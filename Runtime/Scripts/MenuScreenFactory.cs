using System;
using UnityEngine;
using UnityEngine.UIElements;

public enum MenuScreenType
{
	Main,
	HUD,
	Credits,
}

public static class MenuScreenFactory
{
	public static MenuScreen CreateScreen( VisualTreeAsset asset, MenuScreenType type,
		MenuScreenController controller )
	{
		MenuScreen menuScreen = type switch
		{
			MenuScreenType.Main     => new MainMenuScreen( asset, type, controller ),
			MenuScreenType.HUD      => new HUDMenuScreen( asset, type, controller ),
			MenuScreenType.Credits  => new CreditsMenuScreen( asset, type, controller ),
			_                       => throw new ArgumentException( "not a screen type" ),
		};
		
		menuScreen.Initialize();
		return menuScreen;
	}
}