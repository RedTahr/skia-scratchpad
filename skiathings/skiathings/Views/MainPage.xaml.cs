using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace skiathings.Views {
	public partial class MainPage : ContentPage {
		public MainPage() {
			InitializeComponent();
		}

		// https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/graphics/skiasharp/curves/effects
		private void OnPainting(object sender, SKPaintSurfaceEventArgs args) {
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			var circleFill = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Fill,
				Color = SKColors.LightBlue
			};

			canvas.DrawCircle((float)(info.Width / 2), (float)(info.Height / 2), (float)(info.Height / 4), circleFill);

			var paintCapacity = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				Color = SKColors.Yellow,
				StrokeWidth = 10
			};

			var pathCapacity = new SKPath();
			pathCapacity.AddArc(new SKRect(15, 15, info.Width - 15, info.Height - 15), 180, 180);

			canvas.DrawPath(pathCapacity, paintCapacity);

			var paintTotal = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				Color = SKColors.YellowGreen,
				StrokeWidth = 10
			};

			var pathTotal = new SKPath();
			pathTotal.AddArc(new SKRect(15, 15, info.Width - 15, info.Height - 15), 180, 90);

			canvas.DrawPath(pathTotal, paintTotal);

			var paintText = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Fill,
				Color = SKColors.Blue,
				TextSize = 20
			};

			var pathText = new SKPath();
			pathText.AddArc(new SKRect(40, 40, info.Width - 40, info.Height - 40), 190, 160);

			canvas.DrawTextOnPath("Loren bacon ipsum", pathText, 0, 0, paintText);
		}

		private void OnTickPainting(object sender, SKPaintSurfaceEventArgs args) {
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			var circleHollow = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				Color = SKColors.DarkSlateGray,
				StrokeWidth = 4
			};

			canvas.DrawCircle((float)(info.Width / 2), (float)(info.Height / 2), (float)(info.Height / 4), circleHollow);

			// cross
			var pathStroke = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				Color = SKColors.Green,
				StrokeWidth = 10
			};

			// create a path
			var path = new SKPath();
			path.MoveTo(70, 110);
			path.LineTo(90, 130);
			path.LineTo(130, 70);

			// draw the path
			canvas.DrawPath(path, pathStroke);

		}

		// https://blog.xamarin.com/drawing-with-skiasharp/
		private void OnCrossPainting(object sender, SKPaintSurfaceEventArgs args) {
			SKImageInfo info = args.Info;
			SKSurface surface = args.Surface;
			SKCanvas canvas = surface.Canvas;

			var circleHollow = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				Color = SKColors.DarkSlateGray,
				StrokeWidth = 4
			};

			canvas.DrawCircle((float)(info.Width / 2), (float)(info.Height / 2), (float)(info.Height / 4), circleHollow);
			
			// cross
			var pathStroke = new SKPaint {
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				Color = SKColors.Red,
				StrokeWidth = 10
			};

			// create a path
			var path = new SKPath();
			path.MoveTo(70, 70);
			path.LineTo(130, 130);
			path.MoveTo(70, 130);
			path.LineTo(130, 70);

			// draw the path
			canvas.DrawPath(path, pathStroke);

		}
	}
}