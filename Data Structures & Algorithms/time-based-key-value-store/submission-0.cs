public class TimeMap {

    public readonly record struct TimeEntry(string Value, int Timestamp);
    private Dictionary<string, List<TimeEntry>> dict;
    
    public TimeMap() {
        dict = new Dictionary<string,List<TimeEntry>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!dict.ContainsKey(key)){
            dict[key] = new List<TimeEntry>();
        }
        dict[key].Add(new TimeEntry(value,timestamp)); 
    }
    
    public string Get(string key, int timestamp) {
        if(!dict.ContainsKey(key))
        return "";
        int left = 0;
        int right = dict[key].Count - 1;
        string value = "";
        while(left <= right){
            int mid = left + (right-left)/2;
            TimeEntry entry = dict[key][mid];
            if(entry.Timestamp <= timestamp){
                value = entry.Value;
                left = mid + 1;
            }
            else 
            right = mid - 1;
            
        }
        return value;
    }
}
