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

        public ParallelepipedControl()
        {
            InitializeComponent();
        }

        public Parallelepiped Parallelepiped
        {
            get
            {
                var a = sideABox.Text != string.Empty ? Convert.ToUInt32(sideABox.Text) : 0;
                var b = sideBBox.Text != string.Empty ? Convert.ToUInt32(sideBBox.Text) : 0;
                var c = sideCBox.Text != string.Empty ? Convert.ToUInt32(sideCBox.Text) : 0;

                if ((a <= 1000) && (b <= 1000) && (c <= 1000)
                    && (a > 0) && (b > 0) && (c > 0))
                {
                    return new Parallelepiped(a, b, c);
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
                sideABox.Text = Convert.ToString(value.A);
                sideBBox.Text = Convert.ToString(value.B);
                sideCBox.Text = Convert.ToString(value.C);
            }

        }

        public bool ReadOnly
        {
            get => sideABox.ReadOnly;

            set
            {
                sideABox.ReadOnly = value;
                sideBBox.ReadOnly = value;
                sideCBox.ReadOnly = value;
            }
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
    }
}
