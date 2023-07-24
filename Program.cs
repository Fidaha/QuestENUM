using Enumeration.Models;

namespace Enumeration
{
    public class Program
    {
        public static void Main(string[] args)
        {



            // Instancier une liste de plusieurs utilisateurs avec différentes couleurs
            var utilisateurs = new List<User>
        {
            new User("Doe", "John", ECouleur.ROUGE),
            new User("Gage", "Ava", ECouleur.BLEU),
            new User("Robin", "Bob", ECouleur.JAUNE),
            new User("Abra", "Marya", ECouleur.ROUGE),
            new User("Brown", "Michael", ECouleur.VERT),
            new User("Garcia", "Emma", ECouleur.BLEU),
            new User("Lee", "David", ECouleur.JAUNE)
        };

            // Afficher les informations des utilisateurs
            foreach (var utilisateur in utilisateurs)
            {
                Console.WriteLine($"Prénom: {utilisateur.Prenom}");
                Console.WriteLine($"Nom: {utilisateur.Nom}");
                Console.WriteLine($"Couleur: {utilisateur.Couleur}");
                Console.WriteLine();
            }

            // Compter le nombre d'utilisateurs pour chaque couleur
            int rougeCount = utilisateurs.Count(u => u.Couleur == ECouleur.ROUGE);
            int bleuCount = utilisateurs.Count(u => u.Couleur == ECouleur.BLEU);
            int vertCount = utilisateurs.Count(u => u.Couleur == ECouleur.VERT);
            int jauneCount = utilisateurs.Count(u => u.Couleur == ECouleur.JAUNE);

            // Afficher le nombre d'utilisateurs pour chaque couleur
            Console.WriteLine($"ROUGE: {rougeCount} utilisateur(s)");
            Console.WriteLine($"BLEU: {bleuCount} utilisateur(s)");
            Console.WriteLine($"VERT: {vertCount} utilisateur(s)");
            Console.WriteLine($"JAUNE: {jauneCount} utilisateur(s)");

            Console.ReadLine();
        }
    }
}