@Code
    ViewData("Title") = "Index"
End Code

@section styles
    <link rel="stylesheet" href="//cdn.datatables.net/1.10.2/css/jquery.dataTables.min.css" />
End Section

<h2>Index</h2>

<div id="Events"></div>

<table id="EventsTable" class="DataTable">
    <thead>
        <tr>
            <th>Title</th>
        </tr>
    </thead>
</table>

@section scripts
    <script src="//cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js"></script>
    <script>
        $("document").ready(function () {
            $.ajax({
                url: 'http://localhost:45007/api/Events',
                type: 'GET',        // 'GET' 'POST' 'PUT' 'DELETE'
                dataType: 'json',
                //data: Events,
                success: function (data, textStatus, xhr) {
                    console.log(data);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log('Error in Operation');
                }
            });
            
            // or
            $.getJSON("http://localhost:45007/api/Events", function (data) {
                console.log(data);
            });

            $.getJSON("http://localhost:45007/api/Events", function (data) {
                var items = [];
                $.each(data, function (key, val) {
                    items.push("<li id='" + key + "'>" + val["Title"] + "</li>");
                });

                $("<ul/>", {
                    "class": "my-new-list",
                    html: items.join("")
                }).appendTo("#Events");
            });

            var table = $('#EventsTable').dataTable({
                "ajax": {
                    "url": "http://localhost:45007/api/Events",
                    "type": "GET"
                },
                "columns": [
                    { "data": "Title" },
                ]
            }).on('xhr.dt', function (e, settings, json) {
                alert(json.length + ' row(s) were loaded');
            });
        })
    </script>
End Section