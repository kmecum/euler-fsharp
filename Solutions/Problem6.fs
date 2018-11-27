namespace Solutions

module Problem6 =
    let solve () : int64 =
        ([for n in 1L..100L do yield n * n] |> List.sum) - ((([1.0..100.0] |> Seq.sum) ** 2.0) |> int64) |> abs