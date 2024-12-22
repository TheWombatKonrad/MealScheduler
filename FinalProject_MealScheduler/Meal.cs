using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Describes a meal.
    /// </summary>
    /// <param name="mealType">What type of meal it is.</param>
    /// <param name="description">What the meal is.</param>
    class Meal(MealType mealType, string description)
    {
        public MealType MealType { get; set; } = mealType;
        public string Description { get; set; } = description;

        /// <summary>
        /// The default constructor. Sets MealType to Breakfast, and
        /// the Description to an empty string.
        /// </summary>
        public Meal() : this(MealType.Breakfast, string.Empty){ }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="mealToCopy">The meal to copy.</param>
        public Meal(Meal mealToCopy) : this(mealToCopy.MealType, mealToCopy.Description) { }
    }
}
