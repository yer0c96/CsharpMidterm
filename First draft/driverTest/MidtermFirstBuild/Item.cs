using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public abstract class Item : IComparable
    {
        private Guid _id;
        
        public Item()
        {
            _id = Guid.NewGuid();
        }

        public Guid Id
        {
            get { return _id; }
        }
        public abstract string Name
        {
            get;
        }
        public abstract double Weight
        {
            get;
        }
        public abstract InventorySlotId Slot
        {
            get;
        }
        public abstract bool IsNatural
        {
            get;
        }

        int IComparable.CompareTo(object obj)
        {
            Item other = ((Item)obj);
            return this.Id.CompareTo(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (obj.GetType() != this.GetType()) { return false; }

            Item other = ((Item)obj);
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return (Name); 
        }
    }
}
