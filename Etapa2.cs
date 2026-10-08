class Etapa2
{
    public static void Ejecutar()
    {
        System.Console.WriteLine("\n ---------------ETAPA 2---------------");
        int[ , ] matriz= new int[3,3];
        System.Console.WriteLine("\n VALORES A INGRESAR: ");
        System.Console.WriteLine("Ingrese valores para la matriz 3x3: ");
        for(int f=0; f<3; f++)
        {
            for(int c=0; c<3; c++)
            {
                
                matriz[f, c] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("\n MATRIZ: ");
        for(int f=0; f<3; f++)
        {
            for(int c=0; c<3; c++)
            {
                System.Console.Write(matriz[f, c]+"\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("\n SUMA DE VALORES DE LA MATRIZ: ");
        int suma=0;
         for(int f=0; f<3; f++)
        {
            for(int c=0; c<3; c++)
            {
                suma+=matriz[f,c];
            }
        }
        System.Console.WriteLine($"La suma total es: {suma}");
    }
}