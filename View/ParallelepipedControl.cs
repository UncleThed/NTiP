using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class ParallelepipedControl : UserControl
    {
        private uint _a = 0;
        private uint _b = 0;
        private uint _c = 0;

        public ParallelepipedControl()
        {
            InitializeComponent();
        }

        public Parallelepiped Parallelepiped
        {
            get
            {
                if ((_a <= 1000) && (_b <= 1000) && (_c <= 1000)
                    && (_a > 0) && (_b > 0) && (_c > 0))
                {
                    return new Parallelepiped(_a, _b, _c);
                }
                else
                {
                    MessageBox.Show("Параметры должны быть больше 0 и не превышать 1000", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            set
            {
                if (value == null) return;
                sideABox.Text = Convert.ToString((value as Parallelepiped).A);
                sideBBox.Text = Convert.ToString((value as Parallelepiped).B);
                sideCBox.Text = Convert.ToString((value as Parallelepiped).C);
            }

        }

        public bool ReadOnly { get; set; } = true;


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

        private void EnterTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == "0")
            {
                textBox.Text = string.Empty;
            }
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

        private void LeaveTextBox(object sender)
        {
            if (!(sender is TextBox textBox)) return;
            if (textBox.Text == string.Empty)
            {
                textBox.Text = "0";
            }
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
            var number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void sideABox_TextChanged(object sender, EventArgs e)
        {
            _a = sideABox.Text != string.Empty ? Convert.ToUInt32(sideABox.Text) : 0;
        }

        private void sideBBox_TextChanged(object sender, EventArgs e)
        {
            _b = sideBBox.Text != string.Empty ? Convert.ToUInt32(sideBBox.Text) : 0;
        }

        private void sideCBox_TextChanged(object sender, EventArgs e)
        {
            _c = sideCBox.Text != string.Empty ? Convert.ToUInt32(sideCBox.Text) : 0;
        }
    }
}
