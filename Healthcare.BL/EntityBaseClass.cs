using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBaseClass
    {
        public bool HasChanges { get; private set; }
        public bool IsNew { get; set; }
        public bool IsValid { get
            {
                return Validate();
            }
        }
        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();
    }
}
