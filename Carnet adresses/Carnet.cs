using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnet_adresses
{
    class Carnet
    {
        private List<Contact> contact;

        public Carnet()
        {
            contact = new List<Contact>();
        }

        public List<Contact> Contact { get { return contact; } }


        public void AjouterContact(string p_nom, string p_prenom, string p_adresse, string p_courriel, string p_tel)
        {
            contact.Add(new Contact(p_nom, p_prenom, p_adresse, p_courriel, p_tel));
        }


        //Indexeur permettant de renvoyer nos listes en fonction de paramêtre
        public List<Contact> this[string p_Nom, string p_Prenom]
        {
            get
            {
                List<Contact> result = Contact.FindAll(obj => obj.NomComplet == p_Nom + " " + p_Prenom);
                return result;

            }
        }

        public List<Contact> this[string p_Courriel]
        {
            get
            {
                //Permet de récupérer une liste de contact contenant entièrement ou partiellement le mail en paramêtre
                List<Contact> result = Contact.FindAll(
                    delegate (Contact obj)
                    {
                        if (obj.Courriel.Contains(p_Courriel))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    });

                return result;
            }
        }
    }
}
