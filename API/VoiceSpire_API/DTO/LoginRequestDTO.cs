﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoginRequestDTO
    { 
        public string Email { get; set; }
        public string Password { get; set; }    
    }
}
