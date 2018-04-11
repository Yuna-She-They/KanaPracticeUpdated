using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KanaPractice.Data {


    /// <summary>
    /// A Class to hold All the Data for japanese Sylliables
    /// </summary>
    public static class KanaData {

        static List<BasicKana> vowels;

        static List<BasicKana> kList;
        static List<BasicKana> gList;

        static List<BasicKana> sList;
        static List<BasicKana> zList;

        static List<BasicKana> tList;
        static List<BasicKana> dList;

        static List<BasicKana> nList;

        static List<BasicKana> hList;
        static List<BasicKana> bList;
        static List<BasicKana> pList;

        static List<BasicKana> mList;

        static List<BasicKana> yList;

        static List<BasicKana> rList;

        static List<BasicKana> wList;

        static List<BasicKana> modifiedKanaList;

        static List<BasicKana> allKana;

        static KanaData() {
            //create list for each group
            // of kana
            vowels = new List<BasicKana> {
                A,
                E,
                I,
                O,
                U
            };

            kList = new List<BasicKana> {
                Ka,
                Ke,
                Ki,
                Ko,
                Ku
            };

            gList = new List<BasicKana> {
                Ga,
                Ge,
                Gi,
                Go,
                Gu
            };

            sList = new List<BasicKana> {
                Sa,
                Se,
                Shi,
                So,
                Su
            };

            zList = new List<BasicKana> {
                Za,
                Ze,
                Ji,
                Zo,
                Zu
            };

            tList = new List<BasicKana> {
                Ta,
                Te,
                Chi,
                To,
                Tsu
            };

            dList = new List<BasicKana> {
                Da,
                De,
                Di,
                Do,
                Du
            };

            nList = new List<BasicKana> {
                Na,
                Ne,
                Ni,
                No,
                Nu
            };

            hList = new List<BasicKana> {
                Ha,
                He,
                Hi,
                Ho,
                Fu
            };

            bList = new List<BasicKana> {
                Ba,
                Be,
                Bi,
                Bo,
                Bu
            };

            pList = new List<BasicKana> {
                Pa,
                Pe,
                Pi,
                Po,
                Pu
            };

            mList = new List<BasicKana> {
                Ma,
                Me,
                Mi,
                Mo,
                Mu
            };

            yList = new List<BasicKana> {
                Ya,
                Yu,
                Yo
            };

            rList = new List<BasicKana> {
                Ra,
                Re,
                Ri,
                Ro,
                Ru
            };

            wList = new List<BasicKana> {
                Wa,
                Wo,
                N
            };


        }

        //! TIL you can have constructors in a static class
        /*x  todo
         * Figure out how to serilize class into an xml document
         * so I can use Xpath to Randomize What Kana Shows up
         * Depending on What the user chooses on the main form.
         */


        #region vowels
        /// <summary>
        /// The "A" Sound
        /// </summary>
        public static BasicKana A = new BasicKana("a", "あ", "ア");

        /// <summary>
        /// The "I" sound
        /// </summary>
        public static BasicKana I = new BasicKana("i", "い", "イ");

        /// <summary>
        /// The "U"
        /// </summary>
        public static BasicKana U = new BasicKana("u", "う", "ウ");

        /// <summary>
        /// The "E" sound
        /// </summary>
        public static BasicKana E = new BasicKana("e", "え", "エ");

        /// <summary>
        /// The "O" Sound
        /// </summary>
        public static BasicKana O = new BasicKana("o", "お", "オ");
        #endregion

        #region K

        /// <summary>
        /// The "Ka" sound
        /// </summary>
        public static BasicKana Ka = new BasicKana("ka", "か", "カ");

        /// <summary>
        /// The "Ki" sound
        /// </summary>
        public static BasicKana Ki = new BasicKana("ki", "き", "キ");

        /// <summary>
        /// The "Ku" sound
        /// </summary>
        public static BasicKana Ku = new BasicKana("ku", "く", "ク");

        /// <summary>
        /// The "Ke" Sound
        /// </summary>
        public static BasicKana Ke = new BasicKana("ke", "け", "ケ");

        /// <summary>
        /// The "Ko" sound
        /// </summary>
        public static BasicKana Ko = new BasicKana("ko", "こ", "コ");
        #endregion

        #region G

        /// <summary>
        /// The "Ga" Sound
        /// </summary>
        public static BasicKana Ga = new BasicKana("ga", "が", "ガ");

        /// <summary>
        /// The "Gi" sound
        /// </summary>
        public static BasicKana Gi = new BasicKana("gi", "ぎ", "ギ");

        /// <summary>
        /// The "Gu" Sound
        /// </summary>
        public static BasicKana Gu = new BasicKana("gu", "ぐ", "グ");

        /// <summary>
        /// The "Ge" Sound
        /// </summary>
        public static BasicKana Ge = new BasicKana("ge", "げ", "ゲ");

        /// <summary>
        /// The "Go" Sound
        /// </summary>
        public static BasicKana Go = new BasicKana("go", "ご", "ゴ");
        #endregion

        #region S

        /// <summary>
        /// The "Sa" Sound
        /// </summary>
        public static BasicKana Sa = new BasicKana("sa", "さ", "サ");

        /// <summary>
        /// The "Shi" Sound
        /// </summary>
        public static BasicKana Shi = new BasicKana("shi", "し", "シ");

        /// <summary>
        /// The "Su" Sound
        /// </summary>
        public static BasicKana Su = new BasicKana("su", "す", "ス");

        /// <summary>
        /// The "Se" Sound
        /// </summary>
        public static BasicKana Se = new BasicKana("se", "せ", "セ");

        /// <summary>
        /// The "So" sound
        /// </summary>
        public static BasicKana So = new BasicKana("so", "そ", "ゾ");
        #endregion

        #region Z

        /// <summary>
        /// The "Za" Sound
        /// </summary>
        public static BasicKana Za = new BasicKana("za", "ざ", "ザ");

        /// <summary>
        /// The "Ji" Sound
        /// </summary>
        public static BasicKana Ji = new BasicKana("ji", "じ", "ジ");

        /// <summary>
        /// The "Zu" sound
        /// </summary>
        public static BasicKana Zu = new BasicKana("zu", "ず", "ズ");

        /// <summary>
        /// The "Ze" Sound
        /// </summary>
        public static BasicKana Ze = new BasicKana("ze", "ぜ", "ゼ");

        /// <summary>
        /// The "Zo" Sound
        /// </summary>
        public static BasicKana Zo = new BasicKana("zo", "ぞ", "ゾ");
        #endregion

        #region T

        /// <summary>
        /// Ta Sound
        /// </summary>
        public static BasicKana Ta = new BasicKana("ta", "た", "タ");

        /// <summary>
        /// Chi Sound
        /// </summary>
        public static BasicKana Chi = new BasicKana("chi", "ち", "チ");

        /// <summary>
        /// Tsu Sound
        /// </summary>
        public static BasicKana Tsu = new BasicKana("tsu", "つ", "ツ");

        /// <summary>
        /// Te sound
        /// </summary>
        public static BasicKana Te = new BasicKana("te", "て", "テ");

        /// <summary>
        /// To sound
        /// </summary>
        public static BasicKana To = new BasicKana("to", "と", "ト");
        #endregion

        #region D

        /// <summary>
        /// Da Sound
        /// </summary>
        public static BasicKana Da = new BasicKana("da", "だ", "ダ");

        /// <summary>
        /// The "Di" sound <br />
        /// This isn't used in modern Japanese, but is still there for historic refrence
        /// </summary>
        public static BasicKana Di = new BasicKana("di", "ぢ", "ヂ");

        /// <summary>
        /// Du sound
        /// </summary>
        public static BasicKana Du = new BasicKana("du", "づ", "ヅ");

        /// <summary>
        /// De sound
        /// </summary>
        public static BasicKana De = new BasicKana("de", "で", "デ");

        /// <summary>
        /// Do sound
        /// </summary>
        public static BasicKana Do = new BasicKana("do", "ど", "ド");
        #endregion

        #region N

        /// <summary>
        /// Na sound
        /// </summary>
        public static BasicKana Na = new BasicKana("na", "な", "ナ");

        /// <summary>
        /// the Ni sound (We are the Knights who say "Ni")
        /// </summary>
        public static BasicKana Ni = new BasicKana("ni", "に", "ニ");

        /// <summary>
        /// The nu sound (sounds like new)
        /// </summary>
        public static BasicKana Nu = new BasicKana("nu", "ぬ", "ヌ");

        /// <summary>
        /// the Ne sound (knee)
        /// </summary>
        public static BasicKana Ne = new BasicKana("ne", "ね", "ネ");

        /// <summary>
        /// The no sound
        /// </summary>
        public static BasicKana No = new BasicKana("no", "の", "ノ");
        #endregion

        #region H

        /// <summary>
        /// ha sound
        /// </summary>
        public static BasicKana Ha = new BasicKana("ha", "は", "ハ");

        /// <summary>
        /// hi sound
        /// </summary>
        public static BasicKana Hi = new BasicKana("hi", "ひ", "ヒ");

        /// <summary>
        /// Watch out for this one, the Hu sound becomes fu
        /// </summary>
        public static BasicKana Fu = new BasicKana("fu", "ふ", "フ");

        /// <summary>
        /// He sound
        /// </summary>
        public static BasicKana He = new BasicKana("he", "へ", "ヘ");

        /// <summary>
        /// Ho sound
        /// </summary>
        public static BasicKana Ho = new BasicKana("ho", "ほ", "ホ");
        #endregion

        #region B

        /// <summary>
        /// Ba sound
        /// </summary>
        public static BasicKana Ba = new BasicKana("ba", "ば", "バ");

        /// <summary>
        /// Bi sound (be)
        /// </summary>
        public static BasicKana Bi = new BasicKana("bi", "び", "ビ");

        /// <summary>
        /// Bu sound
        /// </summary>
        public static BasicKana Bu = new BasicKana("bu", "ぶ", "ブ");

        /// <summary>
        /// Be sound
        /// </summary>
        public static BasicKana Be = new BasicKana("be", "べ", "ベ");

        /// <summary>
        /// Bo (bow) sound
        /// </summary>
        public static BasicKana Bo = new BasicKana("bo", "ぼ", "ボ");
        #endregion

        #region P

        /// <summary>
        /// Pa sound
        /// </summary>
        public static BasicKana Pa = new BasicKana("pa", "ぱ", "パ");

        /// <summary>
        /// Pi sound
        /// </summary>
        public static BasicKana Pi = new BasicKana("pi", "ぴ", "ピ");

        /// <summary>
        /// Pu sound
        /// </summary>
        public static BasicKana Pu = new BasicKana("pu", "ぷ", "プ");

        /// <summary>
        /// pe sound
        /// </summary>
        public static BasicKana Pe = new BasicKana("pe", "ぺ", "ペ");

        /// <summary>
        /// Po sound
        /// </summary>
        public static BasicKana Po = new BasicKana("po", "ぽ", "ポ");
        #endregion

        #region M

        /// <summary>
        /// Ma sound
        /// </summary>
        public static BasicKana Ma = new BasicKana("ma", "ま", "マ");

        /// <summary>
        /// me sound
        /// </summary>
        public static BasicKana Mi = new BasicKana("mi", "み", "ミ");

        /// <summary>
        /// mu sound
        /// </summary>
        public static BasicKana Mu = new BasicKana("mu", "む", "ム");

        /// <summary>
        ///  me sound
        /// </summary>
        public static BasicKana Me = new BasicKana("me", "め", "メ");

        /// <summary>
        /// Mo sound
        /// </summary>
        public static BasicKana Mo = new BasicKana("mo", "も", "モ");

        #endregion

        #region YaYuYo

        /// <summary>
        /// Ya sound
        /// </summary>
        public static BasicKana Ya = new BasicKana("ya", "や", "ヤ");

        /// <summary>
        /// Yu sound
        /// </summary>
        public static BasicKana Yu = new BasicKana("yu", "ゆ", "ユ");

        /// <summary>
        /// Yo sound
        /// </summary>
        public static BasicKana Yo = new BasicKana("yo", "よ", "ヨ");
        #endregion

        #region R

        /// <summary>
        /// Ra sound
        /// </summary>
        public static BasicKana Ra = new BasicKana("ra", "ら", "ラ");

        /// <summary>
        /// ri sound
        /// </summary>
        public static BasicKana Ri = new BasicKana("ri", "り", "リ");

        /// <summary>
        /// Ru sound
        /// </summary>
        public static BasicKana Ru = new BasicKana("ru", "る", "ル");

        /// <summary>
        /// Re sound
        /// </summary>
        public static BasicKana Re = new BasicKana("re", "れ", "レ");

        /// <summary>
        /// Ro sound
        /// </summary>
        public static BasicKana Ro = new BasicKana("ro", "ろ", "ロ");
        #endregion

        #region W

        /// <summary>
        /// Wa sound
        /// </summary>
        public static BasicKana Wa = new BasicKana("wa", "わ", "ワ");

        /// <summary>
        /// Wo (particle only not really a sound)
        /// </summary>
        public static BasicKana Wo = new BasicKana("wo", "を", "ヲ");

        /// <summary>
        /// "n" sound
        /// </summary>
        public static BasicKana N = new BasicKana("n", "ん", "ン");
        #endregion


/*
 * K = 0 .. 2
 * G = 3 .. 5
 * S = 6 .. 8
 * Z = 9..11
 */

        #region ModifiedKana
        /// <summary>
        /// Kya sound
        /// </summary>
        public static BasicKana Kya = new BasicKana("kya", "きゃ", "キャ");

        /// <summary>
        /// Kyu sound
        /// </summary>
        public static BasicKana Kyu = new BasicKana("kyu", "きゅ", "キュ");

        /// <summary>
        /// Kyo sound
        /// </summary>
        public static BasicKana Kyo = new BasicKana("kyo", "きょ", "キョ");


        /// <summary>
        /// Gya Sound
        /// </summary>
        public static BasicKana Gya = new BasicKana("gya", "ぎゃ", "ギャ");

        /// <summary>
        /// Gyu sound
        /// </summary>
        public static BasicKana Gyu = new BasicKana("gyu", "ぎゅ", "ギュ");

        /// <summary>
        /// Gyo sound
        /// </summary>
        public static BasicKana Gyo = new BasicKana("gyo", "ぎょ", "ギョ");
        //s,z

        /// <summary>
        /// Sha sound
        /// </summary>
        public static BasicKana Sha = new BasicKana("sya", "しゃ", "シャ");

        /// <summary>
        /// Shu sound
        /// </summary>
        public static BasicKana Shu = new BasicKana("syu", "しゅ", "シュ");

        /// <summary>
        /// Sho sound
        /// </summary>
        public static BasicKana Sho = new BasicKana("syo", "しょ", "ショ");

        /// <summary>
        /// ja sound
        /// </summary>
        public static BasicKana Ja = new BasicKana("ja", "じゃ", "ジャ");

        /// <summary>
        /// Ju sound
        /// </summary>
        public static BasicKana Ju = new BasicKana("ju", "じゅ", "ジュ");

        /// <summary>
        /// Jo sound
        /// </summary>
        public static BasicKana Jo = new BasicKana("jo", "じょ", "ジョ");


        /// <summary>
        /// cha sound
        /// </summary>
        public static BasicKana Cha = new BasicKana("cha", "ちゃ", "チャ");

        /// <summary>
        /// chu
        /// </summary>
        public static BasicKana Chu = new BasicKana("chu", "ちゅ", "チュ");

        /// <summary>
        /// cho
        /// </summary>
        public static BasicKana Cho = new BasicKana("cho", "ちょ", "チョ");


        /// <summary>
        /// Sound not used kept for historic reasons
        /// </summary>
        public static BasicKana Dya = new BasicKana("dya", "ぢゃ", "ヂャ");

        /// <summary>
        /// Sound not used kept for historic reasons
        /// </summary>
        public static BasicKana Dyu = new BasicKana("dyu", "ぢゅ", "ヂュ");

        /// <summary>
        /// sound not used kept for historic reasons
        /// </summary>
        public static BasicKana Dyo = new BasicKana("dyo", "ぢょ", "ヂョ");


        /// <summary>
        /// hya sound
        /// </summary>
        public static BasicKana Hya = new BasicKana("hya", "ひゃ", "ヒャ");

        /// <summary>
        /// hyu sound
        /// </summary>
        public static BasicKana Hyu = new BasicKana("hyu", "ひゅ", "ヒュ");

        /// <summary>
        /// hyo sound
        /// </summary>
        public static BasicKana Hyo = new BasicKana("hyo", "ひょ", "ヒョ");


        /// <summary>
        /// Bya sound
        /// </summary>
        public static BasicKana Bya = new BasicKana("bya", "びゃ", "ビャ");

        /// <summary>
        /// byu sound
        /// </summary>
        public static BasicKana Byu = new BasicKana("byu", "びゅ", "ビュ");

        /// <summary>
        /// byo sound
        /// </summary>
        public static BasicKana Byo = new BasicKana("byo", "びょ", "ビョ");

        /// <summary>
        /// Pya sound
        /// </summary>
        public static BasicKana Pya = new BasicKana("pya", "ぴゃ", "ピャ");

        /// <summary>
        /// Pyu sound
        /// </summary>
        public static BasicKana Pyu = new BasicKana("pyu", "ぴゅ", "ピュ");

        /// <summary>
        /// Pyo sound
        /// </summary>
        public static BasicKana Pyo = new BasicKana("pyo", "ぴょ", "ピョ");

        /// <summary>
        /// Nya sound
        /// </summary>
        public static BasicKana Nya = new BasicKana("nya", "にゃ", "ニャ");

        /// <summary>
        /// Nyu sound
        /// </summary>
        public static BasicKana Nyu = new BasicKana("nyu", "にゅ", "ニュ");

        /// <summary>
        /// Nyo
        /// </summary>
        public static BasicKana Nyo = new BasicKana("nyo", "にょ", "ニョ");

        /// <summary>
        /// mya sound
        /// </summary>
        public static BasicKana Mya = new BasicKana("mya", "みゃ", "ミャ");

        /// <summary>
        /// myu sound
        /// </summary>
        public static BasicKana Myu = new BasicKana("myu", "みゅ", "ミュ");

        /// <summary>
        /// Myo sound
        /// </summary>
        public static BasicKana Myo = new BasicKana("myo", "みょ", "ミョ");


        /// <summary>
        /// rya sound
        /// </summary>
        public static BasicKana Rya = new BasicKana("rya", "りゃ", "リャ");

        /// <summary>
        /// ryu sound
        /// </summary>
        public static BasicKana Ryu = new BasicKana("ryu", "りゅ", "リュ");

        /// <summary>
        /// Ryo sound
        /// </summary>
        public static BasicKana Ryo = new BasicKana("ryo", "りょ", "リョ");
        #endregion


    }
}
