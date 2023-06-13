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
using  MATINFO.Metier;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour PersonnelRep.xaml
    /// </summary>
    public partial class PersonnelRep : Window
    {
        public ObservableCollection<Personnel> LesPersonnels { get; set; }
        public PersonnelRep()
        {
            InitializeComponent();

            LesPersonnels = Personnel.FindAll();

            DataContext = this;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (lvPersonnels.SelectedItem != null)
            {
                MessageBoxResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce personnel ?", "Confirmation de suppression", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    LesPersonnels.Remove((Personnel)lvPersonnels.SelectedItem);

                    lvPersonnels.SelectedIndex = 0;
                }
            }
        }
    }
}
