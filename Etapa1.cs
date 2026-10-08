class Etapa1
    {public static void Ejecutar()
        {
            System.Console.WriteLine("\n ---------------ETAPA 1---------------");
            System.Console.WriteLine("NUMEROS YA DECLARADOS: ");
            int[] numeros = { 5, 12, 8, 20, 3, 15, 7, 1, 9, 11 };
            for (int i = 0; i < numeros.Length; i++)
            {
              System.Console.Write(numeros[i] + "  ");            
            }
            System.Console.WriteLine("\n");
            System.Console.WriteLine("MODIFICAR NUMERO");
            System.Console.WriteLine("Ingrese nuevo numero para la posicion 3: ");
            int num=int.Parse(Console.ReadLine());
            numeros[3] = num;
            for (int i = 0; i < numeros.Length; i++)
            {
              System.Console.Write(numeros[i] + "  ");
            }

            System.Console.WriteLine("\n");
            System.Console.WriteLine("Que numero desea bscar:");
            int buscar=int.Parse(Console.ReadLine());
            bool encontrado =false;
            int posicion =-1;
           for (int i = 0; i < numeros.Length; i++)
           {
            if (numeros[i] == buscar)
            {
                encontrado = true;
                posicion = i;
                break;
            }
           }
            if (encontrado)
            {
               System.Console.WriteLine($"Encontrado en posición: {posicion}");
            }
            else
            {
               System.Console.WriteLine("No encontrado");
            }
        }
    }
    