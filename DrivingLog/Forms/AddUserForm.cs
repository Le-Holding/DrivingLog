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
  public partial class AddPostForm : Form
  {
    private readonly EmployeeStamdataDto _dto;

    [Obsolete("Designer only", true)] //Er nødvending for designer 
    public AddPostForm() { }

    public AddPostForm(EmployeeStamdataDto dto)
    {
      InitializeComponent();
      this.FormClosing += Form2_FormClosing;
      _dto = dto;
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
      var form = (Form)sender;
      
      if (e.CloseReason != CloseReason.FormOwnerClosing) return ;

      //MyNewProperty.EmployeeId = _dto.Id;
      //MyNewProperty.Date = dateTimePickerDate.Value;
      //MyNewProperty.DriversTask = textBoxName.Text;
    }
    public EmployeeStamdataDto MyNewProperty { get; set; }
    private void InitializeMyButton()
    {
      // Create and initialize a Button.
      Button button1 = new Button();

      // Set the button to return a value of OK when clicked.
      ok_btn.DialogResult = DialogResult.OK;

      // Add the button to the form.
      Controls.Add(button1);
    }

    private void BtnOk(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void BtnAnunuller(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void AddPostForm_Load(object sender, EventArgs e)
    {
      this.Text = "Create User";
    }
  }
}
