using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Manages the saving and retrieving of data.
    /// </summary>
    class FileManager
    {
        private const string FILE_VERSION_TOKEN = "maltesMealScheduler24";
        private const double FILE_VERSION_NUMBER = 1.0;

        /// <summary>
        /// Saves the content of the day list to a json file.
        /// </summary>
        /// <param name="fileName">Where the json will be saved.</param>
        /// <param name="days">The days to be saved.</param>
        /// <returns></returns>
        public static bool SaveDayListToFile(string fileName, List<Day> days)
        {
            string json = JsonSerializer.Serialize(new SaveFile(days, FILE_VERSION_TOKEN,
                FILE_VERSION_NUMBER));

            try
            {
                File.WriteAllText(fileName, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Sets the contents of the day list to that of a json file.
        /// </summary>
        /// <param name="days">The reference object to be updated.</param>
        /// <param name="fileName">The location of the json file.</param>
        /// <returns>True if the operation was succesful, otherwise false.</returns>
        public static bool ReadDayListFromFile(List<Day> days, string fileName)
        {
            SaveFile saveFile;

            try
            {
                string json = File.ReadAllText(fileName);
                saveFile = JsonSerializer.Deserialize<SaveFile>(json)!;
            }
            catch
            {
                return false;
            }

            if (!saveFile.CheckFileVersionNumber(FILE_VERSION_NUMBER) ||
                !saveFile.CheckFileVersionToken(FILE_VERSION_TOKEN))
            {
                MessageBox.Show("The file version does not match the current version. " +
                    "Data might have been lost.", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //sets the day list to new values
            days.AddRange(saveFile.Days);
            return true;
        }
    }
}
