using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        List<IFigure> _figures;
        CreateFigureForm _createFigureForm;
        DataContractJsonSerializer _serializer;

        /// <summary>
        /// Конструктор класса GetVolumeForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _figures = new List<IFigure>();
            _createFigureForm = new CreateFigureForm();

            bindingSource.DataSource = _figures;
            DataGridView.DataSource = bindingSource;

            List<Type> knownTypeList = new List<Type>();
            knownTypeList.Add(typeof(Parallelepiped));
            knownTypeList.Add(typeof(Pyramid));
            knownTypeList.Add(typeof(Sphere));

            _serializer = new DataContractJsonSerializer(typeof(List<IFigure>), knownTypeList);

#if !DEBUG
            RandomButton.Visible = false;
#endif
        }

        private void AddFigure_Click(object sender, EventArgs e)
        {
            _createFigureForm.ShowDialog();
            if (_createFigureForm.figure != null)
            {
                bindingSource.Add(_createFigureForm.figure);
            }
        }

        private void RemoveFigure_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedCells.Count > 0)
            {
                int index = DataGridView.SelectedCells[0].RowIndex;
                DataGridView.Rows.RemoveAt(index);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Figures|*.fig";
            openFileDialog.ShowDialog();

            FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
            List<IFigure> deserializeFigures = (List<IFigure>)_serializer.ReadObject(fileStream);
            fileStream.Dispose();         

            bindingSource.Clear();

            foreach (IFigure figure in deserializeFigures)
            {
                bindingSource.Add(figure);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Figures|*.fig";
            saveFileDialog.ShowDialog();

            FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
            _serializer.WriteObject(fileStream, _figures);
            fileStream.Dispose();
        }

        private void MinVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void MaxVolumeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PressDigit(e);
        }

        private void PressDigit(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void MinVolumeBox_TextChanged(object sender, EventArgs e)
        {
            ChangeVolumeBox(e);
        }

        private void MaxVolumeBox_TextChanged(object sender, EventArgs e)
        {
            ChangeVolumeBox(e);
        }

        private void ChangeVolumeBox(EventArgs e)
        {
            for (int index = 0; index < DataGridView.RowCount; index++)
            {
                DataGridView.Rows[index].Visible = true;
            }

            if (minVolumeBox.Text != String.Empty && maxVolumeBox.Text != String.Empty)
            {
                List<int> indexes = new List<int>();
                for (int counter = 0; counter < DataGridView.RowCount; counter++)
                {
                    double volume = Convert.ToDouble(DataGridView.Rows[counter].Cells["Column2"].Value);
                    if ((volume < Convert.ToDouble(minVolumeBox.Text))
                        || (volume > Convert.ToDouble(maxVolumeBox.Text)))
                    {
                        indexes.Add(counter);
                    }
                }
                DataGridView.CurrentCell = null;
                foreach (int index in indexes)
                {
                    DataGridView.Rows[index].Visible = false;
                }

            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6:
                    if (e.Control)
                    {
                        Random rand = new Random();
                        int type = rand.Next(0, 3);

                        if (type == 0)
                        {
                            int a = rand.Next(1, 50);
                            int b = rand.Next(1, 50);
                            int c = rand.Next(1, 50);
                            bindingSource.Add(new Parallelepiped(a, b, c));
                        }
                        else if (type == 1)
                        {
                            int baseArea = rand.Next(1, 10000);
                            int height = rand.Next(1, 200);
                            bindingSource.Add(new Pyramid(baseArea, height));
                        }
                        else
                        {
                            int radius = rand.Next(1, 500);
                            bindingSource.Add(new Sphere(radius));
                        }
                    }
                    break;
            }
        }
    }


}
