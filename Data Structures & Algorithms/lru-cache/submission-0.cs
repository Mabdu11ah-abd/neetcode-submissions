public class Node
{
    public int key;
    public int value;
    public Node next;
    public Node prev;

    public Node(int key,int value)
    {
        this.key = key;
        this.value = value;
        next= null;
        prev = null;
    }
}

public class LRUCache {
    
    Dictionary <int, Node> cache;
    private int cap;
    private Node left;
    private Node right;


    public LRUCache(int capacity) {
        cap = capacity;
        cache = new Dictionary<int, Node>();
        left = new Node(0, 0);
        right = new Node(0, 0);
        left.next = right;
        right.prev = left;
    }

    private void Insert(Node node)
{
    Node prev = right.prev;

    prev.next = node;
    node.prev = prev;

    node.next = right;
    right.prev = node;
}
    
    private void Remove(Node node)
    {
        Node prev = node.prev;
        Node next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    public int Get(int key) {
        if(cache.ContainsKey(key))
        {
            var node = cache[key];
            Remove(node);
            Insert(node);
            return node.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key))
        {
            Remove(cache[key]);
        }
        Node newNode = new Node(key, value);
        cache[key] = newNode;
        Insert(newNode);

        if(cache.Count > cap)
        {
            Node lru = left.next;
            Remove(lru);
            cache.Remove(lru.key);
        }
    }
}
