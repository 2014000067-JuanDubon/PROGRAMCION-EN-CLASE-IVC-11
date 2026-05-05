internal class Program
{
    private static void Main(string[] args)
    {
        double saldo = 10000;
        int intentos = 0;
        int pinCorrecto = 1234;
        int pin;

        while (intentos<3)
        {
            Console.Write("Ingrese su PIN: ");
            if (int.TryParse(Console.ReadLine(), out pin)) 
            {
                if(pin==pinCorrecto)
                {
                    Console.WriteLine("Acceso Concedido!!!");

                    int opcion = 0;
                    while (opcion!=4)
                    {
                        Console.WriteLine("==============================");
                        Console.WriteLine("      MENÚ PRINCIPAL BI");
                        Console.WriteLine("1- Consultar Saldo");
                        Console.WriteLine("2- Depositar Dinero");
                        Console.WriteLine("3- Retirar Dinero");
                        Console.WriteLine("4- Salir");
                        Console.WriteLine("==============================");
                        Console.WriteLine("Digite una Opcion: [] ");
                        int.TryParse(Console.ReadLine(), out opcion);

                        switch(opcion)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                Console.WriteLine("Gracias por Usar el Cajero");
                                break;
                            default:
                                Console.WriteLine("Opcion Inválida");
                                break;
                        }
                        Console.WriteLine();
                    }
                    return;
                }
                else
                {
                    intentos++;
                    Console.WriteLine("PIN incorrecto, intentos " + intentos + " de 3\n");
                }
            }
            else
            {
                Console.WriteLine("Digite un PIN válido");
            }
        }

        Console.WriteLine("Tarjeta Bloqueada,\nDemasiados intentos fallidos");
        Console.ReadKey();
    }
}