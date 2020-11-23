using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnet_adresses
{
    public partial class Form1 : Form
    {
        Carnet carnet;

        public Form1()
        {
            InitializeComponent();

            carnet = new Carnet();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            string nom, prenom, adresse, courriel, tel;

            nom = tbNom.Text;
            prenom = tbPrenom.Text;
            adresse = tbAdresse.Text;
            courriel = tbCourriel.Text;
            tel = tbTel.Text;

            //On vérifie que les champs ne sont pas vide
            if(string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(adresse) || string.IsNullOrWhiteSpace(courriel) || string.IsNullOrWhiteSpace(tel))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                carnet.AjouterContact(nom, prenom, adresse, courriel, tel);

                //On vide les champs une fois le contact ajouter
                tbNom.Text = "";
                tbPrenom.Text = "";
                tbAdresse.Text = "";
                tbCourriel.Text = "";
                tbTel.Text = "";
            }

            //Puis on met à jour la liste
            lbContacts.DataSource = null;
            lbContacts.DataSource = carnet.Contact;
        }

        private void btRechercheMail_Click(object sender, EventArgs e)
        {
            string rechercheMail = tbRechercheCourriel.Text;

            List<Contact> ContactMail;

            if(string.IsNullOrWhiteSpace(rechercheMail))
            {
                MessageBox.Show("Veuillez faire une recherche.");
            }
            else
            {
                //On récupère grâce à un indexeur, une liste de contact contenant le mail passé en paramêtre
                ContactMail = carnet[rechercheMail];

                lbContacts.DataSource = null;
                lbContacts.DataSource = ContactMail;
            }
        }

        private void btRechercheNomComplet_Click(object sender, EventArgs e)
        {
            string rechercheNomComplet = tbRechercheNomComplet.Text;

            List<Contact> contactRechercher;

            char separateur = ' ';

            //On sépare le nom et le prénom dans un tableau grâce à notre séparateur.
            string[] NomPrenom = rechercheNomComplet.Split(separateur);

            if(string.IsNullOrWhiteSpace(rechercheNomComplet))
            {
                MessageBox.Show("Veuillez faire une recherche.");
            }
            else
            {
                //Si notre tableau a une longueur differente de 2, cela signifie qu'il y a des champs manquants ou en trop.
                if (NomPrenom.Length == 2)
                {
                    //Grâce à l'indexeur prenant en paramètre le nom et le prénom, on peut récupérer notre contact.
                    contactRechercher = carnet[NomPrenom[0], NomPrenom[1]];

                    lbContacts.DataSource = null;
                    lbContacts.DataSource = contactRechercher;
                }
                else
                {
                    MessageBox.Show("Veuillez saisir un nom complet (Nom Prenom).");
                }
            }
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            //On affiche la liste de base, sans paramêtre de recherche
            lbContacts.DataSource = null;
            lbContacts.DataSource = carnet.Contact;
        }

        private void btTrie_Click(object sender, EventArgs e)
        {
            //On trie la liste
            carnet.Contact.Sort();

            //On met à jour l'affichage de la liste maintenant trier
            lbContacts.DataSource = null;
            lbContacts.DataSource = carnet.Contact;
        }
    }
}
