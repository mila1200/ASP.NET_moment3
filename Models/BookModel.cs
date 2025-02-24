namespace Moment3_ASPNET.Models
{
    public class BookModel
    {
        //props
        public int Id { get; set; }
        public string? Title { get; set; }

        public string? Description { get; set; }

        public int? AuthorModelId { get; set; }

        public AuthorModel? AuthorModel { get; set; }
    }
}
