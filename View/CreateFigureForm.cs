using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class CreateFigureForm : Form
    {
        private BindingSource _bindingSource;

        public CreateFigureForm(BindingSource bindingSource)
        {
            InitializeComponent();
            _bindingSource = bindingSource;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ClearTextBoxes();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            IFigure figure;

            if (SelectFigureBox.SelectedIndex == 0)
            {
                figure = new Parallelepiped(Convert.ToInt32(sideABox.Text), Convert.ToInt32(sideBBox.Text), Convert.ToInt32(sideCBox.Text));
            }
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                figure = new Pyramid(Convert.ToInt32(baseAreaBox.Text), Convert.ToInt32(heightBox.Text));
            }
            else
            {
                figure = new Sphere(Convert.ToInt32(radiusBox.Text));
            }

            _bindingSource.Add(figure);
        }

        private void SelectFigureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectFigureBox.SelectedIndex == 2)
            {
                SphereGroup.Visible = true;
                PyramidGroup.Visible = false;
                ParallelepipedGroup.Visible = false;
                SphereGroup.Location = new Point(9, 75);

            }
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                SphereGroup.Visible = false;
                PyramidGroup.Visible = true;
                ParallelepipedGroup.Visible = false;
                PyramidGroup.Location = new Point(9, 75);
            }
            else
            {
                SphereGroup.Visible = false;
                PyramidGroup.Visible = false;
                ParallelepipedGroup.Visible = true;
                ParallelepipedGroup.Location = new Point(9, 75);

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ParallelepipedGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
