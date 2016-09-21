using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data;
using BookLending.Classes;

namespace BookLending.Repository
{
    public abstract partial class EntityRepository
    {
        public abstract DataSet CreateDataSet();

        protected abstract void FillCollections(DataSet ds);        

        public void Load(string fileName, DataSet ds, XmlReadMode readMode = XmlReadMode.IgnoreSchema)
        {
            string ext = Path.GetExtension(fileName);
            if (ext == ".xml")
            {
                ds.ReadXml(fileName, readMode);
                FillCollections(ds);                
            }
            else 
            {
                throw new Exception(
                    "Сховище не підтримує завантаження "
                    + "з файлу формату " + ext.ToUpper());
            }
        }
        public void Load(DataSet ds)
        {
            FillCollections(ds);
        }

        protected void FillEntityMembers(DataRow dr, Entity entity)
        {
            if (entity != null)
            {
                entity.Note = dr["Note"].ToString();
            }
            IIdentefiable identifiedEntity = entity as IIdentefiable;
            if (identifiedEntity != null)
            {
                identifiedEntity.Id = Int32.Parse(dr["Id"].ToString());
            }
            if(entity is INameble)
                (entity as INameble).CommonName = dr["CommonName"].ToString();
            if(entity is IDescribable){
                (entity as IDescribable).Description = dr["Description"].ToString();
                (entity as IDescribable).Site = dr["Site"].ToString(); }
        }
    }
}
