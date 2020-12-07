
#r "nuget: Plotly.NET,2.0.0-alpha2"
#r "nuget: BioFSharp,2.0.0-beta4"
#r "nuget: FSharp.Stats,0.3.0-beta"
#r "nuget: FSharpAux,1.0.0"
#r "nuget: Argu,6.1.1"
#r "netstandard.dll"

open System.IO
open Plotly.NET


Directory.GetDirectories("/arc/")

Directory.GetFiles("/arc/assays/yourAssay/dataset")



Chart.Point([1.,2.])
|> Chart.SaveHtmlAs "/arc/runs/yourRunResultName/plot1_v5"
