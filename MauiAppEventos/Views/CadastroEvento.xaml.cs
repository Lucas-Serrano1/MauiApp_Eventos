using MauiAppEventos.Models;
using MauiAppEventos.Views;
using Microsoft.Maui.Controls;
using System.Data;

namespace MauiAppEventos.Views;

public partial class CadastroEvento : ContentPage
{
    public CadastroEvento()
    {
        InitializeComponent();



        data_inicio.MinimumDate = DateTime.Now;
        data_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        data_termino.MinimumDate = data_inicio.Date.AddDays(1);
        data_termino.MaximumDate = data_inicio.Date.AddMonths(1);
    }

    private async void OnCadastrarEventoClicked(object sender, EventArgs e)
    {
        var evento = (Evento)BindingContext;

        TimeSpan duracao = evento.DataTermino - evento.DataInicio;


        await Navigation.PushAsync(new ResumoEvento(evento));



        if (evento.DataInicio == DateTime.MinValue || evento.DataTermino == DateTime.MinValue)
        {
            await DisplayAlert("Erro", "As datas não estão corretamente configuradas.", "OK");
            return;
        }
    }

    private void data_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {


        DateTime data_selecionada_inicio = e.NewDate;


        data_termino.MinimumDate = data_selecionada_inicio.AddDays(1);


        data_termino.MaximumDate = data_selecionada_inicio.AddMonths(1);


        data_termino.Date = data_selecionada_inicio.AddDays(1);
    }
}