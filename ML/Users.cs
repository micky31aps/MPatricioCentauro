using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string contrasena { get; set; }
        public int Parent { get; set; }
        public int Estatus { get; set; }
        public List<object> Usuarios { get; set; }
        public ML.Roles Roles { get; set; }
    }
}
