﻿using UnityEngine;
using UnityEditor;

namespace Febucci.UI.Examples.Editors
{
    [CustomEditor(typeof(EffectsTesting))]
    class EffectsTestingCustomEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            if (Application.isPlaying)
            {
                ButtonSetText();
                GUILayout.Space(10);

                base.OnInspectorGUI();

                GUILayout.Space(10);
                ButtonSetText();
            }
            else
            {
                base.OnInspectorGUI();
            }
        }

        void ButtonSetText()
        {
            if (GUILayout.Button("Set Text again"))
            {
                ((EffectsTesting)target)?.ShowText();
            }
        }
    }

}