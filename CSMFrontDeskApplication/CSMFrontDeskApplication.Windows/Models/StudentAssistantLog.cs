using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMFrontDeskApplication.Windows.Models
{
    public class StudentAssistantLog
    {
        public Guid? Id { get; set; }
        public Guid? StudentAssistantId { get; set; }
        public StudentAssistant StudentAssistant { get; set; }
        public DateTime Login { get; set; }
        public DateTime? Logout { get; set; }
        
    }
}
