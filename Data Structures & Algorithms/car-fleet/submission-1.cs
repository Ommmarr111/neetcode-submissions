public class Solution {
    private record struct Car (int Position, double ArrivalTime);
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = new Car[position.Length];
        Stack<double> stack = new Stack<double>();
        for(int i = 0 ; i < position.Length ; i++){
            double ArrivalTime = (double)( target - position[i] ) / speed[i];
            cars[i] = new Car(position[i],ArrivalTime);
        }
        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));

        foreach(Car car in cars){
            if(stack.Count==0)
            stack.Push(car.ArrivalTime);
            else if (car.ArrivalTime > stack.Peek()) {
                stack.Push(car.ArrivalTime);
            }
        }

        return stack.Count;
    }

}
