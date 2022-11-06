namespace WSDLTool.Popups
{
    partial class AddElement_popup
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
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboBuiltin_type = new System.Windows.Forms.ComboBox();
            this.btn_definedType = new System.Windows.Forms.Button();
            this.gpBoxType = new System.Windows.Forms.GroupBox();
            this.rSimpleType = new System.Windows.Forms.RadioButton();
            this.rComplexType = new System.Windows.Forms.RadioButton();
            this.ckNestedType = new System.Windows.Forms.CheckBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtEleValue = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinOccours = new System.Windows.Forms.TextBox();
            this.txtMaxOccours = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboForm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.gpBoxElement = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gpBoxType.SuspendLayout();
            this.gpBoxElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(130, 41);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(170, 20);
            this.txtElementName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ElementName :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(17, 81);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // cboBuiltin_type
            // 
            this.cboBuiltin_type.FormattingEnabled = true;
            this.cboBuiltin_type.Location = new System.Drawing.Point(131, 76);
            this.cboBuiltin_type.Name = "cboBuiltin_type";
            this.cboBuiltin_type.Size = new System.Drawing.Size(135, 21);
            this.cboBuiltin_type.TabIndex = 5;
            // 
            // btn_definedType
            // 
            this.btn_definedType.Location = new System.Drawing.Point(262, 75);
            this.btn_definedType.Name = "btn_definedType";
            this.btn_definedType.Size = new System.Drawing.Size(39, 23);
            this.btn_definedType.TabIndex = 6;
            this.btn_definedType.Text = "---";
            this.btn_definedType.UseVisualStyleBackColor = true;
            // 
            // gpBoxType
            // 
            this.gpBoxType.Controls.Add(this.rSimpleType);
            this.gpBoxType.Controls.Add(this.rComplexType);
            this.gpBoxType.Location = new System.Drawing.Point(12, 138);
            this.gpBoxType.Name = "gpBoxType";
            this.gpBoxType.Size = new System.Drawing.Size(322, 79);
            this.gpBoxType.TabIndex = 7;
            this.gpBoxType.TabStop = false;
            this.gpBoxType.Text = "Type";
            this.gpBoxType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rSimpleType
            // 
            this.rSimpleType.AutoSize = true;
            this.rSimpleType.Location = new System.Drawing.Point(25, 42);
            this.rSimpleType.Name = "rSimpleType";
            this.rSimpleType.Size = new System.Drawing.Size(80, 17);
            this.rSimpleType.TabIndex = 1;
            this.rSimpleType.TabStop = true;
            this.rSimpleType.Text = "SimpleType";
            this.rSimpleType.UseVisualStyleBackColor = true;
            // 
            // rComplexType
            // 
            this.rComplexType.AutoSize = true;
            this.rComplexType.Location = new System.Drawing.Point(25, 19);
            this.rComplexType.Name = "rComplexType";
            this.rComplexType.Size = new System.Drawing.Size(89, 17);
            this.rComplexType.TabIndex = 0;
            this.rComplexType.TabStop = true;
            this.rComplexType.Text = "ComplexType";
            this.rComplexType.UseVisualStyleBackColor = true;
            // 
            // ckNestedType
            // 
            this.ckNestedType.AutoSize = true;
            this.ckNestedType.Location = new System.Drawing.Point(243, 115);
            this.ckNestedType.Name = "ckNestedType";
            this.ckNestedType.Size = new System.Drawing.Size(84, 17);
            this.ckNestedType.TabIndex = 2;
            this.ckNestedType.Text = "NestedType";
            this.ckNestedType.UseVisualStyleBackColor = true;
            this.ckNestedType.CheckedChanged += new System.EventHandler(this.ckNestedType_CheckedChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(117, 637);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Value:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(129, 56);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Default";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtEleValue
            // 
            this.txtEleValue.Location = new System.Drawing.Point(129, 30);
            this.txtEleValue.Name = "txtEleValue";
            this.txtEleValue.Size = new System.Drawing.Size(170, 20);
            this.txtEleValue.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(249, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fixed";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "MinOccurs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "MaxOccurs:";
            // 
            // txtMinOccours
            // 
            this.txtMinOccours.Location = new System.Drawing.Point(130, 79);
            this.txtMinOccours.Name = "txtMinOccours";
            this.txtMinOccours.Size = new System.Drawing.Size(170, 20);
            this.txtMinOccours.TabIndex = 15;
            // 
            // txtMaxOccours
            // 
            this.txtMaxOccours.Location = new System.Drawing.Point(129, 109);
            this.txtMaxOccours.Name = "txtMaxOccours";
            this.txtMaxOccours.Size = new System.Drawing.Size(170, 20);
            this.txtMaxOccours.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Form:";
            // 
            // cboForm
            // 
            this.cboForm.FormattingEnabled = true;
            this.cboForm.Items.AddRange(new object[] {
            "qualified",
            "unqualified"});
            this.cboForm.Location = new System.Drawing.Point(130, 141);
            this.cboForm.Name = "cboForm";
            this.cboForm.Size = new System.Drawing.Size(169, 21);
            this.cboForm.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Annotation:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(131, 179);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(169, 100);
            this.txtNote.TabIndex = 20;
            this.txtNote.Text = "";
            // 
            // gpBoxElement
            // 
            this.gpBoxElement.Controls.Add(this.txtNote);
            this.gpBoxElement.Controls.Add(this.label7);
            this.gpBoxElement.Controls.Add(this.radioButton2);
            this.gpBoxElement.Controls.Add(this.txtEleValue);
            this.gpBoxElement.Controls.Add(this.cboForm);
            this.gpBoxElement.Controls.Add(this.label4);
            this.gpBoxElement.Controls.Add(this.radioButton1);
            this.gpBoxElement.Controls.Add(this.label6);
            this.gpBoxElement.Controls.Add(this.label5);
            this.gpBoxElement.Controls.Add(this.label3);
            this.gpBoxElement.Controls.Add(this.txtMaxOccours);
            this.gpBoxElement.Controls.Add(this.txtMinOccours);
            this.gpBoxElement.Controls.Add(this.btn_ok);
            this.gpBoxElement.Location = new System.Drawing.Point(12, 233);
            this.gpBoxElement.Name = "gpBoxElement";
            this.gpBoxElement.Size = new System.Drawing.Size(322, 280);
            this.gpBoxElement.TabIndex = 8;
            this.gpBoxElement.TabStop = false;
            this.gpBoxElement.Text = "Element Value";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddElement_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 513);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpBoxElement);
            this.Controls.Add(this.ckNestedType);
            this.Controls.Add(this.gpBoxType);
            this.Controls.Add(this.cboBuiltin_type);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_definedType);
            this.Name = "AddElement_popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddElement_popup";
            this.gpBoxType.ResumeLayout(false);
            this.gpBoxType.PerformLayout();
            this.gpBoxElement.ResumeLayout(false);
            this.gpBoxElement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboBuiltin_type;
        private System.Windows.Forms.Button btn_definedType;
        private System.Windows.Forms.GroupBox gpBoxType;
        private System.Windows.Forms.RadioButton rSimpleType;
        private System.Windows.Forms.RadioButton rComplexType;
        private System.Windows.Forms.CheckBox ckNestedType;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtEleValue;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinOccours;
        private System.Windows.Forms.TextBox txtMaxOccours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.GroupBox gpBoxElement;
        private System.Windows.Forms.Button btnSave;
    }
}