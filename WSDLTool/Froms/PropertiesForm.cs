using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSDLTool.Helpers;

namespace WSDLTool.Froms
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
            ObjectType OjType = new ObjectType();
            txtWsdlFile.Text = OjType.Create();
        }
        public PropertiesForm(string Msg)
        {
            InitializeComponent();
            if(Msg == "Msg")
            {
                ObjectType OjType = new ObjectType();
                txtWsdlFile.Text = OjType.CreateMessage();
            }
            else if(Msg == "Port")
            {
                ObjectType OjType = new ObjectType();
                txtWsdlFile.Text = OjType.CreatePortType();
            }
            
        }
    }
}
