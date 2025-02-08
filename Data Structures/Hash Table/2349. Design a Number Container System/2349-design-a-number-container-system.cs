namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 2349. Design a Number Container System
 * Difficulty: Medium
 * Submission Time: 2025-02-08 07:33:48
 * Created by vahtyah on 2025-02-08 07:46:56
*/

public class NumberContainers {
    private readonly Dictionary<int, int> indexToNumber;
    private readonly Dictionary<int, PriorityQueue<int, int>> numberToIndices;

    public NumberContainers() {
        indexToNumber = new Dictionary<int, int>();
        numberToIndices = new Dictionary<int, PriorityQueue<int, int>>();
    }
    
    public void Change(int index, int number) {
        if (indexToNumber.TryGetValue(index, out int oldNumber)) {
            if (numberToIndices.ContainsKey(oldNumber) && 
                numberToIndices[oldNumber].Count > 0) {
            }
        }
        
        indexToNumber[index] = number;
        
        if (!numberToIndices.ContainsKey(number)) {
            numberToIndices[number] = new PriorityQueue<int, int>();
        }
        numberToIndices[number].Enqueue(index, index);
    }
    
    public int Find(int number) {
        if (!numberToIndices.ContainsKey(number) || numberToIndices[number].Count == 0) {
            return -1;
        }

        var pq = numberToIndices[number];
        
        while (pq.Count > 0) {
            int smallestIndex = pq.Dequeue();
            
            if (indexToNumber.TryGetValue(smallestIndex, out int currentNumber) && 
                currentNumber == number) {
                pq.Enqueue(smallestIndex, smallestIndex);
                return smallestIndex;
            }
        }
        
        return -1;
    }
}
 
public class NumberContainers {
    private class Seat
    {
        public int Index {get; set;}
        public bool Valid {get; set;}
    }
    private Dictionary<int, int> indexToNumber = new Dictionary<int, int>();
    private Dictionary<int, Seat> indexToSeat = new Dictionary<int, Seat>();
    private Dictionary<int, PriorityQueue<Seat, int>> numberToSeats = new Dictionary<int, PriorityQueue<Seat, int>>();

    public NumberContainers() {
    }
    
    public void Change(int index, int number) {
        // indexToNumber
        if (this.indexToNumber.TryGetValue(index, out int oldNumber))
        {
            if (oldNumber == number)
            {
                return;
            }
            var oldSeat = indexToSeat[index];
            oldSeat.Valid = false;
        }
        this.indexToNumber[index] = number;

        // indexToSeat
        var newSeat = new Seat(){Index = index, Valid = true};
        indexToSeat[index] = newSeat;

        // numberToSeats
        if (!this.numberToSeats.TryGetValue(number, out PriorityQueue<Seat, int> pq))
        {
            pq = new PriorityQueue<Seat, int>();
            this.numberToSeats[number] = pq;
        }
        pq.Enqueue(newSeat, index);
    }
    
    public int Find(int number) {
        if (!this.numberToSeats.TryGetValue(number, out PriorityQueue<Seat, int> pq))
        {
            return -1;
        }
        while(pq.Count > 0 && !pq.Peek().Valid)
        {
            pq.Dequeue();
        }
        if (pq.Count == 0)
        {
            return -1;
        }
        return pq.Peek().Index;
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */