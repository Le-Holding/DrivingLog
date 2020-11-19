namespace DrivingLog
{
  partial class Form2
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
      this.SuspendLayout();
      // 
      // ok_btn
      // 
      this.ok_btn.Location = new System.Drawing.Point(280, 349);
      this.ok_btn.Name = "ok_btn";
      this.ok_btn.Size = new System.Drawing.Size(75, 23);
      this.ok_btn.TabIndex = 0;
      this.ok_btn.Text = "Ok";
      this.ok_btn.UseVisualStyleBackColor = true;
      // 
      // annuller_btn
      // 
      this.annuller_btn.Location = new System.Drawing.Point(373, 349);
      this.annuller_btn.Name = "annuller_btn";
      this.annuller_btn.Size = new System.Drawing.Size(75, 23);
      this.annuller_btn.TabIndex = 1;
      this.annuller_btn.Text = "Annuller";
      this.annuller_btn.UseVisualStyleBackColor = true;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(460, 384);
      this.Controls.Add(this.annuller_btn);
      this.Controls.Add(this.ok_btn);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button ok_btn;
    private System.Windows.Forms.Button annuller_btn;
  }
}