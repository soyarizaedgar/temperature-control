<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.curr_temp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ind_lamp = New System.Windows.Forms.Button()
        Me.set_point = New System.Windows.Forms.NumericUpDown()
        Me.btn_com = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.port_box = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.ind_fan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.set_point, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'curr_temp
        '
        Me.curr_temp.Location = New System.Drawing.Point(40, 116)
        Me.curr_temp.Name = "curr_temp"
        Me.curr_temp.Size = New System.Drawing.Size(293, 38)
        Me.curr_temp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current temperature"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Set point"
        '
        'ind_lamp
        '
        Me.ind_lamp.BackColor = System.Drawing.Color.Red
        Me.ind_lamp.Location = New System.Drawing.Point(81, 101)
        Me.ind_lamp.Name = "ind_lamp"
        Me.ind_lamp.Size = New System.Drawing.Size(172, 66)
        Me.ind_lamp.TabIndex = 4
        Me.ind_lamp.Text = "OFF"
        Me.ind_lamp.UseVisualStyleBackColor = False
        '
        'set_point
        '
        Me.set_point.Location = New System.Drawing.Point(40, 250)
        Me.set_point.Name = "set_point"
        Me.set_point.Size = New System.Drawing.Size(293, 38)
        Me.set_point.TabIndex = 6
        '
        'btn_com
        '
        Me.btn_com.Location = New System.Drawing.Point(35, 146)
        Me.btn_com.Name = "btn_com"
        Me.btn_com.Size = New System.Drawing.Size(190, 96)
        Me.btn_com.TabIndex = 11
        Me.btn_com.Text = "OK"
        Me.btn_com.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Port"
        '
        'port_box
        '
        Me.port_box.Location = New System.Drawing.Point(35, 88)
        Me.port_box.Name = "port_box"
        Me.port_box.Size = New System.Drawing.Size(279, 38)
        Me.port_box.TabIndex = 9
        Me.port_box.Text = "COM6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "LAMP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "FAN"
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.Color.Red
        Me.btnstart.Location = New System.Drawing.Point(703, 599)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(225, 110)
        Me.btnstart.TabIndex = 14
        Me.btnstart.Text = "ON / OFF"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(988, 599)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(225, 110)
        Me.btnexit.TabIndex = 15
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'ind_fan
        '
        Me.ind_fan.BackColor = System.Drawing.Color.Red
        Me.ind_fan.Location = New System.Drawing.Point(81, 258)
        Me.ind_fan.Name = "ind_fan"
        Me.ind_fan.Size = New System.Drawing.Size(172, 66)
        Me.ind_fan.TabIndex = 16
        Me.ind_fan.Text = "OFF"
        Me.ind_fan.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ind_fan)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ind_lamp)
        Me.GroupBox1.Location = New System.Drawing.Point(559, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 340)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INDICATORS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_com)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.port_box)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 530)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 257)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SETTINGS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.set_point)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.curr_temp)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 340)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONTROL UNIT"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM6"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 838)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnstart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.set_point, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents curr_temp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ind_lamp As Button
    Friend WithEvents set_point As NumericUpDown
    Friend WithEvents btn_com As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents port_box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnstart As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents ind_fan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
End Class
