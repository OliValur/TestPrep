* [F# lists](https://www.tutorialspoint.com/fsharp/fsharp_lists.htm)
* [List.map](https://bradcollins.com/2015/04/17/f-friday-the-map-function/)
# Lists in F#

* Lists are polymorphic datatype (recursive discriminated union) predefined in `F#`.
* A list is a sequence of elements of the same type of any finite length.
    * This means you cannot mix data types in an array
    * It will assume all the items are same type as first item
* The type of lists over type `t` is `t list`.
* A list is made by iterating the data constructor `::` called _cons_ on the data constructor `[]` (the empty list). 
* Functions on lists are defined by cases of pattern-matching against expressions made of the data constructors `[]` and `::`.
* You use `;` when separating items in an array
* We can create a dictionary by separating the key from the value with `,`
* We can auto-fill an array with integeres with `..` between the start and end value. `[0..4] `
```
sum : int list -> int
prod : int list -> int
```
## Examples
```fsharp
let xs1 = [7; 9; 13] 
// xs1 = 7 :: 9 :: 13 :: [] ;; //this checks if xs1 contains these integers
```
```fsharp
let dict = [ 1, "one"; 2, "two"; 3, "three"];;
//val it : (int * string) list = [(1, "one"); (2, "two"); (3, "three")]
```
```fsharp
let rec sum xs = 
    match xs with
    | [] -> 0
    | x :: xs -> x + sum xs //this is not the same xs as above

sum xs1;; //sum of array in previous example, output: 29
```
* This `sum` function is actually just the current number + the rest of the list recursivly, until we've reached the last item in the array, then we can finally sum things up.
* The function is reusing variable names, which are confined to the scope of the recuring function (so it's actually used to represent the tail/rest of the list )

```fsharp
let rec diffs xs = 
    match xs with
    | [] -> [] //if empty list return
    | [x] -> [] //if single element, return
    | x::(y::_ as xs) -> (y-x) :: diffs xs //if two or more elements...
```
> The `diffs` function is going to return an array that just shows the difference between each item of the array, by subtracting items from previous neighbor until it has finished going through all the items recursively.
>* `(y-x) :: diffs xs` means that it will append the results of `y-x` to the rest of the list (which will be created with the recursion).
