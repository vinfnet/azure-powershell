// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Column transformer parameters.</summary>
    public partial class ColumnTransformer :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IColumnTransformer,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IColumnTransformerInternal
    {

        /// <summary>Backing field for <see cref="Field" /> property.</summary>
        private string[] _field;

        /// <summary>Fields to apply transformer logic on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string[] Field { get => this._field; set => this._field = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny _parameter;

        /// <summary>
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Any()); set => this._parameter = value; }

        /// <summary>Creates an new <see cref="ColumnTransformer" /> instance.</summary>
        public ColumnTransformer()
        {

        }
    }
    /// Column transformer parameters.
    public partial interface IColumnTransformer :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Fields to apply transformer logic on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fields to apply transformer logic on.",
        SerializedName = @"fields",
        PossibleTypes = new [] { typeof(string) })]
        string[] Field { get; set; }
        /// <summary>
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Different properties to be passed to transformer.
        Input expected is dictionary of key,value pairs in JSON format.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny Parameter { get; set; }

    }
    /// Column transformer parameters.
    internal partial interface IColumnTransformerInternal

    {
        /// <summary>Fields to apply transformer logic on.</summary>
        string[] Field { get; set; }
        /// <summary>
        /// Different properties to be passed to transformer.
        /// Input expected is dictionary of key,value pairs in JSON format.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny Parameter { get; set; }

    }
}