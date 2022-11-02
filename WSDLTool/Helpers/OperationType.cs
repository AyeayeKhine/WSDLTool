using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSDLTool.Helpers
{
    public class OperationType
    {
        public int ID { get; set; }        
        public string OprationName { get; set; }
        public List<ClsPortType> clsPortTypes { get; set; }
        
    }
    public class ClsPortType
    {
        public string PortTypeId { get; set; }
        public string InputName { get; set; }
        public string Message { get; set; }
    }
}
