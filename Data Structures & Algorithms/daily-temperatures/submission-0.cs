public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       var st = new Stack<int>();
       var res = new int[temperatures.Length];  
       for(int i = 0 ; i < temperatures.Length ; i++ ){
        while(st.Count!=0 && temperatures[i] > temperatures[st.Peek()]) {
            int removed = st.Pop();
            res[removed] = i-removed ;
        }
            st.Push(i);
        }
    return res;
    }
}