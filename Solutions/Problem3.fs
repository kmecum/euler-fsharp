namespace Solutions

module Problem3 =
    let solve () =
        let candidates = Primes.primes (sqrt 600851475143.0 |> floor |> int64) |> Seq.sort |> Seq.rev
        Seq.find (fun c ->  600851475143L % (int64 c) = 0L) candidates