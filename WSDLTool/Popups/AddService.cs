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
    public partial class AddService : Form
    {
        
        public MainForm mainForm;
        public AddService()
        {
            InitializeComponent();
        }
        public AddService(MainForm mainForm)
        {
            InitializeComponent();
        }
        private void AddService_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_port_Click(object sender, EventArgs e)
        {
            portPopup portPop = new portPopup(mainForm);
            portPop.ShowDialog(); 
        }
    }
}
