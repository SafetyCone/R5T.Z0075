using System;


namespace R5T.Z0075.Z002
{
    public class PackageDescriptors : IPackageDescriptors
    {
        #region Infrastructure

        public static IPackageDescriptors Instance { get; } = new PackageDescriptors();


        private PackageDescriptors()
        {
        }

        #endregion
    }
}


namespace R5T.Z0075.Z002.Versioned
{
    public class PackageDescriptors : IPackageDescriptors
    {
        #region Infrastructure

        public static IPackageDescriptors Instance { get; } = new PackageDescriptors();


        private PackageDescriptors()
        {
        }

        #endregion
    }
}