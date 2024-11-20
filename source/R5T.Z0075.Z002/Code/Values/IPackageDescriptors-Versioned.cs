using System;

using R5T.T0131;
using R5T.T0256.T001;


namespace R5T.Z0075.Z002.Versioned
{
    [ValuesMarker]
    public partial interface IPackageDescriptors : IValuesMarker
    {
        /// <summary>
        /// <para><value><inheritdoc cref="Z001.IPackageNames.Microsoft_NET_Test_Sdk" path="descendant::value"/>, <inheritdoc cref="Z001.IVersionNames._17_0_0" path="descendant::value"/></value></para>
        /// </summary>
        public PackageDescriptor Microsoft_NET_Test_Sdk_17_0_0 => new PackageDescriptor
        {
            Name = Instances.PackageNames.Microsoft_NET_Test_Sdk,
            Version = Instances.VersionNames._17_0_0,
        };

        /// <summary>
        /// <para><value><inheritdoc cref="Z001.IPackageNames.MSTest_TestAdapter" path="descendant::value"/>, <inheritdoc cref="Z001.IVersionNames._2_2_8" path="descendant::value"/></value></para>
        /// </summary>
        public PackageDescriptor MSTest_TestAdapter_2_2_8 => new PackageDescriptor
        {
            Name = Instances.PackageNames.MSTest_TestAdapter,
            Version = Instances.VersionNames._2_2_8,
        };
    }
}
