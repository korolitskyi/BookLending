using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    interface IIdentefiable
    {
        int Id { get; set; }
    }

    interface INameble
    {
        string CommonName { get; set; }
    }

    interface IDescribable
    {
        string Description { get; set; }
        string Site { get; set; }
    }
    
    public abstract class Entity
    {
        public string Note { get; set; }
    }
    public abstract class IdentifiedEntity : Entity, IIdentefiable
    {
        public int Id { get; set; }
    }

    public abstract class NamedEntity : Entity, INameble
    {
        private string commonName;
        public string CommonName { get { return commonName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("NamedEntity.CommonName", "value");
                commonName = value.Trim();
            }
        }

        public NamedEntity(string Name)
        {
            CommonName = Name;
        }

        public NamedEntity() { }
        
    }

    public abstract class IdentifiedNamedEntity : NamedEntity, IIdentefiable
    {
        public int Id { get; set; }
        public IdentifiedNamedEntity(string Name) : base(Name) { }
        public IdentifiedNamedEntity() { }
    }
    public abstract class DescribedEntity : Entity, IDescribable
    {
        public string Description { get; set; }
        public string Site { get; set; }
    }

    public abstract class DesribedNamedEntity : NamedEntity, IDescribable
    {
        public string Description { get; set; }
        public string Site { get; set; }
    }

    public abstract class DescribedIdentifiedNamedEntity : IdentifiedNamedEntity, IDescribable
    {
        public string Description { get; set; }
        public string Site { get; set; }
        public DescribedIdentifiedNamedEntity(string Name):base(Name){ }
        public DescribedIdentifiedNamedEntity() { }
    }

   
}
