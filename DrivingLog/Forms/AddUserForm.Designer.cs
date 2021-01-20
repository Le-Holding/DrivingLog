namespace DrivingLog
{
  partial class AddPostForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.ok_btn = new System.Windows.Forms.Button();
      this.annuller_btn = new System.Windows.Forms.Button();
      this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
      this.labelDate = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelLicensPlade = new System.Windows.Forms.Label();
      this.textBoxLicensePlate = new System.Windows.Forms.TextBox();
      this.labelDrivedKm = new System.Windows.Forms.Label();
      this.textBoxDrivedKm = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // ok_btn
      // 
      this.ok_btn.Location = new System.Drawing.Point(176, 141);
      this.ok_btn.Name = "ok_btn";
      this.ok_btn.Size = new System.Drawing.Size(75, 23);
      this.ok_btn.TabIndex = 0;
      this.ok_btn.Text = "Ok";
      this.ok_btn.UseVisualStyleBackColor = true;
      this.ok_btn.Click += new System.EventHandler(this.BtnOk);
      // 
      // annuller_btn
      // 
      this.annuller_btn.Location = new System.Drawing.Point(269, 141);
      this.annuller_btn.Name = "annuller_btn";
      this.annuller_btn.Size = new System.Drawing.Size(75, 23);
      this.annuller_btn.TabIndex = 1;
      this.annuller_btn.Text = "Annuller";
      this.annuller_btn.UseVisualStyleBackColor = true;
      this.annuller_btn.Click += new System.EventHandler(this.BtnAnnuller);
      // 
      // dateTimePickerDate
      // 
      this.dateTimePickerDate.Location = new System.Drawing.Point(125, 23);
      this.dateTimePickerDate.Name = "dateTimePickerDate";
      this.dateTimePickerDate.Size = new System.Drawing.Size(216, 20);
      this.dateTimePickerDate.TabIndex = 2;
      // 
      // labelDate
      // 
      this.labelDate.AutoSize = true;
      this.labelDate.Location = new System.Drawing.Point(49, 26);
      this.labelDate.Name = "labelDate";
      this.labelDate.Size = new System.Drawing.Size(33, 13);
      this.labelDate.TabIndex = 3;
      this.labelDate.Text = "Dato:";
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(49, 52);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(36, 13);
      this.labelName.TabIndex = 5;
      this.labelName.Text = "Navn:";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(125, 49);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(216, 20);
      this.textBoxName.TabIndex = 4;
      // 
      // labelLicensPlade
      // 
      this.labelLicensPlade.AutoSize = true;
      this.labelLicensPlade.Location = new System.Drawing.Point(49, 78);
      this.labelLicensPlade.Name = "labelLicensPlade";
      this.labelLicensPlade.Size = new System.Drawing.Size(72, 13);
      this.labelLicensPlade.TabIndex = 7;
      this.labelLicensPlade.Text = "Nummerplade";
      // 
      // textBoxLicensePlate
      // 
      this.textBoxLicensePlate.Location = new System.Drawing.Point(125, 75);
      this.textBoxLicensePlate.Name = "textBoxLicensePlate";
      this.textBoxLicensePlate.Size = new System.Drawing.Size(216, 20);
      this.textBoxLicensePlate.TabIndex = 6;
      // 
      // labelDrivedKm
      // 
      this.labelDrivedKm.AutoSize = true;
      this.labelDrivedKm.Location = new System.Drawing.Point(49, 104);
      this.labelDrivedKm.Name = "labelDrivedKm";
      this.labelDrivedKm.Size = new System.Drawing.Size(49, 13);
      this.labelDrivedKm.TabIndex = 9;
      this.labelDrivedKm.Text = "Kørt km.:";
      // 
      // textBoxDrivedKm
      // 
      this.textBoxDrivedKm.Location = new System.Drawing.Point(125, 101);
      this.textBoxDrivedKm.Name = "textBoxDrivedKm";
      this.textBoxDrivedKm.Size = new System.Drawing.Size(216, 20);
      this.textBoxDrivedKm.TabIndex = 8;
      // 
      // AddPostForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 193);
      this.Controls.Add(this.labelDrivedKm);
      this.Controls.Add(this.textBoxDrivedKm);
      this.Controls.Add(this.labelLicensPlade);
      this.Controls.Add(this.textBoxLicensePlate);
      this.Controls.Add(this.labelName);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelDate);
      this.Controls.Add(this.dateTimePickerDate);
      this.Controls.Add(this.annuller_btn);
      this.Controls.Add(this.ok_btn);
      this.Name = "AddPostForm";
      this.Text = "Form2";
      this.Load += new System.EventHandler(this.AddPostForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ok_btn;
    private System.Windows.Forms.Button annuller_btn;
    private System.Windows.Forms.Label labelDate;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelLicensPlade;
    private System.Windows.Forms.Label labelDrivedKm;
    protected System.Windows.Forms.TextBox textBoxName;
    protected System.Windows.Forms.TextBox textBoxLicensePlate;
    protected System.Windows.Forms.TextBox textBoxDrivedKm;
    protected System.Windows.Forms.DateTimePicker dateTimePickerDate;
  }
}