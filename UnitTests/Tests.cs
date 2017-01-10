using NFluent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestCategory("Problem Solving"), TestMethod]
        public void Test0()
        {
            var answer = Solution.DoIt("{([]){}()}");
            Check.That(answer).IsTrue();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void Test1()
        {
            var answer = Solution.DoIt("{([{S}]]6K[()]}");
            Check.That(answer).IsFalse();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void Test2()
        {
            var answer = Solution.DoIt("{C{}[{[a]}RqhL]{y2}}");
            Check.That(answer).IsTrue();
        }
        [TestCategory("Problem Solving"), TestMethod]
        public void Test3()
        {
            var answer = Solution.DoIt("W12{}{}L{}");
            Check.That(answer).IsTrue();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void Test4()
        {
            var answer = Solution.DoIt("h{Pn{GT{h}(c))}");
            Check.That(answer).IsFalse();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void Test5()
        {
            var answer = Solution.DoIt("{[{iHTSc}]}p(R)m(){q({})");
            Check.That(answer).IsFalse();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void Test6()
        {
            var answer = Solution.DoIt("][");
            Check.That(answer).IsFalse();
        }
        
        [TestCategory("Reliability"), TestMethod]
        public void Test7()
        {
            Check.That(Solution.DoIt("")).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Test8()
        {
            Check.That(Solution.DoIt(null)).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Test9()
        {
            Check.That(Solution.DoIt("([])))]]]")).IsFalse();
        }
    }
}
