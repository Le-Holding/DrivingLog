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
  public partial class EditUserForm : AddPostForm
  {
    private readonly EmployeeStamdataDto _dto;

    public EditUserForm(EmployeeStamdataDto dto) : base(dto)
    {
      InitializeComponent();
      _dto = dto;
    }

    private void EditPostForm_Load(object sender, EventArgs e)
    {
      #region Vi kan ændre på vores textbox felt fra AddPostForm, fordi feltet er sat protected og ikke private og der med giver det denne klasser som arver fra AddPostForm adgang til felternerk
      //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/protected
      #endregion
      dateTimePickerDate.Enabled = false;
      dateTimePickerDate.Text = _dto.Date.ToString();
      textBoxName.Text = _dto.Name;
      textBoxLicensePlate.Text = _dto.LicensePlate;
    }
  }
}
