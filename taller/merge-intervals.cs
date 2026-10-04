public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1)
            return intervals;

        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var newIntervals = new List<int[]>();

        int intervalStart = intervals[0][0];
        int intervalEnd = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++) {
            int currentStart = intervals[i][0];
            int currentEnd = intervals[i][1];

            if (currentStart <= intervalEnd) {
                intervalEnd = Math.Max(intervalEnd, currentEnd);
                continue;
            }
            
            newIntervals.Add(new[] { intervalStart, intervalEnd });
            intervalStart = currentStart;
            intervalEnd = currentEnd;
        }

        // Se agrega el último intervalo formado
        newIntervals.Add(new[] { intervalStart, intervalEnd });

        return newIntervals.ToArray();
    }
}
