
# List methods
Just methods that can be used to process lists in various ways.
* [Dotnet docs: Fsharp lists](https://docs.microsoft.com/en-us/dotnet/fsharp/language-reference/lists)

## List.map / List.map2 / List.map3
The `List.map` method goes through a list and applies a given function to each element, resulting in a transformed list.

| Arguments | description |
| --- | --- |
| function | Function that will be applied to every element in the list
| list | The list being processed. Depending on what map method you are using, just add as many list arguments as needed (`List.map3` would for example take 3 lists through arguments). 

```fsharp
let mapList (list: int list) : int list =
    List.map (fun x -> x + 1) list
// mapList [0;1;2;3;4;5];; //output: [1; 2; 3; 4; 5; 6]
```
> The `List.map2` method does the same thing, but allows you to feed it two lists and it returns a single list. As expected, the `List.map3` will take 3 lists and output a single list.
>```fsharp
>let mapList2 (listX: int list) (listY: int list) : int list = 
>    List.map2 (fun x y -> x + y) listX listY
>//mapList2 [0;1;2;3;4;5] [0;1;2;3;4;5];; //output: [0; 2; 4; 6; 8; 10]
>```

## List.fold 
This method folds/collapses a list into a single element. The method takes 3 arguments: `func`, `init` and `list`. 

| Arguments | description |
| --- | --- |
| function | a function that will process the list. It takes two arguements, the `accumilator` and the `element` being processed.
| init | initial state of the accumilator (the returned results of the fold)
| list | the list that the function will be applied to

```fsharp
let sumList (list: int list) : int = 
    List.fold (fun acc elem -> (acc + elem)) 0 list
// sumList [3;5;2;5];; //output: 15
```

>Same functionality done with recursion
>```fsharp
>let rec sumListRec (list: int list) : int = 
>    match list with
>    | []           -> 0
>    | head::tail   -> head + (sumListRec tail)
>//sumListRec [3;5;2;5];; //output: 15
>```