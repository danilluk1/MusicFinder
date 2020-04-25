using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MusicFinderBL.Model {
    public enum MusicWebsites {
        Zaycev,
    }
    public sealed class Finder {
        private string _searchRequest;
        private WebClient _webClient;

        public Finder(string searchReq) {
            _searchRequest = searchReq;
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

            var parser = new HtmlParser();
            var document = parser.ParseDocument(reqToSite.ToString());

            IEnumerable<IElement> items = document.QuerySelectorAll("div")
                .Where(item => item.ClassName != null && item.ClassName.Contains("musicset-track__download-link track-geo__button"));
            foreach (var i in items) {
                res.Add(res.T);
            }
           

            return result;
        }
        
        private MusicWebsites DoRequest(string songName) {

            StringBuilder reqToSite = new StringBuilder("https://zaycev.net/search.html?query_search=");
            reqToSite.Append(songName.Replace(" ", "+"));
            _webClient.DownloadFileAsync(new Uri(reqToSite.ToString()), "");
            return MusicWebsites.Zaycev;
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {

        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            //Логика инкрементирования progressbara
        }

    }
}
