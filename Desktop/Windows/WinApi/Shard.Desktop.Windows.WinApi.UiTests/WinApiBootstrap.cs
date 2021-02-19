// <copyright file="WinApiBootstrap.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shard.Desktop.Core.TestFramework;

namespace Shard.Desktop.Windows.WinApi.UiTests
{
    /// <summary>
    /// WinApi tests <see cref="WinApiBootstrap"/>.
    /// </summary>
    [TestClass]
    public class WinApiBootstrap : DesktopBootstrap
    {
        [AssemblyInitialize]
        /// <summary>
        /// MStest entrance point.
        /// </summary>
        /// <param name="testContext">Context instance.</param>
        public static void AssemblyInitialize(TestContext testContext)
        {
            AssemblyInitialize(testContext, new WinApiBootstrap());
        }
    }
}
