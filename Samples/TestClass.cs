using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    class TestClass
    {
        public InnerClass InnerClassProp { get; set; }
    }

    class InnerClass
    {
        public double InnerProp {  get; set; }
    }

    class DtoClass
    {
        public double? InnerProp { get; set; }
    }
}
