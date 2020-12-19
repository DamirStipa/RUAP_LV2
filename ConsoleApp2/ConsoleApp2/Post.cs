using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Post
    {
        public string AccountName { get; private set; }
        private string text;
        private List<string> tags;
        private DateTime time;

        public Post(string accountName, string text)
        {
            AccountName = accountName;
            this.text = text;
            tags = new List<string>();
            time = DateTime.Now;
        }

        public Post(Post other)
        {
            AccountName = other.AccountName;
            text = other.text;
            time = other.time;
            this.tags = new List<string>(other.tags);

        }

        public void Tag(string tag)
        {
            tags.Add(tag);
        }

        public void Untag()
        {
            this.tags.Clear();
        }

        public override string ToString()
        {
            return $"{AccountName} - {text} - {time} - " + string.Join(" ", tags);

        }

        public static string GetAsString<K, V>(Dictionary<K, V> dictionary)
        {
            string output = string.Empty;
            foreach (var key in dictionary.Keys)
            {
                output += $"Value under [{key}]: {dictionary[key]}{Environment.NewLine}";
            }
            return output;

        }
    }
}
