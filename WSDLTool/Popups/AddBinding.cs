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
    public partial class AddBinding : Form
    {
        public MainForm mainForm;
        public AddBinding()
        {
            InitializeComponent();
        }
        public AddBinding(MainForm mainForm)
        {
            InitializeComponent();
        }
    }
}
