using ANC.Domain.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ANC.Domain.Utils
{
	public class EmailHelper
	{
		private readonly string _rootPath;

		public EmailHelper(string rootPath)
		{
			_rootPath = rootPath;
		}
		public async Task SendEmailAsync(string email, string subject, string htmlMessage, EmailSettings _settings)
		{
			using var client = new SmtpClient(_settings.SmtpServer, _settings.SmtpPort)
			{
				Credentials = new NetworkCredential(_settings.SmtpUser, _settings.SmtpPass),
				EnableSsl = true
			};

			var message = new MailMessage
			{
				From = new MailAddress(_settings.FromEmail, _settings.FromName),
				Subject = subject,
				Body = htmlMessage,
				IsBodyHtml = true
			};

			message.To.Add(email);

			await client.SendMailAsync(message);
		}
		public string ReadTemplate(string fileName)
		{
			var basePath = Path.Combine(Directory.GetCurrentDirectory(), "Templates");
			var path = Path.Combine(basePath, fileName);

			if (!File.Exists(path))
			{
				throw new FileNotFoundException($"Không tìm thấy template: {path}");
			}

			return File.ReadAllText(path, Encoding.UTF8);
		}

	}
}
