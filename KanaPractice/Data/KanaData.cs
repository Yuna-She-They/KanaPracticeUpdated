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

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> vowels;



        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> kList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> gList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> sList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> zList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> tList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> dList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> nList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> hList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> bList;


        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> pList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> mList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> yList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> rList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> wList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> modifiedKanaList;

        /// <summary>
        ///
        /// </summary>
        public static List<BasicKana> allKana;

        static KanaData() {
            //create list for each group
            // of kana
            vowels = new List<BasicKana> {
                new BasicKana("a","あ","ア"),
                new BasicKana("i","い","イ"),
                new BasicKana("u","う","ウ"),
                new BasicKana("e","え","エ"),
                new BasicKana("o","お","オ")
            };

            kList = new List<BasicKana> {
                new BasicKana("ka","か","カ"),
                new BasicKana("ki","き","キ"),
                new BasicKana("ku","く","ク"),
                new BasicKana("ke","け","ケ"),
                new BasicKana("ko","こ","コ")
            };

            gList = new List<BasicKana> {
                new BasicKana("ga","が","ガ"),
                new BasicKana("gi","ぎ","ギ"),
                new BasicKana("gu","ぐ","グ"),
                new BasicKana("ge","げ","ゲ"),
                new BasicKana("go","ご","ゴ")
            };

            sList = new List<BasicKana> {
                new BasicKana("sa","さ","サ"),
                new BasicKana("shi","し","シ"),
                new BasicKana("su","す","ス"),
                new BasicKana("se","せ","セ"),
                new BasicKana("so","そ","ソ")
            };

            zList = new List<BasicKana> {
                new BasicKana("za","ざ","ザ"),
                new BasicKana("ji","じ","ジ"),
                new BasicKana("zu","ず","ズ"),
                new BasicKana("ze","ぜ","ゼ"),
                new BasicKana("zo","ぞ","ゾ")
            };

            tList = new List<BasicKana> {
                new BasicKana("ta","た","タ"),
                new BasicKana("chi","ち","千"),
                new BasicKana("tsu","つ","ツ"),
                new BasicKana("te","て","テ"),
                new BasicKana("to","と","ト")
            };

            dList = new List<BasicKana> {
                new BasicKana("da","だ","ダ"),
                new BasicKana("di","ぢ","ヂ"),
                new BasicKana("du","づ","ヅ"),
                new BasicKana("de","で","デ"),
                new BasicKana("do","ど","ド")
            };

            nList = new List<BasicKana> {
                new BasicKana("na","な","ナ"),
                new BasicKana("ni","に","ニ"),
                new BasicKana("nu","ぬ","ヌ"),
                new BasicKana("ne","ね","ネ"),
                new BasicKana("no","の","ノ")
            };

            hList = new List<BasicKana> {
                new BasicKana("ha","は","ハ"),
                new BasicKana("hi","ひ","ヒ"),
                new BasicKana("fu","ふ","フ"),
                new BasicKana("he","へ","ヘ"),
                new BasicKana("ho","ほ","ホ")
            };

            bList = new List<BasicKana> {
                new BasicKana("ba","ば","バ"),
                new BasicKana("bi","び","ビ"),
                new BasicKana("bu","ぶ","ブ"),
                new BasicKana("be","べ","ベ"),
                new BasicKana("bo","ぼ","ボ")
            };

            pList = new List<BasicKana> {
                new BasicKana("pa","ぱ","パ"),
                new BasicKana("pi","ぴ","ピ"),
                new BasicKana("pu","ぷ","ぷ"),
                new BasicKana("pe","ぺ","ペ"),
                new BasicKana("po","ぽ","ポ")
            };

            mList = new List<BasicKana> {
                new BasicKana("ma","ま","マ"),
                new BasicKana("mi","み","ミ"),
                new BasicKana("mu","む","ム"),
                new BasicKana("me","め","メ"),
                new BasicKana("mo","も","モ")
            };
            yList = new List<BasicKana> {
                new BasicKana("ya","や","ヤ"),
                new BasicKana("yu","ゆ","ユ"),
                new BasicKana("yo","よ","ヨ")
            };

            rList = new List<BasicKana> {
                new BasicKana("ra","ら","ラ"),
                new BasicKana("ri","り","リ"),
                new BasicKana("ru","る","ル"),
                new BasicKana("re","れ","レ"),
                new BasicKana("ro","ろ","ロ")
            };

            wList = new List<BasicKana> {
                new BasicKana("wa","わ","ワ"),
                new BasicKana("wo","を","ヲ"),
                new BasicKana("n","ん","ン")
            };
        }

        //!important TIL you can have constructors in a static class
        /*x  todo
         * Figure out how to serilize class into an xml document
         * so I can use Xpath to Randomize What Kana Shows up
         * Depending on What the user chooses on the main form.
         */


        //?question Would it be better to have the seprate sounds
        //?question as private variables

        //x private static BasicKana A = new BasicKana("a", "あ", "ア");

        //x private static BasicKana I = new BasicKana("i", "い", "イ");

        //x private static BasicKana U = new BasicKana("u", "う", "ウ");

        //x private static BasicKana E = new BasicKana("e", "え", "エ");

        //x private static BasicKana O = new BasicKana("o", "お", "オ");

        //x <summary>
        //x The "Ka" sound
        //x </summary>
        //x private static BasicKana Ka = new BasicKana("ka", "か", "カ");

        //x <summary>
        //x The "Ki" sound
        //x </summary>
        //x private static BasicKana Ki = new BasicKana("ki", "き", "キ");

        //x <summary>
        //x The "Ku" sound
        //x </summary>
        //x private static BasicKana Ku = new BasicKana("ku", "く", "ク");

        //x <summary>
        //x The "Ke" Sound
        //x </summary>
        //x private static BasicKana Ke = new BasicKana("ke", "け", "ケ");

        //x <summary>
        //x The "Ko" sound
        //x </summary>
        //x Remove private static BasicKana Ko = new BasicKana("ko", "こ", "コ");

        //x <summary>
        //x The "Ga" Sound
        //x </summary>
        //x public static BasicKana Ga = new BasicKana("ga", "が", "ガ");

        //x <summary>
        //x The "Gi" sound
        //x </summary>
        //x public static BasicKana Gi = new BasicKana("gi", "ぎ", "ギ");

        //x <summary>
        //x The "Gu" Sound
        //x </summary>
        //x public static BasicKana Gu = new BasicKana("gu", "ぐ", "グ");

        //x <summary>
        //x The "Ge" Sound
        //x </summary>
        //x public static BasicKana Ge = new BasicKana("ge", "げ", "ゲ");

        //x <summary>
        //x The "Go" Sound
        //x </summary>
        //x public static BasicKana Go = new BasicKana("go", "ご", "ゴ");

        //x <summary>
        //x The "Sa" Sound
        //x </summary>
        //x private static BasicKana Sa = new BasicKana("sa", "さ", "サ");

        //x <summary>
        //x The "Shi" Sound
        //x </summary>
        //x private static BasicKana Shi = new BasicKana("shi", "し", "シ");

        //x <summary>
        //x The "Su" Sound
        //x </summary>
        //x private static BasicKana Su = new BasicKana("su", "す", "ス");

        //x <summary>
        //x The "Se" Sound
        //x </summary>
        //x private static BasicKana Se = new BasicKana("se", "せ", "セ");

        //x <summary>
        //x The "So" sound
        //x </summary>
        //x private static BasicKana So = new BasicKana("so", "そ", "ゾ");

        //x <summary>
        //x The "Za" Sound
        //x </summary>
        //x private static BasicKana Za = new BasicKana("za", "ざ", "ザ");

        //x <summary>
        //x The "Ji" Sound
        //x </summary>
        //x private static BasicKana Ji = new BasicKana("ji", "じ", "ジ");

        //x <summary>
        //x The "Zu" sound
        //x </summary>
        //x private static BasicKana Zu = new BasicKana("zu", "ず", "ズ");

        //x <summary>
        //x The "Ze" Sound
        //x </summary>
        //x private static BasicKana Ze = new BasicKana("ze", "ぜ", "ゼ");

        //x <summary>
        //x The "Zo" Sound
        //x </summary>
        //x private static BasicKana Zo = new BasicKana("zo", "ぞ", "ゾ");

        //x <summary>
        //x Ta Sound
        //x </summary>
        //x private static BasicKana Ta = new BasicKana("ta", "た", "タ");

        //x <summary>
        //x Chi Sound
        //x </summary>
        //x private static BasicKana Chi = new BasicKana("chi", "ち", "チ");

        //x <summary>
        //x Tsu Sound
        //x </summary>
        //x private static BasicKana Tsu = new BasicKana("tsu", "つ", "ツ");

        //x <summary>
        //x Te sound
        //x </summary>
        //x private static BasicKana Te = new BasicKana("te", "て", "テ");

        //x <summary>
        //x To sound
        //x </summary>
        //x private static BasicKana To = new BasicKana("to", "と", "ト");

        //x <summary>
        //x Da Sound
        //x </summary>
        //x private static BasicKana Da = new BasicKana("da", "だ", "ダ");

        //x <summary>
        //x The "Di" sound <br />
        //x This isn't used in modern Japanese, but is still there for historic refrence
        //x </summary>
        //x private static BasicKana Di = new BasicKana("di", "ぢ", "ヂ");

        //x <summary>
        //x Du sound
        //x </summary>
        //x private static BasicKana Du = new BasicKana("du", "づ", "ヅ");

        //x <summary>
        //x De sound
        //x </summary>
        //x private static BasicKana De = new BasicKana("de", "で", "デ");

        //x <summary>
        //x Do sound
        //x </summary>
        //x private static BasicKana Do = new BasicKana("do", "ど", "ド");

        //x <summary>
        //x Na sound
        //x </summary>
        //x private static BasicKana Na = new BasicKana("na", "な", "ナ");

        //x <summary>
        //x the Ni sound (We are the Knights who say "Ni")
        //x </summary>
        //x private static BasicKana Ni = new BasicKana("ni", "に", "ニ");

        //x <summary>
        //x The nu sound (sounds like new)
        //x </summary>
        //x private static BasicKana Nu = new BasicKana("nu", "ぬ", "ヌ");

        //x <summary>
        //x the Ne sound (knee)
        //x </summary>
        //x private static BasicKana Ne = new BasicKana("ne", "ね", "ネ");

        //x <summary>
        //x The no sound
        //x </summary>
        //x private static BasicKana No = new BasicKana("no", "の", "ノ");

        //x <summary>
        //x ha sound
        //x </summary>
        //x private static BasicKana Ha = new BasicKana("ha", "は", "ハ");

        //x <summary>
        //x hi sound
        //x </summary>
        //x private static BasicKana Hi = new BasicKana("hi", "ひ", "ヒ");

        //x <summary>
        //x Watch out for this one, the Hu sound becomes fu
        //x </summary>
        //x private static BasicKana Fu = new BasicKana("fu", "ふ", "フ");

        //x <summary>
        //x He sound
        //x </summary>
        //x private static BasicKana He = new BasicKana("he", "へ", "ヘ");

        //x <summary>
        //x Ho sound
        //x </summary>
        //x private static BasicKana Ho = new BasicKana("ho", "ほ", "ホ");

        //x <summary>
        //x Ba sound
        //x </summary>
        //x private static BasicKana Ba = new BasicKana("ba", "ば", "バ");

        //x <summary>
        //x Bi sound (be)
        //x </summary>
        //x private static BasicKana Bi = new BasicKana("bi", "び", "ビ");

        //x <summary>
        //x Bu sound
        //x </summary>
        //x private static BasicKana Bu = new BasicKana("bu", "ぶ", "ブ");

        //x <summary>
        //x Be sound
        //x </summary>
        //x private static BasicKana Be = new BasicKana("be", "べ", "ベ");

        //x <summary>
        //x Bo (bow) sound
        //x </summary>
        //x private static BasicKana Bo = new BasicKana("bo", "ぼ", "ボ");

        //x <summary>
        //x Pa sound
        //x </summary>
        //x private static BasicKana Pa = new BasicKana("pa", "ぱ", "パ");

        //x <summary>
        //x Pi sound
        //x </summary>
        //x private static BasicKana Pi = new BasicKana("pi", "ぴ", "ピ");

        //x <summary>
        //x Pu sound
        //x </summary>
        //x private static BasicKana Pu = new BasicKana("pu", "ぷ", "プ");

        //x <summary>
        //x pe sound
        //x </summary>
        //x private static BasicKana Pe = new BasicKana("pe", "ぺ", "ペ");

        //x <summary>
        //x Po sound
        //x </summary>
        //x private static BasicKana Po = new BasicKana("po", "ぽ", "ポ");

        //x <summary>
        //x Ma sound
        //x </summary>
        //x private static BasicKana Ma = new BasicKana("ma", "ま", "マ");

        //x <summary>
        //x me sound
        //x </summary>
        //x private static BasicKana Mi = new BasicKana("mi", "み", "ミ");

        //x <summary>
        //x mu sound
        //x </summary>
        //x private static BasicKana Mu = new BasicKana("mu", "む", "ム");

        //x <summary>
        //x  me sound
        //x </summary>
        //x private static BasicKana Me = new BasicKana("me", "め", "メ");

        //x <summary>
        //x Mo sound
        //x </summary>
        //x private static BasicKana Mo = new BasicKana("mo", "も", "モ");

        //x <summary>
        //x Ya sound
        //x </summary>
        //x private static BasicKana Ya = new BasicKana("ya", "や", "ヤ");

        //x <summary>
        //x Yu sound
        //x </summary>
        //x private static BasicKana Yu = new BasicKana("yu", "ゆ", "ユ");

        //x <summary>
        //x Yo sound
        //x </summary>
        //x private static BasicKana Yo = new BasicKana("yo", "よ", "ヨ");

        //x <summary>
        //x Ra sound
        //x </summary>
        //x private static BasicKana Ra = new BasicKana("ra", "ら", "ラ");

        //x <summary>
        //x ri sound
        //x </summary>
        //x private static BasicKana Ri = new BasicKana("ri", "り", "リ");

        //x <summary>
        //x Ru sound
        //x </summary>
        //x private static BasicKana Ru = new BasicKana("ru", "る", "ル");

        //x <summary>
        //x Re sound
        //x </summary>
        //x private static BasicKana Re = new BasicKana("re", "れ", "レ");

        //x <summary>
        //x Ro sound
        //x </summary>
        //x private static BasicKana Ro = new BasicKana("ro", "ろ", "ロ");

        //x <summary>
        //x Wa sound
        //x </summary>
        //x private static BasicKana Wa = new BasicKana("wa", "わ", "ワ");

        //x <summary>
        //x Wo (particle only not really a sound)
        //x </summary>
        //x private static BasicKana Wo = new BasicKana("wo", "を", "ヲ");

        //x <summary>
        //x "n" sound
        //x </summary>
        //x private static BasicKana N = new BasicKana("n", "ん", "ン");

        #region ModifiedKana
        /// <summary>
        /// Kya sound
        /// </summary>
        private static BasicKana Kya = new BasicKana("kya", "きゃ", "キャ");

        /// <summary>
        /// Kyu sound
        /// </summary>
        private static BasicKana Kyu = new BasicKana("kyu", "きゅ", "キュ");

        /// <summary>
        /// Kyo sound
        /// </summary>
        private static BasicKana Kyo = new BasicKana("kyo", "きょ", "キョ");


        /// <summary>
        /// Gya Sound
        /// </summary>
        private static BasicKana Gya = new BasicKana("gya", "ぎゃ", "ギャ");

        /// <summary>
        /// Gyu sound
        /// </summary>
        private static BasicKana Gyu = new BasicKana("gyu", "ぎゅ", "ギュ");

        /// <summary>
        /// Gyo sound
        /// </summary>
        private static BasicKana Gyo = new BasicKana("gyo", "ぎょ", "ギョ");
        //s,z

        /// <summary>
        /// Sha sound
        /// </summary>
        private static BasicKana Sha = new BasicKana("sya", "しゃ", "シャ");

        /// <summary>
        /// Shu sound
        /// </summary>
        private static BasicKana Shu = new BasicKana("syu", "しゅ", "シュ");

        /// <summary>
        /// Sho sound
        /// </summary>
        private static BasicKana Sho = new BasicKana("syo", "しょ", "ショ");

        /// <summary>
        /// ja sound
        /// </summary>
        private static BasicKana Ja = new BasicKana("ja", "じゃ", "ジャ");

        /// <summary>
        /// Ju sound
        /// </summary>
        private static BasicKana Ju = new BasicKana("ju", "じゅ", "ジュ");

        /// <summary>
        /// Jo sound
        /// </summary>
        private static BasicKana Jo = new BasicKana("jo", "じょ", "ジョ");


        /// <summary>
        /// cha sound
        /// </summary>
        private static BasicKana Cha = new BasicKana("cha", "ちゃ", "チャ");

        /// <summary>
        /// chu
        /// </summary>
        private static BasicKana Chu = new BasicKana("chu", "ちゅ", "チュ");

        /// <summary>
        /// cho
        /// </summary>
        private static BasicKana Cho = new BasicKana("cho", "ちょ", "チョ");


        /// <summary>
        /// Sound not used kept for historic reasons
        /// </summary>
        private static BasicKana Dya = new BasicKana("dya", "ぢゃ", "ヂャ");

        /// <summary>
        /// Sound not used kept for historic reasons
        /// </summary>
        private static BasicKana Dyu = new BasicKana("dyu", "ぢゅ", "ヂュ");

        /// <summary>
        /// sound not used kept for historic reasons
        /// </summary>
        private static BasicKana Dyo = new BasicKana("dyo", "ぢょ", "ヂョ");


        /// <summary>
        /// hya sound
        /// </summary>
        private static BasicKana Hya = new BasicKana("hya", "ひゃ", "ヒャ");

        /// <summary>
        /// hyu sound
        /// </summary>
        private static BasicKana Hyu = new BasicKana("hyu", "ひゅ", "ヒュ");

        /// <summary>
        /// hyo sound
        /// </summary>
        private static BasicKana Hyo = new BasicKana("hyo", "ひょ", "ヒョ");


        /// <summary>
        /// Bya sound
        /// </summary>
        private static BasicKana Bya = new BasicKana("bya", "びゃ", "ビャ");

        /// <summary>
        /// byu sound
        /// </summary>
        private static BasicKana Byu = new BasicKana("byu", "びゅ", "ビュ");

        /// <summary>
        /// byo sound
        /// </summary>
        private static BasicKana Byo = new BasicKana("byo", "びょ", "ビョ");

        /// <summary>
        /// Pya sound
        /// </summary>
        private static BasicKana Pya = new BasicKana("pya", "ぴゃ", "ピャ");

        /// <summary>
        /// Pyu sound
        /// </summary>
        private static BasicKana Pyu = new BasicKana("pyu", "ぴゅ", "ピュ");

        /// <summary>
        /// Pyo sound
        /// </summary>
        private static BasicKana Pyo = new BasicKana("pyo", "ぴょ", "ピョ");

        /// <summary>
        /// Nya sound
        /// </summary>
        private static BasicKana Nya = new BasicKana("nya", "にゃ", "ニャ");

        /// <summary>
        /// Nyu sound
        /// </summary>
        private static BasicKana Nyu = new BasicKana("nyu", "にゅ", "ニュ");

        /// <summary>
        /// Nyo
        /// </summary>
        private static BasicKana Nyo = new BasicKana("nyo", "にょ", "ニョ");

        /// <summary>
        /// mya sound
        /// </summary>
        private static BasicKana Mya = new BasicKana("mya", "みゃ", "ミャ");

        /// <summary>
        /// myu sound
        /// </summary>
        private static BasicKana Myu = new BasicKana("myu", "みゅ", "ミュ");

        /// <summary>
        /// Myo sound
        /// </summary>
        private static BasicKana Myo = new BasicKana("myo", "みょ", "ミョ");


        /// <summary>
        /// rya sound
        /// </summary>
        private static BasicKana Rya = new BasicKana("rya", "りゃ", "リャ");

        /// <summary>
        /// ryu sound
        /// </summary>
        private static BasicKana Ryu = new BasicKana("ryu", "りゅ", "リュ");

        /// <summary>
        /// Ryo sound
        /// </summary>
        private static BasicKana Ryo = new BasicKana("ryo", "りょ", "リョ");
        #endregion


    }
}
