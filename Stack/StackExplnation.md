# Stacks
## I. Welcome
* Introduction
    * In computer science, a stack is an abstract data type that serves as a collection of elements with two main operations:
        * push, which adds an element to the top of the stack
        * pop, which removes the top element from the stack.
    * When it comes to efficiently implementing a stack data structure, the choice of the underlying data structure can have a significant impact on the time complexity of its operations, including push, pop, and peek.

One of the most common implementations of a stack is using an array, which offers constant time complexity for push and pop operations, but linear time complexity for inserting or deleting elements from the middle of the array. This means that if you need to resize the array to accommodate more elements than its current capacity, you may end up with an operation that has a time complexity of O(n), where n is the number of elements in the stack.

To overcome this issue, you can implement a dynamic array, which automatically resizes itself when it runs out of capacity. This can be done by doubling the size of the array each time it needs to be resized. This approach has an amortized time complexity of O(1) for push, pop, and peek operations, which makes it more efficient than a fixed-size array.

Another popular implementation of a stack is using a linked list. A linked list offers constant time complexity for push, pop, and peek operations, as long as the head node of the list is accessible. This makes it a good choice for implementing a stack. However, it can have higher memory overhead than an array-based implementation, as each node in the list requires extra memory to store the address of the next node.

In summary, if you want to implement a stack efficiently, you should consider using a dynamic array or a linked list, depending on your requirements for memory usage and time complexity. Both implementations can offer constant time complexity for basic stack operations, with the dynamic array having better performance for resizing operations, and the linked list having lower memory overhead
    * The elements in a stack follow a last-in-first-out (LIFO) order, meaning that the most recently added element is the first one to be removed.
      ![Stack Picture](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Lifo_stack.svg/525px-Lifo_stack.svg.png)
      
    * In C#, a stack can be implemented using the built-in `System.Collections.Stack` class, which provides methods for push, pop, and other common stack operations.

Here's an example of how to use the Stack class in C#
## II. Stack Example
``` c#
       using System;
       using System.Collections;

        class Program
        {
        static void Main(string[] args)
        {
        // create a new stack
        Stack myStack = new Stack();

        // add some elements to the stack
        myStack.Push("apple");
        myStack.Push("banana");
        myStack.Push("cherry");

        // print the elements in the stack
        foreach (object item in myStack)
        {
            Console.WriteLine(item);
        }

        // remove the top element from the stack
        object poppedItem = myStack.Pop();
        Console.WriteLine("Popped item: " + poppedItem);

        // print the elements in the stack again
        foreach (object item in myStack)
        {
            Console.WriteLine(item);
        }
      
    }
```

In this example, we create a new Stack object and add some elements to it using the Push method. We then iterate over the elements in the stack and print them to the console.

Next, we use the Pop method to remove the top element from the stack and assign it to a variable called poppedItem. We print the popped item to the console, and then iterate over the remaining elements in the stack and print them again.

The output of this program would be:
```c#
- cherry
- banana
- apple
- Popped item: cherry
- banana
- apple
```
As you can see, the elements in the stack are printed in the reverse order in which they were added (LIFO). When we pop an element from the stack, it is removed from the top of the stack and returned to us. We can then use this element or discard it as needed.

Overall, the stack data structure is useful in many programming applications, such as evaluating expressions, undo/redo functionality, and maintaining a history of visited pages in a web browser.
## III.Application
Write a applicaton or progam using a stack that allows the user to input GPS data and, when the user hits enter, pops the data back, allowing the user to follow the GPS coordinates in a breadcrumb-like manner. The following outputs are an example of how the program should work.

```c#
GPS data collected:
(-73.788965, 167.66113)
(-88.695912, -40.68411)
(45.296284, 70.288958)
(43.898944, -104.406991)
(5.059371, 153.163002)

Press enter when you want to return and pop the GPS data...

GPS data popped:
(5.059371, 153.163002)
(43.898944, -104.406991)
(45.296284, 70.288958)
(-88.695912, -40.68411)
(-73.788965, 167.66113)
```
## V.Sources
* Wikimedia Foundation. (2023, March 19). Stack (abstract data type). Wikipedia. Retrieved March 28, 2023, from https://en.wikipedia.org/wiki/Stack_(abstract_data_type)
* GeeksforGeeks. (2023, March 21). Stack Data Structure. GeeksforGeeks. Retrieved March 28, 2023, from https://www.geeksforgeeks.org/stack-data-structure/
* Stack Data Structure. Programiz. (n.d.). Retrieved March 28, 2023, from https://www.programiz.com/dsa/stack 