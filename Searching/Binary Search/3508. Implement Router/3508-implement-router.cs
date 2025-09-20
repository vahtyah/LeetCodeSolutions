namespace LeetCodeSolutions.Searching/BinarySearch;

/*
 * 3508. Implement Router
 * Difficulty: Medium
 * Submission Time: 2025-09-20 11:09:34
 * Created by vahtyah on 2025-09-20 15:31:29
*/
 
using System.Runtime.CompilerServices;

public class Router {
    private readonly HashSet<(int source, int destination, int timestamp)> packets;
    private readonly Queue<(int source, int destination, int timestamp)> packetQueue;
    private readonly Dictionary<int, List<int>> destinationToTimestamp;
    private readonly int memoryLimit;
    
    private static readonly int[] EmptyArray = new int[0];

    public Router(int memoryLimit) {
        packets = new HashSet<(int, int, int)>(memoryLimit + 1);
        packetQueue = new Queue<(int, int, int)>(memoryLimit);
        destinationToTimestamp = new Dictionary<int, List<int>>(memoryLimit);
        this.memoryLimit = memoryLimit;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool AddPacket(int source, int destination, int timestamp) {
        var packetTuple = (source, destination, timestamp);
        if (!packets.Add(packetTuple)) return false;

        if (packetQueue.Count >= memoryLimit) {
            var oldestPacket = packetQueue.Dequeue();
            packets.Remove(oldestPacket);

            var timestampList = destinationToTimestamp[oldestPacket.destination];
            timestampList.RemoveAt(0);
            
            if (timestampList.Count == 0) {
                destinationToTimestamp.Remove(oldestPacket.destination);
            }
        }

        if (!destinationToTimestamp.TryGetValue(destination, out var timeStamps)) {
            timeStamps = new List<int>();
            destinationToTimestamp[destination] = timeStamps;
        }
        timeStamps.Add(timestamp);

        packetQueue.Enqueue(packetTuple);
        return true;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int[] ForwardPacket() {
        if (packetQueue.Count == 0) return EmptyArray;

        var packet = packetQueue.Dequeue();
        packets.Remove(packet);

        if (destinationToTimestamp.TryGetValue(packet.destination, out var timeStamps)) {
            timeStamps.RemoveAt(0);
            if (timeStamps.Count == 0) {
                destinationToTimestamp.Remove(packet.destination);
            }
        }

        return new int[] { packet.source, packet.destination, packet.timestamp };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int GetCount(int destination, int startTime, int endTime) {
        return destinationToTimestamp.TryGetValue(destination, out var timeStamps) 
            ? CountElementsInRange(timeStamps, startTime, endTime) 
            : 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private int CountElementsInRange(List<int> timeStamps, int startTime, int endTime) {
        if (timeStamps.Count == 0 || startTime > endTime) return 0;

        int leftIndex = FindLeftBound(timeStamps, startTime);
        if (leftIndex >= timeStamps.Count) return 0;
        
        int rightIndex = FindRightBound(timeStamps, endTime);
        return rightIndex - leftIndex;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private int FindLeftBound(List<int> timeStamps, int startTime) {
        int left = 0;
        int right = timeStamps.Count;
        
        while (left < right) {
            int mid = (left + right) >> 1;
            
            if (timeStamps[mid] >= startTime) 
                right = mid;
            else 
                left = mid + 1;
        }
        
        return left;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private int FindRightBound(List<int> timeStamps, int endTime) {
        int left = 0;
        int right = timeStamps.Count;
        
        while (left < right) {
            int mid = (left + right) >> 1;
            
            if (timeStamps[mid] <= endTime) 
                left = mid + 1;
            else 
                right = mid;
        }
        
        return left;
    }
}