namespace Solutions

module Problem7 =
    let solve () : int64 =
        let n = 10001.0
        let upper = n * (log n) + n * ((log (log n))) |> ceil |> int64
        Seq.item 10001 (Primes.primes upper)