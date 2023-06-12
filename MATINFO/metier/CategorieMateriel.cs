/***********************************************************************
 * Module:  CategorieMateriel.cs
 * Author:  cordellp
 * Purpose: Definition of the Class CategorieMateriel
 ***********************************************************************/

using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

public class CategorieMateriel : IDonnee
{
    public int IDCategorieMateriel { get; set; }
    public string Nom { get; set; }

    public List<Materiel> lesMateriels { get; set; }

    public CategorieMateriel(int idCategorieMateriel, string nom)
    {
        IDCategorieMateriel = idCategorieMateriel;
        Nom = nom;
    }
   
    public void Create()
    {
        // TODO: implement
    }
   
    public IDonnee Read()
    {
        // TODO: implement
        return null;
    }
   
    public void Update()
    {
        // TODO: implement
    }
   
    public void Delete()
    {
        // TODO: implement
    }

    public static ObservableCollection<CategorieMateriel> FindAll()
    {
        ObservableCollection<CategorieMateriel> lesCategories = new ObservableCollection<CategorieMateriel>();
        DataAccess accesBD = new DataAccess();
        string requete = "select idcategoriemateriel, nomcategoriemateriel from categoriemateriel ;";
        DataTable datas = accesBD.GetData(requete)!;
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                CategorieMateriel e = new CategorieMateriel(int.Parse(row["idcategoriemateriel"].ToString()!), (string)row["nomcategoriemateriel"]);
                lesCategories.Add(e);
            }
        }
        return lesCategories;
    }

    /// <pdGenerated>default getter</pdGenerated>
    public List<Materiel> GetMateriel()
    {
        if (lesMateriels == null)
            lesMateriels = new List<Materiel>();
        return lesMateriels;
    }
   
    /// <pdGenerated>default setter</pdGenerated>
    public void SetMateriel(List<Materiel> newMateriel)
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
        if (this.lesMateriels == null)
            this.lesMateriels = new List<Materiel>();
        if (!this.lesMateriels.Contains(newMateriel))
            this.lesMateriels.Add(newMateriel);
    }
   
    /// <pdGenerated>default Remove</pdGenerated>
    public void RemoveMateriel(Materiel oldMateriel)
    {
        if (oldMateriel == null)
            return;
        if (this.lesMateriels != null)
            if (this.lesMateriels.Contains(oldMateriel))
            this.lesMateriels.Remove(oldMateriel);
    }
   
    /// <pdGenerated>default removeAll</pdGenerated>
    public void RemoveAllMateriel()
    {
        if (lesMateriels != null)
            lesMateriels.Clear();
    }
}