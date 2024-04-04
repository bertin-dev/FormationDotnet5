using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationDotnet5.DesignPatterns.Creation.Singleton1
{
    public class Singleton
    {
        //Première méthode
        /*private static Singleton instance;
        private Singleton() 
        { 
        
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }*/


        //Deuxieme méthode en utilisant les lazy qui se chargeront le ratarder l'instanciation le plus longtemps possible
        private static Lazy<Singleton> instance = new(() => new());

        private Dictionary<string, object> _catchobject;
        private Singleton()
        {
            _catchobject = new();
        }

        public static Singleton GetInstance() => instance.Value;

        public void Add(string key, object obj) => _catchobject.Add(key, obj);

        public object Get(string key)
        {
            if(_catchobject.ContainsKey(key)) return _catchobject[key];
            return null;
        }
    }
}
