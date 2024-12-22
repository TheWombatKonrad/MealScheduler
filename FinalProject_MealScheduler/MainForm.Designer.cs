namespace FinalProject_MealScheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            saveMenuItem = new ToolStripMenuItem();
            saveAsMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            daysGroup = new GroupBox();
            dayList = new ListBox();
            deleteButton = new Button();
            editButton = new Button();
            addButton = new Button();
            mealsGroup = new GroupBox();
            dinnerGroup = new GroupBox();
            dinnerDescription = new TextBox();
            lunchGroup = new GroupBox();
            lunchDescription = new TextBox();
            breakfastGroup = new GroupBox();
            breakfastDescription = new TextBox();
            menuStrip.SuspendLayout();
            daysGroup.SuspendLayout();
            mealsGroup.SuspendLayout();
            dinnerGroup.SuspendLayout();
            lunchGroup.SuspendLayout();
            breakfastGroup.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(724, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem, toolStripMenuItem2, saveMenuItem, saveAsMenuItem, toolStripMenuItem1, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(46, 24);
            fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.Size = new Size(221, 26);
            newMenuItem.Text = "New File (Ctrl + N)";
            newMenuItem.Click += NewMenuItem_Click;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(221, 26);
            openMenuItem.Text = "Open File (Ctrl + O)";
            openMenuItem.Click += OpenMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(218, 6);
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(221, 26);
            saveMenuItem.Text = "Save (Ctrl + S)";
            saveMenuItem.Click += SaveMenuItem_Click;
            // 
            // saveAsMenuItem
            // 
            saveAsMenuItem.Name = "saveAsMenuItem";
            saveAsMenuItem.Size = new Size(221, 26);
            saveAsMenuItem.Text = "Save As";
            saveAsMenuItem.Click += SaveAsMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(218, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(221, 26);
            exitMenuItem.Text = "Exit (Alt + F4)";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(55, 24);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(133, 26);
            aboutMenuItem.Text = "About";
            aboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // daysGroup
            // 
            daysGroup.Controls.Add(dayList);
            daysGroup.Controls.Add(deleteButton);
            daysGroup.Controls.Add(editButton);
            daysGroup.Controls.Add(addButton);
            daysGroup.Location = new Point(12, 31);
            daysGroup.Name = "daysGroup";
            daysGroup.Size = new Size(266, 408);
            daysGroup.TabIndex = 1;
            daysGroup.TabStop = false;
            daysGroup.Text = "Days Planned";
            // 
            // dayList
            // 
            dayList.FormattingEnabled = true;
            dayList.ItemHeight = 18;
            dayList.Location = new Point(6, 22);
            dayList.Name = "dayList";
            dayList.Size = new Size(254, 328);
            dayList.TabIndex = 1;
            dayList.SelectedIndexChanged += DayList_SelectedIndexChanged;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(180, 360);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(80, 42);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(93, 360);
            editButton.Name = "editButton";
            editButton.Size = new Size(80, 42);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 360);
            addButton.Name = "addButton";
            addButton.Size = new Size(80, 42);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // mealsGroup
            // 
            mealsGroup.Controls.Add(dinnerGroup);
            mealsGroup.Controls.Add(lunchGroup);
            mealsGroup.Controls.Add(breakfastGroup);
            mealsGroup.Location = new Point(284, 31);
            mealsGroup.Name = "mealsGroup";
            mealsGroup.Size = new Size(436, 408);
            mealsGroup.TabIndex = 2;
            mealsGroup.TabStop = false;
            mealsGroup.Text = "Meals Planned";
            // 
            // dinnerGroup
            // 
            dinnerGroup.Controls.Add(dinnerDescription);
            dinnerGroup.Location = new Point(6, 276);
            dinnerGroup.Name = "dinnerGroup";
            dinnerGroup.Size = new Size(424, 120);
            dinnerGroup.TabIndex = 2;
            dinnerGroup.TabStop = false;
            dinnerGroup.Text = "Dinner";
            // 
            // dinnerDescription
            // 
            dinnerDescription.BorderStyle = BorderStyle.None;
            dinnerDescription.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dinnerDescription.Location = new Point(12, 24);
            dinnerDescription.Multiline = true;
            dinnerDescription.Name = "dinnerDescription";
            dinnerDescription.PlaceholderText = "What will you have for dinner?";
            dinnerDescription.ReadOnly = true;
            dinnerDescription.Size = new Size(412, 90);
            dinnerDescription.TabIndex = 0;
            dinnerDescription.TabStop = false;
            dinnerDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lunchGroup
            // 
            lunchGroup.Controls.Add(lunchDescription);
            lunchGroup.Location = new Point(6, 150);
            lunchGroup.Name = "lunchGroup";
            lunchGroup.Size = new Size(424, 120);
            lunchGroup.TabIndex = 1;
            lunchGroup.TabStop = false;
            lunchGroup.Text = "Lunch";
            // 
            // lunchDescription
            // 
            lunchDescription.BorderStyle = BorderStyle.None;
            lunchDescription.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lunchDescription.Location = new Point(6, 24);
            lunchDescription.Multiline = true;
            lunchDescription.Name = "lunchDescription";
            lunchDescription.PlaceholderText = "What will you have for lunch?";
            lunchDescription.ReadOnly = true;
            lunchDescription.Size = new Size(412, 90);
            lunchDescription.TabIndex = 0;
            lunchDescription.TabStop = false;
            lunchDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // breakfastGroup
            // 
            breakfastGroup.BackColor = SystemColors.Control;
            breakfastGroup.Controls.Add(breakfastDescription);
            breakfastGroup.Location = new Point(6, 24);
            breakfastGroup.Name = "breakfastGroup";
            breakfastGroup.Size = new Size(424, 120);
            breakfastGroup.TabIndex = 0;
            breakfastGroup.TabStop = false;
            breakfastGroup.Text = "Breakfast";
            // 
            // breakfastDescription
            // 
            breakfastDescription.BorderStyle = BorderStyle.None;
            breakfastDescription.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            breakfastDescription.Location = new Point(6, 24);
            breakfastDescription.Multiline = true;
            breakfastDescription.Name = "breakfastDescription";
            breakfastDescription.PlaceholderText = "What will you have for breakfast?";
            breakfastDescription.ReadOnly = true;
            breakfastDescription.Size = new Size(412, 90);
            breakfastDescription.TabIndex = 0;
            breakfastDescription.TabStop = false;
            breakfastDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 445);
            Controls.Add(mealsGroup);
            Controls.Add(daysGroup);
            Controls.Add(menuStrip);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Meal Scheduler";
            FormClosing += MainForm_FormClosing;
            KeyDown += MainForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            daysGroup.ResumeLayout(false);
            mealsGroup.ResumeLayout(false);
            dinnerGroup.ResumeLayout(false);
            dinnerGroup.PerformLayout();
            lunchGroup.ResumeLayout(false);
            lunchGroup.PerformLayout();
            breakfastGroup.ResumeLayout(false);
            breakfastGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem saveAsMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private GroupBox daysGroup;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private GroupBox mealsGroup;
        private GroupBox dinnerGroup;
        private GroupBox lunchGroup;
        private GroupBox breakfastGroup;
        private TextBox dinnerDescription;
        private TextBox lunchDescription;
        private TextBox breakfastDescription;
        private ListBox dayList;
    }
}
