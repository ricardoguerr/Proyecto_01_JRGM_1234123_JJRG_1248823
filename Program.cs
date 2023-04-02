internal class Program
{
    private static void Main(string[] args)
    {
        // definición de variables para todos los procesos
        int factura = 0;
        double totalpuntos = 0;
        int totalproductos = 0;
        double puntos = 0;
        bool menu = true;

        //Utilización del ciclo while para mostrar siempre el menu
        while (menu)
        {
            Console.Clear();
            Console.WriteLine("                     TIENDAS              ");
            Console.WriteLine("  ^                                    ^");
            Console.WriteLine(" (_)----------------------------------(_)");
            Console.WriteLine(" | / |        /|  /|     /|  |^^^^^^    |   |");
            Console.WriteLine(" |   |       / | / |    / |  |          |   |");
            Console.WriteLine(" | / |      /  |/  |   /  |  |-----|    |   |");
            Console.WriteLine(" |   |     /       |  /---|        |    |   |");
            Console.WriteLine(" |_|    /        | /    |  __|    |_|");
            Console.WriteLine("(__)--------------------------------(__)");
            Console.WriteLine("                Elija una opción");
            Console.WriteLine("");
            Console.WriteLine("                     (0 0)");
            Console.WriteLine("              ---oOO--(_)----oOO---");
            Console.WriteLine("         ╔════════════════════════════╗");
            Console.WriteLine("         ║ 1. Facturación             ║");
            Console.WriteLine("         ║ 2. Reportes de facturación ║");
            Console.WriteLine("         ║ 3. Salir                   ║");
            Console.WriteLine("         ╚════════════════════════════╝");

            int opcion = Convert.ToInt32(Console.ReadLine());
            // ingreso de la variable opcion dentro de un switch para asignar cada caso posible
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    // solicitud de datos del cliente
                    bool vn = true;
                    string nombre = "";
                    // validación que el nombre no sea un número
                    while (vn)
                    {
                        Console.WriteLine("Ingrese su nombre");
                        nombre = Convert.ToString(Console.ReadLine());
                        int valor;
                        if (int.TryParse(nombre, out valor))
                        {
                            // El valor ingresado es un entero
                            Console.WriteLine("Este dato no es válido");
                        }
                        else
                        {
                            vn = false;
                        }
                    }
                    Console.WriteLine("Ingrese su nit");
                    string nit = Console.ReadLine();
                    Console.WriteLine("Ingrese su Correo electrónico");
                    string correo = Convert.ToString(Console.ReadLine());
                    //definición de variables a utilizar durante la facturación
                    bool seguir = true;
                    int codigo;
                    int Caz = 0, Car = 0, Cgama = 0, Ccc = 0, Clbc = 0; // Cantidad de cada producto a comprar 
                    double preciototal = 0;
                    string sn;
                    bool pago = true;
                    bool facturacion = true;
                    factura = factura + 1;//sumar numero de facturas cada vez que se entre al ciclo de facturación 
                    double ppaz = 0, ppar = 0, ppcc = 0, pplbc = 0, ppgama = 0; // Precio por producto o productos del producto elegido
                    facturacion = true; pago = true; seguir = true;
                    Console.Clear();
                    Console.WriteLine("Productos disponibles: ");
                    Console.WriteLine("____________________");
                    Console.WriteLine("|    Producto    |---------- Precio ----------| Código |");
                    Console.WriteLine("|     Azucar     |---------- Q10.80 ----------|   001  |");
                    Console.WriteLine("|      Arroz     |---------- Q3.80  ----------|   002  |");
                    Console.WriteLine("| Galletas  GAMA |---------- Q1.10  ----------|   003  |");
                    Console.WriteLine("|    Coca-Cola   |---------- Q17.00 ----------|   004  |");
                    Console.WriteLine("|      Café      |---------- Q50.00 ----------|   005  |");
                    Console.WriteLine("____________________");
                    // ciclos while para cada paso de la facturación
                    while (facturacion)
                    {
                        while (pago)
                        {

                            while (seguir)
                            {

                                Console.WriteLine("Ingrese el código del producto");
                                codigo = Convert.ToInt32(Console.ReadLine());
                                // Switch para cada codigo existente
                                switch (codigo)
                                {
                                    case 001:
                                        // Declaración de variable que servira para solicitar la cantidad de producto a comprar 
                                        int naz = 0;
                                        bool v1 = true;
                                        // se recibiran solo cantidades enteras
                                        Console.WriteLine("¿Cuántas libras de azúcar desea comprar? SOLO CANTIDADES ENTERAS");
                                        // Validación de ingresar cantidades mayores a 0 
                                        while (v1)
                                        {

                                            naz = Convert.ToInt32(Console.ReadLine());

                                            if (naz > 0)
                                            {
                                                v1 = false;
                                            }
                                            if (naz <= 0)
                                            {
                                                Console.WriteLine("Debe ingresar un número mayor a 0 ");
                                                Console.WriteLine("Ingrese de nuevo el número");
                                            }
                                        }
                                        //Guardar la cantidad ingresada en la cantidad del producto
                                        Caz = Caz + naz;
                                        // Calcular precio por productos comprados del mismo tipo
                                        ppaz = naz * 10.80;
                                        // Guardar, acumular y sumar el precio del producto para el precio total
                                        preciototal = preciototal + ppaz;
                                        do
                                        {
                                            Console.WriteLine("¿Desea ingresar otro producto? s = si, s = no");
                                            sn = Console.ReadLine().ToLower();

                                            if (sn == "s")
                                            {
                                                seguir = true;
                                            }
                                            else if (sn == "n")
                                            {
                                                pago = false;
                                                seguir = false;
                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn != "s" && sn != "n");
                                        break;
                                    case 002:
                                        // Declaración de variable que servira para solicitar la cantidad de producto a comprar 
                                        int nar = 0;
                                        bool v2 = true;
                                        // se recibiran solo cantidades enteras
                                        Console.WriteLine("¿Cuántas libras de arroz desea comprar? SOLO CANTIDADES ENTERAS");
                                        // Validación de ingresar cantidades mayores a 0
                                        while (v2)
                                        {

                                            nar = Convert.ToInt32(Console.ReadLine());

                                            if (nar > 0)
                                            {
                                                v2 = false;
                                            }
                                            if (nar <= 0)
                                            {
                                                Console.WriteLine("Debe ingresar un número mayor a 0 ");
                                                Console.WriteLine("Ingrese de nuevo el número");
                                            }
                                        }
                                        //Guardar la cantidad ingresada en la cantidad del producto
                                        Car = Car + nar;
                                        // Calcular precio por productos comprados del mismo tipo
                                        ppar = nar * 3.80;
                                        // Guardar, acumular y sumar el precio del producto para el precio total
                                        preciototal = preciototal + ppar;
                                        do
                                        {
                                            Console.WriteLine("¿Desea ingresar otro producto? s = si, s = no");
                                            sn = Console.ReadLine().ToLower();

                                            if (sn == "s")
                                            {
                                                seguir = true;
                                            }
                                            else if (sn == "n")
                                            {
                                                pago = false;
                                                seguir = false;
                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn != "s" && sn != "n");
                                        break;
                                    case 003:
                                        // Declaración de variable que servira para solicitar la cantidad de producto a comprar 
                                        int ngama = 0;
                                        bool v3 = true;
                                        // se recibiran solo cantidades enteras
                                        Console.WriteLine("¿Cuántas galletas GAMA desea comprar? ");
                                        // Validación de ingresar cantidades mayores a 0
                                        while (v3)
                                        {
                                            ngama = Convert.ToInt32(Console.ReadLine());

                                            if (ngama > 0)
                                            {
                                                v3 = false;
                                            }
                                            if (ngama <= 0)
                                            {
                                                Console.WriteLine("Debe ingresar un número mayor a 0 ");
                                                Console.WriteLine("Ingrese de nuevo el número");
                                            }
                                        }
                                        //Guardar la cantidad ingresada en la cantidad del producto
                                        Cgama = Cgama + ngama;
                                        // Calcular precio por productos comprados del mismo tipo
                                        ppgama = ngama * 1.10;
                                        // Guardar, acumular y sumar el precio del producto para el precio total
                                        preciototal = preciototal + ppgama;
                                        do
                                        {
                                            Console.WriteLine("¿Desea ingresar otro producto? s = si, s = no");
                                            sn = Console.ReadLine().ToLower();

                                            if (sn == "s")
                                            {
                                                seguir = true;
                                            }
                                            else if (sn == "n")
                                            {
                                                pago = false;
                                                seguir = false;
                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn != "s" && sn != "n");
                                        break;
                                    case 004:
                                        // Declaración de variable que servira para solicitar la cantidad de producto a comprar 
                                        int ncc = 0;
                                        bool v4 = true;
                                        // se recibiran solo cantidades enteras
                                        Console.WriteLine("¿Cuántas Coca-Colas desea comprar? ");
                                        // Validación de ingresar cantidades mayores a 0
                                        while (v4)
                                        {
                                            ncc = Convert.ToInt32(Console.ReadLine());

                                            if (ncc > 0)
                                            {
                                                v4 = false;
                                            }
                                            if (ncc <= 0)
                                            {
                                                Console.WriteLine("Debe ingresar un número mayor a 0 ");
                                                Console.WriteLine("Ingrese de nuevo el número");
                                            }
                                        }
                                        //Guardar la cantidad ingresada en la cantidad del producto
                                        Ccc = Ccc + ncc;
                                        // Calcular precio por productos comprados del mismo tipo
                                        ppcc = ncc * 17.00;
                                        // Guardar, acumular y sumar el precio del producto para el precio total
                                        preciototal = preciototal + ppcc;
                                        do
                                        {
                                            Console.WriteLine("¿Desea ingresar otro producto? s = si, s = no");
                                            sn = Console.ReadLine().ToLower();

                                            if (sn == "s")
                                            {
                                                seguir = true;
                                            }
                                            else if (sn == "n")
                                            {
                                                pago = false;
                                                seguir = false;
                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn != "s" && sn != "n");
                                        break;
                                    case 005:
                                        // Declaración de variable que servira para solicitar la cantidad de producto a comprar 
                                        int nlbc = 0;
                                        bool v5 = true;
                                        // se recibiran solo cantidades enteras
                                        Console.WriteLine("¿Cuántas libras de café desea comprar? SOLO CANTIDADES ENTERAS");
                                        // Validación de ingresar cantidades mayores a 0
                                        while (v5)
                                        {
                                            nlbc = Convert.ToInt32(Console.ReadLine());

                                            if (nlbc > 0)
                                            {
                                                v5 = false;
                                            }
                                            if (nlbc <= 0)
                                            {
                                                Console.WriteLine("Debe ingresar un número mayor a 0 ");
                                                Console.WriteLine("Ingrese de nuevo el número");
                                            }
                                        }
                                        //Guardar la cantidad ingresada en la cantidad del producto
                                        Clbc = Clbc + nlbc;
                                        // Calcular precio por productos comprados del mismo tipo
                                        pplbc = nlbc * 50.00;
                                        // Guardar, acumular y sumar el precio del producto para el precio total
                                        preciototal = preciototal + pplbc;
                                        do
                                        {
                                            Console.WriteLine("¿Desea ingresar otro producto? s = si, s = no");
                                            sn = Console.ReadLine().ToLower();

                                            if (sn == "s")
                                            {
                                                seguir = true;
                                            }
                                            else if (sn == "n")
                                            {
                                                pago = false;
                                                seguir = false;
                                            }
                                            else
                                            {

                                                Console.WriteLine("Entrada no válida. Por favor, ingrese S o N.");
                                            }
                                        } while (sn != "s" && sn != "n");
                                        break;
                                    default:
                                        seguir = false;
                                        Console.WriteLine("Error: el código es desconocido y no puede cobrarse");
                                        break;
                                        // Todas las instrucciones "seguir = false;" se utilizan para salir del ciclo while que realizar la solicitud de productos y cantidad de los mismos

                                }
                            }
                            // Tipo de pago
                            Console.WriteLine("");
                            Console.WriteLine("Total: " + preciototal);
                            Console.WriteLine("Su pago sera con tarjeta de crédito, debito o efectivo?");
                            Console.WriteLine("Tarjeta de crédito = 1");
                            Console.WriteLine("Tarjeta de debito = 2");
                            Console.WriteLine("Efectivo = 3");
                            int op = Convert.ToInt32(Console.ReadLine());
                            pago = true;


                            double preciopuntos = preciototal;
                            switch (op)
                            {
                                case 1:
                                    // se otorgarán puntos al pagar con tarjeta de débito o créditos
                                    if (preciototal >= 10 && preciototal <= 50)//si el precio total esta entre 10 y 50 se otorgará 1 punto por cada 10 
                                    {
                                        preciopuntos = preciopuntos / 10;//dividir la cantidad dentro de 10 para saber cuantas decenas hay 
                                        preciopuntos = Math.Truncate(preciopuntos);// Libreria Math.Truncate utiliazda para obtener solo la parte entera de la división
                                        puntos = preciopuntos * 1;

                                        Console.WriteLine("Sus puntos son: " + puntos);
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        pago = false; //Salir del ciclo de pago
                                        break;
                                    }
                                    else if (preciototal > 50 && preciototal <= 100)//si el precio total esta entre 50 y 100 se otorgarán 2 puntos por cada 10 
                                    {
                                        preciopuntos = preciopuntos / 10;//dividir la cantidad dentro de 10 para saber cuantas decenas hay 
                                        preciopuntos = Math.Truncate(preciopuntos);// Libreria Math.Truncate utiliazda para obtener solo la parte entera de la división
                                        puntos = preciopuntos * 2;
                                        Console.WriteLine("Sus puntos son: " + puntos);
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        pago = false;//Salir del ciclo de pago
                                        break;
                                    }
                                    else if (preciototal > 100)//si el precio total es mayor a 100 se otorgarán 3 puntos por cada 10 
                                    {
                                        preciopuntos = preciopuntos / 10;//dividir la cantidad dentro de 10 para saber cuantas decenas hay 
                                        preciopuntos = Math.Truncate(preciopuntos);// Libreria Math.Truncate utiliazda para obtener solo la parte entera de la división
                                        puntos = preciopuntos * 3;
                                        Console.WriteLine("Sus puntos son: " + puntos);
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        pago = false;//Salir del ciclo de pago
                                        break;
                                    }
                                    else// si es menor a 10 la compra no se otrogarán puntos
                                    {
                                        Console.WriteLine("No sumara puntos");
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        puntos = 0;
                                        pago = false;//Salir del ciclo de pago
                                    }
                                    break;
                                case 2:
                                    if (preciototal >= 10 && preciototal <= 50)//si el precio total esta entre 10 y 50 se otorgará 1 punto por cada 10 
                                    {
                                        preciopuntos = preciopuntos / 10;//dividir la cantidad dentro de 10 para saber cuantas decenas hay 
                                        preciopuntos = Math.Truncate(preciopuntos);// Libreria Math.Truncate utiliazda para obtener solo la parte entera de la división
                                        puntos = preciopuntos * 1;

                                        Console.WriteLine("Sus puntos son: " + puntos);
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        pago = false;//Salir del ciclo de pago

                                    }
                                    else if (preciototal > 50 && preciototal <= 100)//si el precio total esta entre 50 y 100 se otorgarán 2 puntos por cada 10 
                                    {
                                        preciopuntos = preciopuntos / 10;//dividir la cantidad dentro de 10 para saber cuantas decenas hay 
                                        preciopuntos = Math.Truncate(preciopuntos);// Libreria Math.Truncate utiliazda para obtener solo la parte entera de la división
                                        puntos = preciopuntos * 2;
                                        Console.WriteLine("Sus puntos son: " + puntos);
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        pago = false;//Salir del ciclo de pago
                                    }
                                    else if (preciototal > 100)//si el precio total es mayor a 100 se otorgarán 3 puntos por cada 10 
                                    {
                                        preciopuntos = preciopuntos / 10;//dividir la cantidad dentro de 10 para saber cuantas decenas hay 
                                        preciopuntos = Math.Truncate(preciopuntos);// Libreria Math.Truncate utiliazda para obtener solo la parte entera de la división
                                        puntos = preciopuntos * 3;
                                        Console.WriteLine("Sus puntos son: " + puntos);
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        pago = false;//Salir del ciclo de pago
                                    }
                                    else// si es menor a 10 la compra no se otrogarán puntos
                                    {
                                        Console.WriteLine("No sumara puntos");
                                        Console.WriteLine("Presione para continuar con la facturación");
                                        Console.ReadKey();
                                        puntos = 0;
                                        pago = false;//Salir del ciclo de pago
                                    }
                                    break;
                                case 3:// Si se paga con efectivo no se sumarán puntos
                                    Console.WriteLine("No sumara puntos");
                                    Console.WriteLine("Presione para continuar con la facturación");
                                    Console.ReadKey();
                                    puntos = 0;
                                    pago = false;//Salir del ciclo de pago
                                    break;
                                default:
                                    break;
                            }

                        }
                        //Imprimir factura
                        Console.Clear();
                        Console.WriteLine("|----------------------------------------| Tiendas Mas |----------------------------------------|");
                        Console.WriteLine("|---------------------------------------|  Nit: 32521494 |--------------------------------------|");
                        Console.WriteLine("|Factura No. " + factura + " |");
                        Console.WriteLine("" + DateTime.Now.ToString()); // fecha y hora
                        Console.WriteLine("");
                        Console.WriteLine("Cliente:  " + nombre);
                        Console.WriteLine("Nit:" + nit);
                        Console.WriteLine("");
                        Console.WriteLine("Resumen de productos comprados:");
                        if (Caz > 0)//Dar el detalle del producto unicamente si se compraron productos de ese tipo
                        {
                            Console.WriteLine("Libras de azucar |-----| " + Caz + "  |-----| Precio unitario: Q10.80 |-----| Precio total: " + ppaz);
                        }
                        if (Car > 0)//Dar el detalle del producto unicamente si se compraron productos de ese tipo
                        {
                            Console.WriteLine(" Libras de arroz |-----| " + Car + "  |-----| Precio unitario: Q3.80  |-----| Precio total: " + ppar);
                        }
                        if (Cgama > 0)//Dar el detalle del producto unicamente si se compraron productos de ese tipo
                        {
                            Console.WriteLine(" Galletas GAMA   |-----| " + Cgama + "  |-----| Precio unitario: Q1.10  |-----| Precio total: " + ppgama);
                        }
                        if (Ccc > 0)//Dar el detalle del producto unicamente si se compraron productos de ese tipo
                        {
                            Console.WriteLine("  Coca - cola    |-----| " + Ccc + "  |-----| Precio unitario: Q17.00 |-----| Precio total: " + ppcc);
                        }
                        if (Clbc > 0)//Dar el detalle del producto unicamente si se compraron productos de ese tipo
                        {
                            Console.WriteLine(" Libras de café  |-----| " + Clbc + "  |-----| Precio unitario: Q50.00 |-----| Precio total: " + pplbc);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("                                                                          | Puntos:  " + puntos + "|");
                        Console.WriteLine("                                                                          | Total: " + preciototal + "|");
                        totalproductos = totalproductos + Caz + Car + Cgama + Ccc + Clbc; //sumar la cantidad de productos vendidos
                        totalpuntos = totalpuntos + puntos; //sumar la cantidad de puntos otorgados
                        Console.ReadKey();
                        facturacion = false; //Salir del ciclo de facturacion 
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("|----------------------------------------| Reportes de facturación |----------------------------------------|");
                    Console.WriteLine("");
                    Console.WriteLine("¿Qué reporte desea desplegar?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Factura emitidas");
                    Console.WriteLine("2. Total productos vendidos");
                    Console.WriteLine("3. Total puntos otorgados");
                    int rp = Convert.ToInt32(Console.ReadLine());
                    switch (rp)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("|----------------------------------------| Reportes de facturación |----------------------------------------|");
                            Console.WriteLine("");
                            Console.WriteLine("|Facturas emitidas: " + factura + "|");//Imprimir la cantidad de facturas emitidas
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("|----------------------------------------| Reportes de facturación |----------------------------------------|");
                            Console.WriteLine("");
                            Console.WriteLine("|Prodctos vendidos: " + totalproductos + "|");//Imprimir la cantidad de productos vendidos 
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("|----------------------------------------| Reportes de facturación |----------------------------------------|");
                            Console.WriteLine("");
                            Console.WriteLine("|Puntos emitidos:" + totalpuntos + "|");//Imprimir la cantidad de puntos totales otorgados
                            Console.ReadKey();
                            break;
                    }
                    break;
                case 3:
                    menu = false; //Salir del programa
                    break;
            }
        }
    }
}