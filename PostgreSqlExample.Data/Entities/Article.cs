using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Entities
{
    public class Article : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public Article() { }

        public Article(string title, string description)
        {
            Title = title;
            Description = description;
        }

    }
}
