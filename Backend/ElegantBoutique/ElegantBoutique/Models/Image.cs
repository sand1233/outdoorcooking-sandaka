﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantBoutique.Models
{
    public class Image
    {

        public int Id { get; set; }
        public int ItemId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
    }
}
