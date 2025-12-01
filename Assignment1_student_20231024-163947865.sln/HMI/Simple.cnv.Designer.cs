/*
 * Created by EcoStruxure Automation Expert.
 * User: vv263
 * Date: 7/28/2023
 * Time: 10:38 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Simple.
	/// </summary>
	partial class Simple
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.sDefault1 = new HMI.Main.Symbols.Lift.sDefault();
			this.sDefault2 = new HMI.Main.Symbols.Door.sDefault();
			this.sDefault3 = new HMI.Main.Symbols.Door.sDefault();
			this.sDefault4 = new HMI.Main.Symbols.Door.sDefault();
			this.sDefault5 = new HMI.Main.Symbols.ReqPanelLift.sDefault();
			this.sDefault6 = new HMI.Main.Symbols.FloorIndicator.sDefault();
			this.sDefault7 = new HMI.Main.Symbols.FloorIndicator.sDefault();
			this.sDefault8 = new HMI.Main.Symbols.FloorIndicator.sDefault();
			this.sDefault9 = new HMI.Main.Symbols.CallButton.sDefault();
			this.sDefault10 = new HMI.Main.Symbols.CallButton.sDefault();
			this.sDefault11 = new HMI.Main.Symbols.CallButton.sDefault();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(271D)), ((float)(32D)), ((float)(329D)), ((float)(180D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(271D, 212D),
			new NxtControl.Drawing.PointF(375D, 212D),
			new NxtControl.Drawing.PointF(375D, 91D),
			new NxtControl.Drawing.PointF(481D, 91D),
			new NxtControl.Drawing.PointF(481D, 212D),
			new NxtControl.Drawing.PointF(600D, 212D),
			new NxtControl.Drawing.PointF(600D, 32D),
			new NxtControl.Drawing.PointF(271D, 32D),
			new NxtControl.Drawing.PointF(271D, 212D),
			new NxtControl.Drawing.PointF(271D, 212D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(271D)), ((float)(219D)), ((float)(329D)), ((float)(180D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(271D, 399D),
			new NxtControl.Drawing.PointF(375D, 399D),
			new NxtControl.Drawing.PointF(375D, 278D),
			new NxtControl.Drawing.PointF(481D, 278D),
			new NxtControl.Drawing.PointF(481D, 399D),
			new NxtControl.Drawing.PointF(600D, 399D),
			new NxtControl.Drawing.PointF(600D, 219D),
			new NxtControl.Drawing.PointF(271D, 219D),
			new NxtControl.Drawing.PointF(271D, 399D),
			new NxtControl.Drawing.PointF(271D, 399D),
			new NxtControl.Drawing.PointF(271D, 399D),
			new NxtControl.Drawing.PointF(271D, 399D),
			new NxtControl.Drawing.PointF(271D, 399D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(271D)), ((float)(407D)), ((float)(329D)), ((float)(180D)));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(271D, 587D),
			new NxtControl.Drawing.PointF(375D, 587D),
			new NxtControl.Drawing.PointF(375D, 466D),
			new NxtControl.Drawing.PointF(481D, 466D),
			new NxtControl.Drawing.PointF(481D, 587D),
			new NxtControl.Drawing.PointF(600D, 587D),
			new NxtControl.Drawing.PointF(600D, 407D),
			new NxtControl.Drawing.PointF(271D, 407D),
			new NxtControl.Drawing.PointF(271D, 587D),
			new NxtControl.Drawing.PointF(271D, 587D),
			new NxtControl.Drawing.PointF(271D, 587D),
			new NxtControl.Drawing.PointF(271D, 587D)});
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(584D)), ((float)(600D)), ((float)(21D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(208D)), ((float)(329D)), ((float)(18D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(400D)), ((float)(329D)), ((float)(18D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 380D, 64D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "41024E968D96F537.FB1";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 376D, 464D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "41024E968D96F537.Door0";
			this.sDefault2.EndInit();
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 376D, 279D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.TagName = "41024E968D96F537.Door1";
			this.sDefault3.EndInit();
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 376D, 88D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.TagName = "41024E968D96F537.Door2";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 168D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "41024E968D96F537.FB3";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 408D, 56D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.TagName = "41024E968D96F537.FB2";
			this.sDefault6.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 416D, 248D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.TagName = "41024E968D96F537.FB2";
			this.sDefault7.EndInit();
			// 
			// sDefault8
			// 
			this.sDefault8.BeginInit();
			this.sDefault8.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 416D, 432D);
			this.sDefault8.Name = "sDefault8";
			this.sDefault8.SecurityToken = ((uint)(4294967295u));
			this.sDefault8.TagName = "41024E968D96F537.FB2";
			this.sDefault8.EndInit();
			// 
			// sDefault9
			// 
			this.sDefault9.BeginInit();
			this.sDefault9.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 496D, 504D);
			this.sDefault9.Name = "sDefault9";
			this.sDefault9.SecurityToken = ((uint)(4294967295u));
			this.sDefault9.TagName = "41024E968D96F537.Button0";
			this.sDefault9.EndInit();
			// 
			// sDefault10
			// 
			this.sDefault10.BeginInit();
			this.sDefault10.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 496D, 320D);
			this.sDefault10.Name = "sDefault10";
			this.sDefault10.SecurityToken = ((uint)(4294967295u));
			this.sDefault10.TagName = "41024E968D96F537.Button1";
			this.sDefault10.EndInit();
			// 
			// sDefault11
			// 
			this.sDefault11.BeginInit();
			this.sDefault11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 496D, 144D);
			this.sDefault11.Name = "sDefault11";
			this.sDefault11.SecurityToken = ((uint)(4294967295u));
			this.sDefault11.TagName = "41024E968D96F537.Button2";
			this.sDefault11.EndInit();
			// 
			// Simple
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(600D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Simple";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.rectangle1,
			this.rectangle2,
			this.rectangle3,
			this.polygon2,
			this.polygon1,
			this.polygon3,
			this.sDefault2,
			this.sDefault3,
			this.sDefault4,
			this.sDefault5,
			this.sDefault6,
			this.sDefault7,
			this.sDefault8,
			this.sDefault9,
			this.sDefault10,
			this.sDefault11});
			this.Size = new System.Drawing.Size(600, 600);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private HMI.Main.Symbols.Lift.sDefault sDefault1;
		private HMI.Main.Symbols.Door.sDefault sDefault2;
		private HMI.Main.Symbols.Door.sDefault sDefault3;
		private HMI.Main.Symbols.Door.sDefault sDefault4;
		private HMI.Main.Symbols.ReqPanelLift.sDefault sDefault5;
		private HMI.Main.Symbols.FloorIndicator.sDefault sDefault6;
		private HMI.Main.Symbols.FloorIndicator.sDefault sDefault7;
		private HMI.Main.Symbols.FloorIndicator.sDefault sDefault8;
		private HMI.Main.Symbols.CallButton.sDefault sDefault9;
		private HMI.Main.Symbols.CallButton.sDefault sDefault10;
		private HMI.Main.Symbols.CallButton.sDefault sDefault11;
		#endregion
	}
}
