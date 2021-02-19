// <copyright file="BaseInteraction.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shard.Core.TestFramework;

namespace Shard.Desktop.Windows.WinApi.UiTests.Notepad
{
    [TestClass]
    public class BaseInteraction : BaseTest
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext) => OnClassInitialize(testContext);

        [ClassCleanup]
        public static void ClassCleanup() => OnClassCleanup();

        [TestInitialize]
        public void TestInitialize() => OnTestInitialize();

        [TestCleanup]
        public void TestCleanup() => OnTestCleanup();

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
