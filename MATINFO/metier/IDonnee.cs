/***********************************************************************
 * Module:  IDonnee.cs
 * Author:  cordellp
 * Purpose: Definition of the Interface IDonnee
 ***********************************************************************/

namespace MATINFO.Metier
{
    public interface IDonnee
    {
        void Create();
        IDonnee? Read();
        void Update();
        void Delete();

        //ObservableCollection<T> FindAll();

        //ObservableCollection<T> FindBySelection(string criteres);
    }
}