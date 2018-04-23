@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gv"
    
            'built-in callbacks
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
    
            'custom callbacks
            settings.CustomActionRouteValues = New With {.Cotroller = "Home", .Action = "GridViewCustomActionPartial"}
    
            settings.KeyFieldName = "ID"
            settings.Columns.Add("ID")
            settings.Columns.Add("Text")
    
            settings.Settings.ShowFilterRow = Convert.ToBoolean(ViewData("AutoFilterRowVisible"))
    
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
    End Sub).Bind(Model).GetHtml()