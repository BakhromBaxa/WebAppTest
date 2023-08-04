using CsvHelper.Configuration.Attributes;

namespace WebApp.Models
{
    public class Student
    {
        [Index(0)]
        public string username { get; set; } = "";
        [Index(1)]
        public string useridentifier { get; set; } = "";
        [Index(2)]
        public string age { get; set; } = "";
        [Index(3)]
        public string city { get; set; } = "";
        [Index(4)]
        public string phonenumber { get; set; } = "";
        [Index(5)]
        public string email { get; set; } = "";
    }
}
