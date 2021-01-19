using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace DrivingLog
{
  public partial class Form1 : Form
  {
    private readonly Model _model;
    private readonly List<EmployeeStamdataDto> _dtos;


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
        HeaderText = "Kørsel",
        Text = "Tilføj log",
        UseColumnTextForButtonValue = true
      };

      var edit = new DataGridViewButtonColumn()
      {
        Name = BtnColumnNames.Edit_column,
        HeaderText = "Rediger bruger",
        Text = "Rediger",
        UseColumnTextForButtonValue = true
      };


      var delete = new DataGridViewButtonColumn()
      {
        Name = BtnColumnNames.Delete_column,
        HeaderText = "Slet bruger",
        Text = "Delete",
        UseColumnTextForButtonValue = true
      };

      var btn = new DataGridViewButtonColumn[] { add, edit, delete };
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
      _dtos = _model.GetPersons();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataGridView1SetBindings();
      DataGidView1SetColums();
      SetEvents();
      _bindingSource.ResetBindings(false);
    }

    private void dataGridView1SetBindings()
    {
      _bindingList = new BindingList<EmployeeStamdataDto>(_dtos);
      _bindingSource = new BindingSource(_bindingList, $"");
      dataGridView1.DataSource = _bindingSource;
    }

    private void DataGidView1SetColums()
    {
      dataGridView1.Columns[nameof(EmployeeStamdataDto.Id)].Visible = false;
      dataGridView1.Columns[nameof(EmployeeStamdataDto.DeepCopy)].Visible = false;

      dataGridView1.Columns[nameof(EmployeeStamdataDto.Date)].HeaderText = "Dato";
      dataGridView1.Columns[nameof(EmployeeStamdataDto.kilometerSum)].HeaderText = "km i alt";
      dataGridView1.Columns[nameof(EmployeeStamdataDto.Name)].HeaderText = "Navn";
      dataGridView1.Columns[nameof(EmployeeStamdataDto.LicensePlate)].HeaderText = "Nummerplade";

      dataGridView1.Columns[nameof(EmployeeStamdataDto.kilometerSum)].ReadOnly = true;

      dataGridView1.Columns.AddRange(DataGridViewButtonColumns());

      dataGridView1.AutoResizeColumns(/*DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader*/);
    }

    private void SetEvents()
    {
      this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
      this.dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
      this.dataGridView1.CellClick += DataGridView1_CellClick;
    }

    private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      #region Note: Casting an object
      // Since DataBoundItem is return as an object, we need to a type cast the return object to its orginale (form)/Type
      // This Casting is called an explicit casting, which means we have to do it manually.               * Sidenote: Implicit Casting is don automatically *
      #endregion

      DataGridView grid = (DataGridView)sender;

      if (grid == null) return;

      EmployeeStamdataDto dto = (EmployeeStamdataDto)grid.CurrentRow.DataBoundItem;


      // If (same value as before do not reload subgrid)
      SetSubGrid(dto);


      if (e.ColumnIndex == dataGridView1.Columns[BtnColumnNames.Add_column].Index)
      {
        AddPostForm view = new AddPostForm(dto);

        if (view.ShowDialog(this) == DialogResult.OK)
        {
          //view.
        }
        view.Dispose();
      }

      if (e.ColumnIndex == dataGridView1.Columns[BtnColumnNames.Edit_column].Index)
      {
        EditUserForm view = new EditUserForm(dto);

        if (view.ShowDialog(this) == DialogResult.OK)
        {

        }
        view.Dispose();
      }
      if (e.ColumnIndex == dataGridView1.Columns[BtnColumnNames.Delete_column].Index)
      {
        #region It Is What It Is and As It Is: Using the Is and As Operators in C#
        //https://www.pluralsight.com/guides/csharp-is-as-operators-is-expressions
        #endregion
        //var temp = (EmployeeStamdataDto)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
        var temp2 = this.dataGridView1.Rows[e.RowIndex].DataBoundItem as EmployeeStamdataDto;

        var message = string.Format("Ønsker du at slette brugeren {0} {1}?", temp2.Name, dto.Name);
        var Caption = "Delete";

        if (MessageBox.Show(message, Caption, MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
          _model.DeleteEmployee(dto.Id, _dtos);
          _bindingSource.ResetBindings(false);
        }
      }
    }

    private void SetSubGrid(EmployeeStamdataDto stamdataDto)
    {
      if (stamdataDto != null)
      {
        var userDrivingLogDto = _dtos.Where(x => x.Id == stamdataDto.Id).SelectMany(x => x.KilometersPrTrip.Where(t => t.EmployeeId == stamdataDto.Id));

        _subBindingList = new BindingList<DrivingLogDto>(userDrivingLogDto.ToList());
        //_subBindingList = new BindingList<DrivingLogDto>(_model.EmployeeDrivingLog.Where(x => x.EmployeeId == stamdataDto.Id).ToList());
      }
      else
        _subBindingList = null; //Hvis vi rammer rækken addNewRow, så har vi ingen kørselsdata vi kan vise fra vores kørselstabel, derfor sættes det = null eller = new BindingList<DrivingLogDto>().

      _subBindingSource = new BindingSource(_subBindingList, $"");


      dataGridView2.DataSource = _subBindingSource;
      if (_subBindingList != null)
      {
        DataGidView2SetColums();
      }
      _subBindingSource.ResetBindings(true);
    }

    private void DataGidView2SetColums()
    {
      dataGridView2.Columns[nameof(DrivingLogDto.Id)].Visible = false;
      dataGridView2.Columns[nameof(DrivingLogDto.EmployeeId)].Visible = false;

      dataGridView2.Columns[nameof(DrivingLogDto.Date)].HeaderText = "Dato";
      dataGridView2.Columns[nameof(DrivingLogDto.DriversTask)].HeaderText = "Opgave";
      dataGridView2.Columns[nameof(DrivingLogDto.Distance)].HeaderText = "Kørt km";
      dataGridView2.AutoResizeColumns();
    }

    private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var grid = (DataGridView)sender;

      if (grid == null) return;

      //if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.Value == null || e.RowIndex == -1) return;

      var dto = (EmployeeStamdataDto)grid.CurrentRow.DataBoundItem;

      _bindingSource.ResetBindings(false);
    }

    private void DataGridView1_SelectionChanged(object sender, EventArgs e)
    {
    }

    private void btnCreateNewUser_Click(object sender, EventArgs e)
    {
      EmployeeStamdataDto temp = new EmployeeStamdataDto();
      AddPostForm view = new AddPostForm(temp);

      if (view.ShowDialog(this) == DialogResult.OK)
      {
        //view.
      }
      view.Dispose();
    }

    private void button1_Click(object sender, EventArgs e)
    {

      EditUserForm view = new EditUserForm(_dtos.FirstOrDefault() ?? new EmployeeStamdataDto());

      if (view.ShowDialog(this) == DialogResult.OK)
      {

      }
      view.Dispose();
    }
  }
}
