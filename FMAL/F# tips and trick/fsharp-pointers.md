# Reference/pointers
A reference points to a memory location holding a value (contents) of some type.

The basic enviornment of `F#` provides a polymorphic reference type as a record type with mutable field values.
```fsharp
// ref : 'a -> 'a ref
let ref x = {contents = x}                // define a new reference,
                                          // initialize contents to x
// ! : 'a ref -> 'a
let ! p = p.contents                      // dereference ref p

// (:=) : 'a ref -> 'a -> unit
let (:=) p y = p.contents <- y            // update ref p to y
```
> `!` without an argument is not valid `F#` syntax, but you should think of the `!` operator as defined like in the following example. It will use the value instead of the reference.

```fsharp
let p = ref 42;;
p;;    //val it : int ref = { contents = 42 }
!p;;   //val it : int = 42

let q = p;;
q;;     //val it : int ref = { contents = 42 }
q.contents <- 500;; 

p;;     //val it : int ref = { contents = 500 }
q;;     //val it : int ref = { contents = 500 }
```
