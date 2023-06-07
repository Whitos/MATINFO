/***********************************************************************
 * Module:  GestionDonnees.cs
 * Author:  cordellp
 * Purpose: Definition of the Class GestionDonnees
 ***********************************************************************/

using System;
using System.Collections.ObjectModel;

public class GestionDonnees
{
    public GestionDonnees()
    {
        // TODO: implement
    }

    public ObservableCollection<CategorieMateriel> lesCategoriesMateriel { get; set; }
   
    /// <pdGenerated>default getter</pdGenerated>
    public ObservableCollection<CategorieMateriel> GetCategorieMateriel()
    {
        if (lesCategoriesMateriel == null)
            lesCategoriesMateriel = new ObservableCollection<CategorieMateriel>();
        return lesCategoriesMateriel;
    }
   
    /// <pdGenerated>default setter</pdGenerated>
    public void SetCategorieMateriel(ObservableCollection<CategorieMateriel> newCategorieMateriel)
    {
        RemoveAllCategorieMateriel();
        foreach (CategorieMateriel oCategorieMateriel in newCategorieMateriel)
            AddCategorieMateriel(oCategorieMateriel);
    }
   
    /// <pdGenerated>default Add</pdGenerated>
    public void AddCategorieMateriel(CategorieMateriel newCategorieMateriel)
    {
        if (newCategorieMateriel == null)
            return;
        if (this.lesCategoriesMateriel == null)
            this.lesCategoriesMateriel = new ObservableCollection<CategorieMateriel>();
        if (!this.lesCategoriesMateriel.Contains(newCategorieMateriel))
            this.lesCategoriesMateriel.Add(newCategorieMateriel);
    }
   
    /// <pdGenerated>default Remove</pdGenerated>
    public void RemoveCategorieMateriel(CategorieMateriel oldCategorieMateriel)
    {
        if (oldCategorieMateriel == null)
            return;
        if (this.lesCategoriesMateriel != null)
            if (this.lesCategoriesMateriel.Contains(oldCategorieMateriel))
            this.lesCategoriesMateriel.Remove(oldCategorieMateriel);
    }
   
    /// <pdGenerated>default removeAll</pdGenerated>
    public void RemoveAllCategorieMateriel()
    {
        if (lesCategoriesMateriel != null)
            lesCategoriesMateriel.Clear();
    }
    public ObservableCollection<EstAttribue> LesAttributions { get; set; }
   
    /// <pdGenerated>default getter</pdGenerated>
    public ObservableCollection<EstAttribue> GetEstAttribue()
    {
        if (LesAttributions == null)
            LesAttributions = new ObservableCollection<EstAttribue>();
        return LesAttributions;
    }
   
    /// <pdGenerated>default setter</pdGenerated>
    public void SetEstAttribue(ObservableCollection<EstAttribue> newEstAttribue)
    {
        RemoveAllEstAttribue();
        foreach (EstAttribue oEstAttribue in newEstAttribue)
            AddEstAttribue(oEstAttribue);
    }
   
    /// <pdGenerated>default Add</pdGenerated>
    public void AddEstAttribue(EstAttribue newEstAttribue)
    {
        if (newEstAttribue == null)
            return;
        if (this.LesAttributions == null)
            this.LesAttributions = new ObservableCollection<EstAttribue>();
        if (!this.LesAttributions.Contains(newEstAttribue))
            this.LesAttributions.Add(newEstAttribue);
    }
   
    /// <pdGenerated>default Remove</pdGenerated>
    public void RemoveEstAttribue(EstAttribue oldEstAttribue)
    {
        if (oldEstAttribue == null)
            return;
        if (this.LesAttributions != null)
            if (this.LesAttributions.Contains(oldEstAttribue))
            this.LesAttributions.Remove(oldEstAttribue);
    }
   
    /// <pdGenerated>default removeAll</pdGenerated>
    public void RemoveAllEstAttribue()
    {
        if (LesAttributions != null)
            LesAttributions.Clear();
    }
    public ObservableCollection<Materiel> leMateriel  { get; set; }
   
    /// <pdGenerated>default getter</pdGenerated>
    public ObservableCollection<Materiel> GetMateriel()
    {
        if (leMateriel == null)
            leMateriel = new ObservableCollection<Materiel>();
        return leMateriel;
    }
   
    /// <pdGenerated>default setter</pdGenerated>
    public void SetMateriel(ObservableCollection<Materiel> newMateriel)
    {
        RemoveAllMateriel();
        foreach (Materiel oMateriel in newMateriel)
            AddMateriel(oMateriel);
    }
   
    /// <pdGenerated>default Add</pdGenerated>
    public void AddMateriel(Materiel newMateriel)
    {
        if (newMateriel == null)
            return;
        if (this.leMateriel == null)
            this.leMateriel = new ObservableCollection<Materiel>();
        if (!this.leMateriel.Contains(newMateriel))
            this.leMateriel.Add(newMateriel);
    }
   
    /// <pdGenerated>default Remove</pdGenerated>
    public void RemoveMateriel(Materiel oldMateriel)
    {
        if (oldMateriel == null)
            return;
        if (this.leMateriel != null)
            if (this.leMateriel.Contains(oldMateriel))
            this.leMateriel.Remove(oldMateriel);
    }
   
    /// <pdGenerated>default removeAll</pdGenerated>
    public void RemoveAllMateriel()
    {
        if (leMateriel != null)
            leMateriel.Clear();
    }
    public ObservableCollection<Personnel> lePersonnel { get; set; }
   
    /// <pdGenerated>default getter</pdGenerated>
    public ObservableCollection<Personnel> GetPersonnel()
    {
        if (lePersonnel == null)
            lePersonnel = new ObservableCollection<Personnel>();
        return lePersonnel;
    }
   
    /// <pdGenerated>default setter</pdGenerated>
    public void SetPersonnel(ObservableCollection<Personnel> newPersonnel)
    {
        RemoveAllPersonnel();
        foreach (Personnel oPersonnel in newPersonnel)
            AddPersonnel(oPersonnel);
    }
   
    /// <pdGenerated>default Add</pdGenerated>
    public void AddPersonnel(Personnel newPersonnel)
    {
        if (newPersonnel == null)
            return;
        if (this.lePersonnel == null)
            this.lePersonnel = new ObservableCollection<Personnel>();
        if (!this.lePersonnel.Contains(newPersonnel))
            this.lePersonnel.Add(newPersonnel);
    }
   
    /// <pdGenerated>default Remove</pdGenerated>
    public void RemovePersonnel(Personnel oldPersonnel)
    {
        if (oldPersonnel == null)
            return;
        if (this.lePersonnel != null)
            if (this.lePersonnel.Contains(oldPersonnel))
            this.lePersonnel.Remove(oldPersonnel);
    }
   
    /// <pdGenerated>default removeAll</pdGenerated>
    public void RemoveAllPersonnel()
    {
        if (lePersonnel != null)
            lePersonnel.Clear();
    }
}