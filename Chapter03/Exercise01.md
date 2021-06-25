# Exercise 01 - Test your knowledge
1. **What happens when you divide an `int` variable by 0?**
</br> The compiler throws an error: 'Division by constant zero'.
2. **What happens when you divide a `double` variable by 0?**
</br> The variable is given the value of infinity, which is output as '8'.
3. **What happens when you overflow an `int` variable, that is, set it to a value beyond its range?**
</br> The amount by which the assigned value is over a multiple of `int.MaxValue` is added onto `int.MinValue`.
4. **What is the difference between `x = y++` and `x = ++y`**
</br> `x = y++` means assign the value `y` to `x` then increase the value of `y` by one, whereas `x = ++y` means increase the value of `y` by one, then assigned that larger value to `x`.
5. **What are the three parts of a `for` statement and which of them are required?**
</br> Initialiser expression (required); conditonal expression (required); iterator expression (optional).
7. **What is the difference between the `=` and `==` operators?**
</br> `=` is for assignment and initialisation whereas `==` is for checking for equality.
8. Does the fllowing statement compile `for ( ; true; ) ;`
</br> Yes, but it results in an infinite loop.
9. What does the underscoe _ represent in a switch expression?
</br> The default case.
10. What interface must an object implement to be enumerated over by using the `foreach` statement?
</br> `IEnumerable`
