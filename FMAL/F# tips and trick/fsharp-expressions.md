# Expressions
* Expressions are strings ina  concrete syntax. We should think of them as ASTs (Abstract syntax)
* The expressions as we handle them here are abstract syntax (abstract syntax trees, ASTs). A programmer works with concrete syntax.
* Expressions in concrete syntax are (a subclass of all) strings
    * __Parsing__: going from concrete syntax to abstract
    * __Pretty-printing__: going from abstract syntax to concrete

## Arithmetic expressions
>You can write arithmetic expressions, F# makes sure it is well-typed, attempting to infer its type. It then evaluates it for you.
>
>Evaluating (simplification of expressions) is execution paradigm of F# or any functional language. 
>
>Function application is written as the function followed by the argument. No parentheses are needed around the argument unless it is a compound expression.
>
>Simple math expressions, using _integers_ and _floats_ to evaluate statements.

## Expressions as datatypes
> Expressions are strings in concrete syntax, but we really want to think of them as ASTs (abstract syntax trees)
```fsharp
type expr = 
    | Num of int
    | Op of string * expr * expr // Op is operation expression
```

## Abstract and Concrete syntax
* The expressions as we handle them here are abstract syntax. A programmer works with concrete syntax. 
* Expressions in concrete syntax are (a subclass of all) strings
    * __Parsing__ is going fom _abstract_ syntax to _concrete_
    * __Pretty-printing__ is going from _concrete_ syntax to _abstract_.

```fsharp
// Prettyprinting an expression
let rec prettyprint (e : expr) : string = 
    match e with
    | Num i -> string i
    | Op (s, e1, e2) -> "(" + prettyprint e1 + " " + s + " " + prettyprint e2 + ")"

```

## Interpretting an expression by evaluation
### Evaluation by recursion
```fsharp
// Evaluation by recursion
let rec eval (e : expr) : int =
    match e with
    | Num i -> i
    | Op ("+", e1, e2) -> eval e1 + eval e2
    | Op ("*", e1, e2) -> eval e1 * eval e2
    | Op ("-", e1, e2) -> eval e1 - eval e2
    | Op _             -> failwith "unknown primitive"

let e1v = eval e1
let e2v = eval e2
let e3v = eval e3
```

### Evaluating with different meaning
```fsharp
// Interpreting with a different meaning "-"

let rec evalm (e : expr) : int =
    match e with
    | Num i -> i
    | Op ("+", e1, e2) -> evalm e1 + evalm e2
    | Op ("*", e1, e2) -> evalm e1 * evalm e2
    | Op ("-", e1, e2) -> 
         let res = evalm e1 - evalm e2
         if res < 0 then 0 else res 
    | Op _             -> failwith "unknown primitive"


let e4v = evalm (Op ("-", Num 10, Num 27)
```

### Stack machine