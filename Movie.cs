namespace modul10_103022330138
{
    public class Movie
    {
        public String Title { get; set; }
        public String Director { get; set; }
        public List<String> Stars{  get; set; }
        public String Descriptions{  get; set; }

        public Movie(string title, string director, List<string> stars, string descriptions)
        {
            Title = title;
            Director = director;
            Stars = stars;
            Descriptions = descriptions;
        }
    }
}
