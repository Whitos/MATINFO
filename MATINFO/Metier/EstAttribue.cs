/***********************************************************************
 * Module:  EstAttribue.cs
 * Author:  cordellp
 * Purpose: Definition of the Class EstAttribue
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

namespace MATINFO.Metier
{
    public class EstAttribue : IDonnee
    {
        public int IDMateriel { get; set; }
        public int IDPersonnel { get; set; }
        public DateTime DateAttribution { get; set; }
        public string Commentaire { get; set; }

        public EstAttribue(int idMateriel, int idPersonnel, DateTime dateAttribution, string commentaire)
        {
            IDMateriel = idMateriel;
            IDPersonnel = idPersonnel;
            DateAttribution = dateAttribution;
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
            AccesDonnees accesBD = new AccesDonnees();
            string requete = "select idmateriel, idpersonnel, dateattribution, commentaireattribution from est_attribue ;";
            DataTable datas = accesBD.GetData(requete)!;
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    EstAttribue e = new EstAttribue(int.Parse(row["idmateriel"].ToString()!), int.Parse(row["idpersonnel"].ToString()!), DateTime.Parse(row["dateattribution"].ToString()!), (string)row["commentaireattribution"]);
                    lesAttributions.Add(e);
                }
            }
            return lesAttributions;
        }
    }
}