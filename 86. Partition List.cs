/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) 
    {
        ListNode beforeHead = new ListNode(0), afterHead = new ListNode(0);
        ListNode beforeLast = beforeHead, afterLast = afterHead;

        while(head != null)
        {
            if(head.val < x)
            {
                beforeLast.next = head;
                beforeLast = beforeLast.next;
            }
            else
            {
                afterLast.next = head;
                afterLast = afterLast.next;
            }
            head = head.next;
        }
        
        afterLast.next = null;
        beforeLast.next = afterHead.next;

        return beforeHead.next;
    }
}