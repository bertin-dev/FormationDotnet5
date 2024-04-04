using System;

namespace FormationDotnet5.delegates
{
    public class TrieurDeTableau
    {
        private delegate void DelegateTri(int[] tableau);

        public void DemoTri(int[] tableau)
        {
            TrierEtAfficher(tableau, delegate(int[] leTableau)
            {
                Array.Sort(leTableau);
            });

            Console.WriteLine();

            TrierEtAfficher(tableau, delegate(int[] leTableau)
            {
                Array.Sort(leTableau);
                Array.Reverse(leTableau);
            });

        }
        
        
        
        private void TrierEtAfficher(int[] tableau, DelegateTri methodeDeTri)
        {
            methodeDeTri(tableau);
            foreach (int i in tableau)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}