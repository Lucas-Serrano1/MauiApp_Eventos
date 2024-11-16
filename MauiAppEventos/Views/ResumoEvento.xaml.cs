using MauiAppEventos.Models;
using Microsoft.Maui.Controls;

namespace MauiAppEventos.Views;

public partial class ResumoEvento : ContentPage
{
    public ResumoEvento()
    {
    }

    public ResumoEvento(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {

        await Navigation.PopAsync();


    }

}