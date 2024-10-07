using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralTree
{
    public class StructuralMember : IStructuralDataHolder
    {
        public string Name { get; set; }
        public List<ISpecificationData> Data { get; } = new List<ISpecificationData>();

        public List<IStructuralDataHolder> Children { get; } = new List<IStructuralDataHolder>();

        public void AddChildren(IStructuralDataHolder children)
        {
            
        }

        public void AddStructuralData(ISpecificationData data)
        {
            // ADD CHECK THAT DATA TYPE DOESN@T ALREADY EXIST
            Data.Add(data);
        }

        public void UpdateChildren()
        {
            
        }
    }
}
