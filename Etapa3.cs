class Etapa3
{
    static int[] insertar(int [] arreglo, int valor)
    {
        int[] lista = new int[arreglo.Length + 1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                lista[i] = arreglo[i];
            }
            lista[lista.Length - 1] = valor;
            return lista;
    }
    static int[] eliminar(int[] arreglo, int posicion)
    {
        int[] lista = new int[arreglo.Length - 1];
        int indice = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (i != posicion)
            {
            lista[indice] = arreglo[i];
            indice++;
            }
        }
    return lista;
    }
    static int buscar(int[] arreglo,int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor)
                {
                    return i;
                }
            }
            return -1;
    }
    static void mostrar(int[] arreglo)
    {
        if (arreglo.Length == 0)
            {
                Console.WriteLine("(vacía)");
                return;
            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i] + "  ");
            }
            Console.WriteLine();
    }
    
    public static void Ejecutar()
    {
        int[] lista = new int[0];
        int opcion;

        System.Console.WriteLine("\n--------------- ETAPA 3 ---------------");
        do
        {
            System.Console.WriteLine("\n------------ MENÚ DE OPERACIONES ------------");
            System.Console.WriteLine("1. Insertar un elemento al final");
            System.Console.WriteLine("2. Eliminar un elemento por posición");
            System.Console.WriteLine("3. Buscar un valor y mostrar su posición");
            System.Console.WriteLine("4. Mostrar la lista actualizada");
            System.Console.WriteLine("5. Salir");
            System.Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1 :
                System.Console.WriteLine("Ingrese numero aagregar: ");
                int valor = int.Parse(Console.ReadLine()!);
                lista = insertar(lista, valor);
                System.Console.WriteLine("Agregado correctamente");
                break;

                case 2:
                System.Console.WriteLine($"Ingrese posicion del elemento a eliminar(0 a {lista.Length - 1}:");
                int posicion = int.Parse(Console.ReadLine()!);
                lista = eliminar(lista, posicion);
                System.Console.WriteLine("Elemento eliminado correctamente");
                break;

                case 3:
                System.Console.WriteLine("Ingrese valor a buscar: ");
                int dato=int.Parse(Console.ReadLine());
                int encontrado= buscar(lista,dato);
                if(encontrado != -1)
                    {
                        System.Console.WriteLine($"Encontrado en la posicion: {encontrado}");
                    }
                    else
                    {
                        System.Console.WriteLine("No fue encontrado");
                    }
                break;

                case 4:
                System.Console.WriteLine("Lista actualizada: ");
                mostrar(lista);
                break;
                case 5:
                System.Console.WriteLine(" Saliendo...");
                break;

                default:
                System.Console.WriteLine("Opcion ingresado no valido");
                break;
                }    
            }while (opcion != 5);
    }
}