﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IVoicePropertyRepository
    {
        VoiceProperty Add(VoiceProperty VoiceProperty);
        IEnumerable<VoiceProperty> GetBySellerId(int id);
    }
}
