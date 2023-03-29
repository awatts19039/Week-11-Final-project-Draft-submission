# Linked Lists
## I. Welcome
* Introduction
    * In computer science, A linked list is a data structure consisting of a sequence of nodes, where each node stores a value and a reference to the next node in the list. Linked lists are a dynamic data structure, meaning that they can grow or shrink in size during runtime.

  *   Linked lists are commonly used to implement other data structures, such as stacks, queues, and hash tables. They are also useful for implementing algorithms that require efficient insertions or deletions at arbitrary positions in a sequence.n `System.Collections.Stack` class, which provides methods for push, pop, and other common stack operations.

* Types of Linked Lists
* ![Linked List](https://devopedia.org/images/article/409/6269.1647166159.png)
  * Singly Linked List: In a singly linked list, each node contains a value and a reference to the next node in the list.
  * Doubly Linked List: In a doubly linked list, each node contains a value, a reference to the next node, and a reference to the previous node.
  * Circular Linked List: In a circular linked list, the last node in the list references the first node, forming a circular loop.
## II. Linked Lists Example
```C#
       public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class LinkedList {
    private ListNode head;
    public LinkedList() {
        head = null;
    }
    public void Add(int val) {
        ListNode newNode = new ListNode(val);
        if (head == null) {
            head = newNode;
        } else {
            ListNode current = head;
            while (current.next != null) {
                current = current.next;
            }
            current.next = newNode;
        }
    }
    public void Remove(int val) {
        if (head == null) {
            return;
        }
        if (head.val == val) {
            head = head.next;
            return;
        }
        ListNode current = head;
        while (current.next != null && current.next.val != val) {
            current = current.next;
        }
        if (current.next != null) {
            current.next = current.next.next;
        }
    }
    public void Print() {
        ListNode current = head;
        while (current != null) {
            Console.Write(current.val + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

```

In this example, This code defines two classes: `ListNode` and `LinkedList. ListNode` represents a node in a linked list, while `LinkedList` represents the linked list itself. Here are some input and output examples for the various methods in the `LinkedList` class:
The output of this program would be:

Example 1: Adding nodes to the list
```C#
LinkedList list = new LinkedList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Print(); // Output: 1 2 3
```
Example 2: Removing a node from the list
```C#
LinkedList list = new LinkedList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Remove(2);
list.Print(); // Output: 1 3

```
Example 3: Removing the head node from the list
```C#
LinkedList list = new LinkedList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Remove(1);
list.Print(); // Output: 2 3

```
Example 4: Removing a non-existent node from the list
```C#
LinkedList list = new LinkedList();
list.Add(1);
list.Add(2);
list.Add(3);
list.Remove(4);
list.Print(); // Output: 1 2 3

```
Example 5: Printing an empty list
```C#
LinkedList list = new LinkedList();
list.Print(); // Output: (empty line)

```
As you can see, the elements in the stack are printed in the reverse order in which they were added (LIFO). When we pop an element from the stack, it is removed from the top of the stack and returned to us. We can then use this element or discard it as needed.

Overall, the stack data structure is useful in many programming applications, such as evaluating expressions, undo/redo functionality, and maintaining a history of visited pages in a web browser.
## III.Application
* linked list data structure using the provided code template. Your linked list should have the following functionalities:
  * A constructor that initializes an empty linked list.
  * A method called `Add` that adds a new node with a given integer value to the end of the linked list.
  * A method called `Remove` that removes the first node with a given integer value from the linked list, if it exists.
  * A method called `Print` that prints all the values in the linked list in order.
* To accomplish this, you will need to use the provided ListNode class, which represents a single node in the linked list. Each node has an integer value and a reference to the next node in the list.
* You should start by creating a new class called `LinkedList` that contains a private instance variable for the head node of the linked list. In the constructor, you should set the head to null to indicate an empty list.
* Then, implement the `Add` method, which should create a new `ListNode` with the given value and add it to the end of the list. If the list is empty, the new node should become the head. Otherwise, you should iterate through the list until you reach the last node and add the new node after it.
* Next, implement the "Remove" method, which should remove the first node with the given value from the list, if it exists. If the head node has the value to be removed, update the head to the next node in the list. Otherwise, you should iterate through the list until you find the node with the value, then remove it by updating the previous node's reference to skip over it.
* Finally, implement the "Print" method, which should iterate through the list and print each node's value.
## IV. Sources
* Wikimedia Foundation. (2023, March 27). Linked list. Wikipedia. Retrieved March 28, 2023, from https://en.wikipedia.org/wiki/Linked_list 
* GeeksforGeeks. (2023, March 21). Linked list data structure. GeeksforGeeks. Retrieved March 28, 2023, from https://www.geeksforgeeks.org/data-structures/linked-list/ 
* Linked list data structure. Programiz. (n.d.). Retrieved March 28, 2023, from https://www.programiz.com/dsa/linked-list 
*  Home. (2023, March 22). Retrieved March 28, 2023, from https://devopedia.org/ 