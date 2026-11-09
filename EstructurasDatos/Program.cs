namespace EstructurasDatos;

internal static class Program
{
  
    // Punto de entrada de la aplicación.

    [STAThread]
    private static void Main()
    {
        // Configuración estándar de Windows Forms (DPI, fuentes, estilos visuales).
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
