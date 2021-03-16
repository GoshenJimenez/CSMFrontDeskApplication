using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
    public class StudentAssistant
    {
        public Guid? Id { get; set; }
        public string PersonName { get; set; }
        public string Course { get; set; }
        public string Username { get; set; }
        public string Password { get; set;  }

    }
}
