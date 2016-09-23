Namespace nForecast
    Public Class Features
        Public Property forecast As Integer
    End Class

    Public Class Response
        Public Property version As String
        Public Property termsofService As String
        Public Property features As Features
    End Class

    Public Class Forecastday
        Public Property period As Integer
        Public Property icon As String
        Public Property icon_url As String
        Public Property title As String
        Public Property fcttext As String
        Public Property fcttext_metric As String
        Public Property pop As String
    End Class

    Public Class TxtForecast
        Public Property [date] As String
        Public Property forecastday As List(Of Forecastday)
    End Class
    Public Class Simpleforecast
        Public Property forecastday As List(Of Forecastday)
    End Class

    Public Class Forecast
        Public Property txt_forecast As TxtForecast
        Public Property simpleforecast As Simpleforecast
    End Class

    Public Class clsForecast
        Public Property response As Response
        Public Property forecast As Forecast
    End Class


End Namespace