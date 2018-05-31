using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class GetVolumeForm : Form
    {
        List<IFigure> _figures;
        CreateFigureForm _createFigureForm;
        SearchForm _searchForm;
        BinaryFormatter _serializator;

        public GetVolumeForm()
        {
            InitializeComponent();
            _figures = new List<IFigure>();
            _createFigureForm = new CreateFigureForm(bindingSource);
            _searchForm = new SearchForm(_figures);
            _serializator = new BinaryFormatter();

            bindingSource.DataSource = _figures;
            DataGridView.DataSource = bindingSource;
        }

        private void AddFigure_Click(object sender, EventArgs e)
        {
            
            _createFigureForm.Show();
        }

        private void RemoveFigure_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentCellAddress.Y >= 0)
            {
                int index = DataGridView.SelectedCells[0].RowIndex;
                DataGridView.Rows.RemoveAt(index);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            _searchForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Figures|*.fig";
            openFileDialog.ShowDialog();

            FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
            List<IFigure> deserializeFigures = (List<IFigure>)_serializator.Deserialize(fileStream);
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
            _serializator.Serialize(fileStream, _figures);
            fileStream.Dispose();
        }
    }


}
