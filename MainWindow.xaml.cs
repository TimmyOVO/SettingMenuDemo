using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using SettingMenuDemo.ViewModels;

namespace SettingMenuDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private bool loaded;
        public MainWindow()
        {
            InitializeComponent();
            initializeComponentsValue();
        }

        private void initializeComponentsValue()
        {
            this.DataContext = new MainViewModel();
            this.loaded = true;
            this.fontSize.Value = this.someText1.FontSize;
        }

        private void OnConfirmExit(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void OnThemeButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        private void OnOpenSettingButtonClicked(object sender, RoutedEventArgs e)
        {
            WindowButtonCommandsOverlayBehavior = WindowCommandsOverlayBehavior.Flyouts;
            foreach(Flyout f in this.Flyouts.Items)
            {
                f.IsOpen = !f.IsOpen;
            }
        }

        private void fontSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!loaded)
            {
                return;
            }
            this.someText1.FontSize = e.NewValue;
            this.someText2.FontSize = e.NewValue;
        }

        private void setFont_Click(object sender, RoutedEventArgs e)
        {
            Button b = ((Button)e.OriginalSource);
            Console.WriteLine(b.Content);
        }

        private void font1_Click(object sender, RoutedEventArgs e)
        {
            this.someText1.FontFamily = new FontFamily("Comic Sans MS");
            this.someText2.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void font2_Click(object sender, RoutedEventArgs e)
        {
            this.someText1.FontFamily = new FontFamily("Lucida Console");
            this.someText2.FontFamily = new FontFamily("Lucida Console");
        }

        private void switchFirstTextBlockVisiblity_Unchecked(object sender, RoutedEventArgs e)
        {
            this.someText1.Visibility = Visibility.Hidden;
        }

        private void switchSecondTextBlockVisiblity_Unchecked(object sender, RoutedEventArgs e)
        {
            this.someText2.Visibility = Visibility.Hidden;
        }

        private void switchFirstTextBlockVisiblity_Checked(object sender, RoutedEventArgs e)
        {
            this.someText1.Visibility = Visibility.Visible;
        }

        private void switchSecondTextBlockVisiblity_Checked(object sender, RoutedEventArgs e)
        {
            this.someText2.Visibility = Visibility.Visible;
        }
    }
}
