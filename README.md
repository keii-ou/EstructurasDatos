# Estructuras de datos – Unidad 1

Aplicación de **Windows Forms** (C#, **.NET 10**, Visual Studio) para la Unidad 1:
*Introducción a las estructuras de datos*.

## Requisitos
- Windows 10/11
- Visual Studio con soporte para .NET 10 (carga de trabajo "Desarrollo de escritorio con .NET") o el SDK de .NET 10

## Cómo ejecutar
1. Descomprime el ZIP y abre `EstructurasDatos.sln` en Visual Studio.
2. Presiona **F5** (o desde consola: `dotnet run --project EstructurasDatos`).
3. Para ver el formulario en el diseñador abre `Form1.cs` (se abre en modo Diseño).

## Estructura
```
EstructurasDatos/
├── Form1.cs                 -> lógica de eventos de la interfaz
├── Form1.Designer.cs        -> TODOS los controles (generado por el diseñador)
├── Form1.resx
├── Program.cs
└── Logica/
    ├── Estudiante.cs        -> clase con encapsulamiento (TDA); instancias en el Heap
    ├── NodoEstudiante.cs    -> nodo de lista enlazada (referencias)
    ├── ListaEnlazada.cs     -> TDA lista enlazada (estructura dinámica)
    ├── PruebasMemoria.cs    -> comparación estática vs dinámica (tiempo/memoria/GC)
    └── Algoritmos.cs        -> Burbuja vs Merge sort (Tarea 1.3)
```

## Qué hace cada pestaña
| Pestaña | Contenido | Tarea |
|---|---|---|
| 1. Arreglos y redimensión | Genera arreglos y los redimensiona en ejecución (Array.Resize y copia manual) | 1.2 (punto 1) |
| 2. Memoria dinámica (Heap) | Lista enlazada de objetos `Estudiante`, referencias, recolector de basura | 1.2 (punto 2) |
| 3. Desempeño estático vs dinámico | Mide tiempo, memoria asignada y colecciones del GC | 1.2 (punto 3) |
| 4. Algoritmos | Burbuja O(n²) vs Merge sort O(n log n) | 1.3 (apoyo) |
