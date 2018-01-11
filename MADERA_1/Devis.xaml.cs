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

namespace MADERA_1
{
    /// <summary>
    /// Logique d'interaction pour Devis.xaml
    /// </summary>
    public partial class Devis : Page
    {
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
        }

        private void Gamme_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
            GammeGrid.Visibility = Visibility.Visible;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void GammeRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            GammeGrid.Visibility = Visibility.Hidden;
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = true;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void Finition_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
            FinitionGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
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
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = true;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void Modèle_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
            ModeleGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
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
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = true;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void Couleur_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
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
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = true;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
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

        private void ClientRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            ClientGrid.Visibility = Visibility.Hidden;
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = true;
            Demo.IsEnabled = false;
            Envoi.IsEnabled = false;
        }

        private void Paiement_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
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

        private void PaiementRegister_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer les données saisies
            PaiementGrid.Visibility = Visibility.Hidden;
            BaseGrid.Visibility = Visibility.Visible;
            Gamme.IsEnabled = false;
            Finition.IsEnabled = false;
            Modèle.IsEnabled = false;
            Couleur.IsEnabled = false;
            Client.IsEnabled = false;
            Paiement.IsEnabled = false;
            Demo.IsEnabled = true;
            Envoi.IsEnabled = false;
        }

        private void Demo_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
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
            BaseGrid.Visibility = Visibility.Visible;
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
        }

        private void Envoi_Click(object sender, RoutedEventArgs e)
        {
            BaseGrid.Visibility = Visibility.Hidden;
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
    }
}
