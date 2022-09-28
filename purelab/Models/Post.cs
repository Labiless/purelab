namespace purelab.Models
{
    public class Post
    {
        public int Id { set; get; }
        public String Category { get; set; } = "Category";
        public String Title { get; set; } = "Lorem ipsum dolor sit amet, consectetur";
        public String Subtitle { get; set; } = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.";
        public String Text { get; set; } = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.";
        public String ImageUrl { get; set; } = "img/carousel_1.jpg";
        public String LinkText { get; set; } = "Read more";
        public String LinkUrl { get; set; } = "test";
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public Boolean Active { get; set; } = false;

        public String getActive()
        {
            return Active ? "active" : "";
        }
    }
}
