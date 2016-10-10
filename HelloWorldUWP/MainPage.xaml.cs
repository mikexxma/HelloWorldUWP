using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorldUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Button button = new Button();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            textBlock.Text = "hello UWP";
           
            button.Name = "myButton";
            button.Height = 100;
            button.Width = 50;

            button.Margin = new Thickness(100, 20, 0, 0);
            button.Click += clickMe;
            layoutGrid.Children.Add(button);
        }

        public void clickMe(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "hello Mike";
            button.Margin = new Thickness(200, 20, 0, 0);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "hello Button2";
        }
    }
}
