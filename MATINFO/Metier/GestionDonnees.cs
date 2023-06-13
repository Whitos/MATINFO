using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Metier
{
    public class GestionDonnees
    {
        public ObservableCollection<CategorieMateriel> LesCategories { get; set; }
        public ObservableCollection<Materiel> LesMateriels { get; set; }
        public ObservableCollection<Personnel> LesPersonnels { get; set; }
        public ObservableCollection<EstAttribue> LesAttributions { get; set; }

        public GestionDonnees()
        {
            LesCategories = CategorieMateriel.FindAll();
            LesMateriels = Materiel.FindAll();
            LesPersonnels = Personnel.FindAll();
            LesAttributions = EstAttribue.FindAll();
        }
    }
}
