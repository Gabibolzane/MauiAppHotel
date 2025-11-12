using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    internal class Hospedagem : HospedagemContratada
    {
        public Quarto QuartoSelecionado { get; set; }
        public int QntAdultos { get; set; }
        public int QntCriancas { get; set; }
        public DateTime? DataCheckIn { get; set; }
        public DateTime? DataCheckOut { get; set; }
    }
}