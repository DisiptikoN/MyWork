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
    public partial class EditAddDeleteWindow : Window
    {

        public ActionsAddDeleteEdit actions = new ActionsAddDeleteEdit();
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

        /// <summary>
        /// Добавление работника через форму
        /// </summary>
        public void InputWorkerAdd()
        {
            workers = new List<Worker>();
            ActionsAddDeleteEdit.AddWorker(InputName.Text,
                                           InputLastName.Text,
                                           InputPatronymic.Text,
                                           InputPssportNumber.Text,
                                           InputPassportSeries.Text,
                                           InputPhoneNumber.Text,
                                           AddEditCombobox.SelectedIndex,
                                           workers.Count + 1);
        }

        private static int WID;

        /// <summary>
        /// Передача индетификатора работника
        /// </summary>
        /// <param name="WorkerId"></param>
        /// <returns></returns>
        public static int InWorkerId(int WorkerId)
        {
            WID = WorkerId;
            return WID;
        }

        /// <summary>
        /// Редактирование сотрудник
        /// </summary>




        private void InputWorkerEdd()
        {
            ActionsAddDeleteEdit.EddWorker(InputName.Text,
                                           InputLastName.Text,
                                           InputPatronymic.Text,
                                           InputPssportNumber.Text,
                                           InputPassportSeries.Text,
                                           InputPhoneNumber.Text,
                                           AddEditCombobox.SelectedIndex,
                                           WID);
        }

        /// <summary>
        /// Удаление работников по id
        /// </summary>
        /// <param name="name"></param>
        public static void DelWorker(Worker worker)
        {
            Repository.workers.Remove(worker);
        }

        /// <summary>
        /// Привязка информации к форме
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="department"></param>
        public static void EditWorker(Worker worker, int department)
        {
            EditAddDeleteWindow editAdd = new EditAddDeleteWindow();
            editAdd.InputName.Text = worker.Name;
            editAdd.InputLastName.Text = worker.Lastname;
            editAdd.InputPatronymic.Text = worker.Patronymic;
            editAdd.InputPssportNumber.Text = worker.NumberPassport;
            editAdd.InputPassportSeries.Text = worker.SeriesPassport;
            editAdd.InputPhoneNumber.Text = worker.PhoneNumber;
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
                    InputWorkerEdd();
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
                    InputWorkerAdd();
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
