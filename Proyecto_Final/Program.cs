using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //desarrollar un programa que pida al usuario un numero impar entre 1 y 11
            //e imprima el cuadrado magico.     
                        
            int menu = 1;
            while (menu <6)
            
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción del MENU para ver el " +
                    "Cuadrado Mágico de su interés:\n");
                Console.WriteLine("|********   MENU    ********| \n" +
                                  "|*                         *| \n" +
                                  "|* 1. (3x3)                *| \n" +
                                  "|* 2. (5x5)                *| \n" +
                                  "|* 3. (7x7)                *| \n" +
                                  "|* 4. (9x9)                *| \n" +
                                  "|* 5. (11x11)              *| \n" +                                  
                                  "|*                         *| \n" +
                                  "|***************************| \n");

                menu = Convert.ToInt32(Console.ReadLine());

                int escala = menu;

                switch (menu)

                {
                    case 1:
                        escala = 3;
                        break;
                    case 2:
                        escala = 5;
                        break;
                    case 3:
                        escala = 7;
                        break;
                    case 4:
                        escala = 9;
                        break;
                    case 5:
                        escala = 11;
                        break;
                      
                    default:                        
                        escala = 1;                        
                        break;                        
                }

                Console.Clear();             

                int contador = 1;
                int[,] matriz = new int[escala, escala];
                int i = 0;
                int j = escala / 2;
                int k = 0;
                int l = 0;

                matriz[i, j] = contador++;

                for (k = i, l = j; contador <= escala * escala; contador++)
                {
                    i--;
                    j++;

                    if (i < 0)
                        i = escala - 1;
                    if (j >= escala)
                        j = 0;

                    if (matriz[i, j] == 0)
                    {
                        matriz[i, j] = contador;
                    }
                    else
                    {
                        k++;
                        if (k >= escala)
                            k = 0;
                        matriz[k, l] = contador;
                        i = k;
                        j = l;
                        continue;
                    }
                    k = i;
                    l = j;                    
                }

                if (escala == 1)
                {
                    Console.WriteLine("**Por favor ingrese un número válido del MENU**\n"+
                        "\n**Vuelva a ingresar al programa**");
                }

                else

                Console.WriteLine("***CUADRADO MAGICO DE (" + escala + " x " + escala + ")***\n");
                for (i = 0; i < escala; i++)
                {
                    for (j = 0; j < escala; j++)
                    {
                        Console.Write(matriz[i, j] + "  ");
                    }
                    Console.Write("\n\n");

                }
                
                Console.ReadKey();                

            }

        }

    }
}
