using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocos2D;
using CocosDenshion;

namespace Cocos2DGame1
{
    class CustomGameScene : CCScene
    {
		

		

		public CustomGameScene()
		{
			var layer = new CustomLayer();
			AddChild(layer);

		}
    }
}
