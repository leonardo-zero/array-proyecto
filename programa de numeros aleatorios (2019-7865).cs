using System;

namespace numeros_aleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             3.	Realiza una aplicación que genere un número random del 1-100 y que luego el usuario deba adivinar cuál es número que se generó,
             el mismo solo tendrá 10 oportunidades para adivinar al agotar las 10 oportunidades debe mostrarse cuál era el número y
             preguntarle si quiere volver a jugar si quiere seguir se debe generar un nuevo número random de no querer seguir jugando debe finalizar la aplicación.

             La aplicación debe de darle pista al usuario según qué tan cerca este si está a menos o a 5 números debe decirle que está muy caliente, 
             si está a 10 o menos número que está caliente si está a 20 o menos números que se está acercando si está a 30 o menos que esta frio si esta 50 o menos que está muy frio.

             Ejemplo si el número random es 40 y el usuario ingresa 35 está muy caliente y
             si ingresa 45 también está muy caliente porque en ambos casos está a 5 números del resultado correcto.
             
              */

            Random aleatorio = new Random();
            int[] numeros = new Int32[10];
            int num1, num2;
            int men1, men2;
            bool cierre = false;
            int[] varia = new Int32[8];
            while (true)
            {

                Console.Clear();
                Console.WriteLine("adivina cual es el numero \n");
                Console.WriteLine("seleccione la occion que desea ejecutar : \n");
                Console.WriteLine(" 1: iniciar juego \n 2: finalizar el juego \n");
                men1 = Int32.Parse(Console.ReadLine());

                switch (men1)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("adivina cual es el numero \n");
                        Console.WriteLine("seleccione la occion que desea ejecutar : \n");
                        Console.WriteLine(" 1: nuevo juego \n 2: numero aleatorio de la partida anterior \n");
                        men2 = Int32.Parse(Console.ReadLine());

                        

                        switch (men2)
                        {
                            case 1:
                                num1 = aleatorio.Next(1, 101);
                                
                                varia[0] = num1 - 5;
                                varia[1] = num1 + 5;
                                varia[2] = num1 - 10;
                                varia[3] = num1 + 10;
                                varia[4] = num1 - 20;
                                varia[5] = num1 + 20;
                                varia[6] = num1 - 50;
                                varia[7] = num1 + 50;

                                numeros[0] = num1;

                                Console.Clear();

                                Console.WriteLine(" inicia el juego \n");
                                for (int i = 1; i <= 10; i++)
                                {
                                    Console.WriteLine("introducas el numero : ");

                                    num2 = Int32.Parse(Console.ReadLine());

                                    if (num2 == num1)
                                    {
                                        Console.WriteLine("has encontrado el numero generado {0}", num1);
                                        i = 10;
                                    }

                                    if (num1 != num2)
                                    {
                                        if (i == 10)
                                        {
                                            Console.WriteLine("se han acabado las oportunidades el numero generado era : {0}", num1);
                                        }
                                        else
                                        {
                                            Console.WriteLine("tienes otra oportunidad #{0}", (i + 1));

                                            if (varia[0] <= num2 && varia[1] >= num2)
                                            {
                                                Console.WriteLine(" esta  muy caliente ");

                                            }
                                            else
                                            {
                                                if (varia[2] <= num2 && varia[3] >= num2)
                                                {
                                                    Console.WriteLine(" esta caliente ");

                                                }
                                                else
                                                {
                                                    if (varia[4] <= num2 && varia[5] >= num2)
                                                    {
                                                        Console.WriteLine(" esta  medio ");

                                                    }
                                                    else
                                                    {
                                                        if (varia[6] <= num2 && varia[7] >= num2)
                                                        {
                                                            Console.WriteLine(" esta frio ");

                                                        }
                                                    }
                                                }


                                            }






                                        }

                                    }

                                    
                                }

                                break;


                            case 2:
                                Console.Write("este fue el ultimo numero generado de la partida anterior : ");
                                Console.WriteLine(numeros[0]);
                                break;

                        }
                       

                        Console.ReadKey();

                        break;
                    case 2:

                        cierre = true;



                        break;        

                }

                if (cierre)
                {
                    cierre = false;

                    Console.WriteLine("gracias por jugar \n ");
                    break;
                }



            }
           
            
            Console.ReadKey();
        }
    }
}
