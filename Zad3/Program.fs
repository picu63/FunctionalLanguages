// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.IO;

let characterToValue (character:char):int =
    int32(Char.ToUpper(character)) - (int32('A') - 1)

let namesToPoints (names:string[]):int[] = 
    names
    |> Array.sort 
    |> Array.map (fun name -> name.ToCharArray()
                            |> Array.sumBy (fun character -> characterToValue character))

[<EntryPoint>]
let main argv =
    let text = File.ReadAllText("p022_names.txt")
    let allNames = text.Replace("\"", "").Split(',')
    let pointsForEachName = namesToPoints allNames
    let answer = Array.map2 (fun namePoints index -> namePoints*index) pointsForEachName [|1..pointsForEachName.Length|] 
                |> Array.sum
    printf "%i" answer
    0