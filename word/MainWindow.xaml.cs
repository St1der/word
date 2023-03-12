using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace word
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }
        public String text1 { get; set; }
        public String textsave { get; set; }
        private void save_Click(object sender, RoutedEventArgs e)
        {   
             textsave = textbox.Text;
            string fileName = textname.Text;
            string filePath = "C:\\Users\\Tural\\Desktop\\" + fileName + ".txt";
            File.WriteAllText(filePath, textsave);
        }
        private void paste_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = textsave;
        }
        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (check.IsChecked == true)
            {
                text1 = textbox.Text;
            }
        }

        private void cut_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text=null;
        }

        private void copy_Click(object sender, RoutedEventArgs e)
        {
           textsave = textbox.Text;
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            textbox.Background= Brushes.Blue;
        }
    }
}
