using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralTree
{
    public  interface IStructuralData
    {
        List<Tuple<string, double>> MaterialMasses { get; }

    }
}
