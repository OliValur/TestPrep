# F-sharp syntax
## Some syntex notes 

* `let a = 10` will create a immutable variable with the integer 10 as value.
    * `let mutable a = 10` would create a mutable variable.
    > Variables are immutable by default unless specified, quite oposite how it is in `JavaScript` where variables are mutable by default unless you use `const`. Which makes things a bit confusing if you are familiar with that language, since `let` would mean a mutable variable.
* `=` is actually a equality operator in this language, so `a = 20` does not work.
* `a <- 20` will assign 20 to the existing variable `a` if it were mutable, so the `<-` arrow assigns values in this language.
* Collections are immutable, such as `let items = [1..5]` will be an array that cannot be changed in any way.

### Declairing a function
```fsharp
let prefix prefixStr baseStr = 
    prefixStr + ", " + baseStr

// creates a function named prefix that takes in two arguments, both strings
// it knows that it should return a string

prefix "Hello" "David" 
// returns "Hello, David"
```

### Loops (Sequence)
```fsharp
let names = ["David", "Maria", "Alex"]

names
|> Seq.map (prefix "hello")
// prints out a string for each of the names using the prefix function 
// from previous example. ["Hello, David", "Hello, Maria", "Hello, Alex"]
```
> The language is smart enough to correct the function to include the second parameter even if it wasn't specified, so the sequence is using _partial application_. It basically returns a new function that has the parameters that you specified through the sequence.


### Currying
> F-sharp essentially uses currying in the construction of it's functions, which allows it to do the above example of loops with a partial application. 
>
> Currying is when you break down a function that would take multiple arguments into a series of functions that each take only one argument, wrapping a single parameter function within a single parameter function for each parameter.

```fsharp
let prefixWithHello = prefix "Hello"
// Creates a function that has been partially filled

names
|> Seq.map prefixWithHello
// Gives the same result as the loop example
// ["Hello, David", "Hello, Maria", "Hello, Alex"]
```

### Pipeline operator
The pipeline operator `|>` lets you chain together functions, passing the return value of each to the next function in the pipeline. This makes it easier to layer together functions.

```fsharp

let exclaim s = 
    s + "!"
// Just adds a explaimation point to a given string

names
|> Seq.map prefixWithHello
|> Seq.map exclaim
// returns ["Hello, David!", "Hello, Maria!", "Hello, Alex!"]
```

### Function composition
The following example will combine the functions `prefixWithHello` and `exclaim` into a single function, like a pipeline. The direction of the arrows indicate in which direction of the flow.

```fsharp
let bigHello = prefixWithHello >> exclaim

names
|> Seq.map bigHello
// returns ["Hello, David!", "Hello, Maria!", "Hello, Alex!"]
```
