using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.Sqlite;

namespace PDA2._0_
{
    /// <summary>
    /// Логика взаимодействия для TasksPage.xaml
    /// </summary>
    public partial class TasksPage : Page
    {
        public TasksPage()
        {
            InitializeComponent();
            openTask.Content = new OpenTask();
            ReadDB();
        }

        public void ReadDB()
        {
            List<Task> listOfTasks = new List<Task>();
            string sqlExpression = "SELECT * FROM Tasks";
            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            var id = reader.GetValue(0);
                            var name = reader.GetValue(1);
                            var date = reader.GetValue(2);
                            var text = reader.GetValue(3);
                            Label nameLabel = new Label();
                            nameLabel.Content = name.ToString();
                            nameLabel.Foreground = new SolidColorBrush(Colors.White);
                            Label idLabel = new Label();
                            idLabel.Content = id.ToString();
                            idLabel.Foreground = new SolidColorBrush(Colors.White);
                            StackPanel stackPanel = new StackPanel();
                            stackPanel.Children.Add(idLabel);
                            stackPanel.Children.Add(nameLabel);
                            stackPanel.Orientation = Orientation.Horizontal;
                            tasksList.Items.Add(stackPanel);
                        }
                    }
                }
            }
        }
    }
}
