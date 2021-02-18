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
        public static void AssemblyInitialize(TestContext testContext)
        {
            AssemblyInitialize(testContext, new WinApiBootstrap());
        }
    }
}
