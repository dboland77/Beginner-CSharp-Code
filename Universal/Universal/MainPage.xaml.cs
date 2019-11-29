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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void BtnPick_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int[] seq = new int[59];
            for (int i = 1; i < 60; i++) seq[i - 1] = i;
            for(int i = 0; i < 59; i++)
            {
                int j = (rnd.Next() % 59);
                int k = seq[i];
                seq[i] = seq[j];
                seq[j] = k;

            }
            textBlock1.Text = seq[1].ToString();
            textBlock2.Text = seq[2].ToString();
            textBlock3.Text = seq[3].ToString();
            textBlock4.Text = seq[4].ToString();
            textBlock5.Text = seq[5].ToString();
            textBlock6.Text = seq[6].ToString();

            BtnPick.IsEnabled = false;
            BtnReset.IsEnabled = true;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "...";
            textBlock2.Text = "...";
            textBlock3.Text = "...";
            textBlock4.Text = "...";
            textBlock5.Text = "...";
            textBlock6.Text = "...";

            BtnPick.IsEnabled = true;
            BtnReset.IsEnabled = false;

        }
    }
}
