namespace Moment3_ASPNET.Models
{
    public class AuthorModel
    {
        //properties
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<BookModel>? Books { get; set; }
    }
}
