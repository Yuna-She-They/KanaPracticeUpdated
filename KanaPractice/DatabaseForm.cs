using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanaPractice
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void kanaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kanaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.japaneseKanaDataSet);

        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'japaneseKanaDataSet.Kana' table. You can move, or remove it, as needed.
            this.kanaTableAdapter.Fill(this.japaneseKanaDataSet.Kana);
            radLearn.Checked = true;
            lblKana.Text = String.Empty;
            lblError.Text = String.Empty;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (radLearn.Checked)
            {
                lblKana.Text = String.Empty;
                lblError.Text = String.Empty;
            }
            if (radStudy.Checked)
            {
                if(radHiragana.Checked)
                {
                    //somehow produce a random kana from the database

                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (radHiragana.Checked)
            {
                try
                {
                    string toCheck = txtGuess.Text;
                    OleDbCommand cmd = new OleDbCommand("SELECT Hiragana FROM Kana WHERE " + toCheck + "LIKE Romanji");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }
            }
        }
    }
}
