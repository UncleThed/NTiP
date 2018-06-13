using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private List<IFigure> _figures;
        private DataContractJsonSerializer _serializer;
        
        /// <summary>
        /// Конструктор класса GetVolumeForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _figures = new List<IFigure>();

            bindingSource.DataSource = _figures;
            DataGridView.DataSource = bindingSource;

            List<Type> knownTypeList = new List<Type>
            {
                typeof(Parallelepiped),
                typeof(Pyramid),
                typeof(Sphere)
            };

            _serializer = new DataContractJsonSerializer(typeof(List<IFigure>), knownTypeList);
        }

        //private void UpdateControls()
        //{
        //    parallelepipedControl.Visible = false;
        //    pyramidControl.Visible = false;
        //    SphereControl.Visible = false;

        //    bookControl1.ReadOnly = true;
        //    journalControl1.ReadOnly = true;
        //    dissertationControl.ReadOnly = true;
        //}

        private void AddButton_Click(object sender, EventArgs e)
        {
            //UpdateControls();
            CreateFigureForm addFigureForm = new CreateFigureForm()
            {
                ReadOnly = false
            };

            addFigureForm.ShowDialog();

            if (addFigureForm.DialogResult != DialogResult.OK) return;
            if (addFigureForm.Figure != null)
            {
                bindingSource.Add(addFigureForm.Figure);
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //UpdateControls();
            CreateFigureForm modifyFigureForm = new CreateFigureForm()
            {
                Figure = _figures[DataGridView.CurrentRow.Index],
                ReadOnly = false
            };

            modifyFigureForm.ShowDialog();

            if (modifyFigureForm.DialogResult != DialogResult.OK) return;
            if (modifyFigureForm.Figure != null)
            {
                _figures[DataGridView.CurrentRow.Index] = modifyFigureForm.Figure;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedCells.Count > 0)
            {
                int index = DataGridView.SelectedCells[0].RowIndex;
                DataGridView.Rows.RemoveAt(index);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Figures|*.fig";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                List<IFigure> deserializeFigures = (List<IFigure>)_serializer.ReadObject(fileStream);
                fileStream.Dispose();

                bindingSource.Clear();

                foreach (IFigure figure in deserializeFigures)
                {
                    bindingSource.Add(figure);
                }
            }

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Figures|*.fig";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {

                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                _serializer.WriteObject(fileStream, _figures);
                fileStream.Dispose();
            }
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
#if DEBUG
                    if (e.Control)
                    {
                        Random rand = new Random();
                        int type = rand.Next(0, 3);

                        if (type == 0)
                        {
                            int a = rand.Next(1, 50);
                            int b = rand.Next(1, 50);
                            int c = rand.Next(1, 50);
                            bindingSource.Add(new Parallelepiped((uint)a, (uint)b, (uint)c));
                        }
                        else if (type == 1)
                        {
                            int baseArea = rand.Next(1, 1000);
                            int height = rand.Next(1, 20);
                            bindingSource.Add(new Pyramid((uint)baseArea, (uint)height));
                        }
                        else
                        {
                            int radius = rand.Next(1, 100);
                            bindingSource.Add(new Sphere((uint)radius));
                        }
                    }
#endif
                    break;
            }
        }
    }


}
