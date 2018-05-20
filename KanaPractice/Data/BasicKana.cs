namespace KanaPractice.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // comment Guide
    //!important IMPORTANT
    //?question QUESTION
    //remove DELETED CODE
    //todo TODO

    /// <summary>
    /// A Class that holds the symbols for each sylliable
    /// </summary>
    public class BasicKana
    {
        /// <summary>
        /// Gets the Roman letters for the selected syllable.
        /// </summary>
        public string Romanji { get; }

        /// <summary>
        /// Gets Hiragana for Selected Syllable
        /// </summary>
        public string Hirg { get; }

        /// <summary>
        /// Gets Katakana for selected syllable
        /// </summary>
        public string Katakana { get; }
        // todo Possibly Re-factor making a modified Kana struct, with ya,yu,yo props
        //?question Do I need to make properties even though this is just designed to hold data in a static class?

        /// <summary>
        /// The Constructor for the Basic Kana Class
        /// </summary>
        /// <param name="strRomanji">The romanizaed version of the Japanese Syllable</param>
        /// <param name="strHiragana">The hiragana writing system</param>
        /// <param name="strKatakana">The Katakana writing system</param>
        public BasicKana(string strRomanji, string strHiragana, string strKatakana)
        {
            this.Romanji = strRomanji;
            this.Hirg = strHiragana;
            this.Katakana = strKatakana;
        }

        /// <summary>
        ///
        /// </summary>
        public BasicKana()
        { }
    }
}
