﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.hg = New System.Windows.Forms.TextBox
        Me.tot = New System.Windows.Forms.TextBox
        Me.dis = New System.Windows.Forms.TextBox
        Me.kategori = New System.Windows.Forms.ComboBox
        Me.nb = New System.Windows.Forms.ComboBox
        Me.qty = New System.Windows.Forms.ComboBox
        Me.bayar = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "qty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Bayar"
        '
        'hg
        '
        Me.hg.BackColor = System.Drawing.SystemColors.Window
        Me.hg.Enabled = False
        Me.hg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hg.ForeColor = System.Drawing.SystemColors.Window
        Me.hg.Location = New System.Drawing.Point(96, 77)
        Me.hg.Name = "hg"
        Me.hg.Size = New System.Drawing.Size(184, 21)
        Me.hg.TabIndex = 7
        '
        'tot
        '
        Me.tot.BackColor = System.Drawing.SystemColors.Window
        Me.tot.Enabled = False
        Me.tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot.ForeColor = System.Drawing.SystemColors.Window
        Me.tot.Location = New System.Drawing.Point(96, 137)
        Me.tot.Name = "tot"
        Me.tot.Size = New System.Drawing.Size(121, 21)
        Me.tot.TabIndex = 8
        '
        'dis
        '
        Me.dis.BackColor = System.Drawing.SystemColors.Window
        Me.dis.Enabled = False
        Me.dis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dis.ForeColor = System.Drawing.SystemColors.Window
        Me.dis.Location = New System.Drawing.Point(96, 167)
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(121, 21)
        Me.dis.TabIndex = 9
        '
        'kategori
        '
        Me.kategori.FormattingEnabled = True
        Me.kategori.Items.AddRange(New Object() {"Minuman Ringan", "Makanan Ringan"})
        Me.kategori.Location = New System.Drawing.Point(96, 19)
        Me.kategori.Name = "kategori"
        Me.kategori.Size = New System.Drawing.Size(184, 21)
        Me.kategori.TabIndex = 10
        '
        'nb
        '
        Me.nb.FormattingEnabled = True
        Me.nb.Location = New System.Drawing.Point(96, 50)
        Me.nb.Name = "nb"
        Me.nb.Size = New System.Drawing.Size(184, 21)
        Me.nb.TabIndex = 11
        '
        'qty
        '
        Me.qty.FormattingEnabled = True
        Me.qty.Items.AddRange(New Object() {"100", "200", "300"})
        Me.qty.Location = New System.Drawing.Point(98, 106)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(119, 21)
        Me.qty.TabIndex = 12
        '
        'bayar
        '
        Me.bayar.BackColor = System.Drawing.SystemColors.Window
        Me.bayar.Enabled = False
        Me.bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.ForeColor = System.Drawing.SystemColors.Window
        Me.bayar.Location = New System.Drawing.Point(96, 196)
        Me.bayar.Multiline = True
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(184, 58)
        Me.bayar.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 319)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.nb)
        Me.Controls.Add(Me.kategori)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.tot)
        Me.Controls.Add(Me.hg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "NIM: 8020130072 NAMA: ACHMAD WIRA GUNTARA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents hg As System.Windows.Forms.TextBox
    Friend WithEvents tot As System.Windows.Forms.TextBox
    Friend WithEvents dis As System.Windows.Forms.TextBox
    Friend WithEvents nb As System.Windows.Forms.ComboBox
    Friend WithEvents qty As System.Windows.Forms.ComboBox
    Friend WithEvents bayar As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kategori As System.Windows.Forms.ComboBox

End Class
