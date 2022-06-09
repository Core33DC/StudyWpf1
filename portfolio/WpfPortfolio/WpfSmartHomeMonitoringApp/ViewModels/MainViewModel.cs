﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSmartHomeMonitoringApp.ViewModels
{
    public class MainViewModel : Conductor<object>  // Screen ActivateItem[Async] 메서드 없음
    {
        public MainViewModel()
        {
            //MessageBox.Show("MVVM Start!");
            DisplayName = "SmartHome Monitoring v2.0";  //윈도우 타이틀, 제목
        }

        //TODO

        public void LoadDataBaseView()
        {
            ActivateItemAsync(new DataBaseViewModel());
        }


        public void LoadRealTimeView()
        {
            ActivateItemAsync(new RealTimeViewModel());
        }

        public void LoadHistoryView()
        {
            ActivateItemAsync(new HistoryViewModel());
        }

        public void ExitProgram()
        {
            Environment.Exit(0);
        }
    }
}