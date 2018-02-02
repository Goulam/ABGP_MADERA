using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace MADERA_1
{
    /// <summary>
    /// Logique d'interaction pour Devis.xaml
    /// </summary>
    public partial class Devis : Page
    {
        String NomProjet, RefProjet, DateProjet;
        String GammeProjet;
        String Couleur1, Couleur2, Couleur3;
        String CodePostal, Telephone, Email;

        public Devis()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            //enregistrer
            //envoyer sur le nouvel ecran
            First.Visibility = Visibility.Hidden;
            Two.Visibility = Visibility.Visible;
            NomProjet = NameProjectText.Text;
            RefProjet = RefProjectText.Text;
            DateProjet = DateProjectText.Text;
        }

        private void GammeRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            GammeGrid.Visibility = Visibility.Hidden;
            FinitionGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = true;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void FinitionRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            FinitionGrid.Visibility = Visibility.Hidden;
            ModeleGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = true;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void ModeleRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            ModeleGrid.Visibility = Visibility.Hidden;
            CouleurGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = true;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void CouleurRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            CouleurGrid.Visibility = Visibility.Hidden;
            ClientGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = true;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
            Couleur1 = CouleurUn.SelectedColor.ToString(); 
            Couleur2 = CouleurDeux.SelectedColor.ToString();
            Couleur3 = CouleurTrois.SelectedColor.ToString();
        }


        private void ClientRegister_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(CPClient.Text, @"^\d{5}$"))
            {
                CodePostal = CPClient.Text;
                if (Regex.IsMatch(TelephoneClient.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$"))
                {
                    Telephone = TelephoneClient.Text;
                    if (Regex.IsMatch(EmailClient.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                    {
                        Email = EmailClient.Text;
                        ClientGrid.Visibility = Visibility.Hidden;
                        PaiementGrid.Visibility = Visibility.Visible;
                        Gamme.IsEnabled = false;
                        Finition.IsEnabled = false;
                        Modèle.IsEnabled = false;
                        Couleur.IsEnabled = false;
                        Client.IsEnabled = false;
                        Paiement.IsEnabled = true;
                        Demo.IsEnabled = false;
                        Envoi.IsEnabled = false;
                    }
                }
            }
            else
            {
                CPClient.BorderBrush = Brushes.Red;
                ClientGrid.Visibility = Visibility.Visible;
                Gamme.IsEnabled = false;
                Finition.IsEnabled = false;
                Modèle.IsEnabled = false;
                Couleur.IsEnabled = false;
                Client.IsEnabled = true;
                Paiement.IsEnabled = false;
                Demo.IsEnabled = false;
                Envoi.IsEnabled = false;
            }

        }

        private void PaiementRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            PaiementGrid.Visibility = Visibility.Hidden;
            DemoGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = true;
            Envoi.IsEnabled = false;
        }

        private void DemoRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            DemoGrid.Visibility = Visibility.Hidden;
            EnvoiGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = true;
        }

        private void EnvoiRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            EnvoiGrid.Visibility = Visibility.Hidden;
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
            Démarrer.Visibility = Visibility.Hidden;
        }

        private void GammeReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            GammeGrid.Visibility = Visibility.Hidden;
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = true;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void FinitionReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            FinitionGrid.Visibility = Visibility.Hidden;
            GammeGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = true;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void ModeleReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            ModeleGrid.Visibility = Visibility.Hidden;
            FinitionGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = true;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void CouleurReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            CouleurGrid.Visibility = Visibility.Hidden;
            ModeleGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = true;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void ClientReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            ClientGrid.Visibility = Visibility.Hidden;
            CouleurGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = true;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void PaiementReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            PaiementGrid.Visibility = Visibility.Hidden;
            ClientGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = true;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void DemoReback_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            DemoGrid.Visibility = Visibility.Hidden;
            PaiementGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = true;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void EnvoiReback_Click(object sender, RoutedEventArgs e)
        {
            
            //enregistrer les données saisies
            EnvoiGrid.Visibility = Visibility.Hidden;
            DemoGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = true;
            Envoi.IsEnabled = false;
            
        }

        private void Démarrer_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
            GammeGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = true;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }
    }
}
