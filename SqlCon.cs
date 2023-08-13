using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WebApplication2
{
    public class SqlCon
    {
        string server = "";
        string database = "";
        string userid = "";
        string password = "";

        private SqlConnection Con;

        public SqlCon()
        {
            //string line = "";
            try
            {
                /*string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string file = dir + @"\Connection\SQLConfig.txt";
               
                StreamReader sr = new StreamReader(file);
                line = sr.ReadToEnd();
                string[] data = line.Split(',');

                server = data[0].Trim();
                database = data[1].Trim();
                userid = data[2].Trim();
                password = data[3].Trim();*/
                
                server="DESKTOP-3NBRB6O";
                database="projecttest";
                userid="sa";
                password = "123456";

                //sr.Close();
                Con = new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + "; User ID=" + userid + "; Password=" + password + ";");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing final block");
            }


        }
        SqlCommand cmd = new SqlCommand();

        public SqlConnection getCon()
        {
            return Con;
        }

    }
}