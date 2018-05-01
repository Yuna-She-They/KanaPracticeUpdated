﻿/*
 * Form1.Gameplay.cs
 * 2018-04-22
 * Ben Raber
 */

namespace KanaPractice
{

    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Text;
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
        public List<BasicKana> selectedList;


        /// <summary>
        /// Checks the romanji in the textbox, true if romanji = key of basic kana objcect
        /// corrosponding to Kana in lblKana
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

        /// <summary>
        ///
        /// </summary>
        /// <param name="lstToStudy"></param>
        /// <param name="blnKatakana"></param>
        /// <returns></returns>
        public string Study(List<BasicKana>lstToStudy,bool blnKatakana)
        {
            lstToStudy.Shuffle();
            Random rand = new Random();
            //string result = "";
            //List<BasicKana> resultList;
            int randNum = rand.Next(lstToStudy.Count);

            if(blnKatakana)
            {
                int myNum = randNum;
                lblKana.Text = lstToStudy[myNum].Katakana;
                return lstToStudy[myNum].Katakana;
            }else
            {
                int myNum = randNum;
                lblKana.Text = lstToStudy[myNum].Hirg;
                return lstToStudy[myNum].Hirg;
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
