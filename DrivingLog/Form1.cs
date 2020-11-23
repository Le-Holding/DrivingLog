using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLog
{
  public partial class Form1 : Form
  {
    List<StamdataDto> _personer = new List<StamdataDto>()
      {
        new StamdataDto { Id = 1, Name = "Steve", killometer = 1000, LicensePlate = "CP86028", Date = new DateTime(2020, 08, 1)},
        new StamdataDto { Id = 2, Name = "Daniel", killometer = 256, LicensePlate = "AR86028", Date = new DateTime(2020, 01, 1) },
        new StamdataDto { Id = 3, Name = "Jesper", killometer = 98, LicensePlate = "BK08022", Date = new DateTime(2019, 05, 25) },
        new StamdataDto { Id = 4, Name = "Sara", killometer = 56, LicensePlate = "BA09455", Date = new DateTime(2015, 12, 30) }
      };

    List<DrivingLogDto> drivingLogs = new List<DrivingLogDto>();

    public Form1()
    {
      InitializeComponent();

      dataGridView1.DataSource = /*new BindingSource8*/new BindingList<StamdataDto>(_personer)/*, $"")*/;

      dataGridView1.Columns[$"{nameof(StamdataDto.Id)}"].Visible = false;

      DataGridViewButtonColumn Delete = new DataGridViewButtonColumn()
      {
        Name = "Delete_column",
        HeaderText = "Delete",
        Text = "Delete",
        UseColumnTextForButtonValue = true
      };
      DataGridViewButtonColumn Edit = new DataGridViewButtonColumn()
      {
        Name = "Edit_column",
        HeaderText = "Edit",
        Text = "Edit",
        UseColumnTextForButtonValue = true
      };

      this.dataGridView1.Columns.Add(Delete);
      this.dataGridView1.Columns.Add(Edit);
      ;


      //int columnIndex = 3;
      //if (dataGridView1.Columns["Edit_column"] == null)
      //{
      //  dataGridView1.Columns.Insert(columnIndex, Edit);
      //}


      dataGridView1.CellClick += DataGridView1_CellClick;
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == dataGridView1.Columns["Edit_column"].Index)
      {
        Form2 view = new Form2();

        if (view.ShowDialog(this) == DialogResult.OK)
        {
          //var t = dataGridView1.SelectedRows
        }

        view.Dispose();
        //Do something with your button.
      }
      if (e.ColumnIndex == dataGridView1.Columns["Delete_column"]?.Index)
      {
        //ColorDialog m = new ColorDialog();
        var message = string.Format("Ønsker du at slette brugeren {0}?", this.dataGridView1.Rows[e.RowIndex].Cells);
        var Caption = "Delete";
        var result = MessageBox.Show(message, Caption, MessageBoxButtons.OKCancel);
        if (result == DialogResult.OK)
        {
          //var row = this.dataGridView1.SelectedRows[e.RowIndex];

          //var row2 = this.dataGridView1.Rows[e.RowIndex] as StamdataDto;
        }
      }

    }
  }
}
