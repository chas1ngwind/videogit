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


// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace GUI
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {

        public BlankPage1()
        {
            this.InitializeComponent();
        }


        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private async void Selectvideo(object sender, RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation =
                Windows.Storage.Pickers.PickerLocationId.ComputerFolder;
            picker.FileTypeFilter.Add(".mp4");
            picker.FileTypeFilter.Add(".avi");
            picker.FileTypeFilter.Add(".flv");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                this.videoinfo.Text = "Picked Video: " + file.Name;
            }
            else
            {
                this.videoinfo.Text = "Operation cancelled.";
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

       

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void Convertvideo(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
