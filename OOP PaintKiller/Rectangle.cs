﻿using System.Drawing;

namespace OOP_PaintKiller
{
	class Rectangle : Figure
	{
		public int LeftTopX { set; get; }
		public int LeftTopY { set; get; }
		public int RightBottomX { set; get; }
		public int RightBottomY { set; get; }

		public Rectangle() { }

		public override void SetCoord(int startX, int startY, int endX, int endY)
		{
			LeftTopX = startX;
			LeftTopY = startY;
			RightBottomX = endX;
			RightBottomY = endY;
		}

		public override void Draw(Graphics grph, Pen pen)
		{
			grph.DrawRectangle(pen, LeftTopX, LeftTopY, RightBottomX - LeftTopX, RightBottomY - LeftTopY);
		}
	}
}
