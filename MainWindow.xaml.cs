using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KPZ_Lab03CF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentCF dBEntities;
        List<Student> prevStudents;
        List<Student> currentStudents;
        public MainWindow()
        {
            InitializeComponent();
            dBEntities = new StudentCF();
            StudentTable.ItemsSource = dBEntities.Students.ToList();
            prevStudents = dBEntities.Students.ToList();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            currentStudents = new List<Student>();

            for (int i = 0; i<StudentTable.Items.Count; ++i)
            {
                currentStudents.Add(StudentTable.Items[i] as Student);
                if (currentStudents[i] == null)
                {
                    currentStudents.Remove(currentStudents[i]);
                }
            }
            //Зрівнювати зміни і редагувати

            for (int i = 0; i<prevStudents.Count; ++i)
            {
                bool check = false;
                for (int j = 0; j<currentStudents.Count; ++j)
                {

                    if (prevStudents[i].Name == currentStudents[j].Name)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    dBEntities.Students.Remove(prevStudents[i]);
                }
            }

            for (int i = 0; i<currentStudents.Count; ++i)
            {
                bool check = false;
                for (int j = 0; j<prevStudents.Count; ++j)
                {
                    if (currentStudents[i].Name == prevStudents[j].Name)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                {
                    dBEntities.Students.Add(currentStudents[i]);
                }
            }

            dBEntities.SaveChanges();
        }
    }
}
