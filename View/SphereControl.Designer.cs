namespace View
{
    partial class SphereControl
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
            this.SphereGroup = new System.Windows.Forms.GroupBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SphereGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // SphereGroup
            // 
            this.SphereGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SphereGroup.Controls.Add(this.radiusBox);
            this.SphereGroup.Controls.Add(this.label8);
            this.SphereGroup.Location = new System.Drawing.Point(3, 3);
            this.SphereGroup.Name = "SphereGroup";
            this.SphereGroup.Size = new System.Drawing.Size(194, 114);
            this.SphereGroup.TabIndex = 13;
            this.SphereGroup.TabStop = false;
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(59, 23);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(100, 22);
            this.radiusBox.TabIndex = 14;
            this.radiusBox.Text = "0";
            this.radiusBox.Enter += new System.EventHandler(this.RadiusBox_Enter);
            this.radiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RadiusBox_KeyPress);
            this.radiusBox.Leave += new System.EventHandler(this.RadiusBox_Leave);
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
            // SphereControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SphereGroup);
            this.Name = "SphereControl";
            this.Size = new System.Drawing.Size(200, 120);
            this.SphereGroup.ResumeLayout(false);
            this.SphereGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SphereGroup;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Label label8;
    }
}
