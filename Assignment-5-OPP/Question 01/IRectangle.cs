using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OPP.Question_01
{
    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}
