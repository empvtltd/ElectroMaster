namespace ViewSalary
{
    partial class ViewSalary
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtMonth = new MetroFramework.Controls.MetroTextBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(23, 154);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(954, 586);
            this.metroListView1.TabIndex = 1;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(664, 779);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(250, 75);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Print ";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(664, 46);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(250, 75);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "View Salary";
            this.metroButton1.UseSelectable = true;
            // 
            // txtMonth
            // 
            // 
            // 
            // 
            this.txtMonth.CustomButton.Image = null;
            this.txtMonth.CustomButton.Location = new System.Drawing.Point(272, 2);
            this.txtMonth.CustomButton.Name = "";
            this.txtMonth.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMonth.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMonth.CustomButton.TabIndex = 1;
            this.txtMonth.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMonth.CustomButton.UseSelectable = true;
            this.txtMonth.CustomButton.Visible = false;
            this.txtMonth.Enabled = false;
            this.txtMonth.Lines = new string[0];
            this.txtMonth.Location = new System.Drawing.Point(80, 91);
            this.txtMonth.MaxLength = 32767;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.PasswordChar = '\0';
            this.txtMonth.PromptText = "Month";
            this.txtMonth.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMonth.SelectedText = "";
            this.txtMonth.SelectionLength = 0;
            this.txtMonth.SelectionStart = 0;
            this.txtMonth.ShortcutsEnabled = true;
            this.txtMonth.Size = new System.Drawing.Size(300, 30);
            this.txtMonth.TabIndex = 4;
            this.txtMonth.UseSelectable = true;
            this.txtMonth.WaterMark = "Month";
            this.txtMonth.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMonth.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee ID";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee Name";
            this.columnHeader1.Width = 285;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Basic Salary";
            this.columnHeader3.Width = 127;
            // 
            // ViewSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroListView1);
            this.MaximizeBox = false;
            this.Name = "ViewSalary";
            this.Text = "View Calculated Salary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtMonth;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

