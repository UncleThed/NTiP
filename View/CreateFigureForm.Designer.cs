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
            this.ParallelepipedGroup = new System.Windows.Forms.GroupBox();
            this.sideABox = new System.Windows.Forms.TextBox();
            this.sideBBox = new System.Windows.Forms.TextBox();
            this.sideCBox = new System.Windows.Forms.TextBox();
            this.PyramidGroup = new System.Windows.Forms.GroupBox();
            this.baseAreaBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SphereGroup = new System.Windows.Forms.GroupBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.randomButton = new System.Windows.Forms.Button();
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
            this.cancelButton.Location = new System.Drawing.Point(30, 256);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(203, 256);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(155, 34);
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
            // ParallelepipedGroup
            // 
            this.ParallelepipedGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParallelepipedGroup.Controls.Add(this.sideABox);
            this.ParallelepipedGroup.Controls.Add(this.sideBBox);
            this.ParallelepipedGroup.Controls.Add(this.sideCBox);
            this.ParallelepipedGroup.Controls.Add(this.label2);
            this.ParallelepipedGroup.Controls.Add(this.label3);
            this.ParallelepipedGroup.Controls.Add(this.label4);
            this.ParallelepipedGroup.Location = new System.Drawing.Point(427, 145);
            this.ParallelepipedGroup.Name = "ParallelepipedGroup";
            this.ParallelepipedGroup.Size = new System.Drawing.Size(194, 122);
            this.ParallelepipedGroup.TabIndex = 10;
            this.ParallelepipedGroup.TabStop = false;
            this.ParallelepipedGroup.Visible = false;
            this.ParallelepipedGroup.Enter += new System.EventHandler(this.ParallelepipedGroup_Enter);
            // 
            // sideABox
            // 
            this.sideABox.Location = new System.Drawing.Point(59, 23);
            this.sideABox.Name = "sideABox";
            this.sideABox.Size = new System.Drawing.Size(100, 22);
            this.sideABox.TabIndex = 17;
            this.sideABox.Text = "0";
            this.sideABox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sideABox_KeyPress);
            // 
            // sideBBox
            // 
            this.sideBBox.Location = new System.Drawing.Point(59, 51);
            this.sideBBox.Name = "sideBBox";
            this.sideBBox.Size = new System.Drawing.Size(100, 22);
            this.sideBBox.TabIndex = 15;
            this.sideBBox.Text = "0";
            this.sideBBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sideBBox_KeyPress);
            // 
            // sideCBox
            // 
            this.sideCBox.Location = new System.Drawing.Point(59, 79);
            this.sideCBox.Name = "sideCBox";
            this.sideCBox.Size = new System.Drawing.Size(100, 22);
            this.sideCBox.TabIndex = 16;
            this.sideCBox.Text = "0";
            this.sideCBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sideCBox_KeyPress);
            // 
            // PyramidGroup
            // 
            this.PyramidGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PyramidGroup.Controls.Add(this.baseAreaBox);
            this.PyramidGroup.Controls.Add(this.label5);
            this.PyramidGroup.Controls.Add(this.heightBox);
            this.PyramidGroup.Controls.Add(this.label6);
            this.PyramidGroup.Location = new System.Drawing.Point(427, 17);
            this.PyramidGroup.Name = "PyramidGroup";
            this.PyramidGroup.Size = new System.Drawing.Size(194, 122);
            this.PyramidGroup.TabIndex = 11;
            this.PyramidGroup.TabStop = false;
            this.PyramidGroup.Visible = false;
            // 
            // baseAreaBox
            // 
            this.baseAreaBox.Location = new System.Drawing.Point(84, 51);
            this.baseAreaBox.Name = "baseAreaBox";
            this.baseAreaBox.Size = new System.Drawing.Size(100, 22);
            this.baseAreaBox.TabIndex = 14;
            this.baseAreaBox.Text = "0";
            this.baseAreaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baseAreaBox_KeyPress);
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
            this.heightBox.Location = new System.Drawing.Point(84, 23);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 22);
            this.heightBox.TabIndex = 13;
            this.heightBox.Tag = "";
            this.heightBox.Text = "0";
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightBox_KeyPress);
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
            // SphereGroup
            // 
            this.SphereGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SphereGroup.Controls.Add(this.radiusBox);
            this.SphereGroup.Controls.Add(this.label8);
            this.SphereGroup.Location = new System.Drawing.Point(655, 66);
            this.SphereGroup.Name = "SphereGroup";
            this.SphereGroup.Size = new System.Drawing.Size(194, 122);
            this.SphereGroup.TabIndex = 12;
            this.SphereGroup.TabStop = false;
            this.SphereGroup.Visible = false;
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(59, 23);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(100, 22);
            this.radiusBox.TabIndex = 14;
            this.radiusBox.Text = "0";
            this.radiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusBox_KeyPress);
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
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(224, 183);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(155, 48);
            this.randomButton.TabIndex = 13;
            this.randomButton.Text = "Create Random Data";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // CreateFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 501);
            this.Controls.Add(this.randomButton);
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
        private System.Windows.Forms.GroupBox PyramidGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox SphereGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox ParallelepipedGroup;
        private System.Windows.Forms.TextBox sideABox;
        private System.Windows.Forms.TextBox sideBBox;
        private System.Windows.Forms.TextBox sideCBox;
        private System.Windows.Forms.TextBox baseAreaBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Button randomButton;
    }
}