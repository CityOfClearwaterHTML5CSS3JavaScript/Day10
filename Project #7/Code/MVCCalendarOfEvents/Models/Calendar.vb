Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Calendar")>
Partial Public Class Calendar
    <Key>
    Public Property PK As Guid

    Public Property FK_ITEM As Guid?

    Public Property START_DATE As Date?

    Public Property END_DATE As Date?

    <StringLength(100)>
    Public Property LOCATION As String
    Public Property ARTS As Boolean

    Public Property CITY_MEETINGS As Boolean

    Public Property TRAINING As Boolean

    Public Property LIBRARY As Boolean

    Public Property PARKS_REC As Boolean

    Public Property YOUTH As Boolean

    Public Property ADULT As Boolean

    Public Property FAMILY As Boolean

    Public Property RECURRING As Boolean

    Public Property POLICE As Boolean

    Public Property RECYCLE As Boolean

    Public Property TEENS As Boolean

    Public Property SP As Boolean

    Public Overridable Property Item As Item

End Class
