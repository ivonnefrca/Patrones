using Ejercicio4.Core;
using Ejercicio4.Visitors;

class Program
{
    static void Main()
    {
        var root = new Carpeta { Nombre = "root" };
        var docs = new Carpeta { Nombre = "docs" };
        var img = new Carpeta { Nombre = "img" };

        var readme = new Archivo { Nombre = "readme.txt", Bytes = 1200 };
        var logo = new Archivo { Nombre = "logo.png", Bytes = 80000 };

        root.Agregar(docs);
        root.Agregar(img);
        docs.Agregar(readme);
        img.Agregar(logo);

        Console.WriteLine("\n== Calcular tamaño ==");
        var calc = new CalcularTamano();
        root.Aceptar(calc);
        Console.WriteLine($"Total: {calc.Total} bytes\n");

        Console.WriteLine("== Imprimir estructura ==");
        var imprimir = new ImprimirEstructura();
        root.Aceptar(imprimir);
        Console.WriteLine();

        Console.WriteLine("== Renombrar 'docs' ==");
        var renombrar = new RenombrarElemento("documentos");
        docs.Aceptar(renombrar);

        Console.WriteLine("== Mover 'readme.txt' a 'img' ==");
        var mover = new MoverElemento(img);
        readme.Aceptar(mover);

        Console.WriteLine("== Borrar 'img' ==");
        var borrar = new BorrarElemento();
        img.Aceptar(borrar);

        Console.WriteLine("\nFin del programa.");
    }
}
