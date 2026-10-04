public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int n = text1.Length;
        int m = text2.Length;

        int[,] matrix = new int[n + 1, m + 1];

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= m; j++) {
                if (text1[i - 1] == text2[j - 1]) {
                    matrix[i, j] = matrix[i - 1, j - 1] + 1;
                }
                else {
                    matrix[i, j] = Math.Max(
                        matrix[i - 1, j],
                        matrix[i, j - 1]
                    );
                }
            }
        }
        return matrix[n, m];
    }
}
