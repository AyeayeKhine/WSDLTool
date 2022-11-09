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
using WSDLTool.Enums;
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
        public EleValueType eleValue;
        public int ID;
        public int ParentId =0;
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
            ID = 0;
            foreach (string type in types)
            {
                cboBuiltin_type.Items.Add(type);
            }
            btnSaveChild.Visible = false;
        }
        public AddElement_popup(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            mainForm = _Main;
            controls = _Control;
            btnSave.Visible = false;
            ParentId = ((uc_Element)controls).ID;
            gpBoxElement.Visible = true;
            gpBoxType.Visible = false;
            gpBoxElement.Location = new Point(12, 138);
            this.Size = new Size(355, 500);
            ID = 0;
            foreach (string type in types)
            {
                cboBuiltin_type.Items.Add(type);
            }
        }
        public AddElement_popup(MainForm _Main, uc_Element _Element)
        {
            InitializeComponent();
            mainForm = _Main;
            btnSaveChild.Visible = false;
            if (!_Element.IsComplexType)
            {
                gpBoxElement.Visible = true;
                gpBoxType.Visible = false;
                gpBoxElement.Location = new Point(12, 138);
                this.Size = new Size(355, 500);
                foreach (string type in types)
                {
                    cboBuiltin_type.Items.Add(type);
                }
                ID = _Element.ID;
                txtElementName.Text = _Element.Name1;
                txtEleValue.Text = _Element.Ele_value;
                txtMaxOccours.Text = _Element.MaxOcc;
                txtMinOccours.Text = _Element.MinOcc;
                ckNestedType.Enabled = false;
                cboBuiltin_type.Text = _Element.DataType;
                BindR(_Element);
            }
        }
        private void BindR(uc_Element _Element)
        {
            switch (_Element.Ele_valueType)
            {
                case EleValueType.Default:
                    rDefault.Checked = true;
                    break;
                case EleValueType.Fixed:
                    rFixed.Checked = true;
                    break;
                default:
                    break;
            }
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
                btn_definedType.Visible = false;
                this.Size = new Size(355, 270);
            }
            else
            {
                gpBoxElement.Visible = true;
                gpBoxType.Visible = false;
                lblType.Visible = true;
                cboBuiltin_type.Visible = true;
                btn_definedType.Visible = true;
                gpBoxElement.Location = new Point(12, 138);
                this.Size = new Size(355, 500);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var uc_ele = new uc_Element();

            //Check ValueType
            if (rDefault.Checked)
            {
                eleValue = EleValueType.Default;
            }
            else if (rFixed.Checked)
            {
                eleValue = EleValueType.Fixed;
            }
            else
            {
                eleValue = EleValueType.Unknow;
            }

            //Check Add/Modify Element
            if (ID != 0)
            {
                //Modify Element
                var item = ucLists.Elements.Where(ele => ele.ID == ID).FirstOrDefault();
                item.ID = cls_Common.EleId;
                item.Name1 = txtElementName.Text;
                item.DataType = cboBuiltin_type.Text;
                item.MinOcc = txtMinOccours.Text;
                item.MaxOcc = txtMaxOccours.Text;
                item.Note = txtNote.Text;
                item.IsComplexType = false;
                item.Ele_value = txtEleValue.Text;
                item.Ele_valueType = eleValue;
            }
            else
            {
                //Check Simple/Complex Element
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
                    uc_ele = CloneElement(cls_Common.EleId);
                }

                cls_Common.EleId++;
                ucLists.Elements.Add(uc_ele);
            }
            Point point = new Point();
            this.Close();
            uc_Element uc_ = new uc_Element(mainForm, point, uc_ele);

        }
        private uc_Element CloneElement(int ID)
        {
           var uc_ele = new uc_Element
            {
                ID = ID,
                Name1 = txtElementName.Text,
                DataType = cboBuiltin_type.Text,
                MinOcc = txtMinOccours.Text,
                MaxOcc = txtMaxOccours.Text,
                Note = txtNote.Text,
                IsComplexType = false,
                Ele_value = txtEleValue.Text,
                Ele_valueType = eleValue,
                Parentid = ParentId,
            };
            return uc_ele;
        }
        private void btn_OKi_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveChild_Click(object sender, EventArgs e)
        {
            var uc_ele = new uc_Element();
            var parent_ele = new uc_Element();
            //Check ValueType
            if (rDefault.Checked)
            {
                eleValue = EleValueType.Default;
            }
            else if (rFixed.Checked)
            {
                eleValue = EleValueType.Fixed;
            }
            else
            {
                eleValue = EleValueType.Unknow;
            }
            //Check Simple/Complex Element
            if (ckNestedType.Checked)
            {
                uc_ele = new uc_Element()
                {
                    ID = cls_Common.ChildEleId,
                    Name1 = txtElementName.Text,
                    IsComplexType = true,
                };

            }
            else
            {
                uc_ele = CloneElement(cls_Common.ChildEleId);
                 
            }
            cls_Common.ChildEleId++;
            parent_ele = ucLists.Elements.Where(ele => ele.ID == ParentId).FirstOrDefault();
            //if(parent_ele.Param)
            uc_Element uc_ = new uc_Element(mainForm, controls); 
            
        }
    }
}
