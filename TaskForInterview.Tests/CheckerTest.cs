namespace TaskForInterview.Tests
{
    public class CheckerTest
    {

        [Fact]
        public void CheckSix_NumIsLessThanSix_ShouldReturnStringThatSaysNumIsLessThanSix()
        {
            var num = 3;
            var exercise1 = new Exercise1();

            var result = exercise1.CheckSix(num);

            Assert.Equal($"{num} is less than 6.", result);

        }

        [Fact]
        public void CheckSix_NumIsSix_ShouldReturnStringThatSaysNumIsSix()
        {
            var num = 6;
            var exercise1 = new Exercise1();

            var result = exercise1.CheckSix(num);

            Assert.Equal($"{num} is equal to 6.", result);

        }

        [Fact]
        public void CheckSix_NumIsBiggerThanSix_ShouldReturnStringThatSaysNumIsLessThanSix()
        {
            var num = 7;
            var exercise1 = new Exercise1();

            var result = exercise1.CheckSix(num);

            Assert.Equal($"{num} is more than 6.", result);

        }
    }
}