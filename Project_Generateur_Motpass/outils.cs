using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Generateur_Motpass
{
    public static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: Le nombre doit être positif et non nul");
        } 

        public static int DemanderNombreEntre(string question, int min, int max,string  messageErreurPersonnalise = null)
        {
            int nombre = DemanderNombre(question);
            if((nombre>=min) && (nombre)<=max)
            {
                return nombre;
            }
            if(messageErreurPersonnalise == null)
            {
                Console.WriteLine("ERREUR: Le nombre doit etre compris entre  "+ min +" et " +max);
            }
            else
            {
                Console.WriteLine(messageErreurPersonnalise);
            }
            Console.WriteLine();
            return DemanderNombreEntre(question, min, max, messageErreurPersonnalise);
        }

        public static int DemanderNombre(string question)
        {
            while(true)
            {
                Console.WriteLine(question);
                string reponse = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
