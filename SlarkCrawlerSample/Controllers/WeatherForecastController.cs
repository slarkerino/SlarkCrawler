using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlarkCrawler.Core;
using SlarkCrawler.Downloader;
using SlarkCrawler.Pipeline;
using SlarkCrawler.Processor;
using SlarkCrawler.Request;
using SlarkCrawlerSample.Models;

namespace SlarkCrawlerSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> GetAsync()
        {
            var crawler = new SlarkCrawler<TiebaPost>()
                     .AddRequest(new SlarkCrawlerRequest { Url = "https://tieba.baidu.com/f?kw=%E5%8F%8C%E6%A2%A6%E9%95%87&ie=utf-8", Regex = @".*p/.+", TimeOut = 5000 })
                     .AddDownloader(new SlarkCrawlerDownloader { DownloderType = SlarkCrawlerDownloaderType.FromMemory, DownloadPath = @"C:\SlarkCrawlercrawler\" })
                     .AddProcessor(new SlarkCrawlerProcessor<TiebaPost> { })
                     .AddPipeline(new SlarkCrawlerPipeline<TiebaPost> { });

            await crawler.Crawle();

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
