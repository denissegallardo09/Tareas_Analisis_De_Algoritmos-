public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        int contentChildren = 0;
        foreach (int cookie in s) {
            if (contentChildren < g.Length && cookie >= g[contentChildren])
                contentChildren++;
        }
        return contentChildren;
    }
}
