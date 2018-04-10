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
    [XmlRoot("KanaData")]
    public class KanaData {

        /*todo
         * Figure out how to serilize class into an xml document
         * so I can use Xpath to Randomize What Kana Shows up
         * Depending on What the user chooses on the main form.
         */


        #region vowels
        public BasicKana A = new BasicKana("a", "あ", "ア");
        public BasicKana I = new BasicKana("i", "い", "イ");
        public BasicKana U = new BasicKana("u", "う", "ウ");
        public BasicKana E = new BasicKana("e", "え", "エ");
        public BasicKana O = new BasicKana("o", "お", "オ");
        #endregion

        #region K
        public BasicKana Ka = new BasicKana("ka", "か", "カ");
        public BasicKana Ki = new BasicKana("ki", "き", "キ");
        public BasicKana Ku = new BasicKana("ku", "く", "ク");
        public BasicKana Ke = new BasicKana("ke", "け", "ケ");
        public BasicKana Ko = new BasicKana("ko", "こ", "コ");
        #endregion

        #region G
        public BasicKana Ga = new BasicKana("ga", "が", "ガ");
        public BasicKana Gi = new BasicKana("gi", "ぎ", "ギ");
        public BasicKana Gu = new BasicKana("gu", "ぐ", "グ");
        public BasicKana Ge = new BasicKana("ge", "げ", "ゲ");
        public BasicKana Go = new BasicKana("go", "ご", "ゴ");
        #endregion

        #region S
        public BasicKana Sa = new BasicKana("sa", "さ", "サ");
        public BasicKana Shi = new BasicKana("shi", "し", "シ");
        public BasicKana Su = new BasicKana("su", "す", "ス");
        public BasicKana Se = new BasicKana("se", "せ", "セ");
        public BasicKana So = new BasicKana("so", "そ", "ゾ");
        #endregion

        #region Z
        public BasicKana Za = new BasicKana("za", "ざ", "ザ");
        public BasicKana Ji = new BasicKana("ji", "じ", "ジ");
        public BasicKana Zu = new BasicKana("zu", "ず", "ズ");
        public BasicKana Ze = new BasicKana("ze", "ぜ", "ゼ");
        public BasicKana Zo = new BasicKana("zo", "ぞ", "ゾ");
        #endregion

        #region T
        public BasicKana Ta = new BasicKana("ta", "た", "タ");
        public BasicKana Chi = new BasicKana("chi", "ち", "チ");
        public BasicKana Tsu = new BasicKana("tsu", "つ", "ツ");
        public BasicKana Te = new BasicKana("te", "て", "テ");
        public BasicKana To = new BasicKana("to", "と", "ト");
        #endregion

        #region D
        public BasicKana Da = new BasicKana("da", "だ", "ダ");
        public BasicKana Di = new BasicKana("di", "ぢ", "ヂ");
        public BasicKana Du = new BasicKana("du", "づ", "ヅ");
        public BasicKana De = new BasicKana("de", "で", "デ");
        public BasicKana Do = new BasicKana("do", "ど", "ド");
        #endregion

        #region N
        public BasicKana Na = new BasicKana("na", "な", "ナ");
        public BasicKana Ni = new BasicKana("ni", "に", "ニ");
        public BasicKana Nu = new BasicKana("nu", "ぬ", "ヌ");
        public BasicKana Ne = new BasicKana("ne", "ね", "ネ");
        public BasicKana No = new BasicKana("no", "の", "ノ");
        #endregion

        #region H
        public BasicKana Ha = new BasicKana("ha", "は", "ハ");
        public BasicKana Hi = new BasicKana("hi", "ひ", "ヒ");
        public BasicKana Fu = new BasicKana("fu", "ふ", "フ");
        public BasicKana He = new BasicKana("he", "へ", "ヘ");
        public BasicKana Ho = new BasicKana("ho", "ほ", "ホ");
        #endregion

        #region B
        public BasicKana Ba = new BasicKana("ba", "ば", "バ");
        public BasicKana Bi = new BasicKana("bi", "び", "ビ");
        public BasicKana Bu = new BasicKana("bu", "ぶ", "ブ");
        public BasicKana Be = new BasicKana("be", "べ", "ベ");
        public BasicKana Bo = new BasicKana("bo", "ぼ", "ボ");
        #endregion

        #region P
        public BasicKana Pa = new BasicKana("pa", "ぱ", "パ");
        public BasicKana Pi = new BasicKana("pi", "ぴ", "ピ");
        public BasicKana Pu = new BasicKana("pu", "ぷ", "プ");
        public BasicKana Pe = new BasicKana("pe", "ぺ", "ペ");
        public BasicKana Po = new BasicKana("po", "ぽ", "ポ");
        #endregion

        #region M
        public BasicKana Ma = new BasicKana("ma", "ま", "マ");
        public BasicKana Mi = new BasicKana("mi", "み", "ミ");
        public BasicKana Mu = new BasicKana("mu", "む", "ム");
        public BasicKana Me = new BasicKana("me", "め", "メ");
        public BasicKana Mo = new BasicKana("mo", "も", "モ");
        #endregion

        #region YaYuYo
        public BasicKana Ya = new BasicKana("ya", "や", "ヤ");
        public BasicKana Yu = new BasicKana("yu", "ゆ", "ユ");
        public BasicKana Yo = new BasicKana("yo", "よ", "ヨ");
        #endregion

        #region R
        public BasicKana Ra = new BasicKana("ra", "ら", "ラ");
        public BasicKana Ri = new BasicKana("ri", "り", "リ");
        public BasicKana Ru = new BasicKana("ru", "る", "ル");
        public BasicKana Re = new BasicKana("re", "れ", "レ");
        public BasicKana Ro = new BasicKana("ro", "ろ", "ロ");
        #endregion

        #region W
        public BasicKana Wa = new BasicKana("wa", "わ", "ワ");
        public BasicKana Wo = new BasicKana("wo", "を", "ヲ");
        public BasicKana N = new BasicKana("n", "ん", "ン");
        #endregion

        #region ModifiedKana
        //k,g
        public BasicKana Kya = new BasicKana("kya", "きゃ", "キャ");
        public BasicKana Kyu = new BasicKana("kyu", "きゅ", "キュ");
        public BasicKana Kyo = new BasicKana("kyo", "きょ", "キョ");

        public BasicKana Gya = new BasicKana("gya", "ぎゃ", "ギャ");
        public BasicKana Gyu = new BasicKana("gyu", "ぎゅ", "ギュ");
        public BasicKana Gyo = new BasicKana("gyo", "ぎょ", "ギョ");
        //s,z
        public BasicKana Sya = new BasicKana("sya", "しゃ", "シャ");
        public BasicKana Syu = new BasicKana("syu", "しゅ", "シュ");
        public BasicKana Syo = new BasicKana("syo", "しょ", "ショ");

        public BasicKana Ja = new BasicKana("ja", "じゃ", "ジャ");
        public BasicKana Ju = new BasicKana("ju", "じゅ", "ジュ");
        public BasicKana Jo = new BasicKana("jo", "じょ", "ジョ");

        //t,d
        public BasicKana Tya = new BasicKana("cha", "ちゃ", "チャ");
        public BasicKana Tyu = new BasicKana("chu", "ちゅ", "チュ");
        public BasicKana Tyo = new BasicKana("cho", "ちょ", "チョ");

        public BasicKana Dya = new BasicKana("dya", "ぢゃ", "ヂャ");
        public BasicKana Dyu = new BasicKana("dyu", "ぢゅ", "ヂュ");
        public BasicKana Dyo = new BasicKana("dyo", "ぢょ", "ヂョ");
        //h,b,p
        public BasicKana Hya = new BasicKana("hya", "ひゃ", "ヒャ");
        public BasicKana Hyu = new BasicKana("hyu", "ひゅ", "ヒュ");
        public BasicKana Hyo = new BasicKana("hyo", "ひょ", "ヒョ");

        public BasicKana Bya = new BasicKana("bya", "びゃ", "ビャ");
        public BasicKana Byu = new BasicKana("byu", "びゅ", "ビュ");
        public BasicKana Byo = new BasicKana("byo", "びょ", "ビョ");

        public BasicKana Pya = new BasicKana("pya", "ぴゃ", "ピャ");
        public BasicKana Pyu = new BasicKana("pyu", "ぴゅ", "ピュ");
        public BasicKana Pyo = new BasicKana("pyo", "ぴょ", "ピョ");
        //n,m,r
        public BasicKana Nya = new BasicKana("nya", "にゃ", "ニャ");
        public BasicKana Nyu = new BasicKana("nyu", "にゅ", "ニュ");
        public BasicKana Nyo = new BasicKana("nyo", "にょ", "ニョ");

        public BasicKana Mya = new BasicKana("mya", "みゃ", "ミャ");
        public BasicKana Myu = new BasicKana("myu", "みゅ", "ミュ");
        public BasicKana Myo = new BasicKana("myo", "みょ", "ミョ");

        public BasicKana Rya = new BasicKana("rya", "りゃ", "リャ");
        public BasicKana Ryu = new BasicKana("ryu", "りゅ", "リュ");
        public BasicKana Ryo = new BasicKana("ryo", "りょ", "リョ");
        #endregion


    }
}
