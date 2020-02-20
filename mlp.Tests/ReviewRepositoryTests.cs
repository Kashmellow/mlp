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
            Assert.Equal(0, count);
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
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetById_Returns_Created_Item()
        {
            var expectedContent = new Review() { ReviewId = 0 };
            underTest.Create(expectedContent);

            var result = underTest.GetById(expectedContent.ReviewId);

            Assert.Equal(expectedContent.ReviewId, result.ReviewId);
        }

        [Fact]
        public void Delete_Reduces_Count()
        {
            var myReview = new Review() { Content = "My Review Text" };
            underTest.Create(myReview);

            underTest.Delete(myReview);
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAll_Returns_All()
        {
            underTest.Create(new Review() { Content = "My Review Text" });
            underTest.Create(new Review() { Content = "My Review Text 2" });

            var all = underTest.GetAll();

            Assert.Equal(2, all.Count());
        }


    }
}
