using System;
using System.Collections.Generic;
using System.Text;
using Ghost_Launcher.Core;

namespace Ghost_Launcher.MVVM.WievModel
{
    class MainViewModel:ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand GameViewCommand { get; set; }
        public RelayCommand NewsViewCommand { get; set; }

        public HomeViewModel HomeVN { get; set; }
        public GameViewModel GameVN { get; set; }
        public NewsViewModel NewsVN { get; set; }

        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set 
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVN = new HomeViewModel();
            GameVN = new GameViewModel();
            NewsVN = new NewsViewModel();

            CurrentView = HomeVN;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVN;
            });
            GameViewCommand = new RelayCommand(o =>
            {
                CurrentView = GameVN;
            });
            NewsViewCommand = new RelayCommand(o =>
            {
                CurrentView = NewsVN;
            });
        }
    }
}
