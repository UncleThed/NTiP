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
                int a = Convert.ToInt32(sideABox.Text);
                int b = Convert.ToInt32(sideBBox.Text);
                int c = Convert.ToInt32(sideCBox.Text);
                double max = Math.Pow(Int32.MaxValue, 1.0 / 3);

                if ((a < max) && (b < max) && (c < max)
                    && (a > 0) && (b > 0) && (c > 0))
                {
                    figure = new Parallelepiped(a, b, c);
                    _bindingSource.Add(figure);
                }
                else
                {
                    MessageBox.Show("Параметры должны быть больше 0 и не превышать 1290", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                int  baseArea = Convert.ToInt32(baseAreaBox.Text);
                int height = Convert.ToInt32(heightBox.Text);
                double max = Math.Pow(Int32.MaxValue, 1.0 / 2);

                if ((baseArea < max) && (height < max)
                    && (baseArea > 0) && (height > 0))
                {
                    figure = new Pyramid(baseArea, height);
                    _bindingSource.Add(figure);
                }
                else
                {
                    MessageBox.Show("Параметры должны быть больше 0 и не превышать 46340", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int radius = Convert.ToInt32(radiusBox.Text);
                double max = Math.Pow(Int32.MaxValue * 3.0 / 4.0 / Math.PI, 1.0 / 3);

                if ((radius < max) && (radius > 0))
                {
                    figure = new Sphere(radius);
                    _bindingSource.Add(figure);
                }
                else
                {
                    MessageBox.Show("Параметры должны быть больше 0 и не превышать 800", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
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

        private void heightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void baseAreaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void radiusBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void sideABox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void sideBBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void sideCBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void PressDigit(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
