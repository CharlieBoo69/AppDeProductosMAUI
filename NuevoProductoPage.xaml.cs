using PracticaMauiApp.Models;
using System.Collections.ObjectModel;

namespace PracticaMauiApp;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
	}

	private async void onClickedGuardar(object sender, EventArgs e)
    {

		int cant = Utils.Utils.ListaProducto.Count;
        Utils.Utils.ListaProducto.Add(new Producto
		{
			IdProducto = cant + 1,
			Nombre = Nombre.Text,
			Descripcion = Descripcion.Text,
			Cantidad = Int32.Parse(Cantidad.Text)
		});

		Producto p = Utils.Utils.ListaProducto[cant];
        Console.WriteLine(p.Nombre);

        await Navigation.PopModalAsync();



    }
}