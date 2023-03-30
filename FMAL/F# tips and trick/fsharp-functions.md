
# Functions in `F#`
## Defining functions
```fsharp
let functName paraMeter = paraMeter + paraMeter;;
```
You can use `fun` to say that the vaule of the variable is a _function_
```fsharp
let functName = fun paraMeter -> paraMeter + paraMeter;;
```
> This is a example of a function that takes a parameter and does a arithmatic expression with the arguments, so it can determine automatically that we expect the `paraMeter` to be a number.

#### Define data type
```fsharp
let functName (paraMeter : integer) = paraMeter + paraMeter;;
```
> This example sets `paraMeter` to be a integer. Defining data types is optional, and should probably be avoided unless unavoidable.
```fsharp
let functName paraMeter : float = paraMeter + paraMeter;;
```
> This example declairs that the returned value should be a float 

### Anonymous/nameless functions
> A function does not need a name if it is only used once
```fsharp
(fun paraMeter -> paraMeter + paraMeter) 8;; 
// 8 + 8
```

### Recursive function definitions
If a function's definition depends on itself, then you need to give it a name with `let`. Moreover, you need to say it is recursive with `rec`
```fsharp
let rec fac n = if n = 0 then 1 else n * fac (n-1);;
fac 3;;
// 3 ---> 3 * fac 2
//   ---> 3 * (2 * fac 1)
//   ---> 3 * (2 * (1 * fac 0))
//   ---> 3 * (2 * (1 * 1))
//   ===> 6
```