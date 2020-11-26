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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
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
      this.annuller_btn.Click += new System.EventHandler(this.BtnAnunuller);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(125, 23);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(216, 20);
      this.textBox1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(49, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Dato:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(49, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Navn:";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(125, 49);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(216, 20);
      this.textBox2.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(49, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Nummerplade";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(125, 75);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(216, 20);
      this.textBox3.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(49, 104);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Kørt km.:";
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(125, 101);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(216, 20);
      this.textBox4.TabIndex = 8;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(409, 193);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.annuller_btn);
      this.Controls.Add(this.ok_btn);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ok_btn;
    private System.Windows.Forms.Button annuller_btn;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox4;
  }
}