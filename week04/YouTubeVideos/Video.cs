class Video
{
    public string _title, _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}