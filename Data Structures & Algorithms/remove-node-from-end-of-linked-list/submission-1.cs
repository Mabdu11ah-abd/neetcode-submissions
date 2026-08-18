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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // simplest solution is to first get the length of the Listnode

        ListNode curr = head;
        int length = 0;
        while( curr!= null)
        {
            curr = curr.next;
            length++;
        }
        if(length <= 1 )
        {
            return null;
        }
        length -= n;
        if(length == 0)
        {
            return head.next;
        }
        curr = head;
        ListNode target = new();

        for(int i =0 ; i<= length -1 ; i++)
        {
            if(i  == length-1)
            {
                target = curr;
                break;
            }
            curr = curr.next;
        }

        // delete the variable now 
        var targetNext = target.next;
        target.next = targetNext.next;
        targetNext = null;



        return head;
    }
}
