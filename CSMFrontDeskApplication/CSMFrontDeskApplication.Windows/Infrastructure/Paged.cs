using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Infrastructure
{
    public class Paged<T>
    {
        public List<T> Items { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public long RowCount { get; set; }
        public long PageCount { 
            get
            {
                return (long)Math.Ceiling((decimal)(this.RowCount / this.PageSize));
            }
        }
    }
}
