using System;

using R5T.T0131;
using R5T.T0256.T001;


namespace R5T.Z0075.Z002.Raw
{
    [ValuesMarker]
    public partial interface IPackageDescriptorSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static IPackageDescriptors _PackageDescriptors => PackageDescriptors.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// Packages need for creating a test project.
        /// <list type="bullet">
        /// <item><inheritdoc cref="IPackageDescriptors.Microsoft_NET_Test_Sdk" path="descendant::value[1]"/></item>
        /// <item><inheritdoc cref="IPackageDescriptors.MSTest_TestAdapter" path="descendant::value[1]"/></item>
        /// </list>
        /// </summary>
        public PackageDescriptor[] N_001 => new[]
        {
            _PackageDescriptors.Microsoft_NET_Test_Sdk,
            _PackageDescriptors.MSTest_TestAdapter
        };
    }
}
