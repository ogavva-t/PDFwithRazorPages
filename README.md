# PDFwithRazorPages

## Edit codes as followings

copy Rotativa/ folder from [Wkhtmltopdf.NetCore.Example repo](https://github.com/fpanaccia/Wkhtmltopdf.NetCore.Example)

```xml
  <ItemGroup>
    <None Update="Rotativa\Linux\wkhtmltopdf">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="Rotativa\Mac\wkhtmltopdf">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    <None Update="Rotativa\Windows\wkhtmltopdf.exe">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
```

```Dockerfile
RUN apt-get update -qq
RUN apt-get -y install libgdiplus libc6-dev
```


```cs
   services.AddWkhtmltopdf();
```

add Constructer to Pages as following
```cs
        public PDFTestModel(IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
        }
```
