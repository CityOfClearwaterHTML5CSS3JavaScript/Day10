Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class PIMSCalendarItemsContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=PIMSCalendarItemsContext")
    End Sub

    Public Overridable Property Calendars As DbSet(Of Calendar)
    Public Overridable Property Items As DbSet(Of Item)
    Public Overridable Property ItemDetails As DbSet(Of ItemDetail)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Calendar)() _
            .Property(Function(e) e.LOCATION) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .Property(Function(e) e.ITEM_ID) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .Property(Function(e) e.TITLE) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .Property(Function(e) e.SHORT_DESC) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .Property(Function(e) e.CONTACT_INFO) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .Property(Function(e) e.REQUESTED_BY) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .Property(Function(e) e.REQUESTOR_PHONE) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Item)() _
            .HasMany(Function(e) e.Calendars) _
            .WithOptional(Function(e) e.Item) _
            .HasForeignKey(Function(e) e.FK_ITEM)

        modelBuilder.Entity(Of Item)() _
            .HasMany(Function(e) e.ItemDetails) _
            .WithRequired(Function(e) e.Item) _
            .HasForeignKey(Function(e) e.FK_ITEM) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of ItemDetail)() _
            .Property(Function(e) e.DESCRIPTION) _
            .IsUnicode(False)
    End Sub
End Class
