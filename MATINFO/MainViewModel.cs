using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MATINFO.MainWindow;

namespace MATINFO
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CategorieMateriel> lesCategories;
        private ObservableCollection<Materiel> lesMateriels;
        private ObservableCollection<Personnel> lesPersonnels;
        private ObservableCollection<Attribution> lesAttributions;
        private ObservableCollection<Tout> lesTouts;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<CategorieMateriel> LesCategories
        {
            get { return lesCategories; }
            set
            {
                lesCategories = value;
                OnPropertyChanged(nameof(LesCategories));
            }
        }

        public ObservableCollection<Materiel> LesMateriels
        {
            get { return lesMateriels; }
            set
            {
                lesMateriels = value;
                OnPropertyChanged(nameof(LesMateriels));
            }
        }

        public ObservableCollection<Personnel> LesPersonnels
        {
            get { return lesPersonnels; }
            set
            {
                lesPersonnels = value;
                OnPropertyChanged(nameof(LesPersonnels));
            }
        }

        public ObservableCollection<Attribution> LesAttributions
        {
            get { return lesAttributions; }
            set
            {
                lesAttributions = value;
                OnPropertyChanged(nameof(LesAttributions));
            }
        }

        public ObservableCollection<Tout> LesTouts
        {
            get { return lesTouts; }
            set
            {
                lesTouts = value;
                OnPropertyChanged(nameof(LesTouts));
            }
        }

        public MainViewModel()
        {
            LesCategories = new ObservableCollection<CategorieMateriel>();
            LesMateriels = new ObservableCollection<Materiel>();
            LesPersonnels = new ObservableCollection<Personnel>();
            LesAttributions = new ObservableCollection<Attribution>();
            LesTouts = new ObservableCollection<Tout>();
        }
    }
}

