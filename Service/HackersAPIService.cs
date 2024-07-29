using HackersAPICore.Interface;
using HackersAPICore.Models;
using Newtonsoft.Json;
using System.Net;
using BusinessLayer.Service;

namespace HackersAPICore.Service
{
    public class HackersAPIService :IHackerService
    {
        public StoriesResponse GetStories()
        {
            HackersService hackersservice  = new HackersService();
            var getstories= hackersservice.GetStories();
            StoriesResponse storiesResponse = new StoriesResponse();
            storiesResponse.title = getstories.title;
            storiesResponse.time = getstories.time;
            storiesResponse.score = getstories.score;
            storiesResponse.by = getstories.by;
            storiesResponse.id = getstories.id;
            storiesResponse.descendants = getstories.descendants;
            return storiesResponse;
        }
    }
}
