namespace DrivingLog
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.stamdataDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.btnCreateNewUser = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.stamdataDtoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(40, 38);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(615, 330);
      this.dataGridView1.TabIndex = 0;
      // 
      // stamdataDtoBindingSource
      // 
      this.stamdataDtoBindingSource.DataSource = typeof(DrivingLog.EmployeeStamdataDto);
      // 
      // dataGridView2
      // 
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Location = new System.Drawing.Point(709, 38);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.Size = new System.Drawing.Size(463, 330);
      this.dataGridView2.TabIndex = 1;
      // 
      // btnCreateNewUser
      // 
      this.btnCreateNewUser.Location = new System.Drawing.Point(40, 395);
      this.btnCreateNewUser.Name = "btnCreateNewUser";
      this.btnCreateNewUser.Size = new System.Drawing.Size(122, 23);
      this.btnCreateNewUser.TabIndex = 2;
      this.btnCreateNewUser.Text = "Opret ny bruger";
      this.btnCreateNewUser.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1208, 450);
      this.Controls.Add(this.btnCreateNewUser);
      this.Controls.Add(this.dataGridView2);
      this.Controls.Add(this.dataGridView1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.stamdataDtoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource stamdataDtoBindingSource;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.Button btnCreateNewUser;
  }
}

