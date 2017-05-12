using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace JetrionCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double labelQuantity, labelImages, pixelSize, labelTotal, tail, leader, itemblank,
                       eyeMarks, fiftyFeetImages, oneHundredFeet, itemFootage, sizeOfList, addedTotalFootage,
                       w1r1, w1r2, w2r1, w2r2, w3r1, w3r2,
                       c1r1, c1r2, c2r1, c2r2, c3r1, c3r2,
                       m1r1, m1r2, m2r1, m2r2, m3r1, m3r2,
                       y1r1, y1r2, y2r1, y2r2, y3r1, y3r2,
                       k1r1, k1r2, k2r1, k2r2, k3r1, k3r2;



        private bool cbEmbossChecked, cbHotstampChecked, rbNone, rbTwo, rbFive, rbTen;

        List<double> footage = new List<double>();

        public MainWindow()
        {
            InitializeComponent();
            txtLabelQuanity.Focus();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) //This is the about menu
        {
            MessageBox.Show("This is a working prototype, not a final product yet.", "About", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) //This cloes the application in the menu
        {
            this.Close();
        }

        public void EnterToTab(object sender, KeyEventArgs e)
        {
            var uie = e.OriginalSource as UIElement;

            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                uie.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }

        public void EnterToCalculate(object sender, KeyEventArgs e)
        {
            var uie = e.OriginalSource as UIElement;

            if (e.Key == Key.Enter)
            {
                e.Handled = true;

                if ((labelQuantity == 0) || (pixelSize == 0) || (labelImages == 0) || (eyeMarks == 0)) { }
                else
                {
                    try
                    {
                        ValuesToMemory();
                        CalculateAllFootage();
                        CalculateEyeMarkPerGearType();
                        TotalLabelsToPrint();
                        CalculateItemFootage();
                        AddFootageToList();
                        TotalJobFootage();
                    }
                    catch
                    {
                        MessageBox.Show("You did not enter in correct numeric values", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Error);

                    }
                }
            }

            else if (e.Key == Key.Up)
            {
                e.Handled = true;
                uie.MoveFocus(new TraversalRequest(FocusNavigationDirection.Previous));
            }

            else if (e.Key == Key.Down)
            {
                e.Handled = true;
                uie.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            }
        }

        public void CalculateItemFootage()
        {
            itemFootage = (((pixelSize / 360) * Double.Parse(txtTotalLabels.Text)) / 12);
            itemFootage = Math.Round(itemFootage, 2);
            txtItemTotalFootage.Text = itemFootage.ToString();
        }

        public void AddFootageToList()
        {
            footage.Add(itemFootage);
            sizeOfList = footage.Count;
        }

        public void TotalJobFootage()
        {
            double tailFootage = (((pixelSize / 360) * Double.Parse(txtTail.Text)) / 12);
            double leaderFootage = (((pixelSize / 360) * Double.Parse(txtLeader.Text)) / 12);
            double itemBlankFootage = (((pixelSize / 360) * Double.Parse(txtItemBlank.Text)) / 12);
            double totalItemBlankFootage = 0;
            addedTotalFootage = 0;
            if (sizeOfList != 1)
            {
                totalItemBlankFootage = sizeOfList * itemBlankFootage;
                foreach (var values in footage)
                {
                    addedTotalFootage += values;
                }
            }
            else
            {
                totalItemBlankFootage = 0;
                foreach (var values in footage)
                {
                    addedTotalFootage += values;
                }
            }

            txtTotalJobFootage.Text = Math.Round((addedTotalFootage + tailFootage + leaderFootage + totalItemBlankFootage), 2).ToString();
        }

        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            footage.Clear();
            addedTotalFootage = 0;
            txtTotalJobFootage.Text = addedTotalFootage.ToString();
        }

        public void CBEmboss(object sender, RoutedEventArgs e)
        {
            if (checkBoxEmboss.IsChecked == true)
            {
                cbEmbossChecked = true;
            }
        }

        public void CBHotstamp(object sender, RoutedEventArgs e)
        {
            if (checkBoxHotstamp.IsChecked == true)
            {
                cbHotstampChecked = true;
            }
        }

        public void RadioButtonNone(object sender, RoutedEventArgs e)
        {
            if (rb0percent.IsChecked == true)
            {
                rbNone = true;
            }
        }

        private void RadioButtonTwoPercent(object sender, RoutedEventArgs e)
        {
            if (rb2percent.IsChecked == true)
            {
                rbTwo = true;
            }
        }

        private void RadioButtonFivePercent(object sender, RoutedEventArgs e)
        {
            if (rb5percent.IsChecked == true)
            {
                rbFive = true;
            }
        }

        private void RadioButtonTenPercent(object sender, RoutedEventArgs e)
        {
            if (rb10percent.IsChecked == true)
            {
                rbTen = true;
            }
        }

        public void btn50FootStop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pixelSize = Double.Parse(txtPixelLength.Text);
                CalculateFiftyFeetImages();
                FiftyStopTotal();
            }
            catch
            {
                MessageBox.Show("Not all values were entered correctly, or no value was typed in for pixel size", "Uh oh!!", MessageBoxButton.OKCancel, MessageBoxImage.Exclamation);
            }
        }

        public void ClearTextBoxWithGotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).SelectAll();

            var textbox = e.OriginalSource as TextBox;
            if (textbox != null)
            {
                textbox.SelectAll();
            }
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ValuesToMemory();
                CalculateAllFootage();
                CalculateEyeMarkPerGearType();
                TotalLabelsToPrint();
                CalculateItemFootage();
                //AddFootageToList();
                //TotalJobFootage();
                txtLabelQuanity.Focus();
            }
            catch
            {
                MessageBox.Show("You did not enter in correct numeric values", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        public void ValuesToMemory()
        {
            labelQuantity = Double.Parse(txtLabelQuanity.Text);
            labelImages = Double.Parse(txtLabelsPerImage.Text);
            pixelSize = Double.Parse(txtPixelLength.Text);
            eyeMarks = Double.Parse(txtEyeMarks.Text);
        }

        public void TotalLabelsToPrint()
        {
            if (rbNone == true)
            {
                if (cbEmbossChecked == true)
                {
                    if (labelQuantity <= 4999)
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.1 + fiftyFeetImages + oneHundredFeet);
                        lblTotal.Content = "Total for 10% is:";
                    }
                    else if (labelQuantity >= 10000)
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.02 + fiftyFeetImages + oneHundredFeet);
                        lblTotal.Content = "Total for 2% is:";
                    }
                    else
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.05 + fiftyFeetImages + oneHundredFeet);
                        lblTotal.Content = "Total for 5% is:";
                    }
                    cbEmbossChecked = false;
                }
                else if (cbHotstampChecked == true)
                {
                    if (labelQuantity <= 4999)
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.1 + fiftyFeetImages + (oneHundredFeet * 2));
                        lblTotal.Content = "Total for 10% is:";
                    }
                    else if (labelQuantity >= 10000)
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.02 + fiftyFeetImages + (oneHundredFeet * 2));
                        lblTotal.Content = "Total for 2% is:";
                    }
                    else
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.05 + fiftyFeetImages + (oneHundredFeet * 2));
                        lblTotal.Content = "Total for 5% is:";
                    }
                    cbHotstampChecked = false;
                }
                else
                {
                    if (labelQuantity <= 4999)
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.1 + fiftyFeetImages);
                        lblTotal.Content = "Total for 10% is:";
                    }
                    else if (labelQuantity >= 10000)
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.02 + fiftyFeetImages);
                        lblTotal.Content = "Total for 2% is:";
                    }
                    else
                    {
                        labelTotal = ((labelQuantity / labelImages) * 1.05 + fiftyFeetImages);
                        lblTotal.Content = "Total for 5% is:";
                    }
                }
                txtTotalLabels.Text = ((int)labelTotal + 1).ToString();
                rbNone = false;
            }
            else if (rbTwo == true)
            {
                if (cbEmbossChecked == true)
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.02 + fiftyFeetImages + oneHundredFeet);
                    lblTotal.Content = "Total for 2% is:";
                    cbEmbossChecked = false;
                }
                else if (cbHotstampChecked == true)
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.02 + fiftyFeetImages + (oneHundredFeet * 2));
                    lblTotal.Content = "Total for 2% is:";
                    cbHotstampChecked = false;
                }
                else
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.02 + fiftyFeetImages);
                    lblTotal.Content = "Total for 2% is:";
                }
                txtTotalLabels.Text = ((int)labelTotal + 1).ToString();
                rbTwo = false;
            }
            else if (rbFive == true)
            {
                if (cbEmbossChecked == true)
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.05 + fiftyFeetImages + oneHundredFeet);
                    lblTotal.Content = "Total for 5% is:";
                    cbEmbossChecked = false;
                }
                else if (cbHotstampChecked == true)
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.05 + fiftyFeetImages + (oneHundredFeet * 2));
                    lblTotal.Content = "Total for 5% is:";
                    cbHotstampChecked = false;
                }
                else
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.05 + fiftyFeetImages);
                    lblTotal.Content = "Total for 5% is:";
                }
                txtTotalLabels.Text = ((int)labelTotal + 1).ToString();
                rbFive = false;
            }
            else
            {
                if (cbEmbossChecked == true)
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.1 + fiftyFeetImages + oneHundredFeet);
                    lblTotal.Content = "Total for 10% is:";
                    cbEmbossChecked = false;
                }
                else if (cbHotstampChecked == true)
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.1 + fiftyFeetImages + (oneHundredFeet * 2));
                    lblTotal.Content = "Total for 10% is:";
                    cbHotstampChecked = false;
                }
                else
                {
                    labelTotal = ((labelQuantity / labelImages) * 1.1 + fiftyFeetImages);
                    lblTotal.Content = "Total for 10% is:";
                }
                txtTotalLabels.Text = ((int)labelTotal + 1).ToString();
                rbTen = false;
            }
        }

        public void FiftyStopTotal()
        {
            double fiftyFootOldTotal = Double.Parse(txtTotalStop.Text);
            double fiftyFootPrinted = Double.Parse(txtPrintedStop.Text);

            double fiftyFootStop = (fiftyFootOldTotal - fiftyFootPrinted);
            if (fiftyFootStop >= 0)
            {
                fiftyFootStop = (fiftyFootStop + fiftyFeetImages);
                txtNewTotalStop.Text = ((int)fiftyFootStop + 1).ToString();
            }
            else
            {
                MessageBox.Show("The new total is greater than the total images to print", "Negative Total", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            }
        }

        public void CalculateAllFootage()
        {
            tail = (960 / (pixelSize / 360));
            txtTail.Text = ((int)tail + 1).ToString();

            leader = (2700 / (pixelSize / 360));
            txtLeader.Text = ((int)leader + 1).ToString();

            itemblank = (84 / (pixelSize / 360));
            txtItemBlank.Text = ((int)itemblank + 1).ToString();

            fiftyFeetImages = ((50 * 12) / (pixelSize / 360));
            txtFiftyFeet.Text = ((int)fiftyFeetImages + 1).ToString();

            oneHundredFeet = ((100 * 12) / (pixelSize / 360));
            txtOneHundredFeet.Text = ((int)oneHundredFeet + 1).ToString();

            double threeHundredFeet = ((300 * 12) / (pixelSize / 360));
            txtThreeHundredFeet.Text = ((int)threeHundredFeet + 1).ToString();
        }

        public void CalculateFiftyFeetImages()
        {
            fiftyFeetImages = ((50 * 12) / (pixelSize / 360));
            txtFiftyFeet.Text = ((int)fiftyFeetImages + 1).ToString();
        }

        public void CalculateEyeMarkPerGearType()
        {
            double eighthPitch = (((pixelSize / 360) / .125) / eyeMarks);
            txt18Pitch.Text = ((int)eighthPitch + 1).ToString();

            double thirtyTwoPitch = (((pixelSize / 360) * (32 / Math.PI) / eyeMarks));
            txt32Pitch.Text = ((int)thirtyTwoPitch + 1).ToString();
        }


        //pd offset methods
        public void ComboBoxLoadedResolutions(object sender, RoutedEventArgs e)
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

        public void buttonPDOffset_Click(object sender, RoutedEventArgs e)
        {
            try //use to catch some errors
            {
                PutValuesIntoMemory();
                switch (comboBox.SelectedIndex)
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

        public void CalculatePDOffset270DPI()
        {
            txtNewResolutionW1R1.Text = ((w1r1 * 270) / 360).ToString("F");
            txtNewResolutionW1R2.Text = ((w1r2 * 270) / 360).ToString("F");
            txtNewResolutionW2R1.Text = ((w2r1 * 270) / 360).ToString("F");
            txtNewResolutionW2R2.Text = ((w2r2 * 270) / 360).ToString("F");
            txtNewResolutionW3R1.Text = ((w3r1 * 270) / 360).ToString("F");
            txtNewResolutionW3R2.Text = ((w3r2 * 270) / 360).ToString("F");
            txtNewResolutionC1R1.Text = ((c1r1 * 270) / 360).ToString("F");
            txtNewResolutionC1R2.Text = ((c1r2 * 270) / 360).ToString("F");
            txtNewResolutionC2R1.Text = ((c2r1 * 270) / 360).ToString("F");
            txtNewResolutionC2R2.Text = ((c2r2 * 270) / 360).ToString("F");
            txtNewResolutionC3R1.Text = ((c3r1 * 270) / 360).ToString("F");
            txtNewResolutionC3R2.Text = ((c3r2 * 270) / 360).ToString("F");
            txtNewResolutionM1R1.Text = ((m1r1 * 270) / 360).ToString("F");
            txtNewResolutionM1R2.Text = ((m1r2 * 270) / 360).ToString("F");
            txtNewResolutionM2R1.Text = ((m2r1 * 270) / 360).ToString("F");
            txtNewResolutionM2R2.Text = ((m2r2 * 270) / 360).ToString("F");
            txtNewResolutionM3R1.Text = ((m3r1 * 270) / 360).ToString("F");
            txtNewResolutionM3R2.Text = ((m3r2 * 270) / 360).ToString("F");
            txtNewResolutionY1R1.Text = ((y1r1 * 270) / 360).ToString("F");
            txtNewResolutionY1R2.Text = ((y1r2 * 270) / 360).ToString("F");
            txtNewResolutionY2R1.Text = ((y2r1 * 270) / 360).ToString("F");
            txtNewResolutionY2R2.Text = ((y2r2 * 270) / 360).ToString("F");
            txtNewResolutionY3R1.Text = ((y3r1 * 270) / 360).ToString("F");
            txtNewResolutionY3R2.Text = ((y3r2 * 270) / 360).ToString("F");
            txtNewResolutionK1R1.Text = ((k1r1 * 270) / 360).ToString("F");
            txtNewResolutionK1R2.Text = ((k1r2 * 270) / 360).ToString("F");
            txtNewResolutionK2R1.Text = ((k2r1 * 270) / 360).ToString("F");
            txtNewResolutionK2R2.Text = ((k2r2 * 270) / 360).ToString("F");
            txtNewResolutionK3R1.Text = ((k3r1 * 270) / 360).ToString("F");
            txtNewResolutionK3R2.Text = ((k3r2 * 270) / 360).ToString("F");
        }

        public void CalculatePDOffset225DPI()
        {
            txtNewResolutionW1R1.Text = ((w1r1 * 225) / 360).ToString("F");
            txtNewResolutionW1R2.Text = ((w1r2 * 225) / 360).ToString("F");
            txtNewResolutionW2R1.Text = ((w2r1 * 225) / 360).ToString("F");
            txtNewResolutionW2R2.Text = ((w2r2 * 225) / 360).ToString("F");
            txtNewResolutionW3R1.Text = ((w3r1 * 225) / 360).ToString("F");
            txtNewResolutionW3R2.Text = ((w3r2 * 225) / 360).ToString("F");
            txtNewResolutionC1R1.Text = ((c1r1 * 225) / 360).ToString("F");
            txtNewResolutionC1R2.Text = ((c1r2 * 225) / 360).ToString("F");
            txtNewResolutionC2R1.Text = ((c2r1 * 225) / 360).ToString("F");
            txtNewResolutionC2R2.Text = ((c2r2 * 225) / 360).ToString("F");
            txtNewResolutionC3R1.Text = ((c3r1 * 225) / 360).ToString("F");
            txtNewResolutionC3R2.Text = ((c3r2 * 225) / 360).ToString("F");
            txtNewResolutionM1R1.Text = ((m1r1 * 225) / 360).ToString("F");
            txtNewResolutionM1R2.Text = ((m1r2 * 225) / 360).ToString("F");
            txtNewResolutionM2R1.Text = ((m2r1 * 225) / 360).ToString("F");
            txtNewResolutionM2R2.Text = ((m2r2 * 225) / 360).ToString("F");
            txtNewResolutionM3R1.Text = ((m3r1 * 225) / 360).ToString("F");
            txtNewResolutionM3R2.Text = ((m3r2 * 225) / 360).ToString("F");
            txtNewResolutionY1R1.Text = ((y1r1 * 225) / 360).ToString("F");
            txtNewResolutionY1R2.Text = ((y1r2 * 225) / 360).ToString("F");
            txtNewResolutionY2R1.Text = ((y2r1 * 225) / 360).ToString("F");
            txtNewResolutionY2R2.Text = ((y2r2 * 225) / 360).ToString("F");
            txtNewResolutionY3R1.Text = ((y3r1 * 225) / 360).ToString("F");
            txtNewResolutionY3R2.Text = ((y3r2 * 225) / 360).ToString("F");
            txtNewResolutionK1R1.Text = ((k1r1 * 225) / 360).ToString("F");
            txtNewResolutionK1R2.Text = ((k1r2 * 225) / 360).ToString("F");
            txtNewResolutionK2R1.Text = ((k2r1 * 225) / 360).ToString("F");
            txtNewResolutionK2R2.Text = ((k2r2 * 225) / 360).ToString("F");
            txtNewResolutionK3R1.Text = ((k3r1 * 225) / 360).ToString("F");
            txtNewResolutionK3R2.Text = ((k3r2 * 225) / 360).ToString("F");
        }

        public void CalculatePDOffset180DPI()
        {
            txtNewResolutionW1R1.Text = ((w1r1 * 180) / 360).ToString("F");
            txtNewResolutionW1R2.Text = ((w1r2 * 180) / 360).ToString("F");
            txtNewResolutionW2R1.Text = ((w2r1 * 180) / 360).ToString("F");
            txtNewResolutionW2R2.Text = ((w2r2 * 180) / 360).ToString("F");
            txtNewResolutionW3R1.Text = ((w3r1 * 180) / 360).ToString("F");
            txtNewResolutionW3R2.Text = ((w3r2 * 180) / 360).ToString("F");
            txtNewResolutionC1R1.Text = ((c1r1 * 180) / 360).ToString("F");
            txtNewResolutionC1R2.Text = ((c1r2 * 180) / 360).ToString("F");
            txtNewResolutionC2R1.Text = ((c2r1 * 180) / 360).ToString("F");
            txtNewResolutionC2R2.Text = ((c2r2 * 180) / 360).ToString("F");
            txtNewResolutionC3R1.Text = ((c3r1 * 180) / 360).ToString("F");
            txtNewResolutionC3R2.Text = ((c3r2 * 180) / 360).ToString("F");
            txtNewResolutionM1R1.Text = ((m1r1 * 180) / 360).ToString("F");
            txtNewResolutionM1R2.Text = ((m1r2 * 180) / 360).ToString("F");
            txtNewResolutionM2R1.Text = ((m2r1 * 180) / 360).ToString("F");
            txtNewResolutionM2R2.Text = ((m2r2 * 180) / 360).ToString("F");
            txtNewResolutionM3R1.Text = ((m3r1 * 180) / 360).ToString("F");
            txtNewResolutionM3R2.Text = ((m3r2 * 180) / 360).ToString("F");
            txtNewResolutionY1R1.Text = ((y1r1 * 180) / 360).ToString("F");
            txtNewResolutionY1R2.Text = ((y1r2 * 180) / 360).ToString("F");
            txtNewResolutionY2R1.Text = ((y2r1 * 180) / 360).ToString("F");
            txtNewResolutionY2R2.Text = ((y2r2 * 180) / 360).ToString("F");
            txtNewResolutionY3R1.Text = ((y3r1 * 180) / 360).ToString("F");
            txtNewResolutionY3R2.Text = ((y3r2 * 180) / 360).ToString("F");
            txtNewResolutionK1R1.Text = ((k1r1 * 180) / 360).ToString("F");
            txtNewResolutionK1R2.Text = ((k1r2 * 180) / 360).ToString("F");
            txtNewResolutionK2R1.Text = ((k2r1 * 180) / 360).ToString("F");
            txtNewResolutionK2R2.Text = ((k2r2 * 180) / 360).ToString("F");
            txtNewResolutionK3R1.Text = ((k3r1 * 180) / 360).ToString("F");
            txtNewResolutionK3R2.Text = ((k3r2 * 180) / 360).ToString("F");
        }
    }
}
