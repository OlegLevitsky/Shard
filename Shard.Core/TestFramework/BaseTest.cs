// <copyright file="BaseTest.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shard.Core.TestFramework
{
    /// <summary>
    /// Base class for a unit test.
    /// </summary>
    public class BaseTest
    {
        private TestContext testContext;

        /// <summary>
        /// Gets or sets test context.
        /// </summary>
        public TestContext TestContext
        {
            get => testContext;
            set
            {
                OnTestContextChanging();
                testContext = value;
                OnTestContextChanged();
            }
        }

        /// <summary>
        /// Default method to call from the <see cref="ClassInitializeAttribute"/> implementation.
        /// </summary>
        /// <param name="testContext">Specified context.</param>
        protected static void OnClassInitialize(TestContext testContext)
        {
        }

        /// <summary>
        /// Default method to call from the <see cref="ClassCleanupAttribute"/> implementation.
        /// </summary>
        protected static void OnClassCleanup()
        {
        }

        /// <summary>
        /// Occurs before the current <see cref="TestContext"/> chage.
        /// </summary>
        protected virtual void OnTestContextChanging()
        {
        }

        /// <summary>
        /// Occurs after <see cref="TestContext"/> change.
        /// </summary>
        protected virtual void OnTestContextChanged()
        {
        }

        /// <summary>
        /// Default method to call from the <see cref="TestInitializeAttribute"/> implementation.
        /// </summary>
        protected virtual void OnTestInitialize()
        {
        }

        /// <summary>
        /// Default method to call from the <see cref="TestCleanupAttribute"/> implementation.
        /// </summary>
        protected virtual void OnTestCleanup()
        {
        }
    }
}
