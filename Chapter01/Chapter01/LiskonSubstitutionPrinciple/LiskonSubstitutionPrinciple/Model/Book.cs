﻿public class Book : IBook
{
    public string Author { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
}

public class TopicBook : Book
{
    public string Topic { get; set; }
}
