using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace DrivingLog
{
  public partial class Form1 : Form
  {
    private Model _model;

    //https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.bindinglist-1?view=net-5.0
    //Declare Binding variables for our gridViewData
    private BindingList<EmployeeStamdataDto> _bindingList;
    private BindingSource _bindingSource;

    private BindingList<DrivingLogDto> _subBindingList;
    private BindingSource _subBindingSource;

    private DataGridViewButtonColumn[] DataGridViewButtonColumns() //Declare Button variables for our gridViewData
    {      
      var add = new DataGridViewButtonColumn()
      {
        Name = BtnColumnNames.Add_column,
        HeaderText = "Add",
        Text = "Add",
        UseColumnTextForButtonValue = true
      };

      var delete = new DataGridViewButtonColumn()
      {
        Name = nameof(BtnColumnNames.Delete_column),
        HeaderText = "Delete",
        Text = "Delete",
        UseColumnTextForButtonValue = true
      };

      var edit = new DataGridViewButtonColumn()
      {
        Name = BtnColumnNames.Edit_column,
        HeaderText = "Edit",
        Text = "Edit",
        UseColumnTextForButtonValue = true
      };

      var btn = new DataGridViewButtonColumn[] { add, delete, edit };
      return btn;

      #region Eksemple på at oprettet en liste 
      //var btn2 = new List<DataGridViewButtonColumn>();
      //btn2.Add(add);
      //btn2.Add(delete);
      //btn2.Add(edit);
      //
      //return btn2.ToArray();

      //var btn3 = 
      //  new List<DataGridViewButtonColumn>() { add, delete, edit };
      //  
      //return btn3.ToArray();
      #endregion 
    }

    public Form1()
    {
      InitializeComponent();
      this.Text = "Kørsels log (Kørselsbog).";
      _model = new Model();      
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SetBindingsAndGridView();      
      SetEvents();
    }

    private void SetBindingsAndGridView()
    {
      _bindingList = new BindingList<EmployeeStamdataDto>(_model.GetPersons);
      _bindingSource = new BindingSource(_bindingList, $"");
      
      dataGridView1.DataSource = _bindingSource;
      
      this.dataGridView1.Columns[nameof(EmployeeStamdataDto.Id)].Visible = false;
      this.dataGridView1.Columns.AddRange(DataGridViewButtonColumns());
      this.dataGridView1.AutoResizeColumns(/*DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader*/);
      this._bindingSource.ResetBindings(true);
    }

    private void SetEvents()
    {
      this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
      dataGridView1.CellClick += DataGridView1_CellClick;
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
     {
      var grid = (DataGridView)sender;

      if (grid == null) return;

      #region Note: Casting an object
      // Since DataBoundItem is return as an object, we need to a type cast the return object to its orginale (form)/Type
      // This Casting is called an explicit casting, which means we have to do it manually.               * Sidenote: Implicit Casting is don automatically *
      #endregion

      var dto = (EmployeeStamdataDto)grid.CurrentRow.DataBoundItem;

      SetSubGrid(dto);


      if (e.ColumnIndex == dataGridView1.Columns[BtnColumnNames.Add_column].Index)
      {
        Form2 view = new Form2(dto);

        if (view.ShowDialog(this) == DialogResult.OK)
        {

        }
        view.Dispose();
      }

      if (e.ColumnIndex == dataGridView1.Columns[BtnColumnNames.Edit_column].Index)
      {
        Form2 view = new Form2(dto);

        if (view.ShowDialog(this) == DialogResult.OK)
        {

        }
        view.Dispose();
      }
      if (e.ColumnIndex == dataGridView1.Columns[BtnColumnNames.Delete_column]?.Index)
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

    private void SetSubGrid(EmployeeStamdataDto stamdataDto)
    {
      _subBindingList = new BindingList<DrivingLogDto>(_model.EmployeeDrivingLog.Where(x => x.EmployeeId == stamdataDto.Id).ToList());
      _subBindingSource = new BindingSource(_subBindingList, $"");

      dataGridView2.DataSource = _subBindingSource;
      this._subBindingSource.ResetBindings(true);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView)sender;

      if (grid == null) return;

      //if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.Value == null || e.RowIndex == -1) return;

      var dto = (EmployeeStamdataDto)grid.CurrentRow.DataBoundItem;



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
