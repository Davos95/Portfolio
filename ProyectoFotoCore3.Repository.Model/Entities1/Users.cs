using System;
using System.Collections.Generic;

namespace ProyectoFotoCore3.Repository.Context
{
    public partial class Users
    {
        public string Id { get; set; }
        public string Nick { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
