namespace PostgreSqlExample.Api.Request
{
    public class AtricleRequestModel
    {
        public AtricleRequestModel(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set;}

       
    }
}
