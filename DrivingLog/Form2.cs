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
  public partial class Form2 : Form
  {
    private readonly EmployeeStamdataDto _dto;

    public Form2(EmployeeStamdataDto dto)
    {
      InitializeComponent();
      _dto = dto;
      this.FormClosing += Form2_FormClosing;
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }

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
  }
}
