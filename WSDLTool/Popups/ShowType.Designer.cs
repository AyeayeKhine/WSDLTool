namespace WSDLTool.Popups
{
    partial class ShowType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("XSD Types");
            this.typeviews = new System.Windows.Forms.TreeView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeviews
            // 
            this.typeviews.Location = new System.Drawing.Point(0, 1);
            this.typeviews.Name = "typeviews";
            treeNode2.Name = "Node0";
            treeNode2.Text = "XSD Types";
            this.typeviews.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.typeviews.Size = new System.Drawing.Size(296, 177);
            this.typeviews.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(219, 193);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 33);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ShowType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 227);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.typeviews);
            this.Name = "ShowType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView typeviews;
        private System.Windows.Forms.Button btnSelect;
    }
}