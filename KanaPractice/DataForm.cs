using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //string learnHiraganaSQL = "SELECT Romanji, Hiragana FROM Kana";
            //string learnKatakanaSQL = "SELECT Romanji, Katakana FROM Kana";
            //string checkRomanjiKSQL = "SELECT Romanji, Katakana FROM Kana WHERE Romanji=@Romanji";
            //string checkRomanjiHSQL = "SELECT Romanji, Hiragana FROM Kana WHERE Romanji=@Romanji";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.radLearn.Checked)
            {
                if (this.radKatakana.Checked)
                {
                    string learnKatakanaSQL = "SELECT Romanji, Katakana FROM Kana";
                }
                if (this.radHiragana.Checked)
                {
                    string learnHiraganaSQL = "SELECT Romanji, Hiragana FROM Kana";
                }
            }
            if (this.radStudy.Checked)
            {
                if (this.radKatakana.Checked)
                {

                }
                if (this.radHiragana.Checked)
                {

                }
            }

        }
    }
}
