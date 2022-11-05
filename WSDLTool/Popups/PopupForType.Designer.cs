namespace WSDLTool.Popups
{
    partial class PopupForType
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
            this.btn_addElement = new System.Windows.Forms.Button();
            this.btn_addComplextType = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addElement
            // 
            this.btn_addElement.Location = new System.Drawing.Point(13, 13);
            this.btn_addElement.Name = "btn_addElement";
            this.btn_addElement.Size = new System.Drawing.Size(109, 45);
            this.btn_addElement.TabIndex = 0;
            this.btn_addElement.Text = "Add Element";
            this.btn_addElement.UseVisualStyleBackColor = true;
            this.btn_addElement.Click += new System.EventHandler(this.btn_addElement_Click);
            // 
            // btn_addComplextType
            // 
            this.btn_addComplextType.Location = new System.Drawing.Point(13, 64);
            this.btn_addComplextType.Name = "btn_addComplextType";
            this.btn_addComplextType.Size = new System.Drawing.Size(109, 45);
            this.btn_addComplextType.TabIndex = 1;
            this.btn_addComplextType.Text = "Add ComplexType";
            this.btn_addComplextType.UseVisualStyleBackColor = true;
            this.btn_addComplextType.Click += new System.EventHandler(this.btn_addComplextType_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Simple Type";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(128, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Add Attribute";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(128, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Union";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 166);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "Add Model Group";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(128, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "Add Enum";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(128, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Add Any";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // PopupForType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 225);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_addComplextType);
            this.Controls.Add(this.btn_addElement);
            this.Name = "PopupForType";
            this.Text = "PopupForType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addElement;
        private System.Windows.Forms.Button btn_addComplextType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}