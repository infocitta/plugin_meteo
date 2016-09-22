Namespace nConditions
    Public Class Features
        Public Property conditions As Integer
    End Class

    Public Class Response
        Public Property version As String
        Public Property termsofService As String
        Public Property features As Features
    End Class

    Public Class Image
        Public Property url As String
        Public Property title As String
        Public Property link As String
    End Class

    Public Class DisplayLocation
        Public Property full As String
        Public Property city As String
        Public Property state As String
        Public Property state_name As String
        Public Property country As String
        Public Property country_iso3166 As String
        Public Property zip As String
        Public Property magic As String
        Public Property wmo As String
        Public Property latitude As String
        Public Property longitude As String
        Public Property elevation As String
    End Class

    Public Class ObservationLocation
        Public Property full As String
        Public Property city As String
        Public Property state As String
        Public Property country As String
        Public Property country_iso3166 As String
        Public Property latitude As String
        Public Property longitude As String
        Public Property elevation As String
    End Class

    Public Class Estimated
    End Class

    Public Class CurrentObservation
        Public Property image As Image
        Public Property display_location As DisplayLocation
        Public Property observation_location As ObservationLocation
        Public Property estimated As Estimated
        Public Property station_id As String
        Public Property observation_time As String
        Public Property observation_time_rfc822 As String
        Public Property observation_epoch As String
        Public Property local_time_rfc822 As String
        Public Property local_epoch As String
        Public Property local_tz_short As String
        Public Property local_tz_long As String
        Public Property local_tz_offset As String
        Public Property weather As String
        Public Property temperature_string As String
        Public Property temp_f As Double
        Public Property temp_c As Double
        Public Property relative_humidity As String
        Public Property wind_string As String
        Public Property wind_dir As String
        Public Property wind_degrees As Integer
        Public Property wind_mph As Double
        Public Property wind_gust_mph As String
        Public Property wind_kph As Double
        Public Property wind_gust_kph As String
        Public Property pressure_mb As String
        Public Property pressure_in As String
        Public Property pressure_trend As String
        Public Property dewpoint_string As String
        Public Property dewpoint_f As Integer
        Public Property dewpoint_c As Integer
        Public Property heat_index_string As String
        Public Property heat_index_f As String
        Public Property heat_index_c As String
        Public Property windchill_string As String
        Public Property windchill_f As String
        Public Property windchill_c As String
        Public Property feelslike_string As String
        Public Property feelslike_f As String
        Public Property feelslike_c As String
        Public Property visibility_mi As String
        Public Property visibility_km As String
        Public Property solarradiation As String
        Public Property UV As String
        Public Property precip_1hr_string As String
        Public Property precip_1hr_in As String
        Public Property precip_1hr_metric As String
        Public Property precip_today_string As String
        Public Property precip_today_in As String
        Public Property precip_today_metric As String
        Public Property icon As String
        Public Property icon_url As String
        Public Property forecast_url As String
        Public Property history_url As String
        Public Property ob_url As String
        Public Property nowcast As String
    End Class

    Public Class clsCondition
        Public Property response As Response
        Public Property current_observation As CurrentObservation
    End Class
End Namespace
