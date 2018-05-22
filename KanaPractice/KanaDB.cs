using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KanaPractice
{
    public static class KanaDB
    {
        public static bool GetKana(int kanaID,bool katakana)
        {
            string sql = string.Empty;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True");
            SqlCommand cmd;
            bool blnReturn;

            try
            {
                if (katakana)
                {
                    sql = "SELECT Romanji, Katakana FROM Kana WHERE ID=@kanaID";
                }
                else
                {
                    sql = "SELECT Romanji, Hiragana FROM Kana WHERE ID=@kanaID";
                }
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("kanaID", (int)kanaID);
                cmd.ExecuteNonQuery();
                blnReturn = true;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message)
                blnReturn = false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
            }
            return blnReturn;
        }

        public static bool Study(int kanaID,bool katakana)
        {
            string sql = string.Empty;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP=1UVADPU;Initial Catalog=Kana;Integrated Security=True");
            SqlCommand cmd;
            bool blnReturn;

            try
            {
                if (katakana)
                {
                    sql = "SELECT Katakana FROM Kana WHERE ID = @kanaID";
                }
                else
                {
                    sql = "SELECT Hiragana FROM Kana WHERE ID = @kanaID";
                }

                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("kanaID", (int)kanaID);
                cmd.ExecuteNonQuery();
                blnReturn = true;
            }
            catch (Exception ex)
            {
                //MsgBox(ex.Message)
                blnReturn = false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
            }
            return blnReturn;
        }

        public static bool Learn(bool katakana)
        {
            string sql = string.Empty;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True");
            SqlCommand cmd;
            bool blnReturn;

            try
            {
                if (katakana)
                {
                    sql = "SELECT Romanji, Katakana FROM Kana";
                }
                else
                {
                    sql = "SELECT Romanji, Hiragana FROM Kana";
                }

                conn.Open();
                cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    
                }
                blnReturn = true;
            }
            catch (Exception ex)
            {
                //ex.Message
                blnReturn = false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
            }
            return blnReturn;
        }
    }
}
