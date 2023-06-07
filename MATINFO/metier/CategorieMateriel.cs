/***********************************************************************
 * Module:  CategorieMateriel.cs
 * Author:  cordellp
 * Purpose: Definition of the Class CategorieMateriel
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class CategorieMateriel : IDonnee
{
    public int IDCategorieMateriel { get; set; }
    public int Nom { get; set; }

    public List<Materiel> lesMateriels { get; set; }

    public CategorieMateriel()
    {
        // TODO: implement
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
   
    public static List<CategorieMateriel> FindAll()
    {
        // TODO: implement
        return null;
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