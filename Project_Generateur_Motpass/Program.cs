using Project_Generateur_Motpass;

internal class Program
{
    private static void Main(string[] args)
    {
        const int NB_MOTS_DE_PASSE = 10;

        int longeurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

        Console.WriteLine();
        int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
            "1 - Uniquement des caractères en minuscule\n" +
            "2 - Des caractères minuscules et majuscules\n" +
            "3 - Des caractères et des chiffres\n" +
            "4 - Caractères, chiffres et caractères spéciaux\n" +
            "Votre choix : ", 1, 4);


        string minuscules = "abcdefghijklmnopqrstuvwxyz";
        string majuscules = minuscules.ToUpper();
        string chiffres = "0123456789";
        string caracteresSpeciaux = "#&+-@*";
        string alphabet;
        string motDePasse = "";
        Random rand = new Random();

        if (choixAlphabet == 1)
            alphabet = minuscules;
        else if (choixAlphabet == 2)
            alphabet = minuscules + majuscules;
        else if (choixAlphabet == 3)
            alphabet = minuscules + majuscules + chiffres;
        else
            alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;

        int longeurAlphabet = alphabet.Length;

        for (int j = 0; j < NB_MOTS_DE_PASSE; j++)
        {
            motDePasse = "";
            for (int i = 0; i < longeurMotDePasse; i++)
            {
                int index = rand.Next(0, longeurAlphabet);
                motDePasse += alphabet[index];
            }

            Console.WriteLine("Mot de passe : " + motDePasse);
        }

    }
}