using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour CategorieRep.xaml
    /// </summary>
    public partial class CategorieRep : Window
    {
        public ObservableCollection<Categorie> LesCategories { get; set; }
        public CategorieRep()
        {
            InitializeComponent();
            LesCategories = new ObservableCollection<Categorie>();
            LesCategories.Add(new Categorie("PC Portable"));
            LesCategories.Add(new Categorie("Téléphone"));
            LesCategories.Add(new Categorie("Tablette"));

            DataContext = this;
        }

        public class Categorie
        {
            public string Nom { get; set; }

            public Categorie(string nom)
            {
                Nom = nom;
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (lvCategorie.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette catégorie ?", "Confirmation de suppression", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    LesCategories.Remove((Categorie)lvCategorie.SelectedItem);

                    lvCategorie.SelectedIndex = 0;
                }
            }
        }
    }
}
