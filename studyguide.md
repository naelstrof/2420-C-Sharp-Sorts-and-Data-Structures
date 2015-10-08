# 2420 Study Guide
---
> `lg(n), n, n*lg(n), n^2, 2^n`

> Which one's the best?

1. Trick question: constant!
2. lg(n) is second best.

> What is the complexity of selection sort? Why?

The worst case is if the list was sorted in reversed order. We're counting the amount of swaps and the amount of comparisons.
O(n^2)
For a reversed list, you have one swap per element, and also the comparisons.

> What is the complexity of a linear search? Why?

It's linear. Worst case would take n steps, you're just scanning through the list and making comparisons.

> What is the complexity of a binary search? Why?

The worst case scenario would have to be searching for the element all the way on one of the ends.
For example: The number of times you have to halve n to reach the beginning index as a formula would be: `n/2^c=1`
Solving for c where c is the number of ops: `c=lg(n)`.
Thus the Big O notation would be `O(lg(n))`.

> What is the complexity of a list?

* Access an item: It would stay constant; the list knows where each value is due to **continuous** memory.
* Insertion: You have to move every element to the right. It's linear.
* Deletion: Same thing; moving a certain amount back. It's linear.
* Append to the end: Copy the list, and then create a new value. It's linear.

> What is the complexity of the linked list?

* Access an item: Linear; you just go through the list until you find it.
* Insertion: constant; Only creating a new node and rewiring references.
* Deletion: Same thing.
* Append to the end: Constant.
