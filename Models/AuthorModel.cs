using System.ComponentModel;

namespace Moment3_ASPNET.Models
{
    //modell för författare
    public class AuthorModel
    {
        //properties
        public int Id { get; set; }

        [DisplayName("Namn")]
        public string? FullName { get; set; }

        [DisplayName("Födelseår")]
        public int? BirthYear { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}
