using BindableProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGraphics.Componentes
{
	public partial class Grafico : BindableObject, IDrawable
	{
		[BindableProp]
		private int[] _valores = new int[] { 0, 0, 0 };

		public void Draw(ICanvas canvas, RectF dirtyRect)
		{
			// View:     frameView
			// NodeName: Gráfico
			// NodeType: GROUP
			// NodeId:   1:15
			canvas.SaveState();
			canvas.RestoreState();


			// View:     rectangleView
			// NodeName: 1mes
			// NodeType: RECTANGLE
			// NodeId:   1:2
			canvas.SaveState();
			canvas.FillColor = Color.FromRgb(13, 175, 124);
			canvas.Alpha = 1;
			canvas.FillRoundedRectangle(59f, dirtyRect.Height - _valores[0], 28f, (float)_valores[0], 0f);
			canvas.RestoreState();


			// View:     rectangleView1
			// NodeName: 2mes
			// NodeType: RECTANGLE
			// NodeId:   1:3
			canvas.SaveState();
			canvas.FillColor = Color.FromRgb(251, 177, 116);
			canvas.Alpha = 1;
			canvas.FillRoundedRectangle(123f, dirtyRect.Height - _valores[1], 28f, (float)_valores[1], 0f);
			canvas.RestoreState();


			// View:     rectangleView2
			// NodeName: 3mes
			// NodeType: RECTANGLE
			// NodeId:   1:4
			canvas.SaveState();
			canvas.FillColor = Color.FromRgb(237, 111, 111);
			canvas.Alpha = 1;
			canvas.FillRoundedRectangle(187f, dirtyRect.Height - _valores[2], 28f, (float)_valores[2], 0f);
			canvas.RestoreState();


			// View:     lineView
			// NodeName: Line X
			// NodeType: LINE
			// NodeId:   1:6
			canvas.SaveState();
			canvas.StrokeColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.StrokeSize = 1;
			canvas.DrawLine(new Point(23, 257), new Point(246, 257));
			canvas.RestoreState();


			// View:     lineView1
			// NodeName: Line Y
			// NodeType: LINE
			// NodeId:   1:7
			canvas.SaveState();
			canvas.StrokeColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.StrokeSize = 1;
			canvas.DrawLine(new Point(23, 7), new Point(23, 257));
			canvas.RestoreState();


			// View:     textView
			// NodeName: 250
			// NodeType: TEXT
			// NodeId:   1:8
			canvas.SaveState();
			canvas.FontColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
			canvas.FontSize = 12f;
			canvas.DrawString(@"250", 7.1054274E-15f, -7.1054274E-15f, 23f, 15f, HorizontalAlignment.Left, VerticalAlignment.Top);
			canvas.RestoreState();


			// View:     textView1
			// NodeName: 200
			// NodeType: TEXT
			// NodeId:   1:9
			canvas.SaveState();
			canvas.FontColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
			canvas.FontSize = 12f;
			canvas.DrawString(@"200", 7.1054274E-15f, 53f, 23f, 15f, HorizontalAlignment.Left, VerticalAlignment.Top);
			canvas.RestoreState();


			// View:     textView2
			// NodeName: 150
			// NodeType: TEXT
			// NodeId:   1:10
			canvas.SaveState();
			canvas.FontColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
			canvas.FontSize = 12f;
			canvas.DrawString(@"150", 7.1054274E-15f, 106f, 21f, 15f, HorizontalAlignment.Left, VerticalAlignment.Top);
			canvas.RestoreState();


			// View:     textView3
			// NodeName: 100
			// NodeType: TEXT
			// NodeId:   1:11
			canvas.SaveState();
			canvas.FontColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
			canvas.FontSize = 12f;
			canvas.DrawString(@"100", 7.1054274E-15f, 159f, 21f, 15f, HorizontalAlignment.Left, VerticalAlignment.Top);
			canvas.RestoreState();


			// View:     textView4
			// NodeName: 50
			// NodeType: TEXT
			// NodeId:   1:12
			canvas.SaveState();
			canvas.FontColor = Color.FromRgb(0, 0, 0);
			canvas.Alpha = 1;
			canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
			canvas.FontSize = 12f;
			canvas.DrawString(@"50", 7f, 212f, 15f, 15f, HorizontalAlignment.Left, VerticalAlignment.Top);
			canvas.RestoreState();
		}
	}
}
