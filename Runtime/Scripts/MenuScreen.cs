using System;
using UnityEngine.Serialization;
using UnityEngine.UIElements;



[ Serializable ]
public class MenuScreen
{ 
	public VisualTreeAsset screenAsset;

	protected MenuScreenController menuScreenController;

	public MenuScreen( VisualTreeAsset asset, MenuScreenType type, MenuScreenController controller )
	{
		screenAsset = asset;
		Type = type;
		menuScreenController = controller;
	}

	public VisualElement Root{ get; private set; }
	public MenuScreenType Type{ get; private set; }

	public void Initialize()
	{
		Root = screenAsset.CloneTree();

		GetElements();
		BindElements();
		BindEvents();
	}

	public void OnActivation() => OnActivationInternal();
	public void OnDeactivation() => OnDeactivationInternal();
	protected virtual void OnActivationInternal() {}
	protected virtual void OnDeactivationInternal() {}
	protected virtual void GetElements() {}
	protected virtual void BindElements() {}
	protected virtual void BindEvents() {}
}