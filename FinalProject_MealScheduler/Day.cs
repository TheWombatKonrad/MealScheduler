using System.Globalization;

namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Describes a day's planned meals.
    /// </summary>
    /// <param name="date">The date of the day.</param>
    /// <param name="mealPlanning">The meals planned for the day.</param>
    class Day(DateTime date, MealPlanning mealPlanning)
    {
        public MealPlanning MealPlanning { get; set; } = mealPlanning;
        public DateTime Date { get; set; } = date;

        /// <summary>
        /// Default constructor. Sets the day to today.
        /// </summary>
        public Day() : this(DateTime.Today, new MealPlanning()) { }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="dayToCopy">The day that should be copied.</param>
        public Day(Day dayToCopy) : this(dayToCopy.Date, new MealPlanning(dayToCopy.MealPlanning)) { }

        /// <summary>
        /// Copies the information of an existing day into the current day.
        /// </summary>
        /// <param name="dayToCopy"></param>
        public void CopyDay(Day dayToCopy)
        {
            Date = dayToCopy.Date;
            MealPlanning = new MealPlanning(dayToCopy.MealPlanning);
        }

        /// <summary>
        /// Returns the brief information about the day, i.e., the weekday
        /// it falls on and the date.
        /// </summary>
        /// <returns>A brief summary of the day.</returns>
        public override string ToString()
        {
            return string.Concat(Date.DayOfWeek.ToString(), " ",
                Date.ToString("dd/MM", CultureInfo.InvariantCulture));
        }
    }
}
