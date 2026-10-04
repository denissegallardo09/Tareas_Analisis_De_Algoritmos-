public class Solution {
    public int NumIslands(char[][] grid) {
        int islandsCount = 0;
        for (int row = 0; row < grid.Length; row++) {
            for (int col = 0; col < grid[row].Length; col++) {
                if (grid[row][col] == '0') continue;

                islandsCount++;
                SearchLand(grid, row, col);
            }
        }
        return islandsCount;
    }

    private void SearchLand(char[][] grid, int row, int col) {
        if (row < 0 || row >= grid.Length ||
            col < 0 || col >= grid[0].Length
            || grid[row][col] == '0') return;
        
        // Set as visited
        grid[row][col] = '0';

        // left
        SearchLand(grid, row, col - 1);

        // top
        SearchLand(grid, row - 1, col);

        // right
        SearchLand(grid, row, col + 1);

        // buttom
        SearchLand(grid, row + 1, col);
    }
}
