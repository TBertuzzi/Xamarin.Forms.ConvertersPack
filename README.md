# Xamarin.Forms.ConvertersPack

Package with multiple converters for Xamarin.Forms.
 
###### This is the component, works on iOS, Android and UWP.

**NuGet**

|Name|Info|
| ------------------- | :------------------: |
|Xamarin.Forms.ConvertersPack|[![NuGet](https://buildstats.info/nuget/Xamarin.Forms.ConvertersPack)](https://www.nuget.org/packages/Xamarin.Forms.ConvertersPack/)|

**Platform Support**

Xamarin.Forms.ConvertersPack is a .NET Standard 2.0 library.Its only dependency is the Xamarin.Forms

## Setup / Usage

Does not require additional configuration. Just install the package in the shared project and use.

You just need to add the reference in your xaml file.

```csharp
    xmlns:converterPack="clr-namespace:Xamarin.Forms.ConvertersPack;assembly=Xamarin.Forms.ConvertersPack"
```

```csharp
     <ContentPage.Resources>
        <ResourceDictionary>
         <converterPack:CurrencyConverter x:Key="CurrencyConverter" />
         <converterPack:UpperTextConverter x:Key="UpperTextConverter" />
        <converterPack:LowerTextConverter x:Key="LowerTextConverter" />
        </ResourceDictionary>
    </ContentPage.Resources>
    
    <StackLayout>

         <Label Text="Enter your name"></Label>
        
         <Entry Placeholder="Your name" Text="{Binding Name}"></Entry>
        
         <Label Text="{Binding Name, Converter={StaticResource UpperTextConverter}}"></Label>
        
         <Label Text="{Binding Name, Converter={StaticResource LowerTextConverter}}"></Label>
        
         <Label Text="Enter your balance"></Label>
        
         <Entry Placeholder="Money" 
              Keyboard="Numeric" 
              Text="{Binding Money, Converter={StaticResource CurrencyConverter}}"></Entry>
        
    </StackLayout>

```

**Available Converters**

*  **CurrencyConverter** : Converts your entry to a money field.
*  **DecimalConverter** : Decimal Converter.
*  **EmptyToBooleanConverter** : Return true if a text value is null or empty.
*  **EqualsConverter** : Compare if two fields are the equals.
*  **HasDataConverter** : Returns whether an object or a list has data.
*  **HexToColorConverter** : Converts hexadecimal to color.
*  **ImageFromByteArrayConverter** : Converts an array of bytes to Image.
*  **ImageFromFileConverter** : Converts an image from a local repository to Image.
*  **InvertedBooleanConverter** : Invert the value of a boolean.
*  **ItemTappedEventArgsConverter** : Converts a selected item to an object. Ideal for Listview.
*  **LowerTextConverter** : Converts your text to lowercase.
*  **NullToBooleanConverter** : Checks the value if it is null and returns true or false.
*  **PlaceholderConverter** : Replaces a null, empty or whitespace value with placeholder text.
*  **RoundedNumberConverter** : Rounds a decimal or double value.
*  **UpperTextConverter** : Converts your text to uppercase.


The complete example can be downloaded here: https://github.com/TBertuzzi/Xamarin.Forms.ConvertersPack/tree/master/ConvertersPackSample
