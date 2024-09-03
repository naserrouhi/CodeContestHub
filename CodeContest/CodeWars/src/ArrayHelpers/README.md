## Array Helpers

This kata is designed to test your ability to extend the functionality of built-in classes. In this case, we want you to extend the built-in `Array` class with the following methods: `square()`, `cube()`, `average()`, `sum()`, `even()` and `odd()`.

Explanation:

* `square()` must return a copy of the array, containing all values squared
* `cube()` must return a copy of the array, containing all values cubed
* `average()` must return the average of all array values; on an empty array must return `NaN` (note: the empty array is not tested in Ruby!)
* `sum()` must return the sum of all array values
* `even()` must return an array of all even numbers
* `odd()` must return an array of all odd numbers

Note: the original array **must not** be changed in any case!

### Example

```csharp
var numbers = new int[] { 1, 2, 3, 4, 5 };

numbers.Square(); // must return [1, 4, 9, 16, 25]
numbers.Cube(); // must return [1, 8, 27, 64, 125]
numbers.Average(); // must return 3
numbers.Sum(); // must return 15
numbers.Even(); // must return [2, 4]
numbers.Odd(); // must return [1, 3, 5]
```