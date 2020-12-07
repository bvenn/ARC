cwlVersion: v1.0
class: CommandLineTool
baseCommand: [fsi.exe, /…/workflows/FSharpCodespace/script1.fsx]
inputs:
  inputFiles:
    type:
      type: array
      items: string
    inputBinding:
      position: 1
outputs:
  plotted_data:
    type: File
    outputBinding:
      glob: $(inputs.plot)
