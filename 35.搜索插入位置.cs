using System.Globalization;
/*
 * @lc app=leetcode.cn id=35 lang=csharp
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums.Length == 0)
        {
            return 0;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if ( nums[i] ==  target)
            {
                return i;
            } 
            else
            {
                if (nums[i] > target)
                {
                    return i ;
                }
            }    
        }
        return nums.Length;
    }
}
// @lc code=end

