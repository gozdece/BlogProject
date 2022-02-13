﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Parameters
{
    public class PageRequestParameter
    {
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;
     
    }
}
