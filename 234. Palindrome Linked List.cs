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
    public bool IsPalindrome(ListNode head) {
        ListNode reverseHalf = ReverseList(MiddleNode(head));
        while(reverseHalf != null)
        {
            if(reverseHalf.val != head.val) return false;
            reverseHalf = reverseHalf.next;
            head = head.next;
        }
        return true;
    }

    private ListNode MiddleNode(ListNode head) 
    {
        ListNode slow = head, fast = head.next;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow.next;
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        while(head != null) 
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }
        return prev;
    }
}