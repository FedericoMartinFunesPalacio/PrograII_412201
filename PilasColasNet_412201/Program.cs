using PilasNet_412201.Clases;

Pilas pila = new Pilas();
        //¿PILA VACIA?
        if (pila.EstaVacia())
        {
            Console.WriteLine("LISTA VACIA");
        }
        else
        {
            Console.WriteLine("LISTA NO VACIA");
        }

        //AÑADO OBJETO
        if (pila.Añadir("Fede"))
        {
            Console.WriteLine("SE CARGO EL OBJETO");
        }
        else
        {
            Console.WriteLine("NO SE CARGO EL OBJETO");
        }

        //¿PILA VACIA?
        if (pila.EstaVacia())
        {
            Console.WriteLine("LISTA VACIA");
        }
        else
        {
            Console.WriteLine("LISTA NO VACIA");
        }

        Console.WriteLine(pila.Primero());

        //AÑADO OBJETO POR USUARIO
        Console.WriteLine("ESCRIBA UN OBJETO");

        string? objeto = Console.ReadLine();

        if (pila.Añadir(objeto))
        {
            Console.WriteLine("SE CARGO EL OBJETO");
        }
        else
        {
            Console.WriteLine("NO SE CARGO EL OBJETO");
        }

        Console.WriteLine(pila.Primero());

        //EXTRAIGO OBJETOS
        Console.WriteLine("EXTRACCION 1");
        Console.WriteLine(pila.Extraer());

        Console.WriteLine("EXTRACCION 2");
        Console.WriteLine(pila.Extraer());

        //AÑADO MUCHOS OBJETOS
        if (pila.Añadir("TEST 1"))
        {
            Console.WriteLine("SE CARGO EL OBJETO");
        }
        else
        {
            Console.WriteLine("NO SE CARGO EL OBJETO");
        }

        if (pila.Añadir("TEST 2"))
        {
            Console.WriteLine("SE CARGO EL OBJETO");
        }
        else
        {
            Console.WriteLine("NO SE CARGO EL OBJETO");
        }

        if (pila.Añadir("TEST 3"))
        {
            Console.WriteLine("SE CARGO EL OBJETO");
        }
        else
        {
            Console.WriteLine("NO SE CARGO EL OBJETO");
        }

        Console.WriteLine(pila.Primero());

        Console.ReadLine();

//COLA
Colas cola=new Colas();

//¿PILA VACIA?
if (cola.EstaVacia())
{
    Console.WriteLine("cola VACIA");
}
else
{
    Console.WriteLine("cola NO VACIA");
}

//AÑADO OBJETO
if (cola.Añadir("Fede"))
{
    Console.WriteLine("SE CARGO EL OBJETO");
}
else
{
    Console.WriteLine("NO SE CARGO EL OBJETO");
}

//¿PILA VACIA?
if (cola.EstaVacia())
{
    Console.WriteLine("cola VACIA");
}
else
{
    Console.WriteLine("cola NO VACIA");
}

//AÑADO OBJETO POR USUARIO
Console.WriteLine("ESCRIBA UN OBJETO");

string objetot = Console.ReadLine();

if (cola.Añadir(objetot))
{
    Console.WriteLine("SE CARGO EL OBJETO");
}
else
{
    Console.WriteLine("NO SE CARGO EL OBJETO");
}

//EXTRAIGO OBJETOS
Console.WriteLine("EXTRACCION 1");
Console.WriteLine(cola.Extraer());

Console.WriteLine("EXTRACCION 2");
Console.WriteLine(cola.Extraer());

//AÑADO MUCHOS OBJETOS
if (cola.Añadir("TEST 1"))
{
    Console.WriteLine("SE CARGO EL OBJETO");
}
else
{
    Console.WriteLine("NO SE CARGO EL OBJETO");
}

if (cola.Añadir("TEST 2"))
{
    Console.WriteLine("SE CARGO EL OBJETO");
}
else
{
    Console.WriteLine("NO SE CARGO EL OBJETO");
}

if (cola.Añadir("TEST 3"))
{
    Console.WriteLine("SE CARGO EL OBJETO");
}
else
{
    Console.WriteLine("NO SE CARGO EL OBJETO");
}

Console.WriteLine(cola.Primero());

Console.ReadLine();


