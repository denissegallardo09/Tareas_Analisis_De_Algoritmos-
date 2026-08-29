public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fiveBillsCount = 0;
        int tenBillsCount = 0;

        foreach (int bill in bills) {
            switch (bill) {
                case 5:
                    fiveBillsCount++;
                    break;
                case 10:
                    if (fiveBillsCount == 0) return false;
                    fiveBillsCount--;
                    tenBillsCount++;
                    break;
                default:
                    if (tenBillsCount > 0 && fiveBillsCount > 0) {
                        tenBillsCount--;
                        fiveBillsCount--;
                    } else if (fiveBillsCount >= 3) {
                        fiveBillsCount -= 3;
                    } else {
                        return false;
                    }
                    break;
            }
        }
        return true;
    }
}
