public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue two items with diffent priorities, dequeue should return.
        // Expected Result: Dequeued item should have higher priority
        Console.WriteLine("Test 1");
        
        priorityQueue.Enqueue("Item 1", 2);
        priorityQueue.Enqueue("Item 2", 1);
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue multiple items with the same highest priority.
        // Expected Result: Dequeued item should be the one closet to the front.
        Console.WriteLine("Test 2");

        priorityQueue.Enqueue("Item 3", 2);
        priorityQueue.Enqueue("Item 4", 2);
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");



        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}