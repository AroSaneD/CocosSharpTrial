using System;
using Cocos2D;
using Microsoft.Xna.Framework;

namespace Cocos2DGame1
{
	public class IntroLayer : CCLayerColor
	{
		public IntroLayer()
		{

			
			// create and initialize a Label
			var label = new CCLabelTTF("Hello Cocos2D-XNA", "MarkerFelt", 22);

			// position the label on the center of the screen
			label.Position = CCDirector.SharedDirector.WinSize.Center;

			// add the label as a child to this Layer
			//AddChild(label);


			//CCNode node = new CCNode();
			CCSprite sprite = new CCSprite(new CCRect(0, 0, 50, 50));
			sprite.Color = CCColor3B.Green;
			sprite.Position = CCDirector.SharedDirector.WinSize.Center;
			AddChild(sprite);

			CCParticleFireworks fireworks = new CCParticleFireworks();
			fireworks.Position = CCDirector.SharedDirector.WinSize.Center;
			fireworks.Speed = 0.5f;
			fireworks.StartSize = 10;
			fireworks.EndSize = 100;
			fireworks.StartColor = new CCColor4F(0.2f, 0.3f, 0f, 1f);
			fireworks.EndColor = new CCColor4F(1f, 0.3f, 0f, 1f);
			fireworks.StartSpin = 0.5f;
			fireworks.EndSpin = 5f;
			AddChild(fireworks);

			// setup our color for the background
			Color = new CCColor3B(Microsoft.Xna.Framework.Color.Blue);
			Opacity = 255;

		}

		public static CCScene Scene
		{
			get
			{
				// 'scene' is an autorelease object.
				var scene = new CCScene();

				// 'layer' is an autorelease object.
				var layer = new IntroLayer();

				// add layer as a child to scene
				scene.AddChild(layer);

				// return the scene
				return scene;

			}

		}

	}
}

