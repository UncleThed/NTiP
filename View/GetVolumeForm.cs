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
    public partial class GetVolumeForm : Form
    {
        List<IFigure> _figures;
        CreateFigureForm _createFigureForm;

        public GetVolumeForm()
        {
            InitializeComponent();
            _figures = new List<IFigure>();
            _createFigureForm = new CreateFigureForm(bindingSource);

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
    }


}
