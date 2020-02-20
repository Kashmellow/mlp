using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using mlp.Repositories;
using mlp.Models;
using System.Linq;


namespace mlp.Tests
{
    public class ReviewRepositoryTests : IDisposable
    {
        private MlpContext db;
        private ReviewRepository underTest;


        public ReviewRepositoryTests()
        {
            db = new MlpContext();
            db.Database.BeginTransaction();
            underTest = new ReviewRepository(db);

        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
            
        }

        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();
            Assert.Equal(4, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new Review()
            {
                Content = "I love this pony",
                ReviewerName = "Carl",
                Rating = 5.0,
                ProductId = 1,
            });

            var count = underTest.Count();
            Assert.Equal(5, count);
        }

        [Fact]
        public void GetById_Returns_Created_Item()
        {
            var expectedReview = new Review()
            {
                Content = "I love this pony",
                ReviewerName = "Carl",
                Rating = 5.0,
                ProductId = 1,
            };
            underTest.Create(expectedReview);

            var result = underTest.GetById(expectedReview.ReviewId);  // The Id was set by EF when we call Create above.

            Assert.Equal(expectedReview.Content, result.Content);
        }

        [Fact]
        public void Delete_Reduces_Count()
        {
            var review = new Review()
            {
                Content = "I love this pony",
                ReviewerName = "Carl",
                Rating = 5.0,
                ProductId = 1,
            };
            underTest.Create(review);

            underTest.Delete(review);
            var count = underTest.Count();

            Assert.Equal(4, count);
        }

        [Fact]
        public void GetAll_Returns_All()
        {
            underTest.Create(new Review()
            {
                Content = "I love this pony",
                ReviewerName = "Carl",
                Rating = 5.0,
                ProductId = 1,
            });

            underTest.Create(new Review()
            {
                Content = "This pony can Fly",
                ReviewerName = "Amelia",
                Rating = 4.6,
                ProductId = 1,
            });

            var all = underTest.GetAll();

            Assert.Equal(6, all.Count());
        }


    }
}
