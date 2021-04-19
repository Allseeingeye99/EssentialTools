using EssentialTools.Models;
using NUnit.Framework;

namespace EssentialTools.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            // arrange (организация)
            IDiscountHelper target = getTestObject();
            decimal total = 200;

            // act (акт)
            var discountedTotal = target.ApplyDiscount(total);

            // assert (утверждение)
            Assert.AreEqual(total * 0.9M, discountedTotal);
        }
    }
}