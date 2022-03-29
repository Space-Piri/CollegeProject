using CollegeServer.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CollegeManager
{
    public partial class AdminWindow : Window
    {
        HttpClient client = new HttpClient();
        List<Courses> courses = new List<Courses>();

        public AdminWindow()
        {
            InitializeComponent();
            GetCourses();
        }

        public async void GetCourses()
        {
            string result = await client.GetStringAsync("https://localhost:44384/courses");
            courses = JsonConvert.DeserializeObject<List<Courses>>(result);
            LBCourses.SelectedValuePath = "Id";
            LBCourses.ItemsSource = courses;
        }

        private void SearchButton_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {
            CourseEditor courseEditor = new CourseEditor(null);
            courseEditor.Title = "Создание курса";
            courseEditor.ShowDialog();
            LBCourses.Items.Refresh();
        }

        private void CourseEdit_Click(object sender, RoutedEventArgs e)
        {
            var Id = int.Parse((sender as Button).Tag.ToString());
            CourseEditor courseEditor = new CourseEditor(courses.FirstOrDefault(c => c.Id == Id));
            courseEditor.Title = "Редактирование курса";
            courseEditor.ShowDialog();
            LBCourses.Items.Refresh();
        }
    }
}
