Public Class dashboard
    Private currentChildForm As Form
    Private isChartsInitialized As Boolean = False

    Private Sub OpenChildForm(child As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
            currentChildForm = Nothing
        End If

        currentChildForm = child
        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        child.Dock = DockStyle.Fill
        contentHost.Controls.Clear()
        contentHost.Controls.Add(child)
        child.Show()
        child.BringToFront()
    End Sub
    Private Sub topBar_Paint(sender As Object, e As PaintEventArgs) Handles topBar.Paint

    End Sub

    Private Sub navResidents_Click(sender As Object, e As EventArgs) Handles navResidents.Click
        OpenChildForm(New residentinfo())
    End Sub

    Private Sub navReports_Click(sender As Object, e As EventArgs) Handles navReports.Click
        OpenChildForm(New reportsform())
    End Sub

    Private Sub navDashboard_Click(sender As Object, e As EventArgs) Handles navDashboard.Click
        ' Close any child and bring back the dashboard layout
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
            currentChildForm = Nothing
        End If
        RestoreDashboardControls()
        InitializeBottomPanels()
    End Sub

    Private Sub RestoreDashboardControls()
        ' Ensure the dashboard panels are added back in proper order
        contentHost.Controls.Clear()
        contentHost.Controls.Add(chartsTable)
        contentHost.Controls.Add(statsTable)
        chartsTable.Dock = DockStyle.Fill
        statsTable.Dock = DockStyle.Top
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeBottomPanels()
    End Sub

    Private Sub InitializeBottomPanels()
        If isChartsInitialized Then Return

        ' Configure residents grid columns
        dgvDashboardResidents.AutoGenerateColumns = True
        dgvDashboardResidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDashboardResidents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Configure purok chart
        chartPurok.Series.Clear()
        chartPurok.ChartAreas.Clear()
        Dim area = New DataVisualization.Charting.ChartArea("MainArea")
        area.AxisX.Title = "Purok"
        area.AxisY.Title = "Residents"
        chartPurok.ChartAreas.Add(area)
        Dim series = New DataVisualization.Charting.Series("Residents")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Column
        series.IsValueShownAsLabel = True
        chartPurok.Series.Add(series)

        isChartsInitialized = True
    End Sub

    Public Sub BindResidentsToDashboardGrid(source As Object)
        If Not isChartsInitialized Then InitializeBottomPanels()
        dgvDashboardResidents.DataSource = source
    End Sub

    Public Sub UpdatePurokChart(purokToCount As IDictionary(Of String, Integer))
        If Not isChartsInitialized Then InitializeBottomPanels()
        Dim series = chartPurok.Series("Residents")
        series.Points.Clear()
        For Each kvp In purokToCount
            series.Points.AddXY(kvp.Key, kvp.Value)
        Next
    End Sub

    Private Sub statsTable_Paint(sender As Object, e As PaintEventArgs) Handles statsTable.Paint

    End Sub

    Private Sub dgvDashboardResidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDashboardResidents.CellContentClick

    End Sub

    Private Sub navCedula_Click(sender As Object, e As EventArgs) Handles navCedula.Click

    End Sub


End Class