namespace WSDLTool.Controls
{
    partial class uc_ComplexType
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblElement = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblElement
            // 
            this.lblElement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement.Location = new System.Drawing.Point(0, 0);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(256, 31);
            this.lblElement.TabIndex = 1;
            this.lblElement.Text = "<<XSD:ComplexType>>";
            this.lblElement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeName
            // 
            this.lblTypeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeName.Location = new System.Drawing.Point(0, 31);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(256, 25);
            this.lblTypeName.TabIndex = 3;
            this.lblTypeName.Text = "label1";
            this.lblTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_ComplexType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.lblElement);
            this.Name = "uc_ComplexType";
            this.Size = new System.Drawing.Size(256, 173);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblTypeName;
    }
}
