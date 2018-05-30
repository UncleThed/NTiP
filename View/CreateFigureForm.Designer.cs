namespace View
{
    partial class CreateFigureForm
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
            this.SelectFigureBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sideABox = new System.Windows.Forms.MaskedTextBox();
            this.sideBBox = new System.Windows.Forms.MaskedTextBox();
            this.sideCBox = new System.Windows.Forms.MaskedTextBox();
            this.ParallelepipedGroup = new System.Windows.Forms.GroupBox();
            this.PyramidGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.baseAreaBox = new System.Windows.Forms.MaskedTextBox();
            this.SphereGroup = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radiusBox = new System.Windows.Forms.MaskedTextBox();
            this.ParallelepipedGroup.SuspendLayout();
            this.PyramidGroup.SuspendLayout();
            this.SphereGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFigureBox
            // 
            this.SelectFigureBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectFigureBox.FormattingEnabled = true;
            this.SelectFigureBox.Items.AddRange(new object[] {
            "Parallelepiped",
            "Pyramid",
            "Sphere"});
            this.SelectFigureBox.Location = new System.Drawing.Point(9, 38);
            this.SelectFigureBox.Name = "SelectFigureBox";
            this.SelectFigureBox.Size = new System.Drawing.Size(176, 24);
            this.SelectFigureBox.TabIndex = 0;
            this.SelectFigureBox.SelectedIndexChanged += new System.EventHandler(this.SelectFigureBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(182, 276);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(162, 34);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a figure from the list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "side A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "side B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "side C";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sideABox
            // 
            this.sideABox.Location = new System.Drawing.Point(59, 21);
            this.sideABox.Mask = "00000";
            this.sideABox.Name = "sideABox";
            this.sideABox.PromptChar = '0';
            this.sideABox.Size = new System.Drawing.Size(100, 22);
            this.sideABox.TabIndex = 7;
            this.sideABox.ValidatingType = typeof(int);
            // 
            // sideBBox
            // 
            this.sideBBox.Location = new System.Drawing.Point(59, 49);
            this.sideBBox.Mask = "00000";
            this.sideBBox.Name = "sideBBox";
            this.sideBBox.PromptChar = '0';
            this.sideBBox.Size = new System.Drawing.Size(100, 22);
            this.sideBBox.TabIndex = 8;
            this.sideBBox.ValidatingType = typeof(int);
            // 
            // sideCBox
            // 
            this.sideCBox.Location = new System.Drawing.Point(59, 77);
            this.sideCBox.Mask = "00000";
            this.sideCBox.Name = "sideCBox";
            this.sideCBox.PromptChar = '0';
            this.sideCBox.Size = new System.Drawing.Size(100, 22);
            this.sideCBox.TabIndex = 9;
            this.sideCBox.ValidatingType = typeof(int);
            // 
            // ParallelepipedGroup
            // 
            this.ParallelepipedGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParallelepipedGroup.Controls.Add(this.label2);
            this.ParallelepipedGroup.Controls.Add(this.sideABox);
            this.ParallelepipedGroup.Controls.Add(this.label3);
            this.ParallelepipedGroup.Controls.Add(this.sideCBox);
            this.ParallelepipedGroup.Controls.Add(this.sideBBox);
            this.ParallelepipedGroup.Controls.Add(this.label4);
            this.ParallelepipedGroup.Location = new System.Drawing.Point(494, 112);
            this.ParallelepipedGroup.Name = "ParallelepipedGroup";
            this.ParallelepipedGroup.Size = new System.Drawing.Size(194, 122);
            this.ParallelepipedGroup.TabIndex = 10;
            this.ParallelepipedGroup.TabStop = false;
            this.ParallelepipedGroup.Visible = false;
            this.ParallelepipedGroup.Enter += new System.EventHandler(this.ParallelepipedGroup_Enter);
            // 
            // PyramidGroup
            // 
            this.PyramidGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PyramidGroup.Controls.Add(this.label5);
            this.PyramidGroup.Controls.Add(this.heightBox);
            this.PyramidGroup.Controls.Add(this.label6);
            this.PyramidGroup.Controls.Add(this.baseAreaBox);
            this.PyramidGroup.Location = new System.Drawing.Point(30, 112);
            this.PyramidGroup.Name = "PyramidGroup";
            this.PyramidGroup.Size = new System.Drawing.Size(194, 122);
            this.PyramidGroup.TabIndex = 11;
            this.PyramidGroup.TabStop = false;
            this.PyramidGroup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "height";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(84, 21);
            this.heightBox.Mask = "00000";
            this.heightBox.Name = "heightBox";
            this.heightBox.PromptChar = '0';
            this.heightBox.Size = new System.Drawing.Size(100, 22);
            this.heightBox.TabIndex = 7;
            this.heightBox.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "base area";
            // 
            // baseAreaBox
            // 
            this.baseAreaBox.Location = new System.Drawing.Point(84, 49);
            this.baseAreaBox.Mask = "00000";
            this.baseAreaBox.Name = "baseAreaBox";
            this.baseAreaBox.PromptChar = '0';
            this.baseAreaBox.Size = new System.Drawing.Size(100, 22);
            this.baseAreaBox.TabIndex = 8;
            this.baseAreaBox.ValidatingType = typeof(int);
            // 
            // SphereGroup
            // 
            this.SphereGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SphereGroup.Controls.Add(this.label8);
            this.SphereGroup.Controls.Add(this.radiusBox);
            this.SphereGroup.Location = new System.Drawing.Point(257, 112);
            this.SphereGroup.Name = "SphereGroup";
            this.SphereGroup.Size = new System.Drawing.Size(194, 122);
            this.SphereGroup.TabIndex = 12;
            this.SphereGroup.TabStop = false;
            this.SphereGroup.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "radius";
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(59, 21);
            this.radiusBox.Mask = "00000";
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.PromptChar = '0';
            this.radiusBox.Size = new System.Drawing.Size(100, 22);
            this.radiusBox.TabIndex = 7;
            this.radiusBox.ValidatingType = typeof(int);
            // 
            // CreateFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 501);
            this.Controls.Add(this.SphereGroup);
            this.Controls.Add(this.PyramidGroup);
            this.Controls.Add(this.ParallelepipedGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SelectFigureBox);
            this.Name = "CreateFigureForm";
            this.Text = "Create Figure";
            this.ParallelepipedGroup.ResumeLayout(false);
            this.ParallelepipedGroup.PerformLayout();
            this.PyramidGroup.ResumeLayout(false);
            this.PyramidGroup.PerformLayout();
            this.SphereGroup.ResumeLayout(false);
            this.SphereGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectFigureBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox sideABox;
        private System.Windows.Forms.MaskedTextBox sideBBox;
        private System.Windows.Forms.MaskedTextBox sideCBox;
        private System.Windows.Forms.GroupBox PyramidGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox heightBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox baseAreaBox;
        private System.Windows.Forms.GroupBox SphereGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox radiusBox;
        private System.Windows.Forms.GroupBox ParallelepipedGroup;
    }
}