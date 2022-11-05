using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSDLTool.Froms;

namespace WSDLTool.Popups
{
    public partial class portPopup : Form
    {
        public MainForm mainForm;
        public portPopup()
        {
            InitializeComponent();
        }
        public portPopup(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
