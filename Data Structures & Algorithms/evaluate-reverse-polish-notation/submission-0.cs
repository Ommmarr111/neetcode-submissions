public class Solution {
    public int EvalRPN(string[] tokens) {

        var st = new Stack<int>();
        foreach (string s in tokens)
        {
            if (int.TryParse(s, out int number))
            {
                st.Push(number);
            }
            else
            {
                switch (s)
                {
                case "+": {
                int firstNum = st.Pop();
                int secondNum = st.Pop();
                st.Push(secondNum + firstNum);

                    break;
                }

                case "-": {
                int firstNum = st.Pop();
                int secondNum = st.Pop();
                st.Push(secondNum - firstNum);
                    break;
                }

                case "*": {
                int firstNum = st.Pop();
                int secondNum = st.Pop();
                st.Push(secondNum * firstNum);
                    break;
                }

                case "/": {
                int firstNum = st.Pop();
                int secondNum = st.Pop();
                st.Push(secondNum / firstNum);
                    break;
                }
                }
            }
        }

        return st.Pop();
    }
}
