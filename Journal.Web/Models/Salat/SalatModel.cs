namespace Journal.Web.Models.Salat
{
	public class SalatModel
	{
		
			public int Id { get; set; }
			public DateTime? Din { get; set; }
			public string Fajr { get; set; }
			public string Zohr { get; set; }
			public string Asar { get; set; }
			public string Maghreb { get; set; }
			public string Isha { get; set; }
			public string Remarks { get; set; }

	}
}
