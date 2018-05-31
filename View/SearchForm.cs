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
    public partial class SearchForm : Form
    {
        private List<IFigure> _figures;

        public SearchForm(List<IFigure> figures)
        {
            InitializeComponent();
            _figures = figures;
        }

        private void minVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void maxVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string result = String.Empty;

            IEnumerable<IFigure> selectedFigures = from figure in _figures
                                  where (figure.Volume > Convert.ToInt32(minVolumeBox.Text))
                                        && (figure.Volume < Convert.ToInt32(maxVolumeBox.Text))
                                  select figure;

            foreach (IFigure figure in selectedFigures)
            {
                result += Convert.ToString(figure) + "\n";
            }

            if (result != String.Empty)
            {
                MessageBox.Show(result, "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("По данному запросу результата нет", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }




}
