using DZ_SkillBox_11.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DZ_SkillBox_11.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Repository data;
        public static int CombWiw;
        /// <summary>
        /// Проверка вывода данных в listView
        /// </summary>
        public static int numbers = 1;
        public static int numberAdd = 1;


        public MainWindow()
        {
            InitializeComponent();
            if (numbers == 1)
            {
                Data();
                numbers = 0;
            }
           
                   
        }

        private void Data()
        {
            data = Repository.CreateRepository();
            ComboBoxUsers.ItemsSource = Repository.departments;
            var data1 = Repository.RepositorySupervisor();
            ComboBoxWiw.ItemsSource = data1;
            ComboBoxUsers.IsEnabled = false;
        }

        /// <summary>
        /// Проверка на доступ сотрудников со всей информацией
        /// </summary>
        private void Create()
        {
            CombWiw = check();

            if (CombWiw == 0)
            {
                ComboBoxUsers.SelectedItem = Repository.departments;
            }
            else if (CombWiw == 1)
            {
                ComboBoxUsers.SelectedItem = Repository.departments;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Обновление по кнопке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxUsers.Items.Refresh();
            ListViewUsers.Items.Refresh();     
        }



        private void ListWiwer_MouseButton(object sender, MouseButtonEventArgs e)
        {

        }

        /// <summary>
        /// Проверка на доступ к выбору департамента
        /// </summary>
        /// <returns></returns>
        public int check()
        {
            var point = ComboBoxWiw.SelectedIndex;

            if (point == 0 || point == 1)
            {
                ComboBoxUsers.IsEnabled = true;
            }

            return point;
        }


        /// <summary>
        /// Вывод списка сотрудников в зависимости от департамента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewUsers.ItemsSource = Repository.workers.Where(find);
            
        }


        /// <summary>
        /// Проверка на доступ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxWiw_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool checked1 = true;
            check();
            while (checked1)
            {
                if (CombWiw == 0)
                {
                    Create();
                    checked1 = false;
                }
                if (CombWiw == 1)
                {
                    Create();
                    checked1 = false;
                }
                if (CombWiw == -1)
                {
                    checked1 = true;
                }
            }
        }

        private bool find(Worker arg)
        {
            return arg.DepartmentId == (ComboBoxUsers.SelectedItem as Department).DepartmentId;
        }

        public int FindWorkerId()
        {
            int WorkerId = (ListViewUsers.SelectedItem as Worker).WorkerId;
            return WorkerId;
        }

        public Worker FindWorker()
        {
            Worker worker = new Worker();
            worker = ListViewUsers.SelectedItem as Worker;
            return worker;  
        }

        public int FindDepartment()
        {    
            int DepartmentId = (ComboBoxUsers.SelectedItem as Department).DepartmentId;
            return DepartmentId;
        }

        /// <summary>
        /// Кнопка редактирования ПКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditClick(object sender, RoutedEventArgs e)
        {
            EditAddDeleteWindow.EditWorker(FindWorker(), FindDepartment());
            EditAddDeleteWindow.InWorkerId(FindWorkerId());
            ChangeProperties change = new ChangeProperties();
            change.Changed(CombWiw);
        }

        /// <summary>
        /// Кнопка удаление ПКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            EditAddDeleteWindow.DelWorker(FindWorker());
            MessageBox.Show($"Удален: {FindWorker().Name}");
        }

        /// <summary>
        /// Кнопка добавления ПКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClick(object sender, RoutedEventArgs e)
        {
            numberAdd = 0;
            EditAddDeleteWindow editAdd = new EditAddDeleteWindow();            
            editAdd.Show();
            editAdd.InputWorkerAdd();
            ChangeProperties change = new ChangeProperties();
            change.Changed(CombWiw);
            
        }

        private void ListViewUsers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        /// <summary>
        /// Кпока вызова окна свойства
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PropirtiesClick(object sender, RoutedEventArgs e)
        {
            ChangeTimeWindow changeTimeWindow = new ChangeTimeWindow();
            changeTimeWindow.Show();
        }

        private void ListViewUsers_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }
    }
}
