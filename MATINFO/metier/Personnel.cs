/***********************************************************************
 * Module:  Personnel.cs
 * Author:  cordellp
 * Purpose: Definition of the Class Personnel
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Personnel : IDonnee
{
    public int IDPersonnel { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int EMail { get; set; }

    public List<EstAttribue> LesAttributions { get; set; }

    public Personnel()
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
   
    public static List<Personnel> FindAll()
    {
        // TODO: implement
        return null;
    }
}