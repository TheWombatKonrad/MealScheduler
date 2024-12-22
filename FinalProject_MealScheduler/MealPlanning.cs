using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Contains the planned meals a day.
    /// </summary>
    /// <param name="breakfast">The planned breakfast.</param>
    /// <param name="lunch">The planned lunch.</param>
    /// <param name="dinner">The planned dinner.</param>
    class MealPlanning(string breakfast, string lunch, string dinner)
    {
        public string Breakfast { get; set; } = breakfast;
        public string Lunch { get; set; } = lunch;
        public string Dinner { get; set; } = dinner;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MealPlanning() : this(string.Empty, string.Empty, string.Empty) { }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="mealPlanning">The mealplanning to copy.</param>
        public MealPlanning(MealPlanning mealPlanning) : this(
            mealPlanning.Breakfast, mealPlanning.Lunch, mealPlanning.Dinner)
        { }
    }
}
