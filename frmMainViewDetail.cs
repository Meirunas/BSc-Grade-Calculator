using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Calculator
{
    public partial class frmMainViewDetail : Form
    {
        #region Variables

        public List<Module> _ListOfModule = new List<Module>();

        #endregion


        #region Page events and constructor

        public frmMainViewDetail()
        {
            InitializeComponent();
        }

        private void frmMainViewDetail_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //string _FilePath = Application.StartupPath + "\\Modules\\" + Properties.Settings.Default.CourseName + "_" + Properties.Settings.Default.StudentID + ".xml";

            //XmlSerializer deserializer = new XmlSerializer(typeof(List<Module>));

            //string xmlInputData = File.ReadAllText(_FilePath);

            //if (!string.IsNullOrEmpty(xmlInputData))
            //{
            //    TextReader reader = new StreamReader(_FilePath);
            //    object obj = deserializer.Deserialize(reader);
            //    List<Module> XmlData = (List<Module>)obj;

            //    if (XmlData!=null)
            //    {
            //        _ListOfModule = XmlData;
            //    }
            //    reader.Close();
            //}

            lblTotalYear1Value.Text = lblTotalYear2Value.Text = lblTotalYear3Value.Text = lblFinalGradeValue.Text = "";
            gvYear1.AutoGenerateColumns = gvYear2.AutoGenerateColumns = gvYear3.AutoGenerateColumns = false;

            FillGridYear1();
            FillGridYear2();
            FillGridYear3();

            this.Cursor = Cursors.Default;
        }


        #endregion


        #region Button Events

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            lblTotalYear1Value.Text = lblTotalYear2Value.Text = lblTotalYear3Value.Text = lblFinalGradeValue.Text = "";

            if (_ListOfModule == null)
            {
                _ListOfModule = new List<Module>();
            }

            Module _Module = new Module();

            _Module.Year = tcMain.SelectedIndex + 1;

            int _FinalWeight = 120;
/*            if (_Module.Year == 3)
            {
                _FinalWeight = 120;
            }*/
            int _TotalWeight = 0;
            if (_ListOfModule != null)
            {
                _TotalWeight = _ListOfModule.Where(m => m.Year == _Module.Year).Sum(m => m.Weight);
            }

//            _TotalWeight = _TotalWeight + 20;

            if (_TotalWeight > _FinalWeight)
            {
                MessageBox.Show("You can not select Weight more than " + _FinalWeight, Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
/*                _Module.ModuleID = 1;
                if (_ListOfModule.Count() > 0)
                {
                    _Module.ModuleID = _ListOfModule.Max(m => m.ModuleID) + 1;
                }*/

                _Module.Title = "";
                _Module.Assesment1 = 0;
                _Module.Assesment2 = 0;
                _Module.Weight = 20;
                _Module.Total = 0;
                _Module.WeightString = "20";
               
                _ListOfModule.Add(_Module);

                if (_Module.Year == 1)
                {
                    FillGridYear1();
                }
                else if (_Module.Year == 2)
                {
                    FillGridYear2();
                }
                else
                {
                    FillGridYear3();
                }
            }
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            string _FilePath = Application.StartupPath + "\\Modules\\" + Properties.Settings.Default.CourseName + "_" + Properties.Settings.Default.StudentID + ".xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Module>));
            System.IO.FileStream file = System.IO.File.Create(_FilePath);
            serializer.Serialize(file, _ListOfModule);
            file.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (_ListOfModule != null)
            {
                int _TotalWeightYear1 = _ListOfModule.Where(m => m.Year == 1).Sum(m => m.Weight);
                int _TotalWeightYear2 = _ListOfModule.Where(m => m.Year == 2).Sum(m => m.Weight);
                int _TotalWeightYear3 = _ListOfModule.Where(m => m.Year == 3).Sum(m => m.Weight);

                if (_TotalWeightYear1 != 0)
                {

                    decimal year1Grade = Convert.ToDecimal(_ListOfModule.Where(m => m.Year == 1).Sum(m => (m.Total * m.Weight)) / _TotalWeightYear1);
                   

                    lblTotalYear1Value.Text = Convert.ToString(year1Grade);
                    if (year1Grade < 40)
                    {
                        lblTotalYear1Value.ForeColor = Color.Red;
                        System.Windows.Forms.MessageBox.Show("Progression from Level 4 not allowed");
                    }
                    else if (year1Grade >= 40 && year1Grade < 50)
                        lblTotalYear1Value.ForeColor = Color.Orange;
                    else if (year1Grade >= 50 && year1Grade < 60)
                        lblTotalYear1Value.ForeColor = Color.Yellow;
                    else if (year1Grade >= 60 && year1Grade < 70)
                        lblTotalYear1Value.ForeColor = Color.Green;
                    else if (year1Grade >= 70 && year1Grade < 101)
                        lblTotalYear1Value.ForeColor = Color.Blue;
                }

                decimal year2Grade = 0, year3Grade = 0;
                Module minGradeModuleYear2 = null;
                Module minGradeModuleYear3 = null;



                if (_TotalWeightYear2 != 0)
                {

                   minGradeModuleYear2 = _ListOfModule.Where(m => m.Year == 2).OrderBy(m => m.Total).First();

                    year2Grade = Convert.ToDecimal(_ListOfModule.Where(m => m.Year == 2).Sum(m => (m.Total * m.Weight)) / _TotalWeightYear2);

                    lblTotalYear2Value.Text = Convert.ToString(year2Grade);
                    if (year2Grade < 40)
                        if (year2Grade < 40)
                            lblTotalYear1Value.ForeColor = Color.Red;
                        else if (year2Grade >= 40 && year2Grade < 50)
                            lblTotalYear1Value.ForeColor = Color.Orange;
                        else if (year2Grade >= 50 && year2Grade < 60)
                            lblTotalYear1Value.ForeColor = Color.Yellow;
                        else if (year2Grade >= 60 && year2Grade < 70)
                            lblTotalYear1Value.ForeColor = Color.Green;
                        else if (year2Grade >= 70 && year2Grade < 101)
                            lblTotalYear1Value.ForeColor = Color.Blue;
                }


                if (_TotalWeightYear3 != 0)
                {
                    minGradeModuleYear3 = _ListOfModule.Where(m => m.Year == 3).OrderBy(m => m.Total).First();

                    year3Grade = Convert.ToDecimal(_ListOfModule.Where(m => m.Year == 3).Sum(m => (m.Total * m.Weight)) / _TotalWeightYear3);

                    lblTotalYear3Value.Text = Convert.ToString(year3Grade);
                    if (year3Grade < 40)
                        if (year3Grade < 40)
                            lblTotalYear1Value.ForeColor = Color.Red;
                        else if (year3Grade >= 40 && year3Grade < 50)
                            lblTotalYear1Value.ForeColor = Color.Orange;
                        else if (year3Grade >= 50 && year3Grade < 60)
                            lblTotalYear1Value.ForeColor = Color.Yellow;
                        else if (year3Grade >= 60 && year3Grade < 70)
                            lblTotalYear1Value.ForeColor = Color.Green;
                        else if (year3Grade >= 70 && year3Grade < 101)
                            lblTotalYear1Value.ForeColor = Color.Blue;


                }
                Module minGradeModuleYear2And3 = new Module();
                if (minGradeModuleYear2.Total >= minGradeModuleYear3.Total)

                {
                    decimal numerator = _ListOfModule.Where(m => m.Year == 3).Sum(m => (m.Total * m.Weight));
                    minGradeModuleYear2And3.Weight = minGradeModuleYear3.Weight;
                  
                    if (minGradeModuleYear2And3.Weight > 20)
                    {

                        _TotalWeightYear3 -= (minGradeModuleYear3.Weight - 20);
                        minGradeModuleYear2And3.Weight = 20;
                        
                   
                        numerator -= minGradeModuleYear3.Total * (minGradeModuleYear3.Weight - minGradeModuleYear2And3.Weight);
                       
                    }
                    else
                    {
                        _TotalWeightYear3 -= minGradeModuleYear3.Weight;
                        numerator -= minGradeModuleYear3.Total * minGradeModuleYear3.Weight;
                   
                    }
                    
                    year3Grade = Convert.ToDecimal(numerator / _TotalWeightYear3);
                    

                }
                    
                
                else {

                    
                    decimal numerator = _ListOfModule.Where(m => m.Year == 2).Sum(m => (m.Total * m.Weight));

                    minGradeModuleYear2And3 = minGradeModuleYear2;



                    if (minGradeModuleYear2And3.Weight > 20)
                    {
                        _TotalWeightYear2 -= (minGradeModuleYear2.Weight - 20);
                        
                        minGradeModuleYear2And3.Weight = 20;
                        numerator -= minGradeModuleYear2.Total * (minGradeModuleYear2.Weight - minGradeModuleYear2And3.Weight);
                    }
                    else
                    {
                        _TotalWeightYear2 -= minGradeModuleYear2.Weight;
                        numerator -= minGradeModuleYear2.Total * minGradeModuleYear2.Weight;

                    }
                        year2Grade = Convert.ToDecimal(numerator / _TotalWeightYear2);

                }

                
                int _Indicator =(int) Math.Round(year2Grade / 3 + year3Grade * 2 / 3);
                                            

                if (_Indicator >= 40 && _Indicator < 50)
                {
                    lblFinalGradeValue.Text = "3rd Class Honours (3) " + _Indicator;
                }
                else if (_Indicator >= 50 && _Indicator < 60)
                {
                    lblFinalGradeValue.Text = "2nd Class Honours Lower Division (2:ii) " + _Indicator;
                }
                else if (_Indicator >= 60 && _Indicator < 70)
                {
                    lblFinalGradeValue.Text = "2nd Class Honours Upper Division (2:i) " + _Indicator;
                }
                else if (_Indicator >= 70)
                {
                    lblFinalGradeValue.Text = "1st Class Honours (1) " + _Indicator;
                }
                else
                {
                    lblFinalGradeValue.Text = "Fail " + _Indicator;
                }
            }
        }

        private void gvYear1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gvYear1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                int rowindex = gvYear1.CurrentCell.RowIndex;
                int colindex = gvYear1.CurrentCell.ColumnIndex;
                bool _Flag = true;

                if (gvYear1.Columns[colindex].Name == "Assesment1" || gvYear1.Columns[colindex].Name == "Assesment2")
                {
                    int _Assesment1 = 0, _Assesment2 = 0;

                    int.TryParse(Convert.ToString(gvYear1.Rows[rowindex].Cells["Assesment1"].Value), out _Assesment1);
                    int.TryParse(Convert.ToString(gvYear1.Rows[rowindex].Cells["Assesment2"].Value), out _Assesment2);

                    
                    int _Total = (_Assesment1 + _Assesment2) / 2;
                    

                        
                    if (/*_Total > 100 || _Total <= 0 ||*/ _Assesment1 > 100 || _Assesment1 < 0 || _Assesment2 > 100 || _Assesment2 < 0)
                    {
                        _Flag = false;
                        MessageBox.Show("You can not enter assesment /*or total*/ less than 0 or more than 100.", Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        /*if (gvYear1.Columns[colindex].Name == "Assesment1" && _Total > 100)
                        {
                            gvYear1.Rows[rowindex].Cells["Assesment1"].Value = 0;
                        }

                        if (gvYear1.Columns[colindex].Name == "Assesment2" && _Total > 100)
                        {
                            gvYear1.Rows[rowindex].Cells["Assesment2"].Value = 0;
                        }*/
                    }
                    else
                    {
                        gvYear1.Rows[rowindex].Cells["Total"].Value = (_Assesment1 + _Assesment2) / 2;
                    }
                }
                else if (gvYear1.Columns[colindex].Name == "Weight")
                {
                    int _TotalWeight = 0;
                    foreach (DataGridViewRow item in gvYear1.Rows)
                    {
                        if (item.Cells["Weight"].Value != null && !string.IsNullOrEmpty(Convert.ToString(item.Cells["Weight"].Value)))
                        {
                            _TotalWeight = _TotalWeight + Convert.ToInt32(item.Cells["Weight"].Value);
                        }
                    }

                    if (_TotalWeight > 120)
                    {
                        _Flag = false;
                        MessageBox.Show("You can not select Weight more than 120.", Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        gvYear1.Rows[rowindex].Cells["Weight"].Value = "20";
                    }
                }

                if (_Flag)
                {
                    int _ModuleId = Convert.ToInt32(gvYear1.Rows[rowindex].Cells["Id"].Value);
                    Module _Module = _ListOfModule.Where(m => m.ModuleID == _ModuleId).FirstOrDefault();

                    if (_Module != null)
                    {
                        _Module.Title = Convert.ToString(gvYear1.Rows[rowindex].Cells["Title"].Value);
                        _Module.Assesment1 = Convert.ToInt32(gvYear1.Rows[rowindex].Cells["Assesment1"].Value);
                        _Module.Assesment2 = Convert.ToInt32(gvYear1.Rows[rowindex].Cells["Assesment2"].Value);
                        _Module.Total = Convert.ToInt32(gvYear1.Rows[rowindex].Cells["Total"].Value);
                        _Module.Weight = Convert.ToInt32(gvYear1.Rows[rowindex].Cells["Weight"].Value);
                        _Module.WeightString = Convert.ToString(gvYear1.Rows[rowindex].Cells["Weight"].Value);
                    }
                }
            }
        }

        private void gvYear1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(txtNumber_KeyPress);
            if (gvYear1.CurrentCell.ColumnIndex == 1 || gvYear1.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(txtNumber_KeyPress);
                }
            }
        }

        private void gvYear2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gvYear2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                int rowindex = gvYear2.CurrentCell.RowIndex;
                int colindex = gvYear2.CurrentCell.ColumnIndex;
                bool _Flag = true;

                if (gvYear2.Columns[colindex].Name == "Assesment12" || gvYear2.Columns[colindex].Name == "Assesment22")
                {
                    int _Assesment1 = 0, _Assesment2 = 0;

                    int.TryParse(Convert.ToString(gvYear2.Rows[rowindex].Cells["Assesment12"].Value), out _Assesment1);
                    int.TryParse(Convert.ToString(gvYear2.Rows[rowindex].Cells["Assesment22"].Value), out _Assesment2);

                    int _Total = (_Assesment1 + _Assesment2) / 2;
                    if (_Total > 100 || _Total <= 0)
                    {
                        _Flag = false;
                        MessageBox.Show("You can not enter total 0 or more than 100.", Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (gvYear2.Columns[colindex].Name == "Assesment12" && _Total > 100)
                        {
                            gvYear2.Rows[rowindex].Cells["Assesment12"].Value = 0;
                        }

                        if (gvYear2.Columns[colindex].Name == "Assesment22" && _Total > 100)
                        {
                            gvYear2.Rows[rowindex].Cells["Assesment22"].Value = 0;
                        }
                    }
                    else
                    {
                        gvYear2.Rows[rowindex].Cells["Total2"].Value = (_Assesment1 + _Assesment2) / 2;
                    }
                }
                else if (gvYear2.Columns[colindex].Name == "Weight2")
                {
                    int _TotalWeight = 0;
                    foreach (DataGridViewRow item in gvYear2.Rows)
                    {
                        if (item.Cells["Weight2"].Value != null && !string.IsNullOrEmpty(Convert.ToString(item.Cells["Weight2"].Value)))
                        {
                            _TotalWeight = _TotalWeight + Convert.ToInt32(item.Cells["Weight2"].Value);
                        }
                    }

                    if (_TotalWeight > 120)
                    {
                        _Flag = false;
                        MessageBox.Show("You can not select Weight more than 120.", Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        gvYear2.Rows[rowindex].Cells["Weight2"].Value = "20";
                    }
                }

                if (_Flag)
                {
                    int _ModuleId = Convert.ToInt32(gvYear2.Rows[rowindex].Cells["Id2"].Value);
                    Module _Module = _ListOfModule.Where(m => m.ModuleID == _ModuleId).FirstOrDefault();

                    if (_Module != null)
                    {
                        _Module.Title = Convert.ToString(gvYear2.Rows[rowindex].Cells["Title2"].Value);
                        _Module.Assesment1 = Convert.ToInt32(gvYear2.Rows[rowindex].Cells["Assesment12"].Value);
                        _Module.Assesment2 = Convert.ToInt32(gvYear2.Rows[rowindex].Cells["Assesment22"].Value);
                        _Module.Total = Convert.ToInt32(gvYear2.Rows[rowindex].Cells["Total2"].Value);
                        _Module.Weight = Convert.ToInt32(gvYear2.Rows[rowindex].Cells["Weight2"].Value);
                        _Module.WeightString = Convert.ToString(gvYear2.Rows[rowindex].Cells["Weight2"].Value);
                    }
                }
            }
        }

        private void gvYear2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(txtNumber_KeyPress);
            if (gvYear2.CurrentCell.ColumnIndex == 1 || gvYear2.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(txtNumber_KeyPress);
                }
            }
        }

        private void gvYear3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void gvYear3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                int rowindex = gvYear3.CurrentCell.RowIndex;
                int colindex = gvYear3.CurrentCell.ColumnIndex;
                bool _Flag = true;

                if (gvYear3.Columns[colindex].Name == "Assesment13" || gvYear3.Columns[colindex].Name == "Assesment23")
                {
                    int _Assesment1 = 0, _Assesment2 = 0;

                    int.TryParse(Convert.ToString(gvYear3.Rows[rowindex].Cells["Assesment13"].Value), out _Assesment1);
                    int.TryParse(Convert.ToString(gvYear3.Rows[rowindex].Cells["Assesment23"].Value), out _Assesment2);

                    int _Total = (_Assesment1 + _Assesment2) / 2;
                    if (_Total > 100 || _Total <= 0)
                    {
                        _Flag = false;
                        MessageBox.Show("You can not enter total 0 or more than 100.", Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (gvYear3.Columns[colindex].Name == "Assesment13" && _Total > 100)
                        {
                            gvYear3.Rows[rowindex].Cells["Assesment13"].Value = 0;
                        }

                        if (gvYear3.Columns[colindex].Name == "Assesment23" && _Total > 100)
                        {
                            gvYear3.Rows[rowindex].Cells["Assesment23"].Value = 0;
                        }
                    }
                    else
                    {
                        gvYear3.Rows[rowindex].Cells["Total3"].Value = (_Assesment1 + _Assesment2) / 2;
                    }
                }
                else if (gvYear3.Columns[colindex].Name == "Weight3")
                {
                    int _TotalWeight = 0;
                    foreach (DataGridViewRow item in gvYear3.Rows)
                    {
                        if (item.Cells["Weight3"].Value != null && !string.IsNullOrEmpty(Convert.ToString(item.Cells["Weight3"].Value)))
                        {
                            _TotalWeight = _TotalWeight + Convert.ToInt32(item.Cells["Weight3"].Value);
                        }
                    }

                    if (_TotalWeight > 120)
                    {
                        _Flag = false;
                        MessageBox.Show("You can not select Weight more than 100.", Messages.MsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        gvYear3.Rows[rowindex].Cells["Weight3"].Value = "20";
                    }
                }

                if (_Flag)
                {
                    int _ModuleId = Convert.ToInt32(gvYear3.Rows[rowindex].Cells["Id3"].Value);
                    Module _Module = _ListOfModule.Where(m => m.ModuleID == _ModuleId).FirstOrDefault();

                    if (_Module != null)
                    {
                        _Module.Title = Convert.ToString(gvYear3.Rows[rowindex].Cells["Title3"].Value);
                        _Module.Assesment1 = Convert.ToInt32(gvYear3.Rows[rowindex].Cells["Assesment13"].Value);
                        _Module.Assesment2 = Convert.ToInt32(gvYear3.Rows[rowindex].Cells["Assesment23"].Value);
                        _Module.Total = Convert.ToInt32(gvYear3.Rows[rowindex].Cells["Total3"].Value);
                        _Module.Weight = Convert.ToInt32(gvYear3.Rows[rowindex].Cells["Weight3"].Value);
                        _Module.WeightString = Convert.ToString(gvYear3.Rows[rowindex].Cells["Weight3"].Value);
                    }
                }
            }
        }

        private void gvYear3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(txtNumber_KeyPress);
            if (gvYear3.CurrentCell.ColumnIndex == 1 || gvYear3.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(txtNumber_KeyPress);
                }
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion


        #region Private Methods

        private void FillGridYear1()
        {
            this.Cursor = Cursors.WaitCursor;

            gvYear1.DataSource = null;
            gvYear1.Rows.Clear();

            if (_ListOfModule != null)
            {
                gvYear1.DataSource = _ListOfModule.Where(m => m.Year == 1).ToList();
            }

            this.Cursor = Cursors.Default;
        }

        private void FillGridYear2()
        {
            this.Cursor = Cursors.WaitCursor;

            gvYear2.DataSource = null;
            gvYear2.Rows.Clear();

            if (_ListOfModule != null)
            {
                gvYear2.DataSource = _ListOfModule.Where(m => m.Year == 2).ToList();
            }

            this.Cursor = Cursors.Default;
        }

        private void FillGridYear3()
        {
            this.Cursor = Cursors.WaitCursor;

            gvYear3.DataSource = null;
            gvYear3.Rows.Clear();

            if (_ListOfModule != null)
            {
                gvYear3.DataSource = _ListOfModule.Where(m => m.Year == 3).ToList();
            }

            this.Cursor = Cursors.Default;
        }

        #endregion

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ListOfModule != null)
            {
               
                int _TotalWeightYear3 = _ListOfModule.Where(m => m.Year == 3).Sum(m => m.Weight);



                decimal year3Grade = 0; 
                if (_TotalWeightYear3 != 0)
                {


                  year3Grade  = Convert.ToDecimal(_ListOfModule.Where(m => m.Year == 3).Sum(m => (m.Total * m.Weight)) / _TotalWeightYear3);


                    lblTotalYear3Value.Text = Convert.ToString(year3Grade);
                    if (year3Grade < 40)
                        if (year3Grade < 40)
                            lblTotalYear1Value.ForeColor = Color.Red;
                        else if (year3Grade >= 40 && year3Grade < 50)
                            lblTotalYear1Value.ForeColor = Color.Orange;
                        else if (year3Grade >= 50 && year3Grade < 60)
                            lblTotalYear1Value.ForeColor = Color.Yellow;
                        else if (year3Grade >= 60 && year3Grade < 70)
                            lblTotalYear1Value.ForeColor = Color.Green;
                        else if (year3Grade >= 70 && year3Grade < 101)
                            lblTotalYear1Value.ForeColor = Color.Blue;


                }
               


                int _Indicator = (int)Math.Round(year3Grade);


                if (_Indicator >= 40 && _Indicator < 50)
                {
                    lblFinalGradeValue.Text = "3rd Class Honours (3) " + _Indicator;
                }
                else if (_Indicator >= 50 && _Indicator < 60)
                {
                    lblFinalGradeValue.Text = "2nd Class Honours Lower Division (2:ii) " + _Indicator;
                }
                else if (_Indicator >= 60 && _Indicator < 70)
                {
                    lblFinalGradeValue.Text = "2nd Class Honours Upper Division (2:i) " + _Indicator;
                }
                else if (_Indicator >= 70)
                {
                    lblFinalGradeValue.Text = "1st Class Honours (1) " + _Indicator;
                }
                else
                {
                    lblFinalGradeValue.Text = "Fail " + _Indicator;
                }
            }
        }

        private void gvYear1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }