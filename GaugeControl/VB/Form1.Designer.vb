Imports DevComponents.Instrumentation

Namespace GaugeControl_Sample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
Dim GaugeCircularScale5 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer29 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange13 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection22 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor38 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor39 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeCircularScale6 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer30 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection23 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeText13 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeCircularScale7 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GradientFillColor40 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer31 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange14 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection24 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale8 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GradientFillColor41 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer32 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange15 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection25 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale9 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GradientFillColor42 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer33 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange16 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection26 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale10 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer34 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer35 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange17 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection27 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor43 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor44 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeCircularScale11 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer36 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer37 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection28 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection29 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection30 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection31 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection32 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale12 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer38 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection33 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection34 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale13 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeCustomLabel7 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GradientFillColor45 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor46 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer39 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection35 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection36 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor47 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor48 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeCircularScale19 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer46 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer47 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange28 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection48 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection49 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeText14 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeImage3 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim NumericIndicator2 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim GaugeCircularScale17 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeCustomLabel12 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugeCustomLabel13 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugePointer45 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange25 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange26 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange27 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection44 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection45 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection46 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale18 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeSection47 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor54 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor55 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim StateIndicator2 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateRange2 As DevComponents.Instrumentation.StateRange = New DevComponents.Instrumentation.StateRange
Dim StateRange3 As DevComponents.Instrumentation.StateRange = New DevComponents.Instrumentation.StateRange
Dim StateRange4 As DevComponents.Instrumentation.StateRange = New DevComponents.Instrumentation.StateRange
Dim GaugeCircularScale14 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer40 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange18 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection37 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection38 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale15 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeCustomLabel8 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GradientFillColor49 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeCustomLabel9 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GradientFillColor50 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer41 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange19 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange20 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange21 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection39 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection40 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale16 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeCustomLabel10 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GradientFillColor51 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeCustomLabel11 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugePointer42 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer43 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer44 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange22 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange23 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange24 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection41 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection42 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection43 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor52 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor53 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeCircularScale23 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeCustomLabel14 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugePointer54 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer55 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer56 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange29 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection56 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection57 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeText16 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeImage5 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim GradientFillColor9 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor10 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeText2 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeText3 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale1 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GaugeCustomLabel2 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugeCustomLabel3 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugeCustomLabel4 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GradientFillColor11 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor12 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer11 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection9 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection10 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection11 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection12 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale2 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugeCustomLabel1 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugePointer4 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
Dim GaugeRange2 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange3 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange4 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange5 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection2 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection3 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection4 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor3 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor4 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeImage1 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim GaugeCircularScale3 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer5 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer6 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange6 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection5 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection6 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor5 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor6 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeText1 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeImage2 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim GaugeCircularScale4 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer7 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer8 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer9 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer10 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange7 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange8 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeRange9 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection7 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection8 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor7 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor8 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim NumericIndicator1 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim StateIndicator1 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateRange1 As DevComponents.Instrumentation.StateRange = New DevComponents.Instrumentation.StateRange
Dim GaugeCircularScale1 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GaugePointer1 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer2 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer3 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange1 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection1 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor1 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor2 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeText12 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale13 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor36 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor37 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer27 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer28 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection21 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeText4 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeText5 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale2 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor13 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor14 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer12 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer13 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection13 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeLinearScale3 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GaugeCustomLabel5 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugeCustomLabel6 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugePointer14 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer15 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange10 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeLinearScale4 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GaugeSection14 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeSection15 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeText6 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeText7 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale5 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor15 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor16 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer16 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection16 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeLinearScale6 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor17 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor18 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor19 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor20 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeText8 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeText9 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale7 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor21 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor22 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer17 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection17 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeLinearScale8 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor23 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor24 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor25 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor26 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeLinearScale9 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor27 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer18 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer19 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer20 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer21 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GradientFillColor28 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor29 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeText10 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale10 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor30 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor31 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer22 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer23 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection18 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeLinearScale11 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor32 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor33 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer24 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange11 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection19 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeText11 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeLinearScale12 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor34 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor35 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer25 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer26 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeRange12 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange
Dim GaugeSection20 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale20 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GradientFillColor64 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor65 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer48 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection50 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale21 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GradientFillColor66 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor67 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer49 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection51 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeCircularScale22 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale
Dim GradientFillColor68 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor69 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer50 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection52 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor70 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor71 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugeText15 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeImage4 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim GaugeLinearScale14 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor72 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor73 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer51 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection53 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeLinearScale15 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GradientFillColor74 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor75 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GaugePointer52 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection54 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GaugeLinearScale16 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GaugePointer53 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection55 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Dim GradientFillColor56 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor57 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim NumericIndicator3 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator4 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator5 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator6 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator7 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator8 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator9 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator10 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim GradientFillColor58 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor59 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim NumericIndicator11 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator12 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator13 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator14 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator15 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator16 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator17 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator18 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim GradientFillColor60 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor61 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim StateIndicator3 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator4 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator5 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator6 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator7 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator8 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator9 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator10 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator11 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator12 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator13 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator14 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator15 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator16 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator17 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator18 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator19 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim StateIndicator20 As DevComponents.Instrumentation.StateIndicator = New DevComponents.Instrumentation.StateIndicator
Dim GradientFillColor62 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim GradientFillColor63 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor
Dim NumericIndicator19 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator20 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator21 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator22 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator23 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator24 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim NumericIndicator25 As DevComponents.Instrumentation.NumericIndicator = New DevComponents.Instrumentation.NumericIndicator
Dim GaugeText17 As DevComponents.Instrumentation.GaugeText = New DevComponents.Instrumentation.GaugeText
Dim GaugeImage6 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim GaugeImage7 As DevComponents.Instrumentation.GaugeImage = New DevComponents.Instrumentation.GaugeImage
Dim GaugeLinearScale17 As DevComponents.Instrumentation.GaugeLinearScale = New DevComponents.Instrumentation.GaugeLinearScale
Dim GaugeCustomLabel15 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugeCustomLabel16 As DevComponents.Instrumentation.GaugeCustomLabel = New DevComponents.Instrumentation.GaugeCustomLabel
Dim GaugePointer57 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer58 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugePointer59 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer
Dim GaugeSection58 As DevComponents.Instrumentation.GaugeSection = New DevComponents.Instrumentation.GaugeSection
Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl
Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.superTabControl2 = New DevComponents.DotNetBar.SuperTabControl
Me.superTabControlPanel17 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.gcCircular8a = New DevComponents.Instrumentation.GaugeControl
Me.gcCircular8b = New DevComponents.Instrumentation.GaugeControl
Me.labelX16 = New DevComponents.DotNetBar.LabelX
Me.circularTab8 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel15 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.gcCircular7c = New DevComponents.Instrumentation.GaugeControl
Me.gcCircular7b = New DevComponents.Instrumentation.GaugeControl
Me.gcCircular7a = New DevComponents.Instrumentation.GaugeControl
Me.circularTab7 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel16 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.cbHonorMaxPin = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX35 = New DevComponents.DotNetBar.LabelX
Me.cbHonorMinPin = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.sliderMaxPin = New DevComponents.DotNetBar.Controls.Slider
Me.labelX34 = New DevComponents.DotNetBar.LabelX
Me.labelX23 = New DevComponents.DotNetBar.LabelX
Me.cbRotateCap = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.gcCircular6 = New DevComponents.Instrumentation.GaugeControl
Me.circularTab6 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.sliderArc = New DevComponents.DotNetBar.Controls.Slider
Me.rbRoundRect = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.rbRect = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.rbCircular = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.rbNone = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX22 = New DevComponents.DotNetBar.LabelX
Me.labelX21 = New DevComponents.DotNetBar.LabelX
Me.gcCircular5 = New DevComponents.Instrumentation.GaugeControl
Me.circularTab5 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel18 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.sliderScaleAngle = New DevComponents.DotNetBar.Controls.Slider
Me.labelX30 = New DevComponents.DotNetBar.LabelX
Me.cbShowTooltips = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX15 = New DevComponents.DotNetBar.LabelX
Me.gcCircular1 = New DevComponents.Instrumentation.GaugeControl
Me.circularTab1 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel8 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX19 = New DevComponents.DotNetBar.LabelX
Me.labelX18 = New DevComponents.DotNetBar.LabelX
Me.cbReverse2 = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbReverse1 = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbCAddGlassEffect = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.gcCircular2 = New DevComponents.Instrumentation.GaugeControl
Me.circularTab2 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX31 = New DevComponents.DotNetBar.LabelX
Me.labelX20 = New DevComponents.DotNetBar.LabelX
Me.cbCRotateLabels = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbCAutoOrientLabels = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.sliderCAngle = New DevComponents.DotNetBar.Controls.Slider
Me.gcCircular4 = New DevComponents.Instrumentation.GaugeControl
Me.circularTab4 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel6 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX33 = New DevComponents.DotNetBar.LabelX
Me.labelX17 = New DevComponents.DotNetBar.LabelX
Me.labelX14 = New DevComponents.DotNetBar.LabelX
Me.gcCircular3 = New DevComponents.Instrumentation.GaugeControl
Me.circularTab3 = New DevComponents.DotNetBar.SuperTabItem
Me.CTabSamples = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.linkLabel1 = New System.Windows.Forms.LinkLabel
Me.textBox35 = New System.Windows.Forms.TextBox
Me.label36 = New System.Windows.Forms.Label
Me.textBox16 = New System.Windows.Forms.TextBox
Me.label17 = New System.Windows.Forms.Label
Me.textBox15 = New System.Windows.Forms.TextBox
Me.label16 = New System.Windows.Forms.Label
Me.textBox14 = New System.Windows.Forms.TextBox
Me.label15 = New System.Windows.Forms.Label
Me.textBox13 = New System.Windows.Forms.TextBox
Me.label14 = New System.Windows.Forms.Label
Me.textBox12 = New System.Windows.Forms.TextBox
Me.label13 = New System.Windows.Forms.Label
Me.textBox11 = New System.Windows.Forms.TextBox
Me.label12 = New System.Windows.Forms.Label
Me.label6 = New System.Windows.Forms.Label
Me.label11 = New System.Windows.Forms.Label
Me.textBox10 = New System.Windows.Forms.TextBox
Me.label10 = New System.Windows.Forms.Label
Me.textBox9 = New System.Windows.Forms.TextBox
Me.label9 = New System.Windows.Forms.Label
Me.textBox8 = New System.Windows.Forms.TextBox
Me.label8 = New System.Windows.Forms.Label
Me.textBox7 = New System.Windows.Forms.TextBox
Me.label7 = New System.Windows.Forms.Label
Me.textBox6 = New System.Windows.Forms.TextBox
Me.textBox5 = New System.Windows.Forms.TextBox
Me.label5 = New System.Windows.Forms.Label
Me.textBox4 = New System.Windows.Forms.TextBox
Me.label4 = New System.Windows.Forms.Label
Me.textBox3 = New System.Windows.Forms.TextBox
Me.label3 = New System.Windows.Forms.Label
Me.textBox2 = New System.Windows.Forms.TextBox
Me.label2 = New System.Windows.Forms.Label
Me.textBox1 = New System.Windows.Forms.TextBox
Me.label1 = New System.Windows.Forms.Label
Me.gcCircularElements = New DevComponents.Instrumentation.GaugeControl
Me.CTabElements = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel22 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.superTabControl4 = New DevComponents.DotNetBar.SuperTabControl
Me.superTabControlPanel21 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX13 = New DevComponents.DotNetBar.LabelX
Me.gcPointerChange = New DevComponents.Instrumentation.GaugeControl
Me.tabPointerChange = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel26 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX29 = New DevComponents.DotNetBar.LabelX
Me.labelX28 = New DevComponents.DotNetBar.LabelX
Me.cbSetLimits = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX27 = New DevComponents.DotNetBar.LabelX
Me.labelX26 = New DevComponents.DotNetBar.LabelX
Me.btnAuto2 = New DevComponents.DotNetBar.ButtonX
Me.cbSliderDampen2 = New DevComponents.DotNetBar.Controls.Slider
Me.btnMin2 = New DevComponents.DotNetBar.ButtonX
Me.btnMax2 = New DevComponents.DotNetBar.ButtonX
Me.btnMinus10 = New DevComponents.DotNetBar.ButtonX
Me.btnPlus20 = New DevComponents.DotNetBar.ButtonX
Me.gcScaleLimits = New DevComponents.Instrumentation.GaugeControl
Me.tabLimits = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel25 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.btnRtb2Clear = New DevComponents.DotNetBar.ButtonX
Me.rtb2 = New System.Windows.Forms.RichTextBox
Me.labelX4 = New DevComponents.DotNetBar.LabelX
Me.gcHitTesting = New DevComponents.Instrumentation.GaugeControl
Me.tabHitTesting = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel24 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.cbShowRangeEvents = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbShowSectionEvents = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbShowScaleEvents = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX3 = New DevComponents.DotNetBar.LabelX
Me.btnClear = New DevComponents.DotNetBar.ButtonX
Me.labelX2 = New DevComponents.DotNetBar.LabelX
Me.btnAuto = New DevComponents.DotNetBar.ButtonX
Me.rtb1 = New System.Windows.Forms.RichTextBox
Me.sliderDampen1 = New DevComponents.DotNetBar.Controls.Slider
Me.btnMin = New DevComponents.DotNetBar.ButtonX
Me.btnMax = New DevComponents.DotNetBar.ButtonX
Me.btnMinus20 = New DevComponents.DotNetBar.ButtonX
Me.btnPlus30 = New DevComponents.DotNetBar.ButtonX
Me.gcEnterLeave = New DevComponents.Instrumentation.GaugeControl
Me.tabEnterLeave = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel23 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.cbMarker = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbFrame = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX1 = New DevComponents.DotNetBar.LabelX
Me.cbBackground = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbRange = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbSection = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbNeedle = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.cbBar = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.gcUserRendering = New DevComponents.Instrumentation.GaugeControl
Me.tabUserRendering = New DevComponents.DotNetBar.SuperTabItem
Me.TabEvents = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel9 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.superTabControl3 = New DevComponents.DotNetBar.SuperTabControl
Me.superTabControlPanel13 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX37 = New DevComponents.DotNetBar.LabelX
Me.labelX36 = New DevComponents.DotNetBar.LabelX
Me.labelX5 = New DevComponents.DotNetBar.LabelX
Me.gcLinear1 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab1 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel14 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX10 = New DevComponents.DotNetBar.LabelX
Me.gcLinear8 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab8 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel19 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX25 = New DevComponents.DotNetBar.LabelX
Me.gcLinear7 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab7 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel20 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.cbSliderAngle = New DevComponents.DotNetBar.Controls.Slider
Me.cbFillMode = New DevComponents.DotNetBar.Controls.ComboBoxEx
Me.AutoComboItem = New DevComponents.Editors.ComboItem
Me.Angle = New DevComponents.Editors.ComboItem
Me.Center = New DevComponents.Editors.ComboItem
Me.HCenter = New DevComponents.Editors.ComboItem
Me.None = New DevComponents.Editors.ComboItem
Me.VCenter = New DevComponents.Editors.ComboItem
Me.StartToEnd = New DevComponents.Editors.ComboItem
Me.colorPickerButton2 = New DevComponents.DotNetBar.ColorPickerButton
Me.colorPickerButton1 = New DevComponents.DotNetBar.ColorPickerButton
Me.labelX12 = New DevComponents.DotNetBar.LabelX
Me.gcLinear6 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab6 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel7 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX38 = New DevComponents.DotNetBar.LabelX
Me.cbSetSnap = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX11 = New DevComponents.DotNetBar.LabelX
Me.rbFlask = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.rbBulb = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX9 = New DevComponents.DotNetBar.LabelX
Me.gcLinear5 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab5 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel10 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX24 = New DevComponents.DotNetBar.LabelX
Me.cbUnderTickmarks = New DevComponents.DotNetBar.Controls.CheckBoxX
Me.labelX8 = New DevComponents.DotNetBar.LabelX
Me.gcLinear4 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab4 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel11 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX7 = New DevComponents.DotNetBar.LabelX
Me.gcLinear3 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab3 = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel12 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX39 = New DevComponents.DotNetBar.LabelX
Me.labelX32 = New DevComponents.DotNetBar.LabelX
Me.labelX6 = New DevComponents.DotNetBar.LabelX
Me.gcLinear2 = New DevComponents.Instrumentation.GaugeControl
Me.linearTab2 = New DevComponents.DotNetBar.SuperTabItem
Me.LTabSamples = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel27 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.labelX41 = New DevComponents.DotNetBar.LabelX
Me.labelX40 = New DevComponents.DotNetBar.LabelX
Me.gcMixedScale = New DevComponents.Instrumentation.GaugeControl
Me.TabMixedScale = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel28 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.superTabControl5 = New DevComponents.DotNetBar.SuperTabControl
Me.superTabControlPanel29 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.textBox44 = New System.Windows.Forms.TextBox
Me.label45 = New System.Windows.Forms.Label
Me.textBox43 = New System.Windows.Forms.TextBox
Me.label44 = New System.Windows.Forms.Label
Me.textBox42 = New System.Windows.Forms.TextBox
Me.label43 = New System.Windows.Forms.Label
Me.label23 = New System.Windows.Forms.Label
Me.textBox36 = New System.Windows.Forms.TextBox
Me.textBox30 = New System.Windows.Forms.TextBox
Me.label37 = New System.Windows.Forms.Label
Me.textBox28 = New System.Windows.Forms.TextBox
Me.label29 = New System.Windows.Forms.Label
Me.textBox26 = New System.Windows.Forms.TextBox
Me.label31 = New System.Windows.Forms.Label
Me.gcIndicatorElements = New DevComponents.Instrumentation.GaugeControl
Me.IndMechanical = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel31 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.textBox48 = New System.Windows.Forms.TextBox
Me.label48 = New System.Windows.Forms.Label
Me.label41 = New System.Windows.Forms.Label
Me.textBox40 = New System.Windows.Forms.TextBox
Me.textBox39 = New System.Windows.Forms.TextBox
Me.textBox38 = New System.Windows.Forms.TextBox
Me.textBox37 = New System.Windows.Forms.TextBox
Me.label40 = New System.Windows.Forms.Label
Me.label39 = New System.Windows.Forms.Label
Me.label38 = New System.Windows.Forms.Label
Me.gaugeControl2 = New DevComponents.Instrumentation.GaugeControl
Me.IndTab7Seg = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel32 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.label47 = New System.Windows.Forms.Label
Me.label46 = New System.Windows.Forms.Label
Me.textBox47 = New System.Windows.Forms.TextBox
Me.textBox46 = New System.Windows.Forms.TextBox
Me.textBox45 = New System.Windows.Forms.TextBox
Me.gaugeControl3 = New DevComponents.Instrumentation.GaugeControl
Me.IndTabState = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel30 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.label42 = New System.Windows.Forms.Label
Me.textBox41 = New System.Windows.Forms.TextBox
Me.gaugeControl1 = New DevComponents.Instrumentation.GaugeControl
Me.IndTab16Seg = New DevComponents.DotNetBar.SuperTabItem
Me.ITabElements = New DevComponents.DotNetBar.SuperTabItem
Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel
Me.textBox20 = New System.Windows.Forms.TextBox
Me.textBox17 = New System.Windows.Forms.TextBox
Me.label21 = New System.Windows.Forms.Label
Me.label18 = New System.Windows.Forms.Label
Me.textBox33 = New System.Windows.Forms.TextBox
Me.label34 = New System.Windows.Forms.Label
Me.textBox32 = New System.Windows.Forms.TextBox
Me.label33 = New System.Windows.Forms.Label
Me.textBox31 = New System.Windows.Forms.TextBox
Me.label32 = New System.Windows.Forms.Label
Me.textBox29 = New System.Windows.Forms.TextBox
Me.label30 = New System.Windows.Forms.Label
Me.textBox23 = New System.Windows.Forms.TextBox
Me.label24 = New System.Windows.Forms.Label
Me.label19 = New System.Windows.Forms.Label
Me.textBox18 = New System.Windows.Forms.TextBox
Me.textBox34 = New System.Windows.Forms.TextBox
Me.label35 = New System.Windows.Forms.Label
Me.textBox27 = New System.Windows.Forms.TextBox
Me.label28 = New System.Windows.Forms.Label
Me.textBox22 = New System.Windows.Forms.TextBox
Me.label27 = New System.Windows.Forms.Label
Me.textBox25 = New System.Windows.Forms.TextBox
Me.label26 = New System.Windows.Forms.Label
Me.textBox24 = New System.Windows.Forms.TextBox
Me.label25 = New System.Windows.Forms.Label
Me.textBox21 = New System.Windows.Forms.TextBox
Me.label22 = New System.Windows.Forms.Label
Me.textBox19 = New System.Windows.Forms.TextBox
Me.label20 = New System.Windows.Forms.Label
Me.gcLinearElements = New DevComponents.Instrumentation.GaugeControl
Me.LTabElements = New DevComponents.DotNetBar.SuperTabItem
Me.galleryContainer1 = New DevComponents.DotNetBar.GalleryContainer
Me.galleryContainer2 = New DevComponents.DotNetBar.GalleryContainer
Me.galleryContainer3 = New DevComponents.DotNetBar.GalleryContainer
CType(Me.superTabControl1,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControl1.SuspendLayout
Me.superTabControlPanel3.SuspendLayout
CType(Me.superTabControl2,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControl2.SuspendLayout
Me.superTabControlPanel17.SuspendLayout
CType(Me.gcCircular8a,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.gcCircular8b,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel15.SuspendLayout
CType(Me.gcCircular7c,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.gcCircular7b,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.gcCircular7a,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel16.SuspendLayout
CType(Me.gcCircular6,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel5.SuspendLayout
CType(Me.gcCircular5,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel18.SuspendLayout
CType(Me.gcCircular1,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel8.SuspendLayout
CType(Me.gcCircular2,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel4.SuspendLayout
CType(Me.gcCircular4,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel6.SuspendLayout
CType(Me.gcCircular3,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel1.SuspendLayout
CType(Me.gcCircularElements,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel22.SuspendLayout
CType(Me.superTabControl4,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControl4.SuspendLayout
Me.superTabControlPanel21.SuspendLayout
CType(Me.gcPointerChange,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel26.SuspendLayout
CType(Me.gcScaleLimits,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel25.SuspendLayout
CType(Me.gcHitTesting,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel24.SuspendLayout
CType(Me.gcEnterLeave,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel23.SuspendLayout
CType(Me.gcUserRendering,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel9.SuspendLayout
CType(Me.superTabControl3,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControl3.SuspendLayout
Me.superTabControlPanel13.SuspendLayout
CType(Me.gcLinear1,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel14.SuspendLayout
CType(Me.gcLinear8,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel19.SuspendLayout
CType(Me.gcLinear7,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel20.SuspendLayout
CType(Me.gcLinear6,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel7.SuspendLayout
CType(Me.gcLinear5,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel10.SuspendLayout
CType(Me.gcLinear4,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel11.SuspendLayout
CType(Me.gcLinear3,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel12.SuspendLayout
CType(Me.gcLinear2,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel27.SuspendLayout
CType(Me.gcMixedScale,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel28.SuspendLayout
CType(Me.superTabControl5,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControl5.SuspendLayout
Me.superTabControlPanel29.SuspendLayout
CType(Me.gcIndicatorElements,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel31.SuspendLayout
CType(Me.gaugeControl2,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel32.SuspendLayout
CType(Me.gaugeControl3,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel30.SuspendLayout
CType(Me.gaugeControl1,System.ComponentModel.ISupportInitialize).BeginInit
Me.superTabControlPanel2.SuspendLayout
CType(Me.gcLinearElements,System.ComponentModel.ISupportInitialize).BeginInit
Me.SuspendLayout
'
'superTabControl1
'
Me.superTabControl1.AntiAlias = true
'
'
'
'
'
'
Me.superTabControl1.ControlBox.CloseBox.Name = ""
'
'
'
Me.superTabControl1.ControlBox.MenuBox.Name = ""
Me.superTabControl1.ControlBox.Name = ""
Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
Me.superTabControl1.Controls.Add(Me.superTabControlPanel22)
Me.superTabControl1.Controls.Add(Me.superTabControlPanel9)
Me.superTabControl1.Controls.Add(Me.superTabControlPanel3)
Me.superTabControl1.Controls.Add(Me.superTabControlPanel28)
Me.superTabControl1.Controls.Add(Me.superTabControlPanel27)
Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
Me.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControl1.Location = New System.Drawing.Point(0, 0)
Me.superTabControl1.Name = "superTabControl1"
Me.superTabControl1.ReorderTabsEnabled = true
Me.superTabControl1.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
Me.superTabControl1.SelectedTabIndex = 0
Me.superTabControl1.Size = New System.Drawing.Size(820, 638)
Me.superTabControl1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.superTabControl1.TabIndex = 0
Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CTabElements, Me.LTabElements, Me.ITabElements, Me.CTabSamples, Me.LTabSamples, Me.TabMixedScale, Me.TabEvents})
Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
Me.superTabControl1.Text = "superTabControl1"
'
'superTabControlPanel3
'
Me.superTabControlPanel3.Controls.Add(Me.superTabControl2)
Me.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel3.Location = New System.Drawing.Point(0, 35)
Me.superTabControlPanel3.Name = "superTabControlPanel3"
Me.superTabControlPanel3.Size = New System.Drawing.Size(820, 603)
Me.superTabControlPanel3.TabIndex = 0
Me.superTabControlPanel3.TabItem = Me.CTabSamples
'
'superTabControl2
'
Me.superTabControl2.AntiAlias = true
'
'
'
'
'
'
Me.superTabControl2.ControlBox.CloseBox.Name = ""
'
'
'
Me.superTabControl2.ControlBox.MenuBox.Name = ""
Me.superTabControl2.ControlBox.Name = ""
Me.superTabControl2.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl2.ControlBox.MenuBox, Me.superTabControl2.ControlBox.CloseBox})
Me.superTabControl2.Controls.Add(Me.superTabControlPanel17)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel15)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel16)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel5)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel4)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel6)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel8)
Me.superTabControl2.Controls.Add(Me.superTabControlPanel18)
Me.superTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControl2.FixedTabSize = New System.Drawing.Size(30, 30)
Me.superTabControl2.Location = New System.Drawing.Point(0, 0)
Me.superTabControl2.Name = "superTabControl2"
Me.superTabControl2.ReorderTabsEnabled = true
Me.superTabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
Me.superTabControl2.SelectedTabIndex = 0
Me.superTabControl2.Size = New System.Drawing.Size(820, 603)
Me.superTabControl2.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
Me.superTabControl2.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.superTabControl2.TabIndex = 0
Me.superTabControl2.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.circularTab1, Me.circularTab2, Me.circularTab3, Me.circularTab4, Me.circularTab5, Me.circularTab6, Me.circularTab7, Me.circularTab8})
Me.superTabControl2.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.WinMediaPlayer12
Me.superTabControl2.Text = "superTabControl2"
Me.superTabControl2.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
'
'superTabControlPanel17
'
Me.superTabControlPanel17.Controls.Add(Me.gcCircular8a)
Me.superTabControlPanel17.Controls.Add(Me.gcCircular8b)
Me.superTabControlPanel17.Controls.Add(Me.labelX16)
Me.superTabControlPanel17.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel17.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel17.Name = "superTabControlPanel17"
Me.superTabControlPanel17.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel17.TabIndex = 0
Me.superTabControlPanel17.TabItem = Me.circularTab8
'
'gcCircular8a
'
Me.gcCircular8a.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.gcCircular8a.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale5.MaxPin.EndOffset = 0.016!
GaugeCircularScale5.MaxPin.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeCircularScale5.MaxPin.FillColor.BorderWidth = 1
GaugeCircularScale5.MaxPin.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugeCircularScale5.MaxPin.FillColor.Color2 = System.Drawing.Color.Purple
GaugeCircularScale5.MaxPin.Length = 0.12!
GaugeCircularScale5.MaxPin.Name = "MaxPin"
GaugeCircularScale5.MaxPin.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Star5
GaugeCircularScale5.MaxPin.Width = 0.12!
GaugeCircularScale5.MaxValue = 80
GaugeCircularScale5.MinPin.EndOffset = 0.016!
GaugeCircularScale5.MinPin.Name = "MinPin"
GaugeCircularScale5.MinValue = -40
GaugeCircularScale5.Name = "Scale1"
GaugeCircularScale5.PivotPoint = CType(resources.GetObject("GaugeCircularScale5.PivotPoint"),System.Drawing.PointF)
GaugePointer29.AllowUserChange = true
GaugePointer29.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer29.CapFillColor.BorderWidth = 1
GaugePointer29.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer29.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer29.CapImage = CType(resources.GetObject("GaugePointer29.CapImage"),System.Drawing.Image)
GaugePointer29.CapOnTop = false
GaugePointer29.CapWidth = 0.789!
GaugePointer29.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer29.FillColor.BorderWidth = 1
GaugePointer29.FillColor.Color1 = System.Drawing.Color.White
GaugePointer29.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer29.Length = 0.689!
GaugePointer29.Name = "Pointer1"
GaugePointer29.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer29.Value = 10
GaugeCircularScale5.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer29})
GaugeRange13.EndValue = 70
GaugeRange13.EndWidth = 0.068!
GaugeRange13.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange13.FillColor.BorderWidth = 1
GaugeRange13.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange13.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange13.Name = "Range1"
GaugeRange13.ScaleOffset = 0.28!
GaugeRange13.StartValue = 20
GaugeCircularScale5.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange13})
GaugeCircularScale5.Reversed = true
GaugeSection22.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection22.Name = "Section1"
GaugeCircularScale5.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection22})
GaugeCircularScale5.Width = 0.039!
Me.gcCircular8a.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale5})
GradientFillColor38.Color1 = System.Drawing.Color.LightGray
GradientFillColor38.Color2 = System.Drawing.Color.DimGray
GradientFillColor38.GradientAngle = 45
Me.gcCircular8a.Frame.BackColor = GradientFillColor38
Me.gcCircular8a.Frame.BackSigmaFocus = 0.563!
GradientFillColor39.BorderColor = System.Drawing.Color.DarkGray
GradientFillColor39.BorderWidth = 1
GradientFillColor39.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor39.Color2 = System.Drawing.Color.DimGray
GradientFillColor39.GradientAngle = 45
Me.gcCircular8a.Frame.FrameColor = GradientFillColor39
Me.gcCircular8a.Frame.Image = CType(resources.GetObject("gcCircular8a.Frame.Image"),System.Drawing.Image)
Me.gcCircular8a.Frame.InnerBevel = 0.008!
Me.gcCircular8a.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
Me.gcCircular8a.Location = New System.Drawing.Point(74, 58)
Me.gcCircular8a.Name = "gcCircular8a"
Me.gcCircular8a.Size = New System.Drawing.Size(297, 300)
Me.gcCircular8a.TabIndex = 12
'
'gcCircular8b
'
Me.gcCircular8b.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale6.Labels.Layout.ForeColor = System.Drawing.Color.White
GaugeCircularScale6.Labels.Layout.RotateLabel = false
GaugeCircularScale6.MaxPin.Name = "MaxPin"
GaugeCircularScale6.MinPin.Name = "MinPin"
GaugeCircularScale6.Name = "Scale1"
GaugeCircularScale6.PivotPoint = CType(resources.GetObject("GaugeCircularScale6.PivotPoint"),System.Drawing.PointF)
GaugePointer30.AllowUserChange = true
GaugePointer30.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer30.CapFillColor.BorderWidth = 1
GaugePointer30.CapFillColor.Color1 = System.Drawing.Color.White
GaugePointer30.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer30.CapImage = CType(resources.GetObject("GaugePointer30.CapImage"),System.Drawing.Image)
GaugePointer30.CapInnerBevel = 0.25!
GaugePointer30.CapOuterBevel = 0.108!
GaugePointer30.CapWidth = 0.326!
GaugePointer30.FillColor.BorderColor = System.Drawing.Color.Goldenrod
GaugePointer30.FillColor.BorderWidth = 2
GaugePointer30.FillColor.Color1 = System.Drawing.Color.Gold
GaugePointer30.FillColor.Color2 = System.Drawing.Color.Yellow
GaugePointer30.Length = 0.205!
GaugePointer30.Name = "Pointer1"
GaugePointer30.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style3
GaugePointer30.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer30.ScaleOffset = -0.028!
GaugePointer30.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer30.Width = 0.033!
GaugeCircularScale6.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer30})
GaugeSection23.FillColor.Color1 = System.Drawing.Color.PaleTurquoise
GaugeSection23.Name = "Section1"
GaugeCircularScale6.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection23})
GaugeCircularScale6.Width = 0.027!
Me.gcCircular8b.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale6})
Me.gcCircular8b.Frame.Image = CType(resources.GetObject("gcCircular8b.Frame.Image"),System.Drawing.Image)
Me.gcCircular8b.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
GaugeText13.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText13.BackColor.GradientAngle = 45
GaugeText13.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
GaugeText13.ForeColor = System.Drawing.Color.LightCyan
GaugeText13.Location = CType(resources.GetObject("GaugeText13.Location"),System.Drawing.PointF)
GaugeText13.Name = "Dorothy"
GaugeText13.Size = New System.Drawing.SizeF(0.2413793!, 0.2413793!)
GaugeText13.Text = "Dorothy Gale was here"
GaugeText13.Tooltip = "Dorothy, Baby!"
Me.gcCircular8b.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText13})
Me.gcCircular8b.Location = New System.Drawing.Point(415, 245)
Me.gcCircular8b.Name = "gcCircular8b"
Me.gcCircular8b.Size = New System.Drawing.Size(300, 300)
Me.gcCircular8b.TabIndex = 11
'
'labelX16
'
Me.labelX16.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX16.BackgroundStyle.Class = ""
Me.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX16.Location = New System.Drawing.Point(427, 40)
Me.labelX16.Name = "labelX16"
Me.labelX16.Size = New System.Drawing.Size(307, 146)
Me.labelX16.TabIndex = 10
Me.labelX16.Text = "There are 3 pre-defined frame layouts (Circular, Rectangular, and RoundRectangula"& _ 
    "r).  You can also either draw your own frame or set a predefined image for the f"& _ 
    "rame."
Me.labelX16.WordWrap = true
'
'circularTab8
'
Me.circularTab8.AttachedControl = Me.superTabControlPanel17
Me.circularTab8.GlobalItem = false
Me.circularTab8.Name = "circularTab8"
Me.circularTab8.Text = "8"
'
'superTabControlPanel15
'
Me.superTabControlPanel15.Controls.Add(Me.gcCircular7c)
Me.superTabControlPanel15.Controls.Add(Me.gcCircular7b)
Me.superTabControlPanel15.Controls.Add(Me.gcCircular7a)
Me.superTabControlPanel15.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel15.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel15.Name = "superTabControlPanel15"
Me.superTabControlPanel15.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel15.TabIndex = 0
Me.superTabControlPanel15.TabItem = Me.circularTab7
'
'gcCircular7c
'
GaugeCircularScale7.Labels.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.5!)
GaugeCircularScale7.Labels.Layout.ScaleOffset = 0.016!
GaugeCircularScale7.MajorTickMarks.Interval = 50
GaugeCircularScale7.MajorTickMarks.Layout.Length = 0.063!
GaugeCircularScale7.MajorTickMarks.Layout.Width = 0.033!
GaugeCircularScale7.MaxPin.EndOffset = 0.01!
GaugeCircularScale7.MaxPin.Length = 0.026!
GaugeCircularScale7.MaxPin.Name = "MaxPin"
GaugeCircularScale7.MaxPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale7.MaxPin.ScaleOffset = 0.06!
GaugeCircularScale7.MaxPin.Width = 0.026!
GaugeCircularScale7.MinorTickMarks.Interval = 10
GradientFillColor40.BorderColor = System.Drawing.Color.DimGray
GradientFillColor40.BorderWidth = 1
GradientFillColor40.Color1 = System.Drawing.Color.LightYellow
GaugeCircularScale7.MinorTickMarks.Layout.FillColor = GradientFillColor40
GaugeCircularScale7.MinorTickMarks.Layout.Length = 0.042!
GaugeCircularScale7.MinorTickMarks.Layout.Width = 0.013!
GaugeCircularScale7.MinPin.EndOffset = 0.01!
GaugeCircularScale7.MinPin.Length = 0.026!
GaugeCircularScale7.MinPin.Name = "MinPin"
GaugeCircularScale7.MinPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale7.MinPin.ScaleOffset = 0.06!
GaugeCircularScale7.MinPin.Width = 0.026!
GaugeCircularScale7.Name = "Scale1"
GaugeCircularScale7.PivotPoint = CType(resources.GetObject("GaugeCircularScale7.PivotPoint"),System.Drawing.PointF)
GaugePointer31.AllowUserChange = true
GaugePointer31.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer31.CapFillColor.BorderWidth = 1
GaugePointer31.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer31.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer31.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer31.FillColor.BorderWidth = 1
GaugePointer31.FillColor.Color1 = System.Drawing.Color.Black
GaugePointer31.Name = "Pointer1"
GaugePointer31.ScaleOffset = -0.057!
GaugePointer31.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer31.Value = 25
GaugePointer31.Width = 0.032!
GaugeCircularScale7.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer31})
GaugeCircularScale7.Radius = 2.5!
GaugeRange14.EndValue = 100
GaugeRange14.EndWidth = 0.08!
GaugeRange14.FillColor.BorderColor = System.Drawing.Color.Gray
GaugeRange14.FillColor.BorderWidth = 1
GaugeRange14.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange14.FillColor.Color2 = System.Drawing.Color.Yellow
GaugeRange14.Name = "Range1"
GaugeRange14.ScaleOffset = 0.033!
GaugeRange14.StartValue = 0
GaugeRange14.StartWidth = 0.08!
GaugeRange14.Tooltip = "Volts (AC)"
GaugeCircularScale7.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange14})
GaugeCircularScale7.Reversed = true
GaugeSection24.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection24.Name = "Section1"
GaugeCircularScale7.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection24})
GaugeCircularScale7.StartAngle = 330!
GaugeCircularScale7.SweepAngle = 60!
GaugeCircularScale7.Width = 0.011!
Me.gcCircular7c.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale7})
Me.gcCircular7c.Frame.AddGlassEffect = true
Me.gcCircular7c.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
Me.gcCircular7c.Location = New System.Drawing.Point(427, 170)
Me.gcCircular7c.Name = "gcCircular7c"
Me.gcCircular7c.Size = New System.Drawing.Size(126, 401)
Me.gcCircular7c.TabIndex = 6
'
'gcCircular7b
'
GaugeCircularScale8.Labels.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.5!)
GaugeCircularScale8.Labels.Layout.ScaleOffset = 0.016!
GaugeCircularScale8.MajorTickMarks.Interval = 50
GaugeCircularScale8.MajorTickMarks.Layout.Length = 0.063!
GaugeCircularScale8.MajorTickMarks.Layout.Width = 0.033!
GaugeCircularScale8.MaxPin.EndOffset = 0.01!
GaugeCircularScale8.MaxPin.Length = 0.026!
GaugeCircularScale8.MaxPin.Name = "MaxPin"
GaugeCircularScale8.MaxPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale8.MaxPin.ScaleOffset = 0.06!
GaugeCircularScale8.MaxPin.Width = 0.026!
GaugeCircularScale8.MinorTickMarks.Interval = 10
GradientFillColor41.BorderColor = System.Drawing.Color.DimGray
GradientFillColor41.BorderWidth = 1
GradientFillColor41.Color1 = System.Drawing.Color.LightYellow
GaugeCircularScale8.MinorTickMarks.Layout.FillColor = GradientFillColor41
GaugeCircularScale8.MinorTickMarks.Layout.Length = 0.042!
GaugeCircularScale8.MinorTickMarks.Layout.Width = 0.013!
GaugeCircularScale8.MinPin.EndOffset = 0.01!
GaugeCircularScale8.MinPin.Length = 0.026!
GaugeCircularScale8.MinPin.Name = "MinPin"
GaugeCircularScale8.MinPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale8.MinPin.ScaleOffset = 0.06!
GaugeCircularScale8.MinPin.Width = 0.026!
GaugeCircularScale8.Name = "Scale1"
GaugeCircularScale8.PivotPoint = CType(resources.GetObject("GaugeCircularScale8.PivotPoint"),System.Drawing.PointF)
GaugePointer32.AllowUserChange = true
GaugePointer32.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer32.CapFillColor.BorderWidth = 1
GaugePointer32.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer32.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer32.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer32.FillColor.BorderWidth = 1
GaugePointer32.FillColor.Color1 = System.Drawing.Color.Black
GaugePointer32.Name = "Pointer1"
GaugePointer32.ScaleOffset = -0.057!
GaugePointer32.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer32.Value = 25
GaugePointer32.Width = 0.032!
GaugeCircularScale8.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer32})
GaugeCircularScale8.Radius = 2.5!
GaugeRange15.EndValue = 100
GaugeRange15.EndWidth = 0.08!
GaugeRange15.FillColor.BorderColor = System.Drawing.Color.Gray
GaugeRange15.FillColor.BorderWidth = 1
GaugeRange15.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange15.FillColor.Color2 = System.Drawing.Color.Yellow
GaugeRange15.Name = "Range1"
GaugeRange15.ScaleOffset = 0.033!
GaugeRange15.StartValue = 0
GaugeRange15.StartWidth = 0.08!
GaugeRange15.Tooltip = "Volts (AC)"
GaugeCircularScale8.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange15})
GaugeSection25.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection25.Name = "Section1"
GaugeCircularScale8.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection25})
GaugeCircularScale8.StartAngle = 150!
GaugeCircularScale8.SweepAngle = 60!
GaugeCircularScale8.Width = 0.011!
Me.gcCircular7b.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale8})
Me.gcCircular7b.Frame.AddGlassEffect = true
Me.gcCircular7b.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
Me.gcCircular7b.Location = New System.Drawing.Point(235, 170)
Me.gcCircular7b.Name = "gcCircular7b"
Me.gcCircular7b.Size = New System.Drawing.Size(126, 401)
Me.gcCircular7b.TabIndex = 5
'
'gcCircular7a
'
GaugeCircularScale9.Labels.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.5!)
GaugeCircularScale9.Labels.Layout.ScaleOffset = 0.016!
GaugeCircularScale9.MajorTickMarks.Interval = 50
GaugeCircularScale9.MajorTickMarks.Layout.Length = 0.063!
GaugeCircularScale9.MajorTickMarks.Layout.Width = 0.033!
GaugeCircularScale9.MaxPin.EndOffset = 0.01!
GaugeCircularScale9.MaxPin.Length = 0.026!
GaugeCircularScale9.MaxPin.Name = "MaxPin"
GaugeCircularScale9.MaxPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale9.MaxPin.ScaleOffset = 0.06!
GaugeCircularScale9.MaxPin.Width = 0.026!
GaugeCircularScale9.MinorTickMarks.Interval = 10
GradientFillColor42.BorderColor = System.Drawing.Color.DimGray
GradientFillColor42.BorderWidth = 1
GradientFillColor42.Color1 = System.Drawing.Color.LightYellow
GaugeCircularScale9.MinorTickMarks.Layout.FillColor = GradientFillColor42
GaugeCircularScale9.MinorTickMarks.Layout.Length = 0.042!
GaugeCircularScale9.MinorTickMarks.Layout.Width = 0.013!
GaugeCircularScale9.MinPin.EndOffset = 0.01!
GaugeCircularScale9.MinPin.Length = 0.026!
GaugeCircularScale9.MinPin.Name = "MinPin"
GaugeCircularScale9.MinPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale9.MinPin.ScaleOffset = 0.06!
GaugeCircularScale9.MinPin.Width = 0.026!
GaugeCircularScale9.Name = "Scale1"
GaugeCircularScale9.PivotPoint = CType(resources.GetObject("GaugeCircularScale9.PivotPoint"),System.Drawing.PointF)
GaugePointer33.AllowUserChange = true
GaugePointer33.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer33.CapFillColor.BorderWidth = 1
GaugePointer33.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer33.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer33.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer33.FillColor.BorderWidth = 1
GaugePointer33.FillColor.Color1 = System.Drawing.Color.Black
GaugePointer33.Name = "Pointer1"
GaugePointer33.ScaleOffset = -0.057!
GaugePointer33.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer33.Value = 25
GaugePointer33.Width = 0.032!
GaugeCircularScale9.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer33})
GaugeCircularScale9.Radius = 2.5!
GaugeRange16.EndValue = 100
GaugeRange16.EndWidth = 0.08!
GaugeRange16.FillColor.BorderColor = System.Drawing.Color.Gray
GaugeRange16.FillColor.BorderWidth = 1
GaugeRange16.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange16.FillColor.Color2 = System.Drawing.Color.Yellow
GaugeRange16.Name = "Range1"
GaugeRange16.ScaleOffset = 0.033!
GaugeRange16.StartValue = 0
GaugeRange16.StartWidth = 0.08!
GaugeRange16.Tooltip = "Volts (AC)"
GaugeCircularScale9.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange16})
GaugeSection26.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection26.Name = "Section1"
GaugeCircularScale9.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection26})
GaugeCircularScale9.StartAngle = 240.632!
GaugeCircularScale9.SweepAngle = 58.737!
GaugeCircularScale9.Width = 0.011!
Me.gcCircular7a.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale9})
Me.gcCircular7a.Frame.AddGlassEffect = true
Me.gcCircular7a.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
Me.gcCircular7a.Location = New System.Drawing.Point(194, 26)
Me.gcCircular7a.Name = "gcCircular7a"
Me.gcCircular7a.Size = New System.Drawing.Size(401, 126)
Me.gcCircular7a.TabIndex = 4
'
'circularTab7
'
Me.circularTab7.AttachedControl = Me.superTabControlPanel15
Me.circularTab7.GlobalItem = false
Me.circularTab7.Name = "circularTab7"
Me.circularTab7.Text = "7"
'
'superTabControlPanel16
'
Me.superTabControlPanel16.Controls.Add(Me.cbHonorMaxPin)
Me.superTabControlPanel16.Controls.Add(Me.labelX35)
Me.superTabControlPanel16.Controls.Add(Me.cbHonorMinPin)
Me.superTabControlPanel16.Controls.Add(Me.sliderMaxPin)
Me.superTabControlPanel16.Controls.Add(Me.labelX34)
Me.superTabControlPanel16.Controls.Add(Me.labelX23)
Me.superTabControlPanel16.Controls.Add(Me.cbRotateCap)
Me.superTabControlPanel16.Controls.Add(Me.gcCircular6)
Me.superTabControlPanel16.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel16.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel16.Name = "superTabControlPanel16"
Me.superTabControlPanel16.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel16.TabIndex = 0
Me.superTabControlPanel16.TabItem = Me.circularTab6
'
'cbHonorMaxPin
'
Me.cbHonorMaxPin.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbHonorMaxPin.BackgroundStyle.Class = ""
Me.cbHonorMaxPin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbHonorMaxPin.Checked = true
Me.cbHonorMaxPin.CheckState = System.Windows.Forms.CheckState.Checked
Me.cbHonorMaxPin.CheckValue = "Y"
Me.cbHonorMaxPin.Location = New System.Drawing.Point(614, 532)
Me.cbHonorMaxPin.Name = "cbHonorMaxPin"
Me.cbHonorMaxPin.Size = New System.Drawing.Size(103, 28)
Me.cbHonorMaxPin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbHonorMaxPin.TabIndex = 18
Me.cbHonorMaxPin.Text = "Honor MaxPin"
'
'labelX35
'
Me.labelX35.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX35.BackgroundStyle.Class = ""
Me.labelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX35.Location = New System.Drawing.Point(571, 453)
Me.labelX35.Name = "labelX35"
Me.labelX35.Size = New System.Drawing.Size(203, 44)
Me.labelX35.TabIndex = 17
Me.labelX35.Text = "Each pointer can be set to ignore or honor the Scale End Pins."
Me.labelX35.WordWrap = true
'
'cbHonorMinPin
'
Me.cbHonorMinPin.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbHonorMinPin.BackgroundStyle.Class = ""
Me.cbHonorMinPin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbHonorMinPin.Checked = true
Me.cbHonorMinPin.CheckState = System.Windows.Forms.CheckState.Checked
Me.cbHonorMinPin.CheckValue = "Y"
Me.cbHonorMinPin.Location = New System.Drawing.Point(614, 503)
Me.cbHonorMinPin.Name = "cbHonorMinPin"
Me.cbHonorMinPin.Size = New System.Drawing.Size(109, 28)
Me.cbHonorMinPin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbHonorMinPin.TabIndex = 16
Me.cbHonorMinPin.Text = "Honor MinPin"
'
'sliderMaxPin
'
Me.sliderMaxPin.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.sliderMaxPin.BackgroundStyle.Class = ""
Me.sliderMaxPin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.sliderMaxPin.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Bottom
Me.sliderMaxPin.LabelWidth = 68
Me.sliderMaxPin.Location = New System.Drawing.Point(587, 349)
Me.sliderMaxPin.Maximum = 300
Me.sliderMaxPin.Minimum = -300
Me.sliderMaxPin.Name = "sliderMaxPin"
Me.sliderMaxPin.Size = New System.Drawing.Size(166, 41)
Me.sliderMaxPin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.sliderMaxPin.TabIndex = 15
Me.sliderMaxPin.Text = "MaxPin EndOffset"
Me.sliderMaxPin.Value = 0
'
'labelX34
'
Me.labelX34.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX34.BackgroundStyle.Class = ""
Me.labelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX34.Location = New System.Drawing.Point(567, 235)
Me.labelX34.Name = "labelX34"
Me.labelX34.Size = New System.Drawing.Size(203, 105)
Me.labelX34.TabIndex = 14
Me.labelX34.Text = "Note the Minumum and Maximum Pin images at the bottom of the scale. These 'off sc"& _ 
    "ale' points can be fully configured (image, position, size, visibility, etc)."
Me.labelX34.WordWrap = true
'
'labelX23
'
Me.labelX23.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX23.BackgroundStyle.Class = ""
Me.labelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX23.Location = New System.Drawing.Point(571, 81)
Me.labelX23.Name = "labelX23"
Me.labelX23.Size = New System.Drawing.Size(203, 72)
Me.labelX23.TabIndex = 13
Me.labelX23.Text = "The needle and needle cap are fully configurable. You can even specify whether th"& _ 
    "e cap rotates with the needle or not."
Me.labelX23.WordWrap = true
'
'cbRotateCap
'
Me.cbRotateCap.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbRotateCap.BackgroundStyle.Class = ""
Me.cbRotateCap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbRotateCap.Location = New System.Drawing.Point(587, 160)
Me.cbRotateCap.Name = "cbRotateCap"
Me.cbRotateCap.Size = New System.Drawing.Size(175, 28)
Me.cbRotateCap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbRotateCap.TabIndex = 3
Me.cbRotateCap.Text = "Rotate Cap Image (Lady Bug)"
'
'gcCircular6
'
Me.gcCircular6.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale10.MaxPin.EndOffset = 0.016!
GaugeCircularScale10.MaxPin.Image = CType(resources.GetObject("resource.Image"),System.Drawing.Image)
GaugeCircularScale10.MaxPin.Length = 0.13!
GaugeCircularScale10.MaxPin.Name = "MaxPin"
GaugeCircularScale10.MaxPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale10.MaxPin.ScaleOffset = -0.076!
GaugeCircularScale10.MaxPin.Width = 0.13!
GaugeCircularScale10.MinPin.Image = CType(resources.GetObject("resource.Image1"),System.Drawing.Image)
GaugeCircularScale10.MinPin.Length = 0.13!
GaugeCircularScale10.MinPin.Name = "MinPin"
GaugeCircularScale10.MinPin.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCircularScale10.MinPin.ScaleOffset = -0.076!
GaugeCircularScale10.MinPin.Width = 0.13!
GaugeCircularScale10.Name = "Scale1"
GaugePointer34.AllowUserChange = true
GaugePointer34.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer34.CapFillColor.BorderWidth = 1
GaugePointer34.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer34.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer34.CapImage = CType(resources.GetObject("GaugePointer34.CapImage"),System.Drawing.Image)
GaugePointer34.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer34.FillColor.BorderWidth = 1
GaugePointer34.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer34.FillColor.Color2 = System.Drawing.Color.DarkGoldenrod
GaugePointer34.Length = 0.2!
GaugePointer34.Name = "Needle"
GaugePointer34.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer34.Tooltip = "Yellow Bug Needle."
GaugePointer34.Value = 45
GaugePointer34.Width = 0.35!
GaugePointer35.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer35.CapFillColor.BorderWidth = 1
GaugePointer35.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer35.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer35.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer35.FillColor.BorderWidth = 1
GaugePointer35.FillColor.Color1 = System.Drawing.Color.YellowGreen
GaugePointer35.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
GaugePointer35.Name = "Bar"
GaugePointer35.Origin = DevComponents.Instrumentation.PointerOrigin.Custom
GaugePointer35.OriginInterval = 60
GaugePointer35.ScaleOffset = 0.101!
GaugePointer35.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer35.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer35.ThermoBackColor.BorderWidth = 1
GaugePointer35.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer35.UnderTickMarks = true
GaugePointer35.Value = 95
GaugePointer35.Width = 0.025!
GaugeCircularScale10.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer34, GaugePointer35})
GaugeCircularScale10.Radius = 0.353!
GaugeRange17.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange17.FillColor.BorderWidth = 1
GaugeRange17.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugeRange17.FillColor.Color2 = System.Drawing.Color.DarkOliveGreen
GaugeRange17.FillColor.GradientAngle = 45
GaugeRange17.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeRange17.Name = "Range1"
GaugeRange17.ScaleOffset = 0.28!
GaugeRange17.StartValue = 10
GaugeRange17.StartWidth = 0!
GaugeRange17.Tooltip = "Range1"
GaugeCircularScale10.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange17})
GaugeSection27.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection27.FillColor.Color2 = System.Drawing.Color.Green
GaugeSection27.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugeSection27.Name = "Section1"
GaugeCircularScale10.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection27})
GaugeCircularScale10.StartAngle = 108!
GaugeCircularScale10.SweepAngle = 314.526!
Me.gcCircular6.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale10})
Me.gcCircular6.Frame.AddGlassEffect = true
GradientFillColor43.Color1 = System.Drawing.Color.DarkOliveGreen
GradientFillColor43.Color2 = System.Drawing.Color.LightGoldenrodYellow
GradientFillColor43.GradientAngle = 45
Me.gcCircular6.Frame.BackColor = GradientFillColor43
GradientFillColor44.Color1 = System.Drawing.Color.DarkSeaGreen
GradientFillColor44.Color2 = System.Drawing.Color.Black
GradientFillColor44.GradientAngle = 45
Me.gcCircular6.Frame.FrameColor = GradientFillColor44
Me.gcCircular6.Frame.InnerBevel = 0.013!
Me.gcCircular6.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular
Me.gcCircular6.Location = New System.Drawing.Point(50, 51)
Me.gcCircular6.Name = "gcCircular6"
Me.gcCircular6.Size = New System.Drawing.Size(500, 500)
Me.gcCircular6.TabIndex = 2
'
'circularTab6
'
Me.circularTab6.AttachedControl = Me.superTabControlPanel16
Me.circularTab6.GlobalItem = false
Me.circularTab6.Name = "circularTab6"
Me.circularTab6.Text = "6"
'
'superTabControlPanel5
'
Me.superTabControlPanel5.Controls.Add(Me.sliderArc)
Me.superTabControlPanel5.Controls.Add(Me.rbRoundRect)
Me.superTabControlPanel5.Controls.Add(Me.rbRect)
Me.superTabControlPanel5.Controls.Add(Me.rbCircular)
Me.superTabControlPanel5.Controls.Add(Me.rbNone)
Me.superTabControlPanel5.Controls.Add(Me.labelX22)
Me.superTabControlPanel5.Controls.Add(Me.labelX21)
Me.superTabControlPanel5.Controls.Add(Me.gcCircular5)
Me.superTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel5.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel5.Name = "superTabControlPanel5"
Me.superTabControlPanel5.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel5.TabIndex = 0
Me.superTabControlPanel5.TabItem = Me.circularTab5
'
'sliderArc
'
Me.sliderArc.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.sliderArc.BackgroundStyle.Class = ""
Me.sliderArc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.sliderArc.Enabled = false
Me.sliderArc.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Bottom
Me.sliderArc.LabelWidth = 80
Me.sliderArc.Location = New System.Drawing.Point(574, 265)
Me.sliderArc.Name = "sliderArc"
Me.sliderArc.Size = New System.Drawing.Size(204, 36)
Me.sliderArc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.sliderArc.TabIndex = 18
Me.sliderArc.Text = "RoundRect Arc Size"
Me.sliderArc.Value = 10
'
'rbRoundRect
'
Me.rbRoundRect.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.rbRoundRect.BackgroundStyle.Class = ""
Me.rbRoundRect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.rbRoundRect.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
Me.rbRoundRect.Location = New System.Drawing.Point(606, 220)
Me.rbRoundRect.Name = "rbRoundRect"
Me.rbRoundRect.Size = New System.Drawing.Size(117, 23)
Me.rbRoundRect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.rbRoundRect.TabIndex = 17
Me.rbRoundRect.Text = "Round Rectangular"
'
'rbRect
'
Me.rbRect.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.rbRect.BackgroundStyle.Class = ""
Me.rbRect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.rbRect.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
Me.rbRect.Location = New System.Drawing.Point(606, 196)
Me.rbRect.Name = "rbRect"
Me.rbRect.Size = New System.Drawing.Size(117, 23)
Me.rbRect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.rbRect.TabIndex = 16
Me.rbRect.Text = "Rectangular"
'
'rbCircular
'
Me.rbCircular.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.rbCircular.BackgroundStyle.Class = ""
Me.rbCircular.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.rbCircular.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
Me.rbCircular.Checked = true
Me.rbCircular.CheckState = System.Windows.Forms.CheckState.Checked
Me.rbCircular.CheckValue = "Y"
Me.rbCircular.Location = New System.Drawing.Point(606, 172)
Me.rbCircular.Name = "rbCircular"
Me.rbCircular.Size = New System.Drawing.Size(117, 23)
Me.rbCircular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.rbCircular.TabIndex = 15
Me.rbCircular.Text = "Circular"
'
'rbNone
'
Me.rbNone.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.rbNone.BackgroundStyle.Class = ""
Me.rbNone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.rbNone.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
Me.rbNone.Location = New System.Drawing.Point(606, 148)
Me.rbNone.Name = "rbNone"
Me.rbNone.Size = New System.Drawing.Size(117, 23)
Me.rbNone.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.rbNone.TabIndex = 14
Me.rbNone.Text = "None"
'
'labelX22
'
Me.labelX22.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX22.BackgroundStyle.Class = ""
Me.labelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX22.Location = New System.Drawing.Point(571, 93)
Me.labelX22.Name = "labelX22"
Me.labelX22.Size = New System.Drawing.Size(208, 45)
Me.labelX22.TabIndex = 13
Me.labelX22.Text = "(The frame style can also be user drawn - shown later in the sample)."
Me.labelX22.WordWrap = true
'
'labelX21
'
Me.labelX21.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX21.BackgroundStyle.Class = ""
Me.labelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX21.Location = New System.Drawing.Point(557, 44)
Me.labelX21.Name = "labelX21"
Me.labelX21.Size = New System.Drawing.Size(205, 55)
Me.labelX21.TabIndex = 12
Me.labelX21.Text = "Each gauge can be displayed with one of 4 predefined frame styles."
Me.labelX21.WordWrap = true
'
'gcCircular5
'
Me.gcCircular5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.gcCircular5.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale11.Labels.FormatString = ""
GaugeCircularScale11.Labels.Layout.RotateLabel = false
GaugeCircularScale11.MajorTickMarks.Layout.Length = 0.453!
GaugeCircularScale11.MajorTickMarks.Layout.ScaleOffset = -0.028!
GaugeCircularScale11.MaxPin.Name = "MaxPin"
GaugeCircularScale11.MinorTickMarks.Layout.Length = 0.121!
GaugeCircularScale11.MinPin.Name = "MinPin"
GaugeCircularScale11.Name = "Scale3"
GaugePointer36.AllowUserChange = true
GaugePointer36.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer36.CapFillColor.BorderWidth = 1
GaugePointer36.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer36.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer36.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer36.FillColor.BorderWidth = 1
GaugePointer36.FillColor.Color1 = System.Drawing.Color.White
GaugePointer36.FillColor.Color2 = System.Drawing.Color.Fuchsia
GaugePointer36.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer36.Length = 0.2!
GaugePointer36.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Diamond
GaugePointer36.Name = "Marker"
GaugePointer36.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer36.Tooltip = "Marker Tooltip"
GaugePointer36.UnderTickMarks = true
GaugePointer36.Value = 55
GaugePointer36.Width = 0.2!
GaugePointer37.AllowUserChange = true
GaugePointer37.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer37.CapFillColor.BorderWidth = 1
GaugePointer37.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer37.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer37.CapStyle = DevComponents.Instrumentation.NeedlePointerCapStyle.None
GaugePointer37.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer37.FillColor.BorderWidth = 1
GaugePointer37.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer37.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer37.Name = "Needle"
GaugePointer37.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer37.Tooltip = "Needle Tooltip"
GaugePointer37.Value = 15
GaugeCircularScale11.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer36, GaugePointer37})
GaugeCircularScale11.Radius = 0.176!
GaugeSection28.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection28.Name = "Section1"
GaugeSection28.Tooltip = "Lime Section1"
GaugeSection29.EndValue = 20
GaugeSection29.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection29.Name = "Section2"
GaugeSection29.StartValue = 0
GaugeSection29.Tooltip = "Lime Section2"
GaugeSection30.EndValue = 70
GaugeSection30.FillColor.Color1 = System.Drawing.Color.LightPink
GaugeSection30.Name = "Section4"
GaugeSection30.StartValue = 60
GaugeSection30.Tooltip = "Light Pink Section"
GaugeSection31.EndValue = 80
GaugeSection31.FillColor.Color1 = System.Drawing.Color.Aquamarine
GaugeSection31.Name = "Section3"
GaugeSection31.ScaleOffset = -0.164!
GaugeSection31.StartValue = 50
GaugeSection31.Tooltip = "Aquamarine Section"
GaugeSection31.Width = 0.106!
GaugeSection32.EndValue = 30
GaugeSection32.FillColor.Color1 = System.Drawing.Color.Yellow
GaugeSection32.Name = "Section5"
GaugeSection32.StartValue = 0
GaugeSection32.Tooltip = "Yellow Section"
GaugeSection32.Width = 0.106!
GaugeCircularScale11.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection28, GaugeSection29, GaugeSection30, GaugeSection31, GaugeSection32})
GaugeCircularScale11.StartAngle = 229.263!
GaugeCircularScale11.Width = 0.279!
GaugeCircularScale12.MaxPin.EndOffset = 0.025!
GaugeCircularScale12.MaxPin.Length = 0.1!
GaugeCircularScale12.MaxPin.Name = "MaxPin"
GaugeCircularScale12.MaxPin.Width = 0.1!
GaugeCircularScale12.MinPin.EndOffset = 0.025!
GaugeCircularScale12.MinPin.Length = 0.1!
GaugeCircularScale12.MinPin.Name = "MinPin"
GaugeCircularScale12.MinPin.Width = 0.1!
GaugeCircularScale12.Name = "Scale2"
GaugePointer38.AllowUserChange = true
GaugePointer38.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer38.CapFillColor.BorderWidth = 1
GaugePointer38.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer38.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer38.CapStyle = DevComponents.Instrumentation.NeedlePointerCapStyle.None
GaugePointer38.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer38.FillColor.BorderWidth = 1
GaugePointer38.FillColor.Color1 = System.Drawing.Color.PaleGoldenrod
GaugePointer38.FillColor.Color2 = System.Drawing.Color.Olive
GaugePointer38.Name = "Needle"
GaugePointer38.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer38.Tooltip = "Needle Tooltip"
GaugePointer38.Value = 10
GaugeCircularScale12.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer38})
GaugeCircularScale12.Radius = 0.282!
GaugeSection33.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection33.Name = "Section1"
GaugeSection33.Tooltip = "Lime Section"
GaugeSection34.EndValue = 50
GaugeSection34.FillColor.Color1 = System.Drawing.Color.Cyan
GaugeSection34.Name = "Section2"
GaugeSection34.StartValue = 30
GaugeSection34.Tooltip = "Cyan Section"
GaugeCircularScale12.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection33, GaugeSection34})
GaugeCustomLabel7.Layout.AdaptiveLabel = true
GaugeCustomLabel7.Layout.Font = New System.Drawing.Font("Baskerville Old Face", 12!, System.Drawing.FontStyle.Bold)
GaugeCustomLabel7.Layout.ForeColor = System.Drawing.Color.DarkRed
GaugeCustomLabel7.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCustomLabel7.Layout.ScaleOffset = 0.035!
GaugeCustomLabel7.Name = "Danger"
GaugeCustomLabel7.Text = "Wonka"
GradientFillColor45.BorderColor = System.Drawing.Color.DimGray
GradientFillColor45.BorderWidth = 1
GradientFillColor45.Color1 = System.Drawing.Color.Yellow
GaugeCustomLabel7.TickMark.Layout.FillColor = GradientFillColor45
GaugeCustomLabel7.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Triangle
GaugeCustomLabel7.TickMark.Layout.Width = 0.14!
GaugeCustomLabel7.Value = 50
GaugeCircularScale13.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel7})
GaugeCircularScale13.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale13.Labels.Layout.RotateLabel = false
GradientFillColor46.BorderColor = System.Drawing.Color.DimGray
GradientFillColor46.BorderWidth = 1
GradientFillColor46.Color1 = System.Drawing.Color.WhiteSmoke
GradientFillColor46.Color2 = System.Drawing.Color.DarkRed
GaugeCircularScale13.MajorTickMarks.Layout.FillColor = GradientFillColor46
GaugeCircularScale13.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugeCircularScale13.MajorTickMarks.Layout.Width = 0.14!
GaugeCircularScale13.MaxPin.EndOffset = 0.025!
GaugeCircularScale13.MaxPin.Length = 0.1!
GaugeCircularScale13.MaxPin.Name = "MaxPin"
GaugeCircularScale13.MaxPin.Width = 0.1!
GaugeCircularScale13.MinPin.EndOffset = 0.025!
GaugeCircularScale13.MinPin.Length = 0.1!
GaugeCircularScale13.MinPin.Name = "MinPin"
GaugeCircularScale13.MinPin.Width = 0.093!
GaugeCircularScale13.Name = "Scale1"
GaugePointer39.AllowUserChange = true
GaugePointer39.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer39.CapFillColor.BorderWidth = 1
GaugePointer39.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer39.CapFillColor.Color2 = System.Drawing.Color.Maroon
GaugePointer39.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer39.CapStyle = DevComponents.Instrumentation.NeedlePointerCapStyle.Style1
GaugePointer39.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer39.FillColor.BorderWidth = 1
GaugePointer39.FillColor.Color1 = System.Drawing.Color.LightCoral
GaugePointer39.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer39.Name = "Needle"
GaugePointer39.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer39.Tooltip = "Needle"
GaugePointer39.Value = 39
GaugeCircularScale13.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer39})
GaugeCircularScale13.Radius = 0.329!
GaugeSection35.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection35.Name = "Section1"
GaugeSection35.Tooltip = "Lime Section1"
GaugeSection36.EndValue = 20
GaugeSection36.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection36.Name = "Section2"
GaugeSection36.StartValue = 0
GaugeSection36.Tooltip = "Lime Section2"
GaugeCircularScale13.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection35, GaugeSection36})
GaugeCircularScale13.Width = 0.017!
Me.gcCircular5.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale11, GaugeCircularScale12, GaugeCircularScale13})
GradientFillColor47.Color1 = System.Drawing.Color.AntiqueWhite
GradientFillColor47.Color2 = System.Drawing.Color.SaddleBrown
GradientFillColor47.GradientAngle = 45
Me.gcCircular5.Frame.BackColor = GradientFillColor47
GradientFillColor48.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor48.Color2 = System.Drawing.Color.SaddleBrown
GradientFillColor48.GradientAngle = 45
Me.gcCircular5.Frame.FrameColor = GradientFillColor48
Me.gcCircular5.Frame.InnerBevel = 0.04!
Me.gcCircular5.Frame.OuterBevel = 0.02!
Me.gcCircular5.Frame.RoundRectangleArc = 0.1!
Me.gcCircular5.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
Me.gcCircular5.Location = New System.Drawing.Point(50, 51)
Me.gcCircular5.Name = "gcCircular5"
Me.gcCircular5.Size = New System.Drawing.Size(500, 500)
Me.gcCircular5.TabIndex = 1
'
'circularTab5
'
Me.circularTab5.AttachedControl = Me.superTabControlPanel5
Me.circularTab5.GlobalItem = false
Me.circularTab5.Name = "circularTab5"
Me.circularTab5.Text = "5"
'
'superTabControlPanel18
'
Me.superTabControlPanel18.Controls.Add(Me.sliderScaleAngle)
Me.superTabControlPanel18.Controls.Add(Me.labelX30)
Me.superTabControlPanel18.Controls.Add(Me.cbShowTooltips)
Me.superTabControlPanel18.Controls.Add(Me.labelX15)
Me.superTabControlPanel18.Controls.Add(Me.gcCircular1)
Me.superTabControlPanel18.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel18.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel18.Name = "superTabControlPanel18"
Me.superTabControlPanel18.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel18.TabIndex = 0
Me.superTabControlPanel18.TabItem = Me.circularTab1
'
'sliderScaleAngle
'
Me.sliderScaleAngle.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.sliderScaleAngle.BackgroundStyle.Class = ""
Me.sliderScaleAngle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.sliderScaleAngle.LabelWidth = 68
Me.sliderScaleAngle.Location = New System.Drawing.Point(567, 258)
Me.sliderScaleAngle.Maximum = 360
Me.sliderScaleAngle.Name = "sliderScaleAngle"
Me.sliderScaleAngle.Size = New System.Drawing.Size(204, 23)
Me.sliderScaleAngle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.sliderScaleAngle.TabIndex = 14
Me.sliderScaleAngle.Text = "Scale Angle"
Me.sliderScaleAngle.Value = 110
'
'labelX30
'
Me.labelX30.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX30.BackgroundStyle.Class = ""
Me.labelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX30.Location = New System.Drawing.Point(560, 169)
Me.labelX30.Name = "labelX30"
Me.labelX30.Size = New System.Drawing.Size(218, 74)
Me.labelX30.TabIndex = 13
Me.labelX30.Text = "Each Gauge Item can be shown, hidden and/or fully configured individually - such "& _ 
    "as the StartAngle for the scale:"
Me.labelX30.WordWrap = true
'
'cbShowTooltips
'
Me.cbShowTooltips.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbShowTooltips.BackgroundStyle.Class = ""
Me.cbShowTooltips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbShowTooltips.Location = New System.Drawing.Point(590, 113)
Me.cbShowTooltips.Name = "cbShowTooltips"
Me.cbShowTooltips.Size = New System.Drawing.Size(100, 23)
Me.cbShowTooltips.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbShowTooltips.TabIndex = 12
Me.cbShowTooltips.Text = "Show Tooltips"
'
'labelX15
'
Me.labelX15.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX15.BackgroundStyle.Class = ""
Me.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX15.Location = New System.Drawing.Point(522, 25)
Me.labelX15.Name = "labelX15"
Me.labelX15.Size = New System.Drawing.Size(218, 77)
Me.labelX15.TabIndex = 11
Me.labelX15.Text = "Each Gauge Item can have its own defined Tooltip.  These can be enabled or disabl"& _ 
    "ed for the entire gauge."
Me.labelX15.WordWrap = true
'
'gcCircular1
'
Me.gcCircular1.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale19.MaxPin.Name = "Maximum Pin"
GaugeCircularScale19.MaxPin.Tooltip = "MaxPin Tooltip"
GaugeCircularScale19.MinPin.EndOffset = 0.051!
GaugeCircularScale19.MinPin.Label.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
GaugeCircularScale19.MinPin.Label.Layout.ForeColor = System.Drawing.Color.Yellow
GaugeCircularScale19.MinPin.Label.Text = "Off"
GaugeCircularScale19.MinPin.Name = "MinPin"
GaugeCircularScale19.MinPin.Tooltip = "MinPin Tooltip"
GaugeCircularScale19.Name = "Scale1"
GaugePointer46.AllowUserChange = true
GaugePointer46.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer46.CapFillColor.BorderWidth = 1
GaugePointer46.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer46.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer46.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer46.FillColor.BorderWidth = 1
GaugePointer46.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer46.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer46.Length = 0.437!
GaugePointer46.Name = "Needle"
GaugePointer46.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style3
GaugePointer46.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer46.ScaleOffset = -0.215!
GaugePointer46.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer46.Tooltip = "Needle Tooltip"
GaugePointer46.Value = 20
GaugePointer46.Width = 0.055!
GaugePointer47.AllowUserChange = true
GaugePointer47.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer47.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer47.CapFillColor.BorderWidth = 1
GaugePointer47.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer47.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer47.ChangeCursor = System.Windows.Forms.Cursors.SizeAll
GaugePointer47.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer47.FillColor.BorderWidth = 1
GaugePointer47.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer47.FillColor.Color2 = System.Drawing.Color.Indigo
GaugePointer47.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer47.Name = "Bar"
GaugePointer47.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer47.Tooltip = "Bar Tooltip"
GaugePointer47.UnderTickMarks = true
GaugePointer47.Value = 35
GaugePointer47.Width = 0.028!
GaugeCircularScale19.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer46, GaugePointer47})
GaugeRange28.EndValue = 38
GaugeRange28.EndWidth = 0.2!
GaugeRange28.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange28.FillColor.BorderWidth = 1
GaugeRange28.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange28.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange28.Name = "Range1"
GaugeRange28.ScaleOffset = 0.28!
GaugeRange28.StartValue = 12
GaugeRange28.StartWidth = 0.1!
GaugeRange28.Tooltip = "Range Tooltip"
GaugeCircularScale19.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange28})
GaugeCircularScale19.Reversed = true
GaugeSection48.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection48.Name = "Section1"
GaugeSection48.StartValue = 50
GaugeSection48.Tooltip = "Blue Section Tooltip"
GaugeSection49.EndValue = 20
GaugeSection49.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection49.Name = "Section2"
GaugeSection49.StartValue = 0
GaugeSection49.Tooltip = "Lime Section Tooltip"
GaugeCircularScale19.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection48, GaugeSection49})
Me.gcCircular1.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale19})
Me.gcCircular1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
GaugeText14.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText14.Location = CType(resources.GetObject("GaugeText14.Location"),System.Drawing.PointF)
GaugeText14.Name = "Text1"
GaugeText14.Tooltip = "My Text!"
GaugeImage3.AutoFit = true
GaugeImage3.Image = CType(resources.GetObject("GaugeImage3.Image"),System.Drawing.Image)
GaugeImage3.Location = CType(resources.GetObject("GaugeImage3.Location"),System.Drawing.PointF)
GaugeImage3.Name = "Image1"
GaugeImage3.Size = New System.Drawing.SizeF(0.1!, 0.1!)
GaugeImage3.Tooltip = "My Image!"
NumericIndicator2.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator2.BackColor.BorderWidth = 3
NumericIndicator2.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator2.DecimalColor = System.Drawing.Color.Lime
NumericIndicator2.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator2.DigitColor = System.Drawing.Color.Red
NumericIndicator2.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator2.Name = "NumericIndicator1"
NumericIndicator2.OverRangeString = "100"
NumericIndicator2.Size = New System.Drawing.SizeF(0.3!, 0.09!)
NumericIndicator2.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator2.Tooltip = "Digital Indicator"
NumericIndicator2.UnderRangeString = "0"
NumericIndicator2.Value = 20
Me.gcCircular1.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText14, GaugeImage3, NumericIndicator2})
Me.gcCircular1.Location = New System.Drawing.Point(50, 51)
Me.gcCircular1.Name = "gcCircular1"
Me.gcCircular1.ShowToolTips = false
Me.gcCircular1.Size = New System.Drawing.Size(500, 500)
Me.gcCircular1.TabIndex = 15
'
'circularTab1
'
Me.circularTab1.AttachedControl = Me.superTabControlPanel18
Me.circularTab1.GlobalItem = false
Me.circularTab1.Name = "circularTab1"
Me.circularTab1.Text = "1"
'
'superTabControlPanel8
'
Me.superTabControlPanel8.Controls.Add(Me.labelX19)
Me.superTabControlPanel8.Controls.Add(Me.labelX18)
Me.superTabControlPanel8.Controls.Add(Me.cbReverse2)
Me.superTabControlPanel8.Controls.Add(Me.cbReverse1)
Me.superTabControlPanel8.Controls.Add(Me.cbCAddGlassEffect)
Me.superTabControlPanel8.Controls.Add(Me.gcCircular2)
Me.superTabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel8.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel8.Name = "superTabControlPanel8"
Me.superTabControlPanel8.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel8.TabIndex = 0
Me.superTabControlPanel8.TabItem = Me.circularTab2
'
'labelX19
'
Me.labelX19.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX19.BackgroundStyle.Class = ""
Me.labelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX19.Location = New System.Drawing.Point(571, 169)
Me.labelX19.Name = "labelX19"
Me.labelX19.Size = New System.Drawing.Size(189, 45)
Me.labelX19.TabIndex = 13
Me.labelX19.Text = "Each scale in the gauge can be individually reversed."
Me.labelX19.WordWrap = true
'
'labelX18
'
Me.labelX18.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX18.BackgroundStyle.Class = ""
Me.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX18.Location = New System.Drawing.Point(534, 46)
Me.labelX18.Name = "labelX18"
Me.labelX18.Size = New System.Drawing.Size(218, 48)
Me.labelX18.TabIndex = 12
Me.labelX18.Text = "A Glass Effect can be added to the gauge, if desired."
Me.labelX18.WordWrap = true
'
'cbReverse2
'
Me.cbReverse2.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbReverse2.BackgroundStyle.Class = ""
Me.cbReverse2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbReverse2.Location = New System.Drawing.Point(602, 245)
Me.cbReverse2.Name = "cbReverse2"
Me.cbReverse2.Size = New System.Drawing.Size(115, 23)
Me.cbReverse2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbReverse2.TabIndex = 7
Me.cbReverse2.Text = "Reverse Scale2"
'
'cbReverse1
'
Me.cbReverse1.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbReverse1.BackgroundStyle.Class = ""
Me.cbReverse1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbReverse1.Location = New System.Drawing.Point(602, 223)
Me.cbReverse1.Name = "cbReverse1"
Me.cbReverse1.Size = New System.Drawing.Size(115, 23)
Me.cbReverse1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbReverse1.TabIndex = 6
Me.cbReverse1.Text = "Reverse Scale1"
'
'cbCAddGlassEffect
'
Me.cbCAddGlassEffect.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbCAddGlassEffect.BackgroundStyle.Class = ""
Me.cbCAddGlassEffect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbCAddGlassEffect.Location = New System.Drawing.Point(577, 100)
Me.cbCAddGlassEffect.Name = "cbCAddGlassEffect"
Me.cbCAddGlassEffect.Size = New System.Drawing.Size(115, 23)
Me.cbCAddGlassEffect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbCAddGlassEffect.TabIndex = 4
Me.cbCAddGlassEffect.Text = "Add Glass Effect"
'
'gcCircular2
'
Me.gcCircular2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.gcCircular2.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale17.BorderWidth = 1
GaugeCustomLabel12.Layout.AdaptiveLabel = true
GaugeCustomLabel12.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
GaugeCustomLabel12.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCustomLabel12.Layout.RotateLabel = false
GaugeCustomLabel12.Layout.ScaleOffset = 0.088!
GaugeCustomLabel12.Name = "Low"
GaugeCustomLabel12.Text = "Low"
GaugeCustomLabel12.TickMark.Visible = false
GaugeCustomLabel12.Value = 60
GaugeCustomLabel13.Layout.AdaptiveLabel = true
GaugeCustomLabel13.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
GaugeCustomLabel13.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCustomLabel13.Layout.RotateLabel = false
GaugeCustomLabel13.Layout.ScaleOffset = 0.063!
GaugeCustomLabel13.Name = "High"
GaugeCustomLabel13.Text = "High"
GaugeCustomLabel13.TickMark.Visible = false
GaugeCustomLabel13.Value = 90
GaugeCircularScale17.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel12, GaugeCustomLabel13})
GaugeCircularScale17.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Center
GaugeCircularScale17.Labels.Layout.ScaleOffset = 0.082!
GaugeCircularScale17.Labels.ShowMaxLabel = false
GaugeCircularScale17.Labels.ShowMinLabel = false
GaugeCircularScale17.MajorTickMarks.Interval = 5
GaugeCircularScale17.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.None
GaugeCircularScale17.MaxPin.Name = "MaxPin"
GaugeCircularScale17.MaxPin.Tooltip = "Maximum Pin Tooltip"
GaugeCircularScale17.MaxValue = 90
GaugeCircularScale17.MinorTickMarks.Interval = 1.25
GaugeCircularScale17.MinPin.Name = "MinPin"
GaugeCircularScale17.MinPin.Tooltip = "Minimum Pin Tooltip"
GaugeCircularScale17.MinValue = 60
GaugeCircularScale17.Name = "Scale1"
GaugePointer45.AllowUserChange = true
GaugePointer45.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer45.CapFillColor.BorderWidth = 1
GaugePointer45.CapFillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer45.CapFillColor.Color2 = System.Drawing.Color.DarkGoldenrod
GaugePointer45.CapFillColor.GradientAngle = 45
GaugePointer45.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
GaugePointer45.CapWidth = 0.205!
GaugePointer45.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer45.FillColor.BorderWidth = 1
GaugePointer45.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer45.FillColor.Color2 = System.Drawing.Color.Goldenrod
GaugePointer45.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer45.Length = 0.411!
GaugePointer45.Name = "Needle"
GaugePointer45.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer45.Tooltip = "Needle Tooltip"
GaugePointer45.Value = 62
GaugePointer45.Width = 0.093!
GaugeCircularScale17.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer45})
GaugeCircularScale17.Radius = 0.3!
GaugeRange25.EndValue = 90
GaugeRange25.EndWidth = 0.11!
GaugeRange25.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange25.FillColor.BorderWidth = 1
GaugeRange25.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange25.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange25.Name = "Range1"
GaugeRange25.StartValue = 0
GaugeRange25.StartWidth = 0.11!
GaugeRange25.Tooltip = "Range1 Tooltip"
GaugeRange26.EndValue = 82.5
GaugeRange26.EndWidth = 0.495!
GaugeRange26.FillColor.BorderColor = System.Drawing.Color.DarkOliveGreen
GaugeRange26.FillColor.BorderWidth = 1
GaugeRange26.FillColor.Color1 = System.Drawing.Color.Honeydew
GaugeRange26.FillColor.Color2 = System.Drawing.Color.DarkOliveGreen
GaugeRange26.Name = "Range2"
GaugeRange26.ScaleOffset = 0.326!
GaugeRange26.StartValue = 65
GaugeRange26.Tooltip = "Range2 Tooltip"
GaugeRange27.EndValue = 90
GaugeRange27.EndWidth = 0.147!
GaugeRange27.FillColor.BorderColor = System.Drawing.Color.DarkOliveGreen
GaugeRange27.FillColor.BorderWidth = 1
GaugeRange27.FillColor.Color1 = System.Drawing.Color.DarkOliveGreen
GaugeRange27.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange27.Name = "Range3"
GaugeRange27.ScaleOffset = 0.326!
GaugeRange27.StartValue = 82.5
GaugeRange27.StartWidth = 0.495!
GaugeRange27.Tooltip = "Range3 Tooltip"
GaugeCircularScale17.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange25, GaugeRange26, GaugeRange27})
GaugeSection44.FillColor.Color1 = System.Drawing.Color.Beige
GaugeSection44.Name = "Section1"
GaugeSection44.Tooltip = "Section1 Tooltip"
GaugeSection45.EndValue = 70
GaugeSection45.FillColor.Color1 = System.Drawing.Color.Aquamarine
GaugeSection45.Name = "Section2"
GaugeSection45.ScaleOffset = 0.117!
GaugeSection45.StartValue = 60
GaugeSection45.Tooltip = "Section2 Tooltip"
GaugeSection45.Width = 0.079!
GaugeSection46.EndValue = 85
GaugeSection46.FillColor.Color1 = System.Drawing.Color.BurlyWood
GaugeSection46.Name = "Section3"
GaugeSection46.ScaleOffset = 0.142!
GaugeSection46.StartValue = 75
GaugeSection46.Tooltip = "Section3 Tooltip"
GaugeCircularScale17.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection44, GaugeSection45, GaugeSection46})
GaugeCircularScale17.Width = 0.147!
GaugeCircularScale18.Labels.Layout.RotateLabel = false
GaugeCircularScale18.MajorTickMarks.Visible = false
GaugeCircularScale18.MaxPin.Name = "MaxPin"
GaugeCircularScale18.MaxPin.Tooltip = "Maximum Pin Tooltip"
GaugeCircularScale18.MinorTickMarks.Interval = 1
GaugeCircularScale18.MinorTickMarks.Layout.Length = 0.137!
GaugeCircularScale18.MinorTickMarks.Layout.ScaleOffset = 0.025!
GaugeCircularScale18.MinPin.Name = "MinPin"
GaugeCircularScale18.MinPin.Tooltip = "Minimum Pin Tooltip"
GaugeCircularScale18.Name = "Scale2"
GaugeCircularScale18.Radius = 0.255!
GaugeSection47.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection47.Name = "Section1"
GaugeSection47.Tooltip = " (Lime) Tooltip"
GaugeSection47.Visible = false
GaugeCircularScale18.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection47})
Me.gcCircular2.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale17, GaugeCircularScale18})
GradientFillColor54.BorderColor = System.Drawing.Color.Silver
GradientFillColor54.Color1 = System.Drawing.Color.DimGray
GradientFillColor54.Color2 = System.Drawing.Color.LightGray
GradientFillColor54.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter
Me.gcCircular2.Frame.BackColor = GradientFillColor54
GradientFillColor55.BorderColor = System.Drawing.Color.Silver
GradientFillColor55.BorderWidth = 1
GradientFillColor55.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor55.Color2 = System.Drawing.Color.DimGray
GradientFillColor55.GradientAngle = 45
Me.gcCircular2.Frame.FrameColor = GradientFillColor55
Me.gcCircular2.Frame.InnerBevel = 0.02!
Me.gcCircular2.Frame.OuterBevel = 0.1!
Me.gcCircular2.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
StateIndicator2.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator2.BackColor.Color1 = System.Drawing.Color.PaleGreen
StateIndicator2.BackColor.Color2 = System.Drawing.Color.DarkGreen
StateIndicator2.Location = CType(resources.GetObject("StateIndicator2.Location"),System.Drawing.PointF)
StateIndicator2.Name = "StateIndicator1"
StateRange2.BackColor.BorderColor = System.Drawing.Color.Olive
StateRange2.BackColor.BorderWidth = 1
StateRange2.BackColor.Color1 = System.Drawing.Color.Yellow
StateRange2.BackColor.Color2 = System.Drawing.Color.Olive
StateRange2.EndValue = 75
StateRange2.Name = "Range1"
StateRange2.StartValue = 70
StateRange2.TextColor = System.Drawing.Color.Empty
StateRange3.BackColor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
StateRange3.BackColor.BorderWidth = 1
StateRange3.BackColor.Color1 = System.Drawing.Color.White
StateRange3.BackColor.Color2 = System.Drawing.Color.Maroon
StateRange3.EndValue = 85
StateRange3.Name = "Range2"
StateRange3.StartValue = 75
StateRange3.TextColor = System.Drawing.Color.Empty
StateRange4.BackColor.Color1 = System.Drawing.Color.White
StateRange4.BackColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
StateRange4.EndValue = 1000
StateRange4.Name = "Range3"
StateRange4.StartValue = 85
StateRange4.TextColor = System.Drawing.Color.Empty
StateIndicator2.Ranges.AddRange(New DevComponents.Instrumentation.StateRange() {StateRange2, StateRange3, StateRange4})
StateIndicator2.Size = New System.Drawing.SizeF(0.04!, 0.04!)
StateIndicator2.Text = ""
StateIndicator2.TextAlignment = DevComponents.Instrumentation.TextAlignment.BottomCenter
StateIndicator2.Value = 62
Me.gcCircular2.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {StateIndicator2})
Me.gcCircular2.Location = New System.Drawing.Point(50, 51)
Me.gcCircular2.Name = "gcCircular2"
Me.gcCircular2.Size = New System.Drawing.Size(500, 500)
Me.gcCircular2.TabIndex = 14
'
'circularTab2
'
Me.circularTab2.AttachedControl = Me.superTabControlPanel8
Me.circularTab2.GlobalItem = false
Me.circularTab2.Name = "circularTab2"
Me.circularTab2.Text = "2"
'
'superTabControlPanel4
'
Me.superTabControlPanel4.Controls.Add(Me.labelX31)
Me.superTabControlPanel4.Controls.Add(Me.labelX20)
Me.superTabControlPanel4.Controls.Add(Me.cbCRotateLabels)
Me.superTabControlPanel4.Controls.Add(Me.cbCAutoOrientLabels)
Me.superTabControlPanel4.Controls.Add(Me.sliderCAngle)
Me.superTabControlPanel4.Controls.Add(Me.gcCircular4)
Me.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel4.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel4.Name = "superTabControlPanel4"
Me.superTabControlPanel4.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel4.TabIndex = 1
Me.superTabControlPanel4.TabItem = Me.circularTab4
'
'labelX31
'
Me.labelX31.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX31.BackgroundStyle.Class = ""
Me.labelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX31.Location = New System.Drawing.Point(522, 456)
Me.labelX31.Name = "labelX31"
Me.labelX31.Size = New System.Drawing.Size(235, 70)
Me.labelX31.TabIndex = 12
Me.labelX31.Text = "Multiple scales are easy to tie together.  Try moving each of the above needle po"& _ 
    "inters."
Me.labelX31.WordWrap = true
'
'labelX20
'
Me.labelX20.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX20.BackgroundStyle.Class = ""
Me.labelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX20.Location = New System.Drawing.Point(525, 32)
Me.labelX20.Name = "labelX20"
Me.labelX20.Size = New System.Drawing.Size(235, 70)
Me.labelX20.TabIndex = 11
Me.labelX20.Text = "Label fonts, sizes, and colors are fully configurable. You can also control the a"& _ 
    "ngle at which the labels are displayed."
Me.labelX20.WordWrap = true
'
'cbCRotateLabels
'
Me.cbCRotateLabels.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbCRotateLabels.BackgroundStyle.Class = ""
Me.cbCRotateLabels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbCRotateLabels.Checked = true
Me.cbCRotateLabels.CheckState = System.Windows.Forms.CheckState.Checked
Me.cbCRotateLabels.CheckValue = "Y"
Me.cbCRotateLabels.Location = New System.Drawing.Point(603, 186)
Me.cbCRotateLabels.Name = "cbCRotateLabels"
Me.cbCRotateLabels.Size = New System.Drawing.Size(117, 23)
Me.cbCRotateLabels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbCRotateLabels.TabIndex = 4
Me.cbCRotateLabels.Text = "Rotate Labels"
'
'cbCAutoOrientLabels
'
Me.cbCAutoOrientLabels.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbCAutoOrientLabels.BackgroundStyle.Class = ""
Me.cbCAutoOrientLabels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbCAutoOrientLabels.Checked = true
Me.cbCAutoOrientLabels.CheckState = System.Windows.Forms.CheckState.Checked
Me.cbCAutoOrientLabels.CheckValue = "Y"
Me.cbCAutoOrientLabels.Location = New System.Drawing.Point(603, 159)
Me.cbCAutoOrientLabels.Name = "cbCAutoOrientLabels"
Me.cbCAutoOrientLabels.Size = New System.Drawing.Size(117, 23)
Me.cbCAutoOrientLabels.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbCAutoOrientLabels.TabIndex = 3
Me.cbCAutoOrientLabels.Text = "Auto-Orient Labels"
'
'sliderCAngle
'
Me.sliderCAngle.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.sliderCAngle.BackgroundStyle.Class = ""
Me.sliderCAngle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.sliderCAngle.LabelWidth = 68
Me.sliderCAngle.Location = New System.Drawing.Point(545, 115)
Me.sliderCAngle.Maximum = 360
Me.sliderCAngle.Name = "sliderCAngle"
Me.sliderCAngle.Size = New System.Drawing.Size(204, 23)
Me.sliderCAngle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.sliderCAngle.TabIndex = 2
Me.sliderCAngle.Text = "Label Angle"
Me.sliderCAngle.Value = 0
'
'gcCircular4
'
Me.gcCircular4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.gcCircular4.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale14.BorderWidth = 1
GaugeCircularScale14.Labels.Layout.ScaleOffset = 0.063!
GaugeCircularScale14.MajorTickMarks.Interval = 20
GaugeCircularScale14.MajorTickMarks.Layout.Length = 0.232!
GaugeCircularScale14.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale14.MajorTickMarks.Layout.ScaleOffset = -0.164!
GaugeCircularScale14.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Triangle
GaugeCircularScale14.MajorTickMarks.Layout.Width = 0.175!
GaugeCircularScale14.MaxPin.EndOffset = 0.025!
GaugeCircularScale14.MaxPin.Length = 0.1!
GaugeCircularScale14.MaxPin.Name = "MaxPin"
GaugeCircularScale14.MaxPin.Width = 0.1!
GaugeCircularScale14.MinorTickMarks.Interval = 10
GaugeCircularScale14.MinorTickMarks.Layout.Length = 0.2!
GaugeCircularScale14.MinorTickMarks.Layout.Width = 0.128!
GaugeCircularScale14.MinPin.EndOffset = 0.025!
GaugeCircularScale14.MinPin.Length = 0.1!
GaugeCircularScale14.MinPin.Name = "MinPin"
GaugeCircularScale14.MinPin.Width = 0.1!
GaugeCircularScale14.Name = "Small Scale"
GaugeCircularScale14.PivotPoint = CType(resources.GetObject("GaugeCircularScale14.PivotPoint"),System.Drawing.PointF)
GaugePointer40.AllowUserChange = true
GaugePointer40.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer40.CapFillColor.BorderWidth = 1
GaugePointer40.CapFillColor.Color1 = System.Drawing.Color.White
GaugePointer40.CapFillColor.Color2 = System.Drawing.Color.Black
GaugePointer40.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer40.CapStyle = DevComponents.Instrumentation.NeedlePointerCapStyle.Style1
GaugePointer40.CapWidth = 0.268!
GaugePointer40.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer40.FillColor.BorderWidth = 1
GaugePointer40.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer40.FillColor.Color2 = System.Drawing.Color.DarkOrange
GaugePointer40.Length = 0.221!
GaugePointer40.Name = "SmallNeedle"
GaugePointer40.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style3
GaugePointer40.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer40.ScaleOffset = -0.101!
GaugePointer40.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer40.Tooltip = "Little Mr. Pointy"
GaugePointer40.Value = 56
GaugePointer40.Width = 0.081!
GaugeCircularScale14.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer40})
GaugeCircularScale14.Radius = 0.145!
GaugeRange18.EndValue = 100
GaugeRange18.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange18.FillColor.BorderWidth = 1
GaugeRange18.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange18.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange18.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugeRange18.Name = "Range1"
GaugeRange18.ScaleOffset = 0.36!
GaugeRange18.StartValue = 20
GaugeRange18.Tooltip = "Little Green/Red Range"
GaugeCircularScale14.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange18})
GaugeSection37.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection37.Name = "Section1"
GaugeSection37.Tooltip = "Little Limey Section"
GaugeSection38.EndValue = 100
GaugeSection38.FillColor.Color1 = System.Drawing.Color.Chartreuse
GaugeSection38.FillColor.Color2 = System.Drawing.Color.Red
GaugeSection38.Name = "Section2"
GaugeSection38.StartValue = 50
GaugeSection38.Tooltip = "Little Green/Red Section"
GaugeCircularScale14.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection37, GaugeSection38})
GaugeCircularScale14.StartAngle = 191.368!
GaugeCircularScale14.SweepAngle = 153.474!
GaugeCircularScale14.Width = 0.066!
GaugeCustomLabel8.Layout.AdaptiveLabel = true
GaugeCustomLabel8.Layout.ForeColor = System.Drawing.Color.DarkRed
GaugeCustomLabel8.Layout.ScaleOffset = 0.028!
GaugeCustomLabel8.Name = "Peabody"
GaugeCustomLabel8.Text = "Peabody"
GradientFillColor49.BorderColor = System.Drawing.Color.Red
GradientFillColor49.BorderWidth = 1
GradientFillColor49.Color1 = System.Drawing.Color.Gold
GaugeCustomLabel8.TickMark.Layout.FillColor = GradientFillColor49
GaugeCustomLabel8.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Star5
GaugeCustomLabel8.TickMark.Layout.Width = 0.14!
GaugeCustomLabel8.Value = 10
GaugeCustomLabel9.Name = "*50*"
GaugeCustomLabel9.Text = "*50*"
GradientFillColor50.BorderColor = System.Drawing.Color.Black
GradientFillColor50.BorderWidth = 1
GradientFillColor50.Color1 = System.Drawing.Color.Tomato
GaugeCustomLabel9.TickMark.Layout.FillColor = GradientFillColor50
GaugeCustomLabel9.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Diamond
GaugeCustomLabel9.Value = 50
GaugeCircularScale15.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel8, GaugeCustomLabel9})
GaugeCircularScale15.Labels.FormatString = ""
GaugeCircularScale15.MaxPin.EndOffset = 0.016!
GaugeCircularScale15.MaxPin.Length = 0.1!
GaugeCircularScale15.MaxPin.Name = "MaxPin"
GaugeCircularScale15.MaxPin.Width = 0.1!
GaugeCircularScale15.MinPin.EndOffset = 0.016!
GaugeCircularScale15.MinPin.Length = 0.1!
GaugeCircularScale15.MinPin.Name = "MinPin"
GaugeCircularScale15.MinPin.Width = 0.1!
GaugeCircularScale15.Name = "Large Scale"
GaugePointer41.AllowUserChange = true
GaugePointer41.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer41.CapFillColor.BorderWidth = 1
GaugePointer41.CapFillColor.Color1 = System.Drawing.Color.DarkRed
GaugePointer41.CapFillColor.Color2 = System.Drawing.Color.Gold
GaugePointer41.CapInnerBevel = 0.045!
GaugePointer41.CapOuterBevel = 0.061!
GaugePointer41.FillColor.BorderColor = System.Drawing.Color.MidnightBlue
GaugePointer41.FillColor.BorderWidth = 1
GaugePointer41.FillColor.Color1 = System.Drawing.Color.Aqua
GaugePointer41.FillColor.Color2 = System.Drawing.Color.DarkCyan
GaugePointer41.Length = 0.316!
GaugePointer41.Name = "LargeNeedle"
GaugePointer41.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style7
GaugePointer41.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer41.Tooltip = "Big Mr. Pointy"
GaugePointer41.Value = 44
GaugePointer41.Width = 0.129!
GaugeCircularScale15.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer41})
GaugeRange19.EndValue = 95
GaugeRange19.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange19.FillColor.BorderWidth = 1
GaugeRange19.FillColor.Color1 = System.Drawing.Color.Yellow
GaugeRange19.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange19.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.Gray
GaugeRange19.MajorTickMarkFillColor.BorderWidth = 1
GaugeRange19.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Yellow
GaugeRange19.MajorTickMarkFillColor.Color2 = System.Drawing.Color.Gold
GaugeRange19.MinorTickMarkFillColor.BorderColor = System.Drawing.Color.Silver
GaugeRange19.MinorTickMarkFillColor.BorderWidth = 1
GaugeRange19.MinorTickMarkFillColor.Color1 = System.Drawing.Color.Crimson
GaugeRange19.Name = "Range1"
GaugeRange19.ScaleOffset = 0.24!
GaugeRange19.StartValue = 60
GaugeRange19.StartWidth = 0.035!
GaugeRange19.Tooltip = "Yellow/Red Range"
GaugeRange20.EndValue = 100
GaugeRange20.EndWidth = 0.35!
GaugeRange20.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange20.FillColor.BorderWidth = 1
GaugeRange20.FillColor.Color1 = System.Drawing.Color.Teal
GaugeRange20.FillColor.Color2 = System.Drawing.Color.Teal
GaugeRange20.Name = "Range2"
GaugeRange20.ScaleOffset = 0.24!
GaugeRange20.StartValue = 95
GaugeRange20.StartWidth = 0.3!
GaugeRange20.Tooltip = "Teal Range"
GaugeRange21.EndValue = 20
GaugeRange21.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange21.FillColor.BorderWidth = 1
GaugeRange21.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange21.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange21.Name = "Range3"
GaugeRange21.ScaleOffset = 0.237!
GaugeRange21.StartValue = 50
GaugeRange21.StartWidth = 0.037!
GaugeRange21.Tooltip = "Big Green/Red Range"
GaugeCircularScale15.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange19, GaugeRange20, GaugeRange21})
GaugeSection39.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection39.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
GaugeSection39.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugeSection39.Name = "Section1"
GaugeSection39.Tooltip = "Corny Section"
GaugeSection40.EndValue = 20
GaugeSection40.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection40.Name = "Section2"
GaugeSection40.StartValue = 0
GaugeSection40.Tooltip = "Limey Section"
GaugeCircularScale15.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection39, GaugeSection40})
GaugeCircularScale15.StartAngle = 70.105!
Me.gcCircular4.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale14, GaugeCircularScale15})
Me.gcCircular4.Frame.AddGlassEffect = true
Me.gcCircular4.Frame.InnerBevel = 0.011!
Me.gcCircular4.Frame.OuterBevel = 0.032!
Me.gcCircular4.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
Me.gcCircular4.Location = New System.Drawing.Point(50, 51)
Me.gcCircular4.Name = "gcCircular4"
Me.gcCircular4.Size = New System.Drawing.Size(500, 500)
Me.gcCircular4.TabIndex = 1
'
'circularTab4
'
Me.circularTab4.AttachedControl = Me.superTabControlPanel4
Me.circularTab4.GlobalItem = false
Me.circularTab4.Name = "circularTab4"
Me.circularTab4.Text = "4"
'
'superTabControlPanel6
'
Me.superTabControlPanel6.Controls.Add(Me.labelX33)
Me.superTabControlPanel6.Controls.Add(Me.labelX17)
Me.superTabControlPanel6.Controls.Add(Me.labelX14)
Me.superTabControlPanel6.Controls.Add(Me.gcCircular3)
Me.superTabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel6.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel6.Name = "superTabControlPanel6"
Me.superTabControlPanel6.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel6.TabIndex = 0
Me.superTabControlPanel6.TabItem = Me.circularTab3
'
'labelX33
'
Me.labelX33.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX33.BackgroundStyle.Class = ""
Me.labelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX33.Location = New System.Drawing.Point(536, 431)
Me.labelX33.Name = "labelX33"
Me.labelX33.Size = New System.Drawing.Size(218, 83)
Me.labelX33.TabIndex = 11
Me.labelX33.Text = "Also note a few of the variations available when displaying scale labels (rotated"& _ 
    ", colored, curved to fit the scale, etc)."
Me.labelX33.WordWrap = true
'
'labelX17
'
Me.labelX17.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX17.BackgroundStyle.Class = ""
Me.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX17.Location = New System.Drawing.Point(556, 103)
Me.labelX17.Name = "labelX17"
Me.labelX17.Size = New System.Drawing.Size(218, 66)
Me.labelX17.TabIndex = 10
Me.labelX17.Text = "Move the scale pointers (needle, circle, and star) to observe the above effect."
Me.labelX17.WordWrap = true
'
'labelX14
'
Me.labelX14.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX14.BackgroundStyle.Class = ""
Me.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX14.Location = New System.Drawing.Point(530, 26)
Me.labelX14.Name = "labelX14"
Me.labelX14.Size = New System.Drawing.Size(218, 83)
Me.labelX14.TabIndex = 9
Me.labelX14.Text = "Tickmarks, Labels, and Pointers can all be dynamically colored based upon Section"& _ 
    "/Range definitions."
Me.labelX14.WordWrap = true
'
'gcCircular3
'
Me.gcCircular3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.gcCircular3.BackColor = System.Drawing.Color.AliceBlue
GaugeCustomLabel10.Layout.AdaptiveLabel = true
GaugeCustomLabel10.Layout.ForeColor = System.Drawing.Color.Red
GaugeCustomLabel10.Name = "Danger"
GaugeCustomLabel10.Text = "Danger Will Robinson!"
GradientFillColor51.BorderColor = System.Drawing.Color.DimGray
GradientFillColor51.BorderWidth = 1
GradientFillColor51.Color1 = System.Drawing.Color.WhiteSmoke
GradientFillColor51.Color2 = System.Drawing.Color.DarkRed
GaugeCustomLabel10.TickMark.Layout.FillColor = GradientFillColor51
GaugeCustomLabel10.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugeCustomLabel10.TickMark.Layout.Width = 0.14!
GaugeCustomLabel10.Value = 30
GaugeCustomLabel11.Layout.Angle = 90!
GaugeCustomLabel11.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCustomLabel11.Name = "Stop"
GaugeCustomLabel11.Text = "Stop"
GaugeCustomLabel11.Value = 40
GaugeCircularScale16.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel10, GaugeCustomLabel11})
GaugeCircularScale16.Labels.FormatString = ""
GaugeCircularScale16.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale16.Labels.Layout.ScaleOffset = 0.025!
GaugeCircularScale16.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Pentagon
GaugeCircularScale16.MajorTickMarks.Layout.Width = 0.129!
GaugeCircularScale16.MaxPin.Name = "MaxPin"
GaugeCircularScale16.MaxPin.Tooltip = "MinPin Tooltip"
GaugeCircularScale16.MinPin.Name = "MinPin"
GaugeCircularScale16.MinPin.Tooltip = "MaxPin Tooltip"
GaugeCircularScale16.Name = "Scale1"
GaugePointer42.AllowUserChange = true
GaugePointer42.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer42.CapFillColor.BorderWidth = 1
GaugePointer42.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer42.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer42.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer42.FillColor.BorderWidth = 1
GaugePointer42.FillColor.Color1 = System.Drawing.Color.White
GaugePointer42.FillColor.Color2 = System.Drawing.Color.DeepSkyBlue
GaugePointer42.Length = 0.226!
GaugePointer42.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugePointer42.Name = "Star"
GaugePointer42.OriginInterval = 0
GaugePointer42.Tooltip = "Star Pointer Tooltip"
GaugePointer42.Value = 96
GaugePointer42.Width = 0.226!
GaugePointer43.AllowUserChange = true
GaugePointer43.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer43.CapFillColor.BorderWidth = 1
GaugePointer43.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
GaugePointer43.CapFillColor.Color2 = System.Drawing.Color.Silver
GaugePointer43.FillColor.BorderColor = System.Drawing.Color.DarkGoldenrod
GaugePointer43.FillColor.BorderWidth = 1
GaugePointer43.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer43.FillColor.Color2 = System.Drawing.Color.DarkGoldenrod
GaugePointer43.Length = 0.2!
GaugePointer43.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Circle
GaugePointer43.Name = "Circle"
GaugePointer43.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer43.Tooltip = "Circle Pointer Tooltip"
GaugePointer43.Value = 4
GaugePointer43.Width = 0.2!
GaugePointer44.AllowUserChange = true
GaugePointer44.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer44.CapFillColor.BorderWidth = 1
GaugePointer44.CapFillColor.Color1 = System.Drawing.Color.White
GaugePointer44.CapFillColor.Color2 = System.Drawing.Color.DarkRed
GaugePointer44.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
GaugePointer44.CapInnerBevel = 0.084!
GaugePointer44.CapOuterBevel = 0.132!
GaugePointer44.FillColor.BorderColor = System.Drawing.Color.Black
GaugePointer44.FillColor.BorderWidth = 1
GaugePointer44.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer44.FillColor.Color2 = System.Drawing.Color.DarkRed
GaugePointer44.Length = 0.416!
GaugePointer44.Name = "Needle"
GaugePointer44.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style6
GaugePointer44.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer44.Tooltip = "Needle Tooltip"
GaugePointer44.Value = 50
GaugePointer44.Width = 0.115!
GaugeCircularScale16.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer42, GaugePointer43, GaugePointer44})
GaugeCircularScale16.Radius = 0.3!
GaugeRange22.EndValue = 95
GaugeRange22.EndWidth = 0.5!
GaugeRange22.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange22.FillColor.BorderWidth = 1
GaugeRange22.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange22.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange22.LabelColor = System.Drawing.Color.Red
GaugeRange22.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange22.MajorTickMarkFillColor.BorderWidth = 1
GaugeRange22.MajorTickMarkFillColor.Color1 = System.Drawing.Color.MistyRose
GaugeRange22.MajorTickMarkFillColor.Color2 = System.Drawing.Color.Crimson
GaugeRange22.MajorTickMarkFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter
GaugeRange22.MinorTickMarkFillColor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
GaugeRange22.MinorTickMarkFillColor.BorderWidth = 1
GaugeRange22.MinorTickMarkFillColor.Color1 = System.Drawing.Color.LightSkyBlue
GaugeRange22.Name = "Range1"
GaugeRange22.ScaleOffset = 0.085!
GaugeRange22.StartValue = 55
GaugeRange22.StartWidth = 0.153!
GaugeRange22.Tooltip = "Range One Tooltip"
GaugeRange23.EndValue = 12
GaugeRange23.EndWidth = 0.026!
GaugeRange23.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange23.FillColor.BorderWidth = 1
GaugeRange23.FillColor.Color1 = System.Drawing.Color.Aquamarine
GaugeRange23.FillColor.Color2 = System.Drawing.Color.DarkSlateGray
GaugeRange23.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter
GaugeRange23.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.Blue
GaugeRange23.MajorTickMarkFillColor.BorderWidth = 1
GaugeRange23.MajorTickMarkFillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
GaugeRange23.MajorTickMarkFillColor.Color2 = System.Drawing.Color.Blue
GaugeRange23.Name = "Range2"
GaugeRange23.ScaleOffset = 0.246!
GaugeRange23.StartValue = 46
GaugeRange23.Tooltip = "Range Two Tooltip"
GaugeRange24.EndValue = 30
GaugeRange24.EndWidth = 0.15!
GaugeRange24.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange24.FillColor.BorderWidth = 1
GaugeRange24.FillColor.Color1 = System.Drawing.Color.DarkSlateGray
GaugeRange24.FillColor.Color2 = System.Drawing.Color.DeepSkyBlue
GaugeRange24.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugeRange24.Name = "Range3"
GaugeRange24.ScaleOffset = 0.407!
GaugeRange24.StartValue = 0
GaugeRange24.Tooltip = "Range Three Tooltip"
GaugeCircularScale16.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange22, GaugeRange23, GaugeRange24})
GaugeSection41.CapFillColor.Color1 = System.Drawing.Color.Yellow
GaugeSection41.CapFillColor.Color2 = System.Drawing.Color.DarkGoldenrod
GaugeSection41.FillColor.Color1 = System.Drawing.Color.DarkBlue
GaugeSection41.Name = "Section1"
GaugeSection41.PointerFillColor.BorderColor = System.Drawing.Color.DimGray
GaugeSection41.PointerFillColor.BorderWidth = 1
GaugeSection41.PointerFillColor.Color1 = System.Drawing.Color.LightSkyBlue
GaugeSection41.PointerFillColor.Color2 = System.Drawing.Color.DarkBlue
GaugeSection41.Tooltip = "Blue Section Tooltip"
GaugeSection42.CapFillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
GaugeSection42.CapFillColor.Color2 = System.Drawing.Color.DarkGreen
GaugeSection42.EndValue = 20
GaugeSection42.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection42.LabelColor = System.Drawing.Color.DarkGreen
GaugeSection42.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.DarkOliveGreen
GaugeSection42.MajorTickMarkFillColor.BorderWidth = 1
GaugeSection42.MajorTickMarkFillColor.Color1 = System.Drawing.Color.White
GaugeSection42.MajorTickMarkFillColor.Color2 = System.Drawing.Color.DarkGreen
GaugeSection42.Name = "Section2"
GaugeSection42.PointerFillColor.BorderColor = System.Drawing.Color.DimGray
GaugeSection42.PointerFillColor.BorderWidth = 1
GaugeSection42.PointerFillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
GaugeSection42.PointerFillColor.Color2 = System.Drawing.Color.Green
GaugeSection42.ScaleOffset = 0.057!
GaugeSection42.StartValue = 0
GaugeSection42.Tooltip = "Lime Section Tooltip"
GaugeSection42.Width = 0.076!
GaugeSection43.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugeSection43.CapFillColor.Color2 = System.Drawing.Color.DarkMagenta
GaugeSection43.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
GaugeSection43.EndValue = 80
GaugeSection43.FillColor.Color1 = System.Drawing.Color.DarkMagenta
GaugeSection43.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
GaugeSection43.LabelColor = System.Drawing.Color.DarkMagenta
GaugeSection43.Name = "Section3"
GaugeSection43.PointerFillColor.BorderColor = System.Drawing.Color.DimGray
GaugeSection43.PointerFillColor.BorderWidth = 1
GaugeSection43.PointerFillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
GaugeSection43.PointerFillColor.Color2 = System.Drawing.Color.Purple
GaugeSection43.ScaleOffset = 0.051!
GaugeSection43.StartValue = 55
GaugeSection43.Tooltip = "Magenta Section Tooltip"
GaugeSection43.Width = 0.076!
GaugeCircularScale16.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection41, GaugeSection42, GaugeSection43})
GaugeCircularScale16.Width = 0.021!
Me.gcCircular3.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale16})
GradientFillColor52.BorderColor = System.Drawing.Color.DimGray
GradientFillColor52.Color1 = System.Drawing.Color.DimGray
GradientFillColor52.Color2 = System.Drawing.Color.WhiteSmoke
GradientFillColor52.GradientAngle = 45
Me.gcCircular3.Frame.BackColor = GradientFillColor52
GradientFillColor53.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor53.Color2 = System.Drawing.Color.DimGray
Me.gcCircular3.Frame.FrameColor = GradientFillColor53
Me.gcCircular3.Frame.InnerBevel = 0.016!
Me.gcCircular3.Frame.OuterBevel = 0.061!
Me.gcCircular3.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
Me.gcCircular3.Location = New System.Drawing.Point(50, 51)
Me.gcCircular3.Name = "gcCircular3"
Me.gcCircular3.Size = New System.Drawing.Size(500, 500)
Me.gcCircular3.TabIndex = 1
'
'circularTab3
'
Me.circularTab3.AttachedControl = Me.superTabControlPanel6
Me.circularTab3.GlobalItem = false
Me.circularTab3.Name = "circularTab3"
Me.circularTab3.Text = "3"
'
'CTabSamples
'
Me.CTabSamples.AttachedControl = Me.superTabControlPanel3
Me.CTabSamples.GlobalItem = false
Me.CTabSamples.Name = "CTabSamples"
Me.CTabSamples.Text = "Circular"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Gauge Samples"
'
'superTabControlPanel1
'
Me.superTabControlPanel1.Controls.Add(Me.linkLabel1)
Me.superTabControlPanel1.Controls.Add(Me.textBox35)
Me.superTabControlPanel1.Controls.Add(Me.label36)
Me.superTabControlPanel1.Controls.Add(Me.textBox16)
Me.superTabControlPanel1.Controls.Add(Me.label17)
Me.superTabControlPanel1.Controls.Add(Me.textBox15)
Me.superTabControlPanel1.Controls.Add(Me.label16)
Me.superTabControlPanel1.Controls.Add(Me.textBox14)
Me.superTabControlPanel1.Controls.Add(Me.label15)
Me.superTabControlPanel1.Controls.Add(Me.textBox13)
Me.superTabControlPanel1.Controls.Add(Me.label14)
Me.superTabControlPanel1.Controls.Add(Me.textBox12)
Me.superTabControlPanel1.Controls.Add(Me.label13)
Me.superTabControlPanel1.Controls.Add(Me.textBox11)
Me.superTabControlPanel1.Controls.Add(Me.label12)
Me.superTabControlPanel1.Controls.Add(Me.label6)
Me.superTabControlPanel1.Controls.Add(Me.label11)
Me.superTabControlPanel1.Controls.Add(Me.textBox10)
Me.superTabControlPanel1.Controls.Add(Me.label10)
Me.superTabControlPanel1.Controls.Add(Me.textBox9)
Me.superTabControlPanel1.Controls.Add(Me.label9)
Me.superTabControlPanel1.Controls.Add(Me.textBox8)
Me.superTabControlPanel1.Controls.Add(Me.label8)
Me.superTabControlPanel1.Controls.Add(Me.textBox7)
Me.superTabControlPanel1.Controls.Add(Me.label7)
Me.superTabControlPanel1.Controls.Add(Me.textBox6)
Me.superTabControlPanel1.Controls.Add(Me.textBox5)
Me.superTabControlPanel1.Controls.Add(Me.label5)
Me.superTabControlPanel1.Controls.Add(Me.textBox4)
Me.superTabControlPanel1.Controls.Add(Me.label4)
Me.superTabControlPanel1.Controls.Add(Me.textBox3)
Me.superTabControlPanel1.Controls.Add(Me.label3)
Me.superTabControlPanel1.Controls.Add(Me.textBox2)
Me.superTabControlPanel1.Controls.Add(Me.label2)
Me.superTabControlPanel1.Controls.Add(Me.textBox1)
Me.superTabControlPanel1.Controls.Add(Me.label1)
Me.superTabControlPanel1.Controls.Add(Me.gcCircularElements)
Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel1.Location = New System.Drawing.Point(0, 35)
Me.superTabControlPanel1.Name = "superTabControlPanel1"
Me.superTabControlPanel1.Size = New System.Drawing.Size(820, 603)
Me.superTabControlPanel1.TabIndex = 1
Me.superTabControlPanel1.TabItem = Me.CTabElements
Me.superTabControlPanel1.Visible = false
'
'linkLabel1
'
Me.linkLabel1.AutoSize = true
Me.linkLabel1.BackColor = System.Drawing.Color.White
Me.linkLabel1.Location = New System.Drawing.Point(12, 581)
Me.linkLabel1.Name = "linkLabel1"
Me.linkLabel1.Size = New System.Drawing.Size(144, 13)
Me.linkLabel1.TabIndex = 36
Me.linkLabel1.TabStop = true
Me.linkLabel1.Text = "Gauge Getting Started Guide"
'
'textBox35
'
Me.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox35.Location = New System.Drawing.Point(9, 348)
Me.textBox35.Multiline = true
Me.textBox35.Name = "textBox35"
Me.textBox35.Size = New System.Drawing.Size(89, 36)
Me.textBox35.TabIndex = 35
Me.textBox35.Text = "Custom"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Text"
Me.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label36
'
Me.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label36.Location = New System.Drawing.Point(105, 366)
Me.label36.Name = "label36"
Me.label36.Size = New System.Drawing.Size(220, 2)
Me.label36.TabIndex = 34
Me.label36.Text = "label36"
'
'textBox16
'
Me.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox16.Location = New System.Drawing.Point(19, 212)
Me.textBox16.Name = "textBox16"
Me.textBox16.Size = New System.Drawing.Size(89, 16)
Me.textBox16.TabIndex = 33
Me.textBox16.Text = "Scale"
Me.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label17
'
Me.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label17.Location = New System.Drawing.Point(111, 222)
Me.label17.Name = "label17"
Me.label17.Size = New System.Drawing.Size(131, 2)
Me.label17.TabIndex = 32
Me.label17.Text = "label17"
'
'textBox15
'
Me.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox15.Location = New System.Drawing.Point(115, 70)
Me.textBox15.Multiline = true
Me.textBox15.Name = "textBox15"
Me.textBox15.Size = New System.Drawing.Size(89, 39)
Me.textBox15.TabIndex = 31
Me.textBox15.Text = "Frame"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Inner Bevel"
Me.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label16
'
Me.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label16.Location = New System.Drawing.Point(211, 90)
Me.label16.Name = "label16"
Me.label16.Size = New System.Drawing.Size(161, 2)
Me.label16.TabIndex = 30
Me.label16.Text = "label16"
'
'textBox14
'
Me.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox14.Location = New System.Drawing.Point(632, 60)
Me.textBox14.Multiline = true
Me.textBox14.Name = "textBox14"
Me.textBox14.Size = New System.Drawing.Size(103, 38)
Me.textBox14.TabIndex = 29
Me.textBox14.Text = "Frame"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Outer Bevel"
'
'label15
'
Me.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label15.Location = New System.Drawing.Point(465, 76)
Me.label15.Name = "label15"
Me.label15.Size = New System.Drawing.Size(161, 2)
Me.label15.TabIndex = 28
Me.label15.Text = "label15"
'
'textBox13
'
Me.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox13.Location = New System.Drawing.Point(686, 435)
Me.textBox13.Name = "textBox13"
Me.textBox13.Size = New System.Drawing.Size(88, 16)
Me.textBox13.TabIndex = 27
Me.textBox13.Text = "Scale Label"
'
'label14
'
Me.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label14.Location = New System.Drawing.Point(480, 444)
Me.label14.Name = "label14"
Me.label14.Size = New System.Drawing.Size(201, 2)
Me.label14.TabIndex = 26
Me.label14.Text = "label14"
'
'textBox12
'
Me.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox12.Location = New System.Drawing.Point(724, 306)
Me.textBox12.Name = "textBox12"
Me.textBox12.Size = New System.Drawing.Size(83, 16)
Me.textBox12.TabIndex = 25
Me.textBox12.Text = "Needle Cap"
'
'label13
'
Me.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label13.Location = New System.Drawing.Point(408, 315)
Me.label13.Name = "label13"
Me.label13.Size = New System.Drawing.Size(311, 2)
Me.label13.TabIndex = 24
Me.label13.Text = "label13"
'
'textBox11
'
Me.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox11.Location = New System.Drawing.Point(27, 389)
Me.textBox11.Name = "textBox11"
Me.textBox11.Size = New System.Drawing.Size(89, 16)
Me.textBox11.TabIndex = 23
Me.textBox11.Text = "Section"
Me.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label12
'
Me.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label12.Location = New System.Drawing.Point(122, 398)
Me.label12.Name = "label12"
Me.label12.Size = New System.Drawing.Size(131, 2)
Me.label12.TabIndex = 22
Me.label12.Text = "label12"
'
'label6
'
Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label6.Location = New System.Drawing.Point(454, 484)
Me.label6.Name = "label6"
Me.label6.Size = New System.Drawing.Size(201, 2)
Me.label6.TabIndex = 11
Me.label6.Text = "label6"
'
'label11
'
Me.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label11.Location = New System.Drawing.Point(368, 499)
Me.label11.Name = "label11"
Me.label11.Size = New System.Drawing.Size(2, 20)
Me.label11.TabIndex = 21
Me.label11.Text = "label11"
'
'textBox10
'
Me.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox10.Location = New System.Drawing.Point(90, 435)
Me.textBox10.Multiline = true
Me.textBox10.Name = "textBox10"
Me.textBox10.Size = New System.Drawing.Size(55, 40)
Me.textBox10.TabIndex = 20
Me.textBox10.Text = "Pointer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Bar)"
Me.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label10
'
Me.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label10.Location = New System.Drawing.Point(148, 454)
Me.label10.Name = "label10"
Me.label10.Size = New System.Drawing.Size(131, 2)
Me.label10.TabIndex = 19
Me.label10.Text = "label10"
'
'textBox9
'
Me.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox9.Location = New System.Drawing.Point(72, 507)
Me.textBox9.Name = "textBox9"
Me.textBox9.Size = New System.Drawing.Size(89, 16)
Me.textBox9.TabIndex = 18
Me.textBox9.Text = "Minimum Pin"
Me.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label9
'
Me.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label9.Location = New System.Drawing.Point(168, 517)
Me.label9.Name = "label9"
Me.label9.Size = New System.Drawing.Size(201, 2)
Me.label9.TabIndex = 17
Me.label9.Text = "label9"
'
'textBox8
'
Me.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox8.Location = New System.Drawing.Point(45, 281)
Me.textBox8.Multiline = true
Me.textBox8.Name = "textBox8"
Me.textBox8.Size = New System.Drawing.Size(61, 37)
Me.textBox8.TabIndex = 16
Me.textBox8.Text = "Pointer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Needle)"
Me.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label8
'
Me.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label8.Location = New System.Drawing.Point(112, 301)
Me.label8.Name = "label8"
Me.label8.Size = New System.Drawing.Size(161, 2)
Me.label8.TabIndex = 15
Me.label8.Text = "label8"
'
'textBox7
'
Me.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox7.Location = New System.Drawing.Point(713, 220)
Me.textBox7.Name = "textBox7"
Me.textBox7.Size = New System.Drawing.Size(54, 16)
Me.textBox7.TabIndex = 14
Me.textBox7.Text = "Image"
'
'label7
'
Me.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label7.Location = New System.Drawing.Point(443, 228)
Me.label7.Name = "label7"
Me.label7.Size = New System.Drawing.Size(266, 2)
Me.label7.TabIndex = 13
Me.label7.Text = "label7"
'
'textBox6
'
Me.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox6.Location = New System.Drawing.Point(662, 476)
Me.textBox6.Name = "textBox6"
Me.textBox6.Size = New System.Drawing.Size(88, 16)
Me.textBox6.TabIndex = 12
Me.textBox6.Text = "Maximum Pin"
'
'textBox5
'
Me.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox5.Location = New System.Drawing.Point(714, 375)
Me.textBox5.Multiline = true
Me.textBox5.Name = "textBox5"
Me.textBox5.Size = New System.Drawing.Size(54, 38)
Me.textBox5.TabIndex = 10
Me.textBox5.Text = "Pointer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Marker)"
Me.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label5
'
Me.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label5.Location = New System.Drawing.Point(598, 389)
Me.label5.Name = "label5"
Me.label5.Size = New System.Drawing.Size(111, 2)
Me.label5.TabIndex = 9
Me.label5.Text = "label5"
'
'textBox4
'
Me.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox4.Location = New System.Drawing.Point(724, 270)
Me.textBox4.Name = "textBox4"
Me.textBox4.Size = New System.Drawing.Size(54, 16)
Me.textBox4.TabIndex = 8
Me.textBox4.Text = "Range"
'
'label4
'
Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label4.Location = New System.Drawing.Point(509, 278)
Me.label4.Name = "label4"
Me.label4.Size = New System.Drawing.Size(211, 2)
Me.label4.TabIndex = 7
Me.label4.Text = "label4"
'
'textBox3
'
Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox3.Location = New System.Drawing.Point(704, 174)
Me.textBox3.Name = "textBox3"
Me.textBox3.Size = New System.Drawing.Size(103, 16)
Me.textBox3.TabIndex = 6
Me.textBox3.Text = "Minor Tickmark"
'
'label3
'
Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label3.Location = New System.Drawing.Point(539, 183)
Me.label3.Name = "label3"
Me.label3.Size = New System.Drawing.Size(161, 2)
Me.label3.TabIndex = 5
Me.label3.Text = "label3"
'
'textBox2
'
Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox2.Location = New System.Drawing.Point(681, 145)
Me.textBox2.Name = "textBox2"
Me.textBox2.Size = New System.Drawing.Size(103, 16)
Me.textBox2.TabIndex = 4
Me.textBox2.Text = "Major Tickmark"
'
'label2
'
Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label2.Location = New System.Drawing.Point(514, 154)
Me.label2.Name = "label2"
Me.label2.Size = New System.Drawing.Size(161, 2)
Me.label2.TabIndex = 3
Me.label2.Text = "label2"
'
'textBox1
'
Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox1.Location = New System.Drawing.Point(32, 129)
Me.textBox1.Name = "textBox1"
Me.textBox1.Size = New System.Drawing.Size(89, 16)
Me.textBox1.TabIndex = 2
Me.textBox1.Text = "Custom Label"
Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label1
'
Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label1.Location = New System.Drawing.Point(127, 139)
Me.label1.Name = "label1"
Me.label1.Size = New System.Drawing.Size(161, 2)
Me.label1.TabIndex = 1
Me.label1.Text = "label1"
'
'gcCircularElements
'
Me.gcCircularElements.BackColor = System.Drawing.Color.White
GaugeCustomLabel14.Layout.AdaptiveLabel = true
GaugeCustomLabel14.Layout.ForeColor = System.Drawing.Color.DarkRed
GaugeCustomLabel14.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCustomLabel14.Name = "Label1"
GaugeCustomLabel14.Text = "Custom Label"
GaugeCustomLabel14.TickMark.Layout.Image = CType(resources.GetObject("resource.Image2"),System.Drawing.Image)
GaugeCustomLabel14.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Diamond
GaugeCustomLabel14.TickMark.Layout.Width = 0.14!
GaugeCustomLabel14.Value = 40
GaugeCircularScale23.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel14})
GaugeCircularScale23.MaxPin.Name = "MaxPin"
GaugeCircularScale23.MinPin.Name = "MinPin"
GaugeCircularScale23.Name = "Scale1"
GaugePointer54.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer54.CapFillColor.BorderWidth = 1
GaugePointer54.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer54.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer54.CapOuterBevel = 0.076!
GaugePointer54.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer54.FillColor.BorderWidth = 1
GaugePointer54.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer54.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer54.Length = 0.411!
GaugePointer54.Name = "Needle"
GaugePointer54.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer54.Value = 25
GaugePointer55.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer55.CapFillColor.BorderWidth = 1
GaugePointer55.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer55.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer55.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer55.FillColor.BorderWidth = 1
GaugePointer55.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer55.Name = "Marker"
GaugePointer55.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer55.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer55.ThermoBackColor.BorderWidth = 1
GaugePointer55.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer55.Value = 85
GaugePointer56.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer56.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer56.CapFillColor.BorderWidth = 1
GaugePointer56.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer56.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer56.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer56.FillColor.BorderWidth = 1
GaugePointer56.FillColor.Color1 = System.Drawing.Color.DarkCyan
GaugePointer56.FillColor.Color2 = System.Drawing.Color.Cyan
GaugePointer56.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer56.Name = "Bar"
GaugePointer56.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer56.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer56.ThermoBackColor.BorderWidth = 1
GaugePointer56.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer56.UnderTickMarks = true
GaugePointer56.Value = 7.5
GaugeCircularScale23.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer54, GaugePointer55, GaugePointer56})
GaugeCircularScale23.Radius = 0.334!
GaugeRange29.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange29.FillColor.BorderWidth = 1
GaugeRange29.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange29.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange29.Name = "Range1"
GaugeRange29.ScaleOffset = 0.28!
GaugeRange29.StartValue = 70
GaugeCircularScale23.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange29})
GaugeSection56.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection56.FillColor.Color2 = System.Drawing.Color.Purple
GaugeSection56.Name = "Section1"
GaugeSection57.EndValue = 20
GaugeSection57.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection57.Name = "Section2"
GaugeSection57.StartValue = 0
GaugeCircularScale23.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection56, GaugeSection57})
Me.gcCircularElements.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale23})
Me.gcCircularElements.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
GaugeText16.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText16.Location = CType(resources.GetObject("GaugeText16.Location"),System.Drawing.PointF)
GaugeText16.Name = "Text1"
GaugeImage5.Image = CType(resources.GetObject("GaugeImage5.Image"),System.Drawing.Image)
GaugeImage5.Location = CType(resources.GetObject("GaugeImage5.Location"),System.Drawing.PointF)
GaugeImage5.Name = "Image1"
GaugeImage5.Size = New System.Drawing.SizeF(0.1!, 0.1!)
Me.gcCircularElements.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText16, GaugeImage5})
Me.gcCircularElements.Location = New System.Drawing.Point(144, 54)
Me.gcCircularElements.Name = "gcCircularElements"
Me.gcCircularElements.Size = New System.Drawing.Size(524, 522)
Me.gcCircularElements.TabIndex = 0
'
'CTabElements
'
Me.CTabElements.AttachedControl = Me.superTabControlPanel1
Me.CTabElements.GlobalItem = false
Me.CTabElements.Name = "CTabElements"
Me.CTabElements.Text = "Circular"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Gauge Elements"
'
'superTabControlPanel22
'
Me.superTabControlPanel22.Controls.Add(Me.superTabControl4)
Me.superTabControlPanel22.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel22.Location = New System.Drawing.Point(0, 35)
Me.superTabControlPanel22.Name = "superTabControlPanel22"
Me.superTabControlPanel22.Size = New System.Drawing.Size(820, 603)
Me.superTabControlPanel22.TabIndex = 0
Me.superTabControlPanel22.TabItem = Me.TabEvents
'
'superTabControl4
'
Me.superTabControl4.AntiAlias = true
'
'
'
'
'
'
Me.superTabControl4.ControlBox.CloseBox.Name = ""
'
'
'
Me.superTabControl4.ControlBox.MenuBox.Name = ""
Me.superTabControl4.ControlBox.Name = ""
Me.superTabControl4.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl4.ControlBox.MenuBox, Me.superTabControl4.ControlBox.CloseBox})
Me.superTabControl4.Controls.Add(Me.superTabControlPanel23)
Me.superTabControl4.Controls.Add(Me.superTabControlPanel26)
Me.superTabControl4.Controls.Add(Me.superTabControlPanel25)
Me.superTabControl4.Controls.Add(Me.superTabControlPanel24)
Me.superTabControl4.Controls.Add(Me.superTabControlPanel21)
Me.superTabControl4.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControl4.FixedTabSize = New System.Drawing.Size(0, 40)
Me.superTabControl4.Location = New System.Drawing.Point(0, 0)
Me.superTabControl4.Name = "superTabControl4"
Me.superTabControl4.ReorderTabsEnabled = true
Me.superTabControl4.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
Me.superTabControl4.SelectedTabIndex = 0
Me.superTabControl4.Size = New System.Drawing.Size(820, 603)
Me.superTabControl4.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
Me.superTabControl4.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.superTabControl4.TabIndex = 0
Me.superTabControl4.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabPointerChange, Me.tabEnterLeave, Me.tabHitTesting, Me.tabLimits, Me.tabUserRendering})
Me.superTabControl4.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.WinMediaPlayer12
Me.superTabControl4.Text = "superTabControl4"
'
'superTabControlPanel21
'
Me.superTabControlPanel21.Controls.Add(Me.labelX13)
Me.superTabControlPanel21.Controls.Add(Me.gcPointerChange)
Me.superTabControlPanel21.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel21.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel21.Name = "superTabControlPanel21"
Me.superTabControlPanel21.Size = New System.Drawing.Size(723, 603)
Me.superTabControlPanel21.TabIndex = 0
Me.superTabControlPanel21.TabItem = Me.tabPointerChange
'
'labelX13
'
Me.labelX13.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX13.BackgroundStyle.Class = ""
Me.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX13.Location = New System.Drawing.Point(461, 36)
Me.labelX13.Name = "labelX13"
Me.labelX13.Size = New System.Drawing.Size(241, 152)
Me.labelX13.TabIndex = 22
Me.labelX13.Text = resources.GetString("labelX13.Text")
Me.labelX13.WordWrap = true
'
'gcPointerChange
'
Me.gcPointerChange.BackColor = System.Drawing.Color.AliceBlue
Me.gcPointerChange.Frame.AddGlassEffect = true
GradientFillColor9.BorderColor = System.Drawing.Color.Gray
GradientFillColor9.BorderWidth = 1
GradientFillColor9.Color1 = System.Drawing.Color.DarkOliveGreen
GradientFillColor9.Color2 = System.Drawing.Color.White
GradientFillColor9.GradientAngle = 45
Me.gcPointerChange.Frame.BackColor = GradientFillColor9
Me.gcPointerChange.Frame.BackSigmaFocus = 0.058!
GradientFillColor10.BorderColor = System.Drawing.Color.DimGray
GradientFillColor10.BorderWidth = 1
GradientFillColor10.Color1 = System.Drawing.Color.LightGoldenrodYellow
GradientFillColor10.Color2 = System.Drawing.Color.Black
GradientFillColor10.GradientAngle = 45
GradientFillColor10.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
Me.gcPointerChange.Frame.FrameColor = GradientFillColor10
Me.gcPointerChange.Frame.InnerBevel = 0.011!
Me.gcPointerChange.Frame.RoundRectangleArc = 0.5!
Me.gcPointerChange.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular
GaugeText2.Angle = 270!
GaugeText2.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText2.Location = CType(resources.GetObject("GaugeText2.Location"),System.Drawing.PointF)
GaugeText2.Name = "Label"
GaugeText2.Size = New System.Drawing.SizeF(0.8547009!, 0.1025641!)
GaugeText2.Text = "Monthly Sales Level (th. USD)"
GaugeText3.Angle = 270!
GaugeText3.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText3.ForeColor = System.Drawing.Color.MediumVioletRed
GaugeText3.Location = CType(resources.GetObject("GaugeText3.Location"),System.Drawing.PointF)
GaugeText3.Name = "Planned"
GaugeText3.Size = New System.Drawing.SizeF(0.9137931!, 0.1293103!)
GaugeText3.Text = "(Planned $65,000)"
Me.gcPointerChange.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText2, GaugeText3})
GaugeLinearScale1.BorderWidth = 1
GaugeCustomLabel2.Layout.Angle = 270!
GaugeCustomLabel2.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!)
GaugeCustomLabel2.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Center
GaugeCustomLabel2.Name = "Label1"
GaugeCustomLabel2.Text = "Good"
GaugeCustomLabel2.TickMark.Visible = false
GaugeCustomLabel2.Value = 47.5
GaugeCustomLabel3.Layout.Angle = 270!
GaugeCustomLabel3.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!)
GaugeCustomLabel3.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Center
GaugeCustomLabel3.Name = "Label2"
GaugeCustomLabel3.Text = "Excellent"
GaugeCustomLabel3.TickMark.Visible = false
GaugeCustomLabel3.Value = 82.5
GaugeCustomLabel4.Layout.Angle = 270!
GaugeCustomLabel4.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!)
GaugeCustomLabel4.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Center
GaugeCustomLabel4.Name = "Label3"
GaugeCustomLabel4.Text = "Poor"
GaugeCustomLabel4.TickMark.Visible = false
GaugeCustomLabel4.Value = 22.5
GaugeLinearScale1.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel2, GaugeCustomLabel3, GaugeCustomLabel4})
GaugeLinearScale1.Labels.Layout.ScaleOffset = 0.03!
GaugeLinearScale1.Location = CType(resources.GetObject("GaugeLinearScale1.Location"),System.Drawing.PointF)
GradientFillColor11.BorderColor = System.Drawing.Color.DimGray
GradientFillColor11.Color1 = System.Drawing.Color.Black
GaugeLinearScale1.MajorTickMarks.Layout.FillColor = GradientFillColor11
GaugeLinearScale1.MajorTickMarks.Layout.Length = 0.047!
GaugeLinearScale1.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale1.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale1.MajorTickMarks.Layout.Width = 0.021!
GaugeLinearScale1.MaxPin.EndOffset = 0.028!
GaugeLinearScale1.MaxPin.Name = "MaxPin"
GaugeLinearScale1.MaxPin.Visible = false
GradientFillColor12.BorderColor = System.Drawing.Color.DimGray
GradientFillColor12.Color1 = System.Drawing.Color.Black
GaugeLinearScale1.MinorTickMarks.Layout.FillColor = GradientFillColor12
GaugeLinearScale1.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale1.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale1.MinorTickMarks.Visible = false
GaugeLinearScale1.MinPin.EndOffset = 0.028!
GaugeLinearScale1.MinPin.Name = "MinPin"
GaugeLinearScale1.MinPin.Visible = false
GaugeLinearScale1.Name = "Scale1"
GaugeLinearScale1.Orientation = System.Windows.Forms.Orientation.Vertical
GaugePointer11.AllowUserChange = true
GaugePointer11.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer11.CapFillColor.BorderWidth = 1
GaugePointer11.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer11.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer11.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer11.FillColor.BorderWidth = 1
GaugePointer11.FillColor.Color1 = System.Drawing.Color.White
GaugePointer11.FillColor.Color2 = System.Drawing.Color.Magenta
GaugePointer11.Length = 0.2!
GaugePointer11.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugePointer11.Name = "Pointer1"
GaugePointer11.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer11.ScaleOffset = -0.088!
GaugePointer11.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer11.ThermoBackColor.BorderWidth = 1
GaugePointer11.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer11.Value = 65
GaugePointer11.Width = 0.2!
GaugeLinearScale1.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer11})
GaugeSection9.EndValue = 25
GaugeSection9.FillColor.Color1 = System.Drawing.Color.DarkGray
GaugeSection9.Name = "Section0"
GaugeSection9.StartValue = 0
GaugeSection10.EndValue = 30
GaugeSection10.FillColor.Color1 = System.Drawing.Color.OrangeRed
GaugeSection10.Name = "Section1"
GaugeSection10.StartValue = 15
GaugeSection11.EndValue = 65
GaugeSection11.FillColor.Color1 = System.Drawing.Color.Yellow
GaugeSection11.Name = "Section2"
GaugeSection11.StartValue = 30
GaugeSection12.EndValue = 100
GaugeSection12.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection12.Name = "Section3"
GaugeSection12.StartValue = 65
GaugeLinearScale1.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection9, GaugeSection10, GaugeSection11, GaugeSection12})
GaugeLinearScale1.Size = New System.Drawing.SizeF(0.45!, 0.8!)
GaugeLinearScale1.Width = 0.4!
Me.gcPointerChange.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale1})
Me.gcPointerChange.Location = New System.Drawing.Point(108, 36)
Me.gcPointerChange.Name = "gcPointerChange"
Me.gcPointerChange.Size = New System.Drawing.Size(324, 520)
Me.gcPointerChange.TabIndex = 3
'
'tabPointerChange
'
Me.tabPointerChange.AttachedControl = Me.superTabControlPanel21
Me.tabPointerChange.GlobalItem = false
Me.tabPointerChange.Name = "tabPointerChange"
Me.tabPointerChange.Text = "Pointer Change"
'
'superTabControlPanel26
'
Me.superTabControlPanel26.Controls.Add(Me.labelX29)
Me.superTabControlPanel26.Controls.Add(Me.labelX28)
Me.superTabControlPanel26.Controls.Add(Me.cbSetLimits)
Me.superTabControlPanel26.Controls.Add(Me.labelX27)
Me.superTabControlPanel26.Controls.Add(Me.labelX26)
Me.superTabControlPanel26.Controls.Add(Me.btnAuto2)
Me.superTabControlPanel26.Controls.Add(Me.cbSliderDampen2)
Me.superTabControlPanel26.Controls.Add(Me.btnMin2)
Me.superTabControlPanel26.Controls.Add(Me.btnMax2)
Me.superTabControlPanel26.Controls.Add(Me.btnMinus10)
Me.superTabControlPanel26.Controls.Add(Me.btnPlus20)
Me.superTabControlPanel26.Controls.Add(Me.gcScaleLimits)
Me.superTabControlPanel26.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel26.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel26.Name = "superTabControlPanel26"
Me.superTabControlPanel26.Size = New System.Drawing.Size(726, 603)
Me.superTabControlPanel26.TabIndex = 0
Me.superTabControlPanel26.TabItem = Me.tabLimits
'
'labelX29
'
Me.labelX29.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX29.BackgroundStyle.Class = ""
Me.labelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX29.Location = New System.Drawing.Point(512, 229)
Me.labelX29.Name = "labelX29"
Me.labelX29.Size = New System.Drawing.Size(199, 89)
Me.labelX29.TabIndex = 29
Me.labelX29.Text = "Check the box below to set the MinLimit to -150 and the MaxLimit to 100.  Uncheck"& _ 
    " it to return it to its default empty state."
Me.labelX29.WordWrap = true
'
'labelX28
'
Me.labelX28.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX28.BackgroundStyle.Class = ""
Me.labelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX28.Location = New System.Drawing.Point(461, 109)
Me.labelX28.Name = "labelX28"
Me.labelX28.Size = New System.Drawing.Size(262, 62)
Me.labelX28.TabIndex = 28
Me.labelX28.Text = "The MinLimit and MaxLimit values enable the scale to display much more data by pe"& _ 
    "rmitting it to scroll within that range."
Me.labelX28.WordWrap = true
'
'cbSetLimits
'
Me.cbSetLimits.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbSetLimits.BackgroundStyle.Class = ""
Me.cbSetLimits.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbSetLimits.Location = New System.Drawing.Point(572, 324)
Me.cbSetLimits.Name = "cbSetLimits"
Me.cbSetLimits.Size = New System.Drawing.Size(120, 46)
Me.cbSetLimits.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbSetLimits.TabIndex = 27
Me.cbSetLimits.Text = "Use Extended"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Scale Limits"
'
'labelX27
'
Me.labelX27.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX27.BackgroundStyle.Class = ""
Me.labelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX27.Location = New System.Drawing.Point(385, 20)
Me.labelX27.Name = "labelX27"
Me.labelX27.Size = New System.Drawing.Size(338, 74)
Me.labelX27.TabIndex = 26
Me.labelX27.Text = "Each Scale has a displayable MinValue and MaxValue range. In this example our ini"& _ 
    "tial MinValue is 0 and the MaxValue is 50. Each Scale can also have a MinLimit a"& _ 
    "nd MaxLimit range."
Me.labelX27.WordWrap = true
'
'labelX26
'
Me.labelX26.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX26.BackgroundStyle.Class = ""
Me.labelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX26.Location = New System.Drawing.Point(413, 542)
Me.labelX26.Name = "labelX26"
Me.labelX26.Size = New System.Drawing.Size(76, 23)
Me.labelX26.TabIndex = 25
Me.labelX26.Text = "(Dampening)"
Me.labelX26.TextAlignment = System.Drawing.StringAlignment.Center
'
'btnAuto2
'
Me.btnAuto2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnAuto2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnAuto2.Location = New System.Drawing.Point(463, 484)
Me.btnAuto2.Name = "btnAuto2"
Me.btnAuto2.Size = New System.Drawing.Size(75, 23)
Me.btnAuto2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnAuto2.TabIndex = 24
Me.btnAuto2.Text = "Auto"
'
'cbSliderDampen2
'
Me.cbSliderDampen2.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbSliderDampen2.BackgroundStyle.Class = ""
Me.cbSliderDampen2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbSliderDampen2.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Bottom
Me.cbSliderDampen2.LabelWidth = 50
Me.cbSliderDampen2.Location = New System.Drawing.Point(495, 538)
Me.cbSliderDampen2.Maximum = 30
Me.cbSliderDampen2.Name = "cbSliderDampen2"
Me.cbSliderDampen2.Size = New System.Drawing.Size(204, 46)
Me.cbSliderDampen2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbSliderDampen2.TabIndex = 23
Me.cbSliderDampen2.TabStop = false
Me.cbSliderDampen2.Text = "2"
Me.cbSliderDampen2.Value = 2
'
'btnMin2
'
Me.btnMin2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnMin2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnMin2.Location = New System.Drawing.Point(631, 453)
Me.btnMin2.Name = "btnMin2"
Me.btnMin2.Size = New System.Drawing.Size(75, 23)
Me.btnMin2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnMin2.TabIndex = 22
Me.btnMin2.Text = "Min"
'
'btnMax2
'
Me.btnMax2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnMax2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnMax2.Location = New System.Drawing.Point(631, 482)
Me.btnMax2.Name = "btnMax2"
Me.btnMax2.Size = New System.Drawing.Size(75, 23)
Me.btnMax2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnMax2.TabIndex = 21
Me.btnMax2.Text = "Max"
'
'btnMinus10
'
Me.btnMinus10.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnMinus10.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnMinus10.Location = New System.Drawing.Point(550, 482)
Me.btnMinus10.Name = "btnMinus10"
Me.btnMinus10.Size = New System.Drawing.Size(75, 23)
Me.btnMinus10.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnMinus10.TabIndex = 20
Me.btnMinus10.Text = "-10"
'
'btnPlus20
'
Me.btnPlus20.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnPlus20.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnPlus20.Location = New System.Drawing.Point(550, 453)
Me.btnPlus20.Name = "btnPlus20"
Me.btnPlus20.Size = New System.Drawing.Size(75, 23)
Me.btnPlus20.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnPlus20.TabIndex = 19
Me.btnPlus20.Text = "+20"
'
'gcScaleLimits
'
Me.gcScaleLimits.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale2.BorderColor = System.Drawing.Color.DimGray
GaugeCustomLabel1.Layout.AdaptiveLabel = true
GaugeCustomLabel1.Name = "Label1"
GaugeCustomLabel1.Text = "This is cool"
GaugeCustomLabel1.Value = -80
GaugeCircularScale2.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel1})
GaugeCircularScale2.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale2.Labels.Layout.RotateLabel = false
GaugeCircularScale2.MajorTickMarks.IntervalOffset = 10
GaugeCircularScale2.MaxPin.EndOffset = 0.05!
GaugeCircularScale2.MaxPin.Label.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale2.MaxPin.Label.Layout.RotateLabel = false
GaugeCircularScale2.MaxPin.Label.Layout.ScaleOffset = -0.025!
GaugeCircularScale2.MaxPin.Label.Text = "Max"
GaugeCircularScale2.MaxPin.Name = "MaxPin"
GaugeCircularScale2.MaxValue = 50
GaugeCircularScale2.MinPin.EndOffset = 0.05!
GaugeCircularScale2.MinPin.Label.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale2.MinPin.Label.Layout.RotateLabel = false
GaugeCircularScale2.MinPin.Label.Layout.ScaleOffset = -0.025!
GaugeCircularScale2.MinPin.Label.Text = "Min"
GaugeCircularScale2.MinPin.Name = "MinPin"
GaugeCircularScale2.Name = "Scale1"
GaugePointer4.AllowUserChange = true
GaugePointer4.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer4.CapFillColor.BorderWidth = 1
GaugePointer4.CapFillColor.Color1 = System.Drawing.Color.White
GaugePointer4.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer4.CapFillColor.GradientAngle = 45
GaugePointer4.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer4.CapImage = CType(resources.GetObject("GaugePointer4.CapImage"),System.Drawing.Image)
GaugePointer4.CapWidth = 0.505!
GaugePointer4.DampeningSweepTime = 2
GaugePointer4.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer4.FillColor.BorderWidth = 1
GaugePointer4.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer))
GaugePointer4.FillColor.Color2 = System.Drawing.Color.Black
GaugePointer4.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer4.Length = 0.468!
GaugePointer4.Name = "Needle"
GaugePointer4.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4
GaugePointer4.RotateCap = true
GaugePointer4.ScaleOffset = -0.082!
GaugePointer4.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer4.Tooltip = "Black Needle"
GaugePointer4.Value = 30
GaugePointer4.Width = 0.117!
GaugeCircularScale2.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer4})
GaugeCircularScale2.Radius = 0.312!
GaugeRange2.EndValue = 90
GaugeRange2.EndWidth = 0.15!
GaugeRange2.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange2.FillColor.BorderWidth = 1
GaugeRange2.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange2.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange2.Name = "Range1"
GaugeRange2.ScaleOffset = 0.218!
GaugeRange2.StartValue = 20
GaugeRange2.Tooltip = "Range1"
GaugeRange3.EndValue = 70
GaugeRange3.EndWidth = 0.15!
GaugeRange3.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange3.FillColor.BorderWidth = 1
GaugeRange3.FillColor.Color1 = System.Drawing.Color.LightYellow
GaugeRange3.FillColor.Color2 = System.Drawing.Color.Green
GaugeRange3.Name = "Range2"
GaugeRange3.ScaleOffset = 0.397!
GaugeRange3.StartValue = 30
GaugeRange3.Tooltip = "Range2"
GaugeRange4.EndValue = 100
GaugeRange4.EndWidth = 0.15!
GaugeRange4.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange4.FillColor.BorderWidth = 1
GaugeRange4.FillColor.Color1 = System.Drawing.Color.DarkOrange
GaugeRange4.FillColor.Color2 = System.Drawing.Color.Snow
GaugeRange4.Name = "Range3"
GaugeRange4.ScaleOffset = 0.582!
GaugeRange4.StartValue = 60
GaugeRange4.Tooltip = "Range3"
GaugeRange5.EndValue = -150
GaugeRange5.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange5.FillColor.BorderWidth = 1
GaugeRange5.FillColor.Color1 = System.Drawing.Color.DarkRed
GaugeRange5.FillColor.Color2 = System.Drawing.Color.Yellow
GaugeRange5.Name = "Range4"
GaugeRange5.ScaleOffset = 0.218!
GaugeRange5.StartValue = -115
GaugeRange5.Tooltip = "Range4"
GaugeCircularScale2.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange2, GaugeRange3, GaugeRange4, GaugeRange5})
GaugeSection2.EndValue = 20
GaugeSection2.FillColor.Color1 = System.Drawing.Color.Yellow
GaugeSection2.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugeSection2.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.Gray
GaugeSection2.MajorTickMarkFillColor.BorderWidth = 1
GaugeSection2.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Goldenrod
GaugeSection2.MinorTickMarkFillColor.BorderColor = System.Drawing.Color.Gainsboro
GaugeSection2.MinorTickMarkFillColor.BorderWidth = 1
GaugeSection2.MinorTickMarkFillColor.Color1 = System.Drawing.Color.DarkOliveGreen
GaugeSection2.Name = "Section1"
GaugeSection2.StartValue = 0
GaugeSection3.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection3.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
GaugeSection3.Name = "Section2"
GaugeSection3.StartValue = 20
GaugeSection4.EndValue = -150
GaugeSection4.FillColor.Color1 = System.Drawing.Color.Orange
GaugeSection4.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
GaugeSection4.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugeSection4.Name = "Section3"
GaugeSection4.StartValue = 0
GaugeCircularScale2.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection2, GaugeSection3, GaugeSection4})
GaugeCircularScale2.StartAngle = 330!
GaugeCircularScale2.SweepAngle = 240!
Me.gcScaleLimits.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale2})
GradientFillColor3.Color1 = System.Drawing.Color.PaleTurquoise
GradientFillColor3.Color2 = System.Drawing.Color.SteelBlue
GradientFillColor3.GradientAngle = 45
Me.gcScaleLimits.Frame.BackColor = GradientFillColor3
GradientFillColor4.Color1 = System.Drawing.Color.LightBlue
GradientFillColor4.Color2 = System.Drawing.Color.Black
GradientFillColor4.GradientAngle = 45
Me.gcScaleLimits.Frame.FrameColor = GradientFillColor4
Me.gcScaleLimits.Frame.InnerBevel = 0.024!
Me.gcScaleLimits.Frame.OuterBevel = 0.024!
Me.gcScaleLimits.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
GaugeImage1.Image = CType(resources.GetObject("GaugeImage1.Image"),System.Drawing.Image)
GaugeImage1.Location = CType(resources.GetObject("GaugeImage1.Location"),System.Drawing.PointF)
GaugeImage1.Name = "Image1"
GaugeImage1.Size = New System.Drawing.SizeF(0.1!, 0.1!)
Me.gcScaleLimits.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeImage1})
Me.gcScaleLimits.Location = New System.Drawing.Point(40, 90)
Me.gcScaleLimits.Name = "gcScaleLimits"
Me.gcScaleLimits.Size = New System.Drawing.Size(466, 451)
Me.gcScaleLimits.TabIndex = 10
'
'tabLimits
'
Me.tabLimits.AttachedControl = Me.superTabControlPanel26
Me.tabLimits.GlobalItem = false
Me.tabLimits.Name = "tabLimits"
Me.tabLimits.Text = "Scale Limits"
'
'superTabControlPanel25
'
Me.superTabControlPanel25.Controls.Add(Me.btnRtb2Clear)
Me.superTabControlPanel25.Controls.Add(Me.rtb2)
Me.superTabControlPanel25.Controls.Add(Me.labelX4)
Me.superTabControlPanel25.Controls.Add(Me.gcHitTesting)
Me.superTabControlPanel25.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel25.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel25.Name = "superTabControlPanel25"
Me.superTabControlPanel25.Size = New System.Drawing.Size(726, 603)
Me.superTabControlPanel25.TabIndex = 0
Me.superTabControlPanel25.TabItem = Me.tabHitTesting
'
'btnRtb2Clear
'
Me.btnRtb2Clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnRtb2Clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnRtb2Clear.Location = New System.Drawing.Point(574, 546)
Me.btnRtb2Clear.Name = "btnRtb2Clear"
Me.btnRtb2Clear.Size = New System.Drawing.Size(75, 23)
Me.btnRtb2Clear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnRtb2Clear.TabIndex = 23
Me.btnRtb2Clear.Text = "Clear"
'
'rtb2
'
Me.rtb2.Location = New System.Drawing.Point(527, 100)
Me.rtb2.Name = "rtb2"
Me.rtb2.Size = New System.Drawing.Size(170, 434)
Me.rtb2.TabIndex = 22
Me.rtb2.Text = ""
'
'labelX4
'
Me.labelX4.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX4.BackgroundStyle.Class = ""
Me.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX4.Location = New System.Drawing.Point(356, 16)
Me.labelX4.Name = "labelX4"
Me.labelX4.Size = New System.Drawing.Size(347, 67)
Me.labelX4.TabIndex = 21
Me.labelX4.Text = "The mouse can be tracked over each individual Gauge Item. Move the mouse over the"& _ 
    " gauge for a demonstration of this.  Try clicking on the gauge image as well."
Me.labelX4.WordWrap = true
'
'gcHitTesting
'
Me.gcHitTesting.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale3.BorderWidth = 1
GaugeCircularScale3.MaxPin.Name = "MaxPin"
GaugeCircularScale3.MaxPin.Visible = false
GaugeCircularScale3.MinPin.EndOffset = 0.051!
GaugeCircularScale3.MinPin.Label.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
GaugeCircularScale3.MinPin.Label.Layout.ForeColor = System.Drawing.Color.DarkRed
GaugeCircularScale3.MinPin.Label.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale3.MinPin.Label.Layout.ScaleOffset = -0.009!
GaugeCircularScale3.MinPin.Label.Text = "Off"
GaugeCircularScale3.MinPin.Name = "MinPin"
GaugeCircularScale3.Name = "Scale1"
GaugePointer5.AllowUserChange = true
GaugePointer5.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer5.CapFillColor.BorderWidth = 1
GaugePointer5.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer5.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer5.CapImage = CType(resources.GetObject("GaugePointer5.CapImage"),System.Drawing.Image)
GaugePointer5.CapWidth = 0.395!
GaugePointer5.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer5.FillColor.BorderWidth = 1
GaugePointer5.FillColor.Color1 = System.Drawing.Color.White
GaugePointer5.FillColor.Color2 = System.Drawing.Color.Black
GaugePointer5.Length = 0.305!
GaugePointer5.Name = "Needle"
GaugePointer5.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style5
GaugePointer5.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer5.RotateCap = true
GaugePointer5.ScaleOffset = -0.215!
GaugePointer5.SnapInterval = 0.5
GaugePointer5.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer5.Tooltip = "Needle"
GaugePointer5.Value = 19
GaugePointer5.Width = 0.071!
GaugePointer6.AllowUserChange = true
GaugePointer6.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer6.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer6.CapFillColor.BorderWidth = 1
GaugePointer6.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer6.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer6.ChangeCursor = System.Windows.Forms.Cursors.SizeAll
GaugePointer6.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer6.FillColor.BorderWidth = 1
GaugePointer6.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer6.FillColor.Color2 = System.Drawing.Color.Indigo
GaugePointer6.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer6.Name = "Bar"
GaugePointer6.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer6.Tooltip = "Bar"
GaugePointer6.UnderTickMarks = true
GaugePointer6.Value = 35
GaugePointer6.Width = 0.028!
GaugeCircularScale3.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer5, GaugePointer6})
GaugeRange6.EndWidth = 0.216!
GaugeRange6.FillColor.BorderColor = System.Drawing.Color.DarkGray
GaugeRange6.FillColor.BorderWidth = 1
GaugeRange6.FillColor.Color1 = System.Drawing.Color.DarkRed
GaugeRange6.FillColor.Color2 = System.Drawing.Color.WhiteSmoke
GaugeRange6.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugeRange6.Name = "Range1"
GaugeRange6.ScaleOffset = 0.28!
GaugeRange6.StartValue = 65
GaugeRange6.StartWidth = 0.011!
GaugeRange6.Tooltip = "Range"
GaugeCircularScale3.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange6})
GaugeCircularScale3.Reversed = true
GaugeSection5.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection5.Name = "Section1"
GaugeSection5.Tooltip = "Blue Section"
GaugeSection6.EndValue = 20
GaugeSection6.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection6.Name = "Section2"
GaugeSection6.StartValue = 0
GaugeSection6.Tooltip = "Lime Section"
GaugeCircularScale3.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection5, GaugeSection6})
Me.gcHitTesting.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale3})
GradientFillColor5.BorderColor = System.Drawing.Color.Gold
GradientFillColor5.BorderWidth = 1
GradientFillColor5.Color1 = System.Drawing.Color.Yellow
GradientFillColor5.Color2 = System.Drawing.Color.Goldenrod
GradientFillColor5.GradientAngle = 45
GradientFillColor5.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
Me.gcHitTesting.Frame.BackColor = GradientFillColor5
GradientFillColor6.Color1 = System.Drawing.Color.Yellow
GradientFillColor6.Color2 = System.Drawing.Color.Black
GradientFillColor6.GradientAngle = 45
Me.gcHitTesting.Frame.FrameColor = GradientFillColor6
Me.gcHitTesting.Frame.InnerBevel = 0.016!
Me.gcHitTesting.Frame.OuterBevel = 0.032!
Me.gcHitTesting.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
GaugeText1.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText1.Location = CType(resources.GetObject("GaugeText1.Location"),System.Drawing.PointF)
GaugeText1.Name = "My Text"
GaugeText1.Tooltip = "My Text!"
GaugeImage2.Image = CType(resources.GetObject("GaugeImage2.Image"),System.Drawing.Image)
GaugeImage2.Location = CType(resources.GetObject("GaugeImage2.Location"),System.Drawing.PointF)
GaugeImage2.Name = "HeadSet"
GaugeImage2.Size = New System.Drawing.SizeF(0.1!, 0.1!)
GaugeImage2.Tooltip = "My Image!"
Me.gcHitTesting.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText1, GaugeImage2})
Me.gcHitTesting.Location = New System.Drawing.Point(40, 90)
Me.gcHitTesting.Name = "gcHitTesting"
Me.gcHitTesting.Size = New System.Drawing.Size(466, 451)
Me.gcHitTesting.TabIndex = 2
'
'tabHitTesting
'
Me.tabHitTesting.AttachedControl = Me.superTabControlPanel25
Me.tabHitTesting.GlobalItem = false
Me.tabHitTesting.Name = "tabHitTesting"
Me.tabHitTesting.Text = "Hit Testing"
'
'superTabControlPanel24
'
Me.superTabControlPanel24.Controls.Add(Me.cbShowRangeEvents)
Me.superTabControlPanel24.Controls.Add(Me.cbShowSectionEvents)
Me.superTabControlPanel24.Controls.Add(Me.cbShowScaleEvents)
Me.superTabControlPanel24.Controls.Add(Me.labelX3)
Me.superTabControlPanel24.Controls.Add(Me.btnClear)
Me.superTabControlPanel24.Controls.Add(Me.labelX2)
Me.superTabControlPanel24.Controls.Add(Me.btnAuto)
Me.superTabControlPanel24.Controls.Add(Me.rtb1)
Me.superTabControlPanel24.Controls.Add(Me.sliderDampen1)
Me.superTabControlPanel24.Controls.Add(Me.btnMin)
Me.superTabControlPanel24.Controls.Add(Me.btnMax)
Me.superTabControlPanel24.Controls.Add(Me.btnMinus20)
Me.superTabControlPanel24.Controls.Add(Me.btnPlus30)
Me.superTabControlPanel24.Controls.Add(Me.gcEnterLeave)
Me.superTabControlPanel24.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel24.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel24.Name = "superTabControlPanel24"
Me.superTabControlPanel24.Size = New System.Drawing.Size(726, 603)
Me.superTabControlPanel24.TabIndex = 0
Me.superTabControlPanel24.TabItem = Me.tabEnterLeave
'
'cbShowRangeEvents
'
Me.cbShowRangeEvents.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbShowRangeEvents.BackgroundStyle.Class = ""
Me.cbShowRangeEvents.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbShowRangeEvents.Checked = true
Me.cbShowRangeEvents.CheckState = System.Windows.Forms.CheckState.Checked
Me.cbShowRangeEvents.CheckValue = "Y"
Me.cbShowRangeEvents.Location = New System.Drawing.Point(550, 403)
Me.cbShowRangeEvents.Name = "cbShowRangeEvents"
Me.cbShowRangeEvents.Size = New System.Drawing.Size(124, 23)
Me.cbShowRangeEvents.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbShowRangeEvents.TabIndex = 23
Me.cbShowRangeEvents.Text = "Show Range Events"
'
'cbShowSectionEvents
'
Me.cbShowSectionEvents.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbShowSectionEvents.BackgroundStyle.Class = ""
Me.cbShowSectionEvents.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbShowSectionEvents.Location = New System.Drawing.Point(550, 381)
Me.cbShowSectionEvents.Name = "cbShowSectionEvents"
Me.cbShowSectionEvents.Size = New System.Drawing.Size(124, 23)
Me.cbShowSectionEvents.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbShowSectionEvents.TabIndex = 22
Me.cbShowSectionEvents.Text = "Show Section Events"
'
'cbShowScaleEvents
'
Me.cbShowScaleEvents.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbShowScaleEvents.BackgroundStyle.Class = ""
Me.cbShowScaleEvents.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbShowScaleEvents.Location = New System.Drawing.Point(550, 357)
Me.cbShowScaleEvents.Name = "cbShowScaleEvents"
Me.cbShowScaleEvents.Size = New System.Drawing.Size(124, 23)
Me.cbShowScaleEvents.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbShowScaleEvents.TabIndex = 21
Me.cbShowScaleEvents.Text = "Show Scale Events"
'
'labelX3
'
Me.labelX3.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX3.BackgroundStyle.Class = ""
Me.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX3.Location = New System.Drawing.Point(356, 16)
Me.labelX3.Name = "labelX3"
Me.labelX3.Size = New System.Drawing.Size(347, 67)
Me.labelX3.TabIndex = 20
Me.labelX3.Text = resources.GetString("labelX3.Text")
Me.labelX3.WordWrap = true
'
'btnClear
'
Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnClear.BackColor = System.Drawing.Color.AliceBlue
Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnClear.Location = New System.Drawing.Point(574, 299)
Me.btnClear.Name = "btnClear"
Me.btnClear.Size = New System.Drawing.Size(75, 23)
Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnClear.TabIndex = 19
Me.btnClear.Text = "Clear"
'
'labelX2
'
Me.labelX2.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX2.BackgroundStyle.Class = ""
Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX2.Location = New System.Drawing.Point(399, 551)
Me.labelX2.Name = "labelX2"
Me.labelX2.Size = New System.Drawing.Size(76, 23)
Me.labelX2.TabIndex = 18
Me.labelX2.Text = "(Dampening)"
Me.labelX2.TextAlignment = System.Drawing.StringAlignment.Center
'
'btnAuto
'
Me.btnAuto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnAuto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnAuto.Location = New System.Drawing.Point(449, 493)
Me.btnAuto.Name = "btnAuto"
Me.btnAuto.Size = New System.Drawing.Size(75, 23)
Me.btnAuto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnAuto.TabIndex = 16
Me.btnAuto.Text = "Auto"
'
'rtb1
'
Me.rtb1.BackColor = System.Drawing.Color.AliceBlue
Me.rtb1.Location = New System.Drawing.Point(512, 100)
Me.rtb1.Name = "rtb1"
Me.rtb1.Size = New System.Drawing.Size(199, 192)
Me.rtb1.TabIndex = 15
Me.rtb1.Text = ""
'
'sliderDampen1
'
Me.sliderDampen1.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.sliderDampen1.BackgroundStyle.Class = ""
Me.sliderDampen1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.sliderDampen1.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Bottom
Me.sliderDampen1.LabelWidth = 50
Me.sliderDampen1.Location = New System.Drawing.Point(481, 547)
Me.sliderDampen1.Maximum = 30
Me.sliderDampen1.Name = "sliderDampen1"
Me.sliderDampen1.Size = New System.Drawing.Size(204, 46)
Me.sliderDampen1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.sliderDampen1.TabIndex = 14
Me.sliderDampen1.Text = "1"
Me.sliderDampen1.Value = 1
'
'btnMin
'
Me.btnMin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnMin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnMin.Location = New System.Drawing.Point(617, 462)
Me.btnMin.Name = "btnMin"
Me.btnMin.Size = New System.Drawing.Size(75, 23)
Me.btnMin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnMin.TabIndex = 13
Me.btnMin.Text = "Min"
'
'btnMax
'
Me.btnMax.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnMax.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnMax.Location = New System.Drawing.Point(617, 491)
Me.btnMax.Name = "btnMax"
Me.btnMax.Size = New System.Drawing.Size(75, 23)
Me.btnMax.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnMax.TabIndex = 12
Me.btnMax.Text = "Max"
'
'btnMinus20
'
Me.btnMinus20.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnMinus20.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnMinus20.Location = New System.Drawing.Point(536, 491)
Me.btnMinus20.Name = "btnMinus20"
Me.btnMinus20.Size = New System.Drawing.Size(75, 23)
Me.btnMinus20.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnMinus20.TabIndex = 11
Me.btnMinus20.Text = "-20"
'
'btnPlus30
'
Me.btnPlus30.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.btnPlus30.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.btnPlus30.Location = New System.Drawing.Point(536, 462)
Me.btnPlus30.Name = "btnPlus30"
Me.btnPlus30.Size = New System.Drawing.Size(75, 23)
Me.btnPlus30.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.btnPlus30.TabIndex = 10
Me.btnPlus30.Text = "+30"
'
'gcEnterLeave
'
Me.gcEnterLeave.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale4.MajorTickMarks.IntervalOffset = 10
GaugeCircularScale4.MaxPin.EndOffset = 0.057!
GaugeCircularScale4.MaxPin.Label.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale4.MaxPin.Label.Text = "Max"
GaugeCircularScale4.MaxPin.Name = "MaxPin"
GaugeCircularScale4.MaxPin.Visible = false
GaugeCircularScale4.MinPin.EndOffset = 0.076!
GaugeCircularScale4.MinPin.Label.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeCircularScale4.MinPin.Label.Layout.ScaleOffset = -0.025!
GaugeCircularScale4.MinPin.Label.Text = "Min"
GaugeCircularScale4.MinPin.Name = "MinPin"
GaugeCircularScale4.MinPin.Visible = false
GaugeCircularScale4.Name = "Scale1"
GaugePointer7.AllowUserChange = true
GaugePointer7.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer7.CapFillColor.BorderWidth = 1
GaugePointer7.CapFillColor.Color1 = System.Drawing.Color.White
GaugePointer7.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer7.CapFillColor.GradientAngle = 45
GaugePointer7.CapFillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer7.DampeningSweepTime = 5
GaugePointer7.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer7.FillColor.BorderWidth = 1
GaugePointer7.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer), CType(CType(225,Byte),Integer))
GaugePointer7.FillColor.Color2 = System.Drawing.Color.DarkRed
GaugePointer7.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer7.Length = 0.486!
GaugePointer7.Name = "DarkRed Needle"
GaugePointer7.NeedleStyle = DevComponents.Instrumentation.NeedlePointerStyle.Style4
GaugePointer7.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer7.Tooltip = "DarkRed Needle"
GaugePointer7.Value = 92
GaugePointer7.Width = 0.117!
GaugePointer8.AllowUserChange = true
GaugePointer8.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer8.CapFillColor.BorderWidth = 1
GaugePointer8.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer8.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer8.ChangeCursor = System.Windows.Forms.Cursors.Cross
GaugePointer8.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer8.FillColor.BorderWidth = 1
GaugePointer8.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer8.Name = "Yellow Marker"
GaugePointer8.Origin = DevComponents.Instrumentation.PointerOrigin.Maximum
GaugePointer8.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer8.ScaleOffset = 0.047!
GaugePointer8.Tooltip = "Yellow Marker"
GaugePointer8.Value = 40
GaugePointer8.Width = 0.191!
GaugePointer9.AllowUserChange = true
GaugePointer9.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer9.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer9.CapFillColor.BorderWidth = 1
GaugePointer9.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer9.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer9.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer9.FillColor.BorderWidth = 1
GaugePointer9.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer9.FillColor.Color2 = System.Drawing.Color.LightSeaGreen
GaugePointer9.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer9.Name = "LightGreen Bar"
GaugePointer9.OriginInterval = 70
GaugePointer9.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer9.ScaleOffset = -0.057!
GaugePointer9.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer9.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer9.ThermoBackColor.BorderWidth = 1
GaugePointer9.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer9.Tooltip = "LightGreen Bar"
GaugePointer9.UnderTickMarks = true
GaugePointer9.Value = 90
GaugePointer10.AllowUserChange = true
GaugePointer10.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer10.CapFillColor.BorderWidth = 1
GaugePointer10.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer10.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer10.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer10.FillColor.BorderWidth = 1
GaugePointer10.FillColor.Color1 = System.Drawing.Color.Red
GaugePointer10.FillColor.Color2 = System.Drawing.Color.Gold
GaugePointer10.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter
GaugePointer10.HonorMaxPin = false
GaugePointer10.HonorMinPin = false
GaugePointer10.Length = 0.305!
GaugePointer10.Name = "Orange Needle"
GaugePointer10.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer10.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer10.ThermoBackColor.BorderWidth = 1
GaugePointer10.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer10.Tooltip = "Orange Needle"
GaugePointer10.Value = 5
GaugeCircularScale4.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer7, GaugePointer8, GaugePointer9, GaugePointer10})
GaugeCircularScale4.Radius = 0.332!
GaugeRange7.EndValue = 90
GaugeRange7.EndWidth = 0.15!
GaugeRange7.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange7.FillColor.BorderWidth = 1
GaugeRange7.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange7.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange7.Name = "Range1"
GaugeRange7.ScaleOffset = 0.218!
GaugeRange7.StartValue = 20
GaugeRange7.Tooltip = "Range1"
GaugeRange8.EndValue = 70
GaugeRange8.EndWidth = 0.15!
GaugeRange8.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange8.FillColor.BorderWidth = 1
GaugeRange8.FillColor.Color1 = System.Drawing.Color.LightYellow
GaugeRange8.FillColor.Color2 = System.Drawing.Color.Green
GaugeRange8.Name = "Range2"
GaugeRange8.ScaleOffset = 0.397!
GaugeRange8.StartValue = 30
GaugeRange8.Tooltip = "Range2"
GaugeRange9.EndValue = 100
GaugeRange9.EndWidth = 0.15!
GaugeRange9.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange9.FillColor.BorderWidth = 1
GaugeRange9.FillColor.Color1 = System.Drawing.Color.DarkOrange
GaugeRange9.FillColor.Color2 = System.Drawing.Color.Snow
GaugeRange9.Name = "Range3"
GaugeRange9.ScaleOffset = 0.582!
GaugeRange9.StartValue = 60
GaugeRange9.Tooltip = "Range3"
GaugeCircularScale4.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange7, GaugeRange8, GaugeRange9})
GaugeSection7.EndValue = 20
GaugeSection7.FillColor.Color1 = System.Drawing.Color.Yellow
GaugeSection7.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugeSection7.MajorTickMarkFillColor.BorderColor = System.Drawing.Color.Gray
GaugeSection7.MajorTickMarkFillColor.BorderWidth = 1
GaugeSection7.MajorTickMarkFillColor.Color1 = System.Drawing.Color.Goldenrod
GaugeSection7.MinorTickMarkFillColor.BorderColor = System.Drawing.Color.Gainsboro
GaugeSection7.MinorTickMarkFillColor.BorderWidth = 1
GaugeSection7.MinorTickMarkFillColor.Color1 = System.Drawing.Color.DarkOliveGreen
GaugeSection7.Name = "Section1"
GaugeSection7.StartValue = 0
GaugeSection8.FillColor.Color1 = System.Drawing.Color.Lime
GaugeSection8.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
GaugeSection8.Name = "Section2"
GaugeSection8.StartValue = 20
GaugeCircularScale4.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection7, GaugeSection8})
GaugeCircularScale4.StartAngle = 140!
GaugeCircularScale4.SweepAngle = 260!
Me.gcEnterLeave.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale4})
GradientFillColor7.BorderColor = System.Drawing.Color.DarkGray
GradientFillColor7.BorderWidth = 1
GradientFillColor7.Color1 = System.Drawing.Color.Moccasin
GradientFillColor7.Color2 = System.Drawing.Color.Peru
GradientFillColor7.GradientAngle = 45
GradientFillColor7.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
Me.gcEnterLeave.Frame.BackColor = GradientFillColor7
GradientFillColor8.Color1 = System.Drawing.Color.NavajoWhite
GradientFillColor8.Color2 = System.Drawing.Color.Black
GradientFillColor8.GradientAngle = 45
GradientFillColor8.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
Me.gcEnterLeave.Frame.FrameColor = GradientFillColor8
Me.gcEnterLeave.Frame.InnerBevel = 0.018!
Me.gcEnterLeave.Frame.OuterBevel = 0.029!
Me.gcEnterLeave.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
NumericIndicator1.BackColor.BorderColor = System.Drawing.Color.DarkRed
NumericIndicator1.BackColor.BorderWidth = 1
NumericIndicator1.BackColor.Color1 = System.Drawing.Color.Maroon
NumericIndicator1.BackColor.Color2 = System.Drawing.Color.RosyBrown
NumericIndicator1.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator1.DecimalColor = System.Drawing.Color.Silver
NumericIndicator1.DigitColor = System.Drawing.Color.White
NumericIndicator1.Location = CType(resources.GetObject("NumericIndicator1.Location"),System.Drawing.PointF)
NumericIndicator1.Name = "NumericIndicator1"
NumericIndicator1.NumberOfDigits = 5
NumericIndicator1.SeparatorColor.BorderColor = System.Drawing.Color.Sienna
NumericIndicator1.SeparatorColor.BorderWidth = 1
NumericIndicator1.SeparatorColor.Color1 = System.Drawing.Color.Chocolate
NumericIndicator1.SeparatorColor.Color2 = System.Drawing.Color.SaddleBrown
NumericIndicator1.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator1.SeparatorWidth = 0.016!
NumericIndicator1.ShowLeadingZeros = true
NumericIndicator1.Size = New System.Drawing.SizeF(0.2672414!, 0.0775862!)
NumericIndicator1.Value = 100
StateIndicator1.BackColor.BorderColor = System.Drawing.Color.Peru
StateIndicator1.BackColor.BorderWidth = 10
StateIndicator1.BackColor.Color1 = System.Drawing.Color.Yellow
StateIndicator1.BackColor.Color2 = System.Drawing.Color.Goldenrod
StateIndicator1.Location = CType(resources.GetObject("StateIndicator1.Location"),System.Drawing.PointF)
StateIndicator1.Name = "StateIndicator1"
StateRange1.BackColor.BorderColor = System.Drawing.Color.Peru
StateRange1.BackColor.BorderWidth = 10
StateRange1.BackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
StateRange1.BackColor.Color2 = System.Drawing.Color.DarkRed
StateRange1.EndValue = 1000
StateRange1.Name = "Range1"
StateRange1.StartValue = 50
StateRange1.Text = "> 50"
StateIndicator1.Ranges.AddRange(New DevComponents.Instrumentation.StateRange() {StateRange1})
StateIndicator1.RoundRectangleArc = 0.99!
StateIndicator1.Size = New System.Drawing.SizeF(0.1637931!, 0.0775862!)
StateIndicator1.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator1.Text = "< 50"
StateIndicator1.Value = 40
Me.gcEnterLeave.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {NumericIndicator1, StateIndicator1})
Me.gcEnterLeave.Location = New System.Drawing.Point(40, 90)
Me.gcEnterLeave.Name = "gcEnterLeave"
Me.gcEnterLeave.Size = New System.Drawing.Size(466, 451)
Me.gcEnterLeave.TabIndex = 24
'
'tabEnterLeave
'
Me.tabEnterLeave.AttachedControl = Me.superTabControlPanel24
Me.tabEnterLeave.GlobalItem = false
Me.tabEnterLeave.Name = "tabEnterLeave"
Me.tabEnterLeave.Text = "Enter / Leave"
'
'superTabControlPanel23
'
Me.superTabControlPanel23.Controls.Add(Me.cbMarker)
Me.superTabControlPanel23.Controls.Add(Me.cbFrame)
Me.superTabControlPanel23.Controls.Add(Me.labelX1)
Me.superTabControlPanel23.Controls.Add(Me.cbBackground)
Me.superTabControlPanel23.Controls.Add(Me.cbRange)
Me.superTabControlPanel23.Controls.Add(Me.cbSection)
Me.superTabControlPanel23.Controls.Add(Me.cbNeedle)
Me.superTabControlPanel23.Controls.Add(Me.cbBar)
Me.superTabControlPanel23.Controls.Add(Me.gcUserRendering)
Me.superTabControlPanel23.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel23.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel23.Name = "superTabControlPanel23"
Me.superTabControlPanel23.Size = New System.Drawing.Size(723, 603)
Me.superTabControlPanel23.TabIndex = 1
Me.superTabControlPanel23.TabItem = Me.tabUserRendering
'
'cbMarker
'
Me.cbMarker.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbMarker.BackgroundStyle.Class = ""
Me.cbMarker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbMarker.Location = New System.Drawing.Point(614, 140)
Me.cbMarker.Name = "cbMarker"
Me.cbMarker.Size = New System.Drawing.Size(86, 23)
Me.cbMarker.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbMarker.TabIndex = 9
Me.cbMarker.Text = "Marker"
'
'cbFrame
'
Me.cbFrame.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbFrame.BackgroundStyle.Class = ""
Me.cbFrame.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbFrame.Location = New System.Drawing.Point(439, 89)
Me.cbFrame.Name = "cbFrame"
Me.cbFrame.Size = New System.Drawing.Size(58, 23)
Me.cbFrame.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbFrame.TabIndex = 8
Me.cbFrame.Text = "Frame"
'
'labelX1
'
Me.labelX1.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX1.BackgroundStyle.Class = ""
Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX1.Location = New System.Drawing.Point(416, 16)
Me.labelX1.Name = "labelX1"
Me.labelX1.Size = New System.Drawing.Size(287, 67)
Me.labelX1.TabIndex = 7
Me.labelX1.Text = "Select any of the below items to see that particular portion of the Gauge rendere"& _ 
    "d with user modifications."
Me.labelX1.WordWrap = true
'
'cbBackground
'
Me.cbBackground.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbBackground.BackgroundStyle.Class = ""
Me.cbBackground.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbBackground.Location = New System.Drawing.Point(439, 114)
Me.cbBackground.Name = "cbBackground"
Me.cbBackground.Size = New System.Drawing.Size(85, 23)
Me.cbBackground.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbBackground.TabIndex = 1
Me.cbBackground.Text = "Background"
'
'cbRange
'
Me.cbRange.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbRange.BackgroundStyle.Class = ""
Me.cbRange.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbRange.Location = New System.Drawing.Point(540, 89)
Me.cbRange.Name = "cbRange"
Me.cbRange.Size = New System.Drawing.Size(58, 23)
Me.cbRange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbRange.TabIndex = 5
Me.cbRange.Text = "Range"
'
'cbSection
'
Me.cbSection.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbSection.BackgroundStyle.Class = ""
Me.cbSection.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbSection.Location = New System.Drawing.Point(614, 89)
Me.cbSection.Name = "cbSection"
Me.cbSection.Size = New System.Drawing.Size(76, 23)
Me.cbSection.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbSection.TabIndex = 2
Me.cbSection.Text = "Section"
'
'cbNeedle
'
Me.cbNeedle.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbNeedle.BackgroundStyle.Class = ""
Me.cbNeedle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbNeedle.Location = New System.Drawing.Point(614, 114)
Me.cbNeedle.Name = "cbNeedle"
Me.cbNeedle.Size = New System.Drawing.Size(86, 23)
Me.cbNeedle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbNeedle.TabIndex = 4
Me.cbNeedle.Text = "Needle"
'
'cbBar
'
Me.cbBar.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbBar.BackgroundStyle.Class = ""
Me.cbBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbBar.Location = New System.Drawing.Point(540, 114)
Me.cbBar.Name = "cbBar"
Me.cbBar.Size = New System.Drawing.Size(58, 23)
Me.cbBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbBar.TabIndex = 3
Me.cbBar.Text = "Bar"
'
'gcUserRendering
'
Me.gcUserRendering.BackColor = System.Drawing.Color.AliceBlue
GaugeCircularScale1.MaxPin.Name = "MaxPin"
GaugeCircularScale1.MinPin.Name = "MinPin"
GaugeCircularScale1.Name = "Scale1"
GaugePointer1.AllowUserChange = true
GaugePointer1.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer1.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer1.CapFillColor.BorderWidth = 1
GaugePointer1.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer1.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer1.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer1.FillColor.BorderWidth = 1
GaugePointer1.FillColor.Color1 = System.Drawing.Color.PaleTurquoise
GaugePointer1.FillColor.Color2 = System.Drawing.Color.DarkSlateGray
GaugePointer1.Name = "Bar"
GaugePointer1.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer1.ScaleOffset = -0.218!
GaugePointer1.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer1.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer1.ThermoBackColor.BorderWidth = 1
GaugePointer1.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer1.Value = 40
GaugePointer2.AllowUserChange = true
GaugePointer2.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer2.CapFillColor.BorderWidth = 1
GaugePointer2.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer2.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer2.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer2.FillColor.BorderWidth = 1
GaugePointer2.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer2.Name = "Marker"
GaugePointer2.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer2.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer2.ThermoBackColor.BorderWidth = 1
GaugePointer2.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer2.Value = 55
GaugePointer3.AllowUserChange = true
GaugePointer3.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer3.CapFillColor.BorderWidth = 1
GaugePointer3.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer3.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer3.CapStyle = DevComponents.Instrumentation.NeedlePointerCapStyle.Style1
GaugePointer3.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer3.FillColor.BorderWidth = 1
GaugePointer3.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer3.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer3.Length = 0.332!
GaugePointer3.Name = "Needle"
GaugePointer3.RotateCap = true
GaugePointer3.Style = DevComponents.Instrumentation.PointerStyle.Needle
GaugePointer3.Value = 25
GaugeCircularScale1.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer1, GaugePointer2, GaugePointer3})
GaugeRange1.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeRange1.FillColor.BorderWidth = 1
GaugeRange1.FillColor.Color1 = System.Drawing.Color.Lime
GaugeRange1.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange1.Name = "Range1"
GaugeRange1.ScaleOffset = 0.28!
GaugeRange1.StartValue = 70
GaugeCircularScale1.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange1})
GaugeSection1.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection1.FillColor.Color2 = System.Drawing.Color.Purple
GaugeSection1.Name = "Section1"
GaugeCircularScale1.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection1})
Me.gcUserRendering.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale1})
GradientFillColor1.BorderColor = System.Drawing.Color.Black
GradientFillColor1.Color1 = System.Drawing.Color.DarkGreen
GradientFillColor1.Color2 = System.Drawing.Color.LawnGreen
GradientFillColor1.GradientAngle = 45
Me.gcUserRendering.Frame.BackColor = GradientFillColor1
GradientFillColor2.BorderColor = System.Drawing.Color.DimGray
GradientFillColor2.Color1 = System.Drawing.Color.White
GradientFillColor2.Color2 = System.Drawing.Color.Black
GradientFillColor2.GradientAngle = 45
GradientFillColor2.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
Me.gcUserRendering.Frame.FrameColor = GradientFillColor2
Me.gcUserRendering.Frame.FrameSigmaFocus = 0.105!
Me.gcUserRendering.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Circular
Me.gcUserRendering.Location = New System.Drawing.Point(40, 90)
Me.gcUserRendering.Name = "gcUserRendering"
Me.gcUserRendering.Size = New System.Drawing.Size(466, 451)
Me.gcUserRendering.TabIndex = 0
'
'tabUserRendering
'
Me.tabUserRendering.AttachedControl = Me.superTabControlPanel23
Me.tabUserRendering.GlobalItem = false
Me.tabUserRendering.Name = "tabUserRendering"
Me.tabUserRendering.Text = "User Rendering"
'
'TabEvents
'
Me.TabEvents.AttachedControl = Me.superTabControlPanel22
Me.TabEvents.GlobalItem = false
Me.TabEvents.Name = "TabEvents"
Me.TabEvents.Text = "Gauge Events"
'
'superTabControlPanel9
'
Me.superTabControlPanel9.Controls.Add(Me.superTabControl3)
Me.superTabControlPanel9.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel9.Location = New System.Drawing.Point(0, 35)
Me.superTabControlPanel9.Name = "superTabControlPanel9"
Me.superTabControlPanel9.Size = New System.Drawing.Size(820, 603)
Me.superTabControlPanel9.TabIndex = 0
Me.superTabControlPanel9.TabItem = Me.LTabSamples
'
'superTabControl3
'
Me.superTabControl3.AntiAlias = true
'
'
'
'
'
'
Me.superTabControl3.ControlBox.CloseBox.Name = ""
'
'
'
Me.superTabControl3.ControlBox.MenuBox.Name = ""
Me.superTabControl3.ControlBox.Name = ""
Me.superTabControl3.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl3.ControlBox.MenuBox, Me.superTabControl3.ControlBox.CloseBox})
Me.superTabControl3.Controls.Add(Me.superTabControlPanel14)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel19)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel20)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel7)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel10)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel11)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel12)
Me.superTabControl3.Controls.Add(Me.superTabControlPanel13)
Me.superTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControl3.FixedTabSize = New System.Drawing.Size(30, 30)
Me.superTabControl3.Location = New System.Drawing.Point(0, 0)
Me.superTabControl3.Name = "superTabControl3"
Me.superTabControl3.ReorderTabsEnabled = true
Me.superTabControl3.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
Me.superTabControl3.SelectedTabIndex = 0
Me.superTabControl3.Size = New System.Drawing.Size(820, 603)
Me.superTabControl3.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
Me.superTabControl3.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.superTabControl3.TabIndex = 1
Me.superTabControl3.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.linearTab1, Me.linearTab2, Me.linearTab3, Me.linearTab4, Me.linearTab5, Me.linearTab6, Me.linearTab7, Me.linearTab8})
Me.superTabControl3.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.WinMediaPlayer12
Me.superTabControl3.Text = "superTabControl3"
Me.superTabControl3.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
'
'superTabControlPanel13
'
Me.superTabControlPanel13.Controls.Add(Me.labelX37)
Me.superTabControlPanel13.Controls.Add(Me.labelX36)
Me.superTabControlPanel13.Controls.Add(Me.labelX5)
Me.superTabControlPanel13.Controls.Add(Me.gcLinear1)
Me.superTabControlPanel13.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel13.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel13.Name = "superTabControlPanel13"
Me.superTabControlPanel13.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel13.TabIndex = 0
Me.superTabControlPanel13.TabItem = Me.linearTab1
'
'labelX37
'
Me.labelX37.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX37.BackgroundStyle.Class = ""
Me.labelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX37.Location = New System.Drawing.Point(251, 438)
Me.labelX37.Name = "labelX37"
Me.labelX37.Size = New System.Drawing.Size(434, 54)
Me.labelX37.TabIndex = 10
Me.labelX37.Text = "The above yellow Marker and red Bar each have a tooltip defined for them that dis"& _ 
    "plays the current value of the respective pointer."
Me.labelX37.WordWrap = true
'
'labelX36
'
Me.labelX36.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX36.BackgroundStyle.Class = ""
Me.labelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX36.Location = New System.Drawing.Point(218, 92)
Me.labelX36.Name = "labelX36"
Me.labelX36.Size = New System.Drawing.Size(434, 74)
Me.labelX36.TabIndex = 9
Me.labelX36.Text = resources.GetString("labelX36.Text")
Me.labelX36.WordWrap = true
'
'labelX5
'
Me.labelX5.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX5.BackgroundStyle.Class = ""
Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX5.Location = New System.Drawing.Point(188, 65)
Me.labelX5.Name = "labelX5"
Me.labelX5.Size = New System.Drawing.Size(434, 25)
Me.labelX5.TabIndex = 8
Me.labelX5.Text = "Tooltips can be displayed using pre-defined template tags:"
Me.labelX5.WordWrap = true
'
'gcLinear1
'
Me.gcLinear1.Frame.AddGlassEffect = true
Me.gcLinear1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeText12.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6!)
GaugeText12.Location = CType(resources.GetObject("GaugeText12.Location"),System.Drawing.PointF)
GaugeText12.Name = "Text1"
GaugeText12.Size = New System.Drawing.SizeF(0.8717949!, 0.1794872!)
GaugeText12.Text = "Transactions per second"
Me.gcLinear1.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText12})
GaugeLinearScale13.Location = CType(resources.GetObject("GaugeLinearScale13.Location"),System.Drawing.PointF)
GaugeLinearScale13.MajorTickMarks.Interval = 200
GradientFillColor36.BorderColor = System.Drawing.Color.DimGray
GradientFillColor36.Color1 = System.Drawing.Color.Black
GaugeLinearScale13.MajorTickMarks.Layout.FillColor = GradientFillColor36
GaugeLinearScale13.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale13.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale13.MaxPin.EndOffset = 0.028!
GaugeLinearScale13.MaxPin.Name = "MaxPin"
GaugeLinearScale13.MaxValue = 1000
GaugeLinearScale13.MinorTickMarks.Interval = 50
GradientFillColor37.BorderColor = System.Drawing.Color.DimGray
GradientFillColor37.Color1 = System.Drawing.Color.Black
GaugeLinearScale13.MinorTickMarks.Layout.FillColor = GradientFillColor37
GaugeLinearScale13.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale13.MinPin.EndOffset = 0.028!
GaugeLinearScale13.MinPin.Name = "MinPin"
GaugeLinearScale13.MinPin.Visible = false
GaugeLinearScale13.Name = "Scale1"
GaugePointer27.AllowUserChange = true
GaugePointer27.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer27.CapFillColor.BorderWidth = 1
GaugePointer27.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer27.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer27.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer27.FillColor.BorderWidth = 1
GaugePointer27.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
GaugePointer27.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer27.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer27.Name = "Bar"
GaugePointer27.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer27.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer27.ThermoBackColor.BorderWidth = 1
GaugePointer27.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer27.Tooltip = "[Value{F2}] Transactions per second"
GaugePointer27.Value = 550
GaugePointer27.Width = 0.125!
GaugePointer28.AllowUserChange = true
GaugePointer28.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer28.CapFillColor.BorderWidth = 1
GaugePointer28.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer28.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer28.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer28.FillColor.BorderWidth = 1
GaugePointer28.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer28.Name = "Marker"
GaugePointer28.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer28.ScaleOffset = 0.019!
GaugePointer28.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer28.ThermoBackColor.BorderWidth = 1
GaugePointer28.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer28.Tooltip = "[Value{c2}] TPS"
GaugePointer28.Value = 725
GaugeLinearScale13.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer27, GaugePointer28})
GaugeSection21.FillColor.Color1 = System.Drawing.Color.Gainsboro
GaugeSection21.FillColor.Color2 = System.Drawing.Color.Gray
GaugeSection21.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection21.Name = "Section1"
GaugeLinearScale13.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection21})
GaugeLinearScale13.Width = 0.129!
Me.gcLinear1.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale13})
Me.gcLinear1.Location = New System.Drawing.Point(54, 206)
Me.gcLinear1.Name = "gcLinear1"
Me.gcLinear1.Size = New System.Drawing.Size(680, 190)
Me.gcLinear1.TabIndex = 0
'
'linearTab1
'
Me.linearTab1.AttachedControl = Me.superTabControlPanel13
Me.linearTab1.GlobalItem = false
Me.linearTab1.Name = "linearTab1"
Me.linearTab1.Text = "1"
'
'superTabControlPanel14
'
Me.superTabControlPanel14.Controls.Add(Me.labelX10)
Me.superTabControlPanel14.Controls.Add(Me.gcLinear8)
Me.superTabControlPanel14.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel14.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel14.Name = "superTabControlPanel14"
Me.superTabControlPanel14.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel14.TabIndex = 0
Me.superTabControlPanel14.TabItem = Me.linearTab8
'
'labelX10
'
Me.labelX10.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX10.BackgroundStyle.Class = ""
Me.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX10.Location = New System.Drawing.Point(512, 46)
Me.labelX10.Name = "labelX10"
Me.labelX10.Size = New System.Drawing.Size(248, 95)
Me.labelX10.TabIndex = 13
Me.labelX10.Text = "User rendering of each component is provided (shown more fully later in the sampl"& _ 
    "e)."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"These bar pointers are being gradient filled in a user defined rendering "& _ 
    "callout."
Me.labelX10.WordWrap = true
'
'gcLinear8
'
Me.gcLinear8.Frame.AddGlassEffect = true
Me.gcLinear8.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeText4.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText4.Location = CType(resources.GetObject("GaugeText4.Location"),System.Drawing.PointF)
GaugeText4.Name = "Left"
GaugeText4.Text = "L"
GaugeText5.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText5.Location = CType(resources.GetObject("GaugeText5.Location"),System.Drawing.PointF)
GaugeText5.Name = "Right"
GaugeText5.Text = "R"
Me.gcLinear8.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText4, GaugeText5})
GaugeLinearScale2.BorderColor = System.Drawing.Color.White
GaugeLinearScale2.Labels.Layout.Font = New System.Drawing.Font("Lucida Handwriting", 10!)
GaugeLinearScale2.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale2.Labels.Layout.ScaleOffset = 0.03!
GaugeLinearScale2.Location = CType(resources.GetObject("GaugeLinearScale2.Location"),System.Drawing.PointF)
GaugeLinearScale2.MajorTickMarks.Interval = 8
GradientFillColor13.BorderColor = System.Drawing.Color.Black
GradientFillColor13.BorderWidth = 1
GradientFillColor13.Color1 = System.Drawing.Color.Black
GaugeLinearScale2.MajorTickMarks.Layout.FillColor = GradientFillColor13
GaugeLinearScale2.MajorTickMarks.Layout.Length = 0.068!
GaugeLinearScale2.MajorTickMarks.Layout.Overlap = DevComponents.Instrumentation.GaugeTickMarkOverlap.ReplaceNone
GaugeLinearScale2.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale2.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale2.MajorTickMarks.Layout.Width = 0.021!
GaugeLinearScale2.MaxPin.EndOffset = 0.028!
GaugeLinearScale2.MaxPin.Name = "MaxPin"
GaugeLinearScale2.MaxPin.Visible = false
GaugeLinearScale2.MaxValue = 0
GradientFillColor14.BorderColor = System.Drawing.Color.Gray
GradientFillColor14.BorderWidth = 1
GradientFillColor14.Color1 = System.Drawing.Color.White
GaugeLinearScale2.MinorTickMarks.Layout.FillColor = GradientFillColor14
GaugeLinearScale2.MinorTickMarks.Layout.Length = 0.326!
GaugeLinearScale2.MinorTickMarks.Layout.Width = 0.014!
GaugeLinearScale2.MinPin.EndOffset = 0.028!
GaugeLinearScale2.MinPin.Name = "MinPin"
GaugeLinearScale2.MinPin.Visible = false
GaugeLinearScale2.MinValue = -64
GaugeLinearScale2.Name = "Scale1"
GaugeLinearScale2.Orientation = System.Windows.Forms.Orientation.Vertical
GaugePointer12.AllowUserChange = true
GaugePointer12.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer12.CapFillColor.BorderWidth = 1
GaugePointer12.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer12.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer12.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer12.FillColor.BorderWidth = 1
GaugePointer12.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer12.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer12.Name = "Bar1"
GaugePointer12.ScaleOffset = 0.065!
GaugePointer12.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer12.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer12.ThermoBackColor.BorderWidth = 1
GaugePointer12.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer12.UnderTickMarks = true
GaugePointer12.Value = -50
GaugePointer12.Width = 0.085!
GaugePointer13.AllowUserChange = true
GaugePointer13.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer13.CapFillColor.BorderWidth = 1
GaugePointer13.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer13.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer13.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer13.FillColor.BorderWidth = 1
GaugePointer13.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer13.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer13.Name = "Bar2"
GaugePointer13.ScaleOffset = -0.075!
GaugePointer13.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer13.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer13.ThermoBackColor.BorderWidth = 1
GaugePointer13.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer13.UnderTickMarks = true
GaugePointer13.Value = -4
GaugePointer13.Width = 0.085!
GaugeLinearScale2.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer12, GaugePointer13})
GaugeSection13.FillColor.Color1 = System.Drawing.Color.Black
GaugeSection13.FillColor.Color2 = System.Drawing.Color.Gray
GaugeSection13.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter
GaugeSection13.Name = "Section1"
GaugeLinearScale2.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection13})
GaugeLinearScale2.Width = 0.328!
Me.gcLinear8.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale2})
Me.gcLinear8.Location = New System.Drawing.Point(299, 41)
Me.gcLinear8.Name = "gcLinear8"
Me.gcLinear8.Size = New System.Drawing.Size(190, 520)
Me.gcLinear8.TabIndex = 1
'
'linearTab8
'
Me.linearTab8.AttachedControl = Me.superTabControlPanel14
Me.linearTab8.GlobalItem = false
Me.linearTab8.Name = "linearTab8"
Me.linearTab8.Text = "8"
'
'superTabControlPanel19
'
Me.superTabControlPanel19.Controls.Add(Me.labelX25)
Me.superTabControlPanel19.Controls.Add(Me.gcLinear7)
Me.superTabControlPanel19.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel19.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel19.Name = "superTabControlPanel19"
Me.superTabControlPanel19.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel19.TabIndex = 0
Me.superTabControlPanel19.TabItem = Me.linearTab7
'
'labelX25
'
Me.labelX25.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX25.BackgroundStyle.Class = ""
Me.labelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX25.Location = New System.Drawing.Point(530, 68)
Me.labelX25.Name = "labelX25"
Me.labelX25.Size = New System.Drawing.Size(227, 65)
Me.labelX25.TabIndex = 17
Me.labelX25.Text = "You can have (and configure) as many scales or pointers as needed to achieve the "& _ 
    "look and feel you like."
Me.labelX25.WordWrap = true
'
'gcLinear7
'
Me.gcLinear7.Frame.AddGlassEffect = true
Me.gcLinear7.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeLinearScale3.BorderWidth = 1
GaugeCustomLabel5.Layout.ScaleOffset = 0.03!
GaugeCustomLabel5.Name = "Label1"
GaugeCustomLabel5.Text = "0"
GaugeCustomLabel5.TickMark.Layout.Length = 0.111!
GaugeCustomLabel5.TickMark.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCustomLabel5.TickMark.Layout.ScaleOffset = 0.025!
GaugeCustomLabel5.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Triangle
GaugeCustomLabel5.TickMark.Layout.Width = 0.055!
GaugeCustomLabel5.Value = 0
GaugeCustomLabel6.Layout.ScaleOffset = 0.03!
GaugeCustomLabel6.Name = "Label2"
GaugeCustomLabel6.Text = "50"
GaugeCustomLabel6.TickMark.Layout.Length = 0.111!
GaugeCustomLabel6.TickMark.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeCustomLabel6.TickMark.Layout.ScaleOffset = 0.025!
GaugeCustomLabel6.TickMark.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Triangle
GaugeCustomLabel6.TickMark.Layout.Width = 0.055!
GaugeCustomLabel6.Value = 50
GaugeLinearScale3.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel5, GaugeCustomLabel6})
GaugeLinearScale3.Labels.Layout.ScaleOffset = 0.03!
GaugeLinearScale3.Location = CType(resources.GetObject("GaugeLinearScale3.Location"),System.Drawing.PointF)
GaugeLinearScale3.MajorTickMarks.Layout.Length = 0.111!
GaugeLinearScale3.MajorTickMarks.Layout.Overlap = DevComponents.Instrumentation.GaugeTickMarkOverlap.ReplaceNone
GaugeLinearScale3.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale3.MajorTickMarks.Layout.ScaleOffset = 0.025!
GaugeLinearScale3.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Triangle
GaugeLinearScale3.MajorTickMarks.Layout.Width = 0.055!
GaugeLinearScale3.MaxPin.EndOffset = 0.028!
GaugeLinearScale3.MaxPin.Name = "MaxPin"
GaugeLinearScale3.MaxPin.Visible = false
GaugeLinearScale3.MaxValue = 50
GaugeLinearScale3.MinorTickMarks.Layout.Width = 0.03!
GaugeLinearScale3.MinPin.EndOffset = 0.028!
GaugeLinearScale3.MinPin.Name = "MinPin"
GaugeLinearScale3.MinPin.Visible = false
GaugeLinearScale3.Name = "Scale1"
GaugeLinearScale3.Orientation = System.Windows.Forms.Orientation.Vertical
GaugePointer14.AllowUserChange = true
GaugePointer14.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer14.CapFillColor.BorderWidth = 1
GaugePointer14.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer14.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer14.FillColor.BorderColor = System.Drawing.Color.Black
GaugePointer14.FillColor.BorderWidth = 1
GaugePointer14.FillColor.Color1 = System.Drawing.Color.Red
GaugePointer14.Length = 0.311!
GaugePointer14.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Wedge
GaugePointer14.Name = "Marker"
GaugePointer14.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer14.ScaleOffset = 0.126!
GaugePointer14.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer14.ThermoBackColor.BorderWidth = 1
GaugePointer14.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer14.Value = 23
GaugePointer14.Width = 0.09!
GaugePointer15.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer15.CapFillColor.BorderWidth = 1
GaugePointer15.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer15.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer15.DampeningSweepTime = 6
GaugePointer15.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer15.FillColor.BorderWidth = 1
GaugePointer15.FillColor.Color1 = System.Drawing.Color.MidnightBlue
GaugePointer15.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
GaugePointer15.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.VerticalCenter
GaugePointer15.Name = "Bar"
GaugePointer15.ScaleOffset = -0.013!
GaugePointer15.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer15.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer15.ThermoBackColor.BorderWidth = 1
GaugePointer15.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer15.Value = 23
GaugePointer15.Width = 0.096!
GaugeLinearScale3.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer14, GaugePointer15})
GaugeRange10.EndValue = 50
GaugeRange10.EndWidth = 0.126!
GaugeRange10.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange10.FillColor.BorderWidth = 1
GaugeRange10.FillColor.Color1 = System.Drawing.Color.Yellow
GaugeRange10.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange10.Name = "Range1"
GaugeRange10.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeRange10.ScaleOffset = 0.062!
GaugeRange10.StartValue = 35
GaugeRange10.StartWidth = 0.126!
GaugeLinearScale3.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange10})
GaugeLinearScale3.Width = 0.125!
GaugeLinearScale4.Labels.Visible = false
GaugeLinearScale4.Location = CType(resources.GetObject("GaugeLinearScale4.Location"),System.Drawing.PointF)
GaugeLinearScale4.MajorTickMarks.Visible = false
GaugeLinearScale4.MaxPin.Name = "MaxPin"
GaugeLinearScale4.MaxPin.Visible = false
GaugeLinearScale4.MaxValue = 50
GaugeLinearScale4.MinorTickMarks.Visible = false
GaugeLinearScale4.MinPin.Name = "MinPin"
GaugeLinearScale4.MinPin.Visible = false
GaugeLinearScale4.Name = "Scale2"
GaugeLinearScale4.Orientation = System.Windows.Forms.Orientation.Vertical
GaugeSection14.FillColor.Color1 = System.Drawing.Color.Black
GaugeSection14.Name = "Section1"
GaugeSection14.Width = 0.3!
GaugeSection15.EndValue = 50
GaugeSection15.FillColor.Color1 = System.Drawing.Color.LightGray
GaugeSection15.Name = "Section2"
GaugeSection15.ScaleOffset = 0.006!
GaugeSection15.StartValue = 0
GaugeSection15.Width = 0.15!
GaugeLinearScale4.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection14, GaugeSection15})
GaugeLinearScale4.Size = New System.Drawing.SizeF(0.7672414!, 0.84!)
Me.gcLinear7.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale3, GaugeLinearScale4})
Me.gcLinear7.Location = New System.Drawing.Point(299, 41)
Me.gcLinear7.Name = "gcLinear7"
Me.gcLinear7.Size = New System.Drawing.Size(190, 520)
Me.gcLinear7.TabIndex = 0
'
'linearTab7
'
Me.linearTab7.AttachedControl = Me.superTabControlPanel19
Me.linearTab7.GlobalItem = false
Me.linearTab7.Name = "linearTab7"
Me.linearTab7.Text = "7"
'
'superTabControlPanel20
'
Me.superTabControlPanel20.Controls.Add(Me.cbSliderAngle)
Me.superTabControlPanel20.Controls.Add(Me.cbFillMode)
Me.superTabControlPanel20.Controls.Add(Me.colorPickerButton2)
Me.superTabControlPanel20.Controls.Add(Me.colorPickerButton1)
Me.superTabControlPanel20.Controls.Add(Me.labelX12)
Me.superTabControlPanel20.Controls.Add(Me.gcLinear6)
Me.superTabControlPanel20.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel20.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel20.Name = "superTabControlPanel20"
Me.superTabControlPanel20.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel20.TabIndex = 0
Me.superTabControlPanel20.TabItem = Me.linearTab6
'
'cbSliderAngle
'
Me.cbSliderAngle.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbSliderAngle.BackgroundStyle.Class = ""
Me.cbSliderAngle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbSliderAngle.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Bottom
Me.cbSliderAngle.Location = New System.Drawing.Point(540, 309)
Me.cbSliderAngle.Maximum = 360
Me.cbSliderAngle.Name = "cbSliderAngle"
Me.cbSliderAngle.Size = New System.Drawing.Size(191, 44)
Me.cbSliderAngle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbSliderAngle.TabIndex = 21
Me.cbSliderAngle.Text = "Angle (90)"
Me.cbSliderAngle.Value = 90
'
'cbFillMode
'
Me.cbFillMode.DisplayMember = "Text"
Me.cbFillMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
Me.cbFillMode.FormattingEnabled = true
Me.cbFillMode.ItemHeight = 14
Me.cbFillMode.Items.AddRange(New Object() {Me.AutoComboItem, Me.Angle, Me.Center, Me.HCenter, Me.None, Me.VCenter, Me.StartToEnd})
Me.cbFillMode.Location = New System.Drawing.Point(540, 269)
Me.cbFillMode.Name = "cbFillMode"
Me.cbFillMode.Size = New System.Drawing.Size(146, 20)
Me.cbFillMode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbFillMode.TabIndex = 20
'
'AutoComboItem
'
Me.AutoComboItem.Text = "Auto"
'
'Angle
'
Me.Angle.Text = "Angle"
'
'Center
'
Me.Center.Text = "Center"
'
'HCenter
'
Me.HCenter.Text = "Horizontal Center"
'
'None
'
Me.None.Text = "None"
'
'VCenter
'
Me.VCenter.Text = "Vertical Center"
'
'StartToEnd
'
Me.StartToEnd.Text = "Start To End"
'
'colorPickerButton2
'
Me.colorPickerButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.colorPickerButton2.BackColor = System.Drawing.Color.AliceBlue
Me.colorPickerButton2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.colorPickerButton2.Image = CType(resources.GetObject("colorPickerButton2.Image"),System.Drawing.Image)
Me.colorPickerButton2.Location = New System.Drawing.Point(557, 201)
Me.colorPickerButton2.Name = "colorPickerButton2"
Me.colorPickerButton2.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
Me.colorPickerButton2.Size = New System.Drawing.Size(104, 23)
Me.colorPickerButton2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.colorPickerButton2.TabIndex = 18
Me.colorPickerButton2.Text = "Color 2"
'
'colorPickerButton1
'
Me.colorPickerButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
Me.colorPickerButton1.BackColor = System.Drawing.Color.AliceBlue
Me.colorPickerButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"),System.Drawing.Image)
Me.colorPickerButton1.Location = New System.Drawing.Point(557, 172)
Me.colorPickerButton1.Name = "colorPickerButton1"
Me.colorPickerButton1.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
Me.colorPickerButton1.Size = New System.Drawing.Size(104, 23)
Me.colorPickerButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.colorPickerButton1.TabIndex = 17
Me.colorPickerButton1.Text = "Color 1"
'
'labelX12
'
Me.labelX12.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX12.BackgroundStyle.Class = ""
Me.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX12.Location = New System.Drawing.Point(525, 76)
Me.labelX12.Name = "labelX12"
Me.labelX12.Size = New System.Drawing.Size(227, 65)
Me.labelX12.TabIndex = 16
Me.labelX12.Text = "Pointer coloring can be changed as desired."
Me.labelX12.WordWrap = true
'
'gcLinear6
'
Me.gcLinear6.Frame.AddGlassEffect = true
Me.gcLinear6.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeText6.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText6.Location = CType(resources.GetObject("GaugeText6.Location"),System.Drawing.PointF)
GaugeText6.Name = "Text1"
GaugeText6.Text = "C°"
GaugeText7.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText7.Location = CType(resources.GetObject("GaugeText7.Location"),System.Drawing.PointF)
GaugeText7.Name = "Text2"
GaugeText7.Text = "F°"
Me.gcLinear6.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText6, GaugeText7})
GaugeLinearScale5.Labels.FormatString = "0°"
GaugeLinearScale5.Location = CType(resources.GetObject("GaugeLinearScale5.Location"),System.Drawing.PointF)
GradientFillColor15.BorderColor = System.Drawing.Color.DimGray
GradientFillColor15.Color1 = System.Drawing.Color.Black
GaugeLinearScale5.MajorTickMarks.Layout.FillColor = GradientFillColor15
GaugeLinearScale5.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale5.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale5.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale5.MaxPin.EndOffset = 0.028!
GaugeLinearScale5.MaxPin.Name = "MaxPin"
GaugeLinearScale5.MaxPin.Visible = false
GaugeLinearScale5.MaxValue = 40
GradientFillColor16.BorderColor = System.Drawing.Color.DimGray
GradientFillColor16.Color1 = System.Drawing.Color.Black
GaugeLinearScale5.MinorTickMarks.Layout.FillColor = GradientFillColor16
GaugeLinearScale5.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale5.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale5.MinPin.EndOffset = 0.028!
GaugeLinearScale5.MinPin.Name = "MinPin"
GaugeLinearScale5.MinPin.Visible = false
GaugeLinearScale5.MinValue = -30
GaugeLinearScale5.Name = "Scale1"
GaugeLinearScale5.Orientation = System.Windows.Forms.Orientation.Vertical
GaugePointer16.AllowUserChange = true
GaugePointer16.BulbOffset = 0.074!
GaugePointer16.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer16.CapFillColor.BorderWidth = 1
GaugePointer16.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer16.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer16.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer16.FillColor.BorderWidth = 1
GaugePointer16.FillColor.Color1 = System.Drawing.Color.Red
GaugePointer16.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer16.Name = "Thermo"
GaugePointer16.Style = DevComponents.Instrumentation.PointerStyle.Thermometer
GaugePointer16.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer16.ThermoBackColor.BorderWidth = 1
GaugePointer16.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer16.Tooltip = "[Value{F2}]°C ([CtoF{F2}]°F)"
GaugePointer16.Value = 12
GaugePointer16.Width = 0.125!
GaugeLinearScale5.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer16})
GaugeSection16.FillColor.Color1 = System.Drawing.Color.Gainsboro
GaugeSection16.FillColor.Color2 = System.Drawing.Color.Gray
GaugeSection16.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection16.Name = "Section1"
GaugeLinearScale5.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection16})
GaugeLinearScale5.Size = New System.Drawing.SizeF(0.7!, 0.7!)
GaugeLinearScale5.Width = 0.129!
GaugeLinearScale6.Labels.FormatString = "0°"
GaugeLinearScale6.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale6.Labels.ShowMaxLabel = false
GaugeLinearScale6.Labels.ShowMinLabel = false
GaugeLinearScale6.Location = CType(resources.GetObject("GaugeLinearScale6.Location"),System.Drawing.PointF)
GaugeLinearScale6.MajorTickMarks.Interval = 20
GaugeLinearScale6.MajorTickMarks.IntervalOffset = 2
GradientFillColor17.BorderColor = System.Drawing.Color.DimGray
GradientFillColor17.Color1 = System.Drawing.Color.Black
GaugeLinearScale6.MajorTickMarks.Layout.FillColor = GradientFillColor17
GaugeLinearScale6.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale6.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale6.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale6.MaxPin.Name = "MaxPin"
GaugeLinearScale6.MaxPin.Visible = false
GaugeLinearScale6.MaxValue = 104
GaugeLinearScale6.MinorTickMarks.Interval = 5
GaugeLinearScale6.MinorTickMarks.IntervalOffset = 2
GradientFillColor18.BorderColor = System.Drawing.Color.DimGray
GradientFillColor18.Color1 = System.Drawing.Color.Black
GaugeLinearScale6.MinorTickMarks.Layout.FillColor = GradientFillColor18
GaugeLinearScale6.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale6.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale6.MinPin.Name = "MinPin"
GaugeLinearScale6.MinPin.Visible = false
GaugeLinearScale6.MinValue = -22
GaugeLinearScale6.Name = "Scale2"
GaugeLinearScale6.Orientation = System.Windows.Forms.Orientation.Vertical
GaugeLinearScale6.Size = New System.Drawing.SizeF(0.7!, 0.7!)
GaugeLinearScale6.Width = 0.129!
Me.gcLinear6.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale5, GaugeLinearScale6})
Me.gcLinear6.Location = New System.Drawing.Point(299, 26)
Me.gcLinear6.Name = "gcLinear6"
Me.gcLinear6.Size = New System.Drawing.Size(190, 550)
Me.gcLinear6.TabIndex = 2
'
'linearTab6
'
Me.linearTab6.AttachedControl = Me.superTabControlPanel20
Me.linearTab6.GlobalItem = false
Me.linearTab6.Name = "linearTab6"
Me.linearTab6.Text = "6"
'
'superTabControlPanel7
'
Me.superTabControlPanel7.Controls.Add(Me.labelX38)
Me.superTabControlPanel7.Controls.Add(Me.cbSetSnap)
Me.superTabControlPanel7.Controls.Add(Me.labelX11)
Me.superTabControlPanel7.Controls.Add(Me.rbFlask)
Me.superTabControlPanel7.Controls.Add(Me.rbBulb)
Me.superTabControlPanel7.Controls.Add(Me.labelX9)
Me.superTabControlPanel7.Controls.Add(Me.gcLinear5)
Me.superTabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel7.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel7.Name = "superTabControlPanel7"
Me.superTabControlPanel7.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel7.TabIndex = 0
Me.superTabControlPanel7.TabItem = Me.linearTab5
'
'labelX38
'
Me.labelX38.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX38.BackgroundStyle.Class = ""
Me.labelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX38.Location = New System.Drawing.Point(170, 402)
Me.labelX38.Name = "labelX38"
Me.labelX38.Size = New System.Drawing.Size(469, 21)
Me.labelX38.TabIndex = 17
Me.labelX38.Text = "(Activate the Thermometer Tooltip to see the user defined conversion from Celsius"& _ 
    " to Fahrenheit.)"
Me.labelX38.WordWrap = true
'
'cbSetSnap
'
Me.cbSetSnap.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbSetSnap.BackgroundStyle.Class = ""
Me.cbSetSnap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbSetSnap.Location = New System.Drawing.Point(440, 527)
Me.cbSetSnap.Name = "cbSetSnap"
Me.cbSetSnap.Size = New System.Drawing.Size(180, 23)
Me.cbSetSnap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbSetSnap.TabIndex = 16
Me.cbSetSnap.Text = "Set SnapInterval to 2 degrees"
'
'labelX11
'
Me.labelX11.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX11.BackgroundStyle.Class = ""
Me.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX11.Location = New System.Drawing.Point(258, 454)
Me.labelX11.Name = "labelX11"
Me.labelX11.Size = New System.Drawing.Size(434, 67)
Me.labelX11.TabIndex = 15
Me.labelX11.Text = "Pointers (like the Thermometer) can also have their ""SnapInterval"" set so that th"& _ 
    "e pointer will ""snap"" to a given step, or interval, on the scale."
Me.labelX11.WordWrap = true
'
'rbFlask
'
Me.rbFlask.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.rbFlask.BackgroundStyle.Class = ""
Me.rbFlask.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.rbFlask.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
Me.rbFlask.Location = New System.Drawing.Point(319, 138)
Me.rbFlask.Name = "rbFlask"
Me.rbFlask.Size = New System.Drawing.Size(70, 23)
Me.rbFlask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.rbFlask.TabIndex = 14
Me.rbFlask.Text = "Flask"
'
'rbBulb
'
Me.rbBulb.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.rbBulb.BackgroundStyle.Class = ""
Me.rbBulb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.rbBulb.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
Me.rbBulb.Checked = true
Me.rbBulb.CheckState = System.Windows.Forms.CheckState.Checked
Me.rbBulb.CheckValue = "Y"
Me.rbBulb.Location = New System.Drawing.Point(319, 115)
Me.rbBulb.Name = "rbBulb"
Me.rbBulb.Size = New System.Drawing.Size(57, 23)
Me.rbBulb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.rbBulb.TabIndex = 13
Me.rbBulb.Text = "Bulb"
'
'labelX9
'
Me.labelX9.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX9.BackgroundStyle.Class = ""
Me.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX9.Location = New System.Drawing.Point(215, 69)
Me.labelX9.Name = "labelX9"
Me.labelX9.Size = New System.Drawing.Size(434, 42)
Me.labelX9.TabIndex = 12
Me.labelX9.Text = "Thermometer style pointers can have either a bulb or flask for their reservoir"
Me.labelX9.WordWrap = true
'
'gcLinear5
'
Me.gcLinear5.BackColor = System.Drawing.Color.AliceBlue
Me.gcLinear5.Frame.AddGlassEffect = true
GradientFillColor19.Color1 = System.Drawing.Color.DimGray
GradientFillColor19.Color2 = System.Drawing.Color.WhiteSmoke
GradientFillColor19.GradientAngle = 45
Me.gcLinear5.Frame.BackColor = GradientFillColor19
GradientFillColor20.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor20.Color2 = System.Drawing.Color.DimGray
GradientFillColor20.GradientAngle = 45
GradientFillColor20.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
Me.gcLinear5.Frame.FrameColor = GradientFillColor20
Me.gcLinear5.Frame.RoundRectangleArc = 1!
Me.gcLinear5.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular
GaugeText8.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText8.Location = CType(resources.GetObject("GaugeText8.Location"),System.Drawing.PointF)
GaugeText8.Name = "Text1"
GaugeText8.Text = "C°"
GaugeText9.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText9.Location = CType(resources.GetObject("GaugeText9.Location"),System.Drawing.PointF)
GaugeText9.Name = "Text2"
GaugeText9.Text = "F°"
Me.gcLinear5.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText8, GaugeText9})
GaugeLinearScale7.Labels.FormatString = "0°"
GaugeLinearScale7.Location = CType(resources.GetObject("GaugeLinearScale7.Location"),System.Drawing.PointF)
GradientFillColor21.BorderColor = System.Drawing.Color.DimGray
GradientFillColor21.Color1 = System.Drawing.Color.Black
GaugeLinearScale7.MajorTickMarks.Layout.FillColor = GradientFillColor21
GaugeLinearScale7.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale7.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale7.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale7.MaxPin.EndOffset = 0.028!
GaugeLinearScale7.MaxPin.Name = "MaxPin"
GaugeLinearScale7.MaxPin.Visible = false
GaugeLinearScale7.MaxValue = 40
GradientFillColor22.BorderColor = System.Drawing.Color.DimGray
GradientFillColor22.Color1 = System.Drawing.Color.Black
GaugeLinearScale7.MinorTickMarks.Layout.FillColor = GradientFillColor22
GaugeLinearScale7.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale7.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale7.MinPin.EndOffset = 0.028!
GaugeLinearScale7.MinPin.Name = "MinPin"
GaugeLinearScale7.MinPin.Visible = false
GaugeLinearScale7.MinValue = -30
GaugeLinearScale7.Name = "Scale1"
GaugePointer17.AllowUserChange = true
GaugePointer17.BulbOffset = 0.074!
GaugePointer17.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer17.CapFillColor.BorderWidth = 1
GaugePointer17.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer17.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer17.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer17.FillColor.BorderWidth = 1
GaugePointer17.FillColor.Color1 = System.Drawing.Color.Red
GaugePointer17.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
GaugePointer17.Name = "Thermo"
GaugePointer17.Style = DevComponents.Instrumentation.PointerStyle.Thermometer
GaugePointer17.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer17.ThermoBackColor.BorderWidth = 1
GaugePointer17.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer17.Tooltip = "[Value{F2}]°C ([CtoF{F2}]°F)"
GaugePointer17.Value = 12
GaugePointer17.Width = 0.125!
GaugeLinearScale7.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer17})
GaugeSection17.FillColor.Color1 = System.Drawing.Color.Gainsboro
GaugeSection17.FillColor.Color2 = System.Drawing.Color.Gray
GaugeSection17.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection17.Name = "Section1"
GaugeLinearScale7.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection17})
GaugeLinearScale7.Size = New System.Drawing.SizeF(0.7!, 0.8!)
GaugeLinearScale7.Width = 0.129!
GaugeLinearScale8.Labels.FormatString = "0°"
GaugeLinearScale8.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale8.Labels.ShowMaxLabel = false
GaugeLinearScale8.Labels.ShowMinLabel = false
GaugeLinearScale8.Location = CType(resources.GetObject("GaugeLinearScale8.Location"),System.Drawing.PointF)
GaugeLinearScale8.MajorTickMarks.Interval = 20
GaugeLinearScale8.MajorTickMarks.IntervalOffset = 2
GradientFillColor23.BorderColor = System.Drawing.Color.DimGray
GradientFillColor23.Color1 = System.Drawing.Color.Black
GaugeLinearScale8.MajorTickMarks.Layout.FillColor = GradientFillColor23
GaugeLinearScale8.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale8.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale8.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale8.MaxPin.Name = "MaxPin"
GaugeLinearScale8.MaxPin.Visible = false
GaugeLinearScale8.MaxValue = 104
GradientFillColor24.BorderColor = System.Drawing.Color.DimGray
GradientFillColor24.Color1 = System.Drawing.Color.Black
GaugeLinearScale8.MinorTickMarks.Layout.FillColor = GradientFillColor24
GaugeLinearScale8.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale8.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale8.MinPin.Name = "MinPin"
GaugeLinearScale8.MinPin.Visible = false
GaugeLinearScale8.MinValue = -22
GaugeLinearScale8.Name = "Scale2"
GaugeLinearScale8.Size = New System.Drawing.SizeF(0.7!, 0.8!)
GaugeLinearScale8.Width = 0.129!
Me.gcLinear5.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale7, GaugeLinearScale8})
Me.gcLinear5.Location = New System.Drawing.Point(54, 206)
Me.gcLinear5.Name = "gcLinear5"
Me.gcLinear5.Size = New System.Drawing.Size(680, 190)
Me.gcLinear5.TabIndex = 1
'
'linearTab5
'
Me.linearTab5.AttachedControl = Me.superTabControlPanel7
Me.linearTab5.GlobalItem = false
Me.linearTab5.Name = "linearTab5"
Me.linearTab5.Text = "5"
'
'superTabControlPanel10
'
Me.superTabControlPanel10.Controls.Add(Me.labelX24)
Me.superTabControlPanel10.Controls.Add(Me.cbUnderTickmarks)
Me.superTabControlPanel10.Controls.Add(Me.labelX8)
Me.superTabControlPanel10.Controls.Add(Me.gcLinear4)
Me.superTabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel10.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel10.Name = "superTabControlPanel10"
Me.superTabControlPanel10.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel10.TabIndex = 1
Me.superTabControlPanel10.TabItem = Me.linearTab4
'
'labelX24
'
Me.labelX24.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX24.BackgroundStyle.Class = ""
Me.labelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX24.Location = New System.Drawing.Point(187, 478)
Me.labelX24.Name = "labelX24"
Me.labelX24.Size = New System.Drawing.Size(434, 46)
Me.labelX24.TabIndex = 13
Me.labelX24.Text = "Note that the above golden bar can not be interactively changed by the user.  Thi"& _ 
    "s is individually configurable for each pointer."
Me.labelX24.WordWrap = true
'
'cbUnderTickmarks
'
Me.cbUnderTickmarks.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.cbUnderTickmarks.BackgroundStyle.Class = ""
Me.cbUnderTickmarks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.cbUnderTickmarks.Location = New System.Drawing.Point(279, 101)
Me.cbUnderTickmarks.Name = "cbUnderTickmarks"
Me.cbUnderTickmarks.Size = New System.Drawing.Size(196, 40)
Me.cbUnderTickmarks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
Me.cbUnderTickmarks.TabIndex = 12
Me.cbUnderTickmarks.Text = "Place the blue and"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"gold bars under Tickmarks"
'
'labelX8
'
Me.labelX8.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX8.BackgroundStyle.Class = ""
Me.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX8.Location = New System.Drawing.Point(205, 57)
Me.labelX8.Name = "labelX8"
Me.labelX8.Size = New System.Drawing.Size(434, 37)
Me.labelX8.TabIndex = 11
Me.labelX8.Text = "Each individual Pointer can either be above or below its associated Scale Tickmar"& _ 
    "ks."
Me.labelX8.WordWrap = true
'
'gcLinear4
'
GradientFillColor25.BorderColor = System.Drawing.Color.Black
GradientFillColor25.Color1 = System.Drawing.Color.Tan
GradientFillColor25.Color2 = System.Drawing.Color.Goldenrod
GradientFillColor25.GradientAngle = 45
Me.gcLinear4.Frame.BackColor = GradientFillColor25
GradientFillColor26.Color1 = System.Drawing.Color.SaddleBrown
GradientFillColor26.Color2 = System.Drawing.Color.Black
GradientFillColor26.GradientAngle = 45
GradientFillColor26.GradientFillType = DevComponents.Instrumentation.GradientFillType.None
Me.gcLinear4.Frame.FrameColor = GradientFillColor26
Me.gcLinear4.Frame.InnerBevel = 0.011!
Me.gcLinear4.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeLinearScale9.BorderWidth = 1
GaugeLinearScale9.Labels.FormatString = "C0"
GaugeLinearScale9.Labels.Interval = 15
GaugeLinearScale9.Labels.IntervalOffset = 5
GaugeLinearScale9.Labels.Layout.Angle = 300!
GaugeLinearScale9.Labels.Layout.ScaleOffset = 0.073!
GaugeLinearScale9.Location = CType(resources.GetObject("GaugeLinearScale9.Location"),System.Drawing.PointF)
GaugeLinearScale9.MajorTickMarks.Interval = 15
GaugeLinearScale9.MajorTickMarks.IntervalOffset = 5
GaugeLinearScale9.MajorTickMarks.Layout.Length = 0.505!
GaugeLinearScale9.MajorTickMarks.Layout.ScaleOffset = 0.022!
GaugeLinearScale9.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale9.MajorTickMarks.Layout.Width = 0.044!
GaugeLinearScale9.MaxPin.EndOffset = 0.028!
GaugeLinearScale9.MaxPin.Name = "MaxPin"
GaugeLinearScale9.MaxPin.Visible = false
GaugeLinearScale9.MaxValue = 70
GaugeLinearScale9.MinorTickMarks.Interval = 2.5
GradientFillColor27.BorderColor = System.Drawing.Color.DimGray
GradientFillColor27.Color1 = System.Drawing.Color.Black
GaugeLinearScale9.MinorTickMarks.Layout.FillColor = GradientFillColor27
GaugeLinearScale9.MinorTickMarks.Layout.Length = 0.437!
GaugeLinearScale9.MinorTickMarks.Layout.Width = 0.017!
GaugeLinearScale9.MinPin.EndOffset = 0.035!
GaugeLinearScale9.MinPin.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugeLinearScale9.MinPin.FillColor.BorderWidth = 1
GaugeLinearScale9.MinPin.FillColor.Color1 = System.Drawing.Color.Cyan
GaugeLinearScale9.MinPin.Label.Layout.ForeColor = System.Drawing.Color.DarkMagenta
GaugeLinearScale9.MinPin.Label.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale9.MinPin.Label.Text = "Min"
GaugeLinearScale9.MinPin.Length = 0.153!
GaugeLinearScale9.MinPin.Name = "MinPin"
GaugeLinearScale9.MinPin.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugeLinearScale9.MinPin.Visible = false
GaugeLinearScale9.MinPin.Width = 0.153!
GaugeLinearScale9.MinValue = -10
GaugeLinearScale9.Name = "Scale1"
GaugePointer18.AllowUserChange = true
GaugePointer18.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer18.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer18.CapFillColor.BorderWidth = 1
GaugePointer18.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer18.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer18.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer18.FillColor.BorderWidth = 1
GaugePointer18.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer18.FillColor.Color2 = System.Drawing.Color.CadetBlue
GaugePointer18.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer18.Name = "Bar1"
GaugePointer18.Origin = DevComponents.Instrumentation.PointerOrigin.Custom
GaugePointer18.OriginInterval = 0
GaugePointer18.ScaleOffset = 0.152!
GaugePointer18.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer18.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer18.ThermoBackColor.BorderWidth = 1
GaugePointer18.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer18.Tooltip = "[Value{C2}]"
GaugePointer18.Value = 60
GaugePointer18.Width = 0.08!
GaugePointer19.AllowUserChange = true
GaugePointer19.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer19.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer19.CapFillColor.BorderWidth = 1
GaugePointer19.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer19.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer19.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer19.FillColor.BorderWidth = 1
GaugePointer19.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer19.FillColor.Color2 = System.Drawing.Color.Red
GaugePointer19.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer19.Name = "Bar2"
GaugePointer19.Origin = DevComponents.Instrumentation.PointerOrigin.Maximum
GaugePointer19.ScaleOffset = 0.054!
GaugePointer19.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer19.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer19.ThermoBackColor.BorderWidth = 1
GaugePointer19.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer19.Tooltip = "[Value{C2}]"
GaugePointer19.Value = 30
GaugePointer19.Width = 0.08!
GaugePointer20.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer20.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer20.CapFillColor.BorderWidth = 1
GaugePointer20.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer20.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer20.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer20.FillColor.BorderWidth = 1
GaugePointer20.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer20.FillColor.Color2 = System.Drawing.Color.Goldenrod
GaugePointer20.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer20.Name = "Bar3"
GaugePointer20.ScaleOffset = -0.051!
GaugePointer20.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer20.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer20.ThermoBackColor.BorderWidth = 1
GaugePointer20.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer20.Tooltip = "[Value{C2}]"
GaugePointer20.Value = 47
GaugePointer20.Width = 0.08!
GaugePointer21.AllowUserChange = true
GaugePointer21.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer21.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer21.CapFillColor.BorderWidth = 1
GaugePointer21.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer21.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer21.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer21.FillColor.BorderWidth = 1
GaugePointer21.FillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer21.FillColor.Color2 = System.Drawing.Color.ForestGreen
GaugePointer21.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer21.Name = "Bar4"
GaugePointer21.Origin = DevComponents.Instrumentation.PointerOrigin.Custom
GaugePointer21.OriginInterval = 40
GaugePointer21.ScaleOffset = -0.152!
GaugePointer21.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer21.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer21.ThermoBackColor.BorderWidth = 1
GaugePointer21.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer21.Tooltip = "[Value{C2}]"
GaugePointer21.Value = 12
GaugePointer21.Width = 0.08!
GaugeLinearScale9.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer18, GaugePointer19, GaugePointer20, GaugePointer21})
GaugeLinearScale9.Size = New System.Drawing.SizeF(0.8017241!, 0.5517241!)
GaugeLinearScale9.Width = 0.6!
Me.gcLinear4.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale9})
Me.gcLinear4.Location = New System.Drawing.Point(54, 172)
Me.gcLinear4.Name = "gcLinear4"
Me.gcLinear4.Size = New System.Drawing.Size(680, 259)
Me.gcLinear4.TabIndex = 2
'
'linearTab4
'
Me.linearTab4.AttachedControl = Me.superTabControlPanel10
Me.linearTab4.GlobalItem = false
Me.linearTab4.Name = "linearTab4"
Me.linearTab4.Text = "4"
'
'superTabControlPanel11
'
Me.superTabControlPanel11.Controls.Add(Me.labelX7)
Me.superTabControlPanel11.Controls.Add(Me.gcLinear3)
Me.superTabControlPanel11.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel11.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel11.Name = "superTabControlPanel11"
Me.superTabControlPanel11.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel11.TabIndex = 0
Me.superTabControlPanel11.TabItem = Me.linearTab3
'
'labelX7
'
Me.labelX7.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX7.BackgroundStyle.Class = ""
Me.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX7.Location = New System.Drawing.Point(251, 44)
Me.labelX7.Name = "labelX7"
Me.labelX7.Size = New System.Drawing.Size(434, 67)
Me.labelX7.TabIndex = 10
Me.labelX7.Text = "Each Pointer can have its own defined Change Cursor."
Me.labelX7.WordWrap = true
'
'gcLinear3
'
Me.gcLinear3.BackColor = System.Drawing.Color.AliceBlue
Me.gcLinear3.Frame.AddGlassEffect = true
GradientFillColor28.Color1 = System.Drawing.Color.OliveDrab
GradientFillColor28.Color2 = System.Drawing.Color.GreenYellow
GradientFillColor28.GradientAngle = 45
GradientFillColor28.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
Me.gcLinear3.Frame.BackColor = GradientFillColor28
GradientFillColor29.BorderColor = System.Drawing.Color.DarkGray
GradientFillColor29.BorderWidth = 1
GradientFillColor29.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor29.Color2 = System.Drawing.Color.DarkOliveGreen
GradientFillColor29.GradientAngle = 45
Me.gcLinear3.Frame.FrameColor = GradientFillColor29
Me.gcLinear3.Frame.InnerBevel = 0.018!
Me.gcLinear3.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular
GaugeText10.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
GaugeText10.Location = CType(resources.GetObject("GaugeText10.Location"),System.Drawing.PointF)
GaugeText10.Name = "Text1"
GaugeText10.Size = New System.Drawing.SizeF(0.2931035!, 0.1637931!)
GaugeText10.Text = "Immunization Levels"
GaugeText10.TextAlignment = DevComponents.Instrumentation.TextAlignment.MiddleLeft
Me.gcLinear3.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText10})
GaugeLinearScale10.Location = CType(resources.GetObject("GaugeLinearScale10.Location"),System.Drawing.PointF)
GaugeLinearScale10.MajorTickMarks.Interval = 2000
GradientFillColor30.BorderColor = System.Drawing.Color.Black
GradientFillColor30.Color1 = System.Drawing.Color.Black
GaugeLinearScale10.MajorTickMarks.Layout.FillColor = GradientFillColor30
GaugeLinearScale10.MajorTickMarks.Layout.Length = 0.263!
GaugeLinearScale10.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale10.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale10.MaxPin.Name = "MaxPin"
GaugeLinearScale10.MaxPin.Visible = false
GaugeLinearScale10.MaxValue = 10000
GaugeLinearScale10.MinorTickMarks.Interval = 200
GradientFillColor31.BorderColor = System.Drawing.Color.DimGray
GradientFillColor31.Color1 = System.Drawing.Color.Black
GaugeLinearScale10.MinorTickMarks.Layout.FillColor = GradientFillColor31
GaugeLinearScale10.MinorTickMarks.Layout.Length = 0.2!
GaugeLinearScale10.MinorTickMarks.Layout.Width = 0.02!
GaugeLinearScale10.MinPin.Name = "MinPin"
GaugeLinearScale10.MinPin.Visible = false
GaugeLinearScale10.Name = "Scale1"
GaugePointer22.AllowUserChange = true
GaugePointer22.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer22.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer22.CapFillColor.BorderWidth = 1
GaugePointer22.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer22.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer22.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer22.FillColor.BorderWidth = 1
GaugePointer22.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
GaugePointer22.FillColor.Color2 = System.Drawing.Color.Gold
GaugePointer22.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer22.Name = "Pointer1"
GaugePointer22.ScaleOffset = -0.042!
GaugePointer22.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer22.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer22.ThermoBackColor.BorderWidth = 1
GaugePointer22.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer22.Tooltip = "[Value{F2}]"
GaugePointer22.Value = 7150
GaugePointer22.Width = 0.07!
GaugePointer23.AllowUserChange = true
GaugePointer23.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer23.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer23.CapFillColor.BorderWidth = 1
GaugePointer23.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer23.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer23.ChangeCursor = System.Windows.Forms.Cursors.SizeAll
GaugePointer23.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer23.FillColor.BorderWidth = 1
GaugePointer23.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
GaugePointer23.FillColor.Color2 = System.Drawing.Color.Cyan
GaugePointer23.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer23.Name = "Pointer2"
GaugePointer23.ScaleOffset = 0.042!
GaugePointer23.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer23.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer23.ThermoBackColor.BorderWidth = 1
GaugePointer23.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer23.Tooltip = "[Value{F2}]"
GaugePointer23.Value = 9150
GaugePointer23.Width = 0.07!
GaugeLinearScale10.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer22, GaugePointer23})
GaugeSection18.FillColor.Color1 = System.Drawing.Color.Gray
GaugeSection18.FillColor.Color2 = System.Drawing.Color.Gainsboro
GaugeSection18.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection18.Name = "Section1"
GaugeLinearScale10.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection18})
GaugeLinearScale10.Size = New System.Drawing.SizeF(0.75!, 0.45!)
GaugeLinearScale10.Width = 0.26!
GaugeLinearScale11.Labels.FormatString = "0%"
GaugeLinearScale11.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale11.Location = CType(resources.GetObject("GaugeLinearScale11.Location"),System.Drawing.PointF)
GaugeLinearScale11.MajorTickMarks.Interval = 0.2
GradientFillColor32.BorderColor = System.Drawing.Color.DimGray
GradientFillColor32.Color1 = System.Drawing.Color.Black
GaugeLinearScale11.MajorTickMarks.Layout.FillColor = GradientFillColor32
GaugeLinearScale11.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale11.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale11.MaxPin.EndOffset = 0.028!
GaugeLinearScale11.MaxPin.Name = "MaxPin"
GaugeLinearScale11.MaxPin.Visible = false
GaugeLinearScale11.MaxValue = 1
GaugeLinearScale11.MinorTickMarks.Interval = 0.04
GradientFillColor33.BorderColor = System.Drawing.Color.DimGray
GradientFillColor33.Color1 = System.Drawing.Color.Black
GaugeLinearScale11.MinorTickMarks.Layout.FillColor = GradientFillColor33
GaugeLinearScale11.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale11.MinPin.EndOffset = 0.028!
GaugeLinearScale11.MinPin.Name = "MinPin"
GaugeLinearScale11.MinPin.Visible = false
GaugeLinearScale11.Name = "Scale2"
GaugePointer24.AllowUserChange = true
GaugePointer24.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer24.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer24.CapFillColor.BorderWidth = 1
GaugePointer24.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer24.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer24.ChangeCursor = System.Windows.Forms.Cursors.Cross
GaugePointer24.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer24.FillColor.BorderWidth = 1
GaugePointer24.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
GaugePointer24.FillColor.Color2 = System.Drawing.Color.Lime
GaugePointer24.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer24.Name = "Bar"
GaugePointer24.Origin = DevComponents.Instrumentation.PointerOrigin.Maximum
GaugePointer24.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer24.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer24.ThermoBackColor.BorderWidth = 1
GaugePointer24.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer24.Tooltip = "[Value{P2}]"
GaugePointer24.Value = 0.38
GaugePointer24.Width = 0.07!
GaugeLinearScale11.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer24})
GaugeRange11.EndValue = 1
GaugeRange11.EndWidth = 0.15!
GaugeRange11.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange11.FillColor.Color1 = System.Drawing.Color.Transparent
GaugeRange11.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange11.FillColor.GradientAngle = 0
GaugeRange11.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugeRange11.Name = "Range1"
GaugeRange11.ScaleOffset = 0.09!
GaugeRange11.StartValue = 0.25
GaugeLinearScale11.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange11})
GaugeSection19.FillColor.Color1 = System.Drawing.Color.Gray
GaugeSection19.FillColor.Color2 = System.Drawing.Color.Gainsboro
GaugeSection19.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection19.Name = "Section1"
GaugeLinearScale11.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection19})
GaugeLinearScale11.Size = New System.Drawing.SizeF(0.75!, 0.45!)
GaugeLinearScale11.Width = 0.129!
Me.gcLinear3.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale10, GaugeLinearScale11})
Me.gcLinear3.Location = New System.Drawing.Point(54, 136)
Me.gcLinear3.Name = "gcLinear3"
Me.gcLinear3.Size = New System.Drawing.Size(680, 330)
Me.gcLinear3.TabIndex = 2
'
'linearTab3
'
Me.linearTab3.AttachedControl = Me.superTabControlPanel11
Me.linearTab3.GlobalItem = false
Me.linearTab3.Name = "linearTab3"
Me.linearTab3.Text = "3"
'
'superTabControlPanel12
'
Me.superTabControlPanel12.Controls.Add(Me.labelX39)
Me.superTabControlPanel12.Controls.Add(Me.labelX32)
Me.superTabControlPanel12.Controls.Add(Me.labelX6)
Me.superTabControlPanel12.Controls.Add(Me.gcLinear2)
Me.superTabControlPanel12.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel12.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel12.Name = "superTabControlPanel12"
Me.superTabControlPanel12.Size = New System.Drawing.Size(788, 603)
Me.superTabControlPanel12.TabIndex = 2
Me.superTabControlPanel12.TabItem = Me.linearTab2
'
'labelX39
'
Me.labelX39.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX39.BackgroundStyle.Class = ""
Me.labelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX39.Location = New System.Drawing.Point(258, 443)
Me.labelX39.Name = "labelX39"
Me.labelX39.Size = New System.Drawing.Size(434, 96)
Me.labelX39.TabIndex = 12
Me.labelX39.Text = resources.GetString("labelX39.Text")
Me.labelX39.WordWrap = true
'
'labelX32
'
Me.labelX32.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX32.BackgroundStyle.Class = ""
Me.labelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX32.Location = New System.Drawing.Point(195, 110)
Me.labelX32.Name = "labelX32"
Me.labelX32.Size = New System.Drawing.Size(434, 43)
Me.labelX32.TabIndex = 10
Me.labelX32.Text = "Each of the below Pointers (red Bar and green Marker), as well as the red Range, "& _ 
    "has user defined templates associated with their tooltips."
Me.labelX32.WordWrap = true
'
'labelX6
'
Me.labelX6.BackColor = System.Drawing.Color.AliceBlue
'
'
'
Me.labelX6.BackgroundStyle.Class = ""
Me.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX6.Location = New System.Drawing.Point(164, 76)
Me.labelX6.Name = "labelX6"
Me.labelX6.Size = New System.Drawing.Size(434, 28)
Me.labelX6.TabIndex = 9
Me.labelX6.Text = "Tooltips can be displayed using user defined templates. "
Me.labelX6.WordWrap = true
'
'gcLinear2
'
Me.gcLinear2.Frame.AddGlassEffect = true
Me.gcLinear2.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeText11.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
GaugeText11.Location = CType(resources.GetObject("GaugeText11.Location"),System.Drawing.PointF)
GaugeText11.Name = "Text1"
GaugeText11.Size = New System.Drawing.SizeF(0.2931035!, 0.1637931!)
GaugeText11.Text = "Network Saturation"
GaugeText11.TextAlignment = DevComponents.Instrumentation.TextAlignment.MiddleLeft
Me.gcLinear2.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText11})
GaugeLinearScale12.Labels.FormatString = "0%"
GaugeLinearScale12.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale12.Location = CType(resources.GetObject("GaugeLinearScale12.Location"),System.Drawing.PointF)
GaugeLinearScale12.MajorTickMarks.Interval = 0.2
GradientFillColor34.BorderColor = System.Drawing.Color.DimGray
GradientFillColor34.Color1 = System.Drawing.Color.Black
GaugeLinearScale12.MajorTickMarks.Layout.FillColor = GradientFillColor34
GaugeLinearScale12.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale12.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale12.MaxPin.EndOffset = 0.028!
GaugeLinearScale12.MaxPin.Name = "MaxPin"
GaugeLinearScale12.MaxPin.Visible = false
GaugeLinearScale12.MaxValue = 1
GaugeLinearScale12.MinorTickMarks.Interval = 0.05
GradientFillColor35.BorderColor = System.Drawing.Color.DimGray
GradientFillColor35.Color1 = System.Drawing.Color.Black
GaugeLinearScale12.MinorTickMarks.Layout.FillColor = GradientFillColor35
GaugeLinearScale12.MinorTickMarks.Layout.Width = 0.016!
GaugeLinearScale12.MinPin.EndOffset = 0.028!
GaugeLinearScale12.MinPin.Name = "MinPin"
GaugeLinearScale12.MinPin.Visible = false
GaugeLinearScale12.Name = "Scale1"
GaugePointer25.AllowUserChange = true
GaugePointer25.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer25.CapFillColor.BorderWidth = 1
GaugePointer25.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer25.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer25.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer25.FillColor.BorderWidth = 1
GaugePointer25.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
GaugePointer25.FillColor.Color2 = System.Drawing.Color.MediumTurquoise
GaugePointer25.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugePointer25.Name = "Bar"
GaugePointer25.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer25.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer25.ThermoBackColor.BorderWidth = 1
GaugePointer25.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer25.Tooltip = "NetSat [Value{P2}]"
GaugePointer25.Value = 0.45
GaugePointer25.Width = 0.125!
GaugePointer26.AllowUserChange = true
GaugePointer26.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer26.CapFillColor.BorderWidth = 1
GaugePointer26.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer26.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer26.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer26.FillColor.BorderWidth = 1
GaugePointer26.FillColor.Color1 = System.Drawing.Color.Lime
GaugePointer26.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugePointer26.Name = "Marker"
GaugePointer26.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer26.ThermoBackColor.BorderWidth = 1
GaugePointer26.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer26.Tooltip = "Saturation at [OutOf]"
GaugePointer26.Value = 0.725
GaugeLinearScale12.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer25, GaugePointer26})
GaugeRange12.EndValue = 1
GaugeRange12.FillColor.BorderColor = System.Drawing.Color.Black
GaugeRange12.FillColor.Color1 = System.Drawing.Color.Transparent
GaugeRange12.FillColor.Color2 = System.Drawing.Color.Red
GaugeRange12.FillColor.GradientAngle = 0
GaugeRange12.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugeRange12.Name = "Range1"
GaugeRange12.ScaleOffset = 0.038!
GaugeRange12.StartValue = 0.55
GaugeRange12.StartWidth = 0.068!
GaugeRange12.Tooltip = "Range1 (from [MyStartValue] to [MyEndValue]%)"
GaugeLinearScale12.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange12})
GaugeSection20.FillColor.Color1 = System.Drawing.Color.Gainsboro
GaugeSection20.FillColor.Color2 = System.Drawing.Color.Gray
GaugeSection20.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection20.Name = "Section1"
GaugeLinearScale12.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection20})
GaugeLinearScale12.Width = 0.129!
Me.gcLinear2.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale12})
Me.gcLinear2.Location = New System.Drawing.Point(54, 206)
Me.gcLinear2.Name = "gcLinear2"
Me.gcLinear2.Size = New System.Drawing.Size(680, 190)
Me.gcLinear2.TabIndex = 3
'
'linearTab2
'
Me.linearTab2.AttachedControl = Me.superTabControlPanel12
Me.linearTab2.GlobalItem = false
Me.linearTab2.Name = "linearTab2"
Me.linearTab2.Text = "2"
'
'LTabSamples
'
Me.LTabSamples.AttachedControl = Me.superTabControlPanel9
Me.LTabSamples.GlobalItem = false
Me.LTabSamples.Name = "LTabSamples"
Me.LTabSamples.Text = "Linear"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Gauge Samples"
'
'superTabControlPanel27
'
Me.superTabControlPanel27.Controls.Add(Me.labelX41)
Me.superTabControlPanel27.Controls.Add(Me.labelX40)
Me.superTabControlPanel27.Controls.Add(Me.gcMixedScale)
Me.superTabControlPanel27.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel27.Location = New System.Drawing.Point(0, 35)
Me.superTabControlPanel27.Name = "superTabControlPanel27"
Me.superTabControlPanel27.Size = New System.Drawing.Size(820, 603)
Me.superTabControlPanel27.TabIndex = 0
Me.superTabControlPanel27.TabItem = Me.TabMixedScale
'
'labelX41
'
Me.labelX41.BackColor = System.Drawing.Color.White
'
'
'
Me.labelX41.BackgroundStyle.Class = ""
Me.labelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX41.Location = New System.Drawing.Point(375, 502)
Me.labelX41.Name = "labelX41"
Me.labelX41.Size = New System.Drawing.Size(387, 49)
Me.labelX41.TabIndex = 15
Me.labelX41.Text = "Try moving the bottom Yellow triangle pointer."
Me.labelX41.WordWrap = true
'
'labelX40
'
Me.labelX40.BackColor = System.Drawing.Color.White
'
'
'
Me.labelX40.BackgroundStyle.Class = ""
Me.labelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.labelX40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.labelX40.Location = New System.Drawing.Point(191, 36)
Me.labelX40.Name = "labelX40"
Me.labelX40.Size = New System.Drawing.Size(387, 65)
Me.labelX40.TabIndex = 14
Me.labelX40.Text = "Multiple Scales of each type (Circular or Linear) can be added to each Gauge."
Me.labelX40.WordWrap = true
'
'gcMixedScale
'
Me.gcMixedScale.BackColor = System.Drawing.Color.White
GaugeCircularScale20.Labels.Layout.RotateLabel = false
GaugeCircularScale20.Labels.Layout.ScaleOffset = 0.032!
GaugeCircularScale20.Labels.ShowMaxLabel = false
GaugeCircularScale20.MajorTickMarks.Interval = 5
GradientFillColor64.BorderColor = System.Drawing.Color.DimGray
GradientFillColor64.BorderWidth = 1
GradientFillColor64.Color1 = System.Drawing.Color.White
GaugeCircularScale20.MajorTickMarks.Layout.FillColor = GradientFillColor64
GaugeCircularScale20.MajorTickMarks.Layout.Length = 0.09!
GaugeCircularScale20.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Circle
GaugeCircularScale20.MaxPin.Name = "MaxPin"
GaugeCircularScale20.MaxPin.Visible = false
GaugeCircularScale20.MaxValue = 10
GaugeCircularScale20.MinorTickMarks.Interval = 1
GradientFillColor65.BorderColor = System.Drawing.Color.DimGray
GradientFillColor65.Color1 = System.Drawing.Color.Black
GaugeCircularScale20.MinorTickMarks.Layout.FillColor = GradientFillColor65
GaugeCircularScale20.MinorTickMarks.Layout.Width = 0.028!
GaugeCircularScale20.MinPin.Name = "MinPin"
GaugeCircularScale20.MinPin.Visible = false
GaugeCircularScale20.Name = "Scale1"
GaugeCircularScale20.PivotPoint = CType(resources.GetObject("GaugeCircularScale20.PivotPoint"),System.Drawing.PointF)
GaugePointer48.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer48.CapFillColor.BorderWidth = 1
GaugePointer48.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer48.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer48.DampeningSweepTime = 0
GaugePointer48.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer48.FillColor.BorderWidth = 1
GaugePointer48.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer48.Length = 0.175!
GaugePointer48.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugePointer48.Name = "Star"
GaugePointer48.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer48.ThermoBackColor.BorderWidth = 1
GaugePointer48.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer48.Value = 5
GaugePointer48.Width = 0.175!
GaugeCircularScale20.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer48})
GaugeCircularScale20.Radius = 0.3!
GaugeCircularScale20.Reversed = true
GaugeSection50.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection50.Name = "Section1"
GaugeCircularScale20.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection50})
GaugeCircularScale20.StartAngle = 30!
GaugeCircularScale20.SweepAngle = 120!
GaugeCircularScale20.Width = 0.024!
GaugeCircularScale21.Labels.Layout.ScaleOffset = 0.032!
GaugeCircularScale21.Labels.ShowMaxLabel = false
GaugeCircularScale21.Labels.ShowMinLabel = false
GaugeCircularScale21.MajorTickMarks.Interval = 5
GaugeCircularScale21.MajorTickMarks.IntervalOffset = 5
GradientFillColor66.BorderColor = System.Drawing.Color.DimGray
GradientFillColor66.BorderWidth = 1
GradientFillColor66.Color1 = System.Drawing.Color.White
GaugeCircularScale21.MajorTickMarks.Layout.FillColor = GradientFillColor66
GaugeCircularScale21.MajorTickMarks.Layout.Length = 0.09!
GaugeCircularScale21.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Circle
GaugeCircularScale21.MaxPin.Name = "MaxPin"
GaugeCircularScale21.MaxPin.Visible = false
GaugeCircularScale21.MaxValue = 20
GaugeCircularScale21.MinorTickMarks.Interval = 1
GradientFillColor67.BorderColor = System.Drawing.Color.DimGray
GradientFillColor67.Color1 = System.Drawing.Color.Black
GaugeCircularScale21.MinorTickMarks.Layout.FillColor = GradientFillColor67
GaugeCircularScale21.MinorTickMarks.Layout.Width = 0.028!
GaugeCircularScale21.MinPin.Name = "MinPin"
GaugeCircularScale21.MinPin.Visible = false
GaugeCircularScale21.MinValue = 10
GaugeCircularScale21.Name = "Scale2"
GaugeCircularScale21.PivotPoint = CType(resources.GetObject("GaugeCircularScale21.PivotPoint"),System.Drawing.PointF)
GaugePointer49.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer49.CapFillColor.BorderWidth = 1
GaugePointer49.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer49.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer49.DampeningSweepTime = 0
GaugePointer49.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer49.FillColor.BorderWidth = 1
GaugePointer49.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer49.Length = 0.175!
GaugePointer49.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugePointer49.Name = "Star"
GaugePointer49.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer49.ThermoBackColor.BorderWidth = 1
GaugePointer49.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer49.Value = 15
GaugePointer49.Visible = false
GaugePointer49.Width = 0.175!
GaugeCircularScale21.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer49})
GaugeCircularScale21.Radius = 0.3!
GaugeSection51.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection51.Name = "Section1"
GaugeCircularScale21.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection51})
GaugeCircularScale21.StartAngle = 210!
GaugeCircularScale21.SweepAngle = 120!
GaugeCircularScale21.Width = 0.024!
GaugeCircularScale22.Labels.Layout.RotateLabel = false
GaugeCircularScale22.Labels.Layout.ScaleOffset = 0.032!
GaugeCircularScale22.Labels.ShowMinLabel = false
GaugeCircularScale22.MajorTickMarks.Interval = 5
GaugeCircularScale22.MajorTickMarks.IntervalOffset = 5
GradientFillColor68.BorderColor = System.Drawing.Color.DimGray
GradientFillColor68.BorderWidth = 1
GradientFillColor68.Color1 = System.Drawing.Color.White
GaugeCircularScale22.MajorTickMarks.Layout.FillColor = GradientFillColor68
GaugeCircularScale22.MajorTickMarks.Layout.Length = 0.09!
GaugeCircularScale22.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Circle
GaugeCircularScale22.MaxPin.Name = "MaxPin"
GaugeCircularScale22.MaxPin.Visible = false
GaugeCircularScale22.MaxValue = 30
GaugeCircularScale22.MinorTickMarks.Interval = 1
GradientFillColor69.BorderColor = System.Drawing.Color.DimGray
GradientFillColor69.Color1 = System.Drawing.Color.Black
GaugeCircularScale22.MinorTickMarks.Layout.FillColor = GradientFillColor69
GaugeCircularScale22.MinorTickMarks.Layout.Width = 0.028!
GaugeCircularScale22.MinPin.Name = "MinPin"
GaugeCircularScale22.MinPin.Visible = false
GaugeCircularScale22.MinValue = 20
GaugeCircularScale22.Name = "Scale3"
GaugeCircularScale22.PivotPoint = CType(resources.GetObject("GaugeCircularScale22.PivotPoint"),System.Drawing.PointF)
GaugePointer50.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer50.CapFillColor.BorderWidth = 1
GaugePointer50.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer50.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer50.DampeningSweepTime = 0
GaugePointer50.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer50.FillColor.BorderWidth = 1
GaugePointer50.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer50.Length = 0.175!
GaugePointer50.MarkerStyle = DevComponents.Instrumentation.GaugeMarkerStyle.Star7
GaugePointer50.Name = "Star"
GaugePointer50.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer50.ThermoBackColor.BorderWidth = 1
GaugePointer50.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer50.Value = 25
GaugePointer50.Visible = false
GaugePointer50.Width = 0.175!
GaugeCircularScale22.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer50})
GaugeCircularScale22.Radius = 0.3!
GaugeCircularScale22.Reversed = true
GaugeSection52.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection52.Name = "Section1"
GaugeCircularScale22.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection52})
GaugeCircularScale22.StartAngle = 30!
GaugeCircularScale22.SweepAngle = 120!
GaugeCircularScale22.Width = 0.024!
Me.gcMixedScale.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale20, GaugeCircularScale21, GaugeCircularScale22})
Me.gcMixedScale.Frame.AddGlassEffect = true
GradientFillColor70.Color1 = System.Drawing.Color.LightSkyBlue
GradientFillColor70.Color2 = System.Drawing.Color.LightCyan
GradientFillColor70.GradientAngle = 45
Me.gcMixedScale.Frame.BackColor = GradientFillColor70
GradientFillColor71.BorderColor = System.Drawing.Color.DarkGray
GradientFillColor71.BorderWidth = 1
GradientFillColor71.Color1 = System.Drawing.Color.WhiteSmoke
GradientFillColor71.Color2 = System.Drawing.Color.DimGray
GradientFillColor71.GradientAngle = 45
Me.gcMixedScale.Frame.FrameColor = GradientFillColor71
Me.gcMixedScale.Frame.InnerBevel = 0.018!
Me.gcMixedScale.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.RoundedRectangular
GaugeText15.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
GaugeText15.Location = CType(resources.GetObject("GaugeText15.Location"),System.Drawing.PointF)
GaugeText15.Name = "Text1"
GaugeText15.Size = New System.Drawing.SizeF(0.2931035!, 0.1637931!)
GaugeText15.Text = "30 Day Inlet Levels"
GaugeImage4.Image = CType(resources.GetObject("GaugeImage4.Image"),System.Drawing.Image)
GaugeImage4.Location = CType(resources.GetObject("GaugeImage4.Location"),System.Drawing.PointF)
GaugeImage4.Name = "Image1"
GaugeImage4.Size = New System.Drawing.SizeF(0.1293103!, 0.25!)
Me.gcMixedScale.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText15, GaugeImage4})
GaugeLinearScale14.Labels.FormatString = ""
GaugeLinearScale14.Location = CType(resources.GetObject("GaugeLinearScale14.Location"),System.Drawing.PointF)
GaugeLinearScale14.MajorTickMarks.Interval = 5
GradientFillColor72.BorderColor = System.Drawing.Color.DimGray
GradientFillColor72.Color1 = System.Drawing.Color.Black
GaugeLinearScale14.MajorTickMarks.Layout.FillColor = GradientFillColor72
GaugeLinearScale14.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale14.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale14.MaxPin.EndOffset = 0.028!
GaugeLinearScale14.MaxPin.Name = "MaxPin"
GaugeLinearScale14.MaxPin.Visible = false
GaugeLinearScale14.MaxValue = 30
GaugeLinearScale14.MinorTickMarks.Interval = 1
GradientFillColor73.BorderColor = System.Drawing.Color.DimGray
GradientFillColor73.Color1 = System.Drawing.Color.Black
GaugeLinearScale14.MinorTickMarks.Layout.FillColor = GradientFillColor73
GaugeLinearScale14.MinorTickMarks.Layout.Length = 0.089!
GaugeLinearScale14.MinorTickMarks.Layout.Overlap = DevComponents.Instrumentation.GaugeTickMarkOverlap.ReplaceNone
GaugeLinearScale14.MinorTickMarks.Layout.Width = 0.008!
GaugeLinearScale14.MinPin.EndOffset = 0.028!
GaugeLinearScale14.MinPin.Name = "MinPin"
GaugeLinearScale14.MinPin.Visible = false
GaugeLinearScale14.Name = "Scale1"
GaugePointer51.AllowUserChange = true
GaugePointer51.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer51.CapFillColor.BorderWidth = 1
GaugePointer51.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer51.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer51.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer51.FillColor.BorderWidth = 1
GaugePointer51.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer51.Name = "MainMarker"
GaugePointer51.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer51.ScaleOffset = 0.095!
GaugePointer51.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer51.ThermoBackColor.BorderWidth = 1
GaugePointer51.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer51.Value = 5
GaugePointer51.Width = 0.1!
GaugeLinearScale14.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer51})
GaugeSection53.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection53.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection53.Name = "Section1"
GaugeLinearScale14.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection53})
GaugeLinearScale14.Size = New System.Drawing.SizeF(0.761!, 0.4310345!)
GaugeLinearScale14.Width = 0.017!
GaugeLinearScale15.Labels.FormatString = ""
GaugeLinearScale15.Labels.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugeLinearScale15.Labels.Visible = false
GaugeLinearScale15.Location = CType(resources.GetObject("GaugeLinearScale15.Location"),System.Drawing.PointF)
GaugeLinearScale15.MajorTickMarks.Interval = 5
GradientFillColor74.BorderColor = System.Drawing.Color.DimGray
GradientFillColor74.Color1 = System.Drawing.Color.Black
GaugeLinearScale15.MajorTickMarks.Layout.FillColor = GradientFillColor74
GaugeLinearScale15.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Rectangle
GaugeLinearScale15.MajorTickMarks.Layout.Width = 0.022!
GaugeLinearScale15.MaxPin.EndOffset = 0.028!
GaugeLinearScale15.MaxPin.Name = "MaxPin"
GaugeLinearScale15.MaxPin.Visible = false
GaugeLinearScale15.MaxValue = 30
GaugeLinearScale15.MinorTickMarks.Interval = 0.5
GradientFillColor75.BorderColor = System.Drawing.Color.DimGray
GradientFillColor75.Color1 = System.Drawing.Color.Black
GaugeLinearScale15.MinorTickMarks.Layout.FillColor = GradientFillColor75
GaugeLinearScale15.MinorTickMarks.Layout.Length = 0.053!
GaugeLinearScale15.MinorTickMarks.Layout.Overlap = DevComponents.Instrumentation.GaugeTickMarkOverlap.ReplaceNone
GaugeLinearScale15.MinorTickMarks.Layout.Width = 0.008!
GaugeLinearScale15.MinPin.EndOffset = 0.028!
GaugeLinearScale15.MinPin.Name = "MinPin"
GaugeLinearScale15.MinPin.Visible = false
GaugeLinearScale15.Name = "Scale2"
GaugePointer52.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer52.CapFillColor.BorderWidth = 1
GaugePointer52.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer52.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer52.DampeningSweepTime = 0
GaugePointer52.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer52.FillColor.BorderWidth = 1
GaugePointer52.FillColor.Color1 = System.Drawing.Color.Red
GaugePointer52.Name = "Marker"
GaugePointer52.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer52.ScaleOffset = 0.076!
GaugePointer52.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer52.ThermoBackColor.BorderWidth = 1
GaugePointer52.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer52.Value = 25
GaugePointer52.Width = 0.1!
GaugeLinearScale15.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer52})
GaugeSection54.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection54.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
GaugeSection54.Name = "Section1"
GaugeLinearScale15.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection54})
GaugeLinearScale15.Size = New System.Drawing.SizeF(0.761!, 0.4310345!)
GaugeLinearScale15.Width = 0.017!
GaugeLinearScale16.Labels.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!)
GaugeLinearScale16.Location = CType(resources.GetObject("GaugeLinearScale16.Location"),System.Drawing.PointF)
GaugeLinearScale16.MajorTickMarks.Layout.Length = 0.2!
GaugeLinearScale16.MajorTickMarks.Layout.Overlap = DevComponents.Instrumentation.GaugeTickMarkOverlap.ReplaceLast
GaugeLinearScale16.MajorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale16.MajorTickMarks.Layout.ScaleOffset = 0.047!
GaugeLinearScale16.MajorTickMarks.Layout.Style = DevComponents.Instrumentation.GaugeMarkerStyle.Triangle
GaugeLinearScale16.MajorTickMarks.Layout.Width = 0.14!
GaugeLinearScale16.MajorTickMarks.Visible = false
GaugeLinearScale16.MaxPin.Name = "MaxPin"
GaugeLinearScale16.MaxPin.Visible = false
GaugeLinearScale16.MaxValue = 10
GaugeLinearScale16.MinorTickMarks.Layout.Length = 0.253!
GaugeLinearScale16.MinorTickMarks.Layout.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugeLinearScale16.MinorTickMarks.Layout.ScaleOffset = -0.092!
GaugeLinearScale16.MinPin.Name = "MinPin"
GaugeLinearScale16.MinPin.Visible = false
GaugeLinearScale16.MinValue = -10
GaugeLinearScale16.Name = "Scale3"
GaugeLinearScale16.Orientation = System.Windows.Forms.Orientation.Vertical
GaugePointer53.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer53.CapFillColor.BorderWidth = 1
GaugePointer53.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer53.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer53.DampeningSweepTime = 0
GaugePointer53.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer53.FillColor.BorderWidth = 1
GaugePointer53.FillColor.Color1 = System.Drawing.Color.Orange
GaugePointer53.Name = "HeightMarker"
GaugePointer53.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer53.ScaleOffset = 0.1!
GaugePointer53.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer53.ThermoBackColor.BorderWidth = 1
GaugePointer53.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer53.Value = -10
GaugeLinearScale16.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer53})
GaugeSection55.FillColor.Color1 = System.Drawing.Color.Black
GaugeSection55.Name = "Section1"
GaugeLinearScale16.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection55})
GaugeLinearScale16.Size = New System.Drawing.SizeF(0.0862069!, 0.3103448!)
GaugeLinearScale16.Width = 0.028!
Me.gcMixedScale.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale14, GaugeLinearScale15, GaugeLinearScale16})
Me.gcMixedScale.Location = New System.Drawing.Point(70, 136)
Me.gcMixedScale.Name = "gcMixedScale"
Me.gcMixedScale.Size = New System.Drawing.Size(680, 330)
Me.gcMixedScale.TabIndex = 4
'
'TabMixedScale
'
Me.TabMixedScale.AttachedControl = Me.superTabControlPanel27
Me.TabMixedScale.GlobalItem = false
Me.TabMixedScale.Name = "TabMixedScale"
Me.TabMixedScale.Text = "Mixed Scales"
'
'superTabControlPanel28
'
Me.superTabControlPanel28.Controls.Add(Me.superTabControl5)
Me.superTabControlPanel28.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel28.Location = New System.Drawing.Point(0, 35)
Me.superTabControlPanel28.Name = "superTabControlPanel28"
Me.superTabControlPanel28.Size = New System.Drawing.Size(820, 603)
Me.superTabControlPanel28.TabIndex = 2
Me.superTabControlPanel28.TabItem = Me.ITabElements
'
'superTabControl5
'
Me.superTabControl5.AntiAlias = true
'
'
'
'
'
'
Me.superTabControl5.ControlBox.CloseBox.Name = ""
'
'
'
Me.superTabControl5.ControlBox.MenuBox.Name = ""
Me.superTabControl5.ControlBox.Name = ""
Me.superTabControl5.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl5.ControlBox.MenuBox, Me.superTabControl5.ControlBox.CloseBox})
Me.superTabControl5.Controls.Add(Me.superTabControlPanel29)
Me.superTabControl5.Controls.Add(Me.superTabControlPanel31)
Me.superTabControl5.Controls.Add(Me.superTabControlPanel32)
Me.superTabControl5.Controls.Add(Me.superTabControlPanel30)
Me.superTabControl5.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControl5.FixedTabSize = New System.Drawing.Size(115, 40)
Me.superTabControl5.Location = New System.Drawing.Point(0, 0)
Me.superTabControl5.Name = "superTabControl5"
Me.superTabControl5.ReorderTabsEnabled = true
Me.superTabControl5.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
Me.superTabControl5.SelectedTabIndex = 0
Me.superTabControl5.Size = New System.Drawing.Size(820, 603)
Me.superTabControl5.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Right
Me.superTabControl5.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.superTabControl5.TabIndex = 1
Me.superTabControl5.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.IndMechanical, Me.IndTab7Seg, Me.IndTab16Seg, Me.IndTabState})
Me.superTabControl5.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.WinMediaPlayer12
Me.superTabControl5.Text = "superTabControl5"
'
'superTabControlPanel29
'
Me.superTabControlPanel29.Controls.Add(Me.textBox44)
Me.superTabControlPanel29.Controls.Add(Me.label45)
Me.superTabControlPanel29.Controls.Add(Me.textBox43)
Me.superTabControlPanel29.Controls.Add(Me.label44)
Me.superTabControlPanel29.Controls.Add(Me.textBox42)
Me.superTabControlPanel29.Controls.Add(Me.label43)
Me.superTabControlPanel29.Controls.Add(Me.label23)
Me.superTabControlPanel29.Controls.Add(Me.textBox36)
Me.superTabControlPanel29.Controls.Add(Me.textBox30)
Me.superTabControlPanel29.Controls.Add(Me.label37)
Me.superTabControlPanel29.Controls.Add(Me.textBox28)
Me.superTabControlPanel29.Controls.Add(Me.label29)
Me.superTabControlPanel29.Controls.Add(Me.textBox26)
Me.superTabControlPanel29.Controls.Add(Me.label31)
Me.superTabControlPanel29.Controls.Add(Me.gcIndicatorElements)
Me.superTabControlPanel29.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel29.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel29.Name = "superTabControlPanel29"
Me.superTabControlPanel29.Size = New System.Drawing.Size(703, 603)
Me.superTabControlPanel29.TabIndex = 1
Me.superTabControlPanel29.TabItem = Me.IndMechanical
'
'textBox44
'
Me.textBox44.BackColor = System.Drawing.Color.AliceBlue
Me.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox44.Location = New System.Drawing.Point(51, 179)
Me.textBox44.Multiline = true
Me.textBox44.Name = "textBox44"
Me.textBox44.Size = New System.Drawing.Size(107, 48)
Me.textBox44.TabIndex = 74
Me.textBox44.Text = "Sign"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Visibility"
Me.textBox44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label45
'
Me.label45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label45.Location = New System.Drawing.Point(104, 132)
Me.label45.Name = "label45"
Me.label45.Size = New System.Drawing.Size(2, 43)
Me.label45.TabIndex = 73
Me.label45.Text = "label45"
'
'textBox43
'
Me.textBox43.BackColor = System.Drawing.Color.AliceBlue
Me.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox43.Location = New System.Drawing.Point(170, 167)
Me.textBox43.Multiline = true
Me.textBox43.Name = "textBox43"
Me.textBox43.Size = New System.Drawing.Size(87, 44)
Me.textBox43.TabIndex = 72
Me.textBox43.Text = "Leading"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Zeros"
Me.textBox43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label44
'
Me.label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label44.Location = New System.Drawing.Point(213, 133)
Me.label44.Name = "label44"
Me.label44.Size = New System.Drawing.Size(2, 31)
Me.label44.TabIndex = 71
Me.label44.Text = "label44"
'
'textBox42
'
Me.textBox42.BackColor = System.Drawing.Color.AliceBlue
Me.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox42.Location = New System.Drawing.Point(436, 181)
Me.textBox42.Multiline = true
Me.textBox42.Name = "textBox42"
Me.textBox42.Size = New System.Drawing.Size(107, 48)
Me.textBox42.TabIndex = 70
Me.textBox42.Text = "Decimal"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Point"
Me.textBox42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label43
'
Me.label43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label43.Location = New System.Drawing.Point(489, 134)
Me.label43.Name = "label43"
Me.label43.Size = New System.Drawing.Size(2, 43)
Me.label43.TabIndex = 69
Me.label43.Text = "label43"
'
'label23
'
Me.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label23.Location = New System.Drawing.Point(45, 267)
Me.label23.Name = "label23"
Me.label23.Size = New System.Drawing.Size(610, 2)
Me.label23.TabIndex = 22
Me.label23.Text = "label23"
'
'textBox36
'
Me.textBox36.BackColor = System.Drawing.Color.AliceBlue
Me.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox36.Location = New System.Drawing.Point(30, 249)
Me.textBox36.Name = "textBox36"
Me.textBox36.Size = New System.Drawing.Size(66, 16)
Me.textBox36.TabIndex = 68
Me.textBox36.Text = "Samples"
Me.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'textBox30
'
Me.textBox30.BackColor = System.Drawing.Color.AliceBlue
Me.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox30.Location = New System.Drawing.Point(363, 169)
Me.textBox30.Multiline = true
Me.textBox30.Name = "textBox30"
Me.textBox30.Size = New System.Drawing.Size(87, 22)
Me.textBox30.TabIndex = 67
Me.textBox30.Text = "Separator"
Me.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label37
'
Me.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label37.Location = New System.Drawing.Point(406, 135)
Me.label37.Name = "label37"
Me.label37.Size = New System.Drawing.Size(2, 31)
Me.label37.TabIndex = 66
Me.label37.Text = "label37"
'
'textBox28
'
Me.textBox28.BackColor = System.Drawing.Color.AliceBlue
Me.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox28.Location = New System.Drawing.Point(524, 191)
Me.textBox28.Multiline = true
Me.textBox28.Name = "textBox28"
Me.textBox28.Size = New System.Drawing.Size(153, 43)
Me.textBox28.TabIndex = 65
Me.textBox28.Text = "Decimals"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(2 in this example)"
Me.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label29
'
Me.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label29.Location = New System.Drawing.Point(600, 135)
Me.label29.Name = "label29"
Me.label29.Size = New System.Drawing.Size(2, 50)
Me.label29.TabIndex = 64
Me.label29.Text = "label29"
'
'textBox26
'
Me.textBox26.BackColor = System.Drawing.Color.AliceBlue
Me.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox26.Location = New System.Drawing.Point(252, 189)
Me.textBox26.Multiline = true
Me.textBox26.Name = "textBox26"
Me.textBox26.Size = New System.Drawing.Size(153, 43)
Me.textBox26.TabIndex = 63
Me.textBox26.Text = "Digits"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(10 in this example)"
Me.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label31
'
Me.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label31.Location = New System.Drawing.Point(325, 133)
Me.label31.Name = "label31"
Me.label31.Size = New System.Drawing.Size(2, 50)
Me.label31.TabIndex = 24
Me.label31.Text = "label31"
'
'gcIndicatorElements
'
Me.gcIndicatorElements.BackColor = System.Drawing.Color.AliceBlue
GradientFillColor56.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor56.Color2 = System.Drawing.Color.DarkGray
Me.gcIndicatorElements.Frame.BackColor = GradientFillColor56
GradientFillColor57.BorderColor = System.Drawing.Color.Gainsboro
GradientFillColor57.BorderWidth = 1
GradientFillColor57.Color1 = System.Drawing.Color.White
GradientFillColor57.Color2 = System.Drawing.Color.DimGray
Me.gcIndicatorElements.Frame.FrameColor = GradientFillColor57
Me.gcIndicatorElements.Frame.InnerBevel = 0.011!
Me.gcIndicatorElements.Frame.OuterBevel = 0.008!
NumericIndicator3.BackColor.BorderColor = System.Drawing.Color.DimGray
NumericIndicator3.BackColor.BorderWidth = 1
NumericIndicator3.BackColor.Color1 = System.Drawing.Color.Gray
NumericIndicator3.BackColor.Color2 = System.Drawing.Color.White
NumericIndicator3.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator3.Location = CType(resources.GetObject("NumericIndicator3.Location"),System.Drawing.PointF)
NumericIndicator3.MaxValue = 10000
NumericIndicator3.Name = "Mechanical1"
NumericIndicator3.NumberOfDigits = 10
NumericIndicator3.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator3.SeparatorColor.BorderWidth = 1
NumericIndicator3.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator3.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator3.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator3.SeparatorWidth = 0.005!
NumericIndicator3.ShowDecimalPoint = true
NumericIndicator3.ShowLeadingZeros = true
NumericIndicator3.SignVisibility = DevComponents.Instrumentation.SignVisibility.Always
NumericIndicator3.Size = New System.Drawing.SizeF(1!, 0.17!)
NumericIndicator3.Value = 1234.56
NumericIndicator4.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator4.BackColor.BorderWidth = 1
NumericIndicator4.BackColor.Color1 = System.Drawing.Color.Gray
NumericIndicator4.BackColor.Color2 = System.Drawing.Color.White
NumericIndicator4.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator4.DecimalColor = System.Drawing.Color.Green
NumericIndicator4.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator4.DigitColor = System.Drawing.Color.Red
NumericIndicator4.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator4.Location = CType(resources.GetObject("NumericIndicator4.Location"),System.Drawing.PointF)
NumericIndicator4.MaxValue = 10000
NumericIndicator4.Name = "Mechanical2"
NumericIndicator4.NumberOfDecimals = 4
NumericIndicator4.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator4.SeparatorColor.BorderWidth = 1
NumericIndicator4.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator4.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator4.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator4.SeparatorWidth = 0.005!
NumericIndicator4.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator4.Value = 12.3456
NumericIndicator5.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator5.BackColor.BorderWidth = 1
NumericIndicator5.BackColor.Color1 = System.Drawing.Color.Gray
NumericIndicator5.BackColor.Color2 = System.Drawing.Color.White
NumericIndicator5.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator5.DecimalColor = System.Drawing.Color.DarkSlateGray
NumericIndicator5.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator5.DigitColor = System.Drawing.Color.ForestGreen
NumericIndicator5.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator5.Font = New System.Drawing.Font("Monotype Corsiva", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
NumericIndicator5.Location = CType(resources.GetObject("NumericIndicator5.Location"),System.Drawing.PointF)
NumericIndicator5.MaxValue = 100000
NumericIndicator5.Name = "Mechanical3"
NumericIndicator5.NumberOfDecimals = 1
NumericIndicator5.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator5.SeparatorColor.BorderWidth = 1
NumericIndicator5.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator5.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator5.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator5.SeparatorWidth = 0.068!
NumericIndicator5.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator5.Value = 12345.6
NumericIndicator6.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator6.BackColor.BorderWidth = 1
NumericIndicator6.BackColor.Color1 = System.Drawing.Color.DarkGoldenrod
NumericIndicator6.BackColor.Color2 = System.Drawing.Color.LemonChiffon
NumericIndicator6.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator6.DecimalColor = System.Drawing.Color.DarkSlateGray
NumericIndicator6.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator6.DigitColor = System.Drawing.Color.ForestGreen
NumericIndicator6.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator6.Location = CType(resources.GetObject("NumericIndicator6.Location"),System.Drawing.PointF)
NumericIndicator6.MaxValue = 100000
NumericIndicator6.Name = "Mechanical4"
NumericIndicator6.NumberOfDecimals = 3
NumericIndicator6.NumberOfDigits = 8
NumericIndicator6.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator6.SeparatorColor.BorderWidth = 1
NumericIndicator6.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator6.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator6.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator6.SeparatorWidth = 0!
NumericIndicator6.ShowLeadingZeros = true
NumericIndicator6.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator6.Value = 12.345
NumericIndicator7.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator7.BackColor.BorderWidth = 1
NumericIndicator7.BackColor.Color1 = System.Drawing.Color.Gray
NumericIndicator7.BackColor.Color2 = System.Drawing.Color.White
NumericIndicator7.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator7.DecimalColor = System.Drawing.Color.Lime
NumericIndicator7.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator7.DigitColor = System.Drawing.Color.Red
NumericIndicator7.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator7.Location = CType(resources.GetObject("NumericIndicator7.Location"),System.Drawing.PointF)
NumericIndicator7.MaxValue = 10000
NumericIndicator7.Name = "Mechanical5"
NumericIndicator7.NumberOfDecimals = 4
NumericIndicator7.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator7.SeparatorColor.BorderWidth = 1
NumericIndicator7.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator7.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator7.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator7.SeparatorWidth = 0.005!
NumericIndicator7.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator7.Text = "Error"
NumericIndicator7.Value = 12.3456
NumericIndicator8.AutoSize = false
NumericIndicator8.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator8.BackColor.BorderWidth = 1
NumericIndicator8.BackColor.Color1 = System.Drawing.Color.White
NumericIndicator8.BackColor.Color2 = System.Drawing.Color.CadetBlue
NumericIndicator8.BackColor.GradientAngle = 45
NumericIndicator8.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
NumericIndicator8.DecimalColor = System.Drawing.Color.Lime
NumericIndicator8.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator8.DigitColor = System.Drawing.Color.DarkRed
NumericIndicator8.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator8.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Bold)
NumericIndicator8.Location = CType(resources.GetObject("NumericIndicator8.Location"),System.Drawing.PointF)
NumericIndicator8.MaxValue = 10000
NumericIndicator8.Name = "Mechanical6"
NumericIndicator8.NumberOfDecimals = 0
NumericIndicator8.NumberOfDigits = 10
NumericIndicator8.SeparatorColor.Color1 = System.Drawing.Color.Black
NumericIndicator8.SeparatorWidth = 0.005!
NumericIndicator8.Size = New System.Drawing.SizeF(0.45!, 0.12!)
NumericIndicator8.Text = "Overflow"
NumericIndicator8.Value = 12.3456
NumericIndicator9.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator9.BackColor.BorderWidth = 1
NumericIndicator9.BackColor.Color1 = System.Drawing.Color.Yellow
NumericIndicator9.BackColor.Color2 = System.Drawing.Color.DarkOrange
NumericIndicator9.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
NumericIndicator9.DecimalColor = System.Drawing.Color.RoyalBlue
NumericIndicator9.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator9.DigitColor = System.Drawing.Color.Black
NumericIndicator9.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator9.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Near
NumericIndicator9.Location = CType(resources.GetObject("NumericIndicator9.Location"),System.Drawing.PointF)
NumericIndicator9.MaxValue = 100000
NumericIndicator9.Name = "Mechanical7"
NumericIndicator9.NumberOfDigits = 10
NumericIndicator9.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator9.SeparatorColor.BorderWidth = 1
NumericIndicator9.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator9.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator9.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator9.SeparatorWidth = 0!
NumericIndicator9.ShowDecimalPoint = true
NumericIndicator9.SignVisibility = DevComponents.Instrumentation.SignVisibility.Always
NumericIndicator9.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator9.Value = 12345.67
NumericIndicator10.BackColor.BorderColor = System.Drawing.Color.DimGray
NumericIndicator10.BackColor.BorderWidth = 2
NumericIndicator10.BackColor.Color1 = System.Drawing.Color.Gray
NumericIndicator10.BackColor.Color2 = System.Drawing.Color.White
NumericIndicator10.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.HorizontalCenter
NumericIndicator10.DecimalColor = System.Drawing.Color.Red
NumericIndicator10.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator10.DigitColor = System.Drawing.Color.ForestGreen
NumericIndicator10.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator10.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator10.FormatString = "C2"
NumericIndicator10.Location = CType(resources.GetObject("NumericIndicator10.Location"),System.Drawing.PointF)
NumericIndicator10.MaxValue = 1000000000
NumericIndicator10.Name = "Mechanical8"
NumericIndicator10.NumberOfDecimals = 1
NumericIndicator10.NumberOfDigits = 20
NumericIndicator10.SeparatorColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator10.SeparatorColor.BorderWidth = 1
NumericIndicator10.SeparatorColor.Color1 = System.Drawing.Color.Silver
NumericIndicator10.SeparatorColor.Color2 = System.Drawing.Color.DimGray
NumericIndicator10.SeparatorColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
NumericIndicator10.SeparatorWidth = 0.005!
NumericIndicator10.Size = New System.Drawing.SizeF(0.8534483!, 0.1206897!)
NumericIndicator10.Value = 123456789
Me.gcIndicatorElements.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {NumericIndicator3, NumericIndicator4, NumericIndicator5, NumericIndicator6, NumericIndicator7, NumericIndicator8, NumericIndicator9, NumericIndicator10})
Me.gcIndicatorElements.Location = New System.Drawing.Point(76, 26)
Me.gcIndicatorElements.Name = "gcIndicatorElements"
Me.gcIndicatorElements.Size = New System.Drawing.Size(550, 550)
Me.gcIndicatorElements.TabIndex = 1
Me.gcIndicatorElements.Text = "gaugeControl1"
'
'IndMechanical
'
Me.IndMechanical.AttachedControl = Me.superTabControlPanel29
Me.IndMechanical.GlobalItem = false
Me.IndMechanical.Name = "IndMechanical"
Me.IndMechanical.Text = "Mechanical"
'
'superTabControlPanel31
'
Me.superTabControlPanel31.Controls.Add(Me.textBox48)
Me.superTabControlPanel31.Controls.Add(Me.label48)
Me.superTabControlPanel31.Controls.Add(Me.label41)
Me.superTabControlPanel31.Controls.Add(Me.textBox40)
Me.superTabControlPanel31.Controls.Add(Me.textBox39)
Me.superTabControlPanel31.Controls.Add(Me.textBox38)
Me.superTabControlPanel31.Controls.Add(Me.textBox37)
Me.superTabControlPanel31.Controls.Add(Me.label40)
Me.superTabControlPanel31.Controls.Add(Me.label39)
Me.superTabControlPanel31.Controls.Add(Me.label38)
Me.superTabControlPanel31.Controls.Add(Me.gaugeControl2)
Me.superTabControlPanel31.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel31.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel31.Name = "superTabControlPanel31"
Me.superTabControlPanel31.Size = New System.Drawing.Size(703, 603)
Me.superTabControlPanel31.TabIndex = 0
Me.superTabControlPanel31.TabItem = Me.IndTab7Seg
'
'textBox48
'
Me.textBox48.BackColor = System.Drawing.Color.AliceBlue
Me.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox48.Location = New System.Drawing.Point(179, 166)
Me.textBox48.Multiline = true
Me.textBox48.Name = "textBox48"
Me.textBox48.Size = New System.Drawing.Size(112, 22)
Me.textBox48.TabIndex = 74
Me.textBox48.Text = "Colon"
Me.textBox48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label48
'
Me.label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label48.Location = New System.Drawing.Point(235, 99)
Me.label48.Name = "label48"
Me.label48.Size = New System.Drawing.Size(2, 64)
Me.label48.TabIndex = 73
Me.label48.Text = "label48"
'
'label41
'
Me.label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label41.Location = New System.Drawing.Point(45, 220)
Me.label41.Name = "label41"
Me.label41.Size = New System.Drawing.Size(610, 2)
Me.label41.TabIndex = 71
Me.label41.Text = "label41"
'
'textBox40
'
Me.textBox40.BackColor = System.Drawing.Color.AliceBlue
Me.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox40.Location = New System.Drawing.Point(30, 202)
Me.textBox40.Name = "textBox40"
Me.textBox40.Size = New System.Drawing.Size(66, 16)
Me.textBox40.TabIndex = 72
Me.textBox40.Text = "Samples"
Me.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'textBox39
'
Me.textBox39.BackColor = System.Drawing.Color.AliceBlue
Me.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox39.Location = New System.Drawing.Point(449, 166)
Me.textBox39.Multiline = true
Me.textBox39.Name = "textBox39"
Me.textBox39.Size = New System.Drawing.Size(112, 22)
Me.textBox39.TabIndex = 70
Me.textBox39.Text = "Decimal Point"
Me.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'textBox38
'
Me.textBox38.BackColor = System.Drawing.Color.AliceBlue
Me.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox38.Location = New System.Drawing.Point(319, 166)
Me.textBox38.Multiline = true
Me.textBox38.Name = "textBox38"
Me.textBox38.Size = New System.Drawing.Size(112, 22)
Me.textBox38.TabIndex = 69
Me.textBox38.Text = "Dim Segment"
Me.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'textBox37
'
Me.textBox37.BackColor = System.Drawing.Color.AliceBlue
Me.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox37.Location = New System.Drawing.Point(45, 166)
Me.textBox37.Multiline = true
Me.textBox37.Name = "textBox37"
Me.textBox37.Size = New System.Drawing.Size(112, 22)
Me.textBox37.TabIndex = 68
Me.textBox37.Text = "Segment"
Me.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'
'label40
'
Me.label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label40.Location = New System.Drawing.Point(375, 113)
Me.label40.Name = "label40"
Me.label40.Size = New System.Drawing.Size(2, 50)
Me.label40.TabIndex = 67
Me.label40.Text = "label40"
'
'label39
'
Me.label39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label39.Location = New System.Drawing.Point(101, 114)
Me.label39.Name = "label39"
Me.label39.Size = New System.Drawing.Size(2, 50)
Me.label39.TabIndex = 66
Me.label39.Text = "label39"
'
'label38
'
Me.label38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label38.Location = New System.Drawing.Point(505, 114)
Me.label38.Name = "label38"
Me.label38.Size = New System.Drawing.Size(2, 50)
Me.label38.TabIndex = 65
Me.label38.Text = "label38"
'
'gaugeControl2
'
Me.gaugeControl2.BackColor = System.Drawing.Color.AliceBlue
GradientFillColor58.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor58.Color2 = System.Drawing.Color.DarkGray
Me.gaugeControl2.Frame.BackColor = GradientFillColor58
GradientFillColor59.BorderColor = System.Drawing.Color.Gainsboro
GradientFillColor59.BorderWidth = 1
GradientFillColor59.Color1 = System.Drawing.Color.White
GradientFillColor59.Color2 = System.Drawing.Color.DimGray
Me.gaugeControl2.Frame.FrameColor = GradientFillColor59
Me.gaugeControl2.Frame.InnerBevel = 0.011!
Me.gaugeControl2.Frame.OuterBevel = 0.008!
NumericIndicator11.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator11.BackColor.BorderWidth = 3
NumericIndicator11.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator11.DecimalColor = System.Drawing.Color.Lime
NumericIndicator11.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator11.DigitColor = System.Drawing.Color.Red
NumericIndicator11.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator11.Location = CType(resources.GetObject("NumericIndicator11.Location"),System.Drawing.PointF)
NumericIndicator11.MaxValue = 10000
NumericIndicator11.Name = "Digital71"
NumericIndicator11.NumberOfDigits = 10
NumericIndicator11.ShowDecimalPoint = true
NumericIndicator11.ShowLeadingZeros = true
NumericIndicator11.Size = New System.Drawing.SizeF(1!, 0.17!)
NumericIndicator11.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator11.Value = 2134.56
NumericIndicator12.BackColor.BorderColor = System.Drawing.Color.DarkRed
NumericIndicator12.BackColor.BorderWidth = 2
NumericIndicator12.BackColor.Color1 = System.Drawing.Color.GreenYellow
NumericIndicator12.DecimalColor = System.Drawing.Color.DarkRed
NumericIndicator12.DecimalDimColor = System.Drawing.Color.Wheat
NumericIndicator12.DigitColor = System.Drawing.Color.DarkOliveGreen
NumericIndicator12.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
NumericIndicator12.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator12.Location = CType(resources.GetObject("NumericIndicator12.Location"),System.Drawing.PointF)
NumericIndicator12.MaxValue = 10000
NumericIndicator12.Name = "Digital72"
NumericIndicator12.NumberOfDigits = 10
NumericIndicator12.ShowDecimalPoint = true
NumericIndicator12.Size = New System.Drawing.SizeF(0.6637931!, 0.1034483!)
NumericIndicator12.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator12.Value = 1234.56
NumericIndicator13.BackColor.BorderColor = System.Drawing.Color.DarkGray
NumericIndicator13.BackColor.BorderWidth = 1
NumericIndicator13.BackColor.Color1 = System.Drawing.Color.White
NumericIndicator13.BackColor.Color2 = System.Drawing.Color.Silver
NumericIndicator13.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
NumericIndicator13.DecimalColor = System.Drawing.Color.Green
NumericIndicator13.DecimalDimColor = System.Drawing.Color.Honeydew
NumericIndicator13.DigitColor = System.Drawing.Color.Red
NumericIndicator13.DigitDimColor = System.Drawing.Color.LavenderBlush
NumericIndicator13.Location = CType(resources.GetObject("NumericIndicator13.Location"),System.Drawing.PointF)
NumericIndicator13.MaxValue = 10000
NumericIndicator13.Name = "Digital73"
NumericIndicator13.NumberOfDigits = 10
NumericIndicator13.SegmentWidth = 0.6!
NumericIndicator13.ShearFactor = 0!
NumericIndicator13.ShowDecimalPoint = true
NumericIndicator13.ShowDimColonPoints = false
NumericIndicator13.ShowDimDecimalPoint = false
NumericIndicator13.ShowDimSegments = false
NumericIndicator13.ShowLeadingZeros = true
NumericIndicator13.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator13.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator13.Value = 1234.56
NumericIndicator14.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator14.BackColor.BorderWidth = 3
NumericIndicator14.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator14.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
NumericIndicator14.DecimalDimColor = System.Drawing.Color.Indigo
NumericIndicator14.DigitColor = System.Drawing.Color.Aqua
NumericIndicator14.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(74,Byte),Integer))
NumericIndicator14.Location = CType(resources.GetObject("NumericIndicator14.Location"),System.Drawing.PointF)
NumericIndicator14.MaxValue = 10000
NumericIndicator14.Name = "Digital74"
NumericIndicator14.NumberOfDigits = 8
NumericIndicator14.SegmentWidth = 0.7!
NumericIndicator14.Size = New System.Drawing.SizeF(0.45!, 0.14!)
NumericIndicator14.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator14.Value = 1234.56
NumericIndicator15.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator15.BackColor.BorderWidth = 1
NumericIndicator15.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator15.DecimalColor = System.Drawing.Color.Lime
NumericIndicator15.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator15.DigitColor = System.Drawing.Color.Red
NumericIndicator15.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator15.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator15.Location = CType(resources.GetObject("NumericIndicator15.Location"),System.Drawing.PointF)
NumericIndicator15.Name = "Digital75"
NumericIndicator15.NumberOfDecimals = 4
NumericIndicator15.NumberOfDigits = 8
NumericIndicator15.SegmentWidth = 0.9!
NumericIndicator15.ShearFactor = 0!
NumericIndicator15.ShowDimColonPoints = false
NumericIndicator15.ShowDimDecimalPoint = false
NumericIndicator15.ShowDimSegments = false
NumericIndicator15.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator15.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator15.Text = "12:47:59"
NumericIndicator16.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator16.BackColor.BorderWidth = 1
NumericIndicator16.BackColor.Color1 = System.Drawing.Color.Aqua
NumericIndicator16.BackColor.Color2 = System.Drawing.Color.Teal
NumericIndicator16.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
NumericIndicator16.DecimalColor = System.Drawing.Color.Yellow
NumericIndicator16.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
NumericIndicator16.DigitColor = System.Drawing.Color.Red
NumericIndicator16.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
NumericIndicator16.Location = CType(resources.GetObject("NumericIndicator16.Location"),System.Drawing.PointF)
NumericIndicator16.MaxValue = 10000
NumericIndicator16.Name = "Digital76"
NumericIndicator16.NumberOfDigits = 8
NumericIndicator16.SegmentWidth = 0.7!
NumericIndicator16.ShearFactor = -0.4!
NumericIndicator16.ShowDecimalPoint = true
NumericIndicator16.ShowDimColonPoints = false
NumericIndicator16.ShowDimDecimalPoint = false
NumericIndicator16.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator16.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator16.Text = ""
NumericIndicator16.Value = 1234.56
NumericIndicator17.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator17.BackColor.BorderWidth = 1
NumericIndicator17.BackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator17.BackColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator17.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
NumericIndicator17.DecimalColor = System.Drawing.Color.Lime
NumericIndicator17.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator17.DigitColor = System.Drawing.Color.Snow
NumericIndicator17.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator17.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator17.Location = CType(resources.GetObject("NumericIndicator17.Location"),System.Drawing.PointF)
NumericIndicator17.MaxValue = 10000
NumericIndicator17.MinValue = -10000
NumericIndicator17.Name = "Digital77"
NumericIndicator17.NumberOfDecimals = 3
NumericIndicator17.NumberOfDigits = 12
NumericIndicator17.SegmentWidth = 0.732!
NumericIndicator17.ShearFactor = 0.1!
NumericIndicator17.ShowDimColonPoints = false
NumericIndicator17.ShowDimSegments = false
NumericIndicator17.SignVisibility = DevComponents.Instrumentation.SignVisibility.Always
NumericIndicator17.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator17.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator17.Text = "Error 21"
NumericIndicator17.Value = 0
NumericIndicator18.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator18.BackColor.BorderWidth = 3
NumericIndicator18.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator18.DecimalColor = System.Drawing.Color.Lime
NumericIndicator18.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator18.DigitColor = System.Drawing.Color.Red
NumericIndicator18.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator18.Location = CType(resources.GetObject("NumericIndicator18.Location"),System.Drawing.PointF)
NumericIndicator18.MaxValue = 10000
NumericIndicator18.Name = "Digital78"
NumericIndicator18.NumberOfDigits = 15
NumericIndicator18.ShowDecimalPoint = true
NumericIndicator18.ShowDimColonPoints = false
NumericIndicator18.ShowLeadingZeros = true
NumericIndicator18.Size = New System.Drawing.SizeF(0.887931!, 0.112069!)
NumericIndicator18.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital7Segment
NumericIndicator18.Value = 1234.56
Me.gaugeControl2.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {NumericIndicator11, NumericIndicator12, NumericIndicator13, NumericIndicator14, NumericIndicator15, NumericIndicator16, NumericIndicator17, NumericIndicator18})
Me.gaugeControl2.Location = New System.Drawing.Point(76, 26)
Me.gaugeControl2.Name = "gaugeControl2"
Me.gaugeControl2.Size = New System.Drawing.Size(550, 550)
Me.gaugeControl2.TabIndex = 2
Me.gaugeControl2.Text = "gaugeControl2"
'
'IndTab7Seg
'
Me.IndTab7Seg.AttachedControl = Me.superTabControlPanel31
Me.IndTab7Seg.GlobalItem = false
Me.IndTab7Seg.Name = "IndTab7Seg"
Me.IndTab7Seg.Text = "Digital 7 Segment"
'
'superTabControlPanel32
'
Me.superTabControlPanel32.Controls.Add(Me.label47)
Me.superTabControlPanel32.Controls.Add(Me.label46)
Me.superTabControlPanel32.Controls.Add(Me.textBox47)
Me.superTabControlPanel32.Controls.Add(Me.textBox46)
Me.superTabControlPanel32.Controls.Add(Me.textBox45)
Me.superTabControlPanel32.Controls.Add(Me.gaugeControl3)
Me.superTabControlPanel32.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel32.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel32.Name = "superTabControlPanel32"
Me.superTabControlPanel32.Size = New System.Drawing.Size(703, 603)
Me.superTabControlPanel32.TabIndex = 0
Me.superTabControlPanel32.TabItem = Me.IndTabState
'
'label47
'
Me.label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label47.Location = New System.Drawing.Point(54, 400)
Me.label47.Name = "label47"
Me.label47.Size = New System.Drawing.Size(610, 2)
Me.label47.TabIndex = 73
Me.label47.Text = "label47"
'
'label46
'
Me.label46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label46.Location = New System.Drawing.Point(54, 200)
Me.label46.Name = "label46"
Me.label46.Size = New System.Drawing.Size(610, 2)
Me.label46.TabIndex = 72
Me.label46.Text = "label46"
'
'textBox47
'
Me.textBox47.BackColor = System.Drawing.Color.AliceBlue
Me.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox47.Location = New System.Drawing.Point(70, 478)
Me.textBox47.Multiline = true
Me.textBox47.Name = "textBox47"
Me.textBox47.Size = New System.Drawing.Size(119, 34)
Me.textBox47.TabIndex = 71
Me.textBox47.Text = "Round"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Rectangular"
'
'textBox46
'
Me.textBox46.BackColor = System.Drawing.Color.AliceBlue
Me.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox46.Location = New System.Drawing.Point(70, 295)
Me.textBox46.Name = "textBox46"
Me.textBox46.Size = New System.Drawing.Size(95, 16)
Me.textBox46.TabIndex = 70
Me.textBox46.Text = "Rectangular"
'
'textBox45
'
Me.textBox45.BackColor = System.Drawing.Color.AliceBlue
Me.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox45.Location = New System.Drawing.Point(70, 100)
Me.textBox45.Name = "textBox45"
Me.textBox45.Size = New System.Drawing.Size(65, 16)
Me.textBox45.TabIndex = 69
Me.textBox45.Text = "Circular"
'
'gaugeControl3
'
Me.gaugeControl3.BackColor = System.Drawing.Color.AliceBlue
GradientFillColor60.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor60.Color2 = System.Drawing.Color.DarkGray
Me.gaugeControl3.Frame.BackColor = GradientFillColor60
GradientFillColor61.BorderColor = System.Drawing.Color.Gainsboro
GradientFillColor61.BorderWidth = 1
GradientFillColor61.Color1 = System.Drawing.Color.White
GradientFillColor61.Color2 = System.Drawing.Color.DimGray
Me.gaugeControl3.Frame.FrameColor = GradientFillColor61
Me.gaugeControl3.Frame.InnerBevel = 0.011!
Me.gaugeControl3.Frame.OuterBevel = 0.008!
StateIndicator3.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator3.BackColor.Color1 = System.Drawing.Color.PaleGreen
StateIndicator3.BackColor.Color2 = System.Drawing.Color.DarkGreen
StateIndicator3.Location = CType(resources.GetObject("StateIndicator3.Location"),System.Drawing.PointF)
StateIndicator3.Name = "StateCircle1"
StateIndicator3.Text = "Go"
StateIndicator4.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator4.BackColor.Color1 = System.Drawing.Color.PaleGreen
StateIndicator4.BackColor.Color2 = System.Drawing.Color.DarkGreen
StateIndicator4.Location = CType(resources.GetObject("StateIndicator4.Location"),System.Drawing.PointF)
StateIndicator4.Name = "StateRect1"
StateIndicator4.Style = DevComponents.Instrumentation.StateIndicatorStyle.Rectangular
StateIndicator4.Text = "Go"
StateIndicator5.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator5.BackColor.Color1 = System.Drawing.Color.PaleGreen
StateIndicator5.BackColor.Color2 = System.Drawing.Color.DarkGreen
StateIndicator5.Location = CType(resources.GetObject("StateIndicator5.Location"),System.Drawing.PointF)
StateIndicator5.Name = "StateRoundRect1"
StateIndicator5.RoundRectangleArc = 0.5!
StateIndicator5.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator5.Text = "Go"
StateIndicator6.BackColor.BorderColor = System.Drawing.Color.Maroon
StateIndicator6.BackColor.BorderWidth = 1
StateIndicator6.BackColor.Color1 = System.Drawing.Color.MistyRose
StateIndicator6.BackColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(180,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
StateIndicator6.EmptyString = ""
StateIndicator6.Location = CType(resources.GetObject("StateIndicator6.Location"),System.Drawing.PointF)
StateIndicator6.Name = "StateCircle2"
StateIndicator7.BackColor.BorderColor = System.Drawing.Color.Maroon
StateIndicator7.BackColor.BorderWidth = 1
StateIndicator7.BackColor.Color1 = System.Drawing.Color.MistyRose
StateIndicator7.BackColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(180,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
StateIndicator7.EmptyString = ""
StateIndicator7.Location = CType(resources.GetObject("StateIndicator7.Location"),System.Drawing.PointF)
StateIndicator7.Name = "StateRect2"
StateIndicator7.Style = DevComponents.Instrumentation.StateIndicatorStyle.Rectangular
StateIndicator8.BackColor.BorderColor = System.Drawing.Color.Maroon
StateIndicator8.BackColor.BorderWidth = 1
StateIndicator8.BackColor.Color1 = System.Drawing.Color.MistyRose
StateIndicator8.BackColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(180,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
StateIndicator8.EmptyString = ""
StateIndicator8.Location = CType(resources.GetObject("StateIndicator8.Location"),System.Drawing.PointF)
StateIndicator8.Name = "StateRoundRect2"
StateIndicator8.RoundRectangleArc = 0.5!
StateIndicator8.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator9.BackColor.BorderColor = System.Drawing.Color.LightBlue
StateIndicator9.BackColor.BorderWidth = 8
StateIndicator9.BackColor.Color1 = System.Drawing.Color.Aqua
StateIndicator9.BackColor.Color2 = System.Drawing.Color.SteelBlue
StateIndicator9.Location = CType(resources.GetObject("StateIndicator9.Location"),System.Drawing.PointF)
StateIndicator9.Name = "StateCircle3"
StateIndicator9.Size = New System.Drawing.SizeF(0.1!, 0.1!)
StateIndicator9.Text = "1"
StateIndicator10.BackColor.BorderColor = System.Drawing.Color.LightBlue
StateIndicator10.BackColor.BorderWidth = 8
StateIndicator10.BackColor.Color1 = System.Drawing.Color.Aqua
StateIndicator10.BackColor.Color2 = System.Drawing.Color.SteelBlue
StateIndicator10.Location = CType(resources.GetObject("StateIndicator10.Location"),System.Drawing.PointF)
StateIndicator10.Name = "StateRect3"
StateIndicator10.Size = New System.Drawing.SizeF(0.1!, 0.1!)
StateIndicator10.Style = DevComponents.Instrumentation.StateIndicatorStyle.Rectangular
StateIndicator10.Text = "2"
StateIndicator11.BackColor.BorderColor = System.Drawing.Color.LightBlue
StateIndicator11.BackColor.BorderWidth = 8
StateIndicator11.BackColor.Color1 = System.Drawing.Color.Aqua
StateIndicator11.BackColor.Color2 = System.Drawing.Color.SteelBlue
StateIndicator11.Location = CType(resources.GetObject("StateIndicator11.Location"),System.Drawing.PointF)
StateIndicator11.Name = "StateRoundRect3"
StateIndicator11.RoundRectangleArc = 0.5!
StateIndicator11.Size = New System.Drawing.SizeF(0.1!, 0.1!)
StateIndicator11.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator11.Text = "3"
StateIndicator12.BackColor.BorderColor = System.Drawing.Color.Sienna
StateIndicator12.BackColor.BorderWidth = 1
StateIndicator12.BackColor.Color1 = System.Drawing.Color.Yellow
StateIndicator12.BackColor.Color2 = System.Drawing.Color.SandyBrown
StateIndicator12.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
StateIndicator12.Location = CType(resources.GetObject("StateIndicator12.Location"),System.Drawing.PointF)
StateIndicator12.Name = "StateCircle4"
StateIndicator12.Size = New System.Drawing.SizeF(0.13!, 0.07!)
StateIndicator12.Text = "Caution"
StateIndicator13.BackColor.BorderColor = System.Drawing.Color.Sienna
StateIndicator13.BackColor.BorderWidth = 1
StateIndicator13.BackColor.Color1 = System.Drawing.Color.Yellow
StateIndicator13.BackColor.Color2 = System.Drawing.Color.SandyBrown
StateIndicator13.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
StateIndicator13.Location = CType(resources.GetObject("StateIndicator13.Location"),System.Drawing.PointF)
StateIndicator13.Name = "StateRect4"
StateIndicator13.Size = New System.Drawing.SizeF(0.13!, 0.07!)
StateIndicator13.Style = DevComponents.Instrumentation.StateIndicatorStyle.Rectangular
StateIndicator13.Text = "Caution"
StateIndicator14.BackColor.BorderColor = System.Drawing.Color.Sienna
StateIndicator14.BackColor.BorderWidth = 1
StateIndicator14.BackColor.Color1 = System.Drawing.Color.Yellow
StateIndicator14.BackColor.Color2 = System.Drawing.Color.SandyBrown
StateIndicator14.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
StateIndicator14.Location = CType(resources.GetObject("StateIndicator14.Location"),System.Drawing.PointF)
StateIndicator14.Name = "StateRoundRect4"
StateIndicator14.RoundRectangleArc = 1!
StateIndicator14.Size = New System.Drawing.SizeF(0.13!, 0.07!)
StateIndicator14.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator14.Text = "Caution"
StateIndicator15.Angle = 270!
StateIndicator15.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator15.BackColor.BorderWidth = 1
StateIndicator15.BackColor.Color1 = System.Drawing.Color.Violet
StateIndicator15.BackColor.Color2 = System.Drawing.Color.Navy
StateIndicator15.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
StateIndicator15.Location = CType(resources.GetObject("StateIndicator15.Location"),System.Drawing.PointF)
StateIndicator15.Name = "StateCircle5"
StateIndicator15.Size = New System.Drawing.SizeF(0.13!, 0.07!)
StateIndicator15.Text = "C6H20"
StateIndicator15.TextColor = System.Drawing.Color.White
StateIndicator15.TextVerticalOffset = 0.066!
StateIndicator16.Angle = 315!
StateIndicator16.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator16.BackColor.BorderWidth = 1
StateIndicator16.BackColor.Color1 = System.Drawing.Color.Violet
StateIndicator16.BackColor.Color2 = System.Drawing.Color.Navy
StateIndicator16.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
StateIndicator16.Location = CType(resources.GetObject("StateIndicator16.Location"),System.Drawing.PointF)
StateIndicator16.Name = "StateRect5"
StateIndicator16.Size = New System.Drawing.SizeF(0.13!, 0.07!)
StateIndicator16.Style = DevComponents.Instrumentation.StateIndicatorStyle.Rectangular
StateIndicator16.Text = "C6H20"
StateIndicator16.TextColor = System.Drawing.Color.White
StateIndicator16.TextVerticalOffset = 0.066!
StateIndicator17.Angle = 45!
StateIndicator17.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator17.BackColor.BorderWidth = 1
StateIndicator17.BackColor.Color1 = System.Drawing.Color.Violet
StateIndicator17.BackColor.Color2 = System.Drawing.Color.Navy
StateIndicator17.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Center
StateIndicator17.Location = CType(resources.GetObject("StateIndicator17.Location"),System.Drawing.PointF)
StateIndicator17.Name = "StateRoundRect5"
StateIndicator17.RoundRectangleArc = 1!
StateIndicator17.Size = New System.Drawing.SizeF(0.13!, 0.07!)
StateIndicator17.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator17.Text = "C6H20"
StateIndicator17.TextColor = System.Drawing.Color.White
StateIndicator17.TextVerticalOffset = 0.066!
StateIndicator18.AutoSize = false
StateIndicator18.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator18.BackColor.Color1 = System.Drawing.Color.PaleGreen
StateIndicator18.BackColor.Color2 = System.Drawing.Color.DarkGreen
StateIndicator18.Image = CType(resources.GetObject("StateIndicator18.Image"),System.Drawing.Image)
StateIndicator18.Location = CType(resources.GetObject("StateIndicator18.Location"),System.Drawing.PointF)
StateIndicator18.Name = "StateCircle6"
StateIndicator18.Size = New System.Drawing.SizeF(0.085!, 0.07!)
StateIndicator18.Text = "Think"
StateIndicator18.TextHorizontalOffset = 0.231!
StateIndicator18.TextVerticalOffset = 0.051!
StateIndicator19.AutoSize = false
StateIndicator19.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator19.BackColor.BorderWidth = 4
StateIndicator19.BackColor.Color1 = System.Drawing.Color.White
StateIndicator19.BackColor.Color2 = System.Drawing.Color.Gray
StateIndicator19.BackColor.GradientAngle = 45
StateIndicator19.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
StateIndicator19.Location = CType(resources.GetObject("StateIndicator19.Location"),System.Drawing.PointF)
StateIndicator19.Name = "StateRect6"
StateIndicator19.Style = DevComponents.Instrumentation.StateIndicatorStyle.Rectangular
StateIndicator19.Text = "Go"
StateIndicator20.BackColor.BorderColor = System.Drawing.Color.Black
StateIndicator20.BackColor.BorderWidth = 4
StateIndicator20.BackColor.Color1 = System.Drawing.Color.White
StateIndicator20.BackColor.Color2 = System.Drawing.Color.Gray
StateIndicator20.BackColor.GradientAngle = 45
StateIndicator20.BackColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.Angle
StateIndicator20.Font = New System.Drawing.Font("Monotype Corsiva", 18!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
StateIndicator20.Location = CType(resources.GetObject("StateIndicator20.Location"),System.Drawing.PointF)
StateIndicator20.Name = "StateRoundRect6"
StateIndicator20.Style = DevComponents.Instrumentation.StateIndicatorStyle.RoundedRectangular
StateIndicator20.Text = "B2"
StateIndicator20.TextHorizontalOffset = -0.044!
StateIndicator20.TextVerticalOffset = 0.06!
Me.gaugeControl3.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {StateIndicator3, StateIndicator4, StateIndicator5, StateIndicator6, StateIndicator7, StateIndicator8, StateIndicator9, StateIndicator10, StateIndicator11, StateIndicator12, StateIndicator13, StateIndicator14, StateIndicator15, StateIndicator16, StateIndicator17, StateIndicator18, StateIndicator19, StateIndicator20})
Me.gaugeControl3.Location = New System.Drawing.Point(76, 26)
Me.gaugeControl3.Name = "gaugeControl3"
Me.gaugeControl3.Size = New System.Drawing.Size(550, 550)
Me.gaugeControl3.TabIndex = 3
Me.gaugeControl3.Text = "gaugeControl3"
'
'IndTabState
'
Me.IndTabState.AttachedControl = Me.superTabControlPanel32
Me.IndTabState.GlobalItem = false
Me.IndTabState.Name = "IndTabState"
Me.IndTabState.Text = "State"
'
'superTabControlPanel30
'
Me.superTabControlPanel30.Controls.Add(Me.label42)
Me.superTabControlPanel30.Controls.Add(Me.textBox41)
Me.superTabControlPanel30.Controls.Add(Me.gaugeControl1)
Me.superTabControlPanel30.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel30.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel30.Name = "superTabControlPanel30"
Me.superTabControlPanel30.Size = New System.Drawing.Size(703, 603)
Me.superTabControlPanel30.TabIndex = 0
Me.superTabControlPanel30.TabItem = Me.IndTab16Seg
'
'label42
'
Me.label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label42.Location = New System.Drawing.Point(44, 190)
Me.label42.Name = "label42"
Me.label42.Size = New System.Drawing.Size(610, 2)
Me.label42.TabIndex = 73
Me.label42.Text = "label42"
'
'textBox41
'
Me.textBox41.BackColor = System.Drawing.Color.AliceBlue
Me.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox41.Location = New System.Drawing.Point(29, 172)
Me.textBox41.Name = "textBox41"
Me.textBox41.Size = New System.Drawing.Size(66, 16)
Me.textBox41.TabIndex = 74
Me.textBox41.Text = "Samples"
Me.textBox41.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'gaugeControl1
'
Me.gaugeControl1.BackColor = System.Drawing.Color.AliceBlue
GradientFillColor62.Color1 = System.Drawing.Color.Gainsboro
GradientFillColor62.Color2 = System.Drawing.Color.DarkGray
Me.gaugeControl1.Frame.BackColor = GradientFillColor62
GradientFillColor63.BorderColor = System.Drawing.Color.Gainsboro
GradientFillColor63.BorderWidth = 1
GradientFillColor63.Color1 = System.Drawing.Color.White
GradientFillColor63.Color2 = System.Drawing.Color.DimGray
Me.gaugeControl1.Frame.FrameColor = GradientFillColor63
Me.gaugeControl1.Frame.InnerBevel = 0.011!
Me.gaugeControl1.Frame.OuterBevel = 0.008!
NumericIndicator19.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator19.BackColor.BorderWidth = 3
NumericIndicator19.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator19.DecimalColor = System.Drawing.Color.Lime
NumericIndicator19.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator19.DigitColor = System.Drawing.Color.Red
NumericIndicator19.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator19.Location = CType(resources.GetObject("NumericIndicator19.Location"),System.Drawing.PointF)
NumericIndicator19.MaxValue = 10000
NumericIndicator19.Name = "Digital161"
NumericIndicator19.NumberOfDigits = 10
NumericIndicator19.ShowDecimalPoint = true
NumericIndicator19.ShowLeadingZeros = true
NumericIndicator19.Size = New System.Drawing.SizeF(1!, 0.17!)
NumericIndicator19.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator19.Value = 1234.56
NumericIndicator20.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator20.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator20.DecimalColor = System.Drawing.Color.Lime
NumericIndicator20.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator20.DigitColor = System.Drawing.Color.Cyan
NumericIndicator20.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
NumericIndicator20.Location = CType(resources.GetObject("NumericIndicator20.Location"),System.Drawing.PointF)
NumericIndicator20.MaxValue = 10000
NumericIndicator20.Name = "Digital162"
NumericIndicator20.NumberOfDigits = 11
NumericIndicator20.SegmentWidth = 0.7!
NumericIndicator20.SeparatorWidth = 0!
NumericIndicator20.ShowDecimalPoint = true
NumericIndicator20.ShowLeadingZeros = true
NumericIndicator20.Size = New System.Drawing.SizeF(0.7327586!, 0.1206897!)
NumericIndicator20.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator20.Text = "ABCabc/}*@&"
NumericIndicator20.Value = 1234.56
NumericIndicator21.BackColor.BorderColor = System.Drawing.Color.DarkRed
NumericIndicator21.BackColor.BorderWidth = 1
NumericIndicator21.BackColor.Color1 = System.Drawing.Color.Gold
NumericIndicator21.DecimalColor = System.Drawing.Color.Lime
NumericIndicator21.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator21.DigitColor = System.Drawing.Color.Brown
NumericIndicator21.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(128,Byte),Integer))
NumericIndicator21.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Near
NumericIndicator21.Location = CType(resources.GetObject("NumericIndicator21.Location"),System.Drawing.PointF)
NumericIndicator21.MaxValue = 10000
NumericIndicator21.Name = "Digital163"
NumericIndicator21.NumberOfDigits = 19
NumericIndicator21.SegmentWidth = 0.6!
NumericIndicator21.SeparatorWidth = 0!
NumericIndicator21.ShowDecimalPoint = true
NumericIndicator21.ShowLeadingZeros = true
NumericIndicator21.Size = New System.Drawing.SizeF(0.9396552!, 0.0862069!)
NumericIndicator21.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator21.Text = "INPUT LEVELS AT MAX!"
NumericIndicator22.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator22.BackColor.BorderWidth = 3
NumericIndicator22.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator22.DecimalColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
NumericIndicator22.DecimalDimColor = System.Drawing.Color.Indigo
NumericIndicator22.DigitColor = System.Drawing.Color.Aqua
NumericIndicator22.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(74,Byte),Integer))
NumericIndicator22.Location = CType(resources.GetObject("NumericIndicator22.Location"),System.Drawing.PointF)
NumericIndicator22.MaxValue = 10000
NumericIndicator22.MinValue = -10000
NumericIndicator22.Name = "Digital164"
NumericIndicator22.NumberOfDigits = 8
NumericIndicator22.SegmentWidth = 0.7!
NumericIndicator22.SignVisibility = DevComponents.Instrumentation.SignVisibility.Always
NumericIndicator22.Size = New System.Drawing.SizeF(0.4568965!, 0.1293103!)
NumericIndicator22.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator22.Value = 1234.56
NumericIndicator23.BackColor.BorderColor = System.Drawing.Color.Gray
NumericIndicator23.BackColor.BorderWidth = 3
NumericIndicator23.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator23.DecimalColor = System.Drawing.Color.Lime
NumericIndicator23.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator23.DigitColor = System.Drawing.Color.Red
NumericIndicator23.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(94,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator23.Location = CType(resources.GetObject("NumericIndicator23.Location"),System.Drawing.PointF)
NumericIndicator23.MaxValue = 10000
NumericIndicator23.Name = "Digital165"
NumericIndicator23.NumberOfDigits = 8
NumericIndicator23.SegmentWidth = 0.7!
NumericIndicator23.ShearFactor = -0.4!
NumericIndicator23.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator23.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator23.Value = 1234.56
NumericIndicator24.BackColor.BorderColor = System.Drawing.Color.Black
NumericIndicator24.BackColor.BorderWidth = 1
NumericIndicator24.BackColor.Color1 = System.Drawing.Color.DarkRed
NumericIndicator24.DecimalColor = System.Drawing.Color.Lime
NumericIndicator24.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator24.DigitColor = System.Drawing.Color.White
NumericIndicator24.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(50,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
NumericIndicator24.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator24.Location = CType(resources.GetObject("NumericIndicator24.Location"),System.Drawing.PointF)
NumericIndicator24.MaxValue = 10000
NumericIndicator24.MinValue = -10000
NumericIndicator24.Name = "Digital166"
NumericIndicator24.NumberOfDecimals = 3
NumericIndicator24.NumberOfDigits = 12
NumericIndicator24.SegmentWidth = 0.732!
NumericIndicator24.SignVisibility = DevComponents.Instrumentation.SignVisibility.Always
NumericIndicator24.Size = New System.Drawing.SizeF(0.45!, 0.07!)
NumericIndicator24.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator24.Text = "Error 21"
NumericIndicator24.Value = 0
NumericIndicator25.BackColor.BorderColor = System.Drawing.Color.Silver
NumericIndicator25.BackColor.Color1 = System.Drawing.Color.Black
NumericIndicator25.DecimalColor = System.Drawing.Color.Lime
NumericIndicator25.DecimalDimColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(74,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator25.DigitColor = System.Drawing.Color.Red
NumericIndicator25.DigitDimColor = System.Drawing.Color.FromArgb(CType(CType(84,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
NumericIndicator25.DigitPlacement = DevComponents.Instrumentation.DisplayPlacement.Center
NumericIndicator25.FormatString = "C"
NumericIndicator25.Location = CType(resources.GetObject("NumericIndicator25.Location"),System.Drawing.PointF)
NumericIndicator25.MaxValue = 9000000
NumericIndicator25.Name = "Digital167"
NumericIndicator25.NumberOfDigits = 14
NumericIndicator25.SegmentWidth = 0.7!
NumericIndicator25.ShowDecimalPoint = true
NumericIndicator25.ShowDimColonPoints = false
NumericIndicator25.ShowLeadingZeros = true
NumericIndicator25.SignVisibility = DevComponents.Instrumentation.SignVisibility.Never
NumericIndicator25.Size = New System.Drawing.SizeF(0.887931!, 0.112069!)
NumericIndicator25.Style = DevComponents.Instrumentation.NumericIndicatorStyle.Digital16Segment
NumericIndicator25.Value = 7465231.98
Me.gaugeControl1.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {NumericIndicator19, NumericIndicator20, NumericIndicator21, NumericIndicator22, NumericIndicator23, NumericIndicator24, NumericIndicator25})
Me.gaugeControl1.Location = New System.Drawing.Point(76, 26)
Me.gaugeControl1.Name = "gaugeControl1"
Me.gaugeControl1.Size = New System.Drawing.Size(550, 550)
Me.gaugeControl1.TabIndex = 75
Me.gaugeControl1.Text = "gaugeControl1"
'
'IndTab16Seg
'
Me.IndTab16Seg.AttachedControl = Me.superTabControlPanel30
Me.IndTab16Seg.GlobalItem = false
Me.IndTab16Seg.Name = "IndTab16Seg"
Me.IndTab16Seg.Text = "Digital 16 Segment"
'
'ITabElements
'
Me.ITabElements.AttachedControl = Me.superTabControlPanel28
Me.ITabElements.GlobalItem = false
Me.ITabElements.Name = "ITabElements"
Me.ITabElements.Text = "Indicator"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Elements"
'
'superTabControlPanel2
'
Me.superTabControlPanel2.Controls.Add(Me.textBox20)
Me.superTabControlPanel2.Controls.Add(Me.textBox17)
Me.superTabControlPanel2.Controls.Add(Me.label21)
Me.superTabControlPanel2.Controls.Add(Me.label18)
Me.superTabControlPanel2.Controls.Add(Me.textBox33)
Me.superTabControlPanel2.Controls.Add(Me.label34)
Me.superTabControlPanel2.Controls.Add(Me.textBox32)
Me.superTabControlPanel2.Controls.Add(Me.label33)
Me.superTabControlPanel2.Controls.Add(Me.textBox31)
Me.superTabControlPanel2.Controls.Add(Me.label32)
Me.superTabControlPanel2.Controls.Add(Me.textBox29)
Me.superTabControlPanel2.Controls.Add(Me.label30)
Me.superTabControlPanel2.Controls.Add(Me.textBox23)
Me.superTabControlPanel2.Controls.Add(Me.label24)
Me.superTabControlPanel2.Controls.Add(Me.label19)
Me.superTabControlPanel2.Controls.Add(Me.textBox18)
Me.superTabControlPanel2.Controls.Add(Me.textBox34)
Me.superTabControlPanel2.Controls.Add(Me.label35)
Me.superTabControlPanel2.Controls.Add(Me.textBox27)
Me.superTabControlPanel2.Controls.Add(Me.label28)
Me.superTabControlPanel2.Controls.Add(Me.textBox22)
Me.superTabControlPanel2.Controls.Add(Me.label27)
Me.superTabControlPanel2.Controls.Add(Me.textBox25)
Me.superTabControlPanel2.Controls.Add(Me.label26)
Me.superTabControlPanel2.Controls.Add(Me.textBox24)
Me.superTabControlPanel2.Controls.Add(Me.label25)
Me.superTabControlPanel2.Controls.Add(Me.textBox21)
Me.superTabControlPanel2.Controls.Add(Me.label22)
Me.superTabControlPanel2.Controls.Add(Me.textBox19)
Me.superTabControlPanel2.Controls.Add(Me.label20)
Me.superTabControlPanel2.Controls.Add(Me.gcLinearElements)
Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
Me.superTabControlPanel2.Location = New System.Drawing.Point(0, 0)
Me.superTabControlPanel2.Name = "superTabControlPanel2"
Me.superTabControlPanel2.Size = New System.Drawing.Size(820, 638)
Me.superTabControlPanel2.TabIndex = 0
Me.superTabControlPanel2.TabItem = Me.LTabElements
'
'textBox20
'
Me.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox20.Location = New System.Drawing.Point(557, 512)
Me.textBox20.Multiline = true
Me.textBox20.Name = "textBox20"
Me.textBox20.Size = New System.Drawing.Size(71, 37)
Me.textBox20.TabIndex = 68
Me.textBox20.Text = "Bevel"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Outside"
'
'textBox17
'
Me.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox17.Location = New System.Drawing.Point(181, 61)
Me.textBox17.Multiline = true
Me.textBox17.Name = "textBox17"
Me.textBox17.Size = New System.Drawing.Size(65, 37)
Me.textBox17.TabIndex = 67
Me.textBox17.Text = "Bevel"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Inside"
Me.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label21
'
Me.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label21.Location = New System.Drawing.Point(490, 529)
Me.label21.Name = "label21"
Me.label21.Size = New System.Drawing.Size(65, 2)
Me.label21.TabIndex = 66
Me.label21.Text = "label21"
'
'label18
'
Me.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label18.Location = New System.Drawing.Point(247, 79)
Me.label18.Name = "label18"
Me.label18.Size = New System.Drawing.Size(65, 2)
Me.label18.TabIndex = 65
Me.label18.Text = "label18"
'
'textBox33
'
Me.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox33.Location = New System.Drawing.Point(550, 201)
Me.textBox33.Name = "textBox33"
Me.textBox33.Size = New System.Drawing.Size(89, 16)
Me.textBox33.TabIndex = 64
Me.textBox33.Text = "Scale"
'
'label34
'
Me.label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label34.Location = New System.Drawing.Point(416, 209)
Me.label34.Name = "label34"
Me.label34.Size = New System.Drawing.Size(131, 2)
Me.label34.TabIndex = 63
Me.label34.Text = "label34"
'
'textBox32
'
Me.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox32.Location = New System.Drawing.Point(170, 207)
Me.textBox32.Name = "textBox32"
Me.textBox32.Size = New System.Drawing.Size(89, 16)
Me.textBox32.TabIndex = 62
Me.textBox32.Text = "Section"
Me.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label33
'
Me.label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label33.Location = New System.Drawing.Point(265, 216)
Me.label33.Name = "label33"
Me.label33.Size = New System.Drawing.Size(131, 2)
Me.label33.TabIndex = 61
Me.label33.Text = "label33"
'
'textBox31
'
Me.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox31.Location = New System.Drawing.Point(170, 488)
Me.textBox31.Name = "textBox31"
Me.textBox31.Size = New System.Drawing.Size(89, 16)
Me.textBox31.TabIndex = 60
Me.textBox31.Text = "Bulb Style"
Me.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label32
'
Me.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label32.Location = New System.Drawing.Point(265, 497)
Me.label32.Name = "label32"
Me.label32.Size = New System.Drawing.Size(131, 2)
Me.label32.TabIndex = 59
Me.label32.Text = "label32"
'
'textBox29
'
Me.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox29.Location = New System.Drawing.Point(151, 383)
Me.textBox29.Name = "textBox29"
Me.textBox29.Size = New System.Drawing.Size(89, 16)
Me.textBox29.TabIndex = 56
Me.textBox29.Text = "Scale Label"
Me.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label30
'
Me.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label30.Location = New System.Drawing.Point(245, 392)
Me.label30.Name = "label30"
Me.label30.Size = New System.Drawing.Size(100, 2)
Me.label30.TabIndex = 55
Me.label30.Text = "label30"
'
'textBox23
'
Me.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox23.Location = New System.Drawing.Point(137, 158)
Me.textBox23.Multiline = true
Me.textBox23.Name = "textBox23"
Me.textBox23.Size = New System.Drawing.Size(89, 36)
Me.textBox23.TabIndex = 54
Me.textBox23.Text = "Thermometer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Background"
Me.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label24
'
Me.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label24.Location = New System.Drawing.Point(229, 174)
Me.label24.Name = "label24"
Me.label24.Size = New System.Drawing.Size(161, 2)
Me.label24.TabIndex = 53
Me.label24.Text = "label24"
'
'label19
'
Me.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label19.Location = New System.Drawing.Point(242, 128)
Me.label19.Name = "label19"
Me.label19.Size = New System.Drawing.Size(101, 2)
Me.label19.TabIndex = 51
Me.label19.Text = "label19"
'
'textBox18
'
Me.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox18.Location = New System.Drawing.Point(174, 111)
Me.textBox18.Multiline = true
Me.textBox18.Name = "textBox18"
Me.textBox18.Size = New System.Drawing.Size(65, 37)
Me.textBox18.TabIndex = 52
Me.textBox18.Text = "Custom"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Label"
Me.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'textBox34
'
Me.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox34.Location = New System.Drawing.Point(540, 351)
Me.textBox34.Multiline = true
Me.textBox34.Name = "textBox34"
Me.textBox34.Size = New System.Drawing.Size(71, 37)
Me.textBox34.TabIndex = 50
Me.textBox34.Text = "Custom"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Text"
'
'label35
'
Me.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label35.Location = New System.Drawing.Point(469, 366)
Me.label35.Name = "label35"
Me.label35.Size = New System.Drawing.Size(65, 2)
Me.label35.TabIndex = 49
Me.label35.Text = "label35"
'
'textBox27
'
Me.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox27.Location = New System.Drawing.Point(528, 429)
Me.textBox27.Multiline = true
Me.textBox27.Name = "textBox27"
Me.textBox27.Size = New System.Drawing.Size(101, 38)
Me.textBox27.TabIndex = 36
Me.textBox27.Text = "Pointer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Thermometer)"
'
'label28
'
Me.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label28.Location = New System.Drawing.Point(398, 436)
Me.label28.Name = "label28"
Me.label28.Size = New System.Drawing.Size(125, 2)
Me.label28.TabIndex = 35
Me.label28.Text = "label28"
'
'textBox22
'
Me.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox22.Location = New System.Drawing.Point(149, 275)
Me.textBox22.Multiline = true
Me.textBox22.Name = "textBox22"
Me.textBox22.Size = New System.Drawing.Size(50, 37)
Me.textBox22.TabIndex = 34
Me.textBox22.Text = "Pointer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Bar)"
Me.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
'
'label27
'
Me.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label27.Location = New System.Drawing.Point(202, 293)
Me.label27.Name = "label27"
Me.label27.Size = New System.Drawing.Size(160, 2)
Me.label27.TabIndex = 31
Me.label27.Text = "label27"
'
'textBox25
'
Me.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox25.Location = New System.Drawing.Point(528, 254)
Me.textBox25.Name = "textBox25"
Me.textBox25.Size = New System.Drawing.Size(101, 16)
Me.textBox25.TabIndex = 30
Me.textBox25.Text = "Major Tickmark"
'
'label26
'
Me.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label26.Location = New System.Drawing.Point(413, 262)
Me.label26.Name = "label26"
Me.label26.Size = New System.Drawing.Size(111, 2)
Me.label26.TabIndex = 29
Me.label26.Text = "label26"
'
'textBox24
'
Me.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox24.Location = New System.Drawing.Point(528, 282)
Me.textBox24.Name = "textBox24"
Me.textBox24.Size = New System.Drawing.Size(101, 16)
Me.textBox24.TabIndex = 28
Me.textBox24.Text = "Minor Tickmark"
'
'label25
'
Me.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label25.Location = New System.Drawing.Point(413, 290)
Me.label25.Name = "label25"
Me.label25.Size = New System.Drawing.Size(111, 2)
Me.label25.TabIndex = 27
Me.label25.Text = "label25"
'
'textBox21
'
Me.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox21.Location = New System.Drawing.Point(567, 79)
Me.textBox21.Name = "textBox21"
Me.textBox21.Size = New System.Drawing.Size(54, 16)
Me.textBox21.TabIndex = 22
Me.textBox21.Text = "Image"
'
'label22
'
Me.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label22.Location = New System.Drawing.Point(423, 87)
Me.label22.Name = "label22"
Me.label22.Size = New System.Drawing.Size(141, 2)
Me.label22.TabIndex = 21
Me.label22.Text = "label22"
'
'textBox19
'
Me.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.textBox19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.textBox19.Location = New System.Drawing.Point(544, 135)
Me.textBox19.Multiline = true
Me.textBox19.Name = "textBox19"
Me.textBox19.Size = New System.Drawing.Size(54, 38)
Me.textBox19.TabIndex = 18
Me.textBox19.Text = "Pointer"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Marker)"
'
'label20
'
Me.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.label20.Location = New System.Drawing.Point(428, 149)
Me.label20.Name = "label20"
Me.label20.Size = New System.Drawing.Size(111, 2)
Me.label20.TabIndex = 17
Me.label20.Text = "label20"
'
'gcLinearElements
'
Me.gcLinearElements.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
GaugeText17.Angle = 270!
GaugeText17.BackColor.BorderColor = System.Drawing.Color.Black
GaugeText17.ForeColor = System.Drawing.Color.Cyan
GaugeText17.Location = CType(resources.GetObject("GaugeText17.Location"),System.Drawing.PointF)
GaugeText17.Name = "Text1"
GaugeText17.Size = New System.Drawing.SizeF(0.387931!, 0.612069!)
GaugeText17.Text = "Melting Point"
GaugeImage6.Image = CType(resources.GetObject("GaugeImage6.Image"),System.Drawing.Image)
GaugeImage6.Location = CType(resources.GetObject("GaugeImage6.Location"),System.Drawing.PointF)
GaugeImage6.Name = "Image1"
GaugeImage6.Size = New System.Drawing.SizeF(0.1!, 0.1!)
GaugeImage7.Image = CType(resources.GetObject("GaugeImage7.Image"),System.Drawing.Image)
GaugeImage7.Location = CType(resources.GetObject("GaugeImage7.Location"),System.Drawing.PointF)
GaugeImage7.Name = "Image2"
GaugeImage7.Size = New System.Drawing.SizeF(0.1!, 0.1!)
Me.gcLinearElements.GaugeItems.AddRange(New DevComponents.Instrumentation.GaugeItem() {GaugeText17, GaugeImage6, GaugeImage7})
GaugeCustomLabel15.Layout.ForeColor = System.Drawing.Color.Cyan
GaugeCustomLabel15.Layout.ScaleOffset = 0.038!
GaugeCustomLabel15.Name = "Cold"
GaugeCustomLabel15.Text = "Cold"
GaugeCustomLabel15.Value = 0
GaugeCustomLabel16.Layout.ForeColor = System.Drawing.Color.Red
GaugeCustomLabel16.Layout.ScaleOffset = 0.038!
GaugeCustomLabel16.Name = "Hot"
GaugeCustomLabel16.Text = "Hot"
GaugeCustomLabel16.Value = 50
GaugeLinearScale17.CustomLabels.AddRange(New DevComponents.Instrumentation.GaugeCustomLabel() {GaugeCustomLabel15, GaugeCustomLabel16})
GaugeLinearScale17.Labels.FormatString = "####°"
GaugeLinearScale17.Labels.Layout.ScaleOffset = 0.038!
GaugeLinearScale17.Location = CType(resources.GetObject("GaugeLinearScale17.Location"),System.Drawing.PointF)
GaugeLinearScale17.MaxPin.EndOffset = 0.035!
GaugeLinearScale17.MaxPin.Name = "MaxPin"
GaugeLinearScale17.MaxValue = 50
GaugeLinearScale17.MinPin.EndOffset = 0.035!
GaugeLinearScale17.MinPin.Name = "MinPin"
GaugeLinearScale17.Name = "Scale1"
GaugeLinearScale17.Orientation = System.Windows.Forms.Orientation.Vertical
GaugePointer57.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer57.CapFillColor.BorderWidth = 1
GaugePointer57.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer57.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer57.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer57.FillColor.BorderWidth = 1
GaugePointer57.FillColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
GaugePointer57.FillColor.Color2 = System.Drawing.Color.FromArgb(CType(CType(220,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
GaugePointer57.Name = "Thermo"
GaugePointer57.Style = DevComponents.Instrumentation.PointerStyle.Thermometer
GaugePointer57.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer57.ThermoBackColor.BorderWidth = 1
GaugePointer57.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer57.Value = 15
GaugePointer58.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer58.CapFillColor.BorderWidth = 1
GaugePointer58.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer58.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer58.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer58.FillColor.BorderWidth = 1
GaugePointer58.FillColor.Color1 = System.Drawing.Color.Yellow
GaugePointer58.Name = "Marker"
GaugePointer58.Placement = DevComponents.Instrumentation.DisplayPlacement.Far
GaugePointer58.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer58.ThermoBackColor.BorderWidth = 1
GaugePointer58.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer58.Value = 47
GaugePointer59.BarStyle = DevComponents.Instrumentation.BarPointerStyle.Rounded
GaugePointer59.CapFillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer59.CapFillColor.BorderWidth = 1
GaugePointer59.CapFillColor.Color1 = System.Drawing.Color.WhiteSmoke
GaugePointer59.CapFillColor.Color2 = System.Drawing.Color.DimGray
GaugePointer59.FillColor.BorderColor = System.Drawing.Color.DimGray
GaugePointer59.FillColor.BorderWidth = 1
GaugePointer59.FillColor.Color1 = System.Drawing.Color.DarkCyan
GaugePointer59.FillColor.Color2 = System.Drawing.Color.Cyan
GaugePointer59.FillColor.GradientFillType = DevComponents.Instrumentation.GradientFillType.StartToEnd
GaugePointer59.HonorMinPin = false
GaugePointer59.Name = "Bar"
GaugePointer59.Origin = DevComponents.Instrumentation.PointerOrigin.Custom
GaugePointer59.OriginInterval = 15
GaugePointer59.Placement = DevComponents.Instrumentation.DisplayPlacement.Near
GaugePointer59.ScaleOffset = 0.167!
GaugePointer59.Style = DevComponents.Instrumentation.PointerStyle.Bar
GaugePointer59.ThermoBackColor.BorderColor = System.Drawing.Color.Black
GaugePointer59.ThermoBackColor.BorderWidth = 1
GaugePointer59.ThermoBackColor.Color1 = System.Drawing.Color.FromArgb(CType(CType(100,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer), CType(CType(60,Byte),Integer))
GaugePointer59.UnderTickMarks = true
GaugePointer59.Value = 35
GaugePointer59.Width = 0.096!
GaugeLinearScale17.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer57, GaugePointer58, GaugePointer59})
GaugeSection58.FillColor.Color1 = System.Drawing.Color.CornflowerBlue
GaugeSection58.FillColor.Color2 = System.Drawing.Color.Purple
GaugeSection58.Name = "Section1"
GaugeLinearScale17.Sections.AddRange(New DevComponents.Instrumentation.GaugeSection() {GaugeSection58})
GaugeLinearScale17.Size = New System.Drawing.SizeF(0.7413793!, 0.6724138!)
Me.gcLinearElements.LinearScales.AddRange(New DevComponents.Instrumentation.GaugeLinearScale() {GaugeLinearScale17})
Me.gcLinearElements.Location = New System.Drawing.Point(300, 51)
Me.gcLinearElements.Name = "gcLinearElements"
Me.gcLinearElements.Size = New System.Drawing.Size(195, 500)
Me.gcLinearElements.TabIndex = 0
'
'LTabElements
'
Me.LTabElements.AttachedControl = Me.superTabControlPanel2
Me.LTabElements.GlobalItem = false
Me.LTabElements.Name = "LTabElements"
Me.LTabElements.Text = "Linear"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Gauge Elements"
'
'galleryContainer1
'
'
'
'
Me.galleryContainer1.BackgroundStyle.Class = ""
Me.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.galleryContainer1.EnableGalleryPopup = false
Me.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
Me.galleryContainer1.MinimumSize = New System.Drawing.Size(150, 200)
Me.galleryContainer1.MultiLine = false
Me.galleryContainer1.Name = "galleryContainer1"
Me.galleryContainer1.PopupUsesStandardScrollbars = false
'
'galleryContainer2
'
'
'
'
Me.galleryContainer2.BackgroundStyle.Class = ""
Me.galleryContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.galleryContainer2.EnableGalleryPopup = false
Me.galleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
Me.galleryContainer2.MinimumSize = New System.Drawing.Size(150, 200)
Me.galleryContainer2.MultiLine = false
Me.galleryContainer2.Name = "galleryContainer2"
Me.galleryContainer2.PopupUsesStandardScrollbars = false
'
'galleryContainer3
'
'
'
'
Me.galleryContainer3.BackgroundStyle.Class = ""
Me.galleryContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
Me.galleryContainer3.EnableGalleryPopup = false
Me.galleryContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
Me.galleryContainer3.MinimumSize = New System.Drawing.Size(150, 200)
Me.galleryContainer3.MultiLine = false
Me.galleryContainer3.Name = "galleryContainer3"
Me.galleryContainer3.PopupUsesStandardScrollbars = false
'
'Form1
'
Me.ClientSize = New System.Drawing.Size(820, 638)
Me.Controls.Add(Me.superTabControl1)
Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
Me.Name = "Form1"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "GaugeControl Sample Application"
CType(Me.superTabControl1,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControl1.ResumeLayout(false)
Me.superTabControlPanel3.ResumeLayout(false)
CType(Me.superTabControl2,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControl2.ResumeLayout(false)
Me.superTabControlPanel17.ResumeLayout(false)
CType(Me.gcCircular8a,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.gcCircular8b,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel15.ResumeLayout(false)
CType(Me.gcCircular7c,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.gcCircular7b,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.gcCircular7a,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel16.ResumeLayout(false)
CType(Me.gcCircular6,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel5.ResumeLayout(false)
CType(Me.gcCircular5,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel18.ResumeLayout(false)
CType(Me.gcCircular1,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel8.ResumeLayout(false)
CType(Me.gcCircular2,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel4.ResumeLayout(false)
CType(Me.gcCircular4,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel6.ResumeLayout(false)
CType(Me.gcCircular3,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel1.ResumeLayout(false)
Me.superTabControlPanel1.PerformLayout
CType(Me.gcCircularElements,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel22.ResumeLayout(false)
CType(Me.superTabControl4,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControl4.ResumeLayout(false)
Me.superTabControlPanel21.ResumeLayout(false)
CType(Me.gcPointerChange,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel26.ResumeLayout(false)
CType(Me.gcScaleLimits,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel25.ResumeLayout(false)
CType(Me.gcHitTesting,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel24.ResumeLayout(false)
CType(Me.gcEnterLeave,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel23.ResumeLayout(false)
CType(Me.gcUserRendering,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel9.ResumeLayout(false)
CType(Me.superTabControl3,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControl3.ResumeLayout(false)
Me.superTabControlPanel13.ResumeLayout(false)
CType(Me.gcLinear1,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel14.ResumeLayout(false)
CType(Me.gcLinear8,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel19.ResumeLayout(false)
CType(Me.gcLinear7,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel20.ResumeLayout(false)
CType(Me.gcLinear6,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel7.ResumeLayout(false)
CType(Me.gcLinear5,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel10.ResumeLayout(false)
CType(Me.gcLinear4,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel11.ResumeLayout(false)
CType(Me.gcLinear3,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel12.ResumeLayout(false)
CType(Me.gcLinear2,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel27.ResumeLayout(false)
CType(Me.gcMixedScale,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel28.ResumeLayout(false)
CType(Me.superTabControl5,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControl5.ResumeLayout(false)
Me.superTabControlPanel29.ResumeLayout(false)
Me.superTabControlPanel29.PerformLayout
CType(Me.gcIndicatorElements,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel31.ResumeLayout(false)
Me.superTabControlPanel31.PerformLayout
CType(Me.gaugeControl2,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel32.ResumeLayout(false)
Me.superTabControlPanel32.PerformLayout
CType(Me.gaugeControl3,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel30.ResumeLayout(false)
Me.superTabControlPanel30.PerformLayout
CType(Me.gaugeControl1,System.ComponentModel.ISupportInitialize).EndInit
Me.superTabControlPanel2.ResumeLayout(false)
Me.superTabControlPanel2.PerformLayout
CType(Me.gcLinearElements,System.ComponentModel.ISupportInitialize).EndInit
Me.ResumeLayout(false)

End Sub

#End Region

        Private superTabControl1 As DevComponents.DotNetBar.SuperTabControl
        Private superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
        Private CTabElements As DevComponents.DotNetBar.SuperTabItem
        Private gcCircularElements As DevComponents.Instrumentation.GaugeControl
        Private label1 As Label
        Private label5 As Label
        Private textBox4 As TextBox
        Private label4 As Label
        Private textBox3 As TextBox
        Private label3 As Label
        Private textBox2 As TextBox
        Private label2 As Label
        Private textBox1 As TextBox
        Private label8 As Label
        Private textBox7 As TextBox
        Private label7 As Label
        Private textBox6 As TextBox
        Private label6 As Label
        Private textBox5 As TextBox
        Private textBox10 As TextBox
        Private label10 As Label
        Private textBox9 As TextBox
        Private label9 As Label
        Private textBox8 As TextBox
        Private label11 As Label
        Private textBox11 As TextBox
        Private label12 As Label
        Private label15 As Label
        Private textBox13 As TextBox
        Private label14 As Label
        Private textBox12 As TextBox
        Private label13 As Label
        Private textBox16 As TextBox
        Private label17 As Label
        Private textBox15 As TextBox
        Private label16 As Label
        Private textBox14 As TextBox
        Private superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
        Private LTabElements As DevComponents.DotNetBar.SuperTabItem
        Private gcLinearElements As DevComponents.Instrumentation.GaugeControl
        Private textBox19 As TextBox
        Private label20 As Label
        Private textBox21 As TextBox
        Private label22 As Label
        Private label27 As Label
        Private textBox25 As TextBox
        Private label26 As Label
        Private textBox24 As TextBox
        Private label25 As Label
        Private textBox27 As TextBox
        Private label28 As Label
        Private textBox22 As TextBox
        Private textBox34 As TextBox
        Private label35 As Label
        Private textBox35 As TextBox
        Private label36 As Label
        Private superTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabControl2 As DevComponents.DotNetBar.SuperTabControl
        Private superTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab4 As DevComponents.DotNetBar.SuperTabItem
        Private CTabSamples As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel8 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab2 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel6 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab3 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab5 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel9 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabControl3 As DevComponents.DotNetBar.SuperTabControl
        Private superTabControlPanel10 As DevComponents.DotNetBar.SuperTabControlPanel
        Private linearTab4 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel11 As DevComponents.DotNetBar.SuperTabControlPanel
        Private linearTab3 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel13 As DevComponents.DotNetBar.SuperTabControlPanel
        Private linearTab1 As DevComponents.DotNetBar.SuperTabItem
        Private LTabSamples As DevComponents.DotNetBar.SuperTabItem
        Private textBox33 As TextBox
        Private label34 As Label
        Private textBox32 As TextBox
        Private label33 As Label
        Private textBox31 As TextBox
        Private label32 As Label
        Private textBox29 As TextBox
        Private label30 As Label
        Private textBox23 As TextBox
        Private label24 As Label
        Private label19 As Label
        Private textBox18 As TextBox
        Private textBox20 As TextBox
        Private textBox17 As TextBox
        Private label21 As Label
        Private label18 As Label
        Private WithEvents gcCircular4 As DevComponents.Instrumentation.GaugeControl
        Private gcCircular5 As DevComponents.Instrumentation.GaugeControl
        Private gcCircular3 As DevComponents.Instrumentation.GaugeControl
        Private superTabControlPanel15 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab7 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel17 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab8 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel16 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab6 As DevComponents.DotNetBar.SuperTabItem
        Private gcCircular6 As DevComponents.Instrumentation.GaugeControl
        Private superTabControlPanel18 As DevComponents.DotNetBar.SuperTabControlPanel
        Private circularTab1 As DevComponents.DotNetBar.SuperTabItem
        Private gcLinear4 As DevComponents.Instrumentation.GaugeControl
        Private gcLinear1 As DevComponents.Instrumentation.GaugeControl
        Private gcLinear3 As DevComponents.Instrumentation.GaugeControl
        Private superTabControlPanel7 As DevComponents.DotNetBar.SuperTabControlPanel
        Private linearTab5 As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents gcLinear5 As DevComponents.Instrumentation.GaugeControl
        Private superTabControlPanel19 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents gcLinear7 As DevComponents.Instrumentation.GaugeControl
        Private linearTab7 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel20 As DevComponents.DotNetBar.SuperTabControlPanel
        Private linearTab6 As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents gcLinear6 As DevComponents.Instrumentation.GaugeControl
        Private superTabControlPanel12 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents gcLinear2 As DevComponents.Instrumentation.GaugeControl
        Private linearTab2 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel14 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents gcLinear8 As DevComponents.Instrumentation.GaugeControl
        Private linearTab8 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel22 As DevComponents.DotNetBar.SuperTabControlPanel
        Private TabEvents As DevComponents.DotNetBar.SuperTabItem
        Private superTabControl4 As DevComponents.DotNetBar.SuperTabControl
        Private superTabControlPanel23 As DevComponents.DotNetBar.SuperTabControlPanel
        Private tabUserRendering As DevComponents.DotNetBar.SuperTabItem
        Private gcUserRendering As DevComponents.Instrumentation.GaugeControl
        Private WithEvents cbBackground As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbSection As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbBar As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbRange As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbNeedle As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX1 As DevComponents.DotNetBar.LabelX
        Private superTabControlPanel24 As DevComponents.DotNetBar.SuperTabControlPanel
        Private tabEnterLeave As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents btnAuto As DevComponents.DotNetBar.ButtonX
        Private rtb1 As RichTextBox
        Private WithEvents sliderDampen1 As DevComponents.DotNetBar.Controls.Slider
        Private WithEvents btnMin As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnMax As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnMinus20 As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnPlus30 As DevComponents.DotNetBar.ButtonX
        Private labelX2 As DevComponents.DotNetBar.LabelX
        Private WithEvents btnClear As DevComponents.DotNetBar.ButtonX
        Private labelX3 As DevComponents.DotNetBar.LabelX
        Private superTabControlPanel25 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents btnRtb2Clear As DevComponents.DotNetBar.ButtonX
        Private rtb2 As RichTextBox
        Private labelX4 As DevComponents.DotNetBar.LabelX
        Private WithEvents gcHitTesting As DevComponents.Instrumentation.GaugeControl
        Private tabHitTesting As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents cbCAutoOrientLabels As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents sliderCAngle As DevComponents.DotNetBar.Controls.Slider
        Private WithEvents cbCRotateLabels As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbRotateCap As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX5 As DevComponents.DotNetBar.LabelX
        Private labelX6 As DevComponents.DotNetBar.LabelX
        Private labelX7 As DevComponents.DotNetBar.LabelX
        Private labelX8 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbUnderTickmarks As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents rbFlask As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents rbBulb As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX9 As DevComponents.DotNetBar.LabelX
        Private labelX10 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbSetSnap As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX11 As DevComponents.DotNetBar.LabelX
        Private labelX12 As DevComponents.DotNetBar.LabelX
        Private WithEvents colorPickerButton2 As DevComponents.DotNetBar.ColorPickerButton
        Private WithEvents colorPickerButton1 As DevComponents.DotNetBar.ColorPickerButton
        Private WithEvents cbFillMode As DevComponents.DotNetBar.Controls.ComboBoxEx
        Private None As DevComponents.Editors.ComboItem
        Private AutoComboItem As DevComponents.Editors.ComboItem
        Private Center As DevComponents.Editors.ComboItem
        Private HCenter As DevComponents.Editors.ComboItem
        Private VCenter As DevComponents.Editors.ComboItem
        Private StartToEnd As DevComponents.Editors.ComboItem
        Private Angle As DevComponents.Editors.ComboItem
        Private WithEvents cbSliderAngle As DevComponents.DotNetBar.Controls.Slider
        Private superTabControlPanel21 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents gcPointerChange As DevComponents.Instrumentation.GaugeControl
        Private tabPointerChange As DevComponents.DotNetBar.SuperTabItem
        Private labelX13 As DevComponents.DotNetBar.LabelX
        Private labelX14 As DevComponents.DotNetBar.LabelX
        Private cbShowRangeEvents As DevComponents.DotNetBar.Controls.CheckBoxX
        Private cbShowSectionEvents As DevComponents.DotNetBar.Controls.CheckBoxX
        Private cbShowScaleEvents As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX16 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbFrame As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbMarker As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbShowTooltips As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX15 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbCAddGlassEffect As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbReverse2 As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbReverse1 As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX17 As DevComponents.DotNetBar.LabelX
        Private labelX19 As DevComponents.DotNetBar.LabelX
        Private labelX18 As DevComponents.DotNetBar.LabelX
        Private labelX20 As DevComponents.DotNetBar.LabelX
        Private labelX22 As DevComponents.DotNetBar.LabelX
        Private labelX21 As DevComponents.DotNetBar.LabelX
        Private WithEvents rbRoundRect As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents rbRect As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents rbCircular As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents rbNone As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents sliderArc As DevComponents.DotNetBar.Controls.Slider
        Private labelX23 As DevComponents.DotNetBar.LabelX
        Private labelX25 As DevComponents.DotNetBar.LabelX
        Private labelX24 As DevComponents.DotNetBar.LabelX
        Private superTabControlPanel26 As DevComponents.DotNetBar.SuperTabControlPanel
        Private tabLimits As DevComponents.DotNetBar.SuperTabItem
        Private gcScaleLimits As GaugeControl
        Private labelX27 As DevComponents.DotNetBar.LabelX
        Private labelX26 As DevComponents.DotNetBar.LabelX
        Private WithEvents btnAuto2 As DevComponents.DotNetBar.ButtonX
        Private WithEvents cbSliderDampen2 As DevComponents.DotNetBar.Controls.Slider
        Private WithEvents btnMin2 As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnMax2 As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnMinus10 As DevComponents.DotNetBar.ButtonX
        Private WithEvents btnPlus20 As DevComponents.DotNetBar.ButtonX
        Private WithEvents cbSetLimits As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX28 As DevComponents.DotNetBar.LabelX
        Private labelX29 As DevComponents.DotNetBar.LabelX
        Private labelX30 As DevComponents.DotNetBar.LabelX
        Private galleryContainer1 As DevComponents.DotNetBar.GalleryContainer
        Private galleryContainer2 As DevComponents.DotNetBar.GalleryContainer
        Private galleryContainer3 As DevComponents.DotNetBar.GalleryContainer
        Private labelX31 As DevComponents.DotNetBar.LabelX
        Private labelX32 As DevComponents.DotNetBar.LabelX
        Private WithEvents sliderScaleAngle As DevComponents.DotNetBar.Controls.Slider
        Private labelX33 As DevComponents.DotNetBar.LabelX
        Private WithEvents sliderMaxPin As DevComponents.DotNetBar.Controls.Slider
        Private labelX34 As DevComponents.DotNetBar.LabelX
        Private labelX35 As DevComponents.DotNetBar.LabelX
        Private WithEvents cbHonorMinPin As DevComponents.DotNetBar.Controls.CheckBoxX
        Private WithEvents cbHonorMaxPin As DevComponents.DotNetBar.Controls.CheckBoxX
        Private labelX37 As DevComponents.DotNetBar.LabelX
        Private labelX36 As DevComponents.DotNetBar.LabelX
        Private labelX39 As DevComponents.DotNetBar.LabelX
        Private labelX38 As DevComponents.DotNetBar.LabelX
        Private superTabControlPanel27 As DevComponents.DotNetBar.SuperTabControlPanel
        Private labelX41 As DevComponents.DotNetBar.LabelX
        Private labelX40 As DevComponents.DotNetBar.LabelX
        Private WithEvents gcMixedScale As GaugeControl
        Private TabMixedScale As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
        Private WithEvents superTabControlPanel28 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents superTabControl5 As DevComponents.DotNetBar.SuperTabControl
        Private WithEvents superTabControlPanel29 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents textBox44 As System.Windows.Forms.TextBox
        Private WithEvents label45 As System.Windows.Forms.Label
        Private WithEvents textBox43 As System.Windows.Forms.TextBox
        Private WithEvents label44 As System.Windows.Forms.Label
        Private WithEvents textBox42 As System.Windows.Forms.TextBox
        Private WithEvents label43 As System.Windows.Forms.Label
        Private WithEvents label23 As System.Windows.Forms.Label
        Private WithEvents textBox36 As System.Windows.Forms.TextBox
        Private WithEvents textBox30 As System.Windows.Forms.TextBox
        Private WithEvents label37 As System.Windows.Forms.Label
        Private WithEvents textBox28 As System.Windows.Forms.TextBox
        Private WithEvents label29 As System.Windows.Forms.Label
        Private WithEvents textBox26 As System.Windows.Forms.TextBox
        Private WithEvents label31 As System.Windows.Forms.Label
        Private WithEvents gcIndicatorElements As DevComponents.Instrumentation.GaugeControl
        Private WithEvents IndMechanical As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents superTabControlPanel32 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents label47 As System.Windows.Forms.Label
        Private WithEvents label46 As System.Windows.Forms.Label
        Private WithEvents textBox47 As System.Windows.Forms.TextBox
        Private WithEvents textBox46 As System.Windows.Forms.TextBox
        Private WithEvents textBox45 As System.Windows.Forms.TextBox
        Private WithEvents gaugeControl3 As DevComponents.Instrumentation.GaugeControl
        Private WithEvents IndTabState As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents superTabControlPanel30 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents label42 As System.Windows.Forms.Label
        Private WithEvents textBox41 As System.Windows.Forms.TextBox
        Private WithEvents gaugeControl1 As DevComponents.Instrumentation.GaugeControl
        Private WithEvents IndTab16Seg As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents superTabControlPanel31 As DevComponents.DotNetBar.SuperTabControlPanel
        Private WithEvents textBox48 As System.Windows.Forms.TextBox
        Private WithEvents label48 As System.Windows.Forms.Label
        Private WithEvents label41 As System.Windows.Forms.Label
        Private WithEvents textBox40 As System.Windows.Forms.TextBox
        Private WithEvents textBox39 As System.Windows.Forms.TextBox
        Private WithEvents textBox38 As System.Windows.Forms.TextBox
        Private WithEvents textBox37 As System.Windows.Forms.TextBox
        Private WithEvents label40 As System.Windows.Forms.Label
        Private WithEvents label39 As System.Windows.Forms.Label
        Private WithEvents label38 As System.Windows.Forms.Label
        Private WithEvents gaugeControl2 As DevComponents.Instrumentation.GaugeControl
        Private WithEvents IndTab7Seg As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents ITabElements As DevComponents.DotNetBar.SuperTabItem
        Private WithEvents gcCircular1 As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcCircular2 As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcEnterLeave As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcCircular7a As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcCircular7c As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcCircular7b As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcCircular8a As DevComponents.Instrumentation.GaugeControl
        Private WithEvents gcCircular8b As DevComponents.Instrumentation.GaugeControl
	End Class
End Namespace

