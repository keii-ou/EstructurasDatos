using System.Diagnostics;

namespace EstructurasDatos.Logica;

//Resultado de comparar los dos algoritmos de ordenamiento con un tamaño n
public record ResultadoOrdenamiento(
    int N,
    double MsBurbuja,
    double MsMezcla,
    long ComparacionesBurbuja,
    long ComparacionesMezcla,
    long BytesExtraMezcla,
    bool Correcto);


//Problema: ordenar un arreglo de n enteros.
//Algoritmo A: Burbuja  -> tiempo O(n²), espacio O(1).
//Algoritmo B: Mezcla   -> tiempo O(n log n), espacio O(n).
public static class Algoritmos
{
    //Ordenamiento burbuja con bandera de parada anticipada. Devuelve el número de comparaciones
    public static long OrdenarBurbuja(int[] a)
    {
        long comparaciones = 0;
        int n = a.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool huboIntercambio = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                comparaciones++;
                if (a[j] > a[j + 1])
                {
                    (a[j], a[j + 1]) = (a[j + 1], a[j]);
                    huboIntercambio = true;
                }
            }
            if (!huboIntercambio) break; // mejor caso: arreglo ya ordenado -> n-1 comparaciones
        }
        return comparaciones;
    }

    //Ordenamiento por mezcla. Devuelve el número de comparaciones
    public static long OrdenarMezcla(int[] a)
    {
        long comparaciones = 0;
        if (a.Length < 2) return 0;
        int[] auxiliar = new int[a.Length]; 
        Mezclar(a, auxiliar, 0, a.Length - 1, ref comparaciones);
        return comparaciones;
    }

    private static void Mezclar(int[] a, int[] aux, int inicio, int fin, ref long comparaciones)
    {
        if (inicio >= fin) return;

        int medio = inicio + (fin - inicio) / 2;
        Mezclar(a, aux, inicio, medio, ref comparaciones);   
        Mezclar(a, aux, medio + 1, fin, ref comparaciones);  

        // Combinar las dos mitades ordenadas: Θ(n)
        Array.Copy(a, inicio, aux, inicio, fin - inicio + 1);
        int i = inicio;
        int j = medio + 1;
        for (int k = inicio; k <= fin; k++)
        {
            if (i > medio) a[k] = aux[j++];
            else if (j > fin) a[k] = aux[i++];
            else
            {
                comparaciones++;
                if (aux[i] <= aux[j]) a[k] = aux[i++]; // "<=" mantiene la estabilidad
                else a[k] = aux[j++];
            }
        }
    }

    public static bool EstaOrdenado(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
            if (a[i - 1] > a[i]) return false;
        return true;
    }

    //Genera datos aleatorios y mide ambos algoritmos con la misma entrada
    public static ResultadoOrdenamiento Comparar(int n)
    {
        var azar = new Random(12345); 
        int[] original = new int[n];
        for (int i = 0; i < n; i++) original[i] = azar.Next();

        int[] paraBurbuja = (int[])original.Clone();
        int[] paraMezcla = (int[])original.Clone();

        GC.Collect();
        GC.WaitForPendingFinalizers();

        var cronometro = Stopwatch.StartNew();
        long compBurbuja = OrdenarBurbuja(paraBurbuja);
        cronometro.Stop();
        double msBurbuja = cronometro.Elapsed.TotalMilliseconds;

        long bytesAntes = GC.GetAllocatedBytesForCurrentThread();
        cronometro.Restart();
        long compMezcla = OrdenarMezcla(paraMezcla);
        cronometro.Stop();
        double msMezcla = cronometro.Elapsed.TotalMilliseconds;
        long bytesExtra = GC.GetAllocatedBytesForCurrentThread() - bytesAntes;

        bool correcto = EstaOrdenado(paraBurbuja) && EstaOrdenado(paraMezcla);
        return new ResultadoOrdenamiento(n, msBurbuja, msMezcla, compBurbuja, compMezcla, bytesExtra, correcto);
    }
}
