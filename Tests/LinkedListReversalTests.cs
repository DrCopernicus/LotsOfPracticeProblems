using LotsOfPracticeProblems;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class LinkedListReversalTests
    {
        [Test]
        public void OneNodeReversal()
        {
            var head = new LinkedNode(0);

            var reversed = new LinkedListReversal().BumperCartsReverse(head);

            Assert.AreEqual(0, reversed.Value);
            Assert.AreEqual(null, reversed.Next);
        }

        [Test]
        public void SmallListReversal()
        {
            var head = new LinkedNode(0);
            head.Next = new LinkedNode(1);

            var reversed = new LinkedListReversal().BumperCartsReverse(head);

            Assert.AreEqual(1, reversed.Value);
            Assert.AreEqual(0, reversed.Next.Value);
            Assert.AreEqual(null, reversed.Next.Next);
        }

        [Test]
        public void BiggerListReversal()
        {
            var head = new LinkedNode(0);
            head.Next = new LinkedNode(1);
            head.Next.Next = new LinkedNode(2);
            head.Next.Next.Next = new LinkedNode(3);

            var reversed = new LinkedListReversal().BumperCartsReverse(head);

            Assert.AreEqual(3, reversed.Value);
            Assert.AreEqual(2, reversed.Next.Value);
            Assert.AreEqual(1, reversed.Next.Next.Value);
            Assert.AreEqual(0, reversed.Next.Next.Next.Value);
            Assert.AreEqual(null, reversed.Next.Next.Next.Next);
        }
    }
}
