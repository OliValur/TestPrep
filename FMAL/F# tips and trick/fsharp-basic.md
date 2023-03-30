# F-sharp basic syntax
F-sharp has the advantages of higher level programming languages, while conforming to rules that are better known in lower-level languages. Being strict and strongly typed, but able to detect types and not break if you forget line endings.
* It uses indents to define scopes, similar to python
* F# is a functional programming language, so it uses __higher order functions__ and __currying__, even if you might not be aware of it sometimes.
* All values and variables are __unmutable__ 
    * with all the __currying__ that takes place, it gives he impression of mutable variables, while they are actually just being re-defined within a new scope. 
* The `let` keyword is to declair functions and variables
* The `;;` line-ending is put at the end of code blocks to be executed 
* `dotnet fsi` is the _f-sharp interactive_ terminal.
* There is no `return` keyword, the return value is the vaue of the right-hand-side expression (the conclusion of the expression)

## Defining functions
Here is an example of a function with a single `num` parameter that is an integer. F-sharp knows to return the results of the expression, so the use of `return` is not needed. This function will multiply the given number with itself.
```fsharp
let mulNum num : int = 
    num * num

mulNum 5 // output: 25
```
> In this example we use `let` to create the function `mulNum` that takes the parameter `num` and expected output type is `int` (declairing the expected ouptut type is optional, but it is good to be clear sometimes).

### Recursive functions
> To allow the function to be recursive (call itself), then you need to add the `rec` keyword. 
```fsharp
let rec countDown num : string =
    printfn "%d" num
    if num < 1 then "done"
    else countDown(num - 1) 

countDown 10;; //counts down from 10
```
### Defining parameter types (optional)
The following example is the same function as above, but it explicitly defines the parameter `num` as a integer. F-sharp is good at discovering the intended data type, but being able to define it in this manner could be useful in some situations.
```fsharp
let rec coundDown (num: int) : string =
    printfn "%d" num
    if num < 1 then "done"
    else countDown(num - 1) 
```
## Conditional statements
```fsharp
let checkNum num : string =
    if num > 5 then "larger than 5"
    elif num < 5 then "less than 5"
    else "is equal to 5"
```

## Printing
* `printf` will print the string
* `printfn` will print the sting in a new line