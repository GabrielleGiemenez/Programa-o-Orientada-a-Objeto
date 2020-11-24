using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list;
            
            // Criar lista
           
            list = new List<int>(); 
                                          
            //Adicionar elementos
            list.Add(10);
            list.Add(20);
            list.Add(30);

            //Insere elemento em uma posiç~]ao definida 
            list.Insert(2, 22);

            

            // Vê quantos elementos da lista.
            Console.WriteLine("Numero de elementos: " + list.Count); 
            Console.WriteLine("-------------------------");

            //Remover elemento da lista
            list.RemoveAt(3);
            
            //O RemoveAll(Remove determinado elemento da lista), Remove(Remove elementos da lista),
            //e RemoveRange(Remove elementos da lista a partir da posição dos elementos)


            //loop
            foreach (int item in list)
            {
                Console.WriteLine(item);

            }



            Console.ReadKey();




        }
    }
}


