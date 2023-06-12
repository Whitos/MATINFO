/***********************************************************************
 * Module:  EstAttribue.cs
 * Author:  cordellp
 * Purpose: Definition of the Class EstAttribue
 ***********************************************************************/

using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

public class EstAttribue : IDonnee
{
    public int IDMateriel { get; set; }
    public int IDPersonnel { get; set; }
    public int IDDateAttribution { get; set; }
    public string Commentaire { get; set; }

    public DateAttribution LesDatesAttribution { get; set; }

    public EstAttribue(int idMateriel, int idPersonnel, int idDateAttribution, string commentaire)
    {
        IDMateriel = idMateriel;
        IDPersonnel = idPersonnel;
        IDDateAttribution = idDateAttribution;
        Commentaire = commentaire;
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

    public static ObservableCollection<EstAttribue> FindAll()
    {
        ObservableCollection<EstAttribue> lesAttributions = new ObservableCollection<EstAttribue>();
        DataAccess accesBD = new DataAccess();
        string requete = "select idmateriel, idpersonnel, iddateattribution, commentaire from estattribue ;";
        DataTable datas = accesBD.GetData(requete)!;
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                EstAttribue e = new EstAttribue(int.Parse(row["idmateriel"].ToString()!), int.Parse(row["idpersonnel"].ToString()!), int.Parse(row["iddateattribution"].ToString()!), (string)row["commentaire"]);
                lesAttributions.Add(e);
            }
        }
        return lesAttributions;
    }
}