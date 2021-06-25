# Exercise 01 - Test your knowledge
#### 1. What happens when you divide an `int` variable by 0?
**Answer:** The compiler throws an error: 'Division by constant zero'. A `DivideByZeroException` is thrown when dividing an integer or decimal.
#### 2. What happens when you divide a `double` variable by 0?
**Answer:** The variable is given the value of infinity, which is output as '8'.
#### 3. What happens when you overflow an `int` variable, that is, set it to a value beyond its range?
**Answer:** The amount by which the assigned value is over a multiple of `int.MaxValue` is added onto `int.MinValue`. If the statement is in a `checked` block then an `OverflowException` will be thrown.
#### 4. What is the difference between `x = y++` and `x = ++y`
**Answer:** `x = y++` means assign the value `y` to `x` then increase the value of `y` by one, whereas `x = ++y` means increase the value of `y` by one, then assigned that larger value to `x`.
#### 5. What is the difference between `break`, `continue`, and `return` when used inside a loop statement?
**Answer:** `break` stops the current iteration and exits the loop; `continue` stops the current iteration but moves onto the next; and `return` returns from the method.
#### 6. What are the three parts of a `for` statement and which of them are required?
The three parts of a `for` statement are the initialiser, conditonal, and incrementer expressions. Only the conditonal expression is required.
#### 7. What is the difference between the `=` and `==` operators?
`=` is for assignment and initialisation whereas `==` is for checking for equality.
#### 8. Does the fllowing statement compile `for ( ; true; ) ;`
 Yes, but it results in an infinite loop.
#### 9. What does the underscoe _ represent in a switch expression?
The default return value.
#### 10. What interface must an object implement to be enumerated over by using the `foreach` statement?
An object must implement the `IEnumerable` interface.
