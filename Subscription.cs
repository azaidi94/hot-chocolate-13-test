public class Subscription
{
    [Subscribe]
    [Topic(nameof(Mutation.PublishBook))]
    public Book OnPublished([EventMessage] Book publishedBook) =>publishedBook;
    
    }


