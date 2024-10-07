using StructuralTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_tree_tester
{
    public class Utilities
    {
        public static void writeChildData(IStructuralDataHolder holder, int level)
        {
            Console.WriteLine("");
            Console.WriteLine("LEVEL " + level.ToString());
            writeData(holder);
            Console.WriteLine("");

            foreach (var child in holder.Children)
            {
                writeChildData(child, level + 1);
            }
        }

        public static void writeData(IStructuralDataHolder holder)
        {
            Console.WriteLine(holder.Name);
            foreach (var childData in holder.Data)
            {
                if (childData.GetType() == typeof(SteelData))
                {
                    var steel = (SteelData)childData;
                    Console.WriteLine("Steel data found");
                    if (steel.Grade.isInHerited) 
                    { Console.Write("Grade (inherited): "); }
                    else
                    { Console.Write("Grade (not inherited): "); }
                    Console.WriteLine(steel.Grade.GetValueAsObject().ToString());
                    if (steel.FireRating.isInHerited)
                    { Console.Write("Fire rating (inherited): "); }
                    else
                    { Console.Write("Fire rating (not inherited): "); }
                    Console.WriteLine(steel.FireRating.GetValueAsObject().ToString());
                }
                else if (childData.GetType() == typeof(ConcreteData))
                {
                    var conc = (ConcreteData)childData;
                    Console.WriteLine("Concrete data found");
                    if (conc.Cover.isInHerited)
                    { Console.Write("Cover (inherited): "); }
                    else
                    { Console.Write("Cover (not inherited): "); }
                    Console.WriteLine(conc.Cover.GetValueAsObject().ToString());
                }
            }
        }
    }
}
