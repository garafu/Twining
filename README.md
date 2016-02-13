Twining
==========================

"Twining" is a WPF flat-design style set likes "Twitter Bootstrap".
Can develop flat-design application easily.

**Table of Contents**

* [Getting Started](#getting-started)
* [Quick Reference](#quick-reference)
* [License](#license)


Getting Started
-------------------------


1. Create new "WPF Application"
2. Include "Twining.dll" reference.
3. Add "ResourceDictionary" to the "App.xaml"
```
<Application x:Class="WpfApplication.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             StartupUri="Views/MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary Source="/Twining;component/Themes/Generic.xaml" />
    </Application.Resources>
</Application>
```
4. Add "Style="{Binding Source={StaticResource wnd-metro}}" attribute and value to "Window" element in "MainWindow.xaml".
```
<Window x:Class="WpfApplication.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="350" Width="525"
        Style="{StaticResource wnd-metro}">
    <Grid>
    </Grid>
</Window>
```


Quick Reference
-------------------------

### Window

When you set `wnd-metro` value for `Style` attribute, window appearance is changed to flat-design style.

```
<Window x:Class="WpfApplication.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="350" Width="525"
        Style="{StaticResource wnd-metro}">
  ...
</Window>
```


### Button

You can use following button style like Bootstrap.

* `btn-default`
* `btn-primary`
* `btn-success`
* `btn-info`
* `btn-warning`
* `btn-danger`

Sample code is following.

```
<Button Content="Button" Style="{StaticResource btn-primary}"/>
```


License
--------------------------
"Twining" released under the MIT license.  
Please see [MIT-LICENSE.tx](https://github.com/garafu/Twining/blob/master/MIT-LICENSE.txt)t for details.
