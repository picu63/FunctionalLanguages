open System
open System.IO

let allLinesFromFile path:string[] =
    File.ReadAllLines(path)

let largestExponential (numbersTuple:(int*float[])[]) = 
    numbersTuple |> Array.map (fun t -> match t with | (i, arr) -> (i, arr.[1] * (log arr.[0])))
    |> Array.maxBy (fun t -> match t with | (i, l) -> l)

let getFloatsFromCsv (line:string) (charToSplit:char) =
    line.Split(charToSplit) |> Array.map float

let printFirstValueFromTuple tuple =
   match tuple with
    | (a, _) -> printfn "Linia numer: %A" a

[<EntryPoint>]
let main argv =
    let readFileLines = allLinesFromFile "p099_base_exp.txt"
    let linesDeconstructedToCalculate = readFileLines |> Array.mapi (fun i l -> (i + 1, getFloatsFromCsv l ','))
    let largest = largestExponential linesDeconstructedToCalculate
    printFirstValueFromTuple largest
    0 // return an integer exit code