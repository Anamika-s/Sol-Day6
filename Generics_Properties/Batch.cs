using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Properties
{
    internal class Batch
    {
        int id;
        public int Id { get { return id; } set { id = value; } }
        public int Marks { get; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
