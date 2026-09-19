/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {

    public bool IsBalanced(TreeNode root) {
        if(root == null)
            return true;
        
        int leftHeight = DFS(root.left);
        int rightHeight = DFS(root.right);

        if(Math.Abs(leftHeight - rightHeight) > 1) 
            return false;
        else
            return IsBalanced(root.left) && IsBalanced(root.right);
        }

    int DFS (TreeNode root)
    {   
        if(root == null)
        {
            return 0;
        }

        int leftHeight = DFS(root.left) +1;
        int rightHeight = DFS(root.right) +1;

        return Math.Max(leftHeight, rightHeight);
    }   
}
