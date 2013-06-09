"C:\Program Files\Microsoft SDKs\Windows\v6.0A\bin\resgen.exe" AboutBox1.resx SubRenamer.AboutBox1.resources
"C:\Program Files\Microsoft SDKs\Windows\v6.0A\bin\resgen.exe" Form1.resx SubRenamer.Form1.resources 
"C:\Program Files\Microsoft SDKs\Windows\v6.0A\bin\resgen.exe" Properties\Resources.resx SubRenamer.Properties.Resources.resources 

C:\WINDOWS\Microsoft.NET\Framework\v3.5\csc.exe @SubRenamer.rsp 

del SubRenamer.AboutBox1.resources
del SubRenamer.Form1.resources 
del SubRenamer.Properties.Resources.resources 