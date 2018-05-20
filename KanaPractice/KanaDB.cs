using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KanaPractice
{
    /// <summary>
    ///
    /// </summary>
    public static class KanaDB
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="kanaID"></param>
        /// <returns></returns>
        public static Data.BasicKana GetKana(int kanaID)
        {
            Data.BasicKana kana = new Data.BasicKana();
            SqlConnection connection = null;
            string selectStatement = "SELECT Romanji, Hiragana, Katakana FROM Kana WHERE ID=@KanaID";
            SqlCommand selectCommand = new SqlCommand(selectStatement,connection);
            selectCommand.Parameters.AddWithValue("@KanaID", kanaID);
            return null;
        }
    }
}
