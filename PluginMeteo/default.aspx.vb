Imports System.Net
Imports Newtonsoft.Json

Public Class _default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.UserHostAddress <> My.Settings.Host Then
            Response.Write("NON CONSENTITO")
            Exit Sub
        End If
        Try
            Select Case Request.QueryString("TYPE").ToUpper
                Case "CONDITIONS"
                    Try
                        Dim page As String
                        Using w As New WebClient
                            w.Encoding = Encoding.UTF8
                            page = w.DownloadString("http://api.wunderground.com/api/" + My.Settings.Token + "/conditions/lang:IT/q/Italy/" + Request.QueryString("city") + ".json")
                        End Using
                        Dim result = JsonConvert.DeserializeObject(Of nConditions.clsCondition)(page)
                        With result.current_observation
                            Dim printresult As New StringBuilder
                            printresult.AppendLine(String.Join("", Enumerable.Repeat(":wavy_dash:", 10)))
                            printresult.AppendLine("Meteo " & .display_location.city)
                            printresult.AppendLine("Situazione: " + .weather + " " + DecodeEmoji(.icon))
                            printresult.AppendLine("Temperatura: " + .temp_c.ToString)
                            printresult.AppendLine("Umidità: " + .relative_humidity)
                            printresult.AppendLine(String.Join("", Enumerable.Repeat(":wavy_dash:", 10)))
                            Response.Write(printresult.ToString)
                        End With
                    Catch ex As Exception
                        Response.Write("ERRORE IN RICEZIONE DATI. RIPROVA PIU' TARDI")
                    End Try
                Case "FORECAST"
                    Try
                        Dim page As String
                        Using w As New WebClient
                            w.Encoding = Encoding.UTF8
                            page = w.DownloadString("http://api.wunderground.com/api/" + My.Settings.Token + "/forecast/lang:IT/q/Italy/" + Request.QueryString("city") + ".json")
                        End Using
                        Dim result = JsonConvert.DeserializeObject(Of nForecast.clsForecast)(page)
                        With result.forecast.txt_forecast
                            Dim printresult As New StringBuilder
                            printresult.AppendLine(String.Join("", Enumerable.Repeat(":wavy_dash:", 10))).AppendLine 
                            For Each fday In .forecastday
                                printresult.AppendLine(":arrow_right: " + fday.title + " " + DecodeEmoji(fday.icon))
                                printresult.AppendLine(fday.fcttext_metric).AppendLine()
                            Next
                            printresult.AppendLine(String.Join("", Enumerable.Repeat(":wavy_dash:", 10)))
                            Response.Write(printresult.ToString)
                        End With
                    Catch ex As Exception
                        Response.Write("ERRORE IN RICEZIONE DATI. RIPROVA PIU' TARDI")
                    End Try
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Function DecodeEmoji(sCode As String) As String
        Select Case sCode
            Case "clear", "sunny", "nt_clear"
                Return ":sunny:"
            Case "rain"
                Return ":umbrella:"
            Case "partlycloudy", "nt_partlycloudy"
                Return ":partly_sunny:"
            Case "mostlycloudy"
                Return ":partly_sunny:"
            Case "cloudy"
                Return ":cloud:"
            Case Else
                Return ""
        End Select
    End Function
End Class