using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSDLTool.Controls
{
    public partial class uc_ComplexType : UserControl
    {
        private int parentID;
        private string ModelGroup;
        private string ComplexType_name;
        private List<uc_Element> uc_Elements;
        public uc_ComplexType()
        {
            InitializeComponent();
        }

        public string ModelGroup1 { get => ModelGroup; set => ModelGroup = value; }
        public string ComplexType_name1 { get => ComplexType_name; set => ComplexType_name = value; }
        public List<uc_Element> Uc_Elements { get => uc_Elements; set => uc_Elements = value; }
        public int ParentID { get => parentID; set => parentID = value; }
    }
}
