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
        new StamdataDto { Id = 1, Name = "Steve", killometer = 1000 },
        new StamdataDto { Id = 2, Name = "Daniel", killometer = 256 },
        new StamdataDto { Id = 3, Name = "Jesper", killometer = 98 },
        new StamdataDto { Id = 4, Name = "Sara", killometer = 56 }
      };

    private DataGridViewButtonColumn[] DataGridViewColumns()
    {
      var btn = new List<DataGridViewButtonColumn>();

      var add = new DataGridViewButtonColumn()
      {
        Name = "Add_column",
        HeaderText = "Add",
        Text = "Add",
        UseColumnTextForButtonValue = true
      };

      var delete = new DataGridViewButtonColumn()
      {
        Name = "Delete_column",
        HeaderText = "Delete",
        Text = "Delete",
        UseColumnTextForButtonValue = true
      };

      var edit = new DataGridViewButtonColumn()
      {
        Name = "Edit_column",
        HeaderText = "Edit",
        Text = "Edit",
        UseColumnTextForButtonValue = true
      };

      btn.Add(add);
      btn.Add(delete);
      btn.Add(edit);

      return btn.ToArray();
    }

    public Form1()
    {
      InitializeComponent();

      //int columnIndex = 3;
      //if (dataGridView1.Columns["Edit_column"] == null)
      //{
      //  dataGridView1.Columns.Insert(columnIndex, Edit);
      //}


      dataGridView1.CellClick += DataGridView1_CellClick;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataGridView1.DataSource = new BindingSource(new BindingList<StamdataDto>(_personer), $"");
      dataGridView1.Columns[$"{nameof(StamdataDto.Id)}"].Visible = false;
      this.dataGridView1.Columns.AddRange(DataGridViewColumns());
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var rowIndex = e.RowIndex;
      var selctedStamdata = dataGridView1.SelectedRows[rowIndex].DataBoundItem;

      //dataGridView1.Columns.CopyTo();

      //var dto = selctedStamdata

      if (e.ColumnIndex == dataGridView1.Columns["Edit_column"].Index)
      {
        Form2 view = new Form2(new StamdataDto());

        if (view.ShowDialog(this) == DialogResult.OK)
        {
          
        }
        view.Dispose();
      }
      if(e.ColumnIndex == dataGridView1.Columns["Delete_column"]?.Index)
      {
        //ColorDialog m = new ColorDialog();
        var message = "Ønsker du at slette rækken?";
        var Caption = "Delete";
        var result = MessageBox.Show(message, Caption, MessageBoxButtons.OKCancel);
        if(result == DialogResult.OK)
        {
          //var row = this.dataGridView1.SelectedRows[e.RowIndex];

          //var row2 = this.dataGridView1.Rows[e.RowIndex] as StamdataDto;
        }
      }

    }
  }
}
