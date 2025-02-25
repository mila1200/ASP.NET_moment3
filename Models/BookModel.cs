using System.ComponentModel;

namespace Moment3_ASPNET.Models
{
    //modell för böcker
    public class BookModel
    {
        //props
        public int Id { get; set; }

        [DisplayName("Titel")]
        public string? Title { get; set; }

        [DisplayName("Beskrivning")]
        public string? Description { get; set; }

        [DisplayName("Författare")]
        public int? AuthorModelId { get; set; }

        [DisplayName("Författare")]
        public AuthorModel? AuthorModel { get; set; }
    }
}
