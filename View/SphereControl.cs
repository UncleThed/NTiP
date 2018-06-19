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
    public partial class SphereControl : UserControl
    {
        public SphereControl()
        {
            InitializeComponent();
        }

        public Sphere Sphere
        {
            get
            {
                var radius = radiusBox.Text != string.Empty ? Convert.ToUInt32(radiusBox.Text) : 0;
                if ((radius <= 800) && (radius > 0))
                {
                    return new Sphere(radius);
                }
                else
                {
                    MessageBox.Show("Параметры должны быть больше 0 и не превышать 800", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return null;
            }
            set
            {
                if (value == null) return;
                radiusBox.Text = Convert.ToString((value as Sphere).Radius);
            }
        }

        public bool ReadOnly
        {
            get => radiusBox.ReadOnly;
            set => radiusBox.ReadOnly = value;
        }

        private void RadiusBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RadiusBox_Enter(object sender, EventArgs e)
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

        private void RadiusBox_Leave(object sender, EventArgs e)
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
    }
}