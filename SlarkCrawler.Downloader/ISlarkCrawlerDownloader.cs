using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlarkCrawler.Downloader
{
    public interface ISlarkCrawlerDownloader
    {
        SlarkCrawlerDownloaderType DownloderType { get; set; }
        string DownloadPath { get; set; }
        Task<HtmlDocument> Download(string crawlUrl);
    }
}
