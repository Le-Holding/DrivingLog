using DrivingLog.Properties;
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
    //Dummmy Data for test
    private readonly List<StamdataDto> _personer = new List<StamdataDto>() {
        new StamdataDto { Id = 1, Name = "Steve", KilometersPrTrip = new List<int> {100 ,20,  33}, LicensePlate = "CP86028", Date = new DateTime(2020, 08, 1)},
        new StamdataDto { Id = 2, Name = "Daniel", KilometersPrTrip = new List<int> {98 ,22,  33}, LicensePlate = "AR86028", Date = new DateTime(2020, 01, 1) },
        new StamdataDto { Id = 3, Name = "Jesper", KilometersPrTrip = new List<int> {99 , 18,  33}, LicensePlate = "BK08022", Date = new DateTime(2019, 05, 25) },
        new StamdataDto { Id = 4, Name = "Sara", KilometersPrTrip = new List<int> {187 ,50,  33}, LicensePlate = "BA09455", Date = new DateTime(2015, 12, 30) }
      };

    private void SetTestDataForPropertyFieltKilometerAbsValue()
    {
      foreach (var person in _personer)
      {
        int abs_value = 0;

        foreach (var Trip in person.KilometersPrTrip)
        {
          abs_value += Trip;
        }

        person.kilometersAbsValue = abs_value;
      }      
    }

    //Declare Binding variables for our gridViewData
    private BindingList<StamdataDto> _bindingList;
    private BindingSource _bindingSource;

    //Declare Button variables for our gridViewData
    private DataGridViewButtonColumn[] DataGridViewButtonColumns()
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
        Name = nameof(ButtonNamesEnum.Delete_column),
        HeaderText = "Delete",
        Text = "Delete",
        UseColumnTextForButtonValue = true
      };

      var edit = new DataGridViewButtonColumn()
      {
        Name = ColumnButtonNames.Edit_column,
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
      this.Text = "Kørsels log (Kørselsbog).";
      dataGridView1.CellClick += DataGridView1_CellClick;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SetBindingsAndGridView();
      
      SetEvents();
    }

    private void SetBindingsAndGridView()
    {
      SetTestDataForPropertyFieltKilometerAbsValue();

      _bindingList = new BindingList<StamdataDto>(_personer);
      _bindingSource = new BindingSource(_bindingList, $"");
      dataGridView1.DataSource = _bindingSource;
      
      this.dataGridView1.Columns[nameof(StamdataDto.Id)].Visible = false;
      this.dataGridView1.Columns.AddRange(DataGridViewButtonColumns());
      this.dataGridView1.AutoResizeColumns(/*DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader*/);
      this._bindingSource.ResetBindings(true);
    }

    private void SetEvents()
    {
      this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView)sender;

      if (grid == null) return;

      // Since DataBoundItem is return as an object, we need to a type cast the return object to its orginale (form)/Type
      // This Casting is called an explicit casting, which means we have to do it manually.               * Sidenote: Implicit Casting is don automatically *
      var dto = (StamdataDto)grid.CurrentRow.DataBoundItem;

      if (e.ColumnIndex == dataGridView1.Columns[ColumnButtonNames.Edit_column].Index)
      {
        Form2 view = new Form2(dto);

        if (view.ShowDialog(this) == DialogResult.OK)
        {

        }
        view.Dispose();
      }
      if (e.ColumnIndex == dataGridView1.Columns[nameof(ButtonNamesEnum.Delete_column)]?.Index)
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

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView)sender;

      if (grid == null) return;

      //if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.Value == null || e.RowIndex == -1) return;

      var dto = (StamdataDto)grid.CurrentRow.DataBoundItem;



      //_bindingSource.DataSource;
      _bindingSource.ResetBindings(false);
    }

    private void DataGridView1_SelectionChanged(object sender, EventArgs e)
    {
      //dataGridView1.SelectedRows;
      //dataGridView1.DataBindings;

    }
  }
}
