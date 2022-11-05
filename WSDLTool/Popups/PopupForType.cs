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
    
    public partial class PopupForType : Form
    {
        public MainForm mainForm;
        public PopupForType()
        {
            InitializeComponent();
        }
        public PopupForType(MainForm _Main)
        {
            InitializeComponent();
            mainForm = _Main;
        }       

        private void btn_addElement_Click(object sender, EventArgs e)
        {
            //Control control = ((ContextMenuStrip)((ToolStripItem)sender).Owner).SourceControl;
            ////  AddElement_alreadyType addElement_AlreadyType = new AddElement_alreadyType();
            //AddElement_popup addElement_Popup = new AddElement_popup();
            //addElement_Popup.ShowDialog();
            AddElement_popup addElement_Popup = new AddElement_popup(mainForm);
            addElement_Popup.ShowDialog();
        }

        private void btn_addComplextType_Click(object sender, EventArgs e)
        {
            AddComplexType_popup addComplexType_Popup = new AddComplexType_popup(mainForm);
            addComplexType_Popup.ShowDialog();
        }
    }
}
