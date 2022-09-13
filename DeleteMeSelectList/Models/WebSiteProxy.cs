namespace DeleteMeSelectList.Models
{
    public class WebSiteProxy
    {
        public int WebSiteId { get; set; }
        public string WebSiteName { get; set; }

        public WebSiteProxy(int WebSiteId, string WebSiteName)
        {
            this.WebSiteId = WebSiteId;
            this.WebSiteName = WebSiteName;
        }
    }
}
