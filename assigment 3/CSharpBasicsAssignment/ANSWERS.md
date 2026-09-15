# Part G — Short Answers

## Question 1: `.csproj` Contents & Property Verification
```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>

four properties
OutputType: Configured as Exe (Console Application).
TargetFramework: Target framework is set to .NET 10.0 (net10.0).
ImplicitUsings: Set to enable to automatically include common namespaces.
Nullable: Set to enable to enable C# nullable reference types checking.


Question 2: Effect of #region / #endregion
No, #region and #endregion do NOT change the compiled output.

Why use them? هو شكل تنظيمي اكتر وعشان الكود يبقي مقروء احسن يعني لو حد بعدي جه شافه وعشان لو عايز استخدم فانكشن معينة مثلا بس هو مش محبوب عامة ومش دايما انفذه.



Question 3: XML Documentation Comments (///) vs Plain Comments (//)
XML doc comments (///) : بستخدمها مثلا لو عايز وصف لفانكشن معينة أو كلاس أو خاصية مش مفهومة بس مش بستخدمها علطول يعني في حالات معينة.
single-line comments (//) : يستخدمها علطول في الكود لشرح أو تعليق على سطر معين.

Question 4: Global Variables in C# and Closest Equivalent
لان كل حاجه عندي لازم تبقي جوه كلاس 
C# depands on object-oriented programming principles, which means that all variables and methods must be encapsulated within a class or struct. Therefore, C# does not support global variables in the traditional sense. The closest equivalent to global variables in C# is to use static fields or properties within a static class. These static members can be accessed from anywhere in the application without needing to instantiate the class.