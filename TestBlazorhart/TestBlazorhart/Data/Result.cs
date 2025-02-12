﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorhart.Data
{
    public class Result
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Snippet { get; set; }
        public string Source { get; set; }
        public string Query { get; set; }
        public int Index { get; set; }
        public string keyword { get; set; }

        public int blazorIndex { get; set; }
    }
}
