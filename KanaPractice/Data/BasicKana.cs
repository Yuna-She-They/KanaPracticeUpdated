﻿using System;
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
        /// <summary>
        /// The romanized version of how to read japanese
        /// </summary>
        private string romanji;

        /// <summary>
        /// Gets the romanji for the selected syllable.
        /// </summary>
        public string Romanji {
            get {
                return this.romanji;
            }
        }
        /// <summary>
        /// Native Japanse Words are written in this
        /// "Alphabet"
        /// </summary>
        private string hirg;

        /// <summary>
        /// Gets Hiragana for Selected Syllable
        /// </summary>
        public string Hirg {
            get {
                return this.hirg;
            }
        }

        /// <summary>
        /// Words barrowed from other languages
        /// are written in this "alphabet"
        /// </summary>
        private string katakana;


        /// <summary>
        /// Gets Katakana for selected syllable
        /// </summary>
        public string Katakana {
            get {
                return Katakana;
            }
        }
        //Todo Possibly Re-factor making a modified Kana struct, with ya,yu,yo props
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
