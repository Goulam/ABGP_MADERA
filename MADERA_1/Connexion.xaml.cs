﻿using System;
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
            if (NameText.Text != "" || MDPText.Text != "")
            {
                Menu1.Visibility = Visibility.Visible;
                Menu2.Visibility = Visibility.Visible;
                Menu3.Content = "Deconnexion";
                this.Content = "Vous êtes connecté(e)";
            } else
            {
                //recommencer
            }
            
            
        }
    }
}
