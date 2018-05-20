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
            SqlCommand sqlCommand = new SqlCommand();
            
            if (this.radLearn.Checked)
            {
                if (this.radKatakana.Checked)
                {
                    string learnKatakanaSQL = "SELECT Romanji, Katakana FROM Kana";
                    sqlCommand.CommandText = learnKatakanaSQL;

                }
                if (this.radHiragana.Checked)
                {
                    string learnHiraganaSQL = "SELECT Romanji, Hiragana FROM Kana";
                    sqlCommand.CommandText = learnHiraganaSQL;
                }
            }

            if (this.radStudy.Checked)
            {
                if (!(this.txtGuess.Text == string.Empty))
                {
                    if (this.radKatakana.Checked)
                    {
                        string studyKatakanaSQL = "SELECT Katakana FROM Kana WHERE Romanji = @Romanji";
                        sqlCommand.CommandText = studyKatakanaSQL;

                    }

                    if (this.radHiragana.Checked)
                    {
                        string studyHiraganaSQL = "SELECT Hiragana FROM Kana WHERE Romanji = @Romanji";
                        sqlCommand.CommandText = studyHiraganaSQL;
                    }
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        { }
    }
}