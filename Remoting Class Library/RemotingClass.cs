using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Class_Library
{
    public class RemotingClass : MarshalByRefObject
    {
        public int Square(int area)
        {
            return area * area;
        }
    }
}
