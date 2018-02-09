using System;
using System.Linq;
using System.Collections.Generic;

namespace SocialMediaPost
{
    public class Program
    {
        static Dictionary<string, Dictionary<string, string>> postComments =
            new Dictionary<string, Dictionary<string, string>>();

        static Dictionary<string, int> postLikes =
            new Dictionary<string, int>();

        static Dictionary<string, int> postDislikes =
            new Dictionary<string, int>();

        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "drop the media")
            {
                string[] inputTokens = input.Split(' ');
                string command = inputTokens[0];
                string postName = inputTokens[1];

                switch (command)
                {
                    case "post":
                        {
                            CreatePost(postName);
                            break;
                        }
                    case "like":
                        {
                            LikePost(postName);
                            break;
                        }
                    case "dislike":
                        {
                            DislikePost(postName);
                            break;
                        }
                    case "comment":
                        {
                            string commentatorName = inputTokens[2];
                            string content = string.Join(" ", inputTokens.Skip(3).ToArray());
                            CommentPost(postName, commentatorName, content);
                            break;
                        }
                }

                input = Console.ReadLine();
            }

            foreach (var postCommentData in postComments)
            {
                string postName = postCommentData.Key;
                int likes = postLikes[postName];
                int dislikes = postDislikes[postName];
                Dictionary<string, string> commentsData =
                    postCommentData.Value;
                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}",
                    postName, likes, dislikes);

                Console.WriteLine("Comments:");
                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var commentData in commentsData)
                {
                    string commentatorName = commentData.Key;
                    string commentContent = commentData.Value;

                    Console.WriteLine("*  {0}: {1}", commentatorName, commentContent);
                }
            }
        }

        public static void CreatePost(string postName)
        {
            postComments.Add(postName, new Dictionary<string, string>());//write data in the three dictionaries
            postLikes.Add(postName, 0);                                  //write data in the three dictionaries
            postDislikes.Add(postName, 0);                               //write data in the three dictionaries
        }

        public static void LikePost(string postName)
        {
            postLikes[postName]++;
        }

        public static void DislikePost(string postName)
        {
            postDislikes[postName]++;
        }

        public static void CommentPost(string postName, string commentatorName, string commentContent)
        {
            postComments[postName].Add(commentatorName, commentContent);
        }
    }
}
