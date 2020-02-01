using System;

namespace programa_de_lista_de_compras__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.	Debe realizar aplicación que permita administrar el listado de la compra de alimentos, 
            en el mismo podemos agregar alimentos pero cada alimento pertenece a una de estas categorías: frutas, vegetales o lácteos,
            de manera que antes de agregar un alimento al listado debemos saber a cuál categoría pertenece.

            También el sistema permite listar la lista de compra de las siguientes maneras, 
            el sistema nos permite elegir entre listar solo las frutas, solo los vegetales, solo los lácteos o todos los alimentos.

            Podemos editar los alimentos de las diferentes listas de compra, 
            para editar algún alimento primero debemos seleccionar de cual lista es que modificaremos el alimento.

            Finalmente podemos borrar los alimentos de las diferentes listas de compra, 
            para borrar algún alimento primero debemos seleccionar de cual lista es que borraremos el alimento.
             
              
            */

            string[] frutas = new string[10];
            string[] vegetales = new string[10];
            string[] lacteos = new string[10];

            int num1, num2, num3;
            bool cierre = false;
            
            int men1 = 0;
            int men2 = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("lista del supermercado\n ");
                Console.WriteLine("pulse la occion que deseas ejecutar ");
                Console.WriteLine(" 1: listado de compras \n 2: ver la lista de producto\n 3: editar la lista de producto\n 4: borrar los productos de la lista \n 5: salir del programa \n");
                men1 = Int32.Parse(Console.ReadLine());

                switch (men1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("pulse la categoria que desea para introducir el producto en la lista \n ");
                        Console.WriteLine(" 1: lista de frutas \n 2: lista de vegetales \n 3: lista lacteos \n");
                        men2 = Int32.Parse(Console.ReadLine());

                   
                        switch (men2)
                        {
                            case 1:

                                if (string.IsNullOrEmpty(frutas[9]))
                                {
                                    Console.WriteLine("introdusca las frutas que usted necesite");
                                    string fruta = Console.ReadLine();

                                    for (int i = 0; i < frutas.Length; i++)
                                    {

                                        string elemento = frutas[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            frutas[i] = fruta;
                                            break;
                                        }


                                    }

                                }
                                else
                                {
                                    Console.WriteLine("la lista esta llena ");
                                    Console.ReadKey();
                                }



                                break;

                            case 2:
                                if (string.IsNullOrEmpty(frutas[9]))
                                {
                                    Console.WriteLine("introdusca los vegetales que usted necesite");
                                    string vegetal = Console.ReadLine();

                                    for (int i = 0; i < vegetales.Length; i++)
                                    {

                                        string elemento = vegetales[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            vegetales[i] = vegetal;
                                            break;
                                        }


                                    }

                                }
                                else
                                {
                                    Console.WriteLine("la lista esta llena ");
                                    Console.ReadKey();
                                }




                                break;

                            case 3:
                                if (string.IsNullOrEmpty(lacteos[9]))
                                {
                                    Console.WriteLine("introdusca los lacteos que usted necesite");
                                    string lact = Console.ReadLine();

                                    for (int i = 0; i < lacteos.Length; i++)
                                    {

                                        string elemento = lacteos[i];

                                        if (string.IsNullOrEmpty(elemento))
                                        {
                                            lacteos[i] = lact;
                                            break;
                                        }


                                    }

                                }
                                else
                                {
                                    Console.WriteLine("la lista esta llena ");
                                    Console.ReadKey();
                                }




                                break;

                        }

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine("pulse la categoria que desea para ver los productos en la lista \n ");
                        Console.WriteLine(" 1: lista de frutas \n 2: lista de vegetales \n 3: lista lacteos \n 4: todas las listas ");
                        num1 = Int32.Parse(Console.ReadLine());


                        switch (num1)
                        {
                            case 1:

                                Console.WriteLine(" esta es la lista de las frutas \n");
                                for (int i = 0; i < frutas.Length; i++)
                                {

                                    string elemento = frutas[i];

                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }
                                


                                break;

                            case 2:

                                Console.WriteLine(" esta es la lista de las vegetales \n");

                                for (int i = 0; i < vegetales.Length; i++)
                                {

                                    string elemento = vegetales[i];

                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }
                               


                                break;
                            case 3:

                                Console.WriteLine(" esta es la lista de las lacteos \n");

                                for (int i = 0; i < lacteos.Length; i++)
                                {

                                    string elemento = lacteos[i];

                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }

                               

                                break;
                            case 4:

                                Console.WriteLine("esto son todo los productos que estan en la lista");

                                Console.WriteLine(" esta es la lista de las frutas \n");
                                for (int i = 0; i < frutas.Length; i++)
                                {

                                    string elemento = frutas[i];

                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }

                                Console.WriteLine(" esta es la lista de las vegetales \n");

                                for (int i = 0; i < vegetales.Length; i++)
                                {

                                    string elemento = vegetales[i];

                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }

                                Console.WriteLine(" esta es la lista de las lacteos \n");

                                for (int i = 0; i < lacteos.Length; i++)
                                {

                                    string elemento = lacteos[i];

                                    Console.WriteLine((i + 1) + " - " + elemento);
                                }

                                


                                break;

                        }

   

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine("pulse la categoria que desea editar de la lista de productos \n ");
                        Console.WriteLine(" 1: lista de frutas \n 2: lista de vegetales \n 3: lista lacteos \n ");
                        num2 = Int32.Parse(Console.ReadLine());


                        switch (num2)
                        {

                            case 1:

                                if (string.IsNullOrEmpty(frutas[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" esta es la lista de las frutas \n");
                                    for (int i = 0; i < frutas.Length; i++)
                                    {

                                        string elemento = frutas[i];

                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }

                                    Console.WriteLine("introduce el numero de la posicion que deseas cambiar ");
                                   
                                    int nu1 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("introdusca el nuevo nombre del producto a la lista");
                                    string edifrut = Console.ReadLine();
                                    frutas[nu1 - 1] = edifrut;
                                }
                                
                                break;

                            case 2:
                                if (string.IsNullOrEmpty(vegetales[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" esta es la lista de los vegetales \n");
                                    for (int i = 0; i < vegetales.Length; i++)
                                    {

                                        string elemento = vegetales[i];

                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }

                                    Console.WriteLine("introduce el numero de la posicion que deseas cambiar ");

                                    int nu2 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("introdusca el nuevo nombre del producto a la lista");
                                    string edifrut1 = Console.ReadLine();
                                    vegetales[nu2 - 1] = edifrut1;
                                }
                                



                                break;

                            case 3:
                                if (string.IsNullOrEmpty(lacteos[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" esta es la lista de los lacteos \n");
                                    for (int i = 0; i < lacteos.Length; i++)
                                    {

                                        string elemento = lacteos[i];

                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }

                                    Console.WriteLine("introduce el numero de la posicion que deseas cambiar ");

                                    int nu3 = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("introdusca el nuevo nombre del producto a la lista");
                                    string edifrut2 = Console.ReadLine();
                                    lacteos[nu3 - 1] = edifrut2;
                                }
                                
                                break;

                        }

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("pulse la categoria que desea para borrar los productos en la lista \n ");
                        Console.WriteLine(" 1: lista de frutas \n 2: lista de vegetales \n 3: lista lacteos \n 4: borrar todas las listas ");
                        num3 = Int32.Parse(Console.ReadLine());


                        switch (num3)
                        {
                            case 1:
                                if (string.IsNullOrEmpty(frutas[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" esta es la lista de las frutas \n");
                                    for (int i = 0; i < frutas.Length; i++)
                                    {

                                        string elemento = frutas[i];

                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }

                                    Console.WriteLine("introduce el numero de la posicion que deseas borrar ");

                                    int nu1 = Convert.ToInt32(Console.ReadLine());

                                    frutas[nu1 - 1] = null;
                                }
                                


                                break;

                            case 2:
                                if (string.IsNullOrEmpty(vegetales[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" esta es la lista de las frutas \n");
                                    for (int i = 0; i < vegetales.Length; i++)
                                    {

                                        string elemento = vegetales[i];

                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }

                                    Console.WriteLine("introduce el numero de la posicion que deseas borrar ");

                                    int nu2 = Convert.ToInt32(Console.ReadLine());

                                    vegetales[nu2 - 1] = null;
                                }


                                break;


                            case 3:
                                if (string.IsNullOrEmpty(lacteos[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" esta es la lista de las frutas \n");
                                    for (int i = 0; i < lacteos.Length; i++)
                                    {

                                        string elemento = lacteos[i];

                                        Console.WriteLine((i + 1) + " - " + elemento);
                                    }

                                    Console.WriteLine("introduce el numero de la posicion que deseas borrar ");

                                    int nu3 = Convert.ToInt32(Console.ReadLine());

                                    lacteos[nu3 - 1] = null;
                                }


                                break;
                            case 4:


                                if (string.IsNullOrEmpty(frutas[0]))
                                {
                                    Console.WriteLine("no se ha introducido la lista ");

                                }
                                else
                                {
                                    Console.WriteLine(" se ha borado todo la lista de frutas \n");
                                    for (int i = 0; i < frutas.Length; i++)
                                    {

                                        frutas[i] = null;

                                    }
                                    Console.WriteLine(" se ha borado todo la lista de vegetales \n");
                                    for (int i = 0; i < vegetales.Length; i++)
                                    {

                                       vegetales[i] = null;

                                    }
                                    Console.WriteLine(" se ha borado todo la lista lacteo  \n");
                                    for (int i = 0; i < lacteos.Length; i++)
                                    {

                                        lacteos[i] = null;

                                    }
                                }  

                                   break;



                        }

                        break;

                    case 5:
                        cierre = true;
                        break;


                }
       
                if (cierre)
                {
                    Console.WriteLine(" gracias por utilisar nuestro programa (+-+)  ");
                    break;
                }


                Console.ReadKey();

            }
            Console.ReadKey();


        }

       
        
    }
}
