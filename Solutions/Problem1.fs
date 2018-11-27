namespace Solutions

module Problem1 =
    let solve () : int64 =
        List.sum [for a in 1..999 do if a % 3 = 0 || a % 5 = 0 then yield a] |> int64