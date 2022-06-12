using System;
using System.Collections;
using System.Collections.Generic;

namespace Beltek66.GenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Deneme<int>();
           

            //int[] isimler = new int[3]; 

            //ArrayList al = new ArrayList();
            //int s = 5;
            //al.Add(s);




            List<string> list = new List<string>();
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Add("Ali");
            list.Capacity = list.Count;
            Console.WriteLine(list.Capacity);
        }
    }

    public class Deneme<T> where T : struct
    {
        public T sayi;


        public void Yazdir()
        {
            Console.WriteLine(this.sayi);
        }
    }
}
