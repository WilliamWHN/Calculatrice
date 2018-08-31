using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApp1
{

    class Program
    {
        #region private attributes
        private static char[] operateur = new char[] { ' ','+', '-', '*', '/' };
        private static float operande1 = 6;
        private static float operande2 = 18;
        private static int operation = 1;
        private static float resultat = 0;
        #endregion private attributes
        static void Main(string[] args)
        {
            Console.Write("Rentrer les deux valeurs : ");
            Console.ReadLine();
            operande1 = Console.Read();
            operande2 = Console.Read();
            for ( operation = 1; operation < 5; operation++)
            {
                resultat = Calcul(operande1, operande2);
                Console.Write("Le résultat du calcul " + operande1 + operateur[operation] + operande2 + " = ");              
                Console.Write(resultat + "\n");           

            }
            Console.ReadLine();


        }
         private static float Calcul (float op1, float op2)
        {
            switch (operation)
            {                         
                case 1 :
                    return op1 + op2;
                case 2:
                    return op1 - op2;
                case 3:
                    return op1 * op2;
                case 4:
                    return op1 / op2;
                default :
                    return -1;
            }

        }

    }
}