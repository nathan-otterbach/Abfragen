using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class RawMaterial : Material
    {
        private string _seller;

        public RawMaterial() { }

        public RawMaterial(string name, string id, string seller) : this()
        {
            _seller = seller;
        }

        public string Seller
        {
            get { return _seller; }
            set { _seller = value; }
        }

        public override string Name
        {
            get { return base.Name; }
            set { base.Name = value; }
        }

        public override string Id 
        {             
            get { return base.Id; }
            set { base.Id = value; }
        }
    }
}
