

namespace KanaPractice.Data {

    #region Using Directives
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion Using Directives




    /// <summary>
    /// A Class to hold All the Data for japanese Sylliables
    /// </summary>
    public static class KanaData
    {

        /// <summary>
        /// <para>A list that holds the A,I,U,E, and O Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> vowels = new List<BasicKana>
        {
            new BasicKana("a", "あ", "ア"),
            new BasicKana("i", "い", "イ"),
            new BasicKana("u", "う", "ウ"),
            new BasicKana("e", "え", "エ"),
            new BasicKana("o", "お", "オ")
        };

        /// <summary>
        /// <para>A list that holds the Ka,Ki,Ku,Ke and Ko Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> kList = new List<BasicKana>
        {
            new BasicKana("ka", "か", "カ"),
            new BasicKana("ki", "き", "キ"),
            new BasicKana("ku", "く", "ク"),
            new BasicKana("ke", "け", "ケ"),
            new BasicKana("ko", "こ", "コ")
        };


        /// <summary>
        /// <para>A list that holds the Ga, Gi, Gu, Ge, and Go Sounds.</para>
        /// </summary>
        /// <remarks>Subscript 0 - 4</remarks>
        public static List<BasicKana> gList = new List<BasicKana>
        {
            new BasicKana("ga", "が", "ガ"),
            new BasicKana("gi", "ぎ", "ギ"),
            new BasicKana("gu", "ぐ", "グ"),
            new BasicKana("ge", "げ", "ゲ"),
            new BasicKana("go", "ご", "ゴ")
        };

        /// <summary>
        /// <para>A list that holds the Sa, Shi, Su, Se and So Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> sList = new List<BasicKana>
        {
            new BasicKana("sa", "さ", "サ"),
            new BasicKana("shi", "し", "シ"),
            new BasicKana("su", "す", "ス"),
            new BasicKana("se", "せ", "セ"),
            new BasicKana("so", "そ", "ソ")
        };


        /// <summary>
        /// <para>A list that holds the Za,Ji,Zu,Ze, and Zo sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> zList = new List<BasicKana>
        {
            new BasicKana("za", "ざ", "ザ"),
            new BasicKana("ji", "じ", "ジ"),
            new BasicKana("zu", "ず", "ズ"),
            new BasicKana("ze", "ぜ", "ゼ"),
            new BasicKana("zo", "ぞ", "ゾ")
        };


        /// <summary>
        /// <para>A list that holds the Ta,Chi,Tsu,Te and To sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> tList = new List<BasicKana>
        {
            new BasicKana("ta", "た", "タ"),
            new BasicKana("chi", "ち", "千"),
            new BasicKana("tsu", "つ", "ツ"),
            new BasicKana("te", "て", "テ"),
            new BasicKana("to", "と", "ト")
        };


        /// <summary>
        /// <para>A list that holds the Da, Di, Du, De, and Do sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> dList = new List<BasicKana>
        {
            new BasicKana("da", "だ", "ダ"),
            new BasicKana("di", "ぢ", "ヂ"),
            new BasicKana("du", "づ", "ヅ"),
            new BasicKana("de", "で", "デ"),
            new BasicKana("do", "ど", "ド")
        };

        /// <summary>
        /// <para>A list that holds the Na, Ni, Nu, Ne and No sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> nList = new List<BasicKana>
        {
             new BasicKana("na", "な", "ナ"),
             new BasicKana("ni", "に", "ニ"),
             new BasicKana("nu", "ぬ", "ヌ"),
             new BasicKana("ne", "ね", "ネ"),
             new BasicKana("no", "の", "ノ")
        };


        /// <summary>
        /// <para>A list that holds the Ha, Hi, Fu, He, and Ho Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> hList = new List<BasicKana>
        {
            new BasicKana("ha", "は", "ハ"),
            new BasicKana("hi", "ひ", "ヒ"),
            new BasicKana("fu", "ふ", "フ"),
            new BasicKana("he", "へ", "ヘ"),
            new BasicKana("ho", "ほ", "ホ")
        };

        /// <summary>
        /// <para>A list that holds the Ba, Bi, Bu, Be, and Bo Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> bList = new List<BasicKana>
        {
            new BasicKana("ba", "ば", "バ"),
            new BasicKana("bi", "び", "ビ"),
            new BasicKana("bu", "ぶ", "ブ"),
            new BasicKana("be", "べ", "ベ"),
            new BasicKana("bo", "ぼ", "ボ")
        };


        /// <summary>
        /// <para>A list that holds the Pa, Pi, Pu, Pe, and Po Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> pList = new List<BasicKana>
        {
            new BasicKana("pa", "ぱ", "パ"),
            new BasicKana("pi", "ぴ", "ピ"),
            new BasicKana("pu", "ぷ", "プ"),
            new BasicKana("pe", "ぺ", "ペ"),
            new BasicKana("po", "ぽ", "ポ")
        };

        /// <summary>
        /// <para>A list that holds the Ma, Mi, Mu, Me and Mo sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> mList = new List<BasicKana>
        {
            new BasicKana("ma", "ま", "マ"),
            new BasicKana("mi", "み", "ミ"),
            new BasicKana("mu", "む", "ム"),
            new BasicKana("me", "め", "メ"),
            new BasicKana("mo", "も", "モ")
        };

        /// <summary>
        /// <para>A list that holds the Ya, Yu and Yo sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 2</remarks>
        public static List<BasicKana> yList = new List<BasicKana>
        {
            new BasicKana("ya", "や", "ヤ"),
            new BasicKana("yu", "ゆ", "ユ"),
            new BasicKana("yo", "よ", "ヨ")
        };

        /// <summary>
        /// <para>A list that holds the Ra, Ri, Ru, Re and Ro Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> rList = new List<BasicKana>
        {
            new BasicKana("ra", "ら", "ラ"),
            new BasicKana("ri", "り", "リ"),
            new BasicKana("ru", "る", "ル"),
            new BasicKana("re", "れ", "レ"),
            new BasicKana("ro", "ろ", "ロ")
        };

        /// <summary>
        /// <para>A list that holds the Wa, Wo, and N Sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 2</remarks>
        public static List<BasicKana> wList = new List<BasicKana>
        {
            new BasicKana("wa", "わ", "ワ"),
            new BasicKana("wo", "を", "ヲ"),
            new BasicKana("n", "ん", "ン")
        };

        /// <summary>
        /// <para>A list that holds modified sounds such as Kya, Kyu and Kyo</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 35</remarks>
        public static List<BasicKana> modifiedKanaList = new List<BasicKana>
        {
            new BasicKana("kya", "きゃ", "キャ"),
            new BasicKana("kyu", "きゅ", "キュ"),
            new BasicKana("kyo", "きょ", "キョ"),
            new BasicKana("gya", "ぎゃ", "ギャ"),
            new BasicKana("gyu", "ぎゅ", "ギュ"),
            new BasicKana("gyo", "ぎょ", "ギョ"),
            new BasicKana("sha", "しゃ", "シャ"),
            new BasicKana("shu", "しゅ", "シュ"),
            new BasicKana("sho", "しょ", "ショ"),
            new BasicKana("ja", "じゃ", "ジャ"),
            new BasicKana("ju", "じゅ", "ジュ"),
            new BasicKana("jo", "じょ", "ジョ"),
            new BasicKana("cha", "ちゃ", "チャ"),
            new BasicKana("chu", "ちゅ", "チュ"),
            new BasicKana("cho", "ちょ", "チョ"),
            new BasicKana("dya", "ぢゃ", "ヂャ"),
            new BasicKana("dyu", "ぢゅ", "ヂュ"),
            new BasicKana("dyo", "ぢょ", "ヂョ"),
            new BasicKana("hya", "ひゃ", "ヒャ"),
            new BasicKana("hyu", "ひゅ", "ヒュ"),
            new BasicKana("hyo", "ひょ", "ヒョ"),
            new BasicKana("bya", "びゃ", "ビャ"),
            new BasicKana("byu", "びゅ", "ビュ"),
            new BasicKana("byo", "びょ", "ビョ"),
            new BasicKana("pya", "ぴゃ", "ピャ"),
            new BasicKana("pyu", "ぴゅ", "ピュ"),
            new BasicKana("pyo", "ぴょ", "ピョ"),
            new BasicKana("nya", "にゃ", "ニャ"),
            new BasicKana("nyu", "にゅ", "ニュ"),
            new BasicKana("nyo", "にょ", "ニョ"),
            new BasicKana("mya", "みゃ", "ミャ"),
            new BasicKana("myu", "みゅ", "ミュ"),
            new BasicKana("myo", "みょ", "ミョ"),
            new BasicKana("rya", "りゃ", "リャ"),
            new BasicKana("ryu", "りゅ", "リュ"),
            new BasicKana("ryo", "りょ", "リョ"),
        };

        /// <summary>
        /// <para>A list that holds all of the sounds that will be used once the user knows all of them for a more advanced Game.</para>
        /// </summary>
        /// <remarks></remarks>
        public static List<List<BasicKana>> allKana = new List<List<BasicKana>>
        {
            // ?question is this the right way to init a list of lists with lists?
            vowels,
            kList,
            gList,
            sList,
            zList,
            tList,
            dList,
            nList,
            hList,
            bList,
            pList,
            mList,
            yList,
            rList,
            wList,
            modifiedKanaList
        };

        //public static List<BasicKana> Vowels { get => Vowels1; set => Vowels1 = value; }
        //public static List<BasicKana> Vowels1 { get => vowels; set => vowels = value; }
    }
}
