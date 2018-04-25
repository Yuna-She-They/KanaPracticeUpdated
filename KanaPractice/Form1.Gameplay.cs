/*
 * Form1.Gameplay.cs
 * 2018-04-22
 * Ben Raber
 */

namespace KanaPractice
{

    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using KanaPractice.Data;
    #endregion Using Directives

    /// <summary>
    /// The Game play logic
    /// </summary>
    public partial class CfrmMain :  Form {
        //?question should this be a public or private method?
        //Keep public for now, ask for advice at another code review.

        /// <summary>
        ///
        /// </summary>
        public List<BasicKana> guessedCorrectly {
            get;
            set;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="strToCheck">The users entered text to check</param>
        /// <param name="lstOfKanaToCheck">List of kana objects to check</param>
        /// <returns></returns>
        public bool CheckRomanji(string strToCheck, List<BasicKana> lstOfKanaToCheck) {

            bool blnResult = false;
            for (int i = 0; i < lstOfKanaToCheck.Count; i++)
            {
                if (strToCheck == lstOfKanaToCheck[i].Romanji)
                {
                    blnResult = true;
                }
                else
                {
                    blnResult = false;
                }
            }
            return blnResult;
        }

        //todo Remove 1st Study Method, it won't work with what I want to do..

        /// <summary>
        /// Currently a Dummy method to only show first element of shuffled List.
        /// </summary>
        /// <param name="lstToStudy">the list to study.</param>
        public void Study(List<BasicKana> lstToStudy) {
            //todo read up on Threading for WinForms, and learn how to use async and await
            lstToStudy.Shuffle();

			/*remove if (radKatakana.Checked) {
                lblKana.Text = lstToStudy[0].Katakana;
            }
            if (radHirigana.Checked) {
                lblKana.Text = lstToStudy[0].Hirg;
            }
			*/
		}

		/// <summary>
		/// Put a random kana in lblKana, user needs to enter
        /// correct roman letters in textbox.
		/// </summary>
		/// <param name="lstToStudy">The List of kana to Study.
        /// Lists are in groups by a standard katakana or hirgana chart.
        /// </param>
		/// <param name="blnIsKatakana">true of radio button katakana is
        /// checked, False Otherwise.
        /// </param>
		public void Study(List<BasicKana>lstToStudy,bool blnIsKatakana)
		{
            lstToStudy.Shuffle();
            Random rand = new Random();
            int randNum = rand.Next(lstToStudy.Count);

            if (blnIsKatakana)
            {
                lblKana.Text = lstToStudy[randNum].Katakana;
            }
            else
            {
                lblKana.Text = lstToStudy[randNum].Hirg;
            }
        }

        /*todo
         * Problems:
         * Set Random Kana in lblKana,
         * have user enter text in txtRomanji,
         * Validate romanji in textbox,
         * put correctly guessed kana in a list called guessedCorrectly
         * if kana is in list move to next kana,
         * (optional) keep track of guesses, correct and incorrect)
         */

		/// <summary>
		/// A function to show the romanji and corresponding Kana.
		/// </summary>
		/// <param name="lstToLearn">the list to learn based on what user clicks.</param>
		/// <param name="katakana">if user wants to learn Katakana True, hiragana false.</param>
		/// <returns></returns>
		public string Learn(List<BasicKana> lstToLearn,bool katakana)
		{
			StringBuilder stringBuilder = new StringBuilder();

			for(int i = 0; i < lstToLearn.Count; i++)
			{
				if(katakana)
				{
					stringBuilder.Append($"{lstToLearn[i].Romanji} \t {lstToLearn[i].Katakana}\n");
				}
				else
				{
					stringBuilder.Append($"{lstToLearn[i].Romanji} \t {lstToLearn[i].Hirg}\n");
				}
			}
			string result = stringBuilder.ToString();

			return result;

		}

    }
}
