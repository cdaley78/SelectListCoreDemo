using Microsoft.AspNetCore.Mvc.Rendering;

namespace DeleteMeSelectList.Models
{
    public class HomeViewModel
    {
        public int CurrentWebSiteId { get; set; }
        public SelectList WebSites { get; set; }
    }
}
