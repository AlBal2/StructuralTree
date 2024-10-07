using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralTree
{
    public abstract class InheritableValueBase
    {
        public bool isInHerited = true;
        public abstract object GetValueAsObject();
        public abstract void SetValueAsObject(object value);
    }
}

