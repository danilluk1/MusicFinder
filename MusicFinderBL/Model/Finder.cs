using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicFinderBL.Model {
    public enum MusicWebsites {
        Zaycev,
    }
    public sealed class Finder {

        public string SearchRequest { get; set; }

        private WebClient _webClient;

        public Action ParseFailed;

        public Action ParseSuccess;

        public Action<int, long, long> BarIncrement;

        public Action DownloadSuccess;

        public Finder() {         
            _webClient = new WebClient();
            _webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            _webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
        }

        /*
         * Метод делает запрос к сайтам и смотрит, есть ли данная песня в наличии у них, если да то возвращает название сайта
         */

        public string GetHTML(string songName) {
            List<string> res = new List<string>();
            string result = null;
            StringBuilder reqToSite = new StringBuilder("https://zaycev.net/search.html?query_search=");
            reqToSite.Append(songName.Replace(" ", "+"));

            WebClient wc = new WebClient();
            result = wc.DownloadString(reqToSite.ToString());

            return result;
        }



        public async void ParseAsync(string html) {
            HtmlParser domParser = new HtmlParser();
            IHtmlDocument document = await domParser.ParseDocumentAsync(html);

            List<string> list = new List<string>();

            IHtmlAnchorElement downEl = document.QuerySelectorAll<IHtmlAnchorElement>("a")
                .Where(item => item.ClassName != null && item.ClassName.Contains("musicset-track__download-link track-geo__button")).FirstOrDefault();

            string res = downEl.PathName;

            if (downEl == default) {
                ParseFailed?.Invoke();
            }
            else {
                ParseSuccess?.Invoke();
                DownloadFromSite(res);
            }
        }

        private void DownloadFromSite(string pathToSong) {
            StringBuilder reqToSite = new StringBuilder("https://zaycev.net");
            reqToSite.Append(pathToSong);
            _webClient.DownloadFileAsync(new Uri(reqToSite.ToString()), SearchRequest + ".mp3");
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            DownloadSuccess?.Invoke();
    }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            BarIncrement?.Invoke(e.ProgressPercentage, e.BytesReceived, e.TotalBytesToReceive);
        }

    }
}
