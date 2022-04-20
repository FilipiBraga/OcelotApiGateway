﻿namespace Article.Api.Repositories
{
    public class ArticleRepository : List<Models.Article>
    {
        private static List<Models.Article> _articles = Populate();

        private static List<Models.Article> Populate()
        {
            var result = new List<Models.Article>()
            {
                new Models.Article
                {
                    Id = 1,
                    Title = "How to write it",
                    WriterId = 1,
                    LastUpdate = DateTime.Now
                },
                new Models.Article
                {
                    Id = 2,
                    Title= "Second title",
                    WriterId = 2,
                    LastUpdate = DateTime.Now
                },
                new Models.Article
                {
                    Id = 3,
                    Title= "Third title",
                    WriterId = 3,
                    LastUpdate = DateTime.Now
                }
            };

            return result;

        }

        public List<Models.Article> GetAll()
        {
            return _articles;
        }

        public Models.Article? Get(int id)
        {
            return _articles.FirstOrDefault(x => x.Id == id);
        }
    }
}
