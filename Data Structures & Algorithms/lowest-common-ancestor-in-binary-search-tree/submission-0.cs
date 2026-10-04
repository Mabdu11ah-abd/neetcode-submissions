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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // knowing the property of the bst that it divides evenly,  we can deduce that lowest node would be in middle of p and q
        if(root.val < p.val && root.val < q.val)
        {
            return LowestCommonAncestor(root.right, p, q);
        }
        if(root.val > p.val && root.val > q.val )
        {
            return LowestCommonAncestor(root.left, p, q);
        }

        return root;
    }
}
