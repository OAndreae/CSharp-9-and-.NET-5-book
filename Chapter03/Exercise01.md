# Exercise 01 - Test your knowledge
1. What happens when you divide an `int` variable by 0?
The compiler throws an error: 'Division by constant zero' 
2. What happens when you divide a `double` variable by 0?
The variable is given the value of infinity, which is output as '8'
3. What happens when you overflow an `int` variable, that is, set it to a value beyond its range?
The amount by which the assigned value is over a multiple of `int.MaxValue` is added onto `int.MinValue`
4. What is the difference between `x = y++` and `x = ++y`
`x = y++` means assign the value `y` to `x` then increase the value of `y` by one, whereas `x = ++y` means increase the value of `y` by one, then assigned that larger value to `x`.