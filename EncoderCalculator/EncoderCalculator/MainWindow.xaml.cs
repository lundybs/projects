using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace EncoderCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double w1r1, w1r2, w2r1, w2r2, w3r1, w3r2,
                       c1r1, c1r2, c2r1, c2r2, c3r1, c3r2,
                       m1r1, m1r2, m2r1, m2r2, m3r1, m3r2,
                       y1r1, y1r2, y2r1, y2r2, y3r1, y3r2,
                       k1r1, k1r2, k2r1, k2r2, k3r1, k3r2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxLoadedResolutions(object sender, RoutedEventArgs e)
        {
            List<string> resolution = new List<string>();
            resolution.Add("Select DPI");
            resolution.Add("270 dpi");
            resolution.Add("225 dpi");
            resolution.Add("180 dpi");

            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = resolution;
            comboBox.SelectedIndex = 0;
        }

        private void ClearTextBoxWithGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= ClearTextBoxWithGotFocus;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try //use to catch some errors
            {
                PutValuesIntoMemory();
                switch(comboBox.SelectedIndex)
                {
                    case 1:
                        CalculatePDOffset270DPI();
                        break;
                    case 2:
                        CalculatePDOffset225DPI();
                        break;
                    case 3:
                        CalculatePDOffset180DPI();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("You did not enter in numeric values in all of the boxes.", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        public void PutValuesIntoMemory()
        {
            w1r1 = Double.Parse(txtW1R1.Text);
            w1r2 = Double.Parse(txtW1R2.Text);
            w2r1 = Double.Parse(txtW2R1.Text);
            w2r2 = Double.Parse(txtW2R2.Text);
            w3r1 = Double.Parse(txtW3R1.Text);
            w3r2 = Double.Parse(txtW3R2.Text);
            c1r1 = Double.Parse(txtC1R1.Text);
            c1r2 = Double.Parse(txtC1R2.Text);
            c2r1 = Double.Parse(txtC2R1.Text);
            c2r2 = Double.Parse(txtC2R2.Text);
            c3r1 = Double.Parse(txtC3R1.Text);
            c3r2 = Double.Parse(txtC3R2.Text);
            m1r1 = Double.Parse(txtM1R1.Text);
            m1r2 = Double.Parse(txtM1R2.Text);
            m2r1 = Double.Parse(txtM2R1.Text);
            m2r2 = Double.Parse(txtM2R2.Text);
            m3r1 = Double.Parse(txtM3R1.Text);
            m3r2 = Double.Parse(txtM3R2.Text);
            y1r1 = Double.Parse(txtY1R1.Text);
            y1r2 = Double.Parse(txtY1R2.Text);
            y2r1 = Double.Parse(txtY2R1.Text);
            y2r2 = Double.Parse(txtY2R2.Text);
            y3r1 = Double.Parse(txtY3R1.Text);
            y3r2 = Double.Parse(txtY3R2.Text);
            k1r1 = Double.Parse(txtK1R1.Text);
            k1r2 = Double.Parse(txtK1R2.Text);
            k2r1 = Double.Parse(txtK2R1.Text);
            k2r2 = Double.Parse(txtK2R2.Text);
            k3r1 = Double.Parse(txtK3R1.Text);
            k3r2 = Double.Parse(txtK3R2.Text);
        }

        private void CalculatePDOffset270DPI()
        {
            txtNewResolutionW1R1.Text = ((w1r1 * 270) / 360).ToString();
            txtNewResolutionW1R2.Text = ((w1r2 * 270) / 360).ToString();
            txtNewResolutionW2R1.Text = ((w2r1 * 270) / 360).ToString();
            txtNewResolutionW2R2.Text = ((w2r2 * 270) / 360).ToString();
            txtNewResolutionW3R1.Text = ((w3r1 * 270) / 360).ToString();
            txtNewResolutionW3R2.Text = ((w3r2 * 270) / 360).ToString();
            txtNewResolutionC1R1.Text = ((c1r1 * 270) / 360).ToString();
            txtNewResolutionC1R2.Text = ((c1r2 * 270) / 360).ToString();
            txtNewResolutionC2R1.Text = ((c2r1 * 270) / 360).ToString();
            txtNewResolutionC2R2.Text = ((c2r2 * 270) / 360).ToString();
            txtNewResolutionC3R1.Text = ((c3r1 * 270) / 360).ToString();
            txtNewResolutionC3R2.Text = ((c3r2 * 270) / 360).ToString();
            txtNewResolutionM1R1.Text = ((m1r1 * 270) / 360).ToString();
            txtNewResolutionM1R2.Text = ((m1r2 * 270) / 360).ToString();
            txtNewResolutionM2R1.Text = ((m2r1 * 270) / 360).ToString();
            txtNewResolutionM2R2.Text = ((m2r2 * 270) / 360).ToString();
            txtNewResolutionM3R1.Text = ((m3r1 * 270) / 360).ToString();
            txtNewResolutionM3R2.Text = ((m3r2 * 270) / 360).ToString();
            txtNewResolutionY1R1.Text = ((y1r1 * 270) / 360).ToString();
            txtNewResolutionY1R2.Text = ((y1r2 * 270) / 360).ToString();
            txtNewResolutionY2R1.Text = ((y2r1 * 270) / 360).ToString();
            txtNewResolutionY2R2.Text = ((y2r2 * 270) / 360).ToString();
            txtNewResolutionY3R1.Text = ((y3r1 * 270) / 360).ToString();
            txtNewResolutionY3R2.Text = ((y3r2 * 270) / 360).ToString();
            txtNewResolutionK1R1.Text = ((k1r1 * 270) / 360).ToString();
            txtNewResolutionK1R2.Text = ((k1r2 * 270) / 360).ToString();
            txtNewResolutionK2R1.Text = ((k2r1 * 270) / 360).ToString();
            txtNewResolutionK2R2.Text = ((k2r2 * 270) / 360).ToString();
            txtNewResolutionK3R1.Text = ((k3r1 * 270) / 360).ToString();
            txtNewResolutionK3R2.Text = ((k3r2 * 270) / 360).ToString();
        }

        private void CalculatePDOffset225DPI()
        {
            txtNewResolutionW1R1.Text = ((w1r1 * 225) / 360).ToString();
            txtNewResolutionW1R2.Text = ((w1r2 * 225) / 360).ToString();
            txtNewResolutionW2R1.Text = ((w2r1 * 225) / 360).ToString();
            txtNewResolutionW2R2.Text = ((w2r2 * 225) / 360).ToString();
            txtNewResolutionW3R1.Text = ((w3r1 * 225) / 360).ToString();
            txtNewResolutionW3R2.Text = ((w3r2 * 225) / 360).ToString();
            txtNewResolutionC1R1.Text = ((c1r1 * 225) / 360).ToString();
            txtNewResolutionC1R2.Text = ((c1r2 * 225) / 360).ToString();
            txtNewResolutionC2R1.Text = ((c2r1 * 225) / 360).ToString();
            txtNewResolutionC2R2.Text = ((c2r2 * 225) / 360).ToString();
            txtNewResolutionC3R1.Text = ((c3r1 * 225) / 360).ToString();
            txtNewResolutionC3R2.Text = ((c3r2 * 225) / 360).ToString();
            txtNewResolutionM1R1.Text = ((m1r1 * 225) / 360).ToString();
            txtNewResolutionM1R2.Text = ((m1r2 * 225) / 360).ToString();
            txtNewResolutionM2R1.Text = ((m2r1 * 225) / 360).ToString();
            txtNewResolutionM2R2.Text = ((m2r2 * 225) / 360).ToString();
            txtNewResolutionM3R1.Text = ((m3r1 * 225) / 360).ToString();
            txtNewResolutionM3R2.Text = ((m3r2 * 225) / 360).ToString();
            txtNewResolutionY1R1.Text = ((y1r1 * 225) / 360).ToString();
            txtNewResolutionY1R2.Text = ((y1r2 * 225) / 360).ToString();
            txtNewResolutionY2R1.Text = ((y2r1 * 225) / 360).ToString();
            txtNewResolutionY2R2.Text = ((y2r2 * 225) / 360).ToString();
            txtNewResolutionY3R1.Text = ((y3r1 * 225) / 360).ToString();
            txtNewResolutionY3R2.Text = ((y3r2 * 225) / 360).ToString();
            txtNewResolutionK1R1.Text = ((k1r1 * 225) / 360).ToString();
            txtNewResolutionK1R2.Text = ((k1r2 * 225) / 360).ToString();
            txtNewResolutionK2R1.Text = ((k2r1 * 225) / 360).ToString();
            txtNewResolutionK2R2.Text = ((k2r2 * 225) / 360).ToString();
            txtNewResolutionK3R1.Text = ((k3r1 * 225) / 360).ToString();
            txtNewResolutionK3R2.Text = ((k3r2 * 225) / 360).ToString();
        }

        private void CalculatePDOffset180DPI()
        {
            txtNewResolutionW1R1.Text = ((w1r1 * 180) / 360).ToString();
            txtNewResolutionW1R2.Text = ((w1r2 * 180) / 360).ToString();
            txtNewResolutionW2R1.Text = ((w2r1 * 180) / 360).ToString();
            txtNewResolutionW2R2.Text = ((w2r2 * 180) / 360).ToString();
            txtNewResolutionW3R1.Text = ((w3r1 * 180) / 360).ToString();
            txtNewResolutionW3R2.Text = ((w3r2 * 180) / 360).ToString();
            txtNewResolutionC1R1.Text = ((c1r1 * 180) / 360).ToString();
            txtNewResolutionC1R2.Text = ((c1r2 * 180) / 360).ToString();
            txtNewResolutionC2R1.Text = ((c2r1 * 180) / 360).ToString();
            txtNewResolutionC2R2.Text = ((c2r2 * 180) / 360).ToString();
            txtNewResolutionC3R1.Text = ((c3r1 * 180) / 360).ToString();
            txtNewResolutionC3R2.Text = ((c3r2 * 180) / 360).ToString();
            txtNewResolutionM1R1.Text = ((m1r1 * 180) / 360).ToString();
            txtNewResolutionM1R2.Text = ((m1r2 * 180) / 360).ToString();
            txtNewResolutionM2R1.Text = ((m2r1 * 180) / 360).ToString();
            txtNewResolutionM2R2.Text = ((m2r2 * 180) / 360).ToString();
            txtNewResolutionM3R1.Text = ((m3r1 * 180) / 360).ToString();
            txtNewResolutionM3R2.Text = ((m3r2 * 180) / 360).ToString();
            txtNewResolutionY1R1.Text = ((y1r1 * 180) / 360).ToString();
            txtNewResolutionY1R2.Text = ((y1r2 * 180) / 360).ToString();
            txtNewResolutionY2R1.Text = ((y2r1 * 180) / 360).ToString();
            txtNewResolutionY2R2.Text = ((y2r2 * 180) / 360).ToString();
            txtNewResolutionY3R1.Text = ((y3r1 * 180) / 360).ToString();
            txtNewResolutionY3R2.Text = ((y3r2 * 180) / 360).ToString();
            txtNewResolutionK1R1.Text = ((k1r1 * 180) / 360).ToString();
            txtNewResolutionK1R2.Text = ((k1r2 * 180) / 360).ToString();
            txtNewResolutionK2R1.Text = ((k2r1 * 180) / 360).ToString();
            txtNewResolutionK2R2.Text = ((k2r2 * 180) / 360).ToString();
            txtNewResolutionK3R1.Text = ((k3r1 * 180) / 360).ToString();
            txtNewResolutionK3R2.Text = ((k3r2 * 180) / 360).ToString();
        }
    }
}
