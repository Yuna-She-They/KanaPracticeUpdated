
namespace KanaPractice {

    #region Using Directives
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
    #endregion Using Directives

    /// <summary>
    /// Holds Events for Event Driven Form
    /// </summary>
    public partial class CfrmMain : Form {

        /// <summary>
        /// Constructor for class,
        /// this calls initComponents
        /// </summary>
        public CfrmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// Exits The Application
        /// </summary>
        private void mnuExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// Form Load Event
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            lblKana.Text = String.Empty;
            lblSelectedSounds.Text = String.Empty;
        }


        /// <summary>
        /// Learn Japanese Vowel Sounds.
        /// </summary>
        private void mnuKanaVowelsLearn_Click(object sender, EventArgs e) {
            lblSelectedSounds.Text = "Vowels";
            if (radKatakana.Checked)
            {
				//?question Should I possibly Refactor this
				//?question into another form instead of a message box?
				/*remove MessageBox.Show($"{KanaData.vowels[0].Romanji} \t {KanaData.vowels[0].Katakana} \n" +
                    $"{KanaData.vowels[1].Romanji} \t {KanaData.vowels[1].Katakana}\n" +
                    $"{KanaData.vowels[2].Romanji} \t {KanaData.vowels[2].Katakana}\n" +
                    $"{KanaData.vowels[3].Romanji} \t {KanaData.vowels[3].Katakana}\n" +
                    $"{KanaData.vowels[4].Romanji} \t {KanaData.vowels[4].Katakana}","Vowels Katakana");
				*/
				MessageBox.Show(Learn(KanaData.vowels, true), "Vowels in Katakana");
            }
            if (radHirigana.Checked)
            {
				//?question Possiblely Refactor into another form
				/*remove MessageBox.Show($"{KanaData.vowels[0].Romanji} \t {KanaData.vowels[0].Hirg}\n" +
                    $"{KanaData.vowels[1].Romanji} \t {KanaData.vowels[1].Hirg}\n" +
                    $"{KanaData.vowels[2].Romanji} \t {KanaData.vowels[2].Hirg}\n" +
                    $"{KanaData.vowels[3].Romanji} \t {KanaData.vowels[3].Hirg}\n" +
                    $"{KanaData.vowels[4].Romanji} \t {KanaData.vowels[4].Hirg}","Vowels Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.vowels, false), "Vowels in Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese K Sounds.
        /// </summary>
        private void mnuKanaKSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question Should I re-factor this into another form?
            lblSelectedSounds.Text = "K Sounds";
            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.kList[0].Romanji} \t {KanaData.kList[0].Katakana}\n" +
                    $"{KanaData.kList[1].Romanji} \t {KanaData.kList[1].Katakana}\n" +
                    $"{KanaData.kList[2].Romanji} \t {KanaData.kList[2].Katakana}\n" +
                    $"{KanaData.kList[3].Romanji} \t {KanaData.kList[4].Katakana}\n" +
                    $"{KanaData.kList[4].Romanji} \t {KanaData.kList[4].Katakana}","K Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.kList, true), "K Sounds Katakana");

            }
            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.kList[0].Romanji} \t {KanaData.kList[0].Hirg}\n" +
                    $"{KanaData.kList[1].Romanji} \t {KanaData.kList[1].Hirg}\n" +
                    $"{KanaData.kList[2].Romanji} \t {KanaData.kList[2].Hirg}\n" +
                    $"{KanaData.kList[3].Romanji} \t {KanaData.kList[3].Hirg}\n" +
                    $"{KanaData.kList[4].Romanji} \t {KanaData.kList[4].Hirg}","K Sounds, Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.kList, false), "K sounds hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese G Sounds.
        /// </summary>
        private void mnuKanaGSoundsLearn_Click(object sender, EventArgs e) {
            // ?question Should I refactor this into a new form
            lblSelectedSounds.Text = "G Sounds";

            if (radKatakana.Checked)
            {
				/*removeMessageBox.Show($"{KanaData.gList[0].Romanji} \t {KanaData.gList[0].Katakana}\n" +
                    $"{KanaData.gList[1].Romanji} \t {KanaData.gList[1].Katakana}\n" +
                    $"{KanaData.gList[2].Romanji} \t {KanaData.gList[2].Katakana}\n" +
                    $"{KanaData.gList[3].Romanji} \t {KanaData.gList[3].Katakana}\n" +
                    $"{KanaData.gList[4].Romanji} \t {KanaData.gList[4].Katakana}","G Sounds Katakana");*/
				MessageBox.Show(Learn(KanaData.gList, true), "G Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.gList[0].Romanji} \t {KanaData.gList[0].Hirg}\n" +
                    $"{KanaData.gList[1].Romanji} \t {KanaData.gList[1].Hirg}\n" +
                    $"{KanaData.gList[2].Romanji} \t {KanaData.gList[2].Hirg}\n" +
                    $"{KanaData.gList[3].Romanji} \t {KanaData.gList[3].Hirg}\n" +
                    $"{KanaData.gList[4].Romanji} \t {KanaData.gList[4].Hirg}","G Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.gList, false), "G Sounds hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese S Sounds.
        /// </summary>
        private void mnuKanaSSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question should I refactor this into a new form?
            this.lblSelectedSounds.Text = "S Sounds";

            if (radKatakana.Checked)
            {

				/*remove MessageBox.Show($"{KanaData.sList[0].Romanji} \t {KanaData.sList[0].Katakana}\n" +
                    $"{KanaData.sList[1].Romanji} \t {KanaData.sList[1].Katakana}\n" +
                    $"{KanaData.sList[2].Romanji} \t {KanaData.sList[2].Katakana}\n" +
                    $"{KanaData.sList[3].Romanji} \t {KanaData.sList[3].Katakana}\n" +
                    $"{KanaData.sList[4].Romanji} \t {KanaData.sList[4].Katakana}","S Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.sList, true), "S sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.sList[0].Romanji} \t {KanaData.sList[0].Hirg}\n" +
                    $"{KanaData.sList[1].Romanji} \t {KanaData.sList[1].Hirg}\n" +
                    $"{KanaData.sList[2].Romanji} \t {KanaData.sList[2].Hirg}\n" +
                    $"{KanaData.sList[3].Romanji} \t {KanaData.sList[3].Hirg} {KanaData.sList[3].Hirg}\n" +
                    $"{KanaData.sList[4].Romanji} \t {KanaData.sList[4].Hirg}","S Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.sList, false), "S Sounds Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese Z Sounds.
        /// </summary>
        private void mnuKanaZSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question Should I refactor this into a new form
            lblSelectedSounds.Text = "Z Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.zList[0].Romanji} \t {KanaData.zList[0].Katakana}\n" +
                    $"{KanaData.zList[1].Romanji} \t {KanaData.zList[1].Katakana}\n" +
                    $"{KanaData.zList[2].Romanji} \t {KanaData.zList[2].Katakana}\n" +
                    $"{KanaData.zList[3].Romanji} \t {KanaData.zList[3].Katakana}\n" +
                    $"{KanaData.zList[4].Romanji} \t {KanaData.zList[4].Katakana}","Z Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.zList, true), "Z Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				/*remove  MessageBox.Show($"{KanaData.zList[0].Romanji} \t {KanaData.zList[0].Hirg}" +
					 $"{KanaData.zList[1].Romanji} \t {KanaData.zList[1].Hirg}\n" +
					 $"{KanaData.zList[2].Romanji} \t {KanaData.zList[2].Hirg}\n" +
					 $"{KanaData.zList[3].Romanji} \t {KanaData.zList[3].Hirg}\n" +
					 $"{KanaData.zList[4].Romanji} \t {KanaData.zList[4].Hirg}", "Z Sounds Hiragana");
				 */
				MessageBox.Show(Learn(KanaData.zList, false), "Z Sounds Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese T Sounds.
        /// </summary>
        private void mnuKanaTSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question Should I refactor this into a new form
            lblSelectedSounds.Text = "T Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.tList[0].Romanji} \t {KanaData.tList[0].Katakana}\n" +
                    $"{KanaData.tList[1].Romanji} \t {KanaData.tList[1].Katakana}\n" +
                    $"{KanaData.tList[2].Romanji} \t {KanaData.tList[2].Katakana}\n" +
                    $"{KanaData.tList[3].Romanji} \t {KanaData.tList[3].Katakana}\n" +
                    $"{KanaData.tList[4].Romanji} \t {KanaData.tList[4].Katakana}", "T Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.tList, true), "T Sounds Katakana");
            }

            if (radHirigana.Checked)
            {

				/*remove MessageBox.Show($"{KanaData.tList[0].Romanji} \t {KanaData.tList[0].Hirg}\n" +
                    $"{KanaData.tList[1].Romanji} \t {KanaData.tList[1].Hirg}\n" +
                    $"{KanaData.tList[2].Romanji} \t {KanaData.tList[2].Hirg}\n" +
                    $"{KanaData.tList[3].Romanji} \t {KanaData.tList[3].Hirg}\n" +
                    $"{KanaData.tList[4].Romanji} \t {KanaData.tList[4].Hirg}", "T Sounds, Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.tList, false), "T Sounds Hiragana");

            }
        }

        /// <summary>
        /// Learn Japanese D Sounds
        /// </summary>
        private void mnuKanaDSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question should I refactor this into a new form
            lblSelectedSounds.Text = "D Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.dList[0].Romanji} \t {KanaData.dList[0].Katakana}\n" +
                    $"{KanaData.dList[1].Romanji} \t {KanaData.dList[1].Katakana}\n" +
                    $"{KanaData.dList[2].Romanji} \t {KanaData.dList[2].Katakana}\n" +
                    $"{KanaData.dList[3].Romanji} \t {KanaData.dList[3].Katakana}\n" +
                    $"{KanaData.dList[4].Romanji} \t {KanaData.dList[4].Katakana}", "D Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.dList, true), "D Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.dList[0].Romanji} \t {KanaData.dList[0].Hirg}\n" +
                    $"{KanaData.dList[1].Romanji} \t {KanaData.dList[1].Hirg}\n" +
                    $"{KanaData.dList[2].Romanji} \t {KanaData.dList[2].Hirg}\n" +
                    $"{KanaData.dList[3].Romanji} \t {KanaData.dList[3].Hirg}\n" +
                    $"{KanaData.dList[4].Romanji} \t {KanaData.dList[4].Hirg}", "D Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.dList, false), "D Sounds Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese T Sounds
        /// </summary>
        private void mnuKanaTSounds_Click(object sender, EventArgs e) {
            //do nothing I accidently clicked this when trying to make an event handler for something else.
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaNSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "N Sounds";


            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.nList[0].Romanji} \t {KanaData.nList[0].Katakana}\n" +
                    $"{KanaData.nList[1].Romanji} \t {KanaData.nList[1].Katakana}\n" +
                    $"{KanaData.nList[2].Romanji} \t {KanaData.nList[2].Katakana}\n" +
                    $"{KanaData.nList[3].Romanji} \t {KanaData.nList[3].Katakana}\n" +
                    $"{KanaData.nList[4].Romanji} \t {KanaData.nList[4].Katakana}", "N Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.nList, true), "N Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.nList[0].Romanji} \t {KanaData.nList[0].Hirg}\n" +
                    $"{KanaData.nList[1].Romanji} \t {KanaData.nList[1].Hirg}\n" +
                    $"{KanaData.nList[2].Romanji} \t {KanaData.nList[2].Hirg}\n" +
                    $"{KanaData.nList[3].Romanji} \t {KanaData.nList[3].Hirg}\n" +
                    $"{KanaData.nList[4].Romanji} \t {KanaData.nList[4].Hirg}", "N Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.nList, false), "N Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaHSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question should I refactor this into a new form?
            lblSelectedSounds.Text = "H Sounds";
            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.hList[0].Romanji} \t {KanaData.hList[0].Katakana}\n" +
                    $"{KanaData.hList[1].Romanji} \t {KanaData.hList[1].Katakana}\n" +
                    $"{KanaData.hList[2].Romanji} \t {KanaData.hList[2].Katakana}\n" +
                    $"{KanaData.hList[3].Romanji} \t {KanaData.hList[3].Katakana}\n" +
                    $"{KanaData.hList[4].Romanji} \t {KanaData.hList[4].Katakana}", "H Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.hList, true), "H Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.hList[0].Romanji} \t {KanaData.hList[0].Hirg}\t" +
                    $"{KanaData.hList[1].Romanji} \t {KanaData.hList[1].Hirg}\n" +
                    $"{KanaData.hList[2].Romanji} \t {KanaData.hList[2].Hirg}\n" +
                    $"{KanaData.hList[3].Romanji} \t {KanaData.hList[3].Hirg}\n" +
                    $"{KanaData.hList[4].Romanji} \t {KanaData.hList[4].Hirg}", "H Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.hList, false), "H Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaBSoundsLearn_Click(object sender, EventArgs e) {
            // ?question should I refactor this into a new form?
            lblSelectedSounds.Text = "B Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.bList[0].Romanji} \t {KanaData.bList[0].Katakana}\n" +
                    $"{KanaData.bList[1].Romanji} \t {KanaData.bList[1].Katakana}\n" +
                    $"{KanaData.bList[2].Romanji} \t {KanaData.bList[2].Katakana}\n" +
                    $"{KanaData.bList[3].Romanji} \t {KanaData.bList[3].Katakana}\n" +
                    $"{KanaData.bList[4].Romanji} \t {KanaData.bList[4].Katakana}", "B Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.bList, true), "B Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.bList[0].Romanji} \t {KanaData.bList[0].Hirg}\n" +
                    $"{KanaData.bList[1].Romanji} \t {KanaData.bList[1].Hirg}\n" +
                    $"{KanaData.bList[2].Romanji} \t {KanaData.bList[2].Hirg}\n" +
                    $"{KanaData.bList[3].Romanji} \t {KanaData.bList[3].Hirg}\n" +
                    $"{KanaData.bList[4].Romanji} \t {KanaData.bList[4].Hirg}", "B Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.bList, false), "B Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaPSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question should I refactor this into a new form?
            lblSelectedSounds.Text = "P Sounds";
            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.pList[0].Romanji} \t {KanaData.pList[0].Katakana}\n" +
                    $"{KanaData.pList[1].Romanji} \t {KanaData.pList[1].Katakana}\n" +
                    $"{KanaData.pList[2].Romanji} \t {KanaData.pList[2].Katakana}\n" +
                    $"{KanaData.pList[3].Romanji} \t {KanaData.pList[3].Katakana}\n" +
                    $"{KanaData.pList[4].Romanji} \t {KanaData.pList[4].Katakana}", "P Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.pList, true), "P Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.pList[0].Romanji} \t {KanaData.pList[0].Hirg}\n" +
                    $"{KanaData.pList[1].Romanji} \t {KanaData.pList[1].Hirg}\n" +
                    $"{KanaData.pList[2].Romanji} \t {KanaData.pList[2].Hirg}\n" +
                    $"{KanaData.pList[3].Romanji} \t {KanaData.pList[3].Hirg}\n" +
                    $"{KanaData.pList[4].Romanji} \t {KanaData.pList[4].Hirg}", "P Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.pList, false), "P Sounds Hiragana");
            }
        }

        /// <summary>
        /// Japanese M Sounds.
        /// </summary>
        private void mnuKanaMSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "M Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.mList[0].Romanji} \t {KanaData.mList[0].Katakana}\n" +
                    $"{KanaData.mList[1].Romanji} \t {KanaData.mList[1].Katakana}\n" +
                    $"{KanaData.mList[2].Romanji} \t {KanaData.mList[2].Katakana}\n" +
                    $"{KanaData.mList[3].Romanji} \t {KanaData.mList[3].Katakana}\n" +
                    $"{KanaData.mList[4].Romanji} \t {KanaData.mList[4].Katakana}", "M Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.mList, true), "M Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.mList[0].Romanji} \t {KanaData.mList[0].Hirg}\n" +
					 $"{KanaData.mList[1].Romanji} \t {KanaData.mList[1].Hirg}\n" +
					 $"{KanaData.mList[2].Romanji} \t {KanaData.mList[2].Hirg}\n" +
					 $"{KanaData.mList[3].Romanji} \t {KanaData.mList[3].Hirg}\n" +
					 $"{KanaData.mList[4].Romanji} \t {KanaData.mList[4].Hirg}","M Sounds Hiragana");
				 */
				MessageBox.Show(Learn(KanaData.mList, false), "M Sounds Hiragana");
            }
        }

        /// <summary>
        /// Japanese Y sounds, also used in Modifed Kana. <see cref="KanaData.modifiedKanaList"/>
        /// </summary>
        private void mnuKanaYSoundsLearn_Click(object sender, EventArgs e)
        {
            // !important Note that this list only has 3 elements in it
            lblSelectedSounds.Text = "Y Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.yList[0].Romanji} \t {KanaData.yList[0].Katakana}\n" +
                    $"{KanaData.yList[1].Romanji} \t {KanaData.yList[1].Katakana}\n" +
                    $"{KanaData.yList[2].Romanji} \t {KanaData.yList[2].Katakana}", "Y Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.yList, true), "Y Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.yList[0].Romanji} \t {KanaData.yList[0].Hirg}\n" +
                    $"{KanaData.yList[1].Romanji} \t {KanaData.yList[1].Hirg}\n" +
                    $"{KanaData.yList[2].Romanji} \t {KanaData.yList[2].Hirg}", "Y Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.yList, false), "Y Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaRSoundsLearn_Click(object sender, EventArgs e)
        {
            //!important The corrospinding List here has 5 elements (subscripts 0 -4)
            lblSelectedSounds.Text = "R Sounds";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.rList[0].Romanji} \t {KanaData.rList[0].Katakana}\n" +
                    $"{KanaData.rList[1].Romanji} \t {KanaData.rList[1].Katakana}\n" +
                    $"{KanaData.rList[2].Romanji} \t {KanaData.rList[2].Katakana}\n" +
                    $"{KanaData.rList[3].Romanji} \t {KanaData.rList[3].Katakana}\n" +
                    $"{KanaData.rList[4].Romanji} \t {KanaData.rList[4].Katakana}", "R Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.rList, true), "R Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.rList[0].Romanji} \t {KanaData.rList[0].Hirg}\n" +
                    $"{KanaData.rList[1].Romanji} \t {KanaData.rList[1].Hirg}\n" +
                    $"{KanaData.rList[2].Romanji} \t {KanaData.rList[2].Hirg}\n" +
                    $"{KanaData.rList[3].Romanji} \t {KanaData.rList[3].Hirg}\n" +
                    $"{KanaData.rList[4].Romanji} \t {KanaData.rList[4].Hirg}", "R Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.rList, false), "R Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaWSoundsLearn_Click(object sender, EventArgs e)
        {
            // !important This corrosponding list only has 3 elements (subscripts 0 - 2)

            // ?question Should I use another form instead of a message box for the "learn" feature
            lblSelectedSounds.Text = "W Sounds (Wa, Wo, N)";

            if (radKatakana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.wList[0].Romanji} \t {KanaData.wList[0].Katakana}\n" +
                    $"{KanaData.wList[1].Romanji} \t {KanaData.wList[1].Katakana}\n" +
                    $"{KanaData.wList[2].Romanji} \t {KanaData.wList[2].Katakana}", "W Sounds Katakana");
				*/
				MessageBox.Show(Learn(KanaData.wList, true), "W Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				/*remove MessageBox.Show($"{KanaData.wList[0].Romanji} \t {KanaData.wList[0].Hirg}\n" +
                    $"{KanaData.wList[1].Romanji} \t {KanaData.wList[1].Hirg}\n" +
                    $"{KanaData.wList[2].Romanji} \t {KanaData.wList[2].Hirg}", "W Sounds Hiragana");
				*/
				MessageBox.Show(Learn(KanaData.wList, false), "W Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuModifedLearn_Click(object sender, EventArgs e)
        {
			//!important 36 (Subscripts 0 - 35) Elements in this list
			//todo Create a New Form, for this "Learn" functionality
			if (radKatakana.Checked)
			{
				MessageBox.Show(Learn(KanaData.modifiedKanaList, true), "Modified Kana Sounds Katakana");
			}
			if (radHirigana.Checked)
			{
				MessageBox.Show(Learn(KanaData.modifiedKanaList, false), "Modified Kana Sounds Hiragana");
			}
        }


        /// <summary>
        ///
        /// </summary>
        private void mnuKanaVowelsStudy_Click(object sender, EventArgs e)
        {
            //remove Study(KanaData.vowels);
            if (radKatakana.Checked)
            {
                Study(KanaData.vowels, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.vowels, false);
            }

        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaKSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.kList);
            if (radKatakana.Checked)
            {
                Study(KanaData.kList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.kList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaGSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.gList);
            if (radKatakana.Checked)
            {
                Study(KanaData.gList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.gList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaSSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.sList);
            if (radKatakana.Checked)
            {
                Study(KanaData.sList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.sList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaZSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.zList);

            //I feel like this could be done with an if-else statment but
            //I feel like this way is a bit more readable.
            if (radKatakana.Checked)
            {
                Study(KanaData.zList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.zList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaTSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.tList);
            if (radKatakana.Checked)
            {
                Study(KanaData.tList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.tList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaDSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.dList);
            if (radKatakana.Checked)
            {
                Study(KanaData.dList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.dList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaNSoundsStudy_Click(object sender, EventArgs e) {
             //remove List<BasicKana> studyList = KanaData.nList;
            //remove Study(KanaData.nList);
            if (radKatakana.Checked)
            {
                Study(KanaData.nList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.nList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaHSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.hList);

            if (radKatakana.Checked)
            {
                Study(KanaData.hList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.hList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaBSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.bList);

            if (radKatakana.Checked)
            {
                Study(KanaData.bList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.bList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaPSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.pList);
            if (radKatakana.Checked)
            {
                Study(KanaData.pList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.pList, false);
            }

        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaMSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.mList);
            if (radKatakana.Checked)
            {
                Study(KanaData.mList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.mList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaYSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.yList);
            if (radKatakana.Checked)
            {
                Study(KanaData.yList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.yList, false);
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaRSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.rList);
            if (radKatakana.Checked)
            {
                Study(KanaData.rList, true);
            }
            if (radHirigana.Checked)
            {
                Study(KanaData.rList, false);
            }
        }


        /// <summary>
        ///
        /// </summary>
        private void mnuKanaWSoundsStudy_Click(object sender, EventArgs e) {
            if (radKatakana.Checked)
            {
                Study(KanaData.wList, true);
            }
            if(radHirigana.Checked)
            {
                Study(KanaData.wList, false);
            }
        }






        /// <summary>
        ///
        /// </summary>
		private void btnCheck_Click(object sender, EventArgs e)
		{
			if(txtRomanji.Text != String.Empty)
            {
                //todo figure out how to get the list that user is currently studying.
                //CheckRomanji(txtRomanji.Text,????)
            }


            /*todo
			 * declare a list of strings of what has been already
			 * studied.
			 * Figure out some way to seprate list of what has been
			 * guessed and what hasn't and update lblKana that way
			 * FYI Launchcode if you see this Please help!!!.
			 */

		}
	}
}
