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
            lblSelectedSounds.Text = String.Empty;
        }


        /// <summary>
        /// Shows a Message Box to teach kana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuKanaVowelsLearn_Click(object sender, EventArgs e) {
            lblSelectedSounds.Text = "Vowels";
            if (radKatakana.Checked) {
                //?question Should I possibly Refactor this
                //?question into another form instead of a message box?
                MessageBox.Show($"{KanaData.vowels[0].Romanji} \t {KanaData.vowels[0].Katakana} \n" +
                    $"{KanaData.vowels[1].Romanji} \t {KanaData.vowels[1].Katakana}\n" +
                    $"{KanaData.vowels[2].Romanji} \t {KanaData.vowels[2].Katakana}\n" +
                    $"{KanaData.vowels[3].Romanji} \t {KanaData.vowels[3].Katakana}\n" +
                    $"{KanaData.vowels[4].Romanji} \t {KanaData.vowels[4].Katakana}","Vowels Katakana");
            }
            if(radHirigana.Checked) {
                //?question Possiblely Refactor into another form
                MessageBox.Show($"{KanaData.vowels[0].Romanji} \t {KanaData.vowels[0].Hirg}\n" +
                    $"{KanaData.vowels[1].Romanji} \t {KanaData.vowels[1].Hirg}\n" +
                    $"{KanaData.vowels[2].Romanji} \t {KanaData.vowels[2].Hirg}\n" +
                    $"{KanaData.vowels[3].Romanji} \t {KanaData.vowels[3].Hirg}\n" +
                    $"{KanaData.vowels[4].Romanji} \t {KanaData.vowels[4].Hirg}","Vowels Hiragana");
            }
        }

        private void mnuKanaKSoundsLearn_Click(object sender, EventArgs e) {
            //?question Should I re-factor this into anothe form?
            lblSelectedSounds.Text = "K Sounds";
            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.kList[0].Romanji} \t {KanaData.kList[0].Katakana}\n" +
                    $"{KanaData.kList[1].Romanji} \t {KanaData.kList[1].Katakana}\n" +
                    $"{KanaData.kList[2].Romanji} \t {KanaData.kList[2].Katakana}\n" +
                    $"{KanaData.kList[3].Romanji} \t {KanaData.kList[4].Katakana}\n" +
                    $"{KanaData.kList[4].Romanji} \t {KanaData.kList[4].Katakana}","K Sounds Katakana");
            }
            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.kList[0].Romanji} \t {KanaData.kList[0].Hirg}\n" +
                    $"{KanaData.kList[1].Romanji} \t {KanaData.kList[1].Hirg}\n" +
                    $"{KanaData.kList[2].Romanji} \t {KanaData.kList[2].Hirg}\n" +
                    $"{KanaData.kList[3].Romanji} \t {KanaData.kList[3].Hirg}\n" +
                    $"{KanaData.kList[4].Romanji} \t {KanaData.kList[4].Hirg}","K Sounds, Hiragana");
            }
        }

        private void mnuKanaGSoundsLearn_Click(object sender, EventArgs e) {
            //?question Should I refactor this into a new form
            lblSelectedSounds.Text = "G Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.gList[0].Romanji} \t {KanaData.gList[0].Katakana}\n" +
                    $"{KanaData.gList[1].Romanji} \t {KanaData.gList[1].Katakana}\n" +
                    $"{KanaData.gList[2].Romanji} \t {KanaData.gList[2].Katakana}\n" +
                    $"{KanaData.gList[3].Romanji} \t {KanaData.gList[3].Katakana}\n" +
                    $"{KanaData.gList[4].Romanji} \t {KanaData.gList[4].Katakana}","G Sounds Katakana");
            }
            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.gList[0].Romanji} \t {KanaData.gList[0].Hirg}\n" +
                    $"{KanaData.gList[1].Romanji} \t {KanaData.gList[1].Hirg}\n" +
                    $"{KanaData.gList[2].Romanji} \t {KanaData.gList[2].Hirg}\n" +
                    $"{KanaData.gList[3].Romanji} \t {KanaData.gList[3].Hirg}\n" +
                    $"{KanaData.gList[4].Romanji} \t {KanaData.gList[4].Hirg}","G Sounds Hiragana");
            }
        }

        private void mnuKanaSSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "S Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.sList[0].Romanji} \t {KanaData.sList[0].Katakana}\n" +
                    $"{KanaData.sList[1].Romanji} \t {KanaData.sList[1].Katakana}\n" +
                    $"{KanaData.sList[2].Romanji} \t {KanaData.sList[2].Katakana}\n" +
                    $"{KanaData.sList[3].Romanji} \t {KanaData.sList[3].Katakana}\n" +
                    $"{KanaData.sList[4].Romanji} \t {KanaData.sList[4].Katakana}","S Sounds Katakana");
            }
            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.sList[0].Romanji} \t {KanaData.sList[0].Hirg}\n" +
                    $"{KanaData.sList[1].Romanji} \t {KanaData.sList[1].Hirg}\n" +
                    $"{KanaData.sList[2].Romanji} \t {KanaData.sList[2].Hirg}\n" +
                    $"{KanaData.sList[3].Romanji} \t {KanaData.sList[3].Hirg} {KanaData.sList[3].Hirg}\n" +
                    $"{KanaData.sList[4].Romanji} \t {KanaData.sList[4].Hirg}","S Sounds Hiragana");
            }
        }

        private void mnuKanaZSoundsLearn_Click(object sender, EventArgs e) {
            //?question Should I refactor this into a new form
            lblSelectedSounds.Text = "Z Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.zList[0].Romanji} \t {KanaData.zList[0].Katakana}\n" +
                    $"{KanaData.zList[1].Romanji} \t {KanaData.zList[1].Katakana}\n" +
                    $"{KanaData.zList[2].Romanji} \t {KanaData.zList[2].Katakana}\n" +
                    $"{KanaData.zList[3].Romanji} \t {KanaData.zList[3].Katakana}\n" +
                    $"{KanaData.zList[4].Romanji} \t {KanaData.zList[4].Katakana}","Z Sounds Katakana");
            }
            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.zList[0].Romanji} \t {KanaData.zList[0].Hirg}" +
                    $"{KanaData.zList[1].Romanji} \t {KanaData.zList[1].Hirg}\n" +
                    $"{KanaData.zList[2].Romanji} \t {KanaData.zList[2].Hirg}\n" +
                    $"{KanaData.zList[3].Romanji} \t {KanaData.zList[3].Hirg}\n" +
                    $"{KanaData.zList[4].Romanji} \t {KanaData.zList[4].Hirg}", "Z Sounds Hiragana");
            }
        }

        private void mnuKanaTSoundsLearn_Click(object sender, EventArgs e) {
            //?question Should I refactor this into a new form
            lblSelectedSounds.Text = "T Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.tList[0].Romanji} \t {KanaData.tList[0].Katakana}\n" +
                    $"{KanaData.tList[1].Romanji} \t {KanaData.tList[1].Katakana}\n" +
                    $"{KanaData.tList[2].Romanji} \t {KanaData.tList[2].Katakana}\n" +
                    $"{KanaData.tList[3].Romanji} \t {KanaData.tList[3].Katakana}\n" +
                    $"{KanaData.tList[4].Romanji} \t {KanaData.tList[4].Katakana}", "T Sounds Katakana");
            }

            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.tList[0].Romanji} \t {KanaData.tList[0].Hirg}\n" +
                    $"{KanaData.tList[1].Romanji} \t {KanaData.tList[1].Hirg}\n" +
                    $"{KanaData.tList[2].Romanji} \t {KanaData.tList[2].Hirg}\n" +
                    $"{KanaData.tList[3].Romanji} \t {KanaData.tList[3].Hirg}\n" +
                    $"{KanaData.tList[4].Romanji} \t {KanaData.tList[4].Hirg}", "T Sounds, Hiragana");
            }
        }

        private void mnuKanaDSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form
            lblSelectedSounds.Text = "D Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.dList[0].Romanji} \t {KanaData.dList[0].Katakana}\n" +
                    $"{KanaData.dList[1].Romanji} \t {KanaData.dList[1].Katakana}\n" +
                    $"{KanaData.dList[2].Romanji} \t {KanaData.dList[2].Katakana}\n" +
                    $"{KanaData.dList[3].Romanji} \t {KanaData.dList[3].Katakana}\n" +
                    $"{KanaData.dList[4].Romanji} \t {KanaData.dList[4].Katakana}", "D Sounds Katakana");
            }

            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.dList[0].Romanji} \t {KanaData.dList[0].Hirg}\n" +
                    $"{KanaData.dList[1].Romanji} \t {KanaData.dList[1].Hirg}\n" +
                    $"{KanaData.dList[2].Romanji} \t {KanaData.dList[2].Hirg}\n" +
                    $"{KanaData.dList[3].Romanji} \t {KanaData.dList[3].Hirg}\n" +
                    $"{KanaData.dList[4].Romanji} \t {KanaData.dList[4].Hirg}", "D Sounds Hiragana");
            }
        }


        private void mnuKanaTSounds_Click(object sender, EventArgs e) {
            //do nothing I accidently clicked this when trying to make an event handler for something else.
        }

        private void mnuKanaNSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "N Sounds";


            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.nList[0].Romanji} \t {KanaData.nList[0].Katakana}\n" +
                    $"{KanaData.nList[1].Romanji} \t {KanaData.nList[1].Katakana}\n" +
                    $"{KanaData.nList[2].Romanji} \t {KanaData.nList[2].Katakana}\n" +
                    $"{KanaData.nList[3].Romanji} \t {KanaData.nList[3].Katakana}\n" +
                    $"{KanaData.nList[4].Romanji} \t {KanaData.nList[4].Katakana}", "N Sounds Katakana");
            }

            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.nList[0].Romanji} \t {KanaData.nList[0].Hirg}\n" +
                    $"{KanaData.nList[1].Romanji} \t {KanaData.nList[1].Hirg}\n" +
                    $"{KanaData.nList[2].Romanji} \t {KanaData.nList[2].Hirg}\n" +
                    $"{KanaData.nList[3].Romanji} \t {KanaData.nList[3].Hirg}\n" +
                    $"{KanaData.nList[4].Romanji} \t {KanaData.nList[4].Hirg}", "N Sounds Hiragana");
            }
        }

        private void mnuKanaHSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "H Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.hList[0].Romanji} \t {KanaData.hList[0].Katakana}\n" +
                    $"{KanaData.hList[1].Romanji} \t {KanaData.hList[1].Katakana}\n" +
                    $"{KanaData.hList[2].Romanji} \t {KanaData.hList[2].Katakana}\n" +
                    $"{KanaData.hList[3].Romanji} \t {KanaData.hList[3].Katakana}\n" +
                    $"{KanaData.hList[4].Romanji} \t {KanaData.hList[4].Katakana}", "H Sounds Katakana");
            }

            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.hList[0].Romanji} \t {KanaData.hList[0].Hirg}\t" +
                    $"{KanaData.hList[1].Romanji} \t {KanaData.hList[1].Hirg}\n" +
                    $"{KanaData.hList[2].Romanji} \t {KanaData.hList[2].Hirg}\n" +
                    $"{KanaData.hList[3].Romanji} \t {KanaData.hList[3].Hirg}\n" +
                    $"{KanaData.hList[4].Romanji} \t {KanaData.hList[4].Hirg}", "H Sounds Hiragana");
            }
        }

        private void mnuKanaBSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "B Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.bList[0].Romanji} \t {KanaData.bList[0].Katakana}\n" +
                    $"{KanaData.bList[1].Romanji} \t {KanaData.bList[1].Katakana}\n" +
                    $"{KanaData.bList[2].Romanji} \t {KanaData.bList[2].Katakana}\n" +
                    $"{KanaData.bList[3].Romanji} \t {KanaData.bList[3].Katakana}\n" +
                    $"{KanaData.bList[4].Romanji} \t {KanaData.bList[4].Katakana}", "B Sounds Katakana");
            }

            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.bList[0].Romanji} \t {KanaData.bList[0].Hirg}\n" +
                    $"{KanaData.bList[1].Romanji} \t {KanaData.bList[1].Hirg}\n" +
                    $"{KanaData.bList[2].Romanji} \t {KanaData.bList[2].Hirg}\n" +
                    $"{KanaData.bList[3].Romanji} \t {KanaData.bList[3].Hirg}\n" +
                    $"{KanaData.bList[4].Romanji} \t {KanaData.bList[4].Hirg}", "B Sounds Hiragana");
            }
        }

        private void mnuKanaPSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "P Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.pList[0].Romanji} \t {KanaData.pList[0].Katakana}\n" +
                    $"{KanaData.pList[1].Romanji} \t {KanaData.pList[1].Katakana}\n" +
                    $"{KanaData.pList[2].Romanji} \t {KanaData.pList[2].Katakana}\n" +
                    $"{KanaData.pList[3].Romanji} \t {KanaData.pList[3].Katakana}\n" +
                    $"{KanaData.pList[4].Romanji} \t {KanaData.pList[4].Katakana}", "P Sounds Katakana");
            }

            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.pList[0].Romanji} \t {KanaData.pList[0].Hirg}\n" +
                    $"{KanaData.pList[1].Romanji} \t {KanaData.pList[1].Hirg}\n" +
                    $"{KanaData.pList[2].Romanji} \t {KanaData.pList[2].Hirg}\n" +
                    $"{KanaData.pList[3].Romanji} \t {KanaData.pList[3].Hirg}\n" +
                    $"{KanaData.pList[4].Romanji} \t {KanaData.pList[4].Hirg}", "P Sounds Hiragana");
            }
        }

        private void mnuKanaMSoundsLearn_Click(object sender, EventArgs e) {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "M Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.mList[0].Romanji} \t {KanaData.mList[0].Katakana}\n" +
                    $"{KanaData.mList[1].Romanji} \t {KanaData.mList[1].Katakana}\n" +
                    $"{KanaData.mList[2].Romanji} \t {KanaData.mList[2].Katakana}\n" +
                    $"{KanaData.mList[3].Romanji} \t {KanaData.mList[3].Katakana}\n" +
                    $"{KanaData.mList[4].Romanji} \t {KanaData.mList[4].Katakana}", "M Sounds Katakana");
            }

            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.mList[0].Romanji} \t {KanaData.mList[0].Hirg}\n" +
                    $"{KanaData.mList[1].Romanji} \t {KanaData.mList[1].Hirg}\n" +
                    $"{KanaData.mList[2].Romanji} \t {KanaData.mList[2].Hirg}\n" +
                    $"{KanaData.mList[3].Romanji} \t {KanaData.mList[3].Hirg}\n" +
                    $"{KanaData.mList[4].Romanji} \t {KanaData.mList[4].Hirg}","M Sounds Hiragana");
            }
        }

        private void mnuKanaYSoundsLearn_Click(object sender, EventArgs e) {
            //!important Note that this list only has 3 elements in it
            lblSelectedSounds.Text = "Y Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.yList[0].Romanji} \t {KanaData.yList[0].Katakana}\n" +
                    $"{KanaData.yList[1].Romanji} \t {KanaData.yList[1].Katakana}\n" +
                    $"{KanaData.yList[2].Romanji} \t {KanaData.yList[2].Katakana}", "Y Sounds Katakana");
            }

            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.yList[0].Romanji} \t {KanaData.yList[0].Hirg}\n" +
                    $"{KanaData.yList[1].Romanji} \t {KanaData.yList[1].Hirg}\n" +
                    $"{KanaData.yList[2].Romanji} \t {KanaData.yList[2].Hirg}", "Y Sounds Hiragana");
            }
        }

        private void mnuKanaRSoundsLearn_Click(object sender, EventArgs e) {
            //!important The corrospinding List here has 5 elements (subscripts 0 -4)
            lblSelectedSounds.Text = "R Sounds";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.rList[0].Romanji} \t {KanaData.rList[0].Katakana}\n" +
                    $"{KanaData.rList[1].Romanji} \t {KanaData.rList[1].Katakana}\n" +
                    $"{KanaData.rList[2].Romanji} \t {KanaData.rList[2].Katakana}\n" +
                    $"{KanaData.rList[3].Romanji} \t {KanaData.rList[3].Katakana}\n" +
                    $"{KanaData.rList[4].Romanji} \t {KanaData.rList[4].Katakana}", "R Sounds Katakana");
            }

            if(radHirigana.Checked) {
                MessageBox.Show($"{KanaData.rList[0].Romanji} \t {KanaData.rList[0].Hirg}\n" +
                    $"{KanaData.rList[1].Romanji} \t {KanaData.rList[1].Hirg}\n" +
                    $"{KanaData.rList[2].Romanji} \t {KanaData.rList[2].Hirg}\n" +
                    $"{KanaData.rList[3].Romanji} \t {KanaData.rList[3].Hirg}\n" +
                    $"{KanaData.rList[4].Romanji} \t {KanaData.rList[4].Hirg}", "R Sounds Hiragana");
            }
        }

        private void mnuKanaWSoundsLearn_Click(object sender, EventArgs e) {
            //!important This corrosponding list only has 3 elements (subscripts 0 - 2)

            //?question Should I use another form instead of a message box for the "learn" feature
            lblSelectedSounds.Text = "W Sounds (Wa, Wo, N)";

            if (radKatakana.Checked) {
                MessageBox.Show($"{KanaData.wList[0].Romanji} \t {KanaData.wList[0].Katakana}\n" +
                    $"{KanaData.wList[1].Romanji} \t {KanaData.wList[1].Katakana}\n" +
                    $"{KanaData.wList[2].Romanji} \t {KanaData.wList[2].Katakana}", "W Sounds Katakana");
            }

            if (radHirigana.Checked) {
                MessageBox.Show($"{KanaData.wList[0].Romanji} \t {KanaData.wList[0].Hirg}\n" +
                    $"{KanaData.wList[1].Romanji} \t {KanaData.wList[1].Hirg}\n" +
                    $"{KanaData.wList[2].Romanji} \t {KanaData.wList[2].Hirg}", "W Sounds Hiragana");
            }


        }

        private void mnuModifedLearn_Click(object sender, EventArgs e) {
            //!important 36 (Subscripts 0 - 35) Elements in this list
            //todo Create a New Form, for this "Learn" functionality
        }

        private void mnuKanaVowelsStudy_Click(object sender, EventArgs e) {

        }
    }
}
