using System.Data;
using Tyuiu.YakimukVV.Sprint7.Project.V3.Lib;

namespace Tyuiu.YakimukVV.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        private string databasePath = @"C:\База данных";
        private string currentFilePath;
        private Dictionary<string, string> subjectDetails = new Dictionary<string, string>
    {
        { "Алгебра и геометрия", "Преподаватель: Панченко Наталья Борисовна\nАудитории: 512/524\nКоличество часов: 144" },
        { "Дискретная математика", "Преподаватель: Терехова Наталья Владимировна\nАудитории: 304/522\nКоличество часов: 96" },
        { "Иностранный язык", "Преподаватель: Медведева Инесса Александровна\nАудитория: 502\nКоличество часов: 70" },
        { "Математический анализ", "Преподаватель: Панченко Наталья Борисовна\nАудитории: 512/524\nКоличество часов: 144" },
        { "Основы российской государственности", "Преподаватель: Крючева Яна Владимировна\nАудитория: 1212\nКоличество часов: 96" },
        { "Программирование", "Преподаватель: Пряхина Елена Николаевна\nАудитория: 1104\nКоличество часов: 88" },
        { "Проектная деятельность", "Преподаватель: Игнатюк Юлия Леонидовна\nАудитория: 1012\nКоличество часов: 96" },
        { "Теоретическая и прикладная информатика", "Преподаватель: Панченко Наталья Борисовна\nАудитория: 515\nКоличество часов: 144" },
        { "Физическая культура и спорт", "Преподаватель: Тимканов Ренат Рашитович\nАудитория: 3(к)\nКоличество часов: 102" }
    };


        public FormMain()
        {
            InitializeComponent();
            comboBoxGroup_YVV.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            comboBoxSubjects_YVV.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;
            buttonDeleteGroup_YVV.Enabled = false;
            buttonDeleteSubject_YVV.Enabled = false;
            buttonAddSubject_YVV.Click += buttonAddSubject_YVV_Click;
            buttonDeleteSubject_YVV.Enabled = false;
            comboBoxSubjects_YVV.SelectedIndexChanged += comboBoxSubjects_YVV_SelectedIndexChanged;
            dataGridView_YVV.CellValueChanged += DataGridView_YVV_CellValueChanged;
            buttonAddSubject_YVV.Enabled = false;
            comboBoxGroup_YVV.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            buttonDeleteSubject_YVV.Click += buttonDeleteSubject_YVV_Click;
            buttonAddRow_YVV.Click += ButtonAddRow_YVV_Click;
            buttonDeleteRow_YVV.Click += ButtonDeleteRow_YVV_Click;
            buttonAddColumn_YVV.Click += ButtonAddColumn_YVV_Click;
            buttonDeleteColumn_YVV.Click += ButtonDeleteColumn_YVV_Click;
            buttonPerformance_YVV.Click += ButtonPerformance_YVV_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxGroup_YVV.Items.Add("ИИПб-24-1");
            comboBoxGroup_YVV.Items.Add("РППб-24-1");
            comboBoxGroup_YVV.Items.Add("ИБКСб-24-1");
            comboBoxGroup_YVV.Items.Add("АСОиУб-24-1");
            comboBoxGroup_YVV.Items.Add("ИСТНб-24-1");
        }

        private void ButtonAddRow_YVV_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView_YVV.DataSource as DataTable;
            if (dt != null)
            {
                dt.Rows.Add(dt.NewRow());
            }
        }
        private void ButtonDeleteRow_YVV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_YVV.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView_YVV.Rows.Remove(row);
                }
            }
        }
        private void ButtonPerformance_YVV_Click(object sender, EventArgs e)
        {
            if (comboBoxGroup_YVV.SelectedItem != null)
            {
                string group = comboBoxGroup_YVV.SelectedItem.ToString();

                DataTable table = dataGridView_YVV.DataSource as DataTable;

                if (table != null)
                {
                    FormPerformance performanceForm = new FormPerformance(group, databasePath, table);
                    performanceForm.Show();
                }
                else
                {
                    MessageBox.Show("Нет данных для отображения успеваемости.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите группу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAddColumn_YVV_Click(object sender, EventArgs e)
        {
            string columnName = Prompt.ShowDialog("Введите имя нового столбца:", "Добавление столбца");

            if (!string.IsNullOrWhiteSpace(columnName))
            {
                if (!dataGridView_YVV.Columns.Contains(columnName))
                {
                    DataGridViewTextBoxColumn columnIndex = new DataGridViewTextBoxColumn
                    {
                        HeaderText = columnName,
                        Name = columnName
                    };

                    dataGridView_YVV.Columns.Add(columnIndex);
                }
                else
                {
                    MessageBox.Show($"Столбец с именем \"{columnName}\" уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Имя столбца не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteColumn_YVV_Click(object sender, EventArgs e)
        {
            if (dataGridView_YVV.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView_YVV.SelectedCells[0].ColumnIndex;
                foreach (DataGridViewCell cell in dataGridView_YVV.SelectedCells)
                {
                    if (cell.ColumnIndex != columnIndex)
                    {
                        MessageBox.Show("Выберите ячейки только из одного столбца для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                dataGridView_YVV.Columns.RemoveAt(columnIndex);
            }
            else
            {
                MessageBox.Show("Выберите хотя бы одну ячейку в столбце для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSubjects_YVV.Items.Clear();

            if (comboBoxGroup_YVV.SelectedItem != null)
            {
                string group = comboBoxGroup_YVV.SelectedItem.ToString();
                string[] subjects = GetSubjectsForGroup(group);

                if (subjects.Length > 0)
                {
                    comboBoxSubjects_YVV.Items.AddRange(subjects);
                }
            }

            if (comboBoxGroup_YVV.SelectedItem != null)
            {
                buttonDeleteGroup_YVV.Enabled = true;
            }
            else
            {
                buttonDeleteGroup_YVV.Enabled = false;
            }
            if (comboBoxGroup_YVV.SelectedIndex >= 0)
            {
                buttonAddSubject_YVV.Enabled = true;
            }
            else
            {
                buttonAddSubject_YVV.Enabled = false;
            }
        }

        private string[] GetSubjectsForGroup(string group)
        {
            if (group == "ИИПб-24-1" || group == "РППб-24-1" || group == "ИБКСб-24-1" || group == "АСОиУб-24-1" || group == "ИСТНб-24-1")
            {
                return new string[]
                {
            "Алгебра и геометрия",
            "Дискретная математика",
            "Иностранный язык",
            "Математический анализ",
            "Основы российской государственности",
            "Программирование",
            "Проектная деятельность",
            "Теоретическая и прикладная информатика",
            "Физическая культура и спорт"
                };
            }
            return new string[0];

        }
        private void comboBoxSubjects_YVV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubjects_YVV.SelectedItem != null)
            {
                buttonDeleteSubject_YVV.Enabled = true;
            }
            else
            {
                buttonDeleteSubject_YVV.Enabled = false;
            }
        }

        public void LoadDataToGridView(string group, string subject)
        {
            string fileName = $"{group}_{subject}.csv";
            string filePath = Path.Combine(databasePath, fileName);

            if (File.Exists(filePath))
            {
                LoadCsvToDataGridView(filePath);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Файл {fileName} не найден. Создать новый файл?",
                                                      "Файл не найден", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string studentsListPath = Path.Combine(databasePath, $"Список_{group}.csv");

                    if (File.Exists(studentsListPath))
                    {
                        string[] students = File.ReadAllLines(studentsListPath);

                        using (StreamWriter sw = new StreamWriter(filePath))
                        {
                            sw.WriteLine("ФИО,Оценка,Примечание");

                            foreach (string student in students)
                            {
                                sw.WriteLine($"{student},,");
                            }
                        }

                        LoadCsvToDataGridView(filePath);
                    }
                    else
                    {
                        MessageBox.Show($"Файл со списком студентов для группы {group} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            currentFilePath = filePath;
            try
            {
                DataTable csvData = new DataTable();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        csvData.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        csvData.Rows.Add(rows);
                    }
                }

                dataGridView_YVV.DataSource = csvData;
                dataGridView_YVV.Columns[0].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGroup_YVV.SelectedItem != null && comboBoxSubjects_YVV.SelectedItem != null)
            {
                string group = comboBoxGroup_YVV.SelectedItem.ToString();
                string subject = comboBoxSubjects_YVV.SelectedItem.ToString();

                LoadDataToGridView(group, subject);
            }
        }
        private void DataGridView_YVV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SaveDataGridViewToCsv(currentFilePath);
        }

        private void SaveDataGridViewToCsv(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    string[] columnNames = dataGridView_YVV.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(column => column.HeaderText)
                        .ToArray();
                    sw.WriteLine(string.Join(",", columnNames));

                    foreach (DataGridViewRow row in dataGridView_YVV.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] rowData = row.Cells
                                .Cast<DataGridViewCell>()
                                .Select(cell => cell.Value?.ToString() ?? "")
                                .ToArray();
                            sw.WriteLine(string.Join(",", rowData));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            FormAddGroup addGroupForm = new FormAddGroup();

            if (addGroupForm.ShowDialog() == DialogResult.OK)
            {
                string newGroupName = addGroupForm.GroupName;

                if (!comboBoxGroup_YVV.Items.Contains(newGroupName))
                {
                    comboBoxGroup_YVV.Items.Add(newGroupName);
                }
                else
                {
                    MessageBox.Show("Группа с таким названием уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void buttonDeleteGroup_YVV_Click(object sender, EventArgs e)
        {
            if (comboBoxGroup_YVV.SelectedItem != null)
            {
                string selectedGroup = comboBoxGroup_YVV.SelectedItem.ToString();

                DialogResult result = MessageBox.Show($"Все предметы группы {selectedGroup} будут удалены. Вы уверены?",
                                                      "Подтверждение удаления",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    comboBoxGroup_YVV.Items.Remove(selectedGroup);
                    comboBoxSubjects_YVV.Items.Clear();
                    DeleteGroupFiles(selectedGroup);

                    MessageBox.Show($"Группа {selectedGroup} и все её предметы удалены.", "Удаление завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите группу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteGroupFiles(string group)
        {
            try
            {
                string[] files = Directory.GetFiles(databasePath, $"{group}_*.csv");

                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файлов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddSubject_YVV_Click(object sender, EventArgs e)
        {
            FormAddSubject addSubjectForm = new FormAddSubject();

            if (addSubjectForm.ShowDialog() == DialogResult.OK)
            {
                string newSubject = addSubjectForm.SubjectName;

                if (!comboBoxSubjects_YVV.Items.Contains(newSubject))
                {
                    comboBoxSubjects_YVV.Items.Add(newSubject);
                    MessageBox.Show($"Предмет '{newSubject}' успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Предмет '{newSubject}' уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonDeleteSubject_YVV_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects_YVV.SelectedItem != null)
            {
                string selectedSubject = comboBoxSubjects_YVV.SelectedItem.ToString();

                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить предмет \"{selectedSubject}\"?",
                                                      "Удаление предмета",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    comboBoxSubjects_YVV.Items.Remove(selectedSubject);
                    comboBoxSubjects_YVV.SelectedItem = null;
                    dataGridView_YVV.Columns.Clear();

                    if (comboBoxSubjects_YVV.Items.Count == 0)
                    {
                        buttonDeleteSubject_YVV.Enabled = false;
                    }
                }
            }
        }
        private void buttonDetails_YVV_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjects_YVV.SelectedItem != null)
            {
                string selectedSubject = comboBoxSubjects_YVV.SelectedItem.ToString();
                if (subjectDetails.TryGetValue(selectedSubject, out string details))
                {
                    FormDetails detailsForm = new FormDetails(details);
                    detailsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Информация о предмете отсутствует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите предмет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
