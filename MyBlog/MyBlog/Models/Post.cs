//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBlog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int PostID { get; set; }
        public string Body { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<int> Likes { get; set; }
        public int AuthorID { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
