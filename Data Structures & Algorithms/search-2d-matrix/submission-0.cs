public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int left = 0;
        int right = rows * cols - 1;
        while(left<=right){
            int mid = left + (right - left) / 2;
            int value = matrix[mid / cols][mid%cols];
            if (value > target)
                right = mid-1;
            else if(value < target)
                left = mid+1;
            else return true;    
        }
    return false;
    }
}
