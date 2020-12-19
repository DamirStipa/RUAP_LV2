using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {

        public static void RunExercise1()
        {
            Post post1 = new Post("Ana", "hello");
            post1.Tag("#oop");

            Post post2 = new Post("Sara", "hi");
            post2.Tag("#life");

            Post post3 = new Post("Marko", "Good day");
            post3.Tag("#world");

            Dictionary<string, Post> posts = new Dictionary<string, Post>();
            posts.Add("Ana", post1);
            posts.Add("Sara", post2);
            posts.Add(post3.AccountName, post3);
            Console.WriteLine(Post.GetAsString(posts));

            foreach(var post in posts)
            {
                Post postClone = new Post(post.Value);
                postClone.Untag();
                Console.WriteLine(postClone);
            }

            Console.WriteLine(Post.GetAsString(posts));








        }
        public static void RunExercise2()
        {
            Console.WriteLine($"Write a number: ");
            int n= int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            Random rand = new Random();

            for(int i=0; i<n; i++)
            {
                list.Add(rand.Next(-10, 11));
            }
           
            Console.WriteLine(string.Join(",", list));



            var listDividedBy3 = Utilities.Filter(list, x => x % 3 == 0&&x!=0);
            Console.WriteLine(string.Join(",", listDividedBy3));

           

            var listInRange = Utilities.Filter(list, x=> x<=5&&x>=-5);
            Console.WriteLine(string.Join(",", listInRange));


        }
        static void Main(string[] args)
        {
            RunExercise1();
        }
    }
}
