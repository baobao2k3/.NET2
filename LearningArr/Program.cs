using System;
namespace LearningArr.Models

{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please enter your number student: ");
            n = Convert.ToInt16(Console.ReadLine());
            Person[] arrPs = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Person ps = new Person();
                ps.EnterData();
                arrPs[i] = ps;
            }

            foreach (Person ps in arrPs)
            {
                System.Console.WriteLine(ps.FullName);
            }

            //update element
            int k;
            Console.WriteLine("Please enter your student update: ");
            k = Convert.ToInt16(Console.ReadLine());
            Person ps = new Person();
            ps.EnterData();
            arrPs[k] = ps;
        }

    }
}




