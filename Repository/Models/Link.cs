using Repository.Models.Core;

namespace Repository.Models
{
    /// <summary>
    /// Link Entity
    /// </summary>
    public class Link : Entity<long>
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public string SocialMediaIcon { get; set; }

        public long? PersonID { get; set; }

        public Person Person { get; set; }
    }
}
