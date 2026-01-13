namespace ANC.Domain.Bases
{
	public class EmailSettings
	{
		public string SmtpServer { get; set; } = "";
		public int SmtpPort { get; set; }
		public string SmtpUser { get; set; } = "";
		public string SmtpPass { get; set; } = "";
		public string FromName { get; set; } = "";
		public string FromEmail { get; set; } = "";
		public string ImapServer { get; set; }
		public int ImapPort { get; set; }
		public string BounceMailbox { get; set; }
		public string BouncePassword { get; set; }
	}
}
