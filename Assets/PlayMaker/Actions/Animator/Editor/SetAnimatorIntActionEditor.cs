// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.

using UnityEngine;
using HutongGames.PlayMaker.Actions;

namespace HutongGames.PlayMakerEditor
{
    [CustomActionEditor(typeof(SetAnimatorInt))]
    public class SetAnimatorIntActionEditor : OnAnimatorUpdateActionEditorBase
    {

        public override bool OnGUI()
        {
            EditField("gameObject");
            EditField("parameter");
            EditField("Value");

            bool changed = EditEveryFrameField();

            return GUI.changed || changed;
        }

    }
}
