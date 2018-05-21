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

                    if (KanaDB.Learn(myNum,true))
                    {
                        kanaDataGridView.Refresh();
                    }
                }
                if (this.radHiragana.Checked)
                {
                    if (KanaDB.Learn(myNum,false))
                    {
                        kanaDataGridView.Refresh();
                    }
                }

            }

            if (this.radStudy.Checked)
            {
                if (this.radKatakana.Checked)
                {
                    KanaDB.Study(myNum, true);
                    kanaDataGridView.Refresh();
                }
                if (this.radHiragana.Checked)
                {
                    KanaDB.Study(myNum, false);
                    kanaDataGridView.Refresh();
                }

            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}