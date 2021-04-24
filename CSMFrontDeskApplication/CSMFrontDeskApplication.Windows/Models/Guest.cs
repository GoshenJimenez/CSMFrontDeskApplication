using CSMFrontDeskApplication.Windows.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
    public class Guest
    {
        public Guid? Id { get; set; }
        public string PersonName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public RecordStatus Status { get; set; }
    }
}
