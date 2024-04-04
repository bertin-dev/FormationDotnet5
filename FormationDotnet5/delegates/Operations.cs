using System;

namespace FormationDotnet5.delegates
{
    public class Operations
    {
        public void DemoOperations()
        {
            double division = Calcul(delegate(int a, int b)
            {
                return (double)a / (double)b;
            }, 4, 5);

            /*double puissance = Calcul(delegate(int a, int b)
            {
                return Math.Pow((double)a, (double)b);
            }, 4, 5);*/


            Func<int, int, double> tri = (a, b) =>
            {
                return Math.Pow((double)a, (double)b);
            };
            double puissance = Calcul(tri, 4, 5);

            Console.WriteLine("Division : " + division);
            Console.WriteLine("Puissance : " + puissance);
        }

        private double Calcul(Func<int, int, double> methodeDeCalcul, int a, int b)
        {
            return methodeDeCalcul(a, b);
        }
    }
}