using System;

using R5T.T0131;


namespace R5T.Z0075.Z001.PreRelease
{
    [ValuesMarker]
    public partial interface IVersionNames : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private Z001.IVersionNames _VersionNames => Z001.VersionNames.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Z001.IVersionNames._1_0_0_beta"/>
        public string _1_0_0_beta => _VersionNames._1_0_0_beta;

        /// <inheritdoc cref="Z001.IVersionNames._2_0_0_rc_1"/>
        public string _2_0_0_rc_1 => _VersionNames._2_0_0_rc_1;
    }
}
