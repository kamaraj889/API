using HackersAPICore.Models;

namespace HackersAPICore.Interface
{
    public interface IHackerService
    {
        public StoriesResponse GetStories();
    }
}
