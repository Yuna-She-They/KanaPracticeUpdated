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
        /// Currently a Dummy method to only show first element of shuffled List.
        /// </summary>
        /// <param name="lstToStudy">the list to study.</param>
        public void Study(List<BasicKana> lstToStudy) {
            //todo read up on Threading for WinForms, and learn how to use async and await
            lstToStudy.Shuffle();
            if (radKatakana.Checked) {
                lblKana.Text = lstToStudy[0].Katakana;
            }
            if (radHirigana.Checked) {
                lblKana.Text = lstToStudy[0].Hirg;
            }

        }

    }
}
