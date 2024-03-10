using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.Application.Helpers.Pagination
{
    public class PageFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PageFilter()
        {
            PageNumber = 1;
            PageSize = 10;
        }
        public PageFilter(int pagesize , int pagenumber)
        {
            PageNumber = pagenumber < 1 ? 1 : pagenumber;
            PageSize= pagesize>10 ?10:PageSize;
        }
    }
}
