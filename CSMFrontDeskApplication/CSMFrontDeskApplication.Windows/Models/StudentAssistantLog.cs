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
        public int StudentAssistantId { get; set; }
        public DateTime Login { get; set; }
        public DateTime Logout { get; set; }
        public int Hour
        {
            
            get
            {
                return this.Login.Hour;
            }
        }
        public int Minute
        {
            get
            {
                return this.Login.Minute;
            }
        }
        public int Second
        {
            get
            {
                return this.Login.Second;
            }
        }
        
    }
}
