/***********************************************************************
 * Module:  Materiel.cs
 * Author:  cordellp
 * Purpose: Definition of the Class Materiel
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Materiel : IDonnee
{
    public int IDMateriel { get; set; }
    public int IDCategorieMateriel { get; set; }
    public int CodeBarre { get; set; }
    public int Nom { get; set; }
    public int Reference { get; set; }

    public List<EstAttribue> EstAttribue { get; set; }

    public Materiel()
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
   
    public static List<Materiel> FindAll()
    {
        // TODO: implement
        return null;
    }
}