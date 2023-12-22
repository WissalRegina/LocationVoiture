<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RegNumTb = New System.Windows.Forms.TextBox()
        Me.ColorTb = New System.Windows.Forms.TextBox()
        Me.ModelTb = New System.Windows.Forms.TextBox()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.BrandCb = New System.Windows.Forms.ComboBox()
        Me.Availablecb = New System.Windows.Forms.ComboBox()
        Me.CarDgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 59)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(764, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CarRentalSystem.My.Resources.Resources.customer_customer_icon_146530250
        Me.PictureBox2.Location = New System.Drawing.Point(697, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(81, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Car Rental Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarRentalSystem.My.Resources.Resources._4b1d63a10d8b7155598bdda1e71c6319_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox6)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 65)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumBlue
        Me.Panel3.Location = New System.Drawing.Point(99, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(90, 6)
        Me.Panel3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(144, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 22)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cars"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(499, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(676, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Return"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(308, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Customers"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.CarRentalSystem.My.Resources.Resources.téléchargement_removebg_preview__1_
        Me.PictureBox6.Location = New System.Drawing.Point(612, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(58, 56)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CarRentalSystem.My.Resources.Resources.car_rental_sign_logo_849855CB05_seeklogo_com
        Me.PictureBox5.Location = New System.Drawing.Point(441, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(52, 56)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.CarRentalSystem.My.Resources.Resources.téléchargement_removebg_preview
        Me.PictureBox4.Location = New System.Drawing.Point(250, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(52, 56)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CarRentalSystem.My.Resources.Resources._1473103359
        Me.PictureBox3.Location = New System.Drawing.Point(95, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 56)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(127, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Reg Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(422, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Cars List"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(676, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Available"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(403, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 19)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Color"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(127, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 19)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Price"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Crimson
        Me.Label12.Location = New System.Drawing.Point(676, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 19)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Model"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Crimson
        Me.Label13.Location = New System.Drawing.Point(403, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 19)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Brand"
        '
        'RegNumTb
        '
        Me.RegNumTb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegNumTb.Location = New System.Drawing.Point(130, 211)
        Me.RegNumTb.Name = "RegNumTb"
        Me.RegNumTb.Size = New System.Drawing.Size(184, 26)
        Me.RegNumTb.TabIndex = 9
        '
        'ColorTb
        '
        Me.ColorTb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorTb.Location = New System.Drawing.Point(407, 307)
        Me.ColorTb.Name = "ColorTb"
        Me.ColorTb.Size = New System.Drawing.Size(184, 26)
        Me.ColorTb.TabIndex = 10
        '
        'ModelTb
        '
        Me.ModelTb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelTb.Location = New System.Drawing.Point(680, 211)
        Me.ModelTb.Name = "ModelTb"
        Me.ModelTb.Size = New System.Drawing.Size(184, 26)
        Me.ModelTb.TabIndex = 11
        '
        'PriceTb
        '
        Me.PriceTb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTb.Location = New System.Drawing.Point(130, 307)
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(184, 26)
        Me.PriceTb.TabIndex = 12
        '
        'BrandCb
        '
        Me.BrandCb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandCb.FormattingEnabled = True
        Me.BrandCb.Items.AddRange(New Object() {"Jeep", "Mercedes", "Yundai", "Ford", "Chevrolet", "Peogeot", "Audi", "Clio", "Kia", "Toyota", "Cetreon"})
        Me.BrandCb.Location = New System.Drawing.Point(407, 211)
        Me.BrandCb.Name = "BrandCb"
        Me.BrandCb.Size = New System.Drawing.Size(184, 27)
        Me.BrandCb.TabIndex = 13
        '
        'Availablecb
        '
        Me.Availablecb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Availablecb.FormattingEnabled = True
        Me.Availablecb.Items.AddRange(New Object() {"yes", "no"})
        Me.Availablecb.Location = New System.Drawing.Point(674, 307)
        Me.Availablecb.Name = "Availablecb"
        Me.Availablecb.Size = New System.Drawing.Size(186, 27)
        Me.Availablecb.TabIndex = 14
        '
        'CarDgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.CarDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CarDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CarDgv.BackgroundColor = System.Drawing.Color.White
        Me.CarDgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CarDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CarDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CarDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CarDgv.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CarDgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.CarDgv.EnableHeadersVisualStyles = False
        Me.CarDgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CarDgv.Location = New System.Drawing.Point(75, 420)
        Me.CarDgv.Name = "CarDgv"
        Me.CarDgv.RowHeadersVisible = False
        Me.CarDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CarDgv.Size = New System.Drawing.Size(785, 219)
        Me.CarDgv.TabIndex = 15
        Me.CarDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CarDgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CarDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CarDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CarDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CarDgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CarDgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CarDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CarDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CarDgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CarDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CarDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CarDgv.ThemeStyle.HeaderStyle.Height = 30
        Me.CarDgv.ThemeStyle.ReadOnly = False
        Me.CarDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CarDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CarDgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.CarDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CarDgv.ThemeStyle.RowsStyle.Height = 22
        Me.CarDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CarDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.Navy
        Me.add_btn.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.Color.White
        Me.add_btn.Location = New System.Drawing.Point(232, 339)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(103, 35)
        Me.add_btn.TabIndex = 16
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'edit_btn
        '
        Me.edit_btn.BackColor = System.Drawing.Color.Navy
        Me.edit_btn.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.ForeColor = System.Drawing.Color.White
        Me.edit_btn.Location = New System.Drawing.Point(350, 339)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(103, 35)
        Me.edit_btn.TabIndex = 17
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Navy
        Me.delete_btn.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.Location = New System.Drawing.Point(469, 339)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(103, 35)
        Me.delete_btn.TabIndex = 18
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Navy
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(587, 340)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 35)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(872, 651)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.edit_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.CarDgv)
        Me.Controls.Add(Me.Availablecb)
        Me.Controls.Add(Me.BrandCb)
        Me.Controls.Add(Me.PriceTb)
        Me.Controls.Add(Me.ModelTb)
        Me.Controls.Add(Me.ColorTb)
        Me.Controls.Add(Me.RegNumTb)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cars"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RegNumTb As TextBox
    Friend WithEvents ColorTb As TextBox
    Friend WithEvents ModelTb As TextBox
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents BrandCb As ComboBox
    Friend WithEvents Availablecb As ComboBox
    Friend WithEvents CarDgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents add_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents Button4 As Button
End Class
