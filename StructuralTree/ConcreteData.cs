using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralTree
{
    public class ConcreteData : ISpecificationData
    {
        //public List<Tuple<string, double>> MaterialMasses { get; } = new List<Tuple<string, double>>() { new Tuple<string, double>("concrete", 0), new Tuple<string, double>("steel", 0) };

        public InheritableValue<double> Cover { get; }

        public ConcreteData(double cover)
        {
            Cover = new InheritableValue<double>(cover);
        }

    }
}
