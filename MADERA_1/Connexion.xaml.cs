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
using Web_Service.Entity;
using Web_Service.Model;
using System.Data.SqlClient;
using System.Security.Cryptography;

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
                CommerciauxEntity Commercial = new CommerciauxEntity();

                CommerciauxDAO ComDAO = new CommerciauxDAO();

                Commercial = ComDAO.getActiveCommercialByEmail(EmailText.Text);

                if(Commercial.Com_Identifiant!= "")
                {
                    string Test = ConvertStringtoMD5(MDPText.Password);
                    if (Test == Commercial.Com_Mdp)
                    {
                        Menu1.Visibility = Visibility.Visible;
                        Menu2.Visibility = Visibility.Visible;
                        Menu3.Content = "Deconnexion";
                        Accueil1.Visibility = Visibility.Hidden;
                        Accueil2.Visibility = Visibility.Visible;
                    }
                } 
            } else
            {
                EmailText.BorderBrush = Brushes.Red;
                MDPText.BorderBrush = Brushes.Red;
            }        
            
            
        }

        public static string ConvertStringtoMD5(string strword)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strword);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
