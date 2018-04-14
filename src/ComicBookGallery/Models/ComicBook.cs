using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; } //Property will contain HTML Content, so we labeled the property name to reflect this.
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber; 
            }
         }

    // series-title-issuenumber.jpg
    public string CoverImageFileName
    {
        get
        {
            return SeriesTitle.Replace(" ", "-")
                .ToLower() + "-" + IssueNumber + ".jpg";
        }
    }
}
}
