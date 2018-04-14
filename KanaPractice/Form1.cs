using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KanaPractice.Data;

namespace KanaPractice {

    /// <summary>
    /// Holds Events for Event Driven Form
    /// </summary>
    public partial class frmMain : Form {

        /// <summary>
        /// Constructor for class,
        /// this calls initComponents
        /// </summary>
        public frmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// Exits The Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e) {
            lblError.Text = String.Empty;
            lblKana.Text = String.Empty;
        }


        /// <summary>
        /// Shows a Message Box to teach kana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuKanaVowelsLearn_Click(object sender, EventArgs e) {
            if (radKatakana.Checked) {
                //?question Should I possibly Refactor this
                //?question into another form instead of a message box?
                MessageBox.Show($"{KanaData.vowels[0].Romanji} {KanaData.vowels[0].Katakana} \n" +
                    $"{KanaData.vowels[1].Romanji} {KanaData.vowels[1].Katakana}\n" +
                    $"{KanaData.vowels[2].Romanji} {KanaData.vowels[2].Katakana}\n" +
                    $"{KanaData.vowels[3].Romanji} {KanaData.vowels[3].Katakana}\n" +
                    $"{KanaData.vowels[4].Romanji} {KanaData.vowels[4].Katakana}");
            }
            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.vowels[0].Romanji} {KanaData.vowels[0].Hirg}\n" +
                    $"{KanaData.vowels[1].Romanji} {KanaData.vowels[1].Hirg}\n" +
                    $"{KanaData.vowels[2].Romanji} {KanaData.vowels[2].Hirg}\n" +
                    $"{KanaData.vowels[3].Romanji} {KanaData.vowels[3].Hirg}\n" +
                    $"{KanaData.vowels[4].Romanji} {KanaData.vowels[4].Hirg}");
            }
        }

        private void mnuKanaKSoundsLearn_Click(object sender, EventArgs e) {
            if(radKatakana.Checked) {
                MessageBox.Show($"{KanaData.kList[0].Romanji} {KanaData.kList[0].Katakana}\n" +
                    $"{KanaData.kList[1].Romanji} {KanaData.kList[1].Katakana}\n" +
                    $"{KanaData.kList[2].Romanji} {KanaData.kList[2].Katakana}\n" +
                    $"{KanaData.kList[3].Romanji} {KanaData.kList[4].Katakana}\n" +
                    $"{KanaData.kList[4].Romanji} {KanaData.kList[4].Katakana}");
            }
            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.kList[0].Romanji} {KanaData.kList[0].Hirg}\n" +
                    $"{KanaData.kList[1].Romanji} {KanaData.kList[1].Hirg}\n" +
                    $"{KanaData.kList[2].Romanji} {KanaData.kList[2].Hirg}\n" +
                    $"{KanaData.kList[3].Romanji} {KanaData.kList[3].Hirg}\n" +
                    $"{KanaData.kList[4].Romanji} {KanaData.kList[4].Hirg}");
            }
        }

        private void mnuKanaGSoundsLearn_Click(object sender, EventArgs e) {
            if(radKatakana.Checked) {
                MessageBox.Show($"{KanaData.gList[0].Romanji} {KanaData.gList[0].Katakana}\n" +
                    $"{KanaData.gList[1].Romanji} {KanaData.gList[1].Katakana}\n" +
                    $"{KanaData.gList[2].Romanji} {KanaData.gList[2].Katakana}\n" +
                    $"{KanaData.gList[3].Romanji} {KanaData.gList[3].Katakana}\n" +
                    $"{KanaData.gList[4].Romanji} {KanaData.gList[4].Katakana}");
            }
            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.gList[0].Romanji} {KanaData.gList[0].Hirg}\n" +
                    $"{KanaData.gList[1].Romanji} {KanaData.gList[1].Hirg}\n" +
                    $"{KanaData.gList[2].Romanji} {KanaData.gList[2].Hirg}\n" +
                    $"{KanaData.gList[3].Romanji} {KanaData.gList[3].Hirg}\n" +
                    $"{KanaData.gList[4].Romanji} {KanaData.gList[4].Hirg}");
            }
        }

        private void mnuKanaSSoundsLearn_Click(object sender, EventArgs e) {
            if(radKatakana.Checked) {
                MessageBox.Show($"{KanaData.sList[0].Romanji} {KanaData.sList[0].Katakana}\n" +
                    $"{KanaData.sList[1].Romanji} {KanaData.sList[1].Katakana}");
            }
        }
    }
}
