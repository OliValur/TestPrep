// To run: 
// dotnet fsi 21.fsx

module Problem21 =

    let drop xs =
        match xs with
        | [] -> []
        | [ x1 ] -> [ x1 ]
        | [ x1; x2 ] -> [ x1 ]
        | x1 :: x2 :: x3 :: xs -> x1 :: xs

    // drop [] |> Seq.iter (fun x -> printf "%d " x)
    // drop [10] |> Seq.iter (fun x -> printf "%d " x)
    drop [ 10; 20; 30; 40; 50 ]
    |> Seq.iter (fun x -> printf "%d " x)
    // drop [ 10; 20 ]
    // |> Seq.iter (fun x -> printf "%d " x)
