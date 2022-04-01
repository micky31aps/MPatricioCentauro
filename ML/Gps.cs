using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Gps
    {
        public int Id { get; set; }
        public DateTime DateSystem { get; set; }
        public DateTime DateEvent { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Battery { get; set; }
        public int Source { get; set; }
        public int Tipo { get; set; }
    }
}
