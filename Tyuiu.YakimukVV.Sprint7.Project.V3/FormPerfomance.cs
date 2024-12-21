using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.YakimukVV.Sprint7.Project.V3
{
    public partial class FormPerformance : Form
    {
        private string groupName;
        private string databasePath;
        private DataTable groupData;

        public FormPerformance(string groupName, string databasePath, DataTable groupData)
        {
            InitializeComponent();
            this.groupName = groupName;
            this.databasePath = databasePath;
            this.groupData = groupData;

            LoadPerformanceData();
        }

        private void LoadPerformanceData()
        {
            double totalScore = 0;
            int studentCount = 0;

            double highestScore = double.MinValue;
            double lowestScore = double.MaxValue;
            string highestScoreStudent = "";
            string lowestScoreStudent = "";

            foreach (DataRow row in groupData.Rows)
            {
                if (row["ФИО"] != null && double.TryParse(row["Оценка"].ToString(), out double score))
                {
                    string studentName = row["ФИО"].ToString();

                    string[] nameParts = studentName.Split(' ');

                    if (nameParts.Length >= 2) 
                    {
                        string formattedName;

                        if (nameParts.Length >= 3)
                        {
                            formattedName = $"{nameParts[0]} {nameParts[1][0]}.{nameParts[2][0]}";
                        }
                        else
                        {
                            formattedName = $"{nameParts[0]} {nameParts[1][0]}";
                        }

                        totalScore += score;
                        studentCount++;

                        if (score > highestScore)
                        {
                            highestScore = score;
                            highestScoreStudent = formattedName;
                        }

                        if (score < lowestScore)
                        {
                            lowestScore = score;
                            lowestScoreStudent = formattedName;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Некорректное ФИО: {studentName}. Пропускаем этого студента.",
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            double averageScore = studentCount > 0 ? totalScore / studentCount : 0.0;


            labelAverage.Text = $"Средний балл группы \"{groupName}\": {averageScore:F2}";
            labelCount.Text = $"Количество учащихся группы \"{groupName}\": {studentCount}";
            labelHighest.Text = $"Высший балл группы {highestScoreStudent}: {highestScore:F2}";
            labelLowest.Text = $"Низший балл группы {lowestScoreStudent}: {lowestScore:F2}";

        }
    }
}
