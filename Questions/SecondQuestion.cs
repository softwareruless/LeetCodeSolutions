using System.Numerics;

namespace LeetCodeSolutions
{
    public class SecondQuestion
    {
        public SecondQuestion()
        {
            var list1 = new ListNode(1);
            var current = list1;
            for (int i = 1; i < 32; i++)
            {
                if (i == 31)
                {
                    current.next = new ListNode(1);
                    break;
                }
                current.next = new ListNode(0);
                current = current.next;
            }

            var list2 = new ListNode(5);
            list2.next = new ListNode(6);
            list2.next.next = new ListNode(4);

            var result = AddTwoNumbers(list1,list2);

            Console.WriteLine(result);
        }

        private ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var current1 = l1;
            string number1 = current1.val.ToString();
            while (current1 != null && current1.next != null)
            {
                current1 = current1.next;

                number1 = current1.val.ToString() + number1;
            }

            var current2 = l2;
            string number2 = current2.val.ToString();
            while (current2 != null && current2.next != null)

            {
                current2 = current2.next;
                number2 = current2.val.ToString() + number2;
            }

            var totalINT = BigInteger.Parse(number1) + BigInteger.Parse(number2);
            var total = totalINT.ToString();


            ListNode head = new ListNode(Convert.ToInt32(total.Substring(total.Length - 1, 1)));
            ListNode current = head;

            for (int i = total.Length - 2; i > -1; i--)
            {
                ListNode newNode = new ListNode(Convert.ToInt32(total.Substring(i, 1)));
                current.next = newNode;
                current = newNode;
            }

            return head;

        }


    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


}

