using System;

namespace StructuralTree
{
    public class InheritableValue<T> : InheritableValueBase
    {
        T _value;
        T Value { get { return _value; } }

        public override object GetValueAsObject()
        {
            return (object)Value;
        }

        public override void SetValueAsObject(object value)
        {
            _value= (T)value;
        }

        public InheritableValue(T value)
        {
            _value = value;
        }   
    }
}