class Etapa4
{
    static void Mostrar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "  ");
            }
            Console.WriteLine();
        }

    static int[] Burbuja(int[] arreglo)
        {
            int[] lista = (int[])arreglo.Clone();
            int n = lista.Length;
            
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        // Intercambiar
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
            return lista;
        }
         static int[] Seleccion(int[] arreglo)
        {
            int[] lista = (int[])arreglo.Clone();
            int n = lista.Length;
            
            for (int i = 0; i < n - 1; i++)
            {
                int menor = i;
                
                for (int j = i + 1; j < n; j++)
                {
                    if (lista[j] < lista[menor])
                    {
                        menor = j;
                    }
                }
                
                // Intercambiar con la posición actual
                int temp = lista[menor];
                lista[menor] = lista[i];
                lista[i] = temp;
            }
            return lista;
        }

    public static void Ejecutar()
    {
        int[] numeros = { 12, 3, 45, 7, 22, 8, 34, 19, 5, 28 };
        System.Console.WriteLine("\n--------------- ETAPA 4 ---------------");
        System.Console.WriteLine("\nLista original:");
        Mostrar(numeros);

        System.Console.WriteLine("\n--- ORDENAMIENTO BURBUJA ---");
        int[] ordenadoBurbuja = Burbuja(numeros);
        System.Console.WriteLine("Después de Burbuja:");
        Mostrar(ordenadoBurbuja);

        System.Console.WriteLine("\n--- ORDENAMIENTO POR SELECCIÓN ---");
        int[] ordenadoSeleccion = Seleccion(numeros);
         System.Console.WriteLine("Después de Selección:");
        Mostrar(ordenadoSeleccion);

         Console.WriteLine("\n--------------- COMPARACIÓN ---------------");
            bool iguales = true;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (ordenadoBurbuja[i] != ordenadoSeleccion[i])
                {
                    iguales = false;
                    break;
                }
            }
            
            if (iguales)
        {
            Console.WriteLine("Ambos metods dan el mismo resultado");
        }
        else
        {
             Console.WriteLine("Los dos dan diferentes resultados");
        }

    }
}
