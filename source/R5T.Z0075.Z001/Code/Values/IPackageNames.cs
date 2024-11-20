using System;

using R5T.T0131;


namespace R5T.Z0075.Z001
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <para>
    /// Prior work:
    /// <list type="bullet">
    /// <item>R5T.Z0050.IPackageReferences (R5T.T0205.PackageReference typed)</item>
    /// <item>R5T.Z0020.IPackageReferences (R5T.T0152.PackageReference typed)</item>
    /// </list>
    /// </para>
    /// </remarks>
    [ValuesMarker]
    public partial interface IPackageNames : IValuesMarker
    {
        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.Web</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_Web => "Microsoft.AspNetCore.Components.Web";

        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.WebAssembly</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_WebAssembly => "Microsoft.AspNetCore.Components.WebAssembly";

        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.WebAssembly.DevServer</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_WebAssembly_DevServer => "Microsoft.AspNetCore.Components.WebAssembly.DevServer";

        /// <summary>
        /// <para><value>Microsoft.AspNetCore.Components.WebAssembly.Server</value></para>
        /// </summary>
        public string Microsoft_AspNetCore_Components_WebAssembly_Server => "Microsoft.AspNetCore.Components.WebAssembly.Server";

        /// <summary>
        /// <para><value>Microsoft.NET.Test.Sdk</value></para>
        /// </summary>
        public string Microsoft_NET_Test_Sdk => "Microsoft.NET.Test.Sdk";

        /// <summary>
        /// <para><value>MSTest.TestAdapter</value></para>
        /// </summary>
        public string MSTest_TestAdapter => "MSTest.TestAdapter";
    }
}
