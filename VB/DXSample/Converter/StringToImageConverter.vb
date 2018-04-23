Imports System
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Media.Imaging

Namespace DXSample.Converter
    Public Class StringToImageConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return New BitmapImage(New Uri("/DXSample;component/Images/" & value.ToString(), UriKind.Relative))
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Nothing
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
