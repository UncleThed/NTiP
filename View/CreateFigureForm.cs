using System;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Форма создания фигуры
    /// </summary>
    public partial class CreateFigureForm : Form
    {

        public IFigure Figure
        {
            get
            {
                switch (SelectFigureBox.SelectedIndex)
                {
                    case 0:
                        return parallelepipedControl.Parallelepiped;
                    case 1:    
                        return pyramidControl.Pyramid;
                    case 2:
                        return sphereControl.Sphere;
                    default:
                        return null;
                }
            }

            set
            {
                switch (value)
                {
                    case Parallelepiped parallelepiped:
                        SelectFigureBox.SelectedIndex = 0;
                        parallelepipedControl.Parallelepiped = parallelepiped;
                        break;
                    case Pyramid pyramid:
                        SelectFigureBox.SelectedIndex = 1;
                        pyramidControl.Pyramid = pyramid;
                        break;
                    case Sphere sphere:
                        SelectFigureBox.SelectedIndex = 2;
                        sphereControl.Sphere = sphere;
                        break;
                }
            }
        }

        public bool ReadOnly
        {
            set
            {
                parallelepipedControl.ReadOnly = value;
                pyramidControl.ReadOnly = value;
                sphereControl.ReadOnly = value;
            }
        }

        /// <summary>
        /// Конструктор класса CreateFigureForm
        /// </summary>
        public CreateFigureForm()
        {
            InitializeComponent();
            this.Size = new Size(320, 300);
            parallelepipedControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            pyramidControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            sphereControl.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
        }

        private void SelectFigureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectFigureBox.SelectedIndex == 0)
            {
                sphereControl.Visible = false;
                pyramidControl.Visible = false;
                parallelepipedControl.Visible = true;
                parallelepipedControl.Location = new Point(9, 75);


            }            
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                sphereControl.Visible = false;
                pyramidControl.Visible = true;
                parallelepipedControl.Visible = false;
                pyramidControl.Location = new Point(9, 75);
            }
            else if (SelectFigureBox.SelectedIndex == 2)
            {
                sphereControl.Visible = true;
                pyramidControl.Visible = false;
                parallelepipedControl.Visible = false;
                sphereControl.Location = new Point(9, 75);

            }
        }
    }
}
