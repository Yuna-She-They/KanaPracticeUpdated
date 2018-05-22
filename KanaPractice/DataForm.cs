using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanaPractice
{
    public partial class DataForm : Form
    {
        /// <summary>
        /// Constructor for Form.
        /// </summary>
        public DataForm()
        {
            InitializeComponent();
        }

        private void kanaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kanaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kanaDataSet);

        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kanaDataSet.Kana' table. You can move, or remove it, as needed.
            this.kanaTableAdapter.Fill(this.kanaDataSet.Kana);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int myNum = rand.Next(1, 106);
            while (myNum == 103)
            {
                myNum = rand.Next(1, 106);
            }
            if (this.radLearn.Checked)
            {
                if (this.radKatakana.Checked)
                {
                    GetData("SELECT Romanji, Katakana FROM Kana",null);
                    kanaDataGridView.Columns[0].Visible = false;
                    kanaDataGridView.Columns[1].Visible = true;
                    kanaDataGridView.Columns[2].Visible = true;
                    // 0 = id, 1 = romanji, 2 = katakana 3 = hiragana
                    kanaDataGridView.Columns[3].Visible = false;
                }
                if (this.radHiragana.Checked)
                {
                    GetData("SELECT Romanji, Hiragana FROM Kana",null);
                    kanaDataGridView.Columns[0].Visible = false;
                    kanaDataGridView.Columns[1].Visible = true;
                    kanaDataGridView.Columns[2].Visible = false;
                    kanaDataGridView.Columns[3].Visible = true;
                }

            }

            if (this.radStudy.Checked)
            {
                if (this.radKatakana.Checked)
                {
                    GetData("SELECT Katakana FROM Kana WHERE ID=" + myNum,myNum);
                    kanaDataGridView.Columns[0].Visible = false;
                    kanaDataGridView.Columns[1].Visible = false;
                    kanaDataGridView.Columns[2].Visible = true;
                    kanaDataGridView.Columns[3].Visible = false;
                }
                if (this.radHiragana.Checked)
                {
                    GetData("SELECT Hiragana FROM Kana WHERE ID=" + myNum, myNum);
                    kanaDataGridView.Columns[0].Visible = false;
                    kanaDataGridView.Columns[1].Visible = false;
                    kanaDataGridView.Columns[2].Visible = false;
                    kanaDataGridView.Columns[3].Visible = true;
                }

            }
            //kanaDataGridView.EndEdit();
            kanaDataGridView.Refresh();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text != string.Empty)
            {
                GetData("SELECT Romanji,Katakana,Hiragana FROM Kana WHERE Romanji='" + txtGuess.Text + "'", null);
                //Todo figure out how to get romanji  into label error if romanji is wrong.
                kanaDataGridView.Columns[1].Visible = true;
                kanaDataGridView.Columns[2].Visible = true;
                kanaDataGridView.Columns[3].Visible = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetData(string selectCommand,int? kanaID)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True";
                SqlDataAdapter kanaDataAdapter = new SqlDataAdapter(selectCommand, connectionString);
                DataTable kanaDataTable = new DataTable();
                if (kanaID != null)
                {
                    SqlCommand cmd = new SqlCommand(selectCommand);
                    cmd.Parameters.AddWithValue("kanaID", (int)kanaID);
                }
                else
                {
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(kanaDataAdapter);
                }

                kanaDataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                kanaDataAdapter.Fill(kanaDataTable);
                kanaBindingSource.DataSource = kanaDataTable;
                kanaDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                kanaDataGridView.Refresh();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}