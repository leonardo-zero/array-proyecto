using System;

namespace lista_de_contactos__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              2. Realizar una aplicación que permita administrar una lista de contacto, 
              en este podemos agregar,
              listar, editar y eliminar contactos, 
              la cantidad de contactos maximos es 15.
           
             */

            string[] cont1 = new string[15];
          
            bool cierre = false;


            int men1;
           

            while (true)
            {

                Console.Clear();
                Console.WriteLine("aplicacion de contactos \n");
                Console.WriteLine("selecione la occion que deseas ejecutar : \n ");
                Console.WriteLine(" 1: agregar contactos \n 2: editar contactos \n 3: eliminar contactos \n 4: salir del programa \n ");
                men1 = Convert.ToInt32(Console.ReadLine());

                switch (men1)
                {

                    case 1:
                        if (string.IsNullOrEmpty(cont1[14]))
                        {
                            Console.WriteLine("introdusca el nombre y el numero del contacto :  ");
                            string cont = Console.ReadLine();

                            for (int i = 0; i < cont1.Length; i++)
                            {

                                string elemento = cont1[i];

                                if (string.IsNullOrEmpty(elemento))
                                {
                                    cont1[i] = cont;
                                    break;
                                }


                            }

                        }
                        else
                        {
                            Console.WriteLine("la lista de contactos esta llena ");
                            Console.ReadKey();
                        }




                        break;

                    case 2: 



                        if (string.IsNullOrEmpty(cont1[0]) && string.IsNullOrEmpty(cont1[1]))
                        {
                            Console.WriteLine("no se ha introducido ningun contacto en la lista ");

                        }
                        else
                        {
                            Console.WriteLine(" esta es la lista de contactos actual :\n");
                            for (int i = 0; i < cont1.Length; i++)
                            {

                                string elemento = cont1[i];

                                Console.WriteLine((i + 1) + " : " + elemento);
                            }

                            Console.WriteLine("introduce el numero del contacto que deseas cambiar ");

                            int nu1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("introdusca el nuevo contacto :");
                            string conn1 = Console.ReadLine();
                            cont1[nu1 - 1] = conn1;
                        }



                            break;

                    case 3:



                        if (string.IsNullOrEmpty(cont1[0]) && string.IsNullOrEmpty(cont1[1]))
                        {
                            Console.WriteLine("no se ha introducido ningun contacto en la lista ");

                        }
                        else
                        {
                            Console.WriteLine(" esta es la lista de contactos actual :\n");
                            for (int i = 0; i < cont1.Length; i++)
                            {

                                string elemento = cont1[i];

                                Console.WriteLine((i + 1) + " - " + elemento);
                            }

                            Console.WriteLine("introduce el numero del contacto que deseas cambiar ");

                            int nu1 = Convert.ToInt32(Console.ReadLine());                    
                            cont1[nu1 - 1] = null;
                        }



                        break;



                    case 4:

                        cierre= true;

                        break;



                }
                if (cierre)
                {
                    Console.WriteLine(" gracias por utilisar nuestro programa de contactos (+-+)  ");
                    break;
                }


                Console.ReadKey();

            }
            

        }
    }
}
