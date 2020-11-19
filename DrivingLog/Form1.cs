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
    List<DrivingLogDto> _personer = new List<DrivingLogDto>()
      {
        new DrivingLogDto { Id = 1, Navn = "Steve", killometer = 1000 },
        new DrivingLogDto { Id = 2, Navn = "Daniel", killometer = 256 },
        new DrivingLogDto { Id = 3, Navn = "Jesper", killometer = 98 },
        new DrivingLogDto { Id = 4, Navn = "Sara", killometer = 56 }
      };

    public Form1()
    {
      InitializeComponent();

      dataGridView1.DataSource = /*new BindingSource8*/new BindingList<DrivingLogDto>(_personer)/*, $"")*/;
      
      dataGridView1.Columns[$"{nameof(DrivingLogDto.Id)}"].Visible = false;

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
      if(e.ColumnIndex == dataGridView1.Columns["Delete_column"]?.Index)
      {
        //ColorDialog m = new ColorDialog();
        var message = "Ønsker du at slette rækken?";
        var Caption = "Delete";
        var result = MessageBox.Show(message, Caption, MessageBoxButtons.OKCancel);
        if(result == DialogResult.OK)
        {
         var row = this.dataGridView1.SelectedRows[e.RowIndex];

          
        }
      }

    }
  }
}
