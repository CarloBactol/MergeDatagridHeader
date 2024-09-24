Imports System.Collections.ObjectModel

Class MainWindow
    Public Property TaxCertificates As ObservableCollection(Of TaxCertificate)

    Public Sub New()
        InitializeComponent()

        ' Initialize the collection
        TaxCertificates = New ObservableCollection(Of TaxCertificate)()

        ' Sample data
        TaxCertificates.Add(New TaxCertificate() With {
            .CustomerName = "John Doe",
            .TIN = "123-456-789",
            .CCDDateReceived = "2024-01-01",
            .CCDDateCoverage = "2024-01-31",
            .CCDType = "Type A",
            .CCDTaxCertAmount = 100D,
            .CAMDateReceived = "2024-02-01",
            .CAMDateCoverage = "2024-02-28",
            .CAMType = "Type B",
            .CAMTaxCertAmount = 200D,
            .CAMTotalTaggedSI = 180D
        })

        TaxCertificates.Add(New TaxCertificate() With {
            .CustomerName = "John Carlo",
            .TIN = "123-456-789",
            .CCDDateReceived = "2024-01-01",
            .CCDDateCoverage = "2024-01-31",
            .CCDType = "Type A",
            .CCDTaxCertAmount = 100D,
            .CAMDateReceived = "2024-02-01",
            .CAMDateCoverage = "2024-02-28",
            .CAMType = "Type B",
            .CAMTaxCertAmount = 200D,
            .CAMTotalTaggedSI = 180D
        })


        ' Bind the collection to the DataGrid
        dataGrid.ItemsSource = TaxCertificates
    End Sub
End Class



Public Class TaxCertificate
    Public Property CustomerName As String
    Public Property TIN As String
    Public Property CCDDateReceived As String
    Public Property CCDDateCoverage As String
    Public Property CCDType As String
    Public Property CCDTaxCertAmount As Decimal
    Public Property CCDTotalTaggedSI As Decimal
    Public Property CAMDateReceived As String
    Public Property CAMDateCoverage As String
    Public Property CAMType As String
    Public Property CAMTaxCertAmount As Decimal
    Public Property CAMTotalTaggedSI As Decimal
End Class


