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

    [Obsolete("Designer only", true)]
    public AddPostForm()
    {
      // Da klassen EditUserForm arver fra denne klasse AddPostForm, er det nødvendingt at sende vores base class videre med denne constructor, da design view'et bruger den for at tegnet vores billede.
      //Denne base constructor er derfor nødvending for at designer viker i EditUserForm. 
      //Det er den fordi der arves fra klassen Form, som ikke har nogle input parameret i sin constructor. Den bliver kaldt for at tegne formen/viewet.
      //https://stackoverflow.com/questions/16325992/how-to-avoid-error-constructor-on-type-mytype-not-found-when-inheriting-a-ba

      //https://stackoverflow.com/questions/38758760/resolve-error-there-is-no-argument-given-that-corresponds-to-required-formal-pa
      //The form you see in the design view is an actual instance of your base class.
      //If there is not default constructor, the designer cannot create that instance.

      //You can mark the constructor with the [Obsolete("Designer only", true)], and make it throw an exception if called when not in the designer, to prevent other people from calling it.
# if DEBUG
      // https://stackoverflow.com/questions/3788605/if-debug-vs-conditionaldebug
      throw new Exception("Called when not in the designer, only for the designer to create its instance");
#endif
    }

    public AddPostForm(EmployeeStamdataDto dto)
    {
      InitializeComponent();
      this.FormClosing += Form2_FormClosing;
      _dto = dto;
    }

    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
      var form = (Form)sender;

      if (e.CloseReason != CloseReason.FormOwnerClosing) return;

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
