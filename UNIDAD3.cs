internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DATOS ACADEMICOS\n Nombre: Juan Dubón"+
            "\nIVC Clave: 11");
        //crea e inicializar el arreglo
        int[] edadPersonas = new int[7];
        int cantidadPersonasMayores = 0;
        int menoresDeEdad=0;
        int i= 0;

        //llenar el arreglo

        for (i = 0; i < edadPersonas.Length; i++) 
        {
            Console.Write("Ingrese la edad de la persona " +(i+1)+ ": ");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());

            if (edadPersonas[i] >= 18)
            {
                cantidadPersonasMayores++;
                //cantidadPersonasMayores=cantidadPersonasMayores+1
            }
            else 
            {
                menoresDeEdad++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad: " +
            cantidadPersonasMayores);
        Console.WriteLine("Cantidad de personas menores de edad: "+
            menoresDeEdad);
        Console.WriteLine("Total de Personas " +i);
    }
}
