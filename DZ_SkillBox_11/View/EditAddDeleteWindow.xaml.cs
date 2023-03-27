using DZ_SkillBox_11.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using static DZ_SkillBox_11.View.MainWindow;

namespace DZ_SkillBox_11.View
{


    /// <summary>
    /// Логика взаимодействия для EditAddDeleteWindow.xaml
    /// </summary>
    public partial class EditAddDeleteWindow : Window, IActionWhithTheClient
    {

        public static List<Worker> workers = new List<Worker>();


        public EditAddDeleteWindow()
        {
            InitializeComponent();
            AddEditCombobox.ItemsSource = Repository.departments;
            AccessToTextBox();
        }

        private void AddEditCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        void IActionWhithTheClient.AddClient(string name, string lastName, string patronymic, string numberPassport, string seriesPassport, string numberPhone, int DpId, int WorkerId)
        {
            List<BankClient> bankClient = new List<BankClient>();

            if (MainWindow.CombWiw == 1)
            {
                Manager manager = new Manager();

                manager.AddClient(name = InputName.Text,
                                        lastName =  InputLastName.Text,
                                           patronymic= InputPatronymic.Text,
                                           numberPassport= InputPssportNumber.Text,
                                           seriesPassport = InputPassportSeries.Text,
                                           numberPhone = InputPhoneNumber.Text,
                                           AddEditCombobox.SelectedIndex,
                                           bankClient.Count + 1
                                           );
            }
            else
            {
                Consultant consultant = new Consultant();
                consultant.AddClient(name = InputName.Text,
                                        lastName = InputLastName.Text,
                                           patronymic = InputPatronymic.Text,
                                           numberPassport = InputPssportNumber.Text,
                                           seriesPassport = InputPassportSeries.Text,
                                           numberPhone = InputPhoneNumber.Text,
                                           AddEditCombobox.SelectedIndex,
                                           bankClient.Count + 1
                                           );
            }
        }

        /// <summary>
        /// Добавление клиента через форму
        /// </summary>
        public void InputClientAdd()
        {
            List<BankClient> bankClient = new List<BankClient>();
         
            if (MainWindow.CombWiw == 1)
            {
                Manager manager = new Manager();
                
                manager.AddClient(InputName.Text,
                                           InputLastName.Text,
                                           InputPatronymic.Text,
                                           InputPssportNumber.Text,
                                           InputPassportSeries.Text,
                                           InputPhoneNumber.Text,
                                           AddEditCombobox.SelectedIndex,
                                           bankClient.Count + 1
                                           );
            }
            else
            {
                Consultant consultant = new Consultant();
                consultant.AddClient(InputName.Text,
                                           InputLastName.Text,
                                           InputPatronymic.Text,
                                           InputPssportNumber.Text,
                                           InputPassportSeries.Text,
                                           InputPhoneNumber.Text,
                                           AddEditCombobox.SelectedIndex,
                                           bankClient.Count + 1
                                           );
            }
        }

        private static int WID;

        /// <summary>
        /// Передача индетификатора клиента
        /// </summary>
        /// <param name="WorkerId"></param>
        /// <returns></returns>
        public static int InClientId(int ClientId)
        {
            WID = ClientId;
            return WID;
        }

        /// <summary>
        /// Редактирование клиента
        /// </summary>
        private void InputClientEdd()
        {

            if (MainWindow.CombWiw == 1)
            {
                Manager manager = new Manager();
                manager.EditClient(InputName.Text,
                                               InputLastName.Text,
                                               InputPatronymic.Text,
                                               InputPssportNumber.Text,
                                               InputPassportSeries.Text,
                                               InputPhoneNumber.Text,
                                               AddEditCombobox.SelectedIndex,
                                               WID);
            }
            else
            {
                Consultant consultant = new Consultant();
                consultant.EditClient(InputName.Text,
                                               InputLastName.Text,
                                               InputPatronymic.Text,
                                               InputPssportNumber.Text,
                                               InputPassportSeries.Text,
                                               InputPhoneNumber.Text,
                                               AddEditCombobox.SelectedIndex,
                                               WID);
            }
            
        }

        /// <summary>
        /// Удаление клиента по id
        /// </summary>
        /// <param name="name"></param>
        public static void DelClient(BankClient bankClient)
        {
            Repository.bankClients.Remove(bankClient);
        }

        /// <summary>
        /// Привязка информации к форме
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="department"></param>
        public static void EditClient(BankClient bankClient, int department)
        {

            EditAddDeleteWindow editAdd = new EditAddDeleteWindow();
            editAdd.InputName.Text = bankClient.Name;
            editAdd.InputLastName.Text = bankClient.Lastname;
            editAdd.InputPatronymic.Text = bankClient.Patronymic;
            editAdd.InputPssportNumber.Text = bankClient.NumberPassport;
            editAdd.InputPassportSeries.Text = bankClient.SeriesPassport;
            editAdd.InputPhoneNumber.Text = bankClient.PhoneNumber;
            editAdd.AddEditCombobox.SelectedIndex = department;
           
            editAdd.Show();
        }

        /// <summary>
        /// Кнопка нажатия в форме изминений/добавлений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtrAdd_Click(object sender, RoutedEventArgs e)
        {
            if (numberAdd == 1)
            {
                if (InputName.Text == string.Empty ||
                    InputLastName.Text == string.Empty ||
                    InputPatronymic.Text == string.Empty ||
                    InputPhoneNumber.Text == string.Empty ||
                    InputPssportNumber.Text == string.Empty ||
                    InputPassportSeries.Text == string.Empty ||
                    AddEditCombobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Не все поля заполнены");
                }

                else if (InputName.Text != string.Empty ||
                         InputLastName.Text != string.Empty ||
                         InputPatronymic.Text != string.Empty ||
                         InputPhoneNumber.Text != string.Empty ||
                         InputPssportNumber.Text != string.Empty ||
                         InputPassportSeries.Text != string.Empty)
                {
                    InputClientEdd();
                    MessageBox.Show("Данные сотрудника изминены");
                    Close();
                }
            }

            else if (numberAdd == 0)
            {
                if (InputName.Text != string.Empty ||
                    InputLastName.Text != string.Empty ||
                    InputPatronymic.Text != string.Empty ||
                    InputPhoneNumber.Text != string.Empty ||
                    InputPssportNumber.Text != string.Empty ||
                    InputPassportSeries.Text != string.Empty)
                {
                    InputClientAdd();
                    MessageBox.Show("Сотрудник добавлен");
                    Close();
                }
            }
        }







        /// <summary>
        /// Доступ на редактировании полей
        /// </summary>
        private void AccessToTextBox()
        {
            if (CombWiw == 1)
            {
                InputName.IsReadOnly = true;
                InputLastName.IsReadOnly = true;
                InputPatronymic.IsReadOnly = true;
            }
        }
    }
}
