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
    public List<List<int>> LevelOrder(TreeNode root) {
            
        Queue<TreeNode> treeQueue = new();
        List<List<int>> sol = new();
        if(root == null)
            return sol;
        treeQueue.Enqueue(root);
        while(treeQueue.Count != 0)
        {
            int levelSize = treeQueue.Count;
            List<int> currentLevel = new();

            for(int i = 0 ; i < levelSize ; i++)
            {
                var workingNode = treeQueue.Dequeue();
                currentLevel.Add(workingNode.val);
                if(workingNode.left != null)
                    treeQueue.Enqueue(workingNode.left);
                if(workingNode.right != null)
                    treeQueue.Enqueue(workingNode.right);
            }

            sol.Add(currentLevel);

        }
        return sol;
    }
}
