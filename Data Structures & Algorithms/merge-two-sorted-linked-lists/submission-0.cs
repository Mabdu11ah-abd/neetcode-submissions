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
 

 // 1-2-4
 // 1-3-5
 
 // compare ListNode 1 and 2 
 // if same then curr = 1 and curr = curr.next and curr = 2 curr.next
 // if 1 less than 2 then curr = 1 and curr = curr.next and curr = curr.


public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = new ListNode();
        ListNode curr = head;
        while(list1 != null && list2 !=null)
        {
            if (list1.val <= list2.val)
            {
                curr.next = list1;
                list1 = list1.next;
            }
            else
            {
                curr.next = list2;
                list2 = list2.next;
            }
            curr = curr.next;
        }

        if (list1 != null)
            curr.next = list1;
        else
            curr.next = list2;
        
        return head.next;
    }
}