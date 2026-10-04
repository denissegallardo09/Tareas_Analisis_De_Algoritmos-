public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var combinations = new List<IList<int>>();
        Backtrack(candidates, target, 0, new List<int>(), combinations);

        return combinations;
    }

    private void Backtrack(
        int[] candidates,
        int target,
        int start,
        List<int> currentCombination,
        List<IList<int>> combinations) {
        if (target == 0) {
            combinations.Add(new List<int>(currentCombination));
            return;
        }
        if (target < 0) return;

        for (int i = start; i < candidates.Length; i++) {
            currentCombination.Add(candidates[i]);
            Backtrack(
                candidates,
                target - candidates[i],
                i,
                currentCombination,
                combinations);

            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}
