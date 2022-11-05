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
           // controls = _Control;
            foreach (string type in types)
            {
                cboBuiltin_type.Items.Add(type);
            }
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_definedType_Click(object sender, EventArgs e)
        {
            ShowType showType = new ShowType();
            // ShowElement showElement = new ShowElement(this);
            showType.ShowDialog();
        }
    }
}
