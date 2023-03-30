// To run: 
// dotnet fsi 22.fsx

module Problem22 =

    // First the function filters and finds all the integers that 5 matches
    // Next it returns those values in the power of two
    let sqMul5 xs =
        List.map (fun x -> x * x) (List.filter (fun x -> x % 5 = 0) xs)

    sqMul5 [ 1; 3; 5; 8; 10; 15; -15; 7 ]
    |> Seq.iter (fun x -> printf "%d " x)
    // sqMul5 [ 1
    //          2
    //          3
    //          5
    //          10
    //          11
    //          12
    //          13
    //          -20
    //          -21
    //          -22 ]
    // |> Seq.iter (fun x -> printf "%d " x)
