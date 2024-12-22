using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Manages the list of days.
    /// </summary>
    /// <param name="days"></param>
    class DayManager(List<Day> days)
    {
        List<Day> days = days;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DayManager() : this([]) { }

        /// <summary>
        /// Adds a day to the Day list.
        /// </summary>
        /// <param name="day">The day to be added.</param>
        /// <returns>The index of the added day, or -1 if unsuccesful.</returns>
        public int AddDay(Day day)
        {
            Day newDay = new(day);
            if (DateHasAlreadyBeenPlanned(newDay.Date))
                return -1;

            days.Add(newDay);
            SortListOfDays();
            return days.IndexOf(newDay);
        }

        /// <summary>
        /// Removes a day at the given index.
        /// </summary>
        /// <param name="index">The index of the day to be removed.</param>
        /// <returns>True if the operation was succesful, otherwise false.</returns>
        public bool RemoveDayAt(int index)
        {
            if (CheckIndex(index))
            {
                days.RemoveAt(index);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Updates a day at the given index.
        /// </summary>
        /// <param name="index">The index of the day.</param>
        /// <param name="day">The new day data.</param>
        /// <returns>The index of the updated day, or -1 if unsucessful.<returns>
        public int UpdateDayAt(int index, Day day)
        {
            Day updatedDay = new(day);

            if (CheckIndex(index))
            {
                //It's necessary to remove the old day first, to be 
                //able to properly check that the new date doesn't
                //match a previously added date.
                RemoveDayAt(index);
                if (DateHasAlreadyBeenPlanned(updatedDay.Date))
                    return -1;

                days.Add(updatedDay);
                SortListOfDays();
                return days.IndexOf(updatedDay);
            }

            return -1;
        }

        /// <summary>
        /// If the day exists, it is returned. Otherwise an exception
        /// is thrown.
        /// </summary>
        /// <param name="index">The index of the day to be returned.</param>
        /// <returns>The day at the given index.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the day does not exist.</exception>
        public Day GetDayAt(int index)
        {
            if (CheckIndex(index))
                return new Day(days[index]);
            else
                throw new KeyNotFoundException("The specified day could not be found");
        }

        /// <summary>
        /// Returns an array of strings containing brief information about
        /// a day.
        /// </summary>
        /// <returns>An array of strings containing day information.</returns>
        public string[] GetDayStrings()
        {
            return days
                .Select(day => day.ToString())
                .ToArray();
        }

        /// <summary>
        /// Removes all days from the day list.
        /// </summary>
        public void ClearDayList()
        {
            days.Clear();
        }

        /// <summary>
        /// Returns how many days are in the day list.
        /// </summary>
        /// <returns>How many days are in the day list as an int.</returns>
        public int GetDayListCount()
        {
            return days.Count;
        }

        /// <summary>
        /// Saves the current day list.
        /// </summary>
        /// <param name="fileName">The location the list should be saved.</param>
        /// <returns>True if the operation was succesful, otherwise false.</returns>
        public bool WriteDataToFile(string fileName)
        {
            return FileManager.SaveDayListToFile(fileName, days);
        }

        /// <summary>
        /// Sets the day list to that of a saved day list.
        /// </summary>
        /// <param name="fileName">Where the day list is saved.</param>
        /// <returns>True if the operation was succesful, otherwise false.</returns>
        public bool ReadDayListFromFile(string fileName)
        {
            days.Clear();
            bool ok = FileManager.ReadDayListFromFile(days, fileName);

            if (ok)
                SortListOfDays();

            return ok;
        }

        /// <summary>
        /// Checks to make sure that the given index is within
        /// the bounds of the days list.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is good, otherwise false.</returns>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < days.Count)
                return true;
            return false;
        }

        /// <summary>
        /// Returns true if a date already exists in the days list.
        /// </summary>
        /// <param name="date">The date to be checked.</param>
        /// <returns>True if it exists, otherwise false.</returns>
        private bool DateHasAlreadyBeenPlanned(DateTime date)
        {
            foreach (Day day in days)
            {
                if (day.Date.Date == date.Date)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Sorts the days list.
        /// </summary>
        private void SortListOfDays()
        {
            days = [.. days.OrderBy(day => day.Date)];
        }
    }
}
