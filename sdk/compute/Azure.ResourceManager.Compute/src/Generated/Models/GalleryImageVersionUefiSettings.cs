// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Contains UEFI settings for the image version. </summary>
    public partial class GalleryImageVersionUefiSettings
    {
        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionUefiSettings"/>. </summary>
        public GalleryImageVersionUefiSettings()
        {
            SignatureTemplateNames = new ChangeTrackingList<UefiSignatureTemplateName>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryImageVersionUefiSettings"/>. </summary>
        /// <param name="signatureTemplateNames"> The name of the template(s) that contains default UEFI key signatures that will be added to the image. </param>
        /// <param name="additionalSignatures"> Additional UEFI key signatures that will be added to the image in addition to the signature templates. </param>
        internal GalleryImageVersionUefiSettings(IList<UefiSignatureTemplateName> signatureTemplateNames, UefiKeySignatures additionalSignatures)
        {
            SignatureTemplateNames = signatureTemplateNames;
            AdditionalSignatures = additionalSignatures;
        }

        /// <summary> The name of the template(s) that contains default UEFI key signatures that will be added to the image. </summary>
        public IList<UefiSignatureTemplateName> SignatureTemplateNames { get; }
        /// <summary> Additional UEFI key signatures that will be added to the image in addition to the signature templates. </summary>
        public UefiKeySignatures AdditionalSignatures { get; set; }
    }
}
