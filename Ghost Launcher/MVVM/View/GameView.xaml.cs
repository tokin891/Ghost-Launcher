using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;

namespace Ghost_Launcher.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy GameView.xaml
    /// </summary>
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
        }

        public void Button_ClickPlay(object sender, RoutedEventArgs e)
        {
            //Process.Start(Directory.GetCurrentDirectory() + "/App/Game");
            //Application.Current.Shutdown();
        }
    }
}
