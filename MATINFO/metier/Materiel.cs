/***********************************************************************
 * Module:  Materiel.cs
 * Author:  cordellp
 * Purpose: Definition of the Class Materiel
 ***********************************************************************/

using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using static MATINFO.MaterielRep;

public class Materiel : IDonnee
{
    public int IDMateriel { get; set; }
    public int IDCategorieMateriel { get; set; }
    public string CodeBarre { get; set; }
    public string Nom { get; set; }
    public string Reference { get; set; }

    public List<EstAttribue> EstAttribue { get; set; }

    public Materiel(int idMateriel, int idCategorieMateriel, string codeBarre, string nom, string reference)
    {
        IDMateriel = idMateriel;
        IDCategorieMateriel = idCategorieMateriel;
        CodeBarre = codeBarre;
        Nom = nom;
        Reference = reference;
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

    public static ObservableCollection<Materiel> FindAll()
    {
        ObservableCollection<Materiel> lePersonnel = new ObservableCollection<Materiel>();
        DataAccess accesBD = new DataAccess();
        string requete = "select idmateriel, idcategoriemateriel, codebarre, nommateriel, referencemateriel from personnel ;";
        DataTable datas = accesBD.GetData(requete)!;
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                Materiel e = new Materiel(int.Parse(row["idmateriel"].ToString()!), int.Parse(row["idcategoriemateriel"].ToString()!), (string)row["nompersonnel"], (string)row["prenompersonnel"], (string)row["email"]);
                lePersonnel.Add(e);
            }
        }
        return lePersonnel;
    }
}