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
using System.Xml.Linq;

namespace Adaptacion_PrimerProy_SegundoTrim
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private XDocument xml = XDocument.Load("../../xml/xmlProducto.xml");
        public MainWindow()
        {
            InitializeComponent();
            InitCategoriaCMB();
        }

        private void InitCategoriaCMB()
        {
            var listaCategorias = xml.Root.Elements("Categoria").Attributes("IdCategoria");
            for (int i = 0; i < listaCategorias.Count(); i++)
            {
                categoria.Items.Add(listaCategorias.ElementAt(i).Value);
            }
        }

        private void categoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            marca.Items.Clear();
            var listaMarcas = xml.Root.Elements("Categoria").ElementAt(categoria.SelectedIndex).Elements().Attributes("Nombre");
            for (int i = 0; i < listaMarcas.Count(); i++)
            {
                marca.Items.Add(listaMarcas.ElementAt(i).Value);
            }
        }

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            XElement nuevaCat = new XElement("Categoria", new XAttribute("IdCategoria", "Zumos"));
            XElement nuevaMarca = new XElement("Marca", new XAttribute("Nombre", "Bifrutas"));
            nuevaCat.Add(nuevaMarca);
            xml.Save("../../xml/xmlProducto.xml");

        }


    }
}
