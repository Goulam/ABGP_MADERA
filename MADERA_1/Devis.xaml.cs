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
            if (NameProjectText.Text == "" || RefProjectText.Text == "" || DateProjectText.Text == "")
            {
                if (NameProjectText.Text == "")
                {
                    NameProjectText.BorderBrush = Brushes.Red;
                }
                if(RefProjectText.Text == "")
                {
                    RefProjectText.BorderBrush = Brushes.Red;
                }
                if(DateProjectText.Text == "")
                {
                    DateProjectText.BorderBrush = Brushes.Red;
                }
            }
            else
            {
                NomProjet = NameProjectText.Text;
                RefProjet = RefProjectText.Text;
                DateProjet = DateProjectText.Text;

                First.Visibility = Visibility.Hidden;
                Two.Visibility = Visibility.Visible;
            }
            
        }

        private void GammeRegisterView_Click(object sender, RoutedEventArgs e)
        {
            if (GammeProjetChoice.SelectedValue == null)
            {
                GammeProjetChoice.BorderBrush = Brushes.Red;
            }
            else
            {
                GammeProjet = GammeProjetChoice.SelectedValue.ToString();
                MaisonView.Visibility = Visibility.Visible;
                ValidationGamme.Visibility = Visibility.Visible;
            }
        }

        private void GammeRegister_Click(object sender, RoutedEventArgs e)
        {
            //if(MaisonViewChoice == null) {
            //  MaisonViewChoice.BorderBrushes = Brushes.Red
            //} else {
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
            //}
        }

        private void FinitionRegister_Click(object sender, RoutedEventArgs e)
        {
            if (IsolantChoice.SelectedValue == null || CouvertureChoice.SelectedValue == null || RevetementChoice.SelectedValue == null)
            {
                if (IsolantChoice.SelectedValue == null)
                {
                    IsolantChoice.BorderBrush = Brushes.Red;
                }
                if (CouvertureChoice.SelectedValue == null)
                {
                    CouvertureChoice.BorderBrush = Brushes.Red;
                }
                if (RevetementChoice.SelectedValue == null)
                {
                    RevetementChoice.BorderBrush = Brushes.Red;
                }
            }
            else
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
            if(NomClient.Text == "" ||
                PrénomClient.Text == "" ||
                AdresseClient.Text == "" ||
                CPClient.Text == "" ||
                VilleClient.Text == "" ||
                TelephoneClient.Text == "" ||
                EmailClient.Text == "" ||
                Regex.IsMatch(CPClient.Text, @"^\d{5}$") ||
                Regex.IsMatch(TelephoneClient.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$") ||
                Regex.IsMatch(EmailClient.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                if(NomClient.Text == "")
                {
                    NomClient.BorderBrush = Brushes.Red;
                }
                if(PrénomClient.Text == "")
                {
                    PrénomClient.BorderBrush = Brushes.Red;
                }
                if (AdresseClient.Text == "")
                {
                    AdresseClient.BorderBrush = Brushes.Red;
                }
                if (CPClient.Text == "" || Regex.IsMatch(CPClient.Text, @"^\d{5}$"))
                {
                    CPClient.BorderBrush = Brushes.Red;
                }
                if(VilleClient.Text == "")
                {
                    VilleClient.BorderBrush = Brushes.Red;
                }
                if(TelephoneClient.Text == "" || Regex.IsMatch(TelephoneClient.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$"))
                {
                    TelephoneClient.BorderBrush = Brushes.Red;
                }
                if(EmailClient.Text == "" || Regex.IsMatch(EmailClient.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    EmailClient.BorderBrush = Brushes.Red;
                } 
            } else
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

        private void PaiementRegister_Click(object sender, RoutedEventArgs e)
        {
            if(PaimentChoice.SelectedValue == null)
            {
                PaimentChoice.BorderBrush = Brushes.Red;
            } else
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
