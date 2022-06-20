using DZ_SkillBox_11.Model;
using System.Windows;

namespace DZ_SkillBox_11.View
{
    /// <summary>
    /// Логика взаимодействия для ChangeTimeWindow.xaml
    /// </summary>
    public partial class ChangeTimeWindow : Window
    {
        public ChangeTimeWindow()
        {
            InitializeComponent();

        }

        public void WhatChanged(BankClient bankClient)
        {

            foreach (var item in BankClient.EditHistory)
            {
                if (item.WorkerId == bankClient.ClientId)
                {
                    foreach (var item1 in Repository.bankClients)
                    {
                        if (bankClient.ClientId == item1.ClientId)
                        {
                            foreach (var items in BankClient.EditHistory)
                            {
                                WhoChanged.Text = items.EditorName;
                                DataChanged.Content = items.EditData;
                                TypeChanged.Text = items.EditorType;
                                WhatChanged1.Text = items.PrevDataState;
                            }

                        }
                    }
                }

            }
        }

    }
}
