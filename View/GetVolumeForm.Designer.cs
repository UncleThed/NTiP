namespace View
{
    partial class GetVolumeForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GridControl = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.RemoveFigure = new System.Windows.Forms.Button();
            this.AddFigure = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControl
            // 
            this.GridControl.Controls.Add(this.DataGridView);
            this.GridControl.Controls.Add(this.RemoveFigure);
            this.GridControl.Controls.Add(this.AddFigure);
            this.GridControl.Location = new System.Drawing.Point(12, 12);
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(519, 298);
            this.GridControl.TabIndex = 0;
            this.GridControl.TabStop = false;
            this.GridControl.Text = "GridControl";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView.Location = new System.Drawing.Point(0, 118);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(327, 174);
            this.DataGridView.TabIndex = 2;
            // 
            // RemoveFigure
            // 
            this.RemoveFigure.Location = new System.Drawing.Point(6, 59);
            this.RemoveFigure.Name = "RemoveFigure";
            this.RemoveFigure.Size = new System.Drawing.Size(151, 35);
            this.RemoveFigure.TabIndex = 1;
            this.RemoveFigure.Text = "Remove Figure";
            this.RemoveFigure.UseVisualStyleBackColor = true;
            this.RemoveFigure.Click += new System.EventHandler(this.RemoveFigure_Click);
            // 
            // AddFigure
            // 
            this.AddFigure.Location = new System.Drawing.Point(6, 21);
            this.AddFigure.Name = "AddFigure";
            this.AddFigure.Size = new System.Drawing.Size(151, 32);
            this.AddFigure.TabIndex = 0;
            this.AddFigure.Text = "Add Figure";
            this.AddFigure.UseVisualStyleBackColor = true;
            this.AddFigure.Click += new System.EventHandler(this.AddFigure_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "Figure";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Volume";
            this.Column2.HeaderText = "Volume";
            this.Column2.Name = "Column2";
            // 
            // GetVolumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 355);
            this.Controls.Add(this.GridControl);
            this.Name = "GetVolumeForm";
            this.Text = "Get Volume";
            this.GridControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GridControl;
        private System.Windows.Forms.Button RemoveFigure;
        private System.Windows.Forms.Button AddFigure;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

