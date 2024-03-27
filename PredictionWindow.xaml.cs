using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace COMP231_Group2
{
    /// <summary>
    /// PredictionWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PredictionWindow : Window
    {
        public PredictionWindow()
        {
            InitializeComponent();

            cbNumRoom.Items.Add("1");
            cbNumRoom.Items.Add("2");
            cbNumRoom.Items.Add("3");
            cbNumRoom.Items.Add("4");
            cbNumRoom.Items.Add("5");
            cbNumRoom.Items.Add("6");
            cbNumRoom.SelectedItem="1";

            cbNumBath.Items.Add("1");
            cbNumBath.Items.Add("2");
            cbNumBath.Items.Add("3");
            cbNumBath.SelectedItem = "1";

            cbSize.Items.Add("400");
            cbSize.Items.Add("600");
            cbSize.Items.Add("800");
            cbSize.Items.Add("1000");
            cbSize.Items.Add("1200");
            cbSize.Items.Add("1400");
            cbSize.Items.Add("1600");
            cbSize.Items.Add("1800");
            cbSize.Items.Add("2000");
            cbSize.SelectedItem = "800";

            cbRegion.Items.Add("Downtown Toronto");
            cbRegion.Items.Add("York");
            cbRegion.Items.Add("East York");
            cbRegion.Items.Add("Junction");
            cbRegion.SelectedItem = "Downtown Toronto";

            cbFurnished.Items.Add("Yes");
            cbFurnished.Items.Add("No");
            cbFurnished.SelectedItem = "Yes";

            cbParking.Items.Add("Yes");
            cbParking.Items.Add("No");
            cbParking.SelectedItem = "No";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            House input = new House();
            input.RoomCount = Convert.ToInt32(cbNumRoom.Text);
            input.BathCount = Convert.ToInt32(cbNumBath.Text);
            input.Size = Convert.ToInt32(cbSize.Text);
            input.Region = cbRegion.Text;
            input.Furnished = cbFurnished.Text=="Yes"? true : false;
            input.ParkingAvailable = cbParking.Text == "Yes" ? true : false;

            float pred  =AIManager.Instance.GetPredict(input);

            txtOutput.Text = $"Given Variables : \n" +
                $"Room Number = {input.RoomCount}\n" +
                $"Bath Number = {input.BathCount}\n" +
                $"Size        = {input.Size}\n" +
                $"Region      = {input.Region}\n" +
                $"Furnished   = {input.Furnished}\n" +
                $"Parking     = {input.ParkingAvailable}\n" +
                $"Final Predicted Price = {pred}";

        }
    }
}
