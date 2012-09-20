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
using System.Web;
using System.Net;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            /// More commonly, your application will want to process the data retrieved from the web site. 
            /// In order to do this, you use the OpenRead () method, Which returns a stream reference. 
            /// You can then simply retrieve the data from the stream.

            /// WebClient Client = new WebClient();
            /// Stream strm = Client.OpenRead("http://www.csharpfriends.com/Members/index.aspx");


            //next script is to simply download the object given as first parameter; second parameter is the address and name.
            // DON"T forget to import SYSTEM.NET ; include extension

            //WebClient Client = new WebClient();
            //Client.DownloadFile("http://wiresharkdownloads.riverbed.com/wireshark/win64/Wireshark-win64-1.8.2.exe", "D:/Wireshark x64.exe");


        }

        private void bWS64_Click(object sender, RoutedEventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("http://wiresharkdownloads.riverbed.com/wireshark/win64/Wireshark-win64-1.8.2.exe", "D:/Wireshark x64.exe");

            
        }

        private void bWS32_Click(object sender, RoutedEventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("wiresharkdownloads.riverbed.com/wireshark/win32/Wireshark-win32-1.8.2.exe", "D:/Wireshark x32.exe");
        }

       

        private void bBlender_Click(object sender, RoutedEventArgs e)
        {
             WebClient Client = new WebClient();
             Client.DownloadFile("download.blender.org/release/Blender2.63/blender-2.63a-release-windows32.exe", "D:/BlenderInstaller x32.exe");
        }

        private void progressBar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {}
  
        private void bPython32_Click(object sender, RoutedEventArgs e)
        {

            WebClient Client = new WebClient();
            Client.DownloadFile("www.python.org/ftp/python/2.6/python-2.6.msi", "D:/Install Python 2.6 x32.exe");
            
        }


        private void bPython64_click(object sender, RoutedEventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("www.python.org/ftp/python/2.6/python-2.6.amd64.msi", "D:/Install Python 2.6 x64.exe");
        }

        private void textBox1_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void textBox2_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e) {}
   

        private void bEclipse32_Click(object sender, RoutedEventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("www.eclipse.org/downloads/download.php?file=/technology/epp/downloads/release/juno/R/eclipse-jee-juno-win32.zip&url=http://ftp.halifax.rwth-aachen.de/eclipse//technology/epp/downloads/release/juno/R/eclipse-jee-juno-win32.zip&mirror_id=1045", "D:/Install Eclipse x32.exe");
        }

        private void bEclipse64_Click(object sender, RoutedEventArgs e)
        {
            WebClient Client = new WebClient();
            Client.DownloadFile("www.eclipse.org/downloads/download.php?file=/technology/epp/downloads/release/juno/R/eclipse-jee-juno-win32-x86_64.zip&url=http://mirror.selfnet.de/eclipse/technology/epp/downloads/release/juno/R/eclipse-jee-juno-win32-x86_64.zip&mirror_id=1002", "D:/Install Eclipse x64.exe");
        }

      



        
    }
}


