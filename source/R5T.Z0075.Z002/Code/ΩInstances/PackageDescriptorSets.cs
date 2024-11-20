using System;


namespace R5T.Z0075.Z002
{
    public class PackageDescriptorSets : IPackageDescriptorSets
    {
        #region Infrastructure

        public static IPackageDescriptorSets Instance { get; } = new PackageDescriptorSets();


        private PackageDescriptorSets()
        {
        }

        #endregion
    }
}


namespace R5T.Z0075.Z002.Raw
{
    public class PackageDescriptorSets : IPackageDescriptorSets
    {
        #region Infrastructure

        public static IPackageDescriptorSets Instance { get; } = new PackageDescriptorSets();


        private PackageDescriptorSets()
        {
        }

        #endregion
    }
}