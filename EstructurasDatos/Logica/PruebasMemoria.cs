using System.Diagnostics;

namespace EstructurasDatos.Logica;

//Resultado de una medición de desempeño
public record ResultadoMedicion(
    string Estructura,
    double Milisegundos,
    long BytesAsignados,
    int Gen0,
    int Gen1,
    int Gen2,
    string Complejidad,
    long Verificacion);

//Nodo de una lista enlazada de enteros (cada nodo es un objeto independiente en el Heap)
public sealed class NodoEntero
{
    public int Valor;
    public NodoEntero? Siguiente;

    public NodoEntero(int valor)
    {
        Valor = valor;
    }
}


//Pruebas que comparan estructuras de memoria estática y dinámica insertando N enteros.

public static class PruebasMemoria
{
    //Ejecuta todas las pruebas (con un calentamiento previo para que el JIT no distorsione)
    public static List<ResultadoMedicion> EjecutarTodas(int n)
    {
        Ejecutar(Math.Min(n, 1000)); // calentamiento: resultados descartados
        return Ejecutar(n);
    }

    private static List<ResultadoMedicion> Ejecutar(int n)
    {
        var resultados = new List<ResultadoMedicion>();

        // 1) Memoria estática: se reserva todo el bloque de una sola vez.
        resultados.Add(Medir("Arreglo estático preasignado (new int[N])", "O(n)", () =>
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = i;
            return a[n - 1];
        }));

        // 2) Arreglo que crece de uno en uno: cada inserción crea un arreglo nuevo y copia todo.
        resultados.Add(Medir("Arreglo +1 por inserción (Array.Resize)", "O(n²)", () =>
        {
            int[] a = Array.Empty<int>();
            for (int i = 0; i < n; i++)
            {
                Array.Resize(ref a, a.Length + 1);
                a[i] = i;
            }
            return a[n - 1];
        }));

        // 3) Arreglo que duplica su capacidad cuando se llena: costo amortizado O(1) por inserción.
        resultados.Add(Medir("Arreglo con duplicación de capacidad", "O(n) amort.", () =>
        {
            int[] a = new int[4];
            int cantidad = 0;
            for (int i = 0; i < n; i++)
            {
                if (cantidad == a.Length) Array.Resize(ref a, a.Length * 2);
                a[cantidad++] = i;
            }
            return a[cantidad - 1];
        }));

        // 4) List<int> del framework (arreglo dinámico interno con duplicación de capacidad).
        resultados.Add(Medir("List<int> (arreglo dinámico de .NET)", "O(n) amort.", () =>
        {
            var lista = new List<int>();
            for (int i = 0; i < n; i++) lista.Add(i);
            return lista[lista.Count - 1];
        }));

        // 5) Lista enlazada: un objeto (nodo) en el Heap por elemento.
        resultados.Add(Medir("Lista enlazada (un nodo en el Heap por elemento)", "O(n)", () =>
        {
            NodoEntero? cabeza = null;
            NodoEntero? cola = null;
            for (int i = 0; i < n; i++)
            {
                var nodo = new NodoEntero(i);
                if (cabeza is null)
                {
                    cabeza = nodo;
                    cola = nodo;
                }
                else
                {
                    cola!.Siguiente = nodo;
                    cola = nodo;
                }
            }
            return cola!.Valor;
        }));

        return resultados;
    }

    //Mide tiempo, bytes asignados y colecciones del GC de una prueba.
    private static ResultadoMedicion Medir(string nombre, string complejidad, Func<int> prueba)
    {
        // Se limpia el Heap antes de medir para partir de condiciones similares.
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        int g0 = GC.CollectionCount(0);
        int g1 = GC.CollectionCount(1);
        int g2 = GC.CollectionCount(2);
        long bytesAntes = GC.GetAllocatedBytesForCurrentThread();

        var cronometro = Stopwatch.StartNew();
        int verificacion = prueba();
        cronometro.Stop();

        long bytesAsignados = GC.GetAllocatedBytesForCurrentThread() - bytesAntes;

        return new ResultadoMedicion(
            nombre,
            cronometro.Elapsed.TotalMilliseconds,
            bytesAsignados,
            GC.CollectionCount(0) - g0,
            GC.CollectionCount(1) - g1,
            GC.CollectionCount(2) - g2,
            complejidad,
            verificacion);
    }
}
