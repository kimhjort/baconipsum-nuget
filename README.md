# Bacon Ipsum

![logo]

The most delicous way of handling placeholder text and images!

Does your lorem ipsum text long for something a little meatier? Give our generator a try… it's tasty!

Thanks to [baconipsum.com](https://baconipsum.com/)

## Introduction

This packages is gonna be the biggest sausage in your toolkit. Use is to create tasty placeholder text and nice images of bacon.

## Getting Started

Install from <https://nuget.org>

```cmd
Install-Package baconipsum
```

## Usage

Go to `Shared/viewImports`

```csharp
@using baconipsum
```

To create placeholder texts use

```csharp
// Makes the default text
@BaconIpsum.MakeBacon();

//Handles number of paragraphs
@BaconIpsum.MakeBacon(int paras);

//Handles number of paragraphs and sentences
@BaconIpsum.MakeBacon(int paras, int sentences)

//Gives an image url
@BaconIpsum.Baconmockup(int width, int height)
```

## Sample

I have included a small sample project. The project is based on ASP.net core 3.1

```html
<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <img src="@BaconIpsum.Baconmockup(200, 100)" alt="bacon" class="img-fluid" />
    <p>@BaconIpsum.MakeBacon()</p>
</div>
```

## Contribute

<https://github.com/firstcontributions/first-contributions>

## Sync to github - what the

Yeah, so my private repo is based on azuredev ops og the script helps me keep the github repo up to date.

Use at own risk!

[logo]: bacon_logo.jpg "bacon ipsum logo"
