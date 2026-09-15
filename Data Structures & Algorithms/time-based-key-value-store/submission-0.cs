public class TimeMap {
    private Dictionary<string, List<(int Timestamp, string Value)>> _map; 
    public TimeMap() {
        _map = new Dictionary<string , List<(int, string)>>();
    }   
    
    public void Set(string key, string Value, int Timestamp) {
        if(!_map.TryGetValue(key ,out var list))
        {
            list = new List<(int, string)>();
            _map[key] = list;
        }
        list.Add((Timestamp, Value));
    }
    
    public string Get(string key, int timestamp) {
        if(!_map.TryGetValue(key , out var list) || list.Count == 0)
        {
            return "";
        }

        if (timestamp < list[0].Timestamp) {
            return "";
        }

        int left = 0;;
        int right = list.Count -1;
        var result = "";
        while(left <= right)

        {
            int mid  = left + (right - left) /2;

            if (list[mid].Timestamp <= timestamp) {
                result = list[mid].Value;
                left = mid + 1;
            } else {
                right = mid - 1;   
            }
        }

        return result;
    }
}
