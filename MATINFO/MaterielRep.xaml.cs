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
    /// Logique d'interaction pour MaterielRep.xaml
    /// </summary>
    public partial class MaterielRep : Window
    {
        public ObservableCollection<Materiel> LesMateriels { get; set; }
        public MaterielRep()
        {
            InitializeComponent();
            LesMateriels = new ObservableCollection<Materiel>();
            LesMateriels.Add(new Materiel("ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF"));
            LesMateriels.Add(new Materiel("RJFKF4141454RBG", "MSI ", "F-240FJFJUS"));
            LesMateriels.Add(new Materiel("SKIKD4544118RFG", "CHROMEBOOK", "E-300RUDJKS"));

            DataContext = this;
        }
        public class Materiel
        {
            public string CodeBarre { get; set; }
            public string Nom { get; set; }
            public string ReferenceConstructeur { get; set; }

            public Materiel(string codeBarre, string nom, string referenceConstructeur)
            {
                CodeBarre = codeBarre;
                Nom = nom;
                ReferenceConstructeur = referenceConstructeur;
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
            if (lvMateriel.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce matériel ?", "Confirmation de suppression", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    LesMateriels.Remove((Materiel)lvMateriel.SelectedItem);

                    lvMateriel.SelectedIndex = 0;
                }
            }
        }
    }
}
