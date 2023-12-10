namespace Foundation1
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _lengthInSeconds;

        public List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int lengthInSeconds)
        {
            this._title = title;
            this._author = author;
            this._lengthInSeconds = lengthInSeconds;
        }

        public void AddComment(Comment comment)
        {
            this._comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }
    }
}