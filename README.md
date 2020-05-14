# NMeCabDemo
A small demonstration program for [NMeCab](https://github.com/komutan/NMeCab), a Japanese morphological analyzer developed on .NET.

### Note on package availability
As of this writing (May 2020), there are several nuget packages for MeCab/NMecab available, 
but the _official_ NMeCab packages ([LibNMeCab](https://www.nuget.org/packages/LibNMeCab) and [LibNMeCab.IpaDicBin](LibNMeCab.IpaDicBin)) 
that this demonstration uses are still in prerelease stage,
and you need to check `Include prerelease` check box to find it on `Manage NuGet Package for Solution...` on Visual Studio.

## What is NMeCab?

NMeCab is a C# port of a famous Japanese morphological analyzer [MeCab](https://github.com/taku910/mecab).
It is _not_ a wrapper around the C++ MeCab binary, but a complete rewriting in C#.

## What is this program, NMeCabDemo?

NMeCabDemo is a small demonstration program of NMeCab.

It is primarily for those who are not familiar with MeCab or other Japanese morphological analyzers to know what it does.
Those who know morphological analysis would not find anything exciting.

## Environment

NMeCabDemo is written on the Visual Studio 2017 Express for .NET Framework 4.7.2 using WPF.

I used Framework 4.7.2 and WPF because I plan to use MeCab in my application targeting them.
NMeCab itself is a .NET Standard library, 
so you can use it on wider ranges of frameworks.
