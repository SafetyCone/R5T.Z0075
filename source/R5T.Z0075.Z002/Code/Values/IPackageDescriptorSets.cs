using System;

using R5T.T0131;
using R5T.T0143;
using R5T.T0256.T001;


namespace R5T.Z0075.Z002
{
    [ValuesMarker]
    public partial interface IPackageDescriptorSets : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Raw.IPackageDescriptorSets _Raw => Raw.PackageDescriptorSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPackageDescriptorSets.N_001"/>
        public PackageDescriptor[] For_TestProject => _Raw.N_001;
    }
}
