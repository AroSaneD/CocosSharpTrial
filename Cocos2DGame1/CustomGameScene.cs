using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocos2D;

namespace Cocos2DGame1
{
    class CustomGameScene : CCScene
    {
		public CustomGameScene()
		{
			CCLayerColor layer = new CCLayerColor();
			AddChild(layer);

			CCSprite sprite = new CCSprite(new CCRect(0, 0, 50, 50));
			sprite.Color = CCColor3B.Green;

			layer.AddChild(sprite);
			sprite.Position = CCDirector.SharedDirector.WinSize.Center;

			layer.Color = CCColor3B.Black;
			layer.Opacity = 255;
		}
    }
}
