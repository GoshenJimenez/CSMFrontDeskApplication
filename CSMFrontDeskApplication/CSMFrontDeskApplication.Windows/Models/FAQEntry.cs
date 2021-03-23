using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
    public class FAQEntry
    {
            public Guid? Id { get; set; }
            public string Question { get; set; }
            public string Answer { get; set; }
           
    }
}
