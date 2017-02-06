namespace LotsOfPracticeProblems
{
    public class LinkedNode
    {
        public LinkedNode(int value)
        {
            Value = value;
        }

        public LinkedNode Next;
        public int Value;
    }

    public class LinkedListReversal
    {
        public LinkedNode BumperCartsReverse(LinkedNode head)
        {
            LinkedNode previous = null;
            var current = head;
            var next = current.Next;

            while (next != null)
            {
                current.Next = previous;
                previous = current;
                current = next;
                next = current.Next;
            }

            current.Next = previous;

            return current;
        }
    }
}