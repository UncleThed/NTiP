namespace View
{
    partial class ParallelepipedControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParallelepipedGroup = new System.Windows.Forms.GroupBox();
            this.sideABox = new System.Windows.Forms.TextBox();
            this.sideBBox = new System.Windows.Forms.TextBox();
            this.sideCBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ParallelepipedGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParallelepipedGroup
            // 
            this.ParallelepipedGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParallelepipedGroup.Controls.Add(this.sideABox);
            this.ParallelepipedGroup.Controls.Add(this.sideBBox);
            this.ParallelepipedGroup.Controls.Add(this.sideCBox);
            this.ParallelepipedGroup.Controls.Add(this.label2);
            this.ParallelepipedGroup.Controls.Add(this.label3);
            this.ParallelepipedGroup.Controls.Add(this.label4);
            this.ParallelepipedGroup.Location = new System.Drawing.Point(3, 1);
            this.ParallelepipedGroup.Name = "ParallelepipedGroup";
            this.ParallelepipedGroup.Size = new System.Drawing.Size(194, 116);
            this.ParallelepipedGroup.TabIndex = 11;
            this.ParallelepipedGroup.TabStop = false;
            // 
            // sideABox
            // 
            this.sideABox.Location = new System.Drawing.Point(59, 23);
            this.sideABox.Name = "sideABox";
            this.sideABox.Size = new System.Drawing.Size(100, 22);
            this.sideABox.TabIndex = 17;
            this.sideABox.Text = "0";
            this.sideABox.Enter += new System.EventHandler(this.SideABox_Enter);
            this.sideABox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideABox_KeyPress);
            this.sideABox.Leave += new System.EventHandler(this.SideABox_Leave);
            // 
            // sideBBox
            // 
            this.sideBBox.Location = new System.Drawing.Point(59, 51);
            this.sideBBox.Name = "sideBBox";
            this.sideBBox.Size = new System.Drawing.Size(100, 22);
            this.sideBBox.TabIndex = 15;
            this.sideBBox.Text = "0";
            this.sideBBox.Enter += new System.EventHandler(this.SideBBox_Enter);
            this.sideBBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideBBox_KeyPress);
            this.sideBBox.Leave += new System.EventHandler(this.SideBBox_Leave);
            // 
            // sideCBox
            // 
            this.sideCBox.Location = new System.Drawing.Point(59, 79);
            this.sideCBox.Name = "sideCBox";
            this.sideCBox.Size = new System.Drawing.Size(100, 22);
            this.sideCBox.TabIndex = 16;
            this.sideCBox.Text = "0";
            this.sideCBox.Enter += new System.EventHandler(this.SideCBox_Enter);
            this.sideCBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SideCBox_KeyPress);
            this.sideCBox.Leave += new System.EventHandler(this.SideCBox_Leave);
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
            // 
            // ParallelepipedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParallelepipedGroup);
            this.Name = "ParallelepipedControl";
            this.Size = new System.Drawing.Size(200, 120);
            this.ParallelepipedGroup.ResumeLayout(false);
            this.ParallelepipedGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ParallelepipedGroup;
        private System.Windows.Forms.TextBox sideABox;
        private System.Windows.Forms.TextBox sideBBox;
        private System.Windows.Forms.TextBox sideCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
