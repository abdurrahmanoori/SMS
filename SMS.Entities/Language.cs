﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entities
{

    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageCode { get; set; }  // e.g., "en", "fa", "ur"
    }
}