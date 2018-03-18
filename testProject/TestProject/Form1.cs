using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Чистка датагрида
            dGV.Rows.Clear();
            //Вызов функций
            File_load();
            wrd_count();
        }

        //Объявление глобального списка
        List<string> wrd_list = new List<string>();
        //Функция чтения файла по строчно + составения списка всех слов (С повторениями)
        public void File_load()
        {
            //Обьявление переменных для подсчета
            int wrd_counter = 0;
            int str_counter = 0;
            string line;
            //Разделители строк на слова
            string[] sp = new string[] { ",", ".", "!", "\'", " ", "\'s", ":", "(","-",")" ,"|" ,"/"};
            //Фильтр для формы открытия файла 
            openFileDialog1.Filter = "Text Files|*.txt";
            openFileDialog1.Title = "Select a txt File";
            //Считывание файла
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Считывание текстового файла
                System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
                //По строчная обработка
                while ((line = file.ReadLine()) != null)
                {
                    str_counter++;
                    //Разделение строк на слова
                    foreach (string words in line.Split(sp, StringSplitOptions.RemoveEmptyEntries))
                    {
                        //Проверка слов на наличие символов не удовлетворящих условиям
                        if (words.All(char.IsLetterOrDigit))
                        {
                            //Добавление слов в список
                            wrd_list.Add(words);
                            wrd_counter++;
                        }
                    }
                }
            //Вывод на форму
            wrd_count_label.Text = Convert.ToString(wrd_counter);
            line_count_label.Text = Convert.ToString(str_counter);
            file.Close();
            }
        }
        Dictionary<string, int> counts = new Dictionary<string, int>();
        //Функция подсчета слов в списке составленном в функции file_load
        public void wrd_count()
        {
            //Для каждого значения в списке слов выполняется подсчет в тексте
            foreach (string value in wrd_list)
            {
                if (counts.ContainsKey(value))
                    counts[value] = counts[value] + 1;
                else
                    counts.Add(value, 1);
            }
            //Вывод в датагрид 
            BindingSource bgS = new BindingSource();
            dGV.DataSource = bgS;
            bgS.DataSource = counts;
        }
        //Запись в файл
        public void wrds_to_file()
        {
           // string path = @"C:\Test.txt";
            System.IO.File.Delete(@"C:\test.txt");
            //Запрос на сортировку
            if (Sort_check.Checked == true)
            {
                //Сортировка с помощью linq
                var sortedCounts = from entry in counts orderby entry.Value descending select entry;
                //Запись в файл с сортировкой
                foreach (KeyValuePair<string, int> kvp in sortedCounts)
                {
                    System.IO.File.AppendAllText("Test.txt", string.Format("{0} {1} {2}", kvp.Key, kvp.Value, Environment.NewLine));
                }
            }
            else
                //Запись в файл без сортировки
                foreach (KeyValuePair<string, int> kvp in counts)
                {
                    System.IO.File.AppendAllText("Test.txt", string.Format("{0} {1} {2}", kvp.Key, kvp.Value, Environment.NewLine));
                }

        //Открытие файла после сохранения
        //Настроки окна сообщения
        DialogResult result = MessageBox.Show(
        "Файл сохранен. Открыть?",
        "Сообщение",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);

        //Если "Да", то открыть файл
        if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("Test.txt");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wrds_to_file();
        }
    }
}