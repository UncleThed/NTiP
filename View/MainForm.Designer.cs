using System.Windows.Forms;

namespace View
{
    partial class MainForm
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
            this.sphereInfoControl = new View.SphereControl();
            this.pyramidInfoControl = new View.PyramidControl();
            this.parallelepipedInfoControl = new View.ParallelepipedControl();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxVolumeBox = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.minVolumeBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GridControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridControl
            // 
            this.GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridControl.Controls.Add(this.sphereInfoControl);
            this.GridControl.Controls.Add(this.pyramidInfoControl);
            this.GridControl.Controls.Add(this.parallelepipedInfoControl);
            this.GridControl.Controls.Add(this.button1);
            this.GridControl.Controls.Add(this.label2);
            this.GridControl.Controls.Add(this.label1);
            this.GridControl.Controls.Add(this.maxVolumeBox);
            this.GridControl.Controls.Add(this.DataGridView);
            this.GridControl.Controls.Add(this.removeButton);
            this.GridControl.Controls.Add(this.minVolumeBox);
            this.GridControl.Controls.Add(this.addButton);
            this.GridControl.Location = new System.Drawing.Point(9, 43);
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(597, 395);
            this.GridControl.TabIndex = 0;
            this.GridControl.TabStop = false;
            // 
            // sphereInfoControl
            // 
            this.sphereInfoControl.Location = new System.Drawing.Point(360, 79);
            this.sphereInfoControl.Name = "sphereInfoControl";
            this.sphereInfoControl.ReadOnly = true;
            this.sphereInfoControl.Size = new System.Drawing.Size(200, 120);
            this.sphereInfoControl.Sphere = null;
            this.sphereInfoControl.TabIndex = 11;
            // 
            // pyramidInfoControl
            // 
            this.pyramidInfoControl.Location = new System.Drawing.Point(360, 79);
            this.pyramidInfoControl.Name = "pyramidInfoControl";
            this.pyramidInfoControl.Pyramid = null;
            this.pyramidInfoControl.ReadOnly = true;
            this.pyramidInfoControl.Size = new System.Drawing.Size(200, 120);
            this.pyramidInfoControl.TabIndex = 10;
            // 
            // parallelepipedInfoControl
            // 
            this.parallelepipedInfoControl.Location = new System.Drawing.Point(360, 79);
            this.parallelepipedInfoControl.Name = "parallelepipedInfoControl";
            this.parallelepipedInfoControl.Parallelepiped = null;
            this.parallelepipedInfoControl.ReadOnly = true;
            this.parallelepipedInfoControl.Size = new System.Drawing.Size(200, 120);
            this.parallelepipedInfoControl.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(124, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Volume";
            // 
            // maxVolumeBox
            // 
            this.maxVolumeBox.Location = new System.Drawing.Point(192, 21);
            this.maxVolumeBox.Name = "maxVolumeBox";
            this.maxVolumeBox.Size = new System.Drawing.Size(100, 22);
            this.maxVolumeBox.TabIndex = 5;
            this.maxVolumeBox.TextChanged += new System.EventHandler(this.MaxVolumeBox_TextChanged);
            this.maxVolumeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxVolumeBox_KeyPress);
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView.Location = new System.Drawing.Point(6, 79);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.Size = new System.Drawing.Size(327, 259);
            this.DataGridView.TabIndex = 2;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "Figure";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Volume";
            this.Column2.HeaderText = "Volume";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(242, 354);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(113, 35);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // minVolumeBox
            // 
            this.minVolumeBox.Location = new System.Drawing.Point(67, 21);
            this.minVolumeBox.Name = "minVolumeBox";
            this.minVolumeBox.Size = new System.Drawing.Size(100, 22);
            this.minVolumeBox.TabIndex = 4;
            this.minVolumeBox.TextChanged += new System.EventHandler(this.MinVolumeBox_TextChanged);
            this.minVolumeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinVolumeBox_KeyPress);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(6, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(618, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.GridControl);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(636, 497);
            this.MaximumSize = new System.Drawing.Size(636, 497);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Three-dimensional figures";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.GridControl.ResumeLayout(false);
            this.GridControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GridControl;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox maxVolumeBox;
        private System.Windows.Forms.TextBox minVolumeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button1;
        private SphereControl sphereInfoControl;
        private PyramidControl pyramidInfoControl;
        private ParallelepipedControl parallelepipedInfoControl;
    }
}

