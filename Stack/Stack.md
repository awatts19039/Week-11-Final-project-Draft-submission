# Stacks
## I. Welcome
* Introduction
  * In computer science, a stack is an abstract data type that serves as a collection of elements with two main operations:
    * push, which adds an element to the top of the stack
    * pop, which removes the top element from the stack.
  * The elements in a stack follow a last-in-first-out (LIFO) order, meaning that the most recently added element is the first one to be removed.
    ![Stack Picture](https://www.tutorialspoint.com/data_structures_algorithms/images/stack_representation.jpg)
  * In C#, a stack can be implemented using the built-in `System.Collections.Stack` class, which provides methods for push, pop, and other common stack operations.

Here's an example of how to use the Stack class in C#
## II. Stack Example
```C#
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
```C#
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
Write a applicaton or progam using a stack that allows the user to input GPS data and, when the user hits enter, pops the data back, allowing the user to follow the GPS coordinates in a breadcrumb-like manner. I used random code to generate random longitude and latitude. The following outputs are an example of how the program should work.

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



