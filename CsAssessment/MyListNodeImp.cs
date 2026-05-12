namespace CsAssessment
{
    public class MyListNodeImp
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            // 1. Initialize a dummy node and a 'current' pointer
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            // 2. Traverse both lists while neither is empty
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    // Link to list1 node if it's smaller or equal
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    // Link to list2 node
                    current.next = list2;
                    list2 = list2.next;
                }
                // Move the 'current' pointer forward
                current = current.next;
            }

            // 3. Attach remaining nodes from the non-empty list
            current.next = list1 ?? list2;

            // 4. Return the head (skip the dummy node)
            return dummy.next;
        }
    }

}
