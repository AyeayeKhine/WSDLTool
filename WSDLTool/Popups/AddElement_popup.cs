using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSDLTool.Controls;
using WSDLTool.Froms;
using WSDLTool.Helpers;

namespace WSDLTool.Popups
{
    public partial class AddElement_popup : Form
    {
        public MainForm mainForm;
        public Control controls;
        public List<string> types = new List<string>
        {
            "anySimpleType",
            "anyType",
            "anyURI","base64Binary","boolean","byte","date","dateTime","decimal","double","duration","ENTITIES","ENTITY","float","gDay","gMonth","gMonthDay","gYear","gYearMonth","hexBinary","ID","IDREF","IDREFS","integer","language","long","normalizedString","Name","NCName","negativeInteger","NMTOKEN","NMTOKENS","nonNegativeInteger","nonPositiveInteger","NOTATION","positiveInteger","QName","short","string","time","token","unsignedByte","unsignedInt","unsignedShort","unsignedLong",
         };
        public AddElement_popup()
        {
            InitializeComponent();
        }
        public AddElement_popup(MainForm _Main)
        {
            InitializeComponent();
            mainForm = _Main;
            gpBoxElement.Visible = true;
            gpBoxType.Visible = false;
            gpBoxElement.Location = new Point(12, 138);
            this.Size = new Size(355, 500);
            foreach (string type in types)
            {
                cboBuiltin_type.Items.Add(type);
            }
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void type_browse_Click(object sender, EventArgs e)
        {
            ShowType showType = new ShowType();
            // ShowElement showElement = new ShowElement(this);
            showType.ShowDialog();
        }

        private void ckNestedType_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNestedType.Checked)
            {
                gpBoxElement.Visible = false;
                gpBoxType.Visible = true;
                gpBoxElement.Location = new Point(12, 233);
                lblType.Visible = false;
                cboBuiltin_type.Visible = false;
                this.Size = new Size(355, 270);
            }
            else
            {
                gpBoxElement.Visible = true;
                gpBoxType.Visible = false;
                gpBoxElement.Location = new Point(12, 138);
                this.Size = new Size(355, 500);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var uc_ele = new uc_Element();
            if (ckNestedType.Checked)
            {
                uc_ele = new uc_Element()
                {
                    ID = cls_Common.EleId,
                    Name1 = txtElementName.Text,
                    IsComplexType = true,
                };
            }
            else
            {
                uc_ele = new uc_Element
                {
                    ID = cls_Common.EleId,
                    Name1 = txtElementName.Text,
                    DataType = cboBuiltin_type.Text,
                    MinOcc = txtMinOccours.Text,
                    MaxOcc = txtMaxOccours.Text,
                    //Note = txtNote.Text,
                    IsComplexType = false,
                };
            }
            cls_Common.EleId++;
            ucLists.Elements.Add(uc_ele);
        }

        private void btn_OKi_Click(object sender, EventArgs e)
        {

        }
    }
}
