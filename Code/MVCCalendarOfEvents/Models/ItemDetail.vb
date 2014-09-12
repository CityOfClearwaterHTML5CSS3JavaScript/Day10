Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class ItemDetail
    <Key>
    Public Property PK As Guid

    Public Property FK_ITEM As Guid

    <Column(TypeName:="text")>
    <Required>
    Public Property DESCRIPTION As String

    Public Property NOTE_DATE As Date?

    Public Overridable Property Item As Item
End Class
