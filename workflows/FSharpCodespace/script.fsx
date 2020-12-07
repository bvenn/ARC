#load "/workspaces/FSharpCodespace/dependencies/.paket/load/netstandard2.0/main.group.fsx"

open System.IO
open Plotly.NET


Directory.GetDirectories("/arc/")

Directory.GetFiles("/arc/assays/yourAssay/dataset")



Chart.Point([1.,2.])
|> Chart.SaveHtmlAs "/arc/runs/yourRunResultName/plot1"