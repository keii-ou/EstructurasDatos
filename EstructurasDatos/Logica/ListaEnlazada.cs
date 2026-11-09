namespace EstructurasDatos.Logica;


//TDA Lista (implementación con nodos enlazados): estructura lineal y dinámica.
//La interfaz pública oculta cómo se enlazan los nodos internamente (encapsulamiento).


public class ListaEnlazada
{
    public NodoEstudiante? Cabeza { get; private set; }
    public NodoEstudiante? Cola { get; private set; }
    public int Cantidad { get; private set; }

    //Inserción al inicio: O(1)
    public void InsertarInicio(Estudiante estudiante)
    {
        var nodo = new NodoEstudiante(estudiante) { Siguiente = Cabeza };
        Cabeza = nodo;
        Cola ??= nodo;
        Cantidad++;
    }

    //Inserción al final (se conserva referencia a la cola): O(1)
    public void InsertarFinal(Estudiante estudiante)
    {
        var nodo = new NodoEstudiante(estudiante);
        if (Cola is null)
        {
            Cabeza = nodo;
            Cola = nodo;
        }
        else
        {
            Cola.Siguiente = nodo;
            Cola = nodo;
        }
        Cantidad++;
    }

    //Elimina el nodo con la matrícula indicada: O(n) por la búsqueda.
    //Al desenlazarlo, el nodo queda sin referencias y el recolector de basura (GC) lo reclamará.
    public bool Eliminar(string matricula)
    {
        string buscada = matricula.Trim();
        NodoEstudiante? previo = null;
        NodoEstudiante? actual = Cabeza;

        while (actual is not null &&
               !string.Equals(actual.Dato.Matricula, buscada, StringComparison.OrdinalIgnoreCase))
        {
            previo = actual;
            actual = actual.Siguiente;
        }

        if (actual is null) return false;

        if (previo is null) Cabeza = actual.Siguiente;
        else previo.Siguiente = actual.Siguiente;

        if (ReferenceEquals(actual, Cola)) Cola = previo;

        actual.Siguiente = null;
        Cantidad--;
        return true;
    }

    //Búsqueda secuencial: O(n).
    public NodoEstudiante? Buscar(string matricula)
    {
        string buscada = matricula.Trim();
        NodoEstudiante? actual = Cabeza;
        while (actual is not null)
        {
            if (string.Equals(actual.Dato.Matricula, buscada, StringComparison.OrdinalIgnoreCase))
                return actual;
            actual = actual.Siguiente;
        }
        return null;
    }

    //Suelta la referencia a la cabeza: todos los nodos quedan elegibles para el GC.
    public void Vaciar()
    {
        Cabeza = null;
        Cola = null;
        Cantidad = 0;
    }

    //Recorrido de la lista nodo por nodo.
    public IEnumerable<NodoEstudiante> Nodos()
    {
        NodoEstudiante? actual = Cabeza;
        while (actual is not null)
        {
            yield return actual;
            actual = actual.Siguiente;
        }
    }
}
