using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Common
{
    public class PagedResults<T> : PagedResultBase
    {
        public List<T> Items { get; set; }
    }
}
