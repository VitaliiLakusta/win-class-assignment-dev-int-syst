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

using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App_DevIntSys
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

        private async void btnTakePic1_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI capture = new CameraCaptureUI();
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage();
            img.SetSource(filestream);
            imgViewer1.Source = img;
        }

        private async void btnTakePic2_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI capture = new CameraCaptureUI();
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage();
            img.SetSource(filestream);
            imgViewer2.Source = img;
        }

        private async void btnTakePic3_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI capture = new CameraCaptureUI();
            capture.PhotoSettings.CroppedAspectRatio = new Size(16, 9);
            StorageFile file = await capture.CaptureFileAsync(CameraCaptureUIMode.Photo);
            IRandomAccessStream filestream = await file.OpenAsync(FileAccessMode.Read);
            BitmapImage img = new BitmapImage();
            img.SetSource(filestream);
            imgViewer3.Source = img;
        }
    }
}
