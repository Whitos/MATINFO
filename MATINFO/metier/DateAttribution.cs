/***********************************************************************
 * Module:  DateAttribution.cs
 * Author:  cordellp
 * Purpose: Definition of the Class DateAttribution
 ***********************************************************************/

using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;

public class DateAttribution : IDonnee
{
    public int IDDateAttribution { get; set; }
    public DateTime Date { get; set; }

    public DateAttribution(int idDateAttribution, DateTime date)
    {
        IDDateAttribution = idDateAttribution;
        Date = date;
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
    
    public static ObservableCollection<DateAttribution> FindAll()
    {
        ObservableCollection<DateAttribution> lesAttributions = new ObservableCollection<DateAttribution>();
        DataAccess accesBD = new DataAccess();
        string requete = "select iddateattribution, dateattribution from dateattribution ;";
        DataTable datas = accesBD.GetData(requete)!;
        if (datas != null)
        {
            foreach (DataRow row in datas.Rows)
            {
                DateAttribution e = new DateAttribution(int.Parse(row["iddateattribution"].ToString()!), DateTime.Parse((string)row["dateattribution"]));
                lesAttributions.Add(e);
            }
        }
        return lesAttributions;
    }
}