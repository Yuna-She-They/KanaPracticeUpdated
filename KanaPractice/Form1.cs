
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
            List<BasicKana> learnList = KanaData.vowels;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "Vowels in Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "Vowels in Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese K Sounds.
        /// </summary>
        private void mnuKanaKSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question Should I re-factor this into another form?
            lblSelectedSounds.Text = "K Sounds";
            List<BasicKana> learnList = KanaData.kList;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "K Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "K sounds hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese G Sounds.
        /// </summary>
        private void mnuKanaGSoundsLearn_Click(object sender, EventArgs e) {
            // ?question Should I refactor this into a new form
            lblSelectedSounds.Text = "G Sounds";
            List<BasicKana> learnList = KanaData.gList;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "G Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "G Sounds hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese S Sounds.
        /// </summary>
        private void mnuKanaSSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question should I refactor this into a new form?
            this.lblSelectedSounds.Text = "S Sounds";
            List<BasicKana> learnList = KanaData.sList;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "S sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "S Sounds Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese Z Sounds.
        /// </summary>
        private void mnuKanaZSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question Should I refactor this into a new form
            lblSelectedSounds.Text = "Z Sounds";
            List<BasicKana> learnList = KanaData.zList;

            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "Z Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "Z Sounds Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese T Sounds.
        /// </summary>
        private void mnuKanaTSoundsLearn_Click(object sender, EventArgs e)
        {
            // ?question Should I refactor this into a new form
            lblSelectedSounds.Text = "T Sounds";
            List<BasicKana> learnList = KanaData.tList;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "T Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "T Sounds Hiragana");
            }
        }

        /// <summary>
        /// Learn Japanese D Sounds
        /// </summary>
        private void mnuKanaDSoundsLearn_Click(object sender, EventArgs e)
        {
            //?question should I refactor this into a new form
            lblSelectedSounds.Text = "D Sounds";
            List<BasicKana> learnList = KanaData.dList;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "D Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
                MessageBox.Show(Learn(learnList, false), "D Sounds Hiragana");
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
            List<BasicKana>learnList = KanaData.nList;
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "N Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "N Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaHSoundsLearn_Click(object sender, EventArgs e)
        {
            List<BasicKana>learnList = KanaData.hList;
            // ?question should I refactor this into a new form?
            lblSelectedSounds.Text = "H Sounds";
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "H Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "H Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaBSoundsLearn_Click(object sender, EventArgs e) {
            List<BasicKana> learnList = KanaData.bList;

            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "B Sounds";
            //learnList = KanaData.bList;

            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "B Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "B Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaPSoundsLearn_Click(object sender, EventArgs e)
        {
            List<BasicKana> learnList = KanaData.pList;
            // ?question should I refactor this into a new form?
            lblSelectedSounds.Text = "P Sounds";
            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "P Sounds Katakana");
            }
            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "P Sounds Hiragana");
            }
        }

        /// <summary>
        /// Japanese M Sounds.
        /// </summary>
        private void mnuKanaMSoundsLearn_Click(object sender, EventArgs e)
        {
            List<BasicKana> learnList = KanaData.mList;
            //?question should I refactor this into a new form?
            lblSelectedSounds.Text = "M Sounds";

            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "M Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "M Sounds Hiragana");
            }
        }

        /// <summary>
        /// Japanese Y sounds, also used in Modifed Kana. <see cref="KanaData.modifiedKanaList"/>
        /// </summary>
        private void mnuKanaYSoundsLearn_Click(object sender, EventArgs e)
        {
            List<BasicKana> learnList = KanaData.rList;
            //!important Note that this list only has 3 elements in it
            lblSelectedSounds.Text = "Y Sounds";

            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "Y Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "Y Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaRSoundsLearn_Click(object sender, EventArgs e)
        {
            List<BasicKana> learnList = KanaData.rList;
            //!important The corrospinding List here has 5 elements (subscripts 0 -4)
            lblSelectedSounds.Text = "R Sounds";

            if (radKatakana.Checked)
            {
                MessageBox.Show(Learn(learnList, true), "R Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "R Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaWSoundsLearn_Click(object sender, EventArgs e)
        {
            //!important This corrosponding list only has 3 elements (subscripts 0 - 2)

            List<BasicKana> learnList = KanaData.wList;
            //?question Should I use another form instead of a message box for the "learn" feature
            lblSelectedSounds.Text = "W Sounds (Wa, Wo, N)";

            if (radKatakana.Checked)
            {
				MessageBox.Show(Learn(learnList, true), "W Sounds Katakana");
            }

            if (radHirigana.Checked)
            {
				MessageBox.Show(Learn(learnList, false), "W Sounds Hiragana");
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuModifedLearn_Click(object sender, EventArgs e)
        {
            List<BasicKana> learnList = KanaData.modifiedKanaList;
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
            //remove List<string> studied = new List<string>();
            //remove Study(KanaData.vowels);
            List<BasicKana> studyList = KanaData.vowels;
            selectedList = studyList;
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
            List<BasicKana> studyList = KanaData.kList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaGSoundsStudy_Click(object sender, EventArgs e) {

            List<BasicKana> studyList = KanaData.gList;
            //remove Study(KanaData.gList);
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaSSoundsStudy_Click(object sender, EventArgs e) {

            List<BasicKana> studyList = KanaData.sList;
            selectedList = studyList;

            //remove Study(KanaData.sList);
            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaZSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.zList);
            List<BasicKana> studyList = KanaData.zList;
            selectedList = studyList;

            //I feel like this could be done with an if-else statment but
            //I feel like this way is a bit more readable.
            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaTSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.tList);
            List<BasicKana> studyList = KanaData.tList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaDSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.dList);
            List<BasicKana> studyList = KanaData.dList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaNSoundsStudy_Click(object sender, EventArgs e) {
             List<BasicKana> studyList = KanaData.nList;
            selectedList = studyList;

            //remove Study(KanaData.nList);
            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaHSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.hList);
            List<BasicKana> studyList = KanaData.hList;
            selectedList = studyList;


            if (radKatakana.Checked)
            {
                studiedList.Add(Study(KanaData.hList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(KanaData.hList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaBSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.bList);
            List<BasicKana> studyList = KanaData.bList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaPSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.pList);
            List<BasicKana> studyList = KanaData.pList;
            selectedList = studyList;
            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }

        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaMSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.mList);
            List<BasicKana> studyList = KanaData.mList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                studiedList.Add(Study(studyList, true));
            }
            if (radHirigana.Checked)
            {
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaYSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.yList);
            List<BasicKana> studyList = KanaData.yList;
            selectedList = studyList;
            if (radKatakana.Checked)
            {
                resultKana = Study(studyList, true);
                studiedList.Add(resultKana);
            }
            if (radHirigana.Checked)
            {
                //resultKana =
                studiedList.Add(Study(studyList, false));
            }
        }

        /// <summary>
        ///
        /// </summary>
        private void mnuKanaRSoundsStudy_Click(object sender, EventArgs e) {
            //remove Study(KanaData.rList);
            List<BasicKana> studyList = KanaData.rList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                resultKana = Study(studyList, true);
                studiedList.Add(resultKana);
            }
            if (radHirigana.Checked)
            {
                resultKana = Study(studyList, false);
                studiedList.Add(resultKana);
            }
        }


        /// <summary>
        ///
        /// </summary>
        private void mnuKanaWSoundsStudy_Click(object sender, EventArgs e) {
            List<BasicKana> studyList = KanaData.wList;
            selectedList = studyList;

            if (radKatakana.Checked)
            {
                resultKana = Study(studyList, true);
                studiedList.Add(resultKana);
            }
            if(radHirigana.Checked)
            {
                resultKana = Study(studyList, false);
                studiedList.Add(resultKana);
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
                if(CheckRomanji(txtRomanji.Text,selectedList))
                {

                }
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
