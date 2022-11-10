using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WSDLTool.Enums;
using WSDLTool.Froms;
using WSDLTool.Helpers;

namespace WSDLTool.Controls
{
    public partial class uc_Element : UserControl
    {
        private int id;
        //private int reqid;
        //private int resid;
        private int parentid;
        private string name;
        private string minOcc;
        private string maxOcc;
        private string dataType;
        private string note;
        private string ele_value;
        private EleValueType ele_valueType;
        //private string responseDataType;
        private ucParamLists param;
        private uc_ComplexType uc_complextype;
        private string paramName;
        private bool isComplexType;

        public int ID { get => id; set => id = value; }
        //public int Reqid { get => reqid; set => reqid = value; }
        //public int Resid { get => resid; set => resid = value; }
        public string Name1 { get => name; set => name = value; }
        public string MinOcc { get => minOcc; set => minOcc = value; }
        public string MaxOcc { get => maxOcc; set => maxOcc = value; }
        public string DataType { get => dataType; set => dataType = value; }
        //public string ResponseDataType { get => responseDataType; set => responseDataType = value; }
        public int Parentid { get => parentid; set => parentid = value; }
        public string ParamName { get => paramName; set => paramName = value; }
        public Label lblTest { get; set; }
        public ucParamLists Param
        {
            get => param;
            set
            {
                if (value == null)
                {
                    param = new ucParamLists();
                }
                else
                {
                    param = value;
                }
            }
        }
        public uc_ComplexType Uc_complextype { get => uc_complextype; set => uc_complextype = value; }
        public string Note { get => note; set => note = value; }
        public EleValueType Ele_valueType { get => ele_valueType; set => ele_valueType = value; }
        public bool IsComplexType { get => isComplexType; set => isComplexType = value; }
        public string Ele_value { get => ele_value; set => ele_value = value; }

        public uc_Element()
        {
            InitializeComponent();
        }

        public uc_Element(MainForm _Main, Point _Loc,uc_Element _Element)
        {
            InitializeComponent();
            var point = new Point();
            point.X = _Loc.X + 20;
            point.Y = _Loc.Y + 20;
            this.Location = point;
            cls_Common.txtElementHeight = 40;
            if (!_Element.IsComplexType)
            {
                _Element.lblComplexType.Visible = false;
                _Element.lblElement.Text = _Element.Name1;
                ElementMenu = new ContextMenuStrip();
                var addReqElement = new ToolStripMenuItem("Modifiy Element", null, _Main.ModifyElementItem_Click);
                ElementMenu.Items.Add(addReqElement);

                var addResElement = new ToolStripMenuItem("Delete Element", null, _Main.DeleteElementItem_Click);
                ElementMenu.Items.Add(addResElement);
                this.ContextMenuStrip = ElementMenu;
                var lbl1 = new Label
                {
                    Text = "ID     :" +_Element.ID,
                    AutoSize = false,
                };
                //Add location of new Element
                lbl1.Location = new Point(0, cls_Common.txtElementHeight);

                var lbl2 = new Label
                {
                    Text = "Min Occurs   :" + _Element.minOcc,
                    AutoSize = false,
                };
                //Add location of new Element
                cls_Common.txtElementHeight += 23;
                lbl2.Location = new Point(0, cls_Common.txtElementHeight);

                var lbl3 = new Label
                {
                    Text = "Max Occurs   :" + _Element.maxOcc,
                    AutoSize = false,
                };
                //Add location of new Element
                cls_Common.txtElementHeight += 23;
                lbl3.Location = new Point(0, cls_Common.txtElementHeight);

                var lbl4 = new Label
                {
                    Text = "Types   :" + _Element.dataType,
                    AutoSize = false,
                };
                //Add location of new Element
                cls_Common.txtElementHeight += 23;
                lbl4.Location = new Point(0, cls_Common.txtElementHeight);

                var lbl5 = new Label
                {
                    Text = "Values   :" + _Element.ele_value,
                    AutoSize = false,
                };
                cls_Common.txtElementHeight += 23;
                //Add location of new Element
                lbl5.Location = new Point(0, cls_Common.txtElementHeight);
                _Element.Controls.Add(lbl1);
                _Element.Controls.Add(lbl2);
                _Element.Controls.Add(lbl3);
                _Element.Controls.Add(lbl4);
                _Element.Controls.Add(lbl5);
                _Element.ContextMenuStrip = this.ContextMenuStrip;
                _Element.addElementItem.Click += _Main.addElementItem_Click;
                ControlExtension.Draggable(_Element, true);
                _Main.panelType.Controls.Add(_Element);
            }
            else
            {
                _Element.lblElement.Text = _Element.Name1;
                _Element.addElementItem.Click += _Main.addElementItem_Click;
                ControlExtension.Draggable(_Element, true);
                _Main.panelType.Controls.Add(_Element);
            }
        }

        public uc_Element(MainForm _Main, Control _Control,uc_Element _Element)
        {
            InitializeComponent();
            var uc_Ele = (uc_Element)_Control;
            int parentId = uc_Ele.parentid;
            
            if (uc_Ele.ID == 1)
            {
                var tempEle = ucLists.ElementReqs.Where(i => i.parentid == parentId).FirstOrDefault();
                if (tempEle != null)
                {
                    if (tempEle.Param != null && tempEle.Param.ParamLists.Count > 0)
                    {
                        int count = tempEle.Param.ParamLists.Count;
                        string Name = uc_Ele.ParamName;
                        //Update location of new Element parameter
                        cls_Common.txtElementHeight = (count * 20) + 70;
                        //Update param Count
                        cls_Common.paramCount++;
                    }
                    else
                    {
                        //Inilization location of new Element parameter
                        cls_Common.txtElementHeight = 70;
                        //Inilization param Count
                        cls_Common.paramCount = 1;
                    }
                    var lblElement = new Label
                    {
                        Text = "+  " + uc_Ele.ParamName +" : " + uc_Ele.dataType,
                        Width = 182,
                        Height = 20,
                    };
                    lblElement.Click += _Main.AddElementProperty_Click;
                    uc_Ele.Controls.Add(lblElement);
                    //Add location of new Element
                    lblElement.Location = new Point(0, cls_Common.txtElementHeight);
                    //Update Complex Element in Main.panel_load
                    _Main.panelType.Controls.Add(uc_Ele);
                    //Add new Element parameter in Element
                    if (tempEle.Param == null ||tempEle.Param.ParamLists == null)
                    {
                        tempEle.Param = new ucParamLists();
                        tempEle.Param.ParamLists = new List<uc_Element>();
                    }
                    uc_Ele.Parentid = parentId;
                    var itmen = new uc_Element
                    {
                        ID = 1,
                        ParamName = uc_Ele.paramName,
                        dataType = uc_Ele.dataType,
                    };
                    tempEle.Param.ParamLists.Add(itmen);
                }
            }
            else if (uc_Ele.ID == 2)
            {
                var tempEle = ucLists.ElementResps.Where(i => i.parentid == parentId).FirstOrDefault();
                if (tempEle != null)
                {
                    //tempEle.ucSubLists.TypeId = (int)TypeEnum.Commplex;
                    if (tempEle.Param != null && tempEle.Param.ParamLists.Count > 0)
                    {
                        int count = tempEle.Param.ParamLists.Count;
                        //Update location of new Element parameter
                        cls_Common.txtElementHeight = (count * 20) + 70;
                        //Update param Count
                        cls_Common.paramCount++;
                    }
                    else
                    {
                        //Inilization location of new Element parameter
                        cls_Common.txtElementHeight = 70;
                        //Inilization param Count
                        cls_Common.paramCount = 1;
                    }
                    var lblElement = new Label
                    {
                        //Text = "+  " +  cls_Common.paramCount + " : " + uc_Ele.ResponseDataType,
                        Width = 182,
                        Height = 20,
                    };
                    lblElement.Click += _Main.AddElementProperty_Click;
                    uc_Ele.Controls.Add(lblElement);
                    //Add location of new Element
                    lblElement.Location = new Point(0, cls_Common.txtElementHeight);
                    //Update Complex Element in Main.panel_load
                    _Main.panelType.Controls.Add(uc_Ele);
                    //Add new Element parameter in Element
                    if (tempEle.Param == null || tempEle.Param.ParamLists == null)
                    {
                        tempEle.Param = new ucParamLists();
                        tempEle.Param.ParamLists = new List<uc_Element>();
                    }
                    uc_Ele.Parentid = parentId;
                    var itmen = new uc_Element
                    {
                        ID = 2,
                        ParamName = uc_Ele.paramName,
                        dataType = uc_Ele.dataType,
                    };
                    tempEle.Param.ParamLists.Add(itmen);
                }
            }
        }
    }
}
