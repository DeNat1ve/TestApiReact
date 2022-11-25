namespace TestApi.Entities
{
    public class Block
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Block(int id, string title, string body) 
        {
            Id = id;
            Title = title;
            Body = body;
        }
    }
}