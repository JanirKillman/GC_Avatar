﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.1.4322.573
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class RATemp
    Inherits DataSet
    
    Private tablera As raDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("ra")) Is Nothing) Then
                Me.Tables.Add(New raDataTable(ds.Tables("ra")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property ra As raDataTable
        Get
            Return Me.tablera
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As RATemp = CType(MyBase.Clone,RATemp)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("ra")) Is Nothing) Then
            Me.Tables.Add(New raDataTable(ds.Tables("ra")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tablera = CType(Me.Tables("ra"),raDataTable)
        If (Not (Me.tablera) Is Nothing) Then
            Me.tablera.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "RATemp"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/RATemp.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tablera = New raDataTable
        Me.Tables.Add(Me.tablera)
    End Sub
    
    Private Function ShouldSerializera() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub raRowChangeEventHandler(ByVal sender As Object, ByVal e As raRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class raDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnRace_name As DataColumn
        
        Private columnRace_popis As DataColumn
        
        Private columnRacial_str As DataColumn
        
        Private columnRacial_dex As DataColumn
        
        Private columnRacial_skill As DataColumn
        
        Private columnRacial_fodl As DataColumn
        
        Private columnRacial_podl As DataColumn
        
        Private columnRacial_IQ As DataColumn
        
        Private columnRacial_wis As DataColumn
        
        Private columnRacial_beh As DataColumn
        
        Private columnRacial_beau As DataColumn
        
        Private columnRacial_talents As DataColumn
        
        Private columnRacial_attacks_defenses As DataColumn
        
        Private columnRacial_habits As DataColumn
        
        Private columnRacial_cost As DataColumn
        
        Private columnRacial_lifespan As DataColumn
        
        Private columnRarity As DataColumn
        
        Private columnDate_created As DataColumn
        
        Friend Sub New()
            MyBase.New("ra")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property Race_nameColumn As DataColumn
            Get
                Return Me.columnRace_name
            End Get
        End Property
        
        Friend ReadOnly Property Race_popisColumn As DataColumn
            Get
                Return Me.columnRace_popis
            End Get
        End Property
        
        Friend ReadOnly Property Racial_strColumn As DataColumn
            Get
                Return Me.columnRacial_str
            End Get
        End Property
        
        Friend ReadOnly Property Racial_dexColumn As DataColumn
            Get
                Return Me.columnRacial_dex
            End Get
        End Property
        
        Friend ReadOnly Property Racial_skillColumn As DataColumn
            Get
                Return Me.columnRacial_skill
            End Get
        End Property
        
        Friend ReadOnly Property Racial_fodlColumn As DataColumn
            Get
                Return Me.columnRacial_fodl
            End Get
        End Property
        
        Friend ReadOnly Property Racial_podlColumn As DataColumn
            Get
                Return Me.columnRacial_podl
            End Get
        End Property
        
        Friend ReadOnly Property Racial_IQColumn As DataColumn
            Get
                Return Me.columnRacial_IQ
            End Get
        End Property
        
        Friend ReadOnly Property Racial_wisColumn As DataColumn
            Get
                Return Me.columnRacial_wis
            End Get
        End Property
        
        Friend ReadOnly Property Racial_behColumn As DataColumn
            Get
                Return Me.columnRacial_beh
            End Get
        End Property
        
        Friend ReadOnly Property Racial_beauColumn As DataColumn
            Get
                Return Me.columnRacial_beau
            End Get
        End Property
        
        Friend ReadOnly Property Racial_talentsColumn As DataColumn
            Get
                Return Me.columnRacial_talents
            End Get
        End Property
        
        Friend ReadOnly Property Racial_attacks_defensesColumn As DataColumn
            Get
                Return Me.columnRacial_attacks_defenses
            End Get
        End Property
        
        Friend ReadOnly Property Racial_habitsColumn As DataColumn
            Get
                Return Me.columnRacial_habits
            End Get
        End Property
        
        Friend ReadOnly Property Racial_costColumn As DataColumn
            Get
                Return Me.columnRacial_cost
            End Get
        End Property
        
        Friend ReadOnly Property Racial_lifespanColumn As DataColumn
            Get
                Return Me.columnRacial_lifespan
            End Get
        End Property
        
        Friend ReadOnly Property RarityColumn As DataColumn
            Get
                Return Me.columnRarity
            End Get
        End Property
        
        Friend ReadOnly Property Date_createdColumn As DataColumn
            Get
                Return Me.columnDate_created
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As raRow
            Get
                Return CType(Me.Rows(index),raRow)
            End Get
        End Property
        
        Public Event raRowChanged As raRowChangeEventHandler
        
        Public Event raRowChanging As raRowChangeEventHandler
        
        Public Event raRowDeleted As raRowChangeEventHandler
        
        Public Event raRowDeleting As raRowChangeEventHandler
        
        Public Overloads Sub AddraRow(ByVal row As raRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddraRow( _
                    ByVal Race_name As String,  _
                    ByVal Race_popis As String,  _
                    ByVal Racial_str As String,  _
                    ByVal Racial_dex As String,  _
                    ByVal Racial_skill As String,  _
                    ByVal Racial_fodl As String,  _
                    ByVal Racial_podl As String,  _
                    ByVal Racial_IQ As String,  _
                    ByVal Racial_wis As String,  _
                    ByVal Racial_beh As String,  _
                    ByVal Racial_beau As String,  _
                    ByVal Racial_talents As String,  _
                    ByVal Racial_attacks_defenses As String,  _
                    ByVal Racial_habits As String,  _
                    ByVal Racial_cost As String,  _
                    ByVal Racial_lifespan As String,  _
                    ByVal Rarity As String,  _
                    ByVal Date_created As Date) As raRow
            Dim rowraRow As raRow = CType(Me.NewRow,raRow)
            rowraRow.ItemArray = New Object() {Race_name, Race_popis, Racial_str, Racial_dex, Racial_skill, Racial_fodl, Racial_podl, Racial_IQ, Racial_wis, Racial_beh, Racial_beau, Racial_talents, Racial_attacks_defenses, Racial_habits, Racial_cost, Racial_lifespan, Rarity, Date_created}
            Me.Rows.Add(rowraRow)
            Return rowraRow
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As raDataTable = CType(MyBase.Clone,raDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New raDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnRace_name = Me.Columns("Race_name")
            Me.columnRace_popis = Me.Columns("Race_popis")
            Me.columnRacial_str = Me.Columns("Racial_str")
            Me.columnRacial_dex = Me.Columns("Racial_dex")
            Me.columnRacial_skill = Me.Columns("Racial_skill")
            Me.columnRacial_fodl = Me.Columns("Racial_fodl")
            Me.columnRacial_podl = Me.Columns("Racial_podl")
            Me.columnRacial_IQ = Me.Columns("Racial_IQ")
            Me.columnRacial_wis = Me.Columns("Racial_wis")
            Me.columnRacial_beh = Me.Columns("Racial_beh")
            Me.columnRacial_beau = Me.Columns("Racial_beau")
            Me.columnRacial_talents = Me.Columns("Racial_talents")
            Me.columnRacial_attacks_defenses = Me.Columns("Racial_attacks_defenses")
            Me.columnRacial_habits = Me.Columns("Racial_habits")
            Me.columnRacial_cost = Me.Columns("Racial_cost")
            Me.columnRacial_lifespan = Me.Columns("Racial_lifespan")
            Me.columnRarity = Me.Columns("Rarity")
            Me.columnDate_created = Me.Columns("Date_created")
        End Sub
        
        Private Sub InitClass()
            Me.columnRace_name = New DataColumn("Race_name", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRace_name)
            Me.columnRace_popis = New DataColumn("Race_popis", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRace_popis)
            Me.columnRacial_str = New DataColumn("Racial_str", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_str)
            Me.columnRacial_dex = New DataColumn("Racial_dex", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_dex)
            Me.columnRacial_skill = New DataColumn("Racial_skill", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_skill)
            Me.columnRacial_fodl = New DataColumn("Racial_fodl", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_fodl)
            Me.columnRacial_podl = New DataColumn("Racial_podl", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_podl)
            Me.columnRacial_IQ = New DataColumn("Racial_IQ", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_IQ)
            Me.columnRacial_wis = New DataColumn("Racial_wis", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_wis)
            Me.columnRacial_beh = New DataColumn("Racial_beh", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_beh)
            Me.columnRacial_beau = New DataColumn("Racial_beau", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_beau)
            Me.columnRacial_talents = New DataColumn("Racial_talents", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_talents)
            Me.columnRacial_attacks_defenses = New DataColumn("Racial_attacks_defenses", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_attacks_defenses)
            Me.columnRacial_habits = New DataColumn("Racial_habits", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_habits)
            Me.columnRacial_cost = New DataColumn("Racial_cost", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_cost)
            Me.columnRacial_lifespan = New DataColumn("Racial_lifespan", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRacial_lifespan)
            Me.columnRarity = New DataColumn("Rarity", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRarity)
            Me.columnDate_created = New DataColumn("Date_created", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDate_created)
        End Sub
        
        Public Function NewraRow() As raRow
            Return CType(Me.NewRow,raRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New raRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(raRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.raRowChangedEvent) Is Nothing) Then
                RaiseEvent raRowChanged(Me, New raRowChangeEvent(CType(e.Row,raRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.raRowChangingEvent) Is Nothing) Then
                RaiseEvent raRowChanging(Me, New raRowChangeEvent(CType(e.Row,raRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.raRowDeletedEvent) Is Nothing) Then
                RaiseEvent raRowDeleted(Me, New raRowChangeEvent(CType(e.Row,raRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.raRowDeletingEvent) Is Nothing) Then
                RaiseEvent raRowDeleting(Me, New raRowChangeEvent(CType(e.Row,raRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveraRow(ByVal row As raRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class raRow
        Inherits DataRow
        
        Private tablera As raDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tablera = CType(Me.Table,raDataTable)
        End Sub
        
        Public Property Race_name As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Race_nameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Race_nameColumn) = value
            End Set
        End Property
        
        Public Property Race_popis As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Race_popisColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Race_popisColumn) = value
            End Set
        End Property
        
        Public Property Racial_str As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_strColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_strColumn) = value
            End Set
        End Property
        
        Public Property Racial_dex As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_dexColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_dexColumn) = value
            End Set
        End Property
        
        Public Property Racial_skill As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_skillColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_skillColumn) = value
            End Set
        End Property
        
        Public Property Racial_fodl As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_fodlColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_fodlColumn) = value
            End Set
        End Property
        
        Public Property Racial_podl As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_podlColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_podlColumn) = value
            End Set
        End Property
        
        Public Property Racial_IQ As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_IQColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_IQColumn) = value
            End Set
        End Property
        
        Public Property Racial_wis As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_wisColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_wisColumn) = value
            End Set
        End Property
        
        Public Property Racial_beh As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_behColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_behColumn) = value
            End Set
        End Property
        
        Public Property Racial_beau As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_beauColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_beauColumn) = value
            End Set
        End Property
        
        Public Property Racial_talents As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_talentsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_talentsColumn) = value
            End Set
        End Property
        
        Public Property Racial_attacks_defenses As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_attacks_defensesColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_attacks_defensesColumn) = value
            End Set
        End Property
        
        Public Property Racial_habits As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_habitsColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_habitsColumn) = value
            End Set
        End Property
        
        Public Property Racial_cost As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_costColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_costColumn) = value
            End Set
        End Property
        
        Public Property Racial_lifespan As String
            Get
                Try 
                    Return CType(Me(Me.tablera.Racial_lifespanColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Racial_lifespanColumn) = value
            End Set
        End Property
        
        Public Property Rarity As String
            Get
                Try 
                    Return CType(Me(Me.tablera.RarityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.RarityColumn) = value
            End Set
        End Property
        
        Public Property Date_created As Date
            Get
                Try 
                    Return CType(Me(Me.tablera.Date_createdColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tablera.Date_createdColumn) = value
            End Set
        End Property
        
        Public Function IsRace_nameNull() As Boolean
            Return Me.IsNull(Me.tablera.Race_nameColumn)
        End Function
        
        Public Sub SetRace_nameNull()
            Me(Me.tablera.Race_nameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRace_popisNull() As Boolean
            Return Me.IsNull(Me.tablera.Race_popisColumn)
        End Function
        
        Public Sub SetRace_popisNull()
            Me(Me.tablera.Race_popisColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_strNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_strColumn)
        End Function
        
        Public Sub SetRacial_strNull()
            Me(Me.tablera.Racial_strColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_dexNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_dexColumn)
        End Function
        
        Public Sub SetRacial_dexNull()
            Me(Me.tablera.Racial_dexColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_skillNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_skillColumn)
        End Function
        
        Public Sub SetRacial_skillNull()
            Me(Me.tablera.Racial_skillColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_fodlNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_fodlColumn)
        End Function
        
        Public Sub SetRacial_fodlNull()
            Me(Me.tablera.Racial_fodlColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_podlNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_podlColumn)
        End Function
        
        Public Sub SetRacial_podlNull()
            Me(Me.tablera.Racial_podlColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_IQNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_IQColumn)
        End Function
        
        Public Sub SetRacial_IQNull()
            Me(Me.tablera.Racial_IQColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_wisNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_wisColumn)
        End Function
        
        Public Sub SetRacial_wisNull()
            Me(Me.tablera.Racial_wisColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_behNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_behColumn)
        End Function
        
        Public Sub SetRacial_behNull()
            Me(Me.tablera.Racial_behColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_beauNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_beauColumn)
        End Function
        
        Public Sub SetRacial_beauNull()
            Me(Me.tablera.Racial_beauColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_talentsNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_talentsColumn)
        End Function
        
        Public Sub SetRacial_talentsNull()
            Me(Me.tablera.Racial_talentsColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_attacks_defensesNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_attacks_defensesColumn)
        End Function
        
        Public Sub SetRacial_attacks_defensesNull()
            Me(Me.tablera.Racial_attacks_defensesColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_habitsNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_habitsColumn)
        End Function
        
        Public Sub SetRacial_habitsNull()
            Me(Me.tablera.Racial_habitsColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_costNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_costColumn)
        End Function
        
        Public Sub SetRacial_costNull()
            Me(Me.tablera.Racial_costColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRacial_lifespanNull() As Boolean
            Return Me.IsNull(Me.tablera.Racial_lifespanColumn)
        End Function
        
        Public Sub SetRacial_lifespanNull()
            Me(Me.tablera.Racial_lifespanColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRarityNull() As Boolean
            Return Me.IsNull(Me.tablera.RarityColumn)
        End Function
        
        Public Sub SetRarityNull()
            Me(Me.tablera.RarityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDate_createdNull() As Boolean
            Return Me.IsNull(Me.tablera.Date_createdColumn)
        End Function
        
        Public Sub SetDate_createdNull()
            Me(Me.tablera.Date_createdColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class raRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As raRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As raRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As raRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
