﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public   class Newsletter
    {
        [Key]
        public int NewsLetterID { get; set; }
        public string Mail { get; set; }
    }
}
