namespace Solutions

module Zip4 =
    let zip4 l1 l2 l3 l4 =
        List.zip l1 (List.zip3 l2 l3 l4) |> List.map (fun (x1,(x2,x3,x4)) -> (x1,x2,x3,x4))