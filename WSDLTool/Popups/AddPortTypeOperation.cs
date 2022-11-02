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
    public partial class AddPortTypeOperation : Form
    {
        public MainForm mainForm;
        public Control controls;
        public OperationType operations;
        public PortType value;
        public AddPortTypeOperation()
        {
            InitializeComponent();
        }

        public AddPortTypeOperation(MainForm _Main, Control _Control)
        {
            InitializeComponent();
            operations = new OperationType();
            mainForm = _Main;
            controls = _Control;
            cboOperationType.Items.Clear();
            foreach(var i in Enum.GetValues(typeof(PortType)))
            {
                cboOperationType.Items.Add(i.ToString());
            }
            if(ucLists.Mesages != null && ucLists.Mesages.Count > 0)
            {
                foreach (uc_Message msg in ucLists.Mesages)
                {
                    if(msg != null && msg.Part != null)
                    {
                        var item = msg.Part;
                        cboInputMessage.Items.Add(item.EleType);
                    }
                    
                }
            }

            if (ucLists.Mesages != null && ucLists.Mesages.Count > 0)
            {
                foreach (uc_Message msg in ucLists.Mesages)
                {
                    if (msg != null && msg.Part != null)
                    {
                        var item = msg.Part;
                        cboOutputMessage.Items.Add(item.EleType);
                    }

                }
            }

            gpboxInput.Visible = false;
            gpboxOutput.Visible = false;
            gpboxFaults.Visible = false;
        }

        private void cboOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedvalue = cboOperationType.Text;
            value = (PortType)Enum.Parse(typeof(PortType), selectedvalue);
            switch (value)
            {
                case PortType.Request_response:
                    {
                        gpboxInput.Visible = true;
                        gpboxOutput.Visible = true;
                        gpboxOutput.Location = new Point(15, 257);
                        gpboxFaults.Visible = true;
                        break;
                    }
                case PortType.Solicit_response:
                    {
                        gpboxInput.Visible = true;
                        gpboxOutput.Visible = true;
                        gpboxOutput.Location = new Point(15, 257);
                        gpboxFaults.Visible = true;
                        break;
                    }
                case PortType.One_way:
                    {
                        gpboxInput.Visible = true;
                        gpboxOutput.Visible = false;
                        gpboxFaults.Visible = false;
                        break;
                    }
                case PortType.Notification:
                    {
                        gpboxInput.Visible = false;
                        gpboxOutput.Visible = true;
                        gpboxOutput.Location = new Point(15, 123);
                        gpboxFaults.Visible = false;
                        break;
                    }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            operations = new OperationType();
            operations.OprationName = txtOperationName.Text;
            if(operations.clsPortTypes == null)
            {
                operations.clsPortTypes = new List<ClsPortType>();
            }
            switch (value)
            {
                case PortType.Request_response:
                    {
                        operations.clsPortTypes.Add(new ClsPortType { PortTypeId ="input", InputName = txtInputName.Text,Message = cboInputMessage.Text });
                        operations.clsPortTypes.Add(new ClsPortType { PortTypeId = "output", InputName = txtOutputName.Text, Message = cboOutputMessage.Text });
                        break;
                    }
                case PortType.Solicit_response:
                    {
                        operations.clsPortTypes.Add(new ClsPortType { PortTypeId = "output", InputName = txtOutputName.Text, Message = cboOutputMessage.Text });
                        operations.clsPortTypes.Add(new ClsPortType { PortTypeId = "input", InputName = txtInputName.Text, Message = cboInputMessage.Text });                        
                        break;
                    }
                case PortType.One_way:
                    {
                        operations.clsPortTypes.Add(new ClsPortType { PortTypeId = "input", InputName = txtInputName.Text, Message = cboInputMessage.Text });                        
                        break;
                    }
                case PortType.Notification:
                    {
                        operations.clsPortTypes.Add(new ClsPortType { PortTypeId = "output", InputName = txtOutputName.Text, Message = cboOutputMessage.Text });
                        break;
                    }
            }
            uc_PortType _PortType = new uc_PortType(mainForm, controls, operations);
            this.Close();
        }
    }
}
