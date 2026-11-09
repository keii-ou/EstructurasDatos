namespace EstructurasDatos.Logica;

//Clase que implementa un TDA sencillo (Estudiante) mediante encapsulamiento: los campos son privados y solo se modifican a través de propiedades que validan.
//Cada instancia (new Estudiante(...)) se crea en el HEAP; las variables solo guardan una referencia.
public class Estudiante
{
    // Campos privados
    private string nombre = string.Empty;
    private string matricula = string.Empty;
    private double promedio;

    public Estudiante(string nombre, string matricula, double promedio)
    {
        Nombre = nombre;
        Matricula = matricula;
        Promedio = promedio;
    }

    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            nombre = value.Trim();
        }
    }

    public string Matricula
    {
        get => matricula;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La matrícula no puede estar vacía.");
            matricula = value.Trim();
        }
    }

    public double Promedio
    {
        get => promedio;
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("El promedio debe estar entre 0 y 100.");
            promedio = value;
        }
    }

    //Crea un objeto nuevo con los mismos datos
    public Estudiante Clonar() => new Estudiante(Nombre, Matricula, Promedio);

    public override string ToString() => $"{Nombre} ({Matricula}) - Prom. {Promedio:0.0}";
}
