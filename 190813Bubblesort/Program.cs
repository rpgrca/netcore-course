using System;
using Bubblesort;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = {"hola", "hala", "habla", "zzz"};

            // for (int i=0; i < palabras.Length-1; i++)
            // {
            //     for(int j=i+1; j < palabras.Length; j++){
            //         if(Comparo(palabras[i], palabras[j]) > 0){
            //             string buffer =palabras[i];
            //             palabras[i] = palabras[j];
            //             palabras[j] =buffer;
            //         }
            //     }
            // }
            BubbleSorter sorter =new BubbleSorter();
            sorter.Sort(palabras, ComparoDesc);

            foreach (var item in palabras)
            {
                Console.WriteLine(item);
            }

        }

        static int ComparoAsc(string a, string b){
            if(a.Length > b.Length){
                return 1;
            } else if(a.Length < b.Length){
                return -1;
            } else{
                return string.Compare(a,b);
            }
        }

        static int ComparoDesc(string a, string b){
            if(a.Length > b.Length){
                return -1;
            } else if(a.Length < b.Length){
                return 1;
            } else{
                return string.Compare(a,b) * -1;
            }
        }
    }
}
