Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraPrinting.Native.Win32
Imports DevExpress.XtraBars
Imports System.Windows.Forms.Control

Public Class ControlesDevExpress

    Public Enum eTextEditFormat
        Ninguno = 0
        Numero = 1
        Numero2D = 2
        Moneda2D = 3
        Fixed2D = 4
        Fecha = 5
        Fixed = 6
        Fixed4D = 7
    End Enum

    Public Enum eTextEditFormatFuente
        Normal = 0
        Mayusculas = 1
        Minusculas = 2
    End Enum

    Public Enum eGridViewFormato
        Ninguno = 0
        Numero = 1
        Fecha = 2
        Boton = 3
        FechaHora = 4
        Checked = 5
        Link = 6
        Money = 7
    End Enum

    Shared Sub InitRibbonControl(ByRef Control As RibbonControl)

        With Control
            .RibbonStyle = RibbonControlStyle.Office2010
            .ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False
            .ShowToolbarCustomizeItem = False
            .ShowApplicationButton = False
            'Solo version DevExpress 15
            .ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False
        End With
    End Sub

    Shared Sub TextEditFormat(ByRef Control As TextEdit, Optional Format As eTextEditFormat = eTextEditFormat.Ninguno, Optional Longitud As Int32 = 50, Optional SoloLectura As Boolean = False, Optional Fuente As eTextEditFormatFuente = eTextEditFormatFuente.Normal)

        'Se estable el formato de ingreso
        With Control
            Select Case Format
                Case eTextEditFormat.Numero
                    .Properties.Mask.EditMask = "n0"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '.RightToLeft = Windows.Forms.RightToLeft.Yes

                Case eTextEditFormat.Numero2D
                    .Properties.Mask.EditMask = "n2"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '.RightToLeft = Windows.Forms.RightToLeft.Yes

                Case eTextEditFormat.Fixed
                    .Properties.Mask.EditMask = "f0"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '.RightToLeft = Windows.Forms.RightToLeft.No

                Case eTextEditFormat.Fixed2D
                    .Properties.Mask.EditMask = "f2"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '                    .RightToLeft = Windows.Forms.RightToLeft.No

                Case eTextEditFormat.Fixed4D
                    .Properties.Mask.EditMask = "f4"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '.RightToLeft = Windows.Forms.RightToLeft.No

                Case eTextEditFormat.Moneda2D
                    .Properties.Mask.EditMask = "c2"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '.RightToLeft = Windows.Forms.RightToLeft.Yes

                Case eTextEditFormat.Fecha
                    .Properties.Mask.EditMask = "d"
                    .Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
                    .Properties.Mask.UseMaskAsDisplayFormat = True
                    '.RightToLeft = Windows.Forms.RightToLeft.No
            End Select
        End With


        'Se establece el comportamiento del TextEdit
        With Control
            .Properties.ReadOnly = SoloLectura
            .Properties.MaxLength = Longitud
            ' .Properties.CharacterCasing = Fuente
        End With

    End Sub

    Shared Sub InitGridLookUpEdit(ByRef Control As GridLookUpEdit, DataSource As Object, ValueMember As String, DisplayMember As String, Optional PopupWidth As Int32 = 350)

        'Se configura los controles de navegacion y de datos del GridLookUpEdit
        With Control
            'Se alinea el Icono de Error a la derecha
            '.ErrorIconAlignment = ErrorIconAlignment.MiddleRight

            .Properties.ImmediatePopup = True
            .Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.Default
            .Properties.NullText = ""
            .Properties.PopupFilterMode = PopupFilterMode.Contains
            .Properties.PopupFormWidth = Control.Properties.BestFitWidth

            'Se establece el ancho del popup desplegable, por defecto es 150
            .Properties.PopupFormWidth = PopupWidth

            'Se configura la fuente de datos
            .Properties.DataSource = DataSource
            .Properties.ValueMember = ValueMember
            .Properties.DisplayMember = DisplayMember
        End With
    End Sub

    Shared Sub InitGridLookUpEditColumns(ByRef Control As GridLookUpEdit, ColumnaTitulo As String, NombreCampo As String, ColumnaAncho As Int32, Optional ColumnaVisible As Boolean = True)

        'Se crea la columna para el control GridLookUpEdit
        Dim Columna As New DevExpress.XtraGrid.Columns.GridColumn()

        'Se configura la columna
        With Columna
            .Caption = ColumnaTitulo
            .FieldName = NombreCampo
            .Name = NombreCampo
            .Visible = ColumnaVisible
            .Width = ColumnaAncho
            .OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'Se agrega la columna al GridLookUpEdit
        Control.Properties.View.Columns.Add(Columna)
    End Sub

    Shared Sub InitGridLookUpEditSearch(ByRef Control As SearchLookUpEdit, DataSource As Object, ValueMember As String, DisplayMember As String, Optional PopupWidth As Int32 = 350)

        'Se configura los controles de navegacion y de datos del GridLookUpEdit
        With Control
            'Se alinea el Icono de Error a la derecha
            '.ErrorIconAlignment = ErrorIconAlignment.MiddleRight

            .Properties.ImmediatePopup = True
            .Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.Default
            .Properties.NullText = ""
            .Properties.PopupFilterMode = PopupFilterMode.Contains
            .Properties.PopupFormWidth = Control.Properties.BestFitWidth

            'Se establece el ancho del popup desplegable, por defecto es 150
            .Properties.PopupFormWidth = PopupWidth

            'Se configura la fuente de datos
            .Properties.DataSource = DataSource
            .Properties.ValueMember = ValueMember
            .Properties.DisplayMember = DisplayMember

            .Properties.View.OptionsView.ShowAutoFilterRow = True
        End With
    End Sub

    Shared Sub InitGridLookUpEditSearchColumns(ByRef Control As SearchLookUpEdit, ColumnaTitulo As String, NombreCampo As String, ColumnaAncho As Int32, Optional ColumnaVisible As Boolean = True)

        'Se crea la columna para el control GridLookUpEdit
        Dim Columna As New DevExpress.XtraGrid.Columns.GridColumn()

        'Se configura la columna
        With Columna
            .Caption = ColumnaTitulo
            .FieldName = NombreCampo
            .Name = NombreCampo
            .Visible = ColumnaVisible
            .Width = ColumnaAncho
            .OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'Se agrega la columna al GridLookUpEdit
        Control.Properties.View.Columns.Add(Columna)
    End Sub

    Shared Sub InitGridControl(ByRef Control As GridControl)

        'Se configura los controles de navegacion de la grilla
        With Control
            .UseEmbeddedNavigator = True
            .EmbeddedNavigator.Buttons.Append.Visible = False
            .EmbeddedNavigator.Buttons.Edit.Visible = False
            .EmbeddedNavigator.Buttons.EndEdit.Visible = False
            .EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            .EmbeddedNavigator.Buttons.First.Visible = True
            .EmbeddedNavigator.Buttons.Last.Visible = True
            .EmbeddedNavigator.Buttons.Remove.Visible = False
        End With

    End Sub

    Shared Sub InitGridView(ByRef Control As Views.Grid.GridView, Optional PanelBusqueda As Boolean = True, Optional PanelFiltro As Boolean = True)

        'Se Configura GridView : Seleccionar toda la fila, Muestra el Panel de Agrupacion
        With Control
            .OptionsSelection.EnableAppearanceFocusedCell = False
            .OptionsView.ShowGroupPanel = False
            .OptionsSelection.MultiSelect = False

            'Se activa el panel de busqueda
            .OptionsFind.AlwaysVisible = PanelBusqueda
            .OptionsFind.ShowClearButton = False
            .OptionsView.ShowAutoFilterRow = PanelFiltro
            .OptionsView.EnableAppearanceEvenRow = True
        End With
    End Sub

    'Private Function GetControlByTag(numero As Integer) As Control

    '    Dim lst As List(Of Control) =
    '        (From item As Control In EditForm. .OfType(Of Control)()
    '         Where CInt(item.Tag) = numero
    '         Select item).ToList()

    '    If (lst.Count = 0) Then
    '        Throw New IndexOutOfRangeException("No existe ningún control con el índice especificado.")
    '    End If

    '    Return lst(0)

    'End Function

    'Shared Sub SetButtonVisibility(ByVal subItem As BarSubItem, ByVal btnName As String)
    '    For Each itemLink As BarItemLink In subItem.ItemLinks
    '        Dim subItemLink As BarSubItemLink = TryCast(itemLink, BarSubItemLink)
    '        If subItemLink IsNot Nothing Then
    '            SetButtonVisibility(TryCast(subItemLink.Item, BarSubItem), btnName)
    '        End If
    '        If itemLink.Item.Tag.ToString() = btnName Then
    '            itemLink.Visible = True
    '        Else
    '            itemLink.Visible = False
    '        End If
    '    Next itemLink
    'End Sub
    Shared Sub ActivarInactivaracciones(ByVal controls As ControlCollection)
        For Each Control As Control In controls
            If Control.Controls.Count > 0 Then
                ActivarInactivaracciones(Control.Controls)

            End If
            'use Control  
        Next
    End Sub

    Shared Sub InitNavBarMenuDesactiva(ByRef Control As NavBarControl, MenusPrincipales As String(), Icono As System.Drawing.Image, dt As DataTable)

        'Se agrega menu principal que es el primer item
        Dim objNavBarGroup As New NavBarGroup(MenusPrincipales(0))
        Dim objestadobar As Integer

        'Se establece el Icono para el Menu Principal
        objNavBarGroup.LargeImage = Icono

        'Se agrega el Menu Principal al NavBarControl
        Control.Groups.Add(objNavBarGroup)

        For Index = 1 To MenusPrincipales.Length - 1

            Dim objNavBarItem As New NavBarItem(MenusPrincipales(Index))
            objNavBarGroup.ItemLinks.Add(objNavBarItem)

            'Recorrer todo el dt, y activar
            If objestadobar <> 1 Then

                objNavBarGroup.Visible = False

            End If

            objNavBarItem.Visible = False

            Dim navobjeto As String = objNavBarItem.ToString

            For j = 0 To dt.Rows.Count - 1

                If dt.Rows(j)("SubModulo") = navobjeto.Trim Then
                    objNavBarGroup.Visible = True

                    objNavBarItem.Visible = True

                    objestadobar = 1
                End If

            Next

        Next

    End Sub


    Shared Sub InitGridViewColumn(ByRef Control As Views.Grid.GridView, Titulo As String, Nombre As String, Ancho As Int16, Optional Visible As Boolean = True, Optional Format As eGridViewFormato = eGridViewFormato.Ninguno, Optional EditarColumna As Boolean = False)
        Dim col As New DevExpress.XtraGrid.Columns.GridColumn

        With col
            .Caption = Titulo
            .FieldName = Nombre
            .Name = Nombre
            .Width = Ancho
            .Visible = Visible

            '.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
            '.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
            '.AppearanceCell.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
            '.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
            '.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
            '.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
            '.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
            '.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
            '.AppearanceHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
            '.AppearanceHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
            '.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
            '.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
            '.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.Value
            '.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None
            '.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.[Default]
            '.ImageAlignment = System.Drawing.StringAlignment.Near

            '.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[Default]
            '.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[Default]
            '.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[Default]

            .OptionsColumn.AllowEdit = EditarColumna
            .OptionsColumn.ReadOnly = Not EditarColumna

            'Se filta en modo Contains
            .OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.[Default]
            '.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[Default]
            '.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[Default]
            '.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
            ' .SortMode = DevExpress.XtraGrid.ColumnSortMode.[Default]
            ' .UnboundType = DevExpress.Data.UnboundColumnType.Bound

            Select Case Format
                Case eGridViewFormato.Numero
                    Dim Repositorio As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()

                    With Repositorio
                        .AutoHeight = False
                        .Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                        .Mask.EditMask = "#,###,###,##0.00"
                        .Name = "repositorionumero"
                    End With
                    .ColumnEdit = Repositorio

                Case eGridViewFormato.FechaHora
                    .DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            End Select

        End With

        Control.Columns.Add(col)

    End Sub

    Shared Sub InitNavBar(ByRef Control As NavBarControl)
        With Control
            'Se establece el ancho
            .Width = 230
            ' .ScrollMode = NavBarScrollMode.ScrollAlways
            'Se ancla a las izquierda
            .Dock = DockStyle.Left

            'Se establece el estilo de navegacion del NavBar
            '.PaintStyleKind = NavBarViewKind.NavigationPane
            .PaintStyleKind = NavBarViewKind.ExplorerBar
            'Se selecciona el modo de seleccion de opcion, que es uno solo por todo el control
            '.LinkSelectionMode = LinkSelectionModeType.OneInControl


            'Se selecciona el modo de seleccion de opcion, que es uno solo por todo el control
            'navBar.LinkSelectionMode = LinkSelectionModeType.OneInControl

            'Se activa grupo por defecto
            ' navBar.ActiveGroup = grpComprobantes
        End With
    End Sub

    Shared Sub InitNavBarMenu(ByRef Control As NavBarControl, MenusPrincipales As String(), Icono As System.Drawing.Image)

        'Se agrega menu principal que es el primer item
        Dim objNavBarGroup As New NavBarGroup(MenusPrincipales(0))

        'Se establece el Icono para el Menu Principal
        objNavBarGroup.LargeImage = Icono

        'Se agrega el Menu Principal al NavBarControl
        Control.Groups.Add(objNavBarGroup)

        'Se agrega los Sub-Menus
        For Index = 1 To MenusPrincipales.Length - 1
            Dim objNavBarItem As New NavBarItem(MenusPrincipales(Index))

            'Se agrega el Sub-Menu al Menu Principal
            objNavBarGroup.ItemLinks.Add(objNavBarItem)
        Next

    End Sub


End Class
