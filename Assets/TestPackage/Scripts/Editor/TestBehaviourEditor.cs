// -----------------------------------------------------------------------
// <copyright file="TestBehaviourEditor.cs" company="AillieoTech">
// Copyright (c) AillieoTech. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace AillieoUtils.TestPackage.Editor
{
    using UnityEngine;

    /// <summary>
    /// Inspector for type <see cref="TestBehaviour"/>.
    /// </summary>
    public class TestBehaviourEditor : UnityEditor.Editor
    {
        /// <inheritdoc/>
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            Debug.Log("OnInspectorGUI");
        }
    }
}
