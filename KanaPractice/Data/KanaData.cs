using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

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


        static KanaData() {
            //create list for each group
            // of kana
            vowels = new List<BasicKana> {
                KanaData.A,
                KanaData.E,
                KanaData.I,
                KanaData.O,
                KanaData.U
            };

            kList = new List<BasicKana> {
                KanaData.Ka,
                KanaData.Ke,
                KanaData.Ki,
                KanaData.Ko,
                KanaData.Ku
            };
        }

        //! TIL you can have constructors in a static class
        /*x  todo
         * Figure out how to serilize class into an xml document
         * so I can use Xpath to Randomize What Kana Shows up
         * Depending on What the user chooses on the main form.
         */


        #region vowels
        public static BasicKana A = new BasicKana("a", "あ", "ア");
        public static BasicKana I = new BasicKana("i", "い", "イ");
        public static BasicKana U = new BasicKana("u", "う", "ウ");
        public static BasicKana E = new BasicKana("e", "え", "エ");
        public static BasicKana O = new BasicKana("o", "お", "オ");
        #endregion

        #region K
        public static BasicKana Ka = new BasicKana("ka", "か", "カ");
        public static BasicKana Ki = new BasicKana("ki", "き", "キ");
        public static BasicKana Ku = new BasicKana("ku", "く", "ク");
        public static BasicKana Ke = new BasicKana("ke", "け", "ケ");
        public static BasicKana Ko = new BasicKana("ko", "こ", "コ");
        #endregion

        #region G
        public static BasicKana Ga = new BasicKana("ga", "が", "ガ");
        public static BasicKana Gi = new BasicKana("gi", "ぎ", "ギ");
        public static BasicKana Gu = new BasicKana("gu", "ぐ", "グ");
        public static BasicKana Ge = new BasicKana("ge", "げ", "ゲ");
        public static BasicKana Go = new BasicKana("go", "ご", "ゴ");
        #endregion

        #region S
        public static BasicKana Sa = new BasicKana("sa", "さ", "サ");
        public static BasicKana Shi = new BasicKana("shi", "し", "シ");
        public static BasicKana Su = new BasicKana("su", "す", "ス");
        public static BasicKana Se = new BasicKana("se", "せ", "セ");
        public static BasicKana So = new BasicKana("so", "そ", "ゾ");
        #endregion

        #region Z
        public static BasicKana Za = new BasicKana("za", "ざ", "ザ");
        public static BasicKana Ji = new BasicKana("ji", "じ", "ジ");
        public static BasicKana Zu = new BasicKana("zu", "ず", "ズ");
        public static BasicKana Ze = new BasicKana("ze", "ぜ", "ゼ");
        public static BasicKana Zo = new BasicKana("zo", "ぞ", "ゾ");
        #endregion

        #region T
        public static BasicKana Ta = new BasicKana("ta", "た", "タ");
        public static BasicKana Chi = new BasicKana("chi", "ち", "チ");
        public static BasicKana Tsu = new BasicKana("tsu", "つ", "ツ");
        public static BasicKana Te = new BasicKana("te", "て", "テ");
        public static BasicKana To = new BasicKana("to", "と", "ト");
        #endregion

        #region D
        public static BasicKana Da = new BasicKana("da", "だ", "ダ");
        public static BasicKana Di = new BasicKana("di", "ぢ", "ヂ");
        public static BasicKana Du = new BasicKana("du", "づ", "ヅ");
        public static BasicKana De = new BasicKana("de", "で", "デ");
        public static BasicKana Do = new BasicKana("do", "ど", "ド");
        #endregion

        #region N
        public static BasicKana Na = new BasicKana("na", "な", "ナ");
        public static BasicKana Ni = new BasicKana("ni", "に", "ニ");
        public static BasicKana Nu = new BasicKana("nu", "ぬ", "ヌ");
        public static BasicKana Ne = new BasicKana("ne", "ね", "ネ");
        public static BasicKana No = new BasicKana("no", "の", "ノ");
        #endregion

        #region H
        public static BasicKana Ha = new BasicKana("ha", "は", "ハ");
        public static BasicKana Hi = new BasicKana("hi", "ひ", "ヒ");
        public static BasicKana Fu = new BasicKana("fu", "ふ", "フ");
        public static BasicKana He = new BasicKana("he", "へ", "ヘ");
        public static BasicKana Ho = new BasicKana("ho", "ほ", "ホ");
        #endregion

        #region B
        public static BasicKana Ba = new BasicKana("ba", "ば", "バ");
        public static BasicKana Bi = new BasicKana("bi", "び", "ビ");
        public static BasicKana Bu = new BasicKana("bu", "ぶ", "ブ");
        public static BasicKana Be = new BasicKana("be", "べ", "ベ");
        public static BasicKana Bo = new BasicKana("bo", "ぼ", "ボ");
        #endregion

        #region P
        public static BasicKana Pa = new BasicKana("pa", "ぱ", "パ");
        public static BasicKana Pi = new BasicKana("pi", "ぴ", "ピ");
        public static BasicKana Pu = new BasicKana("pu", "ぷ", "プ");
        public static BasicKana Pe = new BasicKana("pe", "ぺ", "ペ");
        public static BasicKana Po = new BasicKana("po", "ぽ", "ポ");
        #endregion

        #region M
        public static BasicKana Ma = new BasicKana("ma", "ま", "マ");
        public static BasicKana Mi = new BasicKana("mi", "み", "ミ");
        public static BasicKana Mu = new BasicKana("mu", "む", "ム");
        public static BasicKana Me = new BasicKana("me", "め", "メ");
        public static BasicKana Mo = new BasicKana("mo", "も", "モ");
        #endregion

        #region YaYuYo
        public static BasicKana Ya = new BasicKana("ya", "や", "ヤ");
        public static BasicKana Yu = new BasicKana("yu", "ゆ", "ユ");
        public static BasicKana Yo = new BasicKana("yo", "よ", "ヨ");
        #endregion

        #region R
        public static BasicKana Ra = new BasicKana("ra", "ら", "ラ");
        public static BasicKana Ri = new BasicKana("ri", "り", "リ");
        public static BasicKana Ru = new BasicKana("ru", "る", "ル");
        public static BasicKana Re = new BasicKana("re", "れ", "レ");
        public static BasicKana Ro = new BasicKana("ro", "ろ", "ロ");
        #endregion

        #region W
        public static BasicKana Wa = new BasicKana("wa", "わ", "ワ");
        public static BasicKana Wo = new BasicKana("wo", "を", "ヲ");
        public static BasicKana N = new BasicKana("n", "ん", "ン");
        #endregion

        #region ModifiedKana
        //k,g
        public static BasicKana Kya = new BasicKana("kya", "きゃ", "キャ");
        public static BasicKana Kyu = new BasicKana("kyu", "きゅ", "キュ");
        public static BasicKana Kyo = new BasicKana("kyo", "きょ", "キョ");

        public static BasicKana Gya = new BasicKana("gya", "ぎゃ", "ギャ");
        public static BasicKana Gyu = new BasicKana("gyu", "ぎゅ", "ギュ");
        public static BasicKana Gyo = new BasicKana("gyo", "ぎょ", "ギョ");
        //s,z
        public static BasicKana Sya = new BasicKana("sya", "しゃ", "シャ");
        public static BasicKana Syu = new BasicKana("syu", "しゅ", "シュ");
        public static BasicKana Syo = new BasicKana("syo", "しょ", "ショ");

        public static BasicKana Ja = new BasicKana("ja", "じゃ", "ジャ");
        public static BasicKana Ju = new BasicKana("ju", "じゅ", "ジュ");
        public static BasicKana Jo = new BasicKana("jo", "じょ", "ジョ");

        //t,d
        public static BasicKana Tya = new BasicKana("cha", "ちゃ", "チャ");
        public static BasicKana Tyu = new BasicKana("chu", "ちゅ", "チュ");
        public static BasicKana Tyo = new BasicKana("cho", "ちょ", "チョ");

        public static BasicKana Dya = new BasicKana("dya", "ぢゃ", "ヂャ");
        public static BasicKana Dyu = new BasicKana("dyu", "ぢゅ", "ヂュ");
        public static BasicKana Dyo = new BasicKana("dyo", "ぢょ", "ヂョ");
        //h,b,p
        public static BasicKana Hya = new BasicKana("hya", "ひゃ", "ヒャ");
        public static BasicKana Hyu = new BasicKana("hyu", "ひゅ", "ヒュ");
        public static BasicKana Hyo = new BasicKana("hyo", "ひょ", "ヒョ");

        public static BasicKana Bya = new BasicKana("bya", "びゃ", "ビャ");
        public static BasicKana Byu = new BasicKana("byu", "びゅ", "ビュ");
        public static BasicKana Byo = new BasicKana("byo", "びょ", "ビョ");

        public static BasicKana Pya = new BasicKana("pya", "ぴゃ", "ピャ");
        public static BasicKana Pyu = new BasicKana("pyu", "ぴゅ", "ピュ");
        public static BasicKana Pyo = new BasicKana("pyo", "ぴょ", "ピョ");
        //n,m,r
        public static BasicKana Nya = new BasicKana("nya", "にゃ", "ニャ");
        public static BasicKana Nyu = new BasicKana("nyu", "にゅ", "ニュ");
        public static BasicKana Nyo = new BasicKana("nyo", "にょ", "ニョ");

        public static BasicKana Mya = new BasicKana("mya", "みゃ", "ミャ");
        public static BasicKana Myu = new BasicKana("myu", "みゅ", "ミュ");
        public static BasicKana Myo = new BasicKana("myo", "みょ", "ミョ");

        public static BasicKana Rya = new BasicKana("rya", "りゃ", "リャ");
        public static BasicKana Ryu = new BasicKana("ryu", "りゅ", "リュ");
        public static BasicKana Ryo = new BasicKana("ryo", "りょ", "リョ");
        #endregion


    }
}
