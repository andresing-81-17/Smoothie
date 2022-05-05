using NUnit.Framework;
using ConsoleApp;

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-us");

            var s1 = new Smoothie(new string[] { "Banana" });
            var s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            var s3 = new Smoothie(new string[] { "Mango", "Apple", "Pineapple" });
            var s4 = new Smoothie(new string[] { "Pineapple", "Strawberries", "Blueberries", "Mango" });
            var s5 = new Smoothie(new string[] { "Blueberries" });

            Assert.AreEqual(new string[] { "Banana" }, s1.Ingredients, "Test 1: Ingredients should equal { \"Banana\" }");
            Assert.AreEqual("$0.50", s1.GetCost(), "Test 2: GetCost() should equal \"$0.50\"");
            Assert.AreEqual("$1.25", s1.GetPrice(), "Test 3: GetPrice() should equal \"$1.25\"");
            Assert.AreEqual("Banana Smoothie", s1.GetName(), "Test 4: GetName() should equal \"Banana Smoothie\"");
            Assert.AreEqual(new string[] { "Raspberries", "Strawberries", "Blueberries" }, s2.Ingredients, "Test 5: Ingredients should equal { \"Raspberries\", \"Strawberries\", \"Blueberries\" }");
            Assert.AreEqual("$3.50", s2.GetCost(), "Test 6: GetCost() should equal { \"Banana\" }");
            Assert.AreEqual("$8.75", s2.GetPrice(), "Test 7: GetPrice() should equal \"$8.75\"");
            Assert.AreEqual("Blueberry Raspberry Strawberry Fusion", s2.GetName(), "Test 8: GetName() should equal \"Blueberry Raspberry Strawberry Fusion\"");
            Assert.AreEqual(new string[] { "Mango", "Apple", "Pineapple" }, s3.Ingredients, "Test 9: Ingredients should equal { \"Mango\", \"Apple\", \"Pineapple\" }");
            Assert.AreEqual("$7.75", s3.GetCost(), "Test 10: GetCost() should equal \"$7.75\"");
            Assert.AreEqual("$19.38", s3.GetPrice(), "Test 11: GetPrice() should equal \"$19.38\"");
            Assert.AreEqual("Apple Mango Pineapple Fusion", s3.GetName(), "Test 12: GetName() should equal \"Apple Mango Pineapple Fusion\"");
            Assert.AreEqual(new string[] { "Pineapple", "Strawberries", "Blueberries", "Mango" }, s4.Ingredients, "Test 13: Ingredients should equal { \"Pineapple\", \"Strawberries\", \"Blueberries\", \"Mango\" }");
            Assert.AreEqual("$8.50", s4.GetCost(), "Test 14: GetCost() should equal \"$8.50\"");
            Assert.AreEqual("$21.25", s4.GetPrice(), "Test 15: GetPrice() should equal \"$21.25\"");
            Assert.AreEqual("Blueberry Mango Pineapple Strawberry Fusion", s4.GetName(), "Test 16: GetName() should equal \"Blueberry Mango Pineapple Strawberry Fusion\"");
            Assert.AreEqual(new string[] { "Blueberries" }, s5.Ingredients, "Test 17: Ingredients should equal { \"Blueberries\" }");
            Assert.AreEqual("$1.00", s5.GetCost(), "Test 18: GetCost() should equal \"$1.00\"");
            Assert.AreEqual("$2.50", s5.GetPrice(), "Test 19: GetPrice() should equal \"$8.75\"");
            Assert.AreEqual("Blueberry Smoothie", s5.GetName(), "Test 20: GetName() should equal { \"Blueberry Smoothie\" }");
        }
    }
}