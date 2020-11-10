using System;
using System.Collections.Generic;
using System.Linq;
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

using System.Windows.Threading;

namespace DispatchTimerSampleInCS
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var testCollection = new List<Employee>
            { 
                new Employee{ EmployeeId = 1, EmpName = "Prashant", Qualification = "MCA", Marks = 10},
                new Employee{ EmployeeId = 3, EmpName = "Kishore", Qualification = "BTech", Marks = 120},
                new Employee{ EmployeeId = 4, EmpName = "Rahul", Qualification = "BA", Marks = 43},
                new Employee{ EmployeeId = 45, EmpName = "Naveen", Qualification = "MCA", Marks = 80},
                new Employee{ EmployeeId = 11, EmpName = "Deen", Qualification = "LLB", Marks = 10},
                new Employee{ EmployeeId = 10, EmpName = "Sumit", Qualification = "MA2", Marks = 23},
                new Employee{ EmployeeId = 6, EmpName = "Pratap", Qualification = "MCA", Marks = 10},
            };

            testCollection.OrderBy(x => x.EmployeeId).ThenBy(y => y.EmpName);
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //listBox1.Items.Add(DateTime.Now.Hour.ToString() + ":" +
            //    DateTime.Now.Second.ToString());
            
            //CommandManager.InvalidateRequerySuggested();
            //listBox1.Items.MoveCurrentToLast();
            //listBox1.SelectedItem = listBox1.Items.CurrentItem;
            //listBox1.ScrollIntoView(listBox1.Items.CurrentItem);
        }

    }
}
