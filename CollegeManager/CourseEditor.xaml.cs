using CollegeServer.Entities;
using System.Windows;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Threading.Tasks;

namespace CollegeManager
{
    public partial class CourseEditor : Window
    {
        HttpClient client = new HttpClient();
        List<TeacherCourseTheme> themes = new List<TeacherCourseTheme>();
        List<TeacherCourse> teacherCourses = new List<TeacherCourse>();
        List<Teachers> teachersList = new List<Teachers>();
        public IEnumerable<Users> teachers = null;
        Courses course = null;

        public CourseEditor(Courses course)
        {
            InitializeComponent();
            if (course!=null)
            {
                this.course = course;
                NameTB.Text = course.Name;
                StartDateDP.SelectedDate = course.StartDate;
                EndDateDP.SelectedDate = course.EndDate;
                TargetHoursTB.Text = course.TargetHours.ToString();
                PassedHoursTB.Text = course.PassedHours.ToString();
                LocatonTB.Text = course.Location;
                GetThemes(course.Id, true);
            }
            GetUsers();
            GetTeacherCourses();
            GetTeachers();
        }

        private async void GetTeachers()
        {
            string result = await client.GetStringAsync("https://localhost:44384/teachers");
            teachersList = JsonConvert.DeserializeObject<List<Teachers>>(result);
            //this.DataContext = teachersList;
        }

        private async void GetTeacherCourses()
        {
            string result = await client.GetStringAsync("https://localhost:44384/teachercourse");
            teacherCourses = JsonConvert.DeserializeObject<List<TeacherCourse>>(result);
        }

        private async void GetUsers()
        {
            string result = await client.GetStringAsync("https://localhost:44384/users");
            teachers = JsonConvert.DeserializeObject<List<Users>>(result).Where(u => u.Type.Name == "Teacher" || u.Type.Name == "Admin").ToList();
            this.DataContext = teachers;
        }

        public async Task GetThemes(int Id, bool update)
        {
            string result = await client.GetStringAsync("https://localhost:44384/course/themes/" + Id);
            themes = JsonConvert.DeserializeObject<List<TeacherCourseTheme>>(result).ToList();
            if (update)
            {
                ThemesLB.SelectedValuePath = "Id";
                ThemesLB.ItemsSource = themes;
            }
        }

        private async void Move_Click(object sender, RoutedEventArgs e)
        {
            if (Move.Content.ToString() == "Назад")
            {
                AddTheme.IsEnabled = false;
                NameTB.IsEnabled = true;
                StartDateDP.IsEnabled = true;
                EndDateDP.IsEnabled = true;
                TargetHoursTB.IsEnabled = true;
                LocatonTB.IsEnabled = true;
                PassedHoursTB.IsEnabled = true;
                ThemesLB.IsEnabled = false;
                Move.Content = "Далее";
                return;
            }
            if (course != null)
            {
                try
                {
                    string request = JsonConvert.SerializeObject(new Courses(course.Id, NameTB.Text, LocatonTB.Text, StartDateDP.SelectedDate.Value, EndDateDP.SelectedDate.Value, Convert.ToInt32(TargetHoursTB.Text), Convert.ToInt32(PassedHoursTB.Text)));
                    var response = await client.PutAsync("https://localhost:44384/courses/", new StringContent(request, Encoding.UTF8, "application/json"));
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
            }
            else
            {
                try
                {
                    course = new Courses(0, NameTB.Text, LocatonTB.Text, StartDateDP.SelectedDate.Value, EndDateDP.SelectedDate.Value, Convert.ToInt32(TargetHoursTB.Text), Convert.ToInt32(PassedHoursTB.Text));
                    string request = JsonConvert.SerializeObject(course);
                    var response = await client.PostAsync("https://localhost:44384/courses/", new StringContent(request, Encoding.UTF8, "application/json"));
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
            }
            AddTheme.IsEnabled = true;
            NameTB.IsEnabled = false;
            StartDateDP.IsEnabled = false;
            EndDateDP.IsEnabled = false;
            TargetHoursTB.IsEnabled = false;
            LocatonTB.IsEnabled = false;
            PassedHoursTB.IsEnabled = false;
            ThemesLB.IsEnabled = true;
            Move.Content = "Назад";
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddTheme_Click(object sender, RoutedEventArgs e)
        {
            themes.Add(new TeacherCourseTheme(0, null, ""));
            ThemesLB.Items.Refresh();
        }

        private async void EditTheme_Click(object sender, RoutedEventArgs e)
        {
            Button B = (sender as Button);
            string Ids = B.Tag.ToString();
            int Idi = Convert.ToInt32(B.Tag.ToString());
            TextBox TB = FindVisualChilds<TextBox>(this).Where(x => x.Tag != null && x.Tag.ToString() == Ids).ToList()[0];
            ComboBox CB = FindVisualChilds<ComboBox>(this).Where(x => x.Tag != null && x.Tag.ToString() == Ids).ToList()[0];
            if (B.Content.ToString()=="Редактировать")
            {
                TB.IsEnabled = true;
                CB.IsEnabled = true;
                B.Content = "Сохранить";
                return;
            }
            TB.IsEnabled = false;
            CB.IsEnabled = false;
            try
            {
                int userId = Convert.ToInt32(CB.SelectedValue);
                var course = teacherCourses.FirstOrDefault(t => t.Teacher.User.Id == userId);
                //await GetThemes(course.Id, false);
                TeacherCourseTheme theme = themes.FirstOrDefault(t => t.Id == userId);
                if (course != null)
                {
                    string request = JsonConvert.SerializeObject(new TeacherCourseTheme(Idi, course, TB.Text));
                    await client.PutAsync("https://localhost:44384/course/themes/", new StringContent(request, Encoding.UTF8, "application/json"));
                    if (theme == null)
                    {
                        request = JsonConvert.SerializeObject(new TeacherCourseTheme(0, course, TB.Text));
                        await client.PostAsync("https://localhost:44384/course/themes/", new StringContent(request, Encoding.UTF8, "application/json"));
                        ThemesLB.Items.Refresh();
                    }
                }
                else
                {
                    Teachers teacher = teachersList.FirstOrDefault(t => t.User.Id == userId);
                    course = new TeacherCourse(0, teacher, this.course, 0, false);
                    string request = JsonConvert.SerializeObject(course);
                    await client.PostAsync("https://localhost:44384/teachercourse/", new StringContent(request, Encoding.UTF8, "application/json"));

                    request = JsonConvert.SerializeObject(new TeacherCourseTheme(0, course, TB.Text));
                    await client.PostAsync("https://localhost:44384/course/themes/", new StringContent(request, Encoding.UTF8, "application/json"));
                    ThemesLB.Items.Refresh();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
                return;
            }
            B.Content = "Редактировать";
        }

        public IEnumerable<T> FindVisualChilds<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj == null) yield return (T)Enumerable.Empty<T>();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
            {
                DependencyObject ithChild = VisualTreeHelper.GetChild(depObj, i);
                if (ithChild == null) continue;
                if (ithChild is T t) yield return t;
                foreach (T childOfChild in FindVisualChilds<T>(ithChild)) yield return childOfChild;
            }
        }

        private void TeachersTB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBox CB = (sender as ComboBox);
            //var Id = B.Tag.ToString();
            //TeacherCourseTheme theme = themes.FirstOrDefault(t => t.Id == ID);
        }
    }
}
