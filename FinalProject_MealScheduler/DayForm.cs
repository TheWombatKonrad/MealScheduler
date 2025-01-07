using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_MealScheduler
{
    /// <summary>
    /// Lets the user add or edit a day.
    /// </summary>
    partial class DayForm : Form
    {
        readonly Day parentDay;
        Day workingDay = new();

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="parentDay"></param>
        /// <param name="isEditing"></param>
        public DayForm(Day parentDay, bool isEditing)
        {
            InitializeComponent();
            this.parentDay = parentDay;
            InitalizeGUI(isEditing);
        }

        /// <summary>
        /// Sets up the starting GUI of the form.
        /// </summary>
        private void InitalizeGUI(bool isEditing)
        {
            if (isEditing)
            {
                datePicker.Value = parentDay.Date;
                breakfastInput.Text = parentDay.MealPlanning.Breakfast;
                lunchInput.Text = parentDay.MealPlanning.Lunch;
                dinnerInput.Text = parentDay.MealPlanning.Dinner;
            }

            dayGroup.Text = string.Concat(datePicker.Value.DayOfWeek.ToString(), " ",
                datePicker.Value.ToString("dd MMMM", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Sets the GroupBox's title to match the day and date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            dayGroup.Text = string.Concat(datePicker.Value.DayOfWeek.ToString(), " ",
                datePicker.Value.ToString("dd MMMM", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Reads the inputs, and if everything is right, updates the 
        /// parentDay with the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            workingDay = new Day(parentDay)
            {
                Date = datePicker.Value
            };

            //Planned meals are allowed to be empty.
            workingDay.MealPlanning.Breakfast = breakfastInput.Text.Trim();
            workingDay.MealPlanning.Lunch = lunchInput.Text.Trim();
            workingDay.MealPlanning.Dinner = dinnerInput.Text.Trim();

            //A day is allowed to contain only empty meals.
            parentDay.CopyDay(workingDay);
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Starts the process to close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Asks the user if they are sure they want to cancel. If yes,
        /// the form is cancelled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
            {
                //If yes, the cancellation of the cancellation does not happen.
                if (MessageBox.Show(this, "Are you sure you want to cancel?",
                    "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }
    }
}
