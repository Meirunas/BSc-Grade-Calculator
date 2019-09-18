using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml;

namespace Calculator
{
    public partial class frmStarterView : Form
    {
        #region Variables

        private Control _Control = null;
        private string _Message = "";

        #endregion

        #region Page events and constructor

        public frmStarterView()
        {
            InitializeComponent();
        }

        private void frmStarterView_Load(object sender, EventArgs e)
        {
            txtCourseName.Select();
            txtCourseName.Focus();
        }

        #endregion

        #region Button Events

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
//            this.Cursor = Cursors.WaitCursor;

//            this.Cursor = Cursors.Default;
//            Properties.Settings.Default.CourseName = "";
//            Properties.Settings.Default.StudentID = "0";

            this.Hide();
            frmMainViewDetail _frmMainViewDetail = new frmMainViewDetail();
            _frmMainViewDetail.ShowDialog();

            //if (ValidateControl())
            //{
            //    //string _DirectoryPath = Application.StartupPath + "\\Modules";
            //    //string _FilePath = Application.StartupPath + "\\Modules\\" + txtCourseName.Text.Trim() + "_" + txtStudentID.Text.Trim() + ".xml";

            //    //if (File.Exists(_FilePath))
            //    //{
            //    //    this.Cursor = Cursors.Default;
            //    //    MessageBox.Show(String.Format(Messages.AlreadyAddedCourse, txtCourseName.Text.Trim(), txtStudentID.Text.Trim()), Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    txtCourseName.Select();
            //    //    txtCourseName.Focus();
            //    //}
            //    //else
            //    //{
            //    //    if (!Directory.Exists(_DirectoryPath))
            //    //    {
            //    //        Directory.CreateDirectory(_DirectoryPath);
            //    //    }

            //    //    XmlTextWriter textWriter = new XmlTextWriter(_FilePath, null);

            //    //    this.Cursor = Cursors.Default;
            //    //    Properties.Settings.Default.CourseName = txtCourseName.Text.Trim();
            //    //    Properties.Settings.Default.StudentID = txtStudentID.Text.Trim();

            //    //    this.Hide();
            //    //    frmMain _frmMaster = new frmMain();
            //    //    _frmMaster.ShowDialog();
            //    //}

            //    this.Cursor = Cursors.Default;
            //    Properties.Settings.Default.CourseName = txtCourseName.Text.Trim();
            //    Properties.Settings.Default.StudentID = txtStudentID.Text.Trim();

            //    this.Hide();
            //    frmMainViewDetail _frmMainViewDetail = new frmMainViewDetail();
            //    _frmMainViewDetail.ShowDialog();
            //}
            //else
            //{
            //    this.Cursor = Cursors.Default;
            //    MessageBox.Show(_Message, Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    _Control.Select();
            //    epLogin.SetIconPadding(_Control, 10);
            //    epLogin.SetError(_Control, Messages.RequiredMsg);
            //}
        }

        private void btnLoadSaved_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (ValidateControl())
            {
                //string _FilePath = Application.StartupPath + "\\Modules\\" + txtCourseName.Text.Trim() + "_" + txtStudentID.Text.Trim() + ".xml";

                //if (File.Exists(_FilePath))
                //{
                //    this.Cursor = Cursors.Default;
                //    Properties.Settings.Default.CourseName = txtCourseName.Text.Trim();
                //    Properties.Settings.Default.StudentID = txtStudentID.Text.Trim();

                //    this.Hide();
                //    frmMain _frmMaster = new frmMain();
                //    _frmMaster.ShowDialog();
                //}
                //else
                //{
                //    this.Cursor = Cursors.Default;
                //    MessageBox.Show(String.Format(Messages.NotAddedCourse, txtCourseName.Text.Trim(), txtStudentID.Text.Trim()), Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtCourseName.Select();
                //    txtCourseName.Focus();
                //}

                this.Cursor = Cursors.Default;
                Properties.Settings.Default.CourseName = txtCourseName.Text.Trim();
                Properties.Settings.Default.StudentID = txtStudentID.Text.Trim();

                this.Hide();
                frmMainViewDetail _frmMainViewDetail = new frmMainViewDetail();
                _frmMainViewDetail.ShowDialog();
            }
            else
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(_Message, Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                _Control.Select();
                epLogin.SetIconPadding(_Control, 10);
                epLogin.SetError(_Control, Messages.RequiredMsg);
            }
        }

        #endregion

        #region Private Methods

        private void CloseApplication()
        {
            DialogResult dlgrslt = MessageBox.Show(Messages.ExitMsg, Messages.MsgBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgrslt == DialogResult.No)
            {
                txtCourseName.Select();
                txtCourseName.Focus();
            }
            else
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        private bool ValidateControl()
        {
            bool _Result = true; _Control = null;
            _Message = Messages.ErrorMsgTitle;

            if (!Helper.CheckRequired(txtCourseName.Text.Trim(), ref _Message, "Course Name"))
            {
                if (_Control == null)
                    _Control = txtCourseName;
                _Result = false;
            }

            if (!Helper.CheckRequired(txtStudentID.Text.Trim(), ref _Message, "Student ID"))
            {
                if (_Control == null)
                    _Control = txtStudentID;
                _Result = false;
            }

            return _Result;
        }
		void LblWelComeClick(object sender, EventArgs e)
		{
	
		}

        #endregion
    }
}
