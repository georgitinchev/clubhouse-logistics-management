using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Classes
{
    internal class Worksheet
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<Worksheet> Worksheets { get; set; }
    }
}
