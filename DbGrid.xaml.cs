using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace COMP231_Group2
{
	/// <summary>
	/// Interaction logic for DbGrid.xaml
	/// Window by Jose
	/// </summary>
	public partial class DbGrid : Window
	{

		ObservableCollection<House> dbList = new ObservableCollection<House>(HouseDatabase.GenerateSampleData());
		
		public DbGrid()
		{


			InitializeComponent();

			//Setting the Collection as the dataSource for the grid
			GridDB.ItemsSource = dbList;


			//In case we do something that modified the collection in this page.
			dbList.CollectionChanged += ReloadGrid;

			//Filling the textBox below the grid
			descTxt.Text = FillTextBox();

		}

		private void ReloadGrid(object? sender, NotifyCollectionChangedEventArgs? e)
		{
			GridDB.ItemsSource = null;
			GridDB.ItemsSource = dbList;
		}


		//Modify this method if you want to modify the textbox below the Grid
		private string FillTextBox()
		{
			return "Check out our simple grid for a quick look at homes available across GTA towns. It's perfect whether you're hunting for your dream place or just curious about what's out there.\r\n\r\nGrid Details:\r\nEach home's entry shows:\r\n\r\nRoom Count: How many rooms it has.\r\nBath Count: How many bathrooms are inside.\r\nSize: The total space in square footage.\r\nRegion: Where in the GTA it's located.\r\nFurnished: Whether it comes with furniture (yes/no).\r\nParking Availability: If there's parking on-site (yes/no).\r\nWith this easy-to-understand info, finding your perfect GTA home is a snap.";
		}



	}
}
