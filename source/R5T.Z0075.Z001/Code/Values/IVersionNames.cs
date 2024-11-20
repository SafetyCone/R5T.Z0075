using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0075.Z001
{
    [ValuesMarker]
    public partial interface IVersionNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public PreRelease.IVersionNames _PreRelease => PreRelease.VersionNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>1.0.0-beta</value></para>
        /// </summary>
        public string _1_0_0_beta => "1.0.0-beta";

        /// <summary>
        /// <para><value>2.0.0-rc.1</value></para>
        /// </summary>
        public string _2_0_0_rc_1 => "2.0.0-rc.1";

        /// <summary>
        /// <para><value>2.2.8</value></para>
        /// </summary>
        public string _2_2_8 => "2.2.8";

        /// <summary>
        /// <para><value>6.0.11</value></para>
        /// </summary>
        public string _6_0_11 => "6.0.11";

        /// <summary>
        /// <para><value>17.0.0</value></para>
        /// </summary>
        public string _17_0_0 => "17.0.0";
    }
}
