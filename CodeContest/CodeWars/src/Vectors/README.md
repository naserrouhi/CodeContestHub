## Vectors #1

### Let's make this short!

*Remember, this is a kata which focuses on object oriented programming*

* **Task**: Create a class `Vector3D`.

* **Properties**: `X`, `Y`, `Z` and `Length` as `double` and `public` scope and accessors.

* `X`, `Y` and `Z` will be set by test methods.

* `Length` should only have an `get`-accessor which calculates the vector's length.

##Some references, to get into the topic

The length or magnitude or norm of the vector a is denoted by ‖a‖ or, less commonly, |a|, which is not to be confused with the absolute value (a scalar "norm").

The length of the vector a can be computed with the Euclidean norm

### Tests

Final tests include 2 fixed and 125 random tests. They will look like this:

```
double length = new Vector3D()
{
  X = 0,
  Y = 0,
  Z = 2
}.Length;
length == 2 // true
```