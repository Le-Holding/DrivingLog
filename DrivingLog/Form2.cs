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
    private readonly DrivingLogDto _person;

    public Form2()
    {
      InitializeComponent();
      ok_btn.DialogResult = DialogResult.OK;
    }

    public Form2(DrivingLogDto person) : base()
    {
      _person = person;
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
