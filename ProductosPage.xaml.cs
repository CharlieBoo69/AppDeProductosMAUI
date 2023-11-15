using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using PracticaMauiApp.Models;
using System;
using System.Collections.ObjectModel;

namespace PracticaMauiApp
{
    public partial class ProductosPage : ContentPage
    {
        private ObservableCollection<Producto> Productos;

        public ProductosPage()
        {
            InitializeComponent();

            // Inicializa la lista de productos como una ObservableCollection
            Productos = new ObservableCollection<Producto>(Utils.Utils.ListaProducto);
            listaProductos.ItemsSource = Productos;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Actualiza la lista de productos cada vez que la página aparece
            Productos.Clear();
            foreach (var producto in Utils.Utils.ListaProducto)
            {
                Productos.Add(producto);
            }
        }

        private async void OnClickNuevoProductoAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NuevoProductoPage());

            var toast = Toast.Make("On click boton nuevo producto", ToastDuration.Short, 14);
            await toast.Show();
        }
    }
}
