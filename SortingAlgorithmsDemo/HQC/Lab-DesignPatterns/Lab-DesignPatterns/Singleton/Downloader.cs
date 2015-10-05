using System.Net;

namespace Singleton
{
    public class Downloader
    {
        private readonly WebClient _webClient;

        public Downloader()
        {
            this._webClient = new WebClient();
        }

        public void Download(string address, string localFile)
        {
            using (this._webClient)
            {
                this._webClient.DownloadFile(address, localFile);
            }
        }
    }
}
