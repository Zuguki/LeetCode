using System;

namespace addTwoNumbers
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var sol = new Solution();
            Console.WriteLine(sol.AddTwoNumbers(new ListNode(), new ListNode()));
        }
    }
    
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return new ListNode();
        }
    }

     public class ListNode
     {
         public int Val;
         public ListNode Next;
         
         public ListNode(int val=0, ListNode next=null)
         {
             Val = val;
             Next = next;
         }
    }
}
