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
using WSDLTool.Helpers;

namespace WSDLTool.Controls
{
    public partial class uc_PortType : UserControl
    {
        private int id;
        private string name;
        private List<OperationType> operationType;
        public int Id { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public List<OperationType> OperationType
        {
            get => operationType;
            set
            {
                if (value == null)
                {
                    operationType = new List<OperationType>();
                }
                else
                {
                    operationType = value;
                }
            }
        }

        public uc_PortType()
        {
            InitializeComponent();
        }

        public uc_PortType(MainForm _Main, Point _Loc, string _Name)
        {
            InitializeComponent();
            this.addOperationItem.Click += _Main.addOperationItem_Click;
            var point = new Point();
            point.X = _Loc.X + 20;
            point.Y = _Loc.Y + 20;
            this.Location = point;
            Point point1 = new Point(_Loc.X + 30, _Loc.Y + 30);
            this.Location = point1;
            this.Id = cls_Common.parentCount;
            this.Name1 = _Name;
            lblPortType.Text = _Name;   
            ControlExtension.Draggable(this, true);
            _Main.panelPortType.Controls.Add(this);
            ucLists.PortTypes.Add(this);
            cls_Common.parentCount++;
        }

        public uc_PortType(MainForm _Main, Control _Control,OperationType _OperationTyes)
        {
            InitializeComponent();
            var pType = (uc_PortType)_Control;
            int id = pType.Id;

            if(_OperationTyes.clsPortTypes != null && _OperationTyes.clsPortTypes.Count > 0)
            {
                var lblElement = new Label
                {
                    Text = "+  " + _OperationTyes.clsPortTypes[0].InputName + " : " + _OperationTyes.clsPortTypes[0].Message,
                    TextAlign=ContentAlignment.MiddleCenter,
                    AutoSize = true,
                };
                for(int i = 1;i < _OperationTyes.clsPortTypes.Count; i++)
                {
                    lblElement.Text += "\n   " + _OperationTyes.clsPortTypes[i].InputName + " : " + _OperationTyes.clsPortTypes[i].Message;
                }
                //Add location of new Element
                cls_Common.txtElementHeight = 70;
                lblElement.Location = new Point(0, cls_Common.txtElementHeight);
                pType.Controls.Add(lblElement);
                //Update PortType in Main.panel_load
                _Main.panelPortType.Controls.Add(pType);
                var oldPort = ucLists.PortTypes.Where(ms => ms.Id == id).FirstOrDefault();
                if (oldPort.operationType == null)
                {
                    oldPort.operationType = new List<OperationType>();
                }
                oldPort.operationType.Add(_OperationTyes);
            }
        }
    }
}
