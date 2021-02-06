using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shard.Desktop.Core.TestFramework;

namespace Shard.Desktop.Windows.WinApi.UiTests
{
    /// <summary>
    /// WinApi tests <see cref="Bootstrap"/>.
    /// </summary>
    [TestClass]
    public class Bootstrap : DesktopBootstrap
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext) => OnAssemblyInitialize(testContext);
    }
}
