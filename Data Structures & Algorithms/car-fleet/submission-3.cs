public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        if(position.Length == 0 ) return 0;
        Stack<double> stack = new();

        // pair each each speed and position
        (int pos, int spd) [] pair = new (int pos, int spd) [position.Length];
        for(int i = 0; i < position.Length; i++)
        {
             pair[i] = (position[i], speed[i]);
        }

        Array.Sort(pair, (a, b) => b.pos.CompareTo(a.pos));

        foreach(var p in pair)
        {
            stack.Push((double)(target - p.pos) / p.spd);
            if(stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1))
            {
                stack.Pop();
            }

        }
            return stack.Count;
    }
}
