using EjercicioPolimorfismo;


Console.WriteLine("########### INICIO ###########");

Vendedor vendedor = new Vendedor();
Console.WriteLine("Ingrese el Nombre del empleado vendedor: ");

vendedor.PNombre = Console.ReadLine();
Console.WriteLine("Ingrese el Apellido del empleado vendedor: ");

vendedor.PApellido = Console.ReadLine();

Console.WriteLine("Ingrese la identidad del empleado vendedor: ");

vendedor.identidad = Console.ReadLine();
vendedor.Imprimir();

Cajero cajero = new Cajero();

Console.WriteLine("Ingrese el Nombre del empleado cajero: ");

cajero.PNombre = Console.ReadLine();
Console.WriteLine("Ingrese el Apellido del empleado cajero: ");

cajero.PApellido = Console.ReadLine();

Console.WriteLine("Ingrese la identidad del empleado cajero: ");

cajero.identidad = Console.ReadLine();


cajero.Imprimir();