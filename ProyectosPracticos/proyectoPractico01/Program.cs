using proyectoPractico01;
using proyectoPractico01.Dominio;
using proyectoPractico01.Servicio;


FacturasServicio facturasServicio = new FacturasServicio();
////UPDATE PREDETERMINADO
//Facturas oFactura = new Facturas();
//oFactura.IdFactura = 6; 
//oFactura.IdDetalle = 1; //SELECCIONAR NUMERO DE DETALLE A CAMBIAR
//oFactura.Cliente = "Federico";
//oFactura.IdArticulo = 5; //TENEMOS 1 2 3 4 5
//oFactura.Cantidad = 10;
//oFactura.IdFormaPago = 5; //TENEMOS 1 2 3 4 5
//oFactura.Fecha = DateTime.Today;
//if (facturasServicio.Save(oFactura))
//{
//    Console.WriteLine("SE CARGO LA FACTURA");
//}
//else
//{
//    Console.WriteLine("NO SE CARGO LA FACTURA");
//}
//Console.ReadLine();

////MOSTRAR FACTURAS POR ID
//List<Facturas> lista = facturasServicio.GetForID(3);
//foreach (Facturas item in lista)
//{
//    Console.WriteLine(item);
//}
//Console.ReadLine();


////MOSTRAR TODAS LAS FACTURAS
//List<Facturas> lista2 = facturasServicio.GetAll();
//foreach (Facturas item in lista2)
//{
//    Console.WriteLine(item);
//}
//Console.ReadLine();

int opcion = 1;
Console.WriteLine("BIENVENIDO AL SISTEMA DE CARGAS DE FACTURAS");
while (opcion != 0)
{
    Console.WriteLine(" ");
    Console.WriteLine("                                                                 __________________________________");
    Console.WriteLine("SELECCIONE QUE ACCION DESEA REALIZAR                            /                                 /");
    Console.WriteLine("--------------------------------------------                   /     sistema de cargas           /");
    Console.WriteLine("[1] CREAR / ACTUALIZAR UNA FACTURA                            /         de facturas v1.1        /");
    Console.WriteLine("[2] MOSTRAR UNA FACTURA SEGUN SU NUMERO                      (                                 (");
    Console.WriteLine("[3] MOSTRAR TODAS LAS FACTURA                                 \\          (0)        (0)        \\");
    Console.WriteLine("[4] BORRAR UNA FACTURA                                         \\       ,                ,       \\");
    Console.WriteLine("                                                                \\       ,,,,,,,,,,,,,,,,         \\");
    Console.WriteLine("[0] SALIR                                                         )                               )");
    Console.WriteLine("--------------------------------------------                     /                                /");
    Console.WriteLine("LE RECOMENDAMOS QUE ANTES DE CREAR UNA FACTURA                  /     by: federico funes 412201  /");
    Console.WriteLine("NUEVA, CONOZCA LAS QUE YA ESTAN CARGADAS PARA                  /________________________________/");
    Console.WriteLine("EVITAR PROBLEMAS DE SOBREESCRIPCION DE DATOS");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine(" ");

    opcion = Convert.ToInt16(Console.ReadLine());

    if (opcion == 1)
    {
        Facturas oFactura = new Facturas();
        Console.WriteLine("ESCRIBA EL NUMERO DE LA FACTURA A CREAR, TENGA EN CUENTA QUE SI ");
        Console.WriteLine("ESCRIBE EL NUMERO DE UNA FACTURA EXISTENTE, ESTA SE ACTUALIZARA");
        oFactura.IdFactura = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("ESCRIBA EL NOMBRE DEL CLIENTE");
        oFactura.Cliente = Console.ReadLine();
        Console.WriteLine("SELECCIONE EL ARTICULO: ");
        Console.WriteLine("[1] CARAMELO");
        Console.WriteLine("[2] CHUPETIN");
        Console.WriteLine("[3] GALLETA");
        Console.WriteLine("[4] ALFAJOR");
        Console.WriteLine("[5] TORTA");
        oFactura.IdArticulo = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("ESCRIBA LA CANTIDAD DEL PRODUCTO");
        oFactura.Cantidad = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("SELECCIONE LA FORMA DE PAGO: ");
        Console.WriteLine("[1] EFECTIVO");
        Console.WriteLine("[2] TRANSFERENCIA");
        Console.WriteLine("[3] DEBITO");
        Console.WriteLine("[4] CREDITO");
        Console.WriteLine("[5] QR");
        oFactura.IdFormaPago = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("ESCRIBA LA FECHA");
        oFactura.Fecha = Convert.ToDateTime(Console.ReadLine());
        if (facturasServicio.Registrar_Editar(oFactura))
        {
            Console.WriteLine("SE CARGO LA FACTURA");
        }
        else
        {
            Console.WriteLine("NO SE CARGO LA FACTURA");
        }
    }
    else if (opcion == 2)
    {
        Console.WriteLine("ESCRIBA EL NUMERO DE FACTURA QUE DESEA VER");
        int ID = Convert.ToInt16(Console.ReadLine());
        List<Facturas> lista = facturasServicio.ConsultarFactura(ID);
        foreach (Facturas item in lista)
        {
            Console.WriteLine(item);
        }
    }
    else if (opcion == 3)
    {
        Console.WriteLine("MOSTRANDO TODAS LAS FACTURAS DE LA BASE DE DATOS");
        List<Facturas> lista = facturasServicio.GetAll();
        foreach (Facturas item in lista)
        {
            Console.WriteLine(item);
        }
    }
    else if (opcion == 4)
    {
        Console.WriteLine("ESCRIBA EL NUMERO DE FACTURA QUE DESEA BORRAR");
        int ID = Convert.ToInt16(Console.ReadLine());
        if (facturasServicio.Delete(ID))
        {
            Console.WriteLine("SE BORRO LA FACTURA");
        }
        else
        {
            Console.WriteLine("NO SE BORRO LA FACTURA");
        }
    }
    else if (opcion == 0)
    {
        Console.WriteLine("SALIENDO");
    }
}