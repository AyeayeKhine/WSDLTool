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

namespace WSDLTool.Popups
{
    public partial class ShowType : Form
    {
        public AddElement_popup mainform;
        //IDictionary<int, string> typeLists = new Dictionary<int, string>();
        public ShowType()
        {
            InitializeComponent();
            GetType();
        }
        public ShowType(AddElement_popup _addElement)
        {
            InitializeComponent();
            mainform = _addElement;
            GetType();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string selectEle = typeviews.SelectedNode.Text;
            mainform.cboBuiltin_type.Text = selectEle;
            this.Close();
        }

        private void GetType()
        {
            var resEle = ucLists.Elements.ToList();
            var childNode = typeviews.Nodes[0];
            childNode.Nodes.Clear();
            foreach (var ele in resEle)
            {
                childNode.Nodes.Add(ele.ID.ToString(), ele.Name1);
            }
        }
    }
}
