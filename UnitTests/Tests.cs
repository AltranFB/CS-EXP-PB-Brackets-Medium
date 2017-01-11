using NFluent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project
{
    [TestClass]
    public class Tests
    {
        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving1()
        {
            var answer = Solution.DoIt("{([]){}()}");
            Check.That(answer).IsTrue();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving2()
        {
            var answer = Solution.DoIt("{([{S}]]6K[()]}");
            Check.That(answer).IsFalse();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving3()
        {
            var answer = Solution.DoIt("{C{}[{[a]}RqhL]{y2}}");
            Check.That(answer).IsTrue();
        }
        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving4()
        {
            var answer = Solution.DoIt("W12{}{}L{}");
            Check.That(answer).IsTrue();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving5()
        {
            var answer = Solution.DoIt("h{Pn{GT{h}(c))}");
            Check.That(answer).IsFalse();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving6()
        {
            var answer = Solution.DoIt("{[{iHTSc}]}p(R)m(){q({})");
            Check.That(answer).IsFalse();
        }

        [TestCategory("Problem Solving"), TestMethod]
        public void ProblemSolving7()
        {
            var answer = Solution.DoIt("][");
            Check.That(answer).IsFalse();
        }
        
        [TestCategory("Reliability"), TestMethod]
        public void Reliability1()
        {
            Check.That(Solution.DoIt("")).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Reliability2()
        {
            Check.That(Solution.DoIt(null)).IsTrue();
        }

        [TestCategory("Reliability"), TestMethod]
        public void Reliability3()
        {
            Check.That(Solution.DoIt("([])))]]]")).IsFalse();
        }
    }
}
