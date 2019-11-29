using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    // We are making this a partial class and giving the constructor
    public partial class Sailboat
    {
        private string make;
        private string model;

        public Sailboat(string make, string model)
        {
            this.make = make;
            this.model = model;
        }
    }
}
