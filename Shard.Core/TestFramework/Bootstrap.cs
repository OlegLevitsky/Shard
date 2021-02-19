// <copyright file="Bootstrap.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shard.Core;
using Shard.Interfaces.Managers;

namespace Shard.TestFramework
{
    /// <summary>
    /// Common class for the infrastructure customization.
    /// </summary>
    public class Bootstrap
    {
        /// <summary>
        /// Gets Singletone instance of <see cref="Bootstrap"/>.
        /// </summary>
        public static Bootstrap Instance { get; private set; }

        /// <summary>
        /// Default method to call from the <see cref="AssemblyInitializeAttribute"/> implementation.
        /// </summary>
        /// <param name="testContext">Specified <see cref="TestContext"/>.</param>
        /// <param name="bootstrap"><see cref="Bootstrap"/> instance that will be available through the <see cref="Instance"/>.</param>
        protected static void AssemblyInitialize(TestContext testContext, Bootstrap bootstrap)
        {
            Instance = bootstrap;
            Environment.Instance = bootstrap.CreateEnvironment();

            bootstrap.RegisterManagers();
        }

        /// <summary>
        /// Creates an <see cref="Environment"/> instance for the <see cref="Environment.Instance"/>.
        /// </summary>
        /// <returns>Specific <see cref="Environment"/>.</returns>
        protected virtual Environment CreateEnvironment() => new Environment();

        /// <summary>
        /// Attach all desired <see cref="IManager"/> to <see cref="Environment"/>.
        /// </summary>
        protected virtual void RegisterManagers()
        {
        }
    }
}
