/*
 * @lc app=leetcode.cn id=136 lang=csharp
 *
 * [136] 只出现一次的数字
 */

// @lc code=start
public class Solution {
    public int SingleNumber(int[] nums) {
        int ret = 0;
        foreach (int e in nums) ret ^= e;
        return ret;
    }
}


// @lc code=end

