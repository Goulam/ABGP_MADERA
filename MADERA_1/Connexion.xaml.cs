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
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Page
    {
        Button Menu1;
        Button Menu2;
        Button Menu3;
        public Connexion(Button menu1, Button menu2, Button menu3)
        {
            InitializeComponent();
            this.Menu1 = menu1;
            this.Menu2 = menu2;
            this.Menu3 = menu3;
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            //Vérifier que le mot de passe contient 8 caractères, 1 majuscule, 1 chiffre et 1 caractère spécial


            //Si l'adresse email est bonne et le mot de passe correspond 8 caracteres 1 majuscule 1 chiffre
            if ((Regex.IsMatch(EmailText.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") && (Regex.IsMatch(MDPText.Password, "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^(.{8,15})$"))))
            {
                //requete en base de donnees ou json pour selectionner le user correspondant a l'adresse email et au mot de passe 
                //if (reussi)
                //{
                Menu1.Visibility = Visibility.Visible;
                Menu2.Visibility = Visibility.Visible;
                Menu3.Content = "Deconnexion";
                Accueil1.Visibility = Visibility.Hidden;
                Accueil2.Visibility = Visibility.Visible;
                //} else
                //{
                //erreur de connexion
                //}

            } else
            {
                EmailText.BorderBrush = Brushes.Red;
                MDPText.BorderBrush = Brushes.Red;
            }        
            
            
        }
    }
}
