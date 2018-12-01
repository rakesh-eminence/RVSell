using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Benefits
    {
        public int BenefitID { get; set; }
        public int PropertyID { get; set; }
        public string BenefitName { get; set; }
        public DateTime timestamp { get; set; }         //Timestamp
    }
}
