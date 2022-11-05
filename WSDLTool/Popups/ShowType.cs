using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSDLTool.Popups
{
    public partial class ShowType : Form
    {
        public ShowType mainform;
        public ShowType()
        {
            InitializeComponent();
        }
        public ShowType(ShowType showType)
        {
            InitializeComponent();
            mainform = showType;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
