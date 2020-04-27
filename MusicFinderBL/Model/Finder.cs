using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;

namespace MusicFinderBL.Model {
    public enum MusicWebsites {
        Zaycev
    }

    public enum PreferedDataType { 
        Bytes,
        Kb,
        Mb,
        Gb
    }

    public sealed class Finder {

        #region Public Properties
        public string SearchRequest { get; set; }
        public string DownloadPath { get; set; }
        List<string> DownloadHistory { get; set; } = new List<string>();
        public PreferedDataType PreferedDataTypeVal { get; set; } = PreferedDataType.Mb;

        #endregion

        private WebClient _webClient;

        public Action ParseFailed;

        public Action ParseSuccess;

        public Action<int, long, long> BarIncrement;

        public Action<string> DownloadSuccess;

        public Finder() {         
            _webClient = new WebClient();
            _webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
            _webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
        }

        public string GetHTML(string songName) {

            StringBuilder reqToSite = new StringBuilder("https://zaycev.net/search.html?query_search=");
            reqToSite.Append(songName.Replace(" ", "+"));

            WebClient wc = new WebClient();
            return wc?.DownloadString(reqToSite.ToString());
        }

        public async void ParseAsync(string html) {

            HtmlParser domParser = new HtmlParser();
            IHtmlDocument document = await domParser.ParseDocumentAsync(html);

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
            _webClient.DownloadFileAsync(new Uri(reqToSite.ToString()), DownloadPath + "\\" + SearchRequest + ".mp3");
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) {
            DownloadHistory.Add(SearchRequest);
            DownloadSuccess?.Invoke(SearchRequest);
        }
        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            BarIncrement?.Invoke(e.ProgressPercentage, e.BytesReceived, e.TotalBytesToReceive);
        }

    }
}
