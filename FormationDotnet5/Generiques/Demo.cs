using Microsoft.CSharp;

namespace FormationDotnet5.Generiques
{
    public class Demo<T>
    {
        private int Nombre;
        private int Capacity;
        private T[] Tab;


        public Demo()
        {
            Nombre = 10;
            Tab = new T[Capacity];
        }
    }
}