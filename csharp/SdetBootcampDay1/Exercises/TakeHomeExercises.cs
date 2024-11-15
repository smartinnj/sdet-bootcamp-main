using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    /**
     * TODO: make sure that this class is recognized by NUnit as a class that contains tests.
     */
    public class TakeHomeExercises
    {
        /**
         * TODO: write a test that creates a new instance of the OrderHandler class,
         * places a new order for 1 copy of FIFA 24 (use the OrderItem.FIFA_24 enum value)
         * and verifies that the remaining number of copies of FIFA_24 on stock is 9.
         */
        [Test]
        public void TakeHome1(){
            OrderHandler orderH = new OrderHandler();

            orderH.OrderAndPay(OrderItem.FIFA_24, 1);

            Assert.That(orderH.GetStockFor(OrderItem.FIFA_24), Is.EqualTo(9));

            var getStockError = Assert.Throws<ArgumentException>(()=>{
                orderH.GetStockFor(OrderItem.DayOfTheTentacle);
            });
            Assert.That(getStockError!.Message, Is.EqualTo($"Unknown item {OrderItem.DayOfTheTentacle}"));
            
        } 
        
        

        /**
         * TODO: write a test that creates a new instance of the OrderHandler class
         * and verifies that placing an order for 101 copies of Fortnite yields an
         * ArgumentException with the message 'Insufficient stock for item Fortnite'.
         */
        [Test]
        public void TakeHome2(){
            OrderHandler order2 = new OrderHandler();

            var ovrExc = Assert.Throws<ArgumentException>(() =>
            {
                order2.OrderAndPay(OrderItem.Fortnite, 101);
            });

            Assert.That(ovrExc!.Message, Is.EqualTo($"Insufficient stock for item {OrderItem.Fortnite}"));
        }

        /**
         * TODO: write a test that creates a new instance of the OrderHandler class
         * and verifies that trying to add new stock for Day Of The Tentacle yields
         * an ArgumentException with the message 'Unknown item DayOfTheTentacle'.
         */
        [Test] 
        public void TakeHome3(){
            OrderHandler order3 = new OrderHandler();

            var stockError = Assert.Throws<ArgumentException>(() =>
            {
                order3.AddStock(OrderItem.DayOfTheTentacle, 10);
            });

            Assert.That(stockError!.Message, Is.EqualTo($"Unknown item {OrderItem.DayOfTheTentacle}"));

            var purchaseError = Assert.Throws<ArgumentException>(() =>
            {
                order3.OrderAndPay(OrderItem.DayOfTheTentacle, 1);
            });
            Assert.That(purchaseError!.Message, Is.EqualTo($"Unknown item {OrderItem.DayOfTheTentacle}"));
        }

        /**
         * TODO: after you have written all of the above tests, calculate the code coverage.
         * What does this tell you? Do we need to write more tests? Can you think of any cases that
         * we haven't covered yet? Add tests for these cases, too and see if you can further improve
         * code coverage.

         I think the code coverage is good but doesn't cover a few scenarios. We are missing a scenario
         for getting the stock argument exception and trying to order an item that doesn't exist. I will add
         these asserts into TakeHome1 and 3 respectively
         */
         

        /**
         * THINK: there are some problems with the code of the OrderHandler class
         * that make it hard to write good tests. Can you spot some of the problems
         * and explain why exactly these are problems? We'll discuss these tomorrow.

         The OrderHandler class does not account for...
         */
    }
}
