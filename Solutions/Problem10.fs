namespace Solutions

module Problem10 =
    let solve () : int64 =
        Seq.sum (Primes.primes 2000000L) - 1L