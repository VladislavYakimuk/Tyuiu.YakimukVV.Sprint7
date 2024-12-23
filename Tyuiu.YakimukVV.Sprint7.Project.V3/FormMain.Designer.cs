﻿using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.YakimukVV.Sprint7.Project.V3
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDetails_YVV = new Button();
            buttonPerformance_YVV = new Button();
            buttonAddRow_YVV = new Button();
            buttonDeleteRow_YVV = new Button();
            buttonAddColumn_YVV = new Button();
            buttonDeleteColumn_YVV = new Button();
            group_YVV = new Label();
            subject_YVV = new Label();
            buttonGiveGroup_YVV = new Button();
            buttonAddSubject_YVV = new Button();
            buttonDeleteGroup_YVV = new Button();
            buttonDeleteSubject_YVV = new Button();
            dataGridView_YVV = new DataGridView();
            comboBoxGroup_YVV = new ComboBox();
            comboBoxSubjects_YVV = new ComboBox();
            toolTip_YVV = new ToolTip(components);
            openFileDialog_YVV = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVV).BeginInit();
            SuspendLayout();
            // 
            // buttonDetails_YVV
            // 
            buttonDetails_YVV.FlatStyle = FlatStyle.Flat;
            buttonDetails_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonDetails_YVV.ForeColor = SystemColors.GradientInactiveCaption;
            buttonDetails_YVV.Image = (Image)resources.GetObject("buttonDetails_YVV.Image");
            buttonDetails_YVV.Location = new Point(12, 812);
            buttonDetails_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonDetails_YVV.Name = "buttonDetails_YVV";
            buttonDetails_YVV.Size = new Size(94, 67);
            buttonDetails_YVV.TabIndex = 11;
            toolTip_YVV.SetToolTip(buttonDetails_YVV, "Нажмите чтобы узнать сведения о предмете");
            buttonDetails_YVV.UseVisualStyleBackColor = true;
            buttonDetails_YVV.Click += buttonDetails_YVV_Click;
            // 
            // buttonPerformance_YVV
            // 
            buttonPerformance_YVV.BackColor = Color.LightBlue;
            buttonPerformance_YVV.FlatStyle = FlatStyle.Flat;
            buttonPerformance_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonPerformance_YVV.Location = new Point(112, 816);
            buttonPerformance_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonPerformance_YVV.Name = "buttonPerformance_YVV";
            buttonPerformance_YVV.Size = new Size(171, 67);
            buttonPerformance_YVV.TabIndex = 11;
            buttonPerformance_YVV.Text = "Успеваемость группы";
            toolTip_YVV.SetToolTip(buttonPerformance_YVV, "Нажмите чтобы узнать средний балл выбранной группы");
            buttonPerformance_YVV.UseVisualStyleBackColor = false;
            // 
            // buttonAddRow_YVV
            // 
            buttonAddRow_YVV.BackColor = Color.LightGreen;
            buttonAddRow_YVV.FlatStyle = FlatStyle.Flat;
            buttonAddRow_YVV.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonAddRow_YVV.Location = new Point(825, 740);
            buttonAddRow_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonAddRow_YVV.Name = "buttonAddRow_YVV";
            buttonAddRow_YVV.Size = new Size(137, 60);
            buttonAddRow_YVV.TabIndex = 12;
            buttonAddRow_YVV.Text = "Добавить \r\nстроку";
            toolTip_YVV.SetToolTip(buttonAddRow_YVV, "Нажмите для добавления новой строки");
            buttonAddRow_YVV.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteRow_YVV
            // 
            buttonDeleteRow_YVV.BackColor = Color.IndianRed;
            buttonDeleteRow_YVV.FlatStyle = FlatStyle.Flat;
            buttonDeleteRow_YVV.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonDeleteRow_YVV.Location = new Point(825, 812);
            buttonDeleteRow_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteRow_YVV.Name = "buttonDeleteRow_YVV";
            buttonDeleteRow_YVV.Size = new Size(137, 68);
            buttonDeleteRow_YVV.TabIndex = 13;
            buttonDeleteRow_YVV.Text = "Удалить строку";
            toolTip_YVV.SetToolTip(buttonDeleteRow_YVV, "Выберите строку для удаления и нажмите кнопку");
            buttonDeleteRow_YVV.UseVisualStyleBackColor = false;
            // 
            // buttonAddColumn_YVV
            // 
            buttonAddColumn_YVV.BackColor = Color.LightGreen;
            buttonAddColumn_YVV.FlatStyle = FlatStyle.Flat;
            buttonAddColumn_YVV.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonAddColumn_YVV.Location = new Point(611, 740);
            buttonAddColumn_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonAddColumn_YVV.Name = "buttonAddColumn_YVV";
            buttonAddColumn_YVV.Size = new Size(137, 60);
            buttonAddColumn_YVV.TabIndex = 14;
            buttonAddColumn_YVV.Text = "Добавить столбец";
            toolTip_YVV.SetToolTip(buttonAddColumn_YVV, "Нажмите для добавления нового столбца");
            buttonAddColumn_YVV.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteColumn_YVV
            // 
            buttonDeleteColumn_YVV.BackColor = Color.IndianRed;
            buttonDeleteColumn_YVV.FlatStyle = FlatStyle.Flat;
            buttonDeleteColumn_YVV.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonDeleteColumn_YVV.Location = new Point(611, 812);
            buttonDeleteColumn_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteColumn_YVV.Name = "buttonDeleteColumn_YVV";
            buttonDeleteColumn_YVV.Size = new Size(137, 68);
            buttonDeleteColumn_YVV.TabIndex = 15;
            buttonDeleteColumn_YVV.Text = "Удалить столбец";
            toolTip_YVV.SetToolTip(buttonDeleteColumn_YVV, "Выберите столбец для удаления и нажмите кнопку");
            buttonDeleteColumn_YVV.UseVisualStyleBackColor = false;
            // 
            // group_YVV
            // 
            group_YVV.AutoSize = true;
            group_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            group_YVV.Location = new Point(38, 64);
            group_YVV.Name = "group_YVV";
            group_YVV.Size = new Size(155, 24);
            group_YVV.TabIndex = 1;
            group_YVV.Text = "Выбор группы";
            // 
            // subject_YVV
            // 
            subject_YVV.AutoSize = true;
            subject_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            subject_YVV.Location = new Point(38, 277);
            subject_YVV.Name = "subject_YVV";
            subject_YVV.Size = new Size(177, 24);
            subject_YVV.TabIndex = 3;
            subject_YVV.Text = "Выбор предмета";
            // 
            // buttonGiveGroup_YVV
            // 
            buttonGiveGroup_YVV.BackColor = Color.LightGreen;
            buttonGiveGroup_YVV.FlatAppearance.BorderSize = 0;
            buttonGiveGroup_YVV.FlatStyle = FlatStyle.Flat;
            buttonGiveGroup_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonGiveGroup_YVV.ForeColor = Color.Black;
            buttonGiveGroup_YVV.Location = new Point(38, 159);
            buttonGiveGroup_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonGiveGroup_YVV.Name = "buttonGiveGroup_YVV";
            buttonGiveGroup_YVV.Size = new Size(117, 73);
            buttonGiveGroup_YVV.TabIndex = 4;
            buttonGiveGroup_YVV.Text = "Добавить";
            toolTip_YVV.SetToolTip(buttonGiveGroup_YVV, "Добавить дополнительную группу");
            buttonGiveGroup_YVV.UseVisualStyleBackColor = false;
            buttonGiveGroup_YVV.Click += buttonAddGroup_Click;
            // 
            // buttonAddSubject_YVV
            // 
            buttonAddSubject_YVV.BackColor = Color.LightGreen;
            buttonAddSubject_YVV.FlatAppearance.BorderSize = 0;
            buttonAddSubject_YVV.FlatStyle = FlatStyle.Flat;
            buttonAddSubject_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonAddSubject_YVV.ForeColor = Color.Black;
            buttonAddSubject_YVV.Location = new Point(38, 383);
            buttonAddSubject_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonAddSubject_YVV.Name = "buttonAddSubject_YVV";
            buttonAddSubject_YVV.Size = new Size(117, 73);
            buttonAddSubject_YVV.TabIndex = 5;
            buttonAddSubject_YVV.Text = "Добавить";
            toolTip_YVV.SetToolTip(buttonAddSubject_YVV, "Добавить дополнительный предмет");
            buttonAddSubject_YVV.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteGroup_YVV
            // 
            buttonDeleteGroup_YVV.BackColor = Color.IndianRed;
            buttonDeleteGroup_YVV.FlatAppearance.BorderSize = 0;
            buttonDeleteGroup_YVV.FlatStyle = FlatStyle.Flat;
            buttonDeleteGroup_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonDeleteGroup_YVV.ForeColor = Color.Black;
            buttonDeleteGroup_YVV.Location = new Point(169, 159);
            buttonDeleteGroup_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteGroup_YVV.Name = "buttonDeleteGroup_YVV";
            buttonDeleteGroup_YVV.Size = new Size(117, 73);
            buttonDeleteGroup_YVV.TabIndex = 6;
            buttonDeleteGroup_YVV.Text = "Удалить";
            toolTip_YVV.SetToolTip(buttonDeleteGroup_YVV, "Удалить выбранную групп");
            buttonDeleteGroup_YVV.UseVisualStyleBackColor = false;
            buttonDeleteGroup_YVV.Click += buttonDeleteGroup_YVV_Click;
            // 
            // buttonDeleteSubject_YVV
            // 
            buttonDeleteSubject_YVV.BackColor = Color.IndianRed;
            buttonDeleteSubject_YVV.FlatAppearance.BorderSize = 0;
            buttonDeleteSubject_YVV.FlatStyle = FlatStyle.Flat;
            buttonDeleteSubject_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonDeleteSubject_YVV.ForeColor = Color.Black;
            buttonDeleteSubject_YVV.Location = new Point(169, 383);
            buttonDeleteSubject_YVV.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteSubject_YVV.Name = "buttonDeleteSubject_YVV";
            buttonDeleteSubject_YVV.Size = new Size(117, 73);
            buttonDeleteSubject_YVV.TabIndex = 7;
            buttonDeleteSubject_YVV.Text = "Удалить";
            toolTip_YVV.SetToolTip(buttonDeleteSubject_YVV, "Удалить данный предмет");
            buttonDeleteSubject_YVV.UseVisualStyleBackColor = false;
            // 
            // dataGridView_YVV
            // 
            dataGridView_YVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_YVV.Location = new Point(472, 16);
            dataGridView_YVV.Margin = new Padding(3, 4, 3, 4);
            dataGridView_YVV.Name = "dataGridView_YVV";
            dataGridView_YVV.RowHeadersWidth = 51;
            dataGridView_YVV.Size = new Size(639, 716);
            dataGridView_YVV.TabIndex = 8;
            // 
            // comboBoxGroup_YVV
            // 
            comboBoxGroup_YVV.BackColor = SystemColors.GradientActiveCaption;
            comboBoxGroup_YVV.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroup_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            comboBoxGroup_YVV.ForeColor = Color.DarkSlateGray;
            comboBoxGroup_YVV.FormattingEnabled = true;
            comboBoxGroup_YVV.Location = new Point(38, 108);
            comboBoxGroup_YVV.Margin = new Padding(3, 4, 3, 4);
            comboBoxGroup_YVV.Name = "comboBoxGroup_YVV";
            comboBoxGroup_YVV.Size = new Size(335, 32);
            comboBoxGroup_YVV.TabIndex = 9;
            comboBoxGroup_YVV.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            // 
            // comboBoxSubjects_YVV
            // 
            comboBoxSubjects_YVV.BackColor = SystemColors.GradientActiveCaption;
            comboBoxSubjects_YVV.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubjects_YVV.Font = new Font("Arial", 12F, FontStyle.Bold);
            comboBoxSubjects_YVV.ForeColor = Color.DarkSlateGray;
            comboBoxSubjects_YVV.FormattingEnabled = true;
            comboBoxSubjects_YVV.Location = new Point(38, 327);
            comboBoxSubjects_YVV.Margin = new Padding(3, 4, 3, 4);
            comboBoxSubjects_YVV.Name = "comboBoxSubjects_YVV";
            comboBoxSubjects_YVV.Size = new Size(335, 32);
            comboBoxSubjects_YVV.TabIndex = 10;
            comboBoxSubjects_YVV.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            // 
            // toolTip_YVV
            // 
            toolTip_YVV.IsBalloon = true;
            toolTip_YVV.Tag = "";
            toolTip_YVV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_YVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1281, 896);
            Controls.Add(buttonDetails_YVV);
            Controls.Add(buttonPerformance_YVV);
            Controls.Add(buttonAddRow_YVV);
            Controls.Add(buttonDeleteRow_YVV);
            Controls.Add(buttonAddColumn_YVV);
            Controls.Add(buttonDeleteColumn_YVV);
            Controls.Add(comboBoxSubjects_YVV);
            Controls.Add(comboBoxGroup_YVV);
            Controls.Add(dataGridView_YVV);
            Controls.Add(buttonDeleteSubject_YVV);
            Controls.Add(buttonDeleteGroup_YVV);
            Controls.Add(buttonAddSubject_YVV);
            Controls.Add(buttonGiveGroup_YVV);
            Controls.Add(subject_YVV);
            Controls.Add(group_YVV);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ТИУ - Журнал оценок";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDetails_YVV;
        private Button buttonPerformance_YVV;
        private Button buttonAddRow_YVV;
        private Button buttonDeleteRow_YVV;
        private Button buttonAddColumn_YVV;
        private Button buttonDeleteColumn_YVV;
        private Label group_YVV;
        private Label subject_YVV;
        private Button buttonGiveGroup_YVV;
        private Button buttonAddSubject_YVV;
        private Button buttonDeleteGroup_YVV;
        private Button buttonDeleteSubject_YVV;
        private DataGridView dataGridView_YVV;
        private ComboBox comboBoxGroup_YVV;
        private ComboBox comboBoxSubjects_YVV;
        private ToolTip toolTip_YVV;
        private OpenFileDialog openFileDialog_YVV;
    }
}