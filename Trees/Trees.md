# Trees
## I. Welcome
* Introduction
  *A binary tree is a tree data structure in which each node has at most two children, which are referred to as the left child and the right child. The left child is the smaller comes before the right child in the order of traversal.

* Binary trees are commonly used in computer science for various applications such as searching and sorting algorithms, data compression, and data encryption.
  *A binary tree is defined as a collection of nodes, where each node contains a value and references to its left and right children. If a node does not have a left or right child, then the corresponding reference is set to null. The topmost node of the tree is called the root.
* When looking at efficiency a binary search tree each node has at most two children, and the left subtree of a node contains only keys that are less than or equal to the node's key, while the right subtree contains only keys that are greater than the node's key. The time complexity of operations on a binary search tree depends on the height of the tree. In a balanced binary search tree, the height is O(log n), where n is the number of nodes in the tree. This means that the time complexity of operations such as search, insertion, and deletion are O(log n) in the average and worst case scenarios.

The following diagram shows the structure of a binary tree:

* ![Binary Trees](https://upload.wikimedia.org/wikipedia/commons/thumb/5/5e/Binary_tree_v2.svg/330px-Binary_tree_v2.svg.png)
  *In this example, the root node has a value of 1 and two children have values 7 and 9. Node 7 has two children with values 2 and 6. Node 6 has two children with values of 5 and 11.  Nodes 5, 2, and 11 have no children.
  In the second branch Node 9 has one child node of 9, and that node has one child node of 5.
## II. Basic Operations
* There are several basic operations that can be performed on a binary tree:
1. Inorder traversal:
    1.  In this traversal, we visit the left subtree first, then the root, and then the right subtree. The resulting sequence of nodes is in ascending order if the tree contains only values of a comparable type (e.g., integers, strings).
2. Preorder traversal:
    1. In this traversal, we visit the root first, then the left subtree, and then the right subtree.
3. Postorder traversal:
    1. In this traversal, we visit the left subtree first, then the right subtree, and then the root.
## III. Binary Tree Example
Here's an example of how to implement a simple binary tree in C#. In this example, we will create a binary tree with integer values. The same principles can be applied to other types of data.
```C#
public class Node {
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

public class BinaryTree {
    private Node root;

    public BinaryTree() {
        root = null;
    }

    public void Insert(int value) {
        if (root == null) {
            root = new Node { Value = value };
        } else {
            Insert(root, value);
        }
    }

    private void Insert(Node node, int value) {
        if (value < node.Value) {
            if (node.Left == null) {
                node.Left = new Node { Value = value };
            } else {
                Insert(node.Left, value);
            }
        } else {
            if (node.Right == null) {
                node.Right = new Node { Value = value };
            } else {
                Insert(node.Right, value);
            }
        }
    }

    public void InorderTraversal() {
        InorderTraversal(root);
    }

    private void InorderTraversal(Node node) {
        if (node != null) {
            InorderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InorderTraversal(node.Right);
        }
    }

    public void PreorderTraversal() {
        PreorderTraversal(root);
    }

    private void PreorderTraversal(Node node) {
        if (node != null) {
            Console.Write(node.Value + " ");
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);
        }
    }

    public void PostorderTraversal() {
        PostorderTraversal(root);
    }

    private void PostorderTraversal(Node node) {
        if (node != null) {
            PostorderTraversal(node.Left);
            Post

```

In this example, This code defines two classes: `ListNode` and `LinkedList. ListNode` represents a node in a linked list, while `LinkedList` represents the linked list itself. Here are some input and output examples for the various methods in the `LinkedList` class:
The output of this program would be:

Example 1: Adding nodes to the list
```C#
Input:
BinaryTree tree = new BinaryTree();
tree.Insert(5);
tree.Insert(2);
tree.Insert(7);
tree.Insert(1);
tree.Insert(3);

Output:
Inorder traversal: 1 2 3 5 7
Preorder traversal: 5 2 1 3 7
Postorder traversal: 1 3 2 7 5
```
In this example, we create a binary tree and insert five nodes with values 5, 2, 7, 1, and 3. Then we perform three different traversals on the tree: inorder, preorder, and postorder. The output shows the order in which the nodes are visited during each traversal.


Example 2: Removing a node from the list
```C#
Input:
BinaryTree tree = new BinaryTree();
tree.Insert(10);
tree.Insert(5);
tree.Insert(15);
tree.Insert(12);
tree.Insert(20);

Output:
Inorder traversal: 5 10 12 15 20
Preorder traversal: 10 5 15 12 20
Postorder traversal: 5 12 20 15 10

```

## IV.Application
* In this assignment, you will create a program that uses a binary search tree to store and search for values. The program should allow the user to insert values into the tree, display the tree in order, and search for a specific value.

* Here's a breakdown of the requirements for your program:
    * Define a `Node` class that has a Data property of type int, and `Left` and `Right` properties of type `Node`.
    * Define a `BinarySearchTree` class that has a root property of type `Node`, and the following methods:
        * `Insert(int data)`: inserts a new node with the specified `data` value into the binary search tree.
        * `InsertRec(Node current, int data)`: a recursive helper method that inserts a new node with the specified `data` value into the binary search tree
        * `Search(int value)`: searches for the specified `value` in the binary search tree and returns `true` if it is found, `false` otherwise
        * `SearchRec(Node current, int value)`: a recursive helper method that searches for the specified `value` in the binary search tree
        * `Display()`: displays the binary search tree in-order.
        * `Inorder(Node node)`: a recursive helper method that performs an in-order traversal of the binary search tree.
    * In the `Main` method, create a new instance of the `BinarySearchTree` class and insert the values `50`, `30`, `20`, `40`, `70`, `60`, and `80` into the tree
    * Display the binary search tree in order using the `Display` method.
    * Prompt the user to enter a value to search for, and use the `Search` method to determine if the value is in the tree.
    * Display a message indicating whether the value was found in the tree or not.
* Your program should use recursion to implement the binary search tree methods. Be sure to test your program thoroughly. Attached is an example of inputs and their corresponding outputs to test your program.

```c#
Enter a value to search for:
60
```

```c#
Binary Search Tree:
20 30 40 50 60 70 80 
Enter a value to search for:
60
60 is found in the tree.


```
## V.Sources
* GeeksforGeeks. (2023, March 21). Binary tree data structure. GeeksforGeeks. Retrieved March 28, 2023, from https://www.geeksforgeeks.org/binary-tree-data-structure/ 
* Wikimedia Foundation. (2023, March 1). Binary tree. Wikipedia. Retrieved March 28, 2023, from https://en.wikipedia.org/wiki/Binary_tree 
* Sugandhi, A. (2023, January 24). Binary tree in data structure: A detailed guide. KnowledgeHut. Retrieved March 28, 2023, from https://www.knowledgehut.com/blog/programming/binary-tree-in-data-structure 