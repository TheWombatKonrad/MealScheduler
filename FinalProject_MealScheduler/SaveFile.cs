namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Contains all information for a save file. 
    /// </summary>
    /// <param name="daysToBeSaved">The days that will be written into the save file.</param>
    /// <param name="fileVersionToken">A token representing the version of the file.</param>
    /// <param name="fileVersionNumber">The version of the file.</param>
    class SaveFile(List<Day> daysToBeSaved, string fileVersionToken,
        double fileVersionNumber)
    {
        public List<Day> Days { get; set; } = daysToBeSaved;
        public int DayCount {  get; } = daysToBeSaved.Count;
        public string FileVersionToken { get; set; } = fileVersionToken;
        public double FileVersionNumber { get; set;} = fileVersionNumber;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SaveFile() : this([], string.Empty, 0.0) { }

        /// <summary>
        /// Checks whether the file version is correct.
        /// </summary>
        /// <param name="versionToken">The version token to be checked.</param>
        /// <returns>True if the version token is correct, otherwise false.</returns>
        public bool CheckFileVersionToken(string versionToken)
        {
            return string.Equals(FileVersionToken, versionToken);
        }

        /// <summary>
        /// Checks whether the given version number matches the current version number.
        /// </summary>
        /// <param name="versionNumber">The version number to be checked.</param>
        /// <returns>True if the version numbers match, otherwise false.</returns>
        public bool CheckFileVersionNumber(double versionNumber)
        {
            return FileVersionNumber.Equals(versionNumber);
        }
    }
}
