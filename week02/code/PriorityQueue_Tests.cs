using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Enqueue several items with different priorities, then dequeue all.
    public void TestPriotityQueue_DequeueHighestPriority()
    {
        // Items are dequeued in order of highest priority first.
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
    }

    
    [TestMethod]
    // Enqueue multiple items with the same highest priority.
    
    public void TestPriorityQueue_FIFOSamePriority()
    {
        // The first enqueued item with the highest priority is dequeued first 
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 3);
        pq.Enqueue("D", 1);
        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("D", pq.Dequeue());
    }

    [TestMethod]
    // Dequeue from an empty queue
    
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyDequeue()
    {
        // Exception is thrown
        var pq = new PriorityQueue();
        pq.Dequeue();
    }
}