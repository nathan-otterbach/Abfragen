using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public class Material
    {
        private string _name;
        private string _id;

        public Material() { }

        public Material(string name, string id) : this()
        {
            _name = name;
            _id = id;
        } 

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
