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

        private void WhatChanged()
        {
            OutPutWhoChanged.Text = "da";
        }

    }
}
