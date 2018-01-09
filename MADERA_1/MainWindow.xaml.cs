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
using MahApps.Metro.Controls;

namespace MADERA_1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Connect.Content = "Connexion";
        }

        private void Devis(object sender, RoutedEventArgs e)
        {
            Accueil accueil = new Accueil();
            this.Content = accueil;
        }

        private void New(object sender, RoutedEventArgs e)
        {
            Devis devis = new Devis();
            this.Content = devis;
        }

        private void Connect_Click(object sender, RoutedEventArgs e)
        {
            if(Connect.Content == "Connexion")
            {
                Connexion connexion = new Connexion();
                this.Content = connexion;
                Connect.Content = "Deconnexion";
            } else
            {
                //se déconnecter
                Connect.Content = "Connexion";
            }
        }
    }
}
