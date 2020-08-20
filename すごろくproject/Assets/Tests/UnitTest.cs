using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;
namespace Tests
{
    public class UnitTest
    {
        // Testアトリビュートを付ける
        [Test]
        public void ExampleTest()
        {
            // 条件式がtrueだったら成功
            Assert.That(1 < 10);
        }
    }
}