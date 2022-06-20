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
            ListViewUsers.ItemsSource = Repository.bankClients.Where(Find);

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

        private bool Find(BankClient arg)
        {
            return arg.DepartmentId == (ComboBoxUsers.SelectedItem as Department).DepartmentId;
        }

        public int FindClientId()
        {
            int BankClientId = (ListViewUsers.SelectedItem as BankClient).ClientId;
            return BankClientId;
        }

        public BankClient FindClient()
        {
            BankClient bankClient = new BankClient();
            bankClient = ListViewUsers.SelectedItem as BankClient;
            return bankClient;
        }

        public int FindDepartment()
        {
            int DepartmentId = (ComboBoxUsers.SelectedItem as Department).DepartmentId;
            return DepartmentId;
        }

        /// <summary>
        /// Поиск руководителя
        /// </summary>
        /// <returns></returns>
        private string FindWorker()
        {
            var ponit = check();
            string checkName;
            var dara = Repository.RepositorySupervisor();
            if (ponit == 0)
            {
                checkName = dara[0].Name;
            }
            else
            {
                checkName = dara[1].Name;
            }

            return checkName;
        }

        /// <summary>
        /// Узнаем что делали с сотрудником
        /// </summary>
        /// <returns></returns>
        private string DeleteEditing(int numb)
        {
            string ForWhat;
            if (numb == 0)
            {
                ForWhat = "Редактирование";
            }
            else
            {
                ForWhat = "Добавление";
            }
            return ForWhat;
        }

        /// <summary>
        /// Кнопка редактирования ПКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditClick(object sender, RoutedEventArgs e)
        {
            ModificationData data = new ModificationData();
            data.EditClientData(FindClient(), FindWorker(), DeleteEditing(0));
            EditAddDeleteWindow.EditWorker(FindClient(), FindDepartment());
            EditAddDeleteWindow.InWorkerId(FindClientId());
            

        }

        /// <summary>
        /// Кнопка удаление ПКМ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            EditAddDeleteWindow.DelWorker(FindClient());
            MessageBox.Show($"Удален: {FindClient().Name}");
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
            changeTimeWindow.WhatChanged(FindClient());
        }

        private void ListViewUsers_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }
    }
}
