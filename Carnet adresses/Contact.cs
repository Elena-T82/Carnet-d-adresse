using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnet_adresses
{
    class Contact : IComparable
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string courriel;
        private string tel;


        //Propriété pour accéder aux atributs de la classe.
        public string Nom { get { return nom; } set { nom = value; } }
        public string Prenom { get { return prenom; } set { prenom = value; } }
        public string Adresse { get { return adresse; } set { adresse = value; } }
        public string Courriel { get { return courriel; } set { courriel = value; } }
        public string Tel { get { return tel; } set { tel = value; } }

        public string NomComplet { get { return nom + " " + prenom; } }
            

        public Contact(string p_nom, string p_prenom, string p_adresse, string p_courriel, string p_tel)
        {
            Nom = p_nom;
            Prenom = p_prenom;
            Adresse = p_adresse;
            Courriel = p_courriel;
            Tel = p_tel;
        }


        public override string ToString()
        {
            return Nom + " | " + Prenom + " | " + Adresse + " | "  + Courriel + " | " + Tel;
        }

        //Permet de comparer et trier le nom complet de chaque contact de la liste
        public int CompareTo(object obj)
        {
            Contact contact = obj as Contact;

            return NomComplet.CompareTo(contact.NomComplet);
        }
    }
}
