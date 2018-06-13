using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Model;

namespace View
{
    public partial class PyramidControl : UserControl
    {
        private uint _baseArea = 0;
        private uint _height = 0;

        public PyramidControl()
        {
            InitializeComponent();
        }

        public Pyramid Pyramid
        {
            get
            {
                if ((_baseArea <= 100000) && (_height <= 800)
                                         && (_baseArea > 0) && (_height > 0))
                {
                    return new Pyramid(_baseArea, _height);
                }
                else
                {
                    MessageBox.Show("Площадь основания должна быть больше 0 и не превышать 100000\n" +
                                    "Высота должна быть больше 0 и не превышать 800", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            set
            {
                if (value == null) return;
                baseAreaBox.Text = Convert.ToString((value as Pyramid).BaseArea);
                heightBox.Text = Convert.ToString((value as Pyramid).Height);
            }
        }

        public bool ReadOnly { get; set; } = true;

        private void HeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void BaseAreaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        /// <summary>
        /// Ввод только цифр
        /// </summary>
        /// <param name="e">Параметры события</param>
        private void PressDigit(KeyPressEventArgs e)
        {
            var number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void HeightBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void BaseAreaBox_Enter(object sender, EventArgs e)
        {
            EnterTextBox(sender);
        }

        private void EnterTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
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

        private void LeaveTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;

            if (textBox.Text == string.Empty)
            {
                textBox.Text = "0";
            }
        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            _height = heightBox.Text != string.Empty ? Convert.ToUInt32(heightBox.Text) : 0;
        }

        private void BaseAreaBox_TextChanged(object sender, EventArgs e)
        {
            _baseArea = baseAreaBox.Text != string.Empty ? Convert.ToUInt32(baseAreaBox.Text) : 0;
        }
    }
}
