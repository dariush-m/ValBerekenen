<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Input))
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.materials = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomUnit = New System.Windows.Forms.Label()
        Me.lblWarningCustom = New System.Windows.Forms.Label()
        Me.lblWarningMaterial = New System.Windows.Forms.Label()
        Me.tbCustom = New System.Windows.Forms.TextBox()
        Me.cbMaterials = New System.Windows.Forms.ComboBox()
        Me.btnCustom = New System.Windows.Forms.RadioButton()
        Me.btnMaterial = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.tbRadius = New System.Windows.Forms.TextBox()
        Me.tbHeight = New System.Windows.Forms.TextBox()
        Me.lblWarningRadius = New System.Windows.Forms.Label()
        Me.lblWarningHeight = New System.Windows.Forms.Label()
        Me.lblRadiusUnit = New System.Windows.Forms.Label()
        Me.lblHeightUnit = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblWarningCycles = New System.Windows.Forms.Label()
        Me.tbCycles = New System.Windows.Forms.TextBox()
        Me.lblCycles = New System.Windows.Forms.Label()
        Me.cbCycles = New System.Windows.Forms.CheckBox()
        Me.materials.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadius.Location = New System.Drawing.Point(32, 34)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(70, 22)
        Me.lblRadius.TabIndex = 0
        Me.lblRadius.Text = "STRAAL"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Consolas", 14.25!)
        Me.lblHeight.Location = New System.Drawing.Point(239, 34)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(70, 22)
        Me.lblHeight.TabIndex = 1
        Me.lblHeight.Text = "HOOGTE"
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.Font = New System.Drawing.Font("Consolas", 14.25!)
        Me.lblDensity.Location = New System.Drawing.Point(32, 129)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(100, 22)
        Me.lblDensity.TabIndex = 2
        Me.lblDensity.Text = "DICHTHEID"
        '
        'materials
        '
        Me.materials.BackColor = System.Drawing.SystemColors.Control
        Me.materials.Controls.Add(Me.Label1)
        Me.materials.Controls.Add(Me.lblCustomUnit)
        Me.materials.Controls.Add(Me.lblWarningCustom)
        Me.materials.Controls.Add(Me.lblWarningMaterial)
        Me.materials.Controls.Add(Me.tbCustom)
        Me.materials.Controls.Add(Me.cbMaterials)
        Me.materials.Controls.Add(Me.btnCustom)
        Me.materials.Controls.Add(Me.btnMaterial)
        Me.materials.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.materials.Location = New System.Drawing.Point(36, 171)
        Me.materials.Name = "materials"
        Me.materials.Size = New System.Drawing.Size(407, 110)
        Me.materials.TabIndex = 3
        Me.materials.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "3"
        '
        'lblCustomUnit
        '
        Me.lblCustomUnit.AutoSize = True
        Me.lblCustomUnit.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomUnit.Location = New System.Drawing.Point(331, 66)
        Me.lblCustomUnit.Name = "lblCustomUnit"
        Me.lblCustomUnit.Size = New System.Drawing.Size(50, 22)
        Me.lblCustomUnit.TabIndex = 11
        Me.lblCustomUnit.Text = "kg/m"
        '
        'lblWarningCustom
        '
        Me.lblWarningCustom.AutoSize = True
        Me.lblWarningCustom.ForeColor = System.Drawing.Color.Red
        Me.lblWarningCustom.Location = New System.Drawing.Point(204, 50)
        Me.lblWarningCustom.Name = "lblWarningCustom"
        Me.lblWarningCustom.Size = New System.Drawing.Size(50, 13)
        Me.lblWarningCustom.TabIndex = 10
        Me.lblWarningCustom.Text = "SAMPLE"
        Me.lblWarningCustom.Visible = False
        '
        'lblWarningMaterial
        '
        Me.lblWarningMaterial.AutoSize = True
        Me.lblWarningMaterial.ForeColor = System.Drawing.Color.Red
        Me.lblWarningMaterial.Location = New System.Drawing.Point(10, 50)
        Me.lblWarningMaterial.Name = "lblWarningMaterial"
        Me.lblWarningMaterial.Size = New System.Drawing.Size(50, 13)
        Me.lblWarningMaterial.TabIndex = 9
        Me.lblWarningMaterial.Text = "SAMPLE"
        Me.lblWarningMaterial.Visible = False
        '
        'tbCustom
        '
        Me.tbCustom.Location = New System.Drawing.Point(207, 66)
        Me.tbCustom.Name = "tbCustom"
        Me.tbCustom.Size = New System.Drawing.Size(118, 20)
        Me.tbCustom.TabIndex = 3
        '
        'cbMaterials
        '
        Me.cbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaterials.FormattingEnabled = True
        Me.cbMaterials.IntegralHeight = False
        Me.cbMaterials.Items.AddRange(New Object() {"Goud", "Zilver", "Hout", "IJzer", "Lood"})
        Me.cbMaterials.Location = New System.Drawing.Point(13, 66)
        Me.cbMaterials.Name = "cbMaterials"
        Me.cbMaterials.Size = New System.Drawing.Size(118, 21)
        Me.cbMaterials.TabIndex = 2
        '
        'btnCustom
        '
        Me.btnCustom.AutoSize = True
        Me.btnCustom.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.btnCustom.Location = New System.Drawing.Point(207, 19)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.Size = New System.Drawing.Size(108, 23)
        Me.btnCustom.TabIndex = 1
        Me.btnCustom.TabStop = True
        Me.btnCustom.Text = "Aangepast"
        Me.btnCustom.UseVisualStyleBackColor = True
        '
        'btnMaterial
        '
        Me.btnMaterial.AutoSize = True
        Me.btnMaterial.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaterial.Location = New System.Drawing.Point(13, 19)
        Me.btnMaterial.Name = "btnMaterial"
        Me.btnMaterial.Size = New System.Drawing.Size(108, 23)
        Me.btnMaterial.TabIndex = 0
        Me.btnMaterial.TabStop = True
        Me.btnMaterial.Text = "Materiaal"
        Me.btnMaterial.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(36, 405)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(175, 64)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Run"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'tbRadius
        '
        Me.tbRadius.Location = New System.Drawing.Point(36, 72)
        Me.tbRadius.Name = "tbRadius"
        Me.tbRadius.Size = New System.Drawing.Size(118, 20)
        Me.tbRadius.TabIndex = 5
        '
        'tbHeight
        '
        Me.tbHeight.Location = New System.Drawing.Point(243, 72)
        Me.tbHeight.Name = "tbHeight"
        Me.tbHeight.Size = New System.Drawing.Size(118, 20)
        Me.tbHeight.TabIndex = 6
        '
        'lblWarningRadius
        '
        Me.lblWarningRadius.AutoSize = True
        Me.lblWarningRadius.ForeColor = System.Drawing.Color.Red
        Me.lblWarningRadius.Location = New System.Drawing.Point(33, 56)
        Me.lblWarningRadius.Name = "lblWarningRadius"
        Me.lblWarningRadius.Size = New System.Drawing.Size(50, 13)
        Me.lblWarningRadius.TabIndex = 7
        Me.lblWarningRadius.Text = "SAMPLE"
        Me.lblWarningRadius.Visible = False
        '
        'lblWarningHeight
        '
        Me.lblWarningHeight.AutoSize = True
        Me.lblWarningHeight.ForeColor = System.Drawing.Color.Red
        Me.lblWarningHeight.Location = New System.Drawing.Point(240, 56)
        Me.lblWarningHeight.Name = "lblWarningHeight"
        Me.lblWarningHeight.Size = New System.Drawing.Size(50, 13)
        Me.lblWarningHeight.TabIndex = 8
        Me.lblWarningHeight.Text = "SAMPLE"
        Me.lblWarningHeight.Visible = False
        '
        'lblRadiusUnit
        '
        Me.lblRadiusUnit.AutoSize = True
        Me.lblRadiusUnit.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadiusUnit.Location = New System.Drawing.Point(160, 72)
        Me.lblRadiusUnit.Name = "lblRadiusUnit"
        Me.lblRadiusUnit.Size = New System.Drawing.Size(20, 22)
        Me.lblRadiusUnit.TabIndex = 9
        Me.lblRadiusUnit.Text = "m"
        '
        'lblHeightUnit
        '
        Me.lblHeightUnit.AutoSize = True
        Me.lblHeightUnit.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightUnit.Location = New System.Drawing.Point(367, 72)
        Me.lblHeightUnit.Name = "lblHeightUnit"
        Me.lblHeightUnit.Size = New System.Drawing.Size(20, 22)
        Me.lblHeightUnit.TabIndex = 10
        Me.lblHeightUnit.Text = "m"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(238, 405)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(205, 64)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblWarningCycles
        '
        Me.lblWarningCycles.AutoSize = True
        Me.lblWarningCycles.ForeColor = System.Drawing.Color.Red
        Me.lblWarningCycles.Location = New System.Drawing.Point(46, 337)
        Me.lblWarningCycles.Name = "lblWarningCycles"
        Me.lblWarningCycles.Size = New System.Drawing.Size(50, 13)
        Me.lblWarningCycles.TabIndex = 14
        Me.lblWarningCycles.Text = "SAMPLE"
        Me.lblWarningCycles.Visible = False
        '
        'tbCycles
        '
        Me.tbCycles.Location = New System.Drawing.Point(49, 353)
        Me.tbCycles.Name = "tbCycles"
        Me.tbCycles.Size = New System.Drawing.Size(118, 20)
        Me.tbCycles.TabIndex = 13
        '
        'lblCycles
        '
        Me.lblCycles.AutoSize = True
        Me.lblCycles.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCycles.Location = New System.Drawing.Point(45, 313)
        Me.lblCycles.Name = "lblCycles"
        Me.lblCycles.Size = New System.Drawing.Size(70, 22)
        Me.lblCycles.TabIndex = 12
        Me.lblCycles.Text = "CYCLES"
        '
        'cbCycles
        '
        Me.cbCycles.AutoSize = True
        Me.cbCycles.Location = New System.Drawing.Point(121, 321)
        Me.cbCycles.Name = "cbCycles"
        Me.cbCycles.Size = New System.Drawing.Size(15, 14)
        Me.cbCycles.TabIndex = 15
        Me.cbCycles.UseVisualStyleBackColor = True
        '
        'Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 498)
        Me.Controls.Add(Me.cbCycles)
        Me.Controls.Add(Me.lblWarningCycles)
        Me.Controls.Add(Me.tbCycles)
        Me.Controls.Add(Me.lblCycles)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblHeightUnit)
        Me.Controls.Add(Me.lblRadiusUnit)
        Me.Controls.Add(Me.lblWarningHeight)
        Me.Controls.Add(Me.lblWarningRadius)
        Me.Controls.Add(Me.tbHeight)
        Me.Controls.Add(Me.tbRadius)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.materials)
        Me.Controls.Add(Me.lblDensity)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblRadius)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Input"
        Me.Text = "Val Bereken"
        Me.materials.ResumeLayout(False)
        Me.materials.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents lblDensity As System.Windows.Forms.Label
    Friend WithEvents materials As System.Windows.Forms.GroupBox
    Friend WithEvents btnCustom As System.Windows.Forms.RadioButton
    Friend WithEvents btnMaterial As System.Windows.Forms.RadioButton
    Friend WithEvents cbMaterials As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents tbCustom As System.Windows.Forms.TextBox
    Friend WithEvents tbRadius As TextBox
    Friend WithEvents tbHeight As TextBox
    Friend WithEvents lblWarningCustom As Label
    Friend WithEvents lblWarningMaterial As Label
    Friend WithEvents lblWarningRadius As Label
    Friend WithEvents lblWarningHeight As Label
    Friend WithEvents lblRadiusUnit As Label
    Friend WithEvents lblHeightUnit As Label
    Friend WithEvents lblCustomUnit As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblWarningCycles As Label
    Friend WithEvents tbCycles As TextBox
    Friend WithEvents lblCycles As Label
    Friend WithEvents cbCycles As CheckBox
    Friend WithEvents Label1 As Label
End Class
