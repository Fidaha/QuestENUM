namespace Enumeration.Models
{
    public class User
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public ECouleur Couleur { get; set; }


        public User(string nom, string prenom, ECouleur couleur)
        {
            Nom = nom;
            Prenom = prenom;
            Couleur = couleur;
        }


    }




}
