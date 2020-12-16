using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Wpflab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Params objWithParams = new Params(); 
        Thread t; 
        BackgroundWorker bgWorker; 
        public MainWindow()
        {
            InitializeComponent();
            bgWorker = (BackgroundWorker)this.Resources["worker"];
        }
        private void SettingsClick(object sender, RoutedEventArgs e)
        {
            DialogForParams dlg = new DialogForParams();
            dlg.mainGrid.DataContext = objWithParams;
            if (dlg.ShowDialog() != true)
            {
                MessageBox.Show("Entering data don't save");
            }

        }
        private void Start1Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProgressBar.Value = 0;
                ButtonsDisable();
                if (ProgressBar.Maximum != 100) ProgressBar.Maximum = 100;
                t = new Thread(Calculate);
                t.Start((objWithParams));
            }
            catch
            {
                MessageBox.Show("Please, enter  correct data");
            }
        }
        private void Calculate(object n)
        {
            try
            {
                Params obj = (Params)n;
                int step = obj.N / 100;
                double h = (obj.XMax - obj.XMin) / (double)obj.N;
                double sum = 0;
                for (int i = 0; i <= obj.N; i++)
                {
                    sum += h * Math.Pow((obj.XMin + h * i), 3);
                    if (i % step == 0)
                    { Dispatcher.BeginInvoke(new Action(() => ProgressBar.Value = (i / step)+1)); }
                }
                MessageBox.Show(string.Format($"Integral is: {sum}"));
            }
            catch
            {
                MessageBox.Show("Incorrect enter data!");
            }
            Dispatcher.BeginInvoke(new Action(ButtonsEnable));
        }

        private void Start2Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.Value = 0;
            ButtonsDisable();
            bgWorker.RunWorkerAsync((object)objWithParams);

        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e) 
        {
            try
            {
                Params objWithParams = (Params)e.Argument;
                int step = objWithParams.N / 100;
                double h = (objWithParams.XMax - objWithParams.XMin) / (double)objWithParams.N;
                double sum = 0;
                for (int i = 0; i <= objWithParams.N; i++)
                {
                    sum += h * Math.Pow((objWithParams.XMin + h * i), 3);
                    if (i % step == 0)
                    {
                        if (bgWorker != null && bgWorker.WorkerReportsProgress)
                            bgWorker.ReportProgress((i / step)+1);
                    }
                    Thread.Sleep(100);
                }
                MessageBox.Show(string.Format($"Integral is: {sum}"));
            }
            catch
            {
                MessageBox.Show("Incorrect enter data!");
            }
        }
       
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) 
        {
           // if (ProgressBar.Maximum != 100) ProgressBar.Maximum = 100;
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void StopClick(object sender, RoutedEventArgs e)
        {
            if (t != null)
            {
                t.Abort();
                this.Close();
            }
            else MessageBox.Show("Abort Thread");
        }
        private void ButtonsEnable() 
        {
            Start1.IsEnabled = true;
            Start2.IsEnabled = true;
        }
        private void ButtonsDisable() 
        {
            Start1.IsEnabled = false;
            Start2.IsEnabled = false;
        }
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            ButtonsEnable();
        }

       
    }
}
