﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public bool Admin { get; set; }
        public bool Empleado { get; set; }

        //Cambiar perfiles con un Enum

    }
}
