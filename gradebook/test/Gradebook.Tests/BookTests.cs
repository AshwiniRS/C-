using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(15.1);

            // act
            var actual = book.GetStatistics();

            // assert
            Assert.Equal(52.1, actual.Average, 1);
            Assert.Equal(89.1, actual.High);
            Assert.Equal(15.1, actual.Low);
        }
    }
}
