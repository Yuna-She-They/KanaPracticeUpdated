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
        /// <para>A list that holds the A,I,U,E, and O Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> vowels;


        /// <summary>
        /// <para>A list that holds the Ka,Ki,Ku,Ke and Ko Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> kList;


        /// <summary>
        /// <para>A list that holds the Ga, Gi, Gu, Ge, and Go Sounds.</para>
        /// </summary>
        /// <remarks>Subscript 0 - 4</remarks>
        public static List<BasicKana> gList;


        /// <summary>
        /// <para>A list that holds the Sa, Shi, Su, Se and So Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> sList;


        /// <summary>
        /// <para>A list that holds the Za,Ji,Zu,Ze, and Zo sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> zList;


        /// <summary>
        /// <para>A list that holds the Ta,Chi,Tsu,Te and To sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> tList;


        /// <summary>
        /// <para>A list that holds the Da, Di, Du, De, and Do sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> dList;


        /// <summary>
        /// <para>A list that holds the Na, Ni, Nu, Ne and No sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> nList;


        /// <summary>
        /// <para>A list that holds the Ha, Hi, Fu, He, and Ho Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> hList;

        /// <summary>
        /// <para>A list that holds the Ba, Bi, Bu, Be, and Bo Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> bList;


        /// <summary>
        /// <para>A list that holds the Pa, Pi, Pu, Pe, and Po Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> pList;

        /// <summary>
        /// <para>A list that holds the Ma, Mi, Mu, Me and Mo sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> mList;

        /// <summary>
        /// <para>A list that holds the Ya, Yu and Yo sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 2</remarks>
        public static List<BasicKana> yList;

        /// <summary>
        /// <para>A list that holds the Ra, Ri, Ru, Re and Ro Sounds.</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 4</remarks>
        public static List<BasicKana> rList;

        /// <summary>
        /// <para>A list that holds the Wa, Wo, and N Sounds</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 2</remarks>
        public static List<BasicKana> wList;


        /// <summary>
        /// <para>A list that holds modified sounds such as Kya, Kyu and Kyo</para>
        /// </summary>
        /// <remarks>Subscripts 0 - 35</remarks>
        public static List<BasicKana> modifiedKanaList;


        /// <summary>
        /// <para>A list that holds all of the sounds that will be used once the user knows all of them for a more advanced Game.</para>
        /// </summary>
        /// <remarks></remarks>
        public static List<List<BasicKana>> allKana;


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

            //3
            yList = new List<BasicKana>{
                new BasicKana("ya","や","ヤ"),
                new BasicKana("yu","ゆ","ユ"),
                new BasicKana("yo","よ","ヨ")
            };

            rList = new List<BasicKana>{
                new BasicKana("ra","ら","ラ"),
                new BasicKana("ri","り","リ"),
                new BasicKana("ru","る","ル"),
                new BasicKana("re","れ","レ"),
                new BasicKana("ro","ろ","ロ")
            };

            //3
            wList = new List<BasicKana> {
                new BasicKana("wa","わ","ワ"),
                new BasicKana("wo","を","ヲ"),
                new BasicKana("n","ん","ン")
            };

            modifiedKanaList = new List<BasicKana> {
                new BasicKana("kya","きゃ","キャ"), //0
                new BasicKana("kyu","きゅ","キュ"), //1
                new BasicKana("kyo","きょ","キョ"), //2

                new BasicKana("gya","ぎゃ","ギャ"), //3
                new BasicKana("gyu","ぎゅ","ギュ"), //4
                new BasicKana("gyo","ぎょ","ギョ"), //5

                new BasicKana("sha","しゃ","シャ"), //6
                new BasicKana("shu","しゅ","シュ"), //7
                new BasicKana("sho","しょ","ショ"), //8

                new BasicKana("ja","じゃ","ジャ"), //9
                new BasicKana("ju","じゅ","ジュ"), //10
                new BasicKana("jo","じょ","ジョ"), //11

                new BasicKana("cha","ちゃ","チャ"), //12
                new BasicKana("chu","ちゅ","チュ"), //13
                new BasicKana("cho","ちょ","チョ"), //14

                new BasicKana("dya","ぢゃ","ヂャ"), //15
                new BasicKana("dyu","ぢゅ","ヂュ"), //16
                new BasicKana("dyo","ぢょ","ヂョ"), //17

                new BasicKana("hya","ひゃ","ヒャ"), //18
                new BasicKana("hyu","ひゅ","ヒュ"), //19
                new BasicKana("hyo","ひょ","ヒョ"), //20

                new BasicKana("bya","びゃ","ビャ"), //21
                new BasicKana("byu","びゅ","ビュ"), //22
                new BasicKana("byo","びょ","ビョ"), //23

                new BasicKana("pya","ぴゃ","ピャ"), //24
                new BasicKana("pyu","ぴゅ","ピュ"), //25
                new BasicKana("pyo","ぴょ","ピョ"), //26

                new BasicKana("nya","にゃ","ニャ"), //27
                new BasicKana("nyu","にゅ","ニュ"), //28
                new BasicKana("nyo","にょ","ニョ"), //29

                new BasicKana("mya","みゃ","ミャ"), //30
                new BasicKana("myu","みゅ","ミュ"), //31
                new BasicKana("myo","みょ","ミョ"), //32

                new BasicKana("rya","りゃ","リャ"), //33
                new BasicKana("ryu","りゅ","リュ"), //34
                new BasicKana("ryo","りょ","リョ") //35
            };

            allKana = new List<List<BasicKana>> {
                vowels,
                kList,
                gList,
                sList,
                zList,
                tList,
                dList,
                hList,
                bList,
                pList,
                mList,
                yList,
                rList,
                wList
            };
        }

    }
}
