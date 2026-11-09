using System.Runtime.CompilerServices;
using EstructurasDatos.Logica;

namespace EstructurasDatos;

/// Formulario principal. Todos los controles están definidos en Form1.Designer.cs (diseñador);
//Pestaña 1: arreglos (memoria estática) que se generan y redimensionan en ejecución.
//Pestaña 2: memoria dinámica con instancias y referencias en el Heap (lista enlazada).
//Pestaña 3: pruebas de desempeño estático vs dinámico.
//Pestaña 4: comparación de algoritmos de ordenamiento (apoyo de la Tarea 1.3).
public partial class Form1 : Form
{
    // ---------- Estado de la pestaña 1 ----------
    private int[] arreglo = Array.Empty<int>();
    private int preservados;               // cuántos elementos del arreglo tienen un valor "real"

    // ---------- Estado de la pestaña 2 ----------
    private readonly ListaEnlazada lista = new();

    private readonly Random azar = new();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        Log1("Genera un arreglo para comenzar. Un arreglo ocupa un bloque contiguo del Heap y su tamaño es fijo.");
        Log2("Inserta estudiantes: cada 'new Estudiante' y cada nodo son objetos independientes en el Heap.");
        Log3("Presiona 'Ejecutar pruebas' para comparar estructuras estáticas y dinámicas.");
        txtLog4.Text = "Burbuja: tiempo O(n²), espacio O(1), estable.\r\n" +
                       "Merge sort: tiempo O(n log n), espacio O(n), estable.\r\n" +
                       "Presiona 'Comparar' para medir ambos con la misma entrada.\r\n";
        ActualizarMemoria();
    }

  
    //  Utilidades
    private static string Hash(object objeto) => "0x" + RuntimeHelpers.GetHashCode(objeto).ToString("X8");

    private static void Escribir(TextBox caja, string mensaje) =>
        caja.AppendText($"[{DateTime.Now:HH:mm:ss}] {mensaje}{Environment.NewLine}");

    private void Log1(string m) => Escribir(txtLog1, m);
    private void Log2(string m) => Escribir(txtLog2, m);
    private void Log3(string m) => Escribir(txtLog3, m);

    //  PESTAÑA 1: arreglos generados y redimensionados en tiempo de ejecución
    private void btnGenerar_Click(object? sender, EventArgs e)
    {
        int n = (int)nudTamanio.Value;

        // 'new int[n]' reserva en el Heap un bloque contiguo de n enteros. Su longitud ya no puede cambiar.
        arreglo = new int[n];
        for (int i = 0; i < n; i++)
            arreglo[i] = azar.Next(1, 1000);
        preservados = n;

        RefrescarArreglo();
        Log1($"new int[{n}] -> bloque contiguo en el Heap (~{(long)n * sizeof(int):N0} bytes de datos). " +
             $"Tamaño FIJO. Referencia: {Hash(arreglo)}");
    }

    private void btnRedimensionar_Click(object? sender, EventArgs e)
    {
        if (arreglo.Length == 0)
        {
            MessageBox.Show("Primero genera un arreglo.", "Sin arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int nuevoTamano = (int)nudNuevoTam.Value;
        int[] anterior = arreglo;
        int tamanoAnterior = anterior.Length;
        string hashAnterior = Hash(anterior);

        // Array.Resize NO agranda el arreglo en sitio: crea uno nuevo, copia los datos y reemplaza la referencia.
        Array.Resize(ref arreglo, nuevoTamano);
        preservados = Math.Min(tamanoAnterior, nuevoTamano);
        bool mismaReferencia = ReferenceEquals(anterior, arreglo);

        RefrescarArreglo();

        if (mismaReferencia)
        {
            Log1($"Mismo tamaño ({nuevoTamano}): Array.Resize no hizo nada; la referencia sigue siendo {hashAnterior}.");
        }
        else
        {
            Log1($"Array.Resize {tamanoAnterior} -> {nuevoTamano}: se creó un arreglo NUEVO y se copiaron " +
                 $"{preservados} elementos (costo O(n)). Referencia anterior {hashAnterior} -> nueva {Hash(arreglo)}. " +
                 $"ReferenceEquals = {mismaReferencia}.");
            if (nuevoTamano > tamanoAnterior)
                Log1($"Las {nuevoTamano - tamanoAnterior} posiciones nuevas se inicializan en 0.");
            else
                Log1($"Se descartaron {tamanoAnterior - nuevoTamano} elementos; el arreglo anterior quedó sin referencias (GC).");
        }
    }

    private void btnAgregar_Click(object? sender, EventArgs e)
    {
        // Redimensión MANUAL: nuevo arreglo de tamaño +1 y copia elemento por elemento.
        int[] anterior = arreglo;
        int[] nuevo = new int[anterior.Length + 1];
        for (int i = 0; i < anterior.Length; i++)
            nuevo[i] = anterior[i];

        int valor = azar.Next(1, 1000);
        nuevo[nuevo.Length - 1] = valor;

        arreglo = nuevo;
        preservados = nuevo.Length;

        RefrescarArreglo();
        Log1($"Agregar {valor}: se copiaron {anterior.Length} elementos a un arreglo nuevo de {nuevo.Length} " +
             $"(O(n) por inserción; n inserciones => O(n²)). Referencia {Hash(anterior)} -> {Hash(nuevo)}.");
    }

    private void btnLimpiarLog1_Click(object? sender, EventArgs e) => txtLog1.Clear();

    private void RefrescarArreglo()
    {
        RefrescarListaArreglo();
        lblInfoArr.Text = $"Longitud: {arreglo.Length} | Referencia: {Hash(arreglo)} | " +
                          $"Datos: {(long)arreglo.Length * sizeof(int):N0} bytes";
    }

    private void RefrescarListaArreglo()
    {
        lst1.BeginUpdate();
        lst1.Items.Clear();
        for (int i = 0; i < arreglo.Length; i++)
        {
            string estado = i < preservados ? "Valor existente" : "Espacio nuevo (0 por defecto)";
            lst1.Items.Add(new ListViewItem(new[] { i.ToString(), arreglo[i].ToString(), estado }));
        }
        lst1.EndUpdate();
    }

    //  PESTAÑA 2: memoria dinámica (instancias y referencias en el Heap)
    private void btnInsertarInicio_Click(object? sender, EventArgs e) => Insertar(alInicio: true);

    private void btnInsertarFinal_Click(object? sender, EventArgs e) => Insertar(alInicio: false);

    private void Insertar(bool alInicio)
    {
        try
        {
            // 'new' crea el objeto en el Heap; 'estudiante' solo guarda su referencia.
            var estudiante = new Estudiante(txtNombre.Text, txtMatricula.Text, (double)nudPromedio.Value);

            if (lista.Buscar(estudiante.Matricula) is not null)
            {
                MessageBox.Show("Ya existe un estudiante con esa matrícula.", "Matrícula duplicada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (alInicio) lista.InsertarInicio(estudiante);
            else lista.InsertarFinal(estudiante);

            Log2($"{(alInicio ? "Insertado al inicio" : "Insertado al final")}: {estudiante} -> objeto {Hash(estudiante)} en el Heap.");
            txtNombre.Clear();
            txtMatricula.Clear();
            txtNombre.Focus();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        RefrescarLista();
        ActualizarMemoria();
    }

    private void btnEliminar_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMatricula.Text))
        {
            MessageBox.Show("Escribe la matrícula del estudiante a eliminar.", "Falta matrícula",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string matricula = txtMatricula.Text.Trim();
        if (lista.Eliminar(matricula))
            Log2($"Eliminado el nodo con matrícula {matricula}: ya nadie lo referencia -> elegible para el recolector de basura.");
        else
            Log2($"No se encontró la matrícula {matricula}.");

        RefrescarLista();
        ActualizarMemoria();
    }

    private void btnVaciar_Click(object? sender, EventArgs e)
    {
        lista.Vaciar();
        Log2("Lista vaciada: se soltó la referencia a la cabeza; todos los nodos quedaron sin referencias.");
        RefrescarLista();
        ActualizarMemoria();
    }

    private void btnReferencias_Click(object? sender, EventArgs e)
    {
        var a = new Estudiante("Demo", "DEMO-1", 90);
        Estudiante b = a;              // copia de la REFERENCIA: ambas variables apuntan al mismo objeto
        Estudiante c = a.Clonar();     // objeto NUEVO con los mismos datos

        b.Promedio = 100;              // se modifica el objeto a través de 'b'

        Log2("--- Demostración de referencias ---");
        Log2($"a -> {Hash(a)} | b = a -> {Hash(b)} | c = a.Clonar() -> {Hash(c)}");
        Log2($"ReferenceEquals(a, b) = {ReferenceEquals(a, b)}  (mismo objeto en el Heap)");
        Log2($"ReferenceEquals(a, c) = {ReferenceEquals(a, c)}  (objetos distintos con los mismos datos)");
        Log2($"Tras 'b.Promedio = 100': a.Promedio = {a.Promedio}, c.Promedio = {c.Promedio} (a cambió, c no).");
    }

    private void btnWeak_Click(object? sender, EventArgs e)
    {
        WeakReference referenciaDebil = CrearObjetoTemporal();
        Log2($"Antes de la recolección: ¿objeto temporal vivo? {referenciaDebil.IsAlive}");

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Log2($"Después de GC.Collect(): ¿objeto temporal vivo? {referenciaDebil.IsAlive} " +
             "(sin referencias fuertes, el GC liberó su memoria).");
        ActualizarMemoria();
    }

    // NoInlining evita que el compilador JIT mantenga viva la variable local más tiempo del necesario.
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static WeakReference CrearObjetoTemporal()
    {
        var temporal = new Estudiante("Temporal", "TMP-1", 70);
        return new WeakReference(temporal);
    }

    private void btnGC_Click(object? sender, EventArgs e)
    {
        long antes = GC.GetTotalMemory(false);
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        long despues = GC.GetTotalMemory(true);
        Log2($"GC.Collect(): memoria administrada {antes / 1024.0:N1} KB -> {despues / 1024.0:N1} KB.");
        ActualizarMemoria();
    }

    private void RefrescarLista()
    {
        lst2.BeginUpdate();
        lst2.Items.Clear();
        int posicion = 0;
        foreach (NodoEstudiante nodo in lista.Nodos())
        {
            string siguiente = nodo.Siguiente is null ? "null" : Hash(nodo.Siguiente);
            lst2.Items.Add(new ListViewItem(new[]
            {
                posicion.ToString(),
                nodo.Dato.Nombre,
                nodo.Dato.Matricula,
                nodo.Dato.Promedio.ToString("0.0"),
                Hash(nodo),
                siguiente
            }));
            posicion++;
        }
        lst2.EndUpdate();
    }

    private void ActualizarMemoria()
    {
        lblMemoria.Text = $"Memoria administrada: {GC.GetTotalMemory(false) / 1024.0:N1} KB | " +
                          $"Colecciones GC -> Gen0: {GC.CollectionCount(0)}, Gen1: {GC.CollectionCount(1)}, " +
                          $"Gen2: {GC.CollectionCount(2)} | Nodos en la lista: {lista.Cantidad}";
    }

    //  PESTAÑA 3: desempeño de memoria estática vs dinámica
    private async void btnEjecutarMem_Click(object? sender, EventArgs e)
    {
        int n = (int)nudN.Value;
        btnEjecutarMem.Enabled = false;
        lblEstadoMem.Text = "Ejecutando pruebas...";
        lst3.Items.Clear();

        try
        {
            // Se ejecuta en otro hilo para que la ventana no se congele.
            List<ResultadoMedicion> resultados = await Task.Run(() => PruebasMemoria.EjecutarTodas(n));

            foreach (ResultadoMedicion r in resultados)
            {
                lst3.Items.Add(new ListViewItem(new[]
                {
                    r.Estructura,
                    r.Milisegundos.ToString("N2"),
                    (r.BytesAsignados / 1024.0).ToString("N1"),
                    r.Gen0.ToString(),
                    r.Gen1.ToString(),
                    r.Gen2.ToString(),
                    r.Complejidad,
                    r.Verificacion.ToString()
                }));
            }

            ResultadoMedicion masRapido = resultados.MinBy(r => r.Milisegundos)!;
            ResultadoMedicion masLento = resultados.MaxBy(r => r.Milisegundos)!;
            ResultadoMedicion menosMemoria = resultados.MinBy(r => r.BytesAsignados)!;
            ResultadoMedicion masMemoria = resultados.MaxBy(r => r.BytesAsignados)!;

            txtLog3.Clear();
            Log3($"N = {n:N0} elementos.");
            Log3($"Más rápido: {masRapido.Estructura} ({masRapido.Milisegundos:N2} ms).");
            Log3($"Más lento: {masLento.Estructura} ({masLento.Milisegundos:N2} ms).");
            Log3($"Menor memoria asignada: {menosMemoria.Estructura} ({menosMemoria.BytesAsignados / 1024.0:N1} KB).");
            Log3($"Mayor memoria asignada: {masMemoria.Estructura} ({masMemoria.BytesAsignados / 1024.0:N1} KB).");
            Log3("Conclusión: la memoria estática (bloque contiguo y tamaño conocido) es la más compacta y rápida; " +
                 "la dinámica da flexibilidad, pero cada redimensión copia datos o cada nodo añade encabezado y referencia en el Heap.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error en las pruebas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnEjecutarMem.Enabled = true;
            lblEstadoMem.Text = "Listo.";
        }
    }

    //  PESTAÑA 4: Burbuja vs Merge sort (apoyo de la Tarea 1.3)
    private async void btnComparar_Click(object? sender, EventArgs e)
    {
        var tamanos = new List<int>();
        string[] partes = txtTamanios.Text.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        foreach (string parte in partes)
        {
            if (!int.TryParse(parte, out int valor) || valor < 2 || valor > 50000)
            {
                MessageBox.Show($"'{parte}' no es válido. Usa enteros entre 2 y 50000 separados por coma.",
                    "Tamaños inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tamanos.Add(valor);
        }

        if (tamanos.Count == 0)
        {
            MessageBox.Show("Escribe al menos un tamaño.", "Sin tamaños", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        btnComparar.Enabled = false;
        lst4.Items.Clear();
        txtLog4.Clear();

        try
        {
            await Task.Run(() => Algoritmos.Comparar(200)); // calentamiento del JIT

            foreach (int n in tamanos)
            {
                lblEstadoAlg.Text = $"Ordenando con n = {n:N0} ...";
                ResultadoOrdenamiento r = await Task.Run(() => Algoritmos.Comparar(n));

                double factor = r.MsBurbuja / Math.Max(r.MsMezcla, 0.001);
                lst4.Items.Add(new ListViewItem(new[]
                {
                    r.N.ToString("N0"),
                    r.MsBurbuja.ToString("N2"),
                    r.MsMezcla.ToString("N2"),
                    r.ComparacionesBurbuja.ToString("N0"),
                    r.ComparacionesMezcla.ToString("N0"),
                    (r.BytesExtraMezcla / 1024.0).ToString("N1"),
                    factor.ToString("N1") + " x"
                }));

                Escribir(txtLog4, $"n = {r.N:N0}: ordenamiento correcto = {r.Correcto}. " +
                                  $"Burbuja {r.MsBurbuja:N2} ms vs Merge {r.MsMezcla:N2} ms.");
            }

            Escribir(txtLog4, "Observa que al duplicar n el tiempo de la burbuja se multiplica por ~4 (O(n²)), " +
                              "mientras que el de merge sort crece un poco más del doble (O(n log n)).");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error en la comparación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnComparar.Enabled = true;
            lblEstadoAlg.Text = "Listo.";
        }
    }
}
