﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Helpers.Filters
{
    public class RootFilter
    {
       public List<Filter> Filters { get; set; }
       public string Logic { get; set; }
    }

    public class Filter
    {
       public string Field { get; set; }
       public string Operator { get; set; }
       public object Value { get; set; }
       public string? Logic { get; set; } // This is the nested "logic" property for the inner filters array
       public List<Filter>? Filters { get; set; } // Nested filters array
    }
}
