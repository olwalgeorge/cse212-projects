using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and verify highest priority is dequeued first
    // Expected Result: "High" (priority 3), "Medium" (priority 2), "Low" (priority 1)
    // Defect(s) Found: Loop in Dequeue was not checking all items (missed last item), and item wasn't being removed from queue. 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with same priority and verify FIFO order for equal priorities
    // Expected Result: "First" should come before "Second" when both have same priority
    // Defect(s) Found: Priority comparison used >= instead of >, breaking FIFO order for equal priorities. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Higher", 3);

        Assert.AreEqual("Higher", priorityQueue.Dequeue());
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Try to dequeue from empty queue
    // Expected Result: Should throw InvalidOperationException
    // Defect(s) Found: No defects - this test was to verify proper exception handling was implemented. 
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add single item and dequeue it
    // Expected Result: Should return the single item
    // Defect(s) Found: No defects - this test was to verify basic functionality works correctly. 
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Only", 5);
        Assert.AreEqual("Only", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Complex scenario with multiple priorities and FIFO within same priority
    // Expected Result: Items should come out in priority order, FIFO within same priority
    // Defect(s) Found: Same defects as earlier tests - loop bounds and priority comparison logic were incorrect. 
    public void TestPriorityQueue_ComplexScenario()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("D", 3);  // Same priority as B, should come after B
        priorityQueue.Enqueue("E", 1);  // Same priority as A, should come after A

        Assert.AreEqual("B", priorityQueue.Dequeue());  // First priority 3
        Assert.AreEqual("D", priorityQueue.Dequeue());  // Second priority 3
        Assert.AreEqual("C", priorityQueue.Dequeue());  // Priority 2
        Assert.AreEqual("A", priorityQueue.Dequeue());  // First priority 1
        Assert.AreEqual("E", priorityQueue.Dequeue());  // Second priority 1
    }
}