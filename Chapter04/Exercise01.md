1. What does the C# keyword `void` mean?  
**Answer:** The function doesn't return a value.

2. What are some of the differences between imperative and functional programming styles?  
**Answer:** Imperative programs consist of a series of statements instructing the computer what to do at each line. They have variables, which allow for values to be stored and changed. However, this can easily lead to errors. By contrast, functional programs consists solely of functions - there are no mutable variables. This can make the code cleaner leading to fewer bugs.

3. In Visual Studio Code, what is the difference between pressing *F5*, *Cmd + F5*, and *Cmd + Shift + F5*?  
**Answer:** Shown in the program.

1. Where does the `Trace.WriteLine` method write its output to?  
**Answer:** Any configured trace listeners. By default, this is the Debug Console but could also be a log file.

5. What are the five trace levels?  
**Answer:** Off, Error, Warning, Info, and Verbose.

6. What is the difference between `Debug` and `Trace`?  
**Answer:** `Debug` only outputs to attached trace listeners in the Debug configuration, whereas `Trace` outputs to attached trace listeners in *both* the Debug and Release configurations. Hence `Debug` can be used generously throughout the program to minimise errors.

7. When writing a unit test, what re the three As?  
**Answer:** *Arrange* (the inputs and expected outputs); *Act* (get an actual value from the method being tested); *Assert* (compare the expected and actual values).

8. When writing a unit test using `xUnit`, what attribute must you decorate the test methods with?  
**Answer:** The `[Fact]` attribute.

9. What `dotnet` command executes `xUnit` tests?  
**Answer:** The `dotnet test` command.

10. What is TDD?  
**Answer:** Test Driven Development: the principle that unit tests should be written before functions.


