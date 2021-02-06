// <copyright file="Bootstrap.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shard.Core;

namespace Shard.TestFramework
{
    /// <summary>
    /// Common class for the infrastructure customization.
    /// </summary>
    public class Bootstrap
    {
        /// <summary>
        /// Default method to call from the <see cref="AssemblyInitializeAttribute"/> implementation.
        /// </summary>
        /// <param name="testContext">Specified <see cref="TestContext"/>.</param>
        protected static void OnAssemblyInitialize(TestContext testContext)
        {
        }

        /// <summary>
        /// Creates an <see cref="Environment"/> instance.
        /// </summary>
        /// <returns>Specific environment.</returns>
        protected Environment CreateInvironment() => new Environment();
    }
}
