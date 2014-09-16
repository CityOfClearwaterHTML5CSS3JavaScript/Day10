Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Item")>
Partial Public Class Item
    Public Sub New()
        Calendars = New HashSet(Of Calendar)()
        ItemDetails = New HashSet(Of ItemDetail)()
    End Sub

    <Key>
    Public Property PK As Guid

    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property ITEM_NUMBER As Integer

    <DatabaseGenerated(DatabaseGeneratedOption.Computed)>
    <StringLength(12)>
    Public Property ITEM_ID As String

    Public Property FK_DEPARTMENT As Guid?

    Public Property FK_NEIGHBORHOOD As Guid?

    <Required>
    <StringLength(255)>
    Public Property TITLE As String

    <Required>
    <StringLength(512)>
    Public Property SHORT_DESC As String

    <Required>
    <StringLength(255)>
    Public Property CONTACT_INFO As String

    Public Property CREATED_DATE As Date

    Public Property UPDATED_BY As Guid?

    Public Property UPDATED_DATE As Date?

    Public Property CANCEL As Boolean

    <Required>
    <StringLength(30)>
    Public Property REQUESTED_BY As String

    <Required>
    <StringLength(30)>
    Public Property REQUESTOR_PHONE As String

    Public Property APP_DEPT_STATE As Byte

    Public Property APP_DEPT_USER As Guid?

    Public Property APP_DEPT_DATE As Date?

    Public Property APP_CW_STATE As Byte

    Public Property APP_CW_USER As Guid?

    Public Property APP_CW_DATE As Date?

    Public Property DELETED As Boolean

    Public Property MEDIA_ITEM As Boolean?

    Public Overridable Property Calendars As ICollection(Of Calendar)

    Public Overridable Property ItemDetails As ICollection(Of ItemDetail)
End Class
