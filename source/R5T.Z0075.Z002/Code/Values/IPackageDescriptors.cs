using System;

using R5T.T0131;
using R5T.T0143;
using R5T.T0256.T001;


namespace R5T.Z0075.Z002
{
    [ValuesMarker]
    public partial interface IPackageDescriptors : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Versioned.IPackageDescriptors _Versioned => Versioned.PackageDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Versioned.IPackageDescriptors.Microsoft_NET_Test_Sdk_17_0_0"/>
        public PackageDescriptor Microsoft_NET_Test_Sdk => _Versioned.Microsoft_NET_Test_Sdk_17_0_0;

        /// <inheritdoc cref="Versioned.IPackageDescriptors.MSTest_TestAdapter_2_2_8"/>
        public PackageDescriptor MSTest_TestAdapter => _Versioned.MSTest_TestAdapter_2_2_8;
    }
}
