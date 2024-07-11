using HackersAPICore.Interface;
using HackersAPICore.Models;
using Newtonsoft.Json;
using System.Net;

namespace HackersAPICore.Service
{
    public class HackersAPIService:IHackerService
    {
        public StoriesResponse GetStories()
        {
            StoriesResponse response1 = new StoriesResponse();
            var url = "https://hacker-news.firebaseio.com/v0/item/8863.json?print=pretty";//it should be the url of your api

            string json = (new WebClient()).DownloadString(url);
            return JsonConvert.DeserializeObject<StoriesResponse>(json);
        }

     
    }
}
