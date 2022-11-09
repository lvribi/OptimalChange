using MyCoinChange;
using Newtonsoft.Json;

namespace MyOptimalChangeApp.Test
{
    public class Tests
    {
        ChangeCoinService _changeCoinService = new ChangeCoinService();
        
        [Test]
        public void OptimalChangeTest_2_OK()
        {
            Change coinExpected = new Change(1, 0, 0);
            
            var result = _changeCoinService.OptimalChange(2);
            
            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
        }
        [Test]
        public void OptimalChangeTest_5_OK()
        {
            Change coinExpected = new Change(0, 1, 0);
            
            var result = _changeCoinService.OptimalChange(5);
            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));

        }
        [Test]
        public void OptimalChangeTest_6_OK()
        {
            Change coinExpected = new Change(3, 0, 0);

            var result = _changeCoinService.OptimalChange(6);

            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));

        }
        [Test]
        public void OptimalChangeTest_7_OK()
        {
            Change coinExpected = new Change(1, 1, 0);

            var result = _changeCoinService.OptimalChange(7);
            
            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
           
        }
        [Test]
        public void OptimalChangeTest_10_OK()
        {
            Change coinExpected = new Change(0, 0, 1);
            
            var result = _changeCoinService.OptimalChange(10);

            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
        }
        [Test]
        public void OptimalChangeTest_12_OK()
        {
            Change coinExpected = new Change(1, 0, 1);
            
            var result = _changeCoinService.OptimalChange(12);

            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
        }
        [Test]
        public void OptimalChangeTest_15_OK()
        {
            Change coinExpected = new Change(0, 1, 1);

            var result = _changeCoinService.OptimalChange(15);

            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
        }
        [Test]
        public void OptimalChangeTest_31_OK()
        {
            Change coinExpected = new Change(3, 1, 2);
            
            var result = _changeCoinService.OptimalChange(31);

            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
        }
        [Test]
        public void OptimalChangeTest_9223372036854775807_OK()
        {
            Change coinExpected = new Change(1, 1, 922337203685477580);

            var result = _changeCoinService.OptimalChange(9223372036854775807);

            var expectedSerialized = JsonConvert.SerializeObject(coinExpected);
            var resulatSerialized = JsonConvert.SerializeObject(result);
            Assert.That(resulatSerialized, Is.EqualTo(expectedSerialized));
        }
    }
}