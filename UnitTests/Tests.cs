using NUnit.Framework;
using NFluent;

namespace Project
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Example()
        {
            var answer = Solution.DoIt("{([]){}()}");
            Check.That(answer).IsTrue();
        }

        [Test]
        public void Test1()
        {
            var answer = Solution.DoIt("{([{S}]]6K[()]}");
            Check.That(answer).IsFalse();
        }

        [Test]
        public void Test2()
        {
            var answer = Solution.DoIt("{C{}[{[a]}RqhL]{y2}}");
            Check.That(answer).IsTrue();
        }
        [Test]
        public void Test3()
        {
            var answer = Solution.DoIt("W12{}{}L{}");
            Check.That(answer).IsTrue();
        }

        [Test]
        public void Test4()
        {
            var answer = Solution.DoIt("h{Pn{GT{h}(c))}");
            Check.That(answer).IsFalse();
        }

        [Test]
        public void Test5()
        {
            var answer = Solution.DoIt("{[{iHTSc}]}p(R)m(){q({})");
            Check.That(answer).IsFalse();
        }

        [Test]
        public void Test6()
        {
            var answer = Solution.DoIt("][");
            Check.That(answer).IsFalse();
        }
    }
}