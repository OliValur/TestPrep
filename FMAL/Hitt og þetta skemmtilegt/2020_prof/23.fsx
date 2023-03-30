// To run: 
// dotnet fsi 23.fsx

// Must use the option type: https://fsharpforfunandprofit.com/posts/the-option-type/

module Problem23 =

    // Recursive function so we need to use the keyword rec
    let rec safeTake n xs =
        match n, xs with
        | 0, _ -> Some []
        | _, [] -> None
        | n, x :: xs ->
            match safeTake (n - 1) xs with
            | None -> None
            | Some ys -> Some(x :: ys)

    // let result = safeTake 3 [16; 20; 5; 4; 2]
    // let result = safeTake 1 [16; 20;]
    let result = safeTake 2 [16; 20; 5; 4; 2]

    printfn "%A" result
