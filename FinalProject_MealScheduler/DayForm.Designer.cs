namespace FinalProject_MealScheduler
{
    partial class DayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datePicker = new DateTimePicker();
            breakfastInput = new TextBox();
            breakfastLabel = new Label();
            lunchLabel = new Label();
            dinnerLabel = new Label();
            lunchInput = new TextBox();
            dinnerInput = new TextBox();
            OKButton = new Button();
            cancelButton = new Button();
            dayGroup = new GroupBox();
            dayGroup.SuspendLayout();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Location = new Point(6, 23);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(354, 25);
            datePicker.TabIndex = 0;
            datePicker.ValueChanged += DatePicker_ValueChanged;
            // 
            // breakfastInput
            // 
            breakfastInput.BorderStyle = BorderStyle.FixedSingle;
            breakfastInput.Location = new Point(92, 54);
            breakfastInput.Name = "breakfastInput";
            breakfastInput.Size = new Size(268, 25);
            breakfastInput.TabIndex = 2;
            // 
            // breakfastLabel
            // 
            breakfastLabel.AutoSize = true;
            breakfastLabel.Location = new Point(6, 56);
            breakfastLabel.Name = "breakfastLabel";
            breakfastLabel.Size = new Size(80, 18);
            breakfastLabel.TabIndex = 1;
            breakfastLabel.Text = "Breakfast";
            // 
            // lunchLabel
            // 
            lunchLabel.AutoSize = true;
            lunchLabel.Location = new Point(6, 91);
            lunchLabel.Name = "lunchLabel";
            lunchLabel.Size = new Size(48, 18);
            lunchLabel.TabIndex = 3;
            lunchLabel.Text = "Lunch";
            // 
            // dinnerLabel
            // 
            dinnerLabel.AutoSize = true;
            dinnerLabel.Location = new Point(6, 125);
            dinnerLabel.Name = "dinnerLabel";
            dinnerLabel.Size = new Size(56, 18);
            dinnerLabel.TabIndex = 5;
            dinnerLabel.Text = "Dinner";
            // 
            // lunchInput
            // 
            lunchInput.BorderStyle = BorderStyle.FixedSingle;
            lunchInput.Location = new Point(92, 89);
            lunchInput.Name = "lunchInput";
            lunchInput.Size = new Size(268, 25);
            lunchInput.TabIndex = 4;
            // 
            // dinnerInput
            // 
            dinnerInput.BorderStyle = BorderStyle.FixedSingle;
            dinnerInput.Location = new Point(92, 123);
            dinnerInput.Name = "dinnerInput";
            dinnerInput.Size = new Size(268, 25);
            dinnerInput.TabIndex = 6;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(6, 153);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(175, 45);
            OKButton.TabIndex = 7;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(185, 153);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 45);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // dayGroup
            // 
            dayGroup.Controls.Add(cancelButton);
            dayGroup.Controls.Add(OKButton);
            dayGroup.Controls.Add(dinnerInput);
            dayGroup.Controls.Add(lunchInput);
            dayGroup.Controls.Add(dinnerLabel);
            dayGroup.Controls.Add(lunchLabel);
            dayGroup.Controls.Add(breakfastLabel);
            dayGroup.Controls.Add(breakfastInput);
            dayGroup.Controls.Add(datePicker);
            dayGroup.Location = new Point(12, 11);
            dayGroup.Name = "dayGroup";
            dayGroup.Size = new Size(366, 209);
            dayGroup.TabIndex = 0;
            dayGroup.TabStop = false;
            // 
            // DayForm
            // 
            AcceptButton = OKButton;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 227);
            Controls.Add(dayGroup);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "DayForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Plan A Day";
            FormClosing += DayForm_FormClosing;
            dayGroup.ResumeLayout(false);
            dayGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker datePicker;
        private TextBox breakfastInput;
        private Label breakfastLabel;
        private Label lunchLabel;
        private Label dinnerLabel;
        private TextBox lunchInput;
        private TextBox dinnerInput;
        private Button OKButton;
        private Button cancelButton;
        private GroupBox dayGroup;
    }
}