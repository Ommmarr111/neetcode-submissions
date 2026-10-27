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


public class Solution
{
    public void ReorderList(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode prev = null;
        ListNode current = slow.next;
        slow.next = null;
        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        ListNode first = head;
        ListNode second = prev;
            while(second != null){
                ListNode firstNext = first.next;
                ListNode secondNext = second.next;
                first.next = second;
                second.next = firstNext;
                first = firstNext;
                second = secondNext;
        }
    }
}
