using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]


#region FontIcons Embedded
// CUSTOM FONT ICONS WITH "IconMoon" and "Fontello"
[assembly: ExportFont("customfonticons.ttf", Alias = "CustomFontIcons")]
#endregion

#region FontFamily Embedded 
#region FONTFAMILY [Montserrat]
[assembly: ExportFont("Montserrat-Black.ttf", Alias = "Montserrat#900")]
[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "Montserrat#700")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat#600")]
[assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat#500")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat#400")]
#endregion
#endregion