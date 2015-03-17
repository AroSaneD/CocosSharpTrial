using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocos2D;

namespace Cocos2DGame1
{
    class CustomGameScene : CCScene
    {
		public CCLayer layer;
		public CCSprite sprite;
		public CCSprite ball;
		public CCLabelTTF scoreLabel;

		public CustomGameScene()
		{
			layer = new CCLayerColor();
			AddChild(layer);

			#region creating the platform

			sprite = new CCSprite(new CCRect(0, 0, 100, 20));
			sprite.Color = CCColor3B.Blue;

			layer.AddChild(sprite);

			CCPoint lowerCenter = new CCPoint();

			lowerCenter.X = CCDirector.SharedDirector.WinSize.Center.X;
			lowerCenter.Y = (int)((float)CCDirector.SharedDirector.WinSize.Center.Y * 0.2);

			sprite.Position = lowerCenter;

			#endregion

			
			#region creating the ball

			ball = new CCSprite(new CCRect(0, 0, 15, 15));
			ball.Color = CCColor3B.Green;
			
			layer.AddChild(ball);
			
			CCPoint upperRegion = new CCPoint();
			
			upperRegion.Y = (int)((float)CCDirector.SharedDirector.WinSize.Center.Y * 1.5);
			upperRegion.X = (int)((float) CCDirector.SharedDirector.WinSize.Center.X * 1.3);
			
			ball.Position = upperRegion;
			
			#endregion


			#region creating the score field

			scoreLabel = new CCLabelTTF("Score: 0", "MarkerFelt", 22);
			
			scoreLabel.PositionX = layer.WorldBoundingBox.MinX + 20;
			scoreLabel.PositionY = layer.WorldBoundingBox.MaxY - 20;
			scoreLabel.AnchorPoint = CCPoint.AnchorUpperLeft;
			
			layer.AddChild(scoreLabel);

			#endregion
		}
    }
}
