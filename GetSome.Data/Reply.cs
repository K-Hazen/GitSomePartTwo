﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSome.Data
{
    public class Reply : Comment
    {
        public Comment ReplyComment { get; set; }
    }
}