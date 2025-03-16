namespace Journal.Domain.Models
{
    public class Salat
    {
        public int Id { get; set; }
        public DateTime? Din { get; set; }
        public string Fajr { get; set; }
        public string Zohr { get; set; }
        public string Asr { get; set; }
        public string Maghreb { get; set; }
        public string Isha { get; set; }
        public string Remarks { get; set; }

    }
}
