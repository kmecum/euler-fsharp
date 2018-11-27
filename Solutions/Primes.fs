namespace Solutions

module Primes =
    let primes (limit:int64) =
        let odds = seq { 3L..2L..limit }
        let composites = [for n in odds do yield! seq { n * n..n * 2L..limit }]
        (Set.ofList [1L; 2L]) + (Set.ofSeq odds) - (Set.ofList composites)