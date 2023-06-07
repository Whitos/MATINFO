/***********************************************************************
 * Module:  EstAttribue.cs
 * Author:  cordellp
 * Purpose: Definition of the Class EstAttribue
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class EstAttribue : IDonnee
{
    public int IDMateriel { get; set; }
    public int IDPersonnel { get; set; }
    public int IDDateAttribution { get; set; }
    public string Commentaire { get; set; }

    public DateAttribution LesDatesAttribution { get; set; }

    public EstAttribue()
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
   
    public static List<EstAttribue> FindAll()
    {
        // TODO: implement
        return null;
    }
}