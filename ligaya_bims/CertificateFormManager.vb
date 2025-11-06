Public Class CertificateFormManager
    Private Shared _certBrgyClearance As CertBrgyClearance
    Private Shared _certResidency As CertResidency
    Private Shared _certIndigency As CertifcateIndigency
    Private Shared _certAnnual As certAnnual
    Private Shared _certCC As certCC
    Private Shared _certSC As certSC
    
    Public Shared Function GetBrgyClearanceForm() As CertBrgyClearance
        If _certBrgyClearance Is Nothing OrElse _certBrgyClearance.IsDisposed Then
            _certBrgyClearance = New CertBrgyClearance()
            _certBrgyClearance.TopLevel = False
            _certBrgyClearance.Visible = False
        End If
        Return _certBrgyClearance
    End Function
    
    Public Shared Function GetResidencyForm() As CertResidency
        If _certResidency Is Nothing OrElse _certResidency.IsDisposed Then
            _certResidency = New CertResidency()
            _certResidency.TopLevel = False
            _certResidency.Visible = False
        End If
        Return _certResidency
    End Function
    
    Public Shared Function GetIndigencyForm() As CertifcateIndigency
        If _certIndigency Is Nothing OrElse _certIndigency.IsDisposed Then
            _certIndigency = New CertifcateIndigency()
            _certIndigency.TopLevel = False
            _certIndigency.Visible = False
        End If
        Return _certIndigency
    End Function
    
    Public Shared Function GetAnnualForm() As certAnnual
        If _certAnnual Is Nothing OrElse _certAnnual.IsDisposed Then
            _certAnnual = New certAnnual()
            _certAnnual.TopLevel = False
            _certAnnual.Visible = False
        End If
        Return _certAnnual
    End Function
    
    Public Shared Function GetCCForm() As certCC
        If _certCC Is Nothing OrElse _certCC.IsDisposed Then
            _certCC = New certCC()
            _certCC.TopLevel = False
            _certCC.Visible = False
        End If
        Return _certCC
    End Function
    
    Public Shared Function GetSCForm() As certSC
        If _certSC Is Nothing OrElse _certSC.IsDisposed Then
            _certSC = New certSC()
            _certSC.TopLevel = False
            _certSC.Visible = False
        End If
        Return _certSC
    End Function
    
    Public Shared Sub DisposeAllForms()
        If _certBrgyClearance IsNot Nothing AndAlso Not _certBrgyClearance.IsDisposed Then
            _certBrgyClearance.Dispose()
        End If
        If _certResidency IsNot Nothing AndAlso Not _certResidency.IsDisposed Then
            _certResidency.Dispose()
        End If
        If _certIndigency IsNot Nothing AndAlso Not _certIndigency.IsDisposed Then
            _certIndigency.Dispose()
        End If
        If _certAnnual IsNot Nothing AndAlso Not _certAnnual.IsDisposed Then
            _certAnnual.Dispose()
        End If
        If _certCC IsNot Nothing AndAlso Not _certCC.IsDisposed Then
            _certCC.Dispose()
        End If
        If _certSC IsNot Nothing AndAlso Not _certSC.IsDisposed Then
            _certSC.Dispose()
        End If
    End Sub
End Class
