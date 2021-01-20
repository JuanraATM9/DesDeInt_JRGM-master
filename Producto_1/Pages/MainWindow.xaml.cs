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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Producto_1.Pages
{
	/// <summary>
	/// Lógica de interacción para MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Page
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void tabla_Click(object sender, RoutedEventArgs e)
		{
			myNavigationFrame.NavigationService.Navigate(new ProductGrid());		
		}
	}
}
