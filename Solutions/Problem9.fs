namespace Solutions

module Problem9 =
    let solve () : int64 =
        let list = [for a in 1L..331L do
                    for b in 2L..499L do
                    for c in 3L..997L do
                        if a + b + c = 1000L then
                            yield (a, b, c)]
        let a, b, c = Seq.find (fun (a, b, c) -> a * a + b * b = c * c) list
        a * b * c