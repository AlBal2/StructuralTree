using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralTree
{
    public interface IStructuralDataHolder
    {
        string Name { get; set; }
        List<ISpecificationData> Data { get; }

        List<IStructuralDataHolder> Children { get; }

        void UpdateChildren();

        void AddChildren(IStructuralDataHolder children);

        void AddStructuralData(ISpecificationData data);


    }
}
