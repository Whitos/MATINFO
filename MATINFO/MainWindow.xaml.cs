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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public ObservableCollection<Tout> LesTouts { get; set; }
        public ObservableCollection<CategorieMateriel> LesCategories { get; set; }
        public ObservableCollection<Materiel> LesMateriels { get; set; }
        public ObservableCollection<Personnel> LesPersonnels { get; set; }

        public ObservableCollection<EstAttribue> LesAttributions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            viewModel.LesCategories = lesCategories();
            viewModel.LesMateriels = lesMateriels();
            viewModel.LesPersonnels = lesPersonnels();
            viewModel.LesTouts = lesTouts();

            lvGeneral.Items.Refresh();

            DataAccess accesBD = new DataAccess();
            bool res = accesBD.OpenConnection();
            MessageBox.Show("Résultat de la connexion : " + res);
        }

        public class Tout
        {
            public string NomProduit { get; set; }
            public string CodeBarre { get; set; }
            public string NomMateriel { get; set; }
            public string ReferenceConstructeur { get; set; }
            public string Email { get; set; }
            public string Nom { get; set; }
            public string Prenom { get; set; }

            public Tout(string nomP, string codeBarre, string nomM, string referenceConstructeur, string email, string nom, string prenom)
            {
                NomProduit = nomP;
                CodeBarre = codeBarre;
                NomMateriel = nomM;
                ReferenceConstructeur = referenceConstructeur;
                Email = email;
                Nom = nom;
                Prenom = prenom;
            }
        }  

        private void btCategorie_Click(object sender, RoutedEventArgs e)
        {
            lvGeneral.ItemsSource = viewModel.LesCategories;
        }

        private void btMateriel_Click(object sender, RoutedEventArgs e)
        {
            lvGeneral.ItemsSource = viewModel.LesMateriels;
        }

        private void btPersonnel_Click(object sender, RoutedEventArgs e)
        {
            lvGeneral.ItemsSource = viewModel.LesPersonnels;
        }
        private void btAttribution_Click(object sender, RoutedEventArgs e)
        {
            lvGeneral.ItemsSource = viewModel.LesAttributions;
        }

        private void btTout_Click(object sender, RoutedEventArgs e)
        {
            lvGeneral.ItemsSource = viewModel.LesTouts;
        }


        private ObservableCollection<CategorieMateriel> lesCategories()
        {
            LesCategories = new ObservableCollection<CategorieMateriel>();
            //LesCategories.Add(new CategorieMateriel("PC Portable"));
            //LesCategories.Add(new CategorieMateriel("Téléphone"));
            //LesCategories.Add(new CategorieMateriel("Tablette"));

            return LesCategories;
        }

        private ObservableCollection<Materiel> lesMateriels()
        {
            LesMateriels = new ObservableCollection<Materiel>();
            //LesMateriels.Add(new Materiel("ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF"));
            //LesMateriels.Add(new Materiel("RJFKF4141454RBG", "MSI ", "F-240FJFJUS"));
            //LesMateriels.Add(new Materiel("SKIKD4544118RFG", "CHROMEBOOK", "E-300RUDJKS"));

            return LesMateriels;
        }

        private ObservableCollection<Personnel> lesPersonnels()
        {
            LesPersonnels = new ObservableCollection<Personnel>();
            //LesPersonnels.Add(new Personnel("nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesPersonnels.Add(new Personnel("jean.can@univ-smb.fr", "Can", "Jean"));
            //LesPersonnels.Add(new Personnel("nick.chauve@univ-smb.fr", "Chauve", "Nick"));
            //LesPersonnels.Add(new Personnel("bert.man@univ-smb.fr", "Man", "Man"));

            return LesPersonnels;
        }

        private ObservableCollection<EstAttribue> lesAttributions()
        {
            LesAttributions = new ObservableCollection<EstAttribue>();
            //LesAttributions.Add(new Attribution(new DateTime(2020,02,20),"A signé une décharge admin"));
            //LesAttributions.Add(new Attribution(new DateTime(2090, 11, 06), "A signé une décharge admin"));
            //LesAttributions.Add(new Attribution(new DateTime(2017, 10, 17), "A signé une décharge admin"));

            return LesAttributions;
        }


        private ObservableCollection<Tout> lesTouts()
        {
            LesTouts = new ObservableCollection<Tout>();
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));
            //LesTouts.Add(new Tout("PC Portable", "ZNDNF5679393IFG", "APPLE MACBOOK AIR M2", "A-233RFMZEF", "nicolas.meger@univ-smb.fr", "Meger", "Nicolas"));

            return LesTouts;
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void btnCategorieRep_Click(object sender, RoutedEventArgs e)
        {
            CategorieRep categorieRep = new CategorieRep();
            this.Close();
            categorieRep.Show();
        }

        private void btnMaterielRep_Click(object sender, RoutedEventArgs e)
        {
            MaterielRep materielRep = new MaterielRep();
            this.Close();
            materielRep.Show();
        }

        private void btnPersonnelRep_Click(object sender, RoutedEventArgs e)
        {
            PersonnelRep personnelRep = new PersonnelRep();
            this.Close();
            personnelRep.Show();
        }
    }
}
