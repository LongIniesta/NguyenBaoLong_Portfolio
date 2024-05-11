﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoginResponseDTO
    {
        public string Token { get; set; }
        public string Role { get; set; }
        public VoiceSellerDTO VoiceSeller { get; set; }
        public BuyerDTO Buyer { get; set; } 
    }
}
