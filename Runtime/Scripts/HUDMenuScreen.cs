using UnityEngine.UIElements;

public class HUDMenuScreen : MenuScreen
{
	private Label _timerLabel;

	public HUDMenuScreen( VisualTreeAsset asset, MenuScreenType type, MenuScreenController controller ) : base(
		asset, type, controller )
	{
	}


	protected override void GetElements()
	{
		base.GetElements();
	}

	protected override void BindEvents()
	{
		base.BindEvents();
	}
}