@ModelType IEnumerable(Of MVCCalendarOfEvents.CalendarEvent)
@Code
ViewData("Title") = "GetEvents"
End Code

<h2>GetEvents</h2>

<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.StartDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EndDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Location)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ContactInfo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ShortDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Arts)
        </th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StartDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EndDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Location)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ContactInfo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ShortDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Activities)
        </td>
    </tr>
Next

</table>
