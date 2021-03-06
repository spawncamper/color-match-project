// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Gets the name of a Game Object and stores it in a String Variable.")]
	public class GetName : FsmStateAction
	{
		[RequiredField]
        [Tooltip("The Game Object target.")]
		public FsmGameObject gameObject;
		
		[RequiredField]
		[UIHint(UIHint.Variable)]
        [Tooltip("Store the Game Object name in a String Variable.")]
		public FsmString storeName;

        [Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
			gameObject = new FsmGameObject { UseVariable = true};
			storeName = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoGetGameObjectName();
			
			if (!everyFrame)
			{
				Finish();
			}
		}
		
		public override void OnUpdate()
		{
			DoGetGameObjectName();
		}
		
		void DoGetGameObjectName()
		{
			var go = gameObject.Value;

			storeName.Value = go != null ? go.name : "";
		}
	}
}