// -----------------------------------------------------------------------
// <copyright file="TestBehaviour.cs" company="AillieoTech">
// Copyright (c) AillieoTech. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace AillieoUtils.TestPackage
{
    using UnityEngine;

    /// <summary>
    /// A simple script for test package.
    /// </summary>
    public class TestBehaviour : MonoBehaviour
    {
        /// <summary>
        /// Gets or sets the test value.
        /// </summary>
        public int testValue
        {
            get;
            set;
        }

        /// <summary>
        /// Print the test value.
        /// </summary>
        public void TestMethod()
        {
            Debug.Log(this.testValue);
        }

        private void Start()
        {
            Debug.Log("Start");
        }
    }
}
