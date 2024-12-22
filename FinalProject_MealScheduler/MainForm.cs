namespace FinalProject_MealScheduler
{
    public partial class MainForm : Form
    {
        DayManager dayManager = new DayManager();
        string fileName = "";

        public MainForm()
        {
            InitializeComponent();
            UpdateGUI();
        }

        /// <summary>
        /// When a key is pressed, if the key is one of the established 
        /// shortcuts, the corresponding method is run.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                NewMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                OpenMenuItem_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                SaveMenuItem_Click(sender, e);
            }
        }

        /// <summary>
        /// Creates a new session. If the day list is not empty, the user
        /// is asked if they want to save first.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            if (dayManager.GetDayListCount() > 0)
                if (MessageBox.Show(this, "Do you wish to save first?",
                    "Creating new session", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveAsMenuItem_Click(sender, e);
                }

            fileName = "";
            dayManager.ClearDayList();
            UpdateGUI();
        }

        /// <summary>
        /// Asks the user where the file is located, and then retrieves
        /// the information stored there.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (dayManager.GetDayListCount() > 0)
                if (MessageBox.Show(this, "Do you wish to save first?",
                    "Opening saved days", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveAsMenuItem_Click(sender, e);
                }

            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Json files(*.json) | *.json",
                Title = "Open day list"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //This is so that when the user presses Save next time,
                //this file will automatically be saved over.
                fileName = openFileDialog.FileName;

                if (dayManager.ReadDayListFromFile(fileName))
                    UpdateGUI();
                else
                    MessageBox.Show(this, "The day list could not be opened.",
                        "File Cannot Be Opened", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// If the fileName is not empty, the day list is saved without
        /// the user being prompted for a location.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
                SaveAsMenuItem_Click(sender, e);
            else
                //If the file was not succesfully saved
                if (!dayManager.WriteDataToFile(fileName))
                MessageBox.Show(this, "The day list could not be saved.",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// The user is first prompted to set where the day list should be 
        /// saved, and then the list is saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Json files(*.json) | *.json",
                Title = "Save day list"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //This is so that when the user presses Save next time, this file
                //will automatically be saved over.
                fileName = saveFileDialog.FileName;

                //If the file was not succesfully saved
                if (!dayManager.WriteDataToFile(fileName))
                    MessageBox.Show(this, "The day list could not be saved.",
                        "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Starts the process for closing the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// When the user tries to close the application, they are prompted
        /// to answer if they actually want to close it. If yes, it closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dayManager.GetDayListCount() > 0)
                if (MessageBox.Show(this, "Do you wish to save first?",
                    "Closing Application", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveAsMenuItem_Click(sender, e);
                }
        }

        /// <summary>
        /// Opens a dialog showing the information about the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// When the selected index is changed, the MealsGroup part of the
        /// GUI is updated to show the information of the selected day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = dayList.SelectedIndex;

            try
            {
                SetMealsGroupGUI(dayManager.GetDayAt(index));
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show(this, "The day could not be found.",
                    "Day Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(this, "There was an error updating the GUI.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the MealsGroup part of the GUI to show the planned
        /// meals for the day.
        /// </summary>
        /// <param name="day"></param>
        private void SetMealsGroupGUI(Day day)
        {
            ClearMeals();

            if (!string.IsNullOrEmpty(day.MealPlanning.Breakfast))
                breakfastDescription.Text = GetFormattedMealDescription(day.MealPlanning.Breakfast);
            if (!string.IsNullOrEmpty(day.MealPlanning.Lunch))
                lunchDescription.Text = GetFormattedMealDescription(day.MealPlanning.Lunch);
            if (!string.IsNullOrEmpty(day.MealPlanning.Dinner))
                dinnerDescription.Text = GetFormattedMealDescription(day.MealPlanning.Dinner);
        }

        private string GetFormattedMealDescription(string meal)
        {
            if (meal.Length > 60)
                return string.Concat(Environment.NewLine, meal.AsSpan(0, 60));
            else
                return string.Concat(Environment.NewLine, meal);
        }


        /// <summary>
        /// Adds a day to the day list. Will continue to open the dialog
        /// until the day is succesfully added, or the dialog is cancelled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Day workingDay = new();
            DayForm dayForm = new(workingDay, false);

            while (true)
            {
                var result = dayForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int newIndex = dayManager.AddDay(workingDay);

                    if (newIndex != -1)
                    {
                        UpdateGUI();
                        dayList.SelectedIndex = newIndex;
                        //If the user succesfully adds a day, the 
                        //dialog box no longer continues to open.
                        return;
                    }
                    else
                    {
                        string errorString = "There was an error. Make " +
                            "sure that the date has not already been planned, " +
                            "and that all information was entered correctly.";

                        MessageBox.Show(this, errorString, "Day could not be added",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //If the user has cancelled the dialog box, 
                //the box doesn't open again.
                if (result == DialogResult.Cancel)
                    return;
            }
        }

        /// <summary>
        /// Opens a Dialog to edit the selected day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            Day workingDay;

            //Sets the selected day.
            try
            {
                workingDay = dayManager.GetDayAt(dayList.SelectedIndex);
            }
            catch
            {
                MessageBox.Show(this, "The selected day could not be found.",
                    "Day Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DayForm dayForm = new(workingDay, true);

            //Passes the selected day to the DayForm and updates the list.
            while (true)
            {
                var result = dayForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int newIndex = dayManager.UpdateDayAt(dayList.SelectedIndex, workingDay);

                    if (newIndex != -1)
                    {
                        UpdateGUI();
                        dayList.SelectedIndex = newIndex;
                        //If the user succesfully updates the day, the 
                        //dialog box no longer continues to open.
                        return;
                    }
                    else
                    {
                        string errorString = "There was an error. Make " +
                            "sure that the date has not already been planned, " +
                            "and that all information was entered correctly.";

                        MessageBox.Show(this, errorString, "Day could not be updated",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //If the user has cancelled the dialog box, 
                //the box doesn't open again.
                if (result == DialogResult.Cancel)
                    return;
            }
        }

        /// <summary>
        /// Deletes the selected day.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dayManager.RemoveDayAt(dayList.SelectedIndex))
                UpdateGUI();
            else
                MessageBox.Show(this, "The selected day could not be deleted.",
                    "Day Could Not Be Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Updates the GUI to show the current state of things.
        /// </summary>
        private void UpdateGUI()
        {
            dayList.Items.Clear();
            dayList.Items.AddRange(dayManager.GetDayStrings());
            ClearMeals();
        }

        /// <summary>
        /// Clears the meals displayed in the MealsGroup.
        /// </summary>
        private void ClearMeals()
        {
            breakfastDescription.Text = "";
            lunchDescription.Text = "";
            dinnerDescription.Text = "";
        }
    }
}
