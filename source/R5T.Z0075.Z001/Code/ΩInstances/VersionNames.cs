using System;


namespace R5T.Z0075.Z001
{
    public class VersionNames : IVersionNames
    {
        #region Infrastructure

        public static IVersionNames Instance { get; } = new VersionNames();


        private VersionNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0075.Z001.PreRelease
{
    public class VersionNames : IVersionNames
    {
        #region Infrastructure

        public static IVersionNames Instance { get; } = new VersionNames();


        private VersionNames()
        {
        }

        #endregion
    }
}