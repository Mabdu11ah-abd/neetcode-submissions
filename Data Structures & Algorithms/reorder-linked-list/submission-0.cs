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

// head = 1 -> 2 -> 3 -> 4-> 5


// curr = head.next;
// temp  = head; 


public class Solution {
    public void ReorderList(ListNode head) {
        // first get the length of the string

        int length = 0;
        ListNode curr = head;

        while(curr != null)
        {
            curr = curr.next;
            length++;
        }
        curr = head;
        // split the list into two seperate lists;

        for (int i = 0; i < length / 2 - 1; i++)
        {
            curr = curr.next;
        }

        ListNode first = head;
        ListNode second = curr.next;

        curr.next = null;
        // reverse the second list

        ListNode prev = null;
        curr = second;

        while(curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr; 
            curr = next; 
        }

        second = prev;
        curr = first;
        while(first != null && second != null)
        {
        var firstNext = first.next;
        var secondNext = second.next;

        first.next = second;
        if (firstNext == null) {
                // If first half has no next element, we keep second's chain intact
                break;
        }
        second.next = firstNext;

        first = firstNext;
        second = secondNext;
        }
    }
}
