using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Utils.Helpers
{
    public static class TemplatesHelper
    {
        public static class Mail
        {
            public static string GetAccountVerificationTemplate()
            {
                WebClient client = new WebClient();
                //File.ReadAllTextAsync(path)
                //Directory.GetCurrentDirectory TO-DO
                
                return client.DownloadString($"C:\\inetpub\\wwwroot\\API\\Templates\\Mail\\account_verification.html");
            }

            public static string GetTokensSentTemplate()
            {
                WebClient client = new WebClient();
                return client.DownloadString($"C:\\inetpub\\wwwroot\\API\\Templates\\Mail\\tokens_send.html");
            }

            public static string GetTransactionTemplate()
            {
                WebClient client = new WebClient();
                return client.DownloadString($"C:\\inetpub\\wwwroot\\API\\Templates\\Mail\\create_transaction.html");
            }
        }
    }
}
