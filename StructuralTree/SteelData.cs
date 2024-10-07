using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralTree
{
    public class SteelData : ISpecificationData
    {
        //public List<Tuple<string, double>> MaterialMasses { get; } = new List<Tuple<string, double>>() {  new Tuple<string, double>("steel", 0)};

        public InheritableValue<int> FireRating { get; }
        public InheritableValue<string> Grade { get; }

        public SteelData(int fireRating, string grade)
        {
            FireRating = new InheritableValue<int>(fireRating);
            Grade = new InheritableValue<string>(grade);
            
        }

        public SteelData(InheritableValue<int> fireRating, InheritableValue<string> grade)
        {
            FireRating = fireRating;
            Grade = grade;

        }
    }
}
