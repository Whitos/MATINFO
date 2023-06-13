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
using MATINFO.Model;

namespace MATINFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public ObservableCollection<CategorieMateriel> LesCategories { get; set; }
        public ObservableCollection<Materiel> LesMateriels { get; set; }
        public ObservableCollection<Personnel> LesPersonnels { get; set; }
        public ObservableCollection<EstAttribue> LesAttributions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            viewModel.LesCategories = CategorieMateriel.FindAll();
            viewModel.LesMateriels = Materiel.FindAll();
            viewModel.LesPersonnels = Personnel.FindAll();

            lvGeneral.Items.Refresh();

            DataAccess accesBD = new DataAccess();
            accesBD.OpenConnection();

            // Test de connexion à la base de données
            //MessageBox.Show("Résultat de la connexion : " + accesBD.OpenConnection());

            LesCategories = CategorieMateriel.FindAll();
            LesMateriels = Materiel.FindAll();
            LesPersonnels = Personnel.FindAll();
            LesAttributions = EstAttribue.FindAll();
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
            //lvGeneral.ItemsSource = viewModel.LesTouts;
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
