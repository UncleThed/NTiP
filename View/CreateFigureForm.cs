﻿using System;
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
    /// <summary>
    /// Форма создания фигуры
    /// </summary>
    public partial class CreateFigureForm : Form
    {
        public IFigure Figure { get; private set; }

        /// <summary>
        /// Конструктор класса CreateFigureForm
        /// </summary>
        /// <param name="bindingSource">Источник данных</param>
        public CreateFigureForm()
        {
            InitializeComponent();
            this.Size = new Size(320, 300);
            ParallelepipedGroup.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            PyramidGroup.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            SphereGroup.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            BackToMain();
        }

        private void CreateFigureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToMain();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((SelectFigureBox.SelectedIndex > -1) && (SelectFigureBox.SelectedIndex < 3))
            {
                if (SelectFigureBox.SelectedIndex == 0)
                {
                    int a = Convert.ToInt32(sideABox.Text);
                    int b = Convert.ToInt32(sideBBox.Text);
                    int c = Convert.ToInt32(sideCBox.Text);
                    double max = Math.Pow(Int32.MaxValue, 1.0 / 3);

                    if ((a < max) && (b < max) && (c < max)
                        && (a > 0) && (b > 0) && (c > 0))
                    {
                        Figure = new Parallelepiped(a, b, c);
                    }
                    else
                    {
                        MessageBox.Show("Параметры должны быть больше 0 и не превышать 1290", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else if (SelectFigureBox.SelectedIndex == 1)
                {
                    int baseArea = Convert.ToInt32(baseAreaBox.Text);
                    int height = Convert.ToInt32(heightBox.Text);
                    double max = Math.Pow(Int32.MaxValue, 1.0 / 2);

                    if ((baseArea < max) && (height < max)
                        && (baseArea > 0) && (height > 0))
                    {
                        Figure = new Pyramid(baseArea, height);
                    }
                    else
                    {
                        MessageBox.Show("Параметры должны быть больше 0 и не превышать 46340", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int radius = Convert.ToInt32(radiusBox.Text);
                    double max = Math.Pow(Int32.MaxValue * 3.0 / 4.0 / Math.PI, 1.0 / 3);

                    if ((radius < max) && (radius > 0))
                    {
                        Figure = new Sphere(radius);
                    }
                    else
                    {
                        MessageBox.Show("Параметры должны быть больше 0 и не превышать 800", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                BackToMain();
            }
        }

        private void SelectFigureBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectFigureBox.SelectedIndex == 0)
            {
                SphereGroup.Visible = false;
                PyramidGroup.Visible = false;
                ParallelepipedGroup.Visible = true;
                ParallelepipedGroup.Location = new Point(9, 75);


            }            
            else if (SelectFigureBox.SelectedIndex == 1)
            {
                SphereGroup.Visible = false;
                PyramidGroup.Visible = true;
                ParallelepipedGroup.Visible = false;
                PyramidGroup.Location = new Point(9, 75);
            }
            else if (SelectFigureBox.SelectedIndex == 2)
            {
                SphereGroup.Visible = true;
                PyramidGroup.Visible = false;
                ParallelepipedGroup.Visible = false;
                SphereGroup.Location = new Point(9, 75);

            }

        }

        private void ParallelepipedGroup_Enter(object sender, EventArgs e)
        {

        }

        private void HeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void BaseAreaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void RadiusBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void SideABox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void SideBBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void SideCBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Ввод только цифр
        /// </summary>
        /// <param name="e">Параметры события</param>
        private void PressDigit(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void BackToMain()
        {
            SphereGroup.Visible = false;
            PyramidGroup.Visible = false;
            ParallelepipedGroup.Visible = false;

            radiusBox.Text = "0";
            heightBox.Text = "0";
            baseAreaBox.Text = "0";
            sideABox.Text = "0";
            sideBBox.Text = "0";
            sideCBox.Text = "0";
            SelectFigureBox.SelectedIndex = -1;

            this.Hide();
        }

        private void SelectFigureBox_VisibleChanged(object sender, EventArgs e)
        {
            Figure = null;
        }

        private void HeightBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void BaseAreaBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void SideABox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void SideBBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void SideCBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void RadiusBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void EnterTextBox(object sender)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                if (textBox.Text == "0")
                {
                    textBox.Text = String.Empty;
                }
            }
        }

        private void HeightBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void BaseAreaBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void SideABox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void SideBBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void SideCBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void RadiusBox_Leave(object sender, EventArgs e)
        {
            LeaveTextBox(sender);
        }

        private void LeaveTextBox(object sender)
        {
            if (sender is TextBox)
            {
                TextBox textBox = sender as TextBox;
                if (textBox.Text == String.Empty)
                {
                    textBox.Text = "0";
                }
            }
        }
    }
}
