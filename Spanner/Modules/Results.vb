Namespace App

    ' This service handles the results data handling
    Public Class Results
        Private DB As App.Database

        Public Sub New(DB As App.Database)
            Me.DB = DB
        End Sub

        ' getSections()
        ' Get a list of sections for an event
        '
        ' Integer eventId - The id of the event
        '
        ' Returns a datatable with the sections
        Public Function getSections(eventId As Integer)
            Dim SQL = "SELECT * FROM event_sections WHERE "
            SQL += "event_id = " + eventId

            Return DB.GetQuery(SQL)
        End Function

        ' findSectionResult
        ' Find a specific section result for a specific person
        '
        ' Integer sectionId - The id of the section
        ' Integer bookingId - The id of the booking
        '
        ' Returns a section datatable
        Private Function findSectionResult(sectionId, bookingId) As DataTable
            ' Try and find the result
            Dim SQL = "SELECT * FROM event_section_results WHERE "
            SQL += "event_section_id = " + sectionId.ToString()
            SQL += " AND event_booking_id = " + bookingId.ToString()

            ' Return the query
            Return DB.getQuery(SQL)
        End Function

        ' getSectionResult
        ' Find a specific section result for a specific person. It will create one if one is not found
        '
        ' Integer sectionId - The id of the section
        ' Integer bookingId - The id of the booking
        '
        ' Returns the datarow
        Public Function getSectionResult(sectionId As Integer, bookingId As Integer) As DataRow
            ' Try and get a section result
            Dim data = findSectionResult(sectionId, bookingId)

            If data.Rows.Count = 0 Then
                ' Create new result if it doesn't exist
                Dim result = New Dictionary(Of String, Object)

                ' Set data
                result("event_section_id") = sectionId
                result("event_booking_id") = bookingId
                result("score") = 0

                ' Insert into database
                DB.insert("event_section_results", result)

                ' Get the newly created section result
                data = findSectionResult(sectionId, bookingId)
            End If

            Return data.Rows(0)
        End Function

        ' export
        ' Export the data into a PDF
        '
        ' Integer eventId - The id of the event to export
        '
        Sub export(eventId As Integer)
            ' Create a save file dialog
            Dim selectFile As SaveFileDialog = New SaveFileDialog

            ' Get any relevant entities
            Dim clubEvent = DB.getRecord("events", eventId)
            Dim club = DB.getRecord("clubs", clubEvent("club_id"))

            ' Set the save file filter and file name
            selectFile.Filter = "PDF (*.pdf)|*.pdf"
            selectFile.FileName = Now().Hour().ToString() + "_" + Now().Minute().ToString() + "_" + Now().Second().ToString() + " " + clubEvent("name") + " Results.pdf"

            ' If cancel pressed, exit
            If Not selectFile.ShowDialog() = DialogResult.OK Then
                Exit Sub
            End If

            ' Generate SQL
            Dim html As String = "<html>"

            ' Loop through each of the classes
            Dim SQL = "SELECT DISTINCT event_bookings.vehicle_class_id, vehicle_classes.name FROM event_bookings, vehicle_classes WHERE "
            SQL += "vehicle_classes.id = event_bookings.vehicle_class_id"
            SQL += " AND event_bookings.event_id = " + eventId.ToString()
            SQL += " AND event_bookings.is_competing = 1"
            SQL += " AND event_bookings.is_retired = 0"

            Dim classes = DB.getQuery(SQL)

            For Each row In classes.Rows
                ' Get all of the entrants in this class
                SQL = "SELECT * FROM event_bookings WHERE "
                SQL += "event_id = " + eventId.ToString()
                SQL += " AND event_bookings.vehicle_class_id = " + row("vehicle_class_id").ToString()
                SQL += " AND event_bookings.is_retired = 0 "
                SQL += " AND event_bookings.is_competing = 1 "
                SQL += "ORDER BY event_bookings.total_score ASC"

                ' Generate a page for the class and add to the document
                html += generatePage(SQL, clubEvent, club, "Class " + row("name"), True)
            Next

            ' Add the retired drivers
            SQL = "SELECT * FROM event_bookings WHERE "
            SQL += "event_id = " + eventId.ToString()
            SQL += " AND event_bookings.is_retired = 1 "
            SQL += " AND event_bookings.is_competing = 1 "
            SQL += " AND event_bookings.is_approved = 1 "
            SQL += "ORDER BY event_bookings.total_score ASC"

            html += generatePage(SQL, clubEvent, club, "Retired", False)

            ' Add those who did not show
            SQL = "SELECT * FROM event_bookings WHERE "
            SQL += "event_id = " + eventId.ToString()
            SQL += " AND event_bookings.is_competing = 0 "
            SQL += " AND event_bookings.is_approved = 1 "
            SQL += "ORDER BY event_bookings.total_score ASC"

            html += generatePage(SQL, clubEvent, club, "Did Not Show", False)

            ' Convert the html to PDF
            Dim converter = New NReco.PdfGenerator.HtmlToPdfConverter()
            converter.Orientation = NReco.PdfGenerator.PageOrientation.Landscape
            converter.GeneratePdf(html, "", selectFile.FileName)

            ' Open the PDF file for viewing
            Process.Start(selectFile.FileName)
        End Sub

        ' generatePage
        '
        ' String  SQL       - The SQL query of the data to use to export 
        ' DataRow clubEvent - The club event
        ' DataRow club      - The event's club
        ' String  title     - The title of the page
        ' Boolean positions - show the ordinal position of the entrants (1st, 2nd, etc)
        '
        ' Returns the html of the data
        Private Function generatePage(SQL As String, clubEvent As DataRow, club As DataRow, title As String, positions As Boolean) As String
            ' Check that there are any items in the query
            Dim results = DB.GetQuery(SQL)

            If results.Rows.Count = 0 Then
                ' Return blank page if no entrants
                Return ""
            End If

            ' Create new page with title
            Dim html = "<div style='page-break-after:always'>"
            html = "<center><h2>"
            html += clubEvent("name") + " - " + title

            ' Convert dates to date time format
            Dim startDate = New Date(clubEvent("start_date"))
            Dim endDate = New Date(clubEvent("end_date"))

            html += "</h2>"
            html += "<h3>" + club("club_name") + " - "
            ' Format to string and add
            html += startDate.ToString("dd MMMM yyyy")

            ' If not a one day event, show finish date
            If startDate <> endDate Then
                html += " to " + endDate.ToString("dd MMMM yyyy")
            End If
            html += "</h3></center>"

            ' Generate the table
            html += "
    <table style='border-collapse: collapse; width: 100%;'>
        <tr>
            <th style='border: 1px solid black; padding: 4px;'>First Name</th>
            <th style='border: 1px solid black; padding: 4px;'>Last Name</th>
            <th style='border: 1px solid black; padding: 4px;'>Club</th>
            <th style='border: 1px solid black; padding: 4px;'>Class</th>
"
            ' Get the sections for the event
            Dim sections = DB.GetQuery("SELECT * FROM event_sections WHERE event_sections.event_id = " + clubEvent("id").ToString())

            ' Add columns for each sections
            For Each section In sections.Rows
                html += "<th style='border: 1px solid black; padding: 4px;'>" + section("section_name") + "</th>"
            Next

            ' Add a total column
            html += "<th style='border: 1px solid black; padding: 4px;'>Total</th>"
            ' Add positions column if required
            If positions Then
                html += "<th style='border: 1px solid black; padding: 4px;'></th>"
            End If
            html += "</tr>"
            Dim positionCounter = 1

            ' Loop through all of the entrants
            For Each entrant In results.Rows
                Dim user = DB.getRecord("users", entrant("user_id"))
                Dim user_club = DB.getRecord("clubs", entrant("club_id"))
                Dim vehicle_class = DB.getRecord("vehicle_classes", entrant("vehicle_class_id"))

                ' Export the entrant's data to html
                html += "<tr>"
                html += "<td style='border: 1px solid black; padding 4px;'>" + user("first_name") + "</td>"
                html += "<td style='border: 1px solid black; padding 4px;'>" + user("last_name") + "</td>"
                html += "<td style='border: 1px solid black; padding 4px;'>" + club("abbreviation") + "</td>"
                html += "<td style='border: 1px solid black; padding 4px;'>" + vehicle_class("name") + "</td>"

                ' Loop through each of the sections
                For Each section In sections.Rows
                    Dim result = findSectionResult(section("id"), entrant("id"))
                    Dim score = ""
                    If result.Rows.Count > 0 Then
                        score = result.Rows(0)("score")
                    End If
                    ' Add the score
                    html += "<td style='border: 1px solid black; padding 4px;'>" + score.ToString() + "</td>"
                Next

                ' Check if they competed
                If entrant("is_competing") = 0 Then
                    html += "<td style='border: 1px solid black; padding 4px;'>DNS</td>"
                ElseIf entrant("is_retired") = 1 Then
                    html += "<td style='border: 1px solid black; padding 4px;'>RET</td>"
                Else
                    ' Display the total
                    html += "<td style='border: 1px solid black; padding 4px;'>" + entrant("total_score").ToString() + "</td>"
                End If

                If positions Then
                    ' Display the positions if required
                    html += "<td style='border: 1px solid black; padding 4px;'>" + addOrdinalSuffix(positionCounter.ToString()) + "</td>"
                    positionCounter += 1
                End If

            Next

            ' Closing html tags

            html += "</table>"

            html += "</div>"
            ' Page break
            html += "<div style='page-break-after:always'></div>"
            Return html
        End Function

        ' addOrdinalSuffix
        ' Add an ordinal suffix to a number
        '
        ' Integer score - the score to add the number too
        '
        ' Returns a string of the number with the right ordinal suffic
        Function addOrdinalSuffix(score As String)
            If score(score.Length - 1) = "1" Then
                ' If ending with a 1, add a st
                Return score + "st"
            ElseIf score(score.Length - 1) = "2" Then
                ' If ending with a 2, add a nd
                Return score + "nd"
            ElseIf score(score.Length - 1) = "3" Then
                ' If ending with a 3, add a rd
                Return score + "rd"
            Else
                ' Anything else, add a th
                Return score + "th"
            End If
        End Function

    End Class

End Namespace