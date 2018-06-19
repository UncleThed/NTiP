namespace View
{
    partial class PyramidControl
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
            this.PyramidGroup = new System.Windows.Forms.GroupBox();
            this.baseAreaBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PyramidGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PyramidGroup
            // 
            this.PyramidGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PyramidGroup.Controls.Add(this.baseAreaBox);
            this.PyramidGroup.Controls.Add(this.label5);
            this.PyramidGroup.Controls.Add(this.heightBox);
            this.PyramidGroup.Controls.Add(this.label6);
            this.PyramidGroup.Location = new System.Drawing.Point(3, 0);
            this.PyramidGroup.Name = "PyramidGroup";
            this.PyramidGroup.Size = new System.Drawing.Size(194, 117);
            this.PyramidGroup.TabIndex = 15;
            this.PyramidGroup.TabStop = false;
            // 
            // baseAreaBox
            // 
            this.baseAreaBox.Location = new System.Drawing.Point(84, 51);
            this.baseAreaBox.Name = "baseAreaBox";
            this.baseAreaBox.Size = new System.Drawing.Size(100, 22);
            this.baseAreaBox.TabIndex = 14;
            this.baseAreaBox.Text = "0";
            this.baseAreaBox.Enter += new System.EventHandler(this.BaseAreaBox_Enter);
            this.baseAreaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseAreaBox_KeyPress);
            this.baseAreaBox.Leave += new System.EventHandler(this.BaseAreaBox_Leave);
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
            this.heightBox.Enter += new System.EventHandler(this.HeightBox_Enter);
            this.heightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightBox_KeyPress);
            this.heightBox.Leave += new System.EventHandler(this.HeightBox_Leave);
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
            // PyramidControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PyramidGroup);
            this.Name = "PyramidControl";
            this.Size = new System.Drawing.Size(200, 120);
            this.PyramidGroup.ResumeLayout(false);
            this.PyramidGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PyramidGroup;
        private System.Windows.Forms.TextBox baseAreaBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label label6;
    }
}
