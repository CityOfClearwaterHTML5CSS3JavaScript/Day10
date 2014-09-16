Imports Newtonsoft.Json
Imports System.Runtime.Serialization

Public Class CalendarEvent
    Public Property Title As String
    Public Property StartDate As Date
    Public Property EndDate As Date
    Public Property Location As String
    Public Property ContactInfo As String
    Public Property ShortDescription As String
    Public Property Description As String

    <IgnoreDataMember>
    Public Property Arts As Boolean

    <IgnoreDataMember>
    Public Property CityMeetings As Boolean

    <IgnoreDataMember>
    Public Property Training As Boolean

    <IgnoreDataMember>
    Public Property Library As Boolean

    <IgnoreDataMember>
    Public Property ParksRec As Boolean

    <IgnoreDataMember>
    Public Property Youth As Boolean

    <IgnoreDataMember>
    Public Property Adult As Boolean

    <IgnoreDataMember>
    Public Property Family As Boolean

    <IgnoreDataMember>
    Public Property Recurring As Boolean

    <IgnoreDataMember>
    Public Property Police As Boolean

    <IgnoreDataMember>
    Public Property Recyle As Boolean

    <IgnoreDataMember>
    Public Property Teens As Boolean

    <IgnoreDataMember>
    Public Property SP As Boolean

    Private _Activities As List(Of String)
    Public Property Activities() As List(Of String)
        Get
            If (_Activities Is Nothing) Then
                Dim results As New List(Of String)
                If Arts Then results.Add("Arts")
                If CityMeetings Then results.Add("City Meetings")
                If Training Then results.Add("Training")
                If Library Then results.Add("Library")
                If ParksRec Then results.Add("Parks & Rec")
                If Youth Then results.Add("Youth")
                If Adult Then results.Add("Adult")
                If Family Then results.Add("Family")
                If Recurring Then results.Add("Recurring")
                If Police Then results.Add("Police")
                If Recyle Then results.Add("Recyle")
                If Teens Then results.Add("Teens")
                If SP Then results.Add("SP")
                _Activities = results
            End If
            Return _Activities
        End Get

        Set(value As List(Of String))
            _Activities = value
        End Set
    End Property
End Class