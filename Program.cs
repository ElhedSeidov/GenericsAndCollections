using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ConsoleApp7
{



    public class ArrayHelper
    {

        public static void Add(ref string[] array,  string plus_value)
        {
            Array.Resize(ref array, array.Length+1);
            array[array.Length-1] = plus_value;

            
            

        }

        public static void Remove(ref string[] array, string minus_value)
        {
            array.Append(null);
            int b = Array.IndexOf(array, minus_value);
            //if (array.Contains(minus_value))
            //{
            //    array[b] = null;

            //}

            for (int i=b+1; i<array.Length; i++)
            {
                if (array[i] == minus_value)
                { array[i] = array[i + 1]; }
                
                 array[i-1] = array[i]; 
            }

            Array.Resize(ref array, array.Length -1);



        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             
            string[] array1 = { "jonh", "brock", "join" };
            ArrayHelper.Add(ref array1, "blur");
            foreach (string item in array1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================================================");

            string[] array2 = { "jomn", "flish", "false", "fakes", "flock","block","brick"};
            ArrayHelper.Remove(ref array2, "false");
            foreach (string item in array2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(array2.Length);

        }
    }
}