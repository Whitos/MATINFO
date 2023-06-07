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
using static MATINFO.MainWindow;
using static MATINFO.PersonnelRep;

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
            LesPersonnels = new ObservableCollection<Personnel>();
            LesPersonnels.Add(new Personnel("nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            LesPersonnels.Add(new Personnel("jean.can@univ-smb.fr", "Can", "Jean"));
            LesPersonnels.Add(new Personnel("nick.chauve@univ-smb.fr", "Chauve", "Nick"));
            LesPersonnels.Add(new Personnel("bert.man@univ-smb.fr", "Man", "Man"));

            DataContext = this;
        }
        public class Personnel
        {
            public string Email { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }

            public Personnel(string email, string nom, string prenom)
            {
                Email = email;
                Nom = nom;
                Prenom = prenom;
            }
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
