using System;
using System.Globalization;

namespace Array_Struct
{
    class Program
    {
     
        
            static void Main(string[] args)
            {
                int pessoa;

                Console.WriteLine("Entre com o número de pessoas: ");            
                pessoa = int.Parse(Console.ReadLine());
                double[] vect = new double[pessoa];                               


                Console.WriteLine("Coloque altura das pessoa em sequência: ");



                for (int i = 0; i < pessoa; i++)
                {
                    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Altura da pessoa " + "(" + i + "): " + vect[i]);
                }

                double soma = 0.0;             


                for (int i = 0; i < pessoa; i++)             
                {
                    soma += vect[i];
                }



                Console.WriteLine("A média de altura das pessoas é = " + soma / pessoa);
            }
        }
    }


