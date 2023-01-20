using System.ComponentModel.DataAnnotations;

namespace asp_net_project.Models
{
    public class Book
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Author {get; set;}
        [DataType(DataType.DateTime)] public DateTime ReleaseDate {get; set;}
        public string Genre {get; set;}
    }
}