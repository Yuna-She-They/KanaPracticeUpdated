using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanaPractice.Data {

    //comment Guide
    //! IMPORTANT
    //? QUESTION
    //x DELETED CODE
    //todo TODO


    /// <summary>
    /// A Class that holds the symbols for each sylliable
    /// </summary>
    public class BasicKana {
        private string romanji;
        private string hirg;
        private string katakana;

        //? Do I need to make properties even though this is just designed to hold data in a static class?

        /// <summary>
        /// The Constructor for the Basic Kana Class
        /// </summary>
        /// <param name="romanji">The romanizaed verson of the japanese Syllable</param>
        /// <param name="hirg">The hirgana writing system</param>
        /// <param name="kata">The Katakana writing system</param>
        public BasicKana(string romanji,string hirg,string kata) {
            this.romanji = romanji;
            this.hirg = hirg;
            this.katakana = kata;
        }

        //? Do I need a dustructor
        //? When using Seralization
        //? for Cleanup?

        //x ~BasicKana() { }

    }
}
