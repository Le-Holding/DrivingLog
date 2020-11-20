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
    private readonly StamdataDto _dto;

    public Form2(StamdataDto dto)
    {
      InitializeComponent();
      ok_btn.DialogResult = DialogResult.OK;
      _dto = dto;
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
  }
}
