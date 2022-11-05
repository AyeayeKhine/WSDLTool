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
    public partial class AddExistingElements : Form
    {
        public AddExistingElements()
        {
            InitializeComponent();
        }

        private void type_browse_Click(object sender, EventArgs e)
        {
            ShowType showType = new ShowType();
            // ShowElement showElement = new ShowElement(this);
            showType.ShowDialog();
        }

        private void element_browse_Click(object sender, EventArgs e)
        {
            ShowElement showElement = new ShowElement();
             showElement.ShowDialog();
        }
    }
}
