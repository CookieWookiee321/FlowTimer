using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace FlowTimer
{
    internal class DatabaseInit
    {
        static string connString = "Data Source=flowtimer.sqlite; Version=3;";
        static SQLiteConnection conn;

        /// <summary>
        /// Sets up the database with an initial table which points to the base sound files
        /// included with the program.
        /// </summary>
        public static void CreateDB()
        {
            if (!File.Exists("flowtimer.sqlite"))
            {
                SQLiteConnection.CreateFile("flowtimer.sqlite");

                conn = new SQLiteConnection(connString);
                conn.Open();

                CreateTables();

                conn.Close();
            }
        }

        private static void CreateTables()
        {
            string tables = 
                $"CREATE TABLE FileLocations" +
                $"(" +
                    $"folder varchar(200), " +
                    $"fileName varchar(200), " +
                    $"function varchar(50)" +
                $");";

            using (SQLiteCommand cmd = new SQLiteCommand(tables, conn))
            {
                cmd.ExecuteNonQuery();
            }

            string tablesInput =
                $"INSERT INTO FileLocations (folder, fileName, function) " +
                $"VALUES ('sounds', 'bing.wav', 'start'), " +
                        $"('sounds', 'break_fin.wav', 'finishBreak'), " +
                        $"('sounds', 'bong.wav', 'startBreak'), " +
                        $"('graphics', 'imgPause.png', 'pause'), " +
                        $"('graphics', 'imgPlay.png', 'play'), " +
                        $"('graphics', 'imgReset.png', 'reset'), " +
                        $"('graphics', 'imgStop.png', 'stop'), " +
                        $"('sounds', 'bong_short.wav', 'pause');";

            using (SQLiteCommand cmd = new SQLiteCommand(tablesInput, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Fetches the details of the files set to be used in the database.
        /// </summary>
        /// <returns>List of string[] which hold all the information for the used files.</returns>
        public static List<string[]> LoadFiles()
        {
            if (conn is null)
            {
                conn = new SQLiteConnection(connString);
            }

            conn.Open();

            List<string[]> details = new List<string[]>();

            string fetch =
                $"SELECT * " +
                $"FROM FileLocations;";

            using (SQLiteDataReader r = new SQLiteCommand(fetch, conn).ExecuteReader())
            {
                while (r.Read())
                {
                    details.Add(new string[] { (string)r[0], (string)r[1], (string)r[2] });
                }
            }

            conn.Close();

            return details;
        }

        /// <summary>
        /// Adds a new file to the program files, as well as replaces (does not overwrite) the pre-existing file in the program 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="newFilePath"></param>
        /// <param name="newFileName"></param>
        /// <param name="function"></param>
        /// <returns>Location of the new file in the local directory</returns>
        public static string AddFile(string type, string newFilePath, string newFileName, string function)
        {
            //Copy new file to local program directory
            string oldLoc = newFilePath;
            string newLoc = $"{Directory.GetCurrentDirectory()}/sounds/{newFileName}";

            File.Copy(oldLoc, newLoc, true);

            //Update the DB so it knows to select the new file in the future
            string update =
                $"UPDATE FileLocations " +
                $"SET fileName = @fn " +
                $"WHERE folder = @f1 AND function = @f2;";

            conn.Open();

            using (SQLiteCommand cmd = new SQLiteCommand(update, conn))
            {
                SQLiteParameter[] param = new SQLiteParameter[]
                {
                    new SQLiteParameter("@fn", newFileName),
                    new SQLiteParameter("@f1", type),
                    new SQLiteParameter("@f2", function)
                };
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
            }

            conn.Close();

            return newLoc;
        }
    }
}
