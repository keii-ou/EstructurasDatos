namespace EstructurasDatos.Logica;


//Nodo de una lista enlazada. Es un objeto en el Heap que guarda:
//Dato: referencia a un objeto Estudiante (también en el Heap).
//Siguiente: referencia al siguiente nodo (null si es el último).

public class NodoEstudiante
{
    public Estudiante Dato { get; }
    public NodoEstudiante? Siguiente { get; set; }

    public NodoEstudiante(Estudiante dato)
    {
        Dato = dato;
    }
}
