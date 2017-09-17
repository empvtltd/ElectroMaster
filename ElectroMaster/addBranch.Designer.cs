namespace ElectroMaster
{
    partial class manageBranch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBranchID = new MetroFramework.Controls.MetroTextBox();
            this.txtBranchName = new MetroFramework.Controls.MetroTextBox();
            this.gridViewBranch = new MetroFramework.Controls.MetroGrid();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BranchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(43, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Branch ID ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(43, 213);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Branch Name";
            // 
            // txtBranchID
            // 
            // 
            // 
            // 
            this.txtBranchID.CustomButton.Image = null;
            this.txtBranchID.CustomButton.Location = new System.Drawing.Point(596, 2);
            this.txtBranchID.CustomButton.Name = "";
            this.txtBranchID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBranchID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBranchID.CustomButton.TabIndex = 1;
            this.txtBranchID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBranchID.CustomButton.UseSelectable = true;
            this.txtBranchID.CustomButton.Visible = false;
            this.txtBranchID.Lines = new string[0];
            this.txtBranchID.Location = new System.Drawing.Point(217, 119);
            this.txtBranchID.MaxLength = 32767;
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.PasswordChar = '\0';
            this.txtBranchID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBranchID.SelectedText = "";
            this.txtBranchID.SelectionLength = 0;
            this.txtBranchID.SelectionStart = 0;
            this.txtBranchID.ShortcutsEnabled = true;
            this.txtBranchID.Size = new System.Drawing.Size(624, 30);
            this.txtBranchID.TabIndex = 2;
            this.txtBranchID.UseSelectable = true;
            this.txtBranchID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBranchID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBranchName
            // 
            // 
            // 
            // 
            this.txtBranchName.CustomButton.Image = null;
            this.txtBranchName.CustomButton.Location = new System.Drawing.Point(600, 2);
            this.txtBranchName.CustomButton.Name = "";
            this.txtBranchName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBranchName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBranchName.CustomButton.TabIndex = 1;
            this.txtBranchName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBranchName.CustomButton.UseSelectable = true;
            this.txtBranchName.CustomButton.Visible = false;
            this.txtBranchName.Lines = new string[0];
            this.txtBranchName.Location = new System.Drawing.Point(217, 213);
            this.txtBranchName.MaxLength = 32767;
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.PasswordChar = '\0';
            this.txtBranchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBranchName.SelectedText = "";
            this.txtBranchName.SelectionLength = 0;
            this.txtBranchName.SelectionStart = 0;
            this.txtBranchName.ShortcutsEnabled = true;
            this.txtBranchName.Size = new System.Drawing.Size(628, 30);
            this.txtBranchName.TabIndex = 3;
            this.txtBranchName.UseSelectable = true;
            this.txtBranchName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBranchName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gridViewBranch
            // 
            this.gridViewBranch.AllowUserToResizeRows = false;
            this.gridViewBranch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewBranch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridViewBranch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewBranch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBranch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchID,
            this.BranchName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewBranch.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewBranch.EnableHeadersVisualStyles = false;
            this.gridViewBranch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewBranch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewBranch.Location = new System.Drawing.Point(43, 284);
            this.gridViewBranch.Name = "gridViewBranch";
            this.gridViewBranch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBranch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewBranch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewBranch.RowTemplate.Height = 24;
            this.gridViewBranch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewBranch.Size = new System.Drawing.Size(934, 431);
            this.gridViewBranch.TabIndex = 4;
            this.gridViewBranch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewBranch_CellContentClick);
            this.gridViewBranch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewBranch_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.Location = new System.Drawing.Point(115, 756);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 75);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDelete.Location = new System.Drawing.Point(431, 756);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 75);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdate.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnUpdate.Location = new System.Drawing.Point(732, 756);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 75);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = global::ElectroMaster.Properties.Resources.searchbtn1;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(871, 142);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(94, 68);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // BranchID
            // 
            this.BranchID.HeaderText = "BranchID";
            this.BranchID.Name = "BranchID";
            this.BranchID.Visible = false;
            // 
            // BranchName
            // 
            this.BranchName.HeaderText = "BranchName";
            this.BranchName.Name = "BranchName";
            this.BranchName.Visible = false;
            // 
            // manageBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridViewBranch);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtBranchID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "manageBranch";
            this.Text = "Branch Management";
            this.Load += new System.EventHandler(this.addBranch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBranchID;
        private MetroFramework.Controls.MetroTextBox txtBranchName;
        private MetroFramework.Controls.MetroGrid gridViewBranch;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
    }
}