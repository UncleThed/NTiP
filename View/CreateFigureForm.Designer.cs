using System.Windows.Forms;

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
            this.parallelepipedControl = new View.ParallelepipedControl();
            this.pyramidControl = new View.PyramidControl();
            this.sphereControl = new View.SphereControl();
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
            this.SelectFigureBox.Location = new System.Drawing.Point(12, 38);
            this.SelectFigureBox.Name = "SelectFigureBox";
            this.SelectFigureBox.Size = new System.Drawing.Size(176, 24);
            this.SelectFigureBox.TabIndex = 0;
            this.SelectFigureBox.SelectedIndexChanged += new System.EventHandler(this.SelectFigureBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 307);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(173, 307);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(155, 34);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a figure from the list";
            // 
            // parallelepipedControl
            // 
            this.parallelepipedControl.Location = new System.Drawing.Point(-1, 238);
            this.parallelepipedControl.Name = "parallelepipedControl";
            this.parallelepipedControl.Parallelepiped = null;
            this.parallelepipedControl.ReadOnly = true;
            this.parallelepipedControl.Size = new System.Drawing.Size(230, 131);
            this.parallelepipedControl.TabIndex = 13;
            this.parallelepipedControl.Visible = false;
            // 
            // pyramidControl
            // 
            this.pyramidControl.Location = new System.Drawing.Point(296, 38);
            this.pyramidControl.Name = "pyramidControl";
            this.pyramidControl.Pyramid = null;
            this.pyramidControl.ReadOnly = true;
            this.pyramidControl.Size = new System.Drawing.Size(191, 115);
            this.pyramidControl.TabIndex = 15;
            this.pyramidControl.Visible = false;
            // 
            // sphereControl
            // 
            this.sphereControl.Location = new System.Drawing.Point(296, 238);
            this.sphereControl.Name = "sphereControl";
            this.sphereControl.ReadOnly = true;
            this.sphereControl.Size = new System.Drawing.Size(236, 151);
            this.sphereControl.Sphere = null;
            this.sphereControl.TabIndex = 16;
            this.sphereControl.Visible = false;
            // 
            // CreateFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.sphereControl);
            this.Controls.Add(this.pyramidControl);
            this.Controls.Add(this.parallelepipedControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SelectFigureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "CreateFigureForm";
            this.Text = "Create Figure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectFigureBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private ParallelepipedControl parallelepipedControl;
        private PyramidControl pyramidControl;
        private SphereControl sphereControl;
    }
}