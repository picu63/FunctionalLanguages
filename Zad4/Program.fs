open System

let hasTheSameChars (s1:string) (s2:string) =
    s1 |> Seq.forall (fun c -> s2.IndexOf(c) >= 0)

let checkNumbersOfMultiply (number : int) (multiplier : int) =
    let numberStr = number.ToString()
    let multipleStr = (number * multiplier).ToString()
    multipleStr.Length = numberStr.Length && hasTheSameChars numberStr multipleStr

let correctMultiply number =
    {2..6} |> Seq.forall (fun multiplier -> checkNumbersOfMultiply number multiplier)

[<EntryPoint>]
let main argv =
    {1..Int32.MaxValue} // listy działają zbyt długo
        |> Seq.find correctMultiply 
        |> fun i -> printf "%i" i
    0