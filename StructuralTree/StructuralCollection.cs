using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StructuralTree
{
    public class StructuralCollection : IStructuralDataHolder
    {
        public string Name { get; set; }
        public List<ISpecificationData> Data { get; } = new List<ISpecificationData>();

        public List<IStructuralDataHolder> Children { get; } = new List<IStructuralDataHolder> ();

        public void UpdateChildren()
        {
            foreach (var child in Children)
            {
                foreach (var childDataSet in child.Data)
                {
                    var dataSet = Data.Where(x=> x.GetType() == childDataSet.GetType()).FirstOrDefault();
                    if (dataSet == null) break; // i.e. no matching data set on parent
                    var srcProps = dataSet.GetType().GetProperties();
                    var test = srcProps[0].PropertyType;
                    var srcPropsInheritable = srcProps.Where(x => typeof(InheritableValueBase).IsAssignableFrom(x.PropertyType) == true).ToList();

                    foreach (var prop in srcPropsInheritable)
                    {
                        var childValue = (InheritableValueBase)prop.GetValue(childDataSet);
                        

                        if (childValue.isInHerited)
                        {
                            var parentPropValue = (InheritableValueBase)prop.GetValue(dataSet);
                            var testVal = parentPropValue.GetValueAsObject();
                            childValue.SetValueAsObject(testVal);
                        }
                    }

                }
                child.UpdateChildren();
            }
        }
        public void AddChildren(IStructuralDataHolder data)
        {
            Children.Add(data);
        }

        public void AddStructuralData(ISpecificationData data)
        {
            // ADD CHECK THAT DATA TYPE DOESN@T ALREADY EXIST
            Data.Add(data);
        }
    }
}
