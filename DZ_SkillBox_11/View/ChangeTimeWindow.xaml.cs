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
using System.Windows.Shapes;
using DZ_SkillBox_11;
using DZ_SkillBox_11.Model;

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

        public void WhatChanged(Worker worker)
        {
            var data = Worker.EditHistory;

            foreach (var item in data)
            {
                if (item.WorkerId == worker.WorkerId)
                {
                    foreach (var item1 in Repository.workers)
                    {
                        if (worker.WorkerId == item1.WorkerId)
                        {
                            foreach (var items in Worker.EditHistory)
                            {
                                WhoChanged.Text = items.EditorName;
                                DataChanged.Content = items.EditData;
                                TypeChanged.Text = item.EditorType;
                                WhatChanged1.Text = item.PrevDataState;
                            }

                        }
                    }
                }

            }
        }

    }
}
