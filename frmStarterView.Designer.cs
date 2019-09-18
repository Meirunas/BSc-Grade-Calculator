namespace Calculator
{
    partial class frmStarterView
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStarterView));
        	this.pnlLogo = new System.Windows.Forms.Panel();
        	this.btnMinimize = new System.Windows.Forms.Button();
        	this.btnClose = new System.Windows.Forms.Button();
        	this.btnLoadSaved = new System.Windows.Forms.Button();
        	this.lblStudentID = new System.Windows.Forms.Label();
        	this.lblCourseName = new System.Windows.Forms.Label();
        	this.txtStudentID = new System.Windows.Forms.TextBox();
        	this.txtCourseName = new System.Windows.Forms.TextBox();
        	this.lblDescription = new System.Windows.Forms.Label();
        	this.lblWelCome = new System.Windows.Forms.Label();
        	this.btnAdd = new System.Windows.Forms.Button();
        	this.epLogin = new System.Windows.Forms.ErrorProvider(this.components);
        	this.pnlLogo.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.epLogin)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// pnlLogo
        	// 
        	this.pnlLogo.BackColor = System.Drawing.Color.White;
        	this.pnlLogo.BackgroundImage = global::Calculator.Properties.Resources.login_logo;
        	this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.pnlLogo.Controls.Add(this.btnMinimize);
        	this.pnlLogo.Controls.Add(this.btnClose);
        	this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
        	this.pnlLogo.Location = new System.Drawing.Point(0, 0);
        	this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
        	this.pnlLogo.Name = "pnlLogo";
        	this.pnlLogo.Size = new System.Drawing.Size(436, 87);
        	this.pnlLogo.TabIndex = 44;
        	// 
        	// btnMinimize
        	// 
        	this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
        	this.btnMinimize.BackgroundImage = global::Calculator.Properties.Resources.Minimize;
        	this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        	this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnMinimize.FlatAppearance.BorderSize = 0;
        	this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnMinimize.Location = new System.Drawing.Point(386, 1);
        	this.btnMinimize.Name = "btnMinimize";
        	this.btnMinimize.Size = new System.Drawing.Size(24, 23);
        	this.btnMinimize.TabIndex = 0;
        	this.btnMinimize.UseVisualStyleBackColor = false;
        	this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
        	// 
        	// btnClose
        	// 
        	this.btnClose.BackColor = System.Drawing.Color.White;
        	this.btnClose.BackgroundImage = global::Calculator.Properties.Resources.Close;
        	this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        	this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnClose.FlatAppearance.BorderSize = 0;
        	this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnClose.Location = new System.Drawing.Point(411, 1);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(24, 23);
        	this.btnClose.TabIndex = 1;
        	this.btnClose.UseVisualStyleBackColor = false;
        	this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        	// 
        	// btnLoadSaved
        	// 
        	this.btnLoadSaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(94)))));
        	this.btnLoadSaved.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnLoadSaved.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.btnLoadSaved.FlatAppearance.BorderSize = 0;
        	this.btnLoadSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnLoadSaved.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnLoadSaved.ForeColor = System.Drawing.Color.White;
        	this.btnLoadSaved.Location = new System.Drawing.Point(233, 452);
        	this.btnLoadSaved.Name = "btnLoadSaved";
        	this.btnLoadSaved.Size = new System.Drawing.Size(157, 46);
        	this.btnLoadSaved.TabIndex = 3;
        	this.btnLoadSaved.Text = "Load Saved";
        	this.btnLoadSaved.UseVisualStyleBackColor = true;
        	this.btnLoadSaved.Click += new System.EventHandler(this.btnLoadSaved_Click);
        	// 
        	// lblStudentID
        	// 
        	this.lblStudentID.AutoSize = true;
        	this.lblStudentID.Font = new System.Drawing.Font("Calibri", 14F);
        	this.lblStudentID.ForeColor = System.Drawing.Color.Black;
        	this.lblStudentID.Location = new System.Drawing.Point(29, 313);
        	this.lblStudentID.Margin = new System.Windows.Forms.Padding(0);
        	this.lblStudentID.Name = "lblStudentID";
        	this.lblStudentID.Size = new System.Drawing.Size(92, 23);
        	this.lblStudentID.TabIndex = 60;
        	this.lblStudentID.Text = "Student ID";
        	this.lblStudentID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// lblCourseName
        	// 
        	this.lblCourseName.AutoSize = true;
        	this.lblCourseName.Font = new System.Drawing.Font("Calibri", 14F);
        	this.lblCourseName.ForeColor = System.Drawing.Color.Black;
        	this.lblCourseName.Location = new System.Drawing.Point(29, 228);
        	this.lblCourseName.Margin = new System.Windows.Forms.Padding(0);
        	this.lblCourseName.Name = "lblCourseName";
        	this.lblCourseName.Size = new System.Drawing.Size(113, 23);
        	this.lblCourseName.TabIndex = 59;
        	this.lblCourseName.Text = "Course Name";
        	this.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// txtStudentID
        	// 
        	this.txtStudentID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtStudentID.ForeColor = System.Drawing.Color.Gray;
        	this.txtStudentID.Location = new System.Drawing.Point(29, 342);
        	this.txtStudentID.MaxLength = 20;
        	this.txtStudentID.Name = "txtStudentID";
        	this.txtStudentID.Size = new System.Drawing.Size(370, 37);
        	this.txtStudentID.TabIndex = 1;
        	// 
        	// txtCourseName
        	// 
        	this.txtCourseName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.txtCourseName.ForeColor = System.Drawing.Color.Gray;
        	this.txtCourseName.Location = new System.Drawing.Point(29, 259);
        	this.txtCourseName.MaxLength = 100;
        	this.txtCourseName.Name = "txtCourseName";
        	this.txtCourseName.Size = new System.Drawing.Size(370, 37);
        	this.txtCourseName.TabIndex = 0;
        	// 
        	// lblDescription
        	// 
        	this.lblDescription.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblDescription.ForeColor = System.Drawing.Color.Gray;
        	this.lblDescription.Location = new System.Drawing.Point(87, 150);
        	this.lblDescription.Name = "lblDescription";
        	this.lblDescription.Size = new System.Drawing.Size(262, 50);
        	this.lblDescription.TabIndex = 57;
        	this.lblDescription.Text = "To get started, Please enter your student information below";
        	this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// lblWelCome
        	// 
        	this.lblWelCome.AutoSize = true;
        	this.lblWelCome.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.lblWelCome.Location = new System.Drawing.Point(149, 112);
        	this.lblWelCome.Name = "lblWelCome";
        	this.lblWelCome.Size = new System.Drawing.Size(132, 33);
        	this.lblWelCome.TabIndex = 58;
        	this.lblWelCome.Text = "WELCOME";
        	this.lblWelCome.Click += new System.EventHandler(this.LblWelComeClick);
        	// 
        	// btnAdd
        	// 
        	this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(94)))));
        	this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        	this.btnAdd.FlatAppearance.BorderSize = 0;
        	this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.btnAdd.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnAdd.ForeColor = System.Drawing.Color.White;
        	this.btnAdd.Location = new System.Drawing.Point(36, 452);
        	this.btnAdd.Name = "btnAdd";
        	this.btnAdd.Size = new System.Drawing.Size(157, 46);
        	this.btnAdd.TabIndex = 2;
        	this.btnAdd.Text = "Add";
        	this.btnAdd.UseVisualStyleBackColor = true;
        	this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        	// 
        	// epLogin
        	// 
        	this.epLogin.ContainerControl = this;
        	// 
        	// frmStarterView
        	// 
        	this.AcceptButton = this.btnAdd;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
        	this.ClientSize = new System.Drawing.Size(436, 623);
        	this.Controls.Add(this.btnLoadSaved);
        	this.Controls.Add(this.lblStudentID);
        	this.Controls.Add(this.lblCourseName);
        	this.Controls.Add(this.txtStudentID);
        	this.Controls.Add(this.txtCourseName);
        	this.Controls.Add(this.lblDescription);
        	this.Controls.Add(this.lblWelCome);
        	this.Controls.Add(this.btnAdd);
        	this.Controls.Add(this.pnlLogo);
        	this.Font = new System.Drawing.Font("Calibri", 9F);
        	this.ForeColor = System.Drawing.Color.Black;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "frmStarterView";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Starter View";
        	this.Load += new System.EventHandler(this.frmStarterView_Load);
        	this.pnlLogo.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.epLogin)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoadSaved;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblWelCome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider epLogin;

    }
}