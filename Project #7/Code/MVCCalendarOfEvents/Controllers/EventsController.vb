Imports System.Net
Imports System.Web.Http
Imports System.Web.Http.Description

Namespace Controllers
    Public Class EventsController
        Inherits ApiController

        Private data As New List(Of String) From {"Fred", "Barney", "Wilma", "Betty"}
        Private db As New PIMSCalendarItemsContext

        Private Function QueryEvents() As IEnumerable(Of CalendarEvent)
            Dim model = _
                From i In db.Items
                Join id In db.ItemDetails On i.PK Equals id.FK_ITEM
                Join c In db.Calendars On i.PK Equals c.FK_ITEM
                Where c.START_DATE >= Now
                Select New CalendarEvent With
                {
                    .Title = i.TITLE,
                    .StartDate = c.START_DATE,
                    .EndDate = c.END_DATE,
                    .Location = c.LOCATION,
                    .ContactInfo = i.CONTACT_INFO,
                    .ShortDescription = i.SHORT_DESC,
                    .Description = id.DESCRIPTION,
                    .Arts = c.ARTS,
                    .CityMeetings = c.CITY_MEETINGS,
                    .Training = c.TRAINING,
                    .Library = c.LIBRARY,
                    .ParksRec = c.PARKS_REC,
                    .Youth = c.YOUTH,
                    .Adult = c.ADULT,
                    .Family = c.FAMILY,
                    .Recurring = c.RECURRING,
                    .Police = c.POLICE,
                    .Recyle = c.RECYCLE,
                    .Teens = c.TEENS,
                    .SP = c.SP
                }
            Return model.ToList
        End Function

        <Route("api/Events")>
        Public Function GetEvents() As IEnumerable(Of CalendarEvent)                                                    ' as IEnumerable(Of String)
            Dim data = QueryEvents()
            Return data
        End Function

        <Route("api/Events/{startDate:datetime}/{EndDate:datetime}")>
        Public Function GetEventsByDateRange(startDate As Date, EndDate As Date) As IEnumerable(Of CalendarEvent)        ' as IEnumerable(Of String)
            Dim data = QueryEvents().Where(Function(ce) ce.StartDate >= startDate And ce.EndDate <= EndDate)
            Return data
        End Function

        <Route("api/Events/{criteria}")>
        Public Function GetEventsBySearch(criteria As String) As IEnumerable(Of CalendarEvent)                           ' as IEnumerable(Of String)
            Dim data = QueryEvents().Where(Function(ce) ce.Title.Contains(criteria) Or ce.Description.Contains(criteria))
            ' Return data.FindAll(Function(p) p = criteria)
            Return data
        End Function

        <Route("api/Events")>
        Public Function PostEvent(<FromBody()> ByVal data As CalendarEvent) As IHttpActionResult
            Return Ok("Post Complete")
        End Function

        <Route("api/Events/{id}")>
        Public Function PutEvent(ByVal id As Integer, <FromBody()> ByVal data As CalendarEvent) As IHttpActionResult
            'Return StatusCode(HttpStatusCode.NoContent)
            Return Ok("Put Complete")
        End Function

        <Route("api/Events/{id}")>
        Public Function DeleteEvent(ByVal id As Integer) As IHttpActionResult
            Return Ok("Delete Complete")
        End Function
    End Class
End Namespace