using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerSaleSYS
{
    internal class FileReader
    {
        public static string GetConnectionString()
        {
            try
            {
                //Get the current user's profile folder path - will be something like C:\Users\t********
                string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                //Here I have placed the files holding the Oracle connection strings into the "Documents" folder on my OneDrive
                //I have two files, one for each connection string used - you will need to create these files yourself of course
                //and pop the appropriate Oracle connection strings into them - the one for me HOME connection looks as follows:

                //Data Source=localhost/orcl; User Id=C##User1; Password=123456;

                //The one for your MTU Oracle connection will look as follows:

                //Data Source=studentoracle:1521/orcl; User Id=t*********; Password=**********;

                //string filePath = Path.Combine(userProfilePath + "\\OneDrive - Munster Technological University", "OracleConnectionStringMTU.txt");
                string filePath = Path.Combine(userProfilePath, "Documents", "OracleConnectionStringHOME.txt");

                //Check if file exists
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"File not found: {filePath}");
                }

                return File.ReadAllText(filePath).Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading connection string: {ex.Message}");
                throw;
            }
        }
    }
}
