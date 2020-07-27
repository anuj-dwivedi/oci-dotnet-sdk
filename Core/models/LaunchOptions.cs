/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CoreService.Models
{
    /// <summary>
    /// Options for tuning the compatibility and performance of VM shapes. The values that you specify override any
    /// default values.
    /// 
    /// </summary>
    public class LaunchOptions 
    {
                ///
        /// <value>
        /// Emulation type for the boot volume.
        /// * `ISCSI` - ISCSI attached block storage device.
        /// * `SCSI` - Emulated SCSI disk.
        /// * `IDE` - Emulated IDE disk.
        /// * `VFIO` - Direct attached Virtual Function storage.  This is the default option for local data
        /// volumes on Oracle-provided images.
        /// * `PARAVIRTUALIZED` - Paravirtualized disk. This is the default for boot volumes and remote block
        /// storage volumes on Oracle-provided images.
        /// 
        /// </value>
        ///
        public enum BootVolumeTypeEnum {
            [EnumMember(Value = "ISCSI")]
            Iscsi,
            [EnumMember(Value = "SCSI")]
            Scsi,
            [EnumMember(Value = "IDE")]
            Ide,
            [EnumMember(Value = "VFIO")]
            Vfio,
            [EnumMember(Value = "PARAVIRTUALIZED")]
            Paravirtualized
        };

        /// <value>
        /// Emulation type for the boot volume.
        /// * `ISCSI` - ISCSI attached block storage device.
        /// * `SCSI` - Emulated SCSI disk.
        /// * `IDE` - Emulated IDE disk.
        /// * `VFIO` - Direct attached Virtual Function storage.  This is the default option for local data
        /// volumes on Oracle-provided images.
        /// * `PARAVIRTUALIZED` - Paravirtualized disk. This is the default for boot volumes and remote block
        /// storage volumes on Oracle-provided images.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bootVolumeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<BootVolumeTypeEnum> BootVolumeType { get; set; }
        ///
        /// <value>
        /// Firmware used to boot VM.  Select the option that matches your operating system.
        /// * `BIOS` - Boot VM using BIOS style firmware.  This is compatible with both 32 bit and 64 bit operating
        /// systems that boot using MBR style bootloaders.
        /// * `UEFI_64` - Boot VM using UEFI style firmware compatible with 64 bit operating systems.  This is the
        /// default for Oracle-provided images.
        /// 
        /// </value>
        ///
        public enum FirmwareEnum {
            [EnumMember(Value = "BIOS")]
            Bios,
            [EnumMember(Value = "UEFI_64")]
            Uefi64
        };

        /// <value>
        /// Firmware used to boot VM.  Select the option that matches your operating system.
        /// * `BIOS` - Boot VM using BIOS style firmware.  This is compatible with both 32 bit and 64 bit operating
        /// systems that boot using MBR style bootloaders.
        /// * `UEFI_64` - Boot VM using UEFI style firmware compatible with 64 bit operating systems.  This is the
        /// default for Oracle-provided images.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "firmware")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<FirmwareEnum> Firmware { get; set; }
        ///
        /// <value>
        /// Emulation type for the physical network interface card (NIC).
        /// * `E1000` - Emulated Gigabit ethernet controller.  Compatible with Linux e1000 network driver.
        /// * `VFIO` - Direct attached Virtual Function network controller. This is the networking type
        /// when you launch an instance using hardware-assisted (SR-IOV) networking.
        /// * `PARAVIRTUALIZED` - VM instances launch with paravirtualized devices using VirtIO drivers.
        /// 
        /// </value>
        ///
        public enum NetworkTypeEnum {
            [EnumMember(Value = "E1000")]
            E1000,
            [EnumMember(Value = "VFIO")]
            Vfio,
            [EnumMember(Value = "PARAVIRTUALIZED")]
            Paravirtualized
        };

        /// <value>
        /// Emulation type for the physical network interface card (NIC).
        /// * `E1000` - Emulated Gigabit ethernet controller.  Compatible with Linux e1000 network driver.
        /// * `VFIO` - Direct attached Virtual Function network controller. This is the networking type
        /// when you launch an instance using hardware-assisted (SR-IOV) networking.
        /// * `PARAVIRTUALIZED` - VM instances launch with paravirtualized devices using VirtIO drivers.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "networkType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<NetworkTypeEnum> NetworkType { get; set; }
        ///
        /// <value>
        /// Emulation type for volume.
        /// * `ISCSI` - ISCSI attached block storage device.
        /// * `SCSI` - Emulated SCSI disk.
        /// * `IDE` - Emulated IDE disk.
        /// * `VFIO` - Direct attached Virtual Function storage.  This is the default option for local data
        /// volumes on Oracle-provided images.
        /// * `PARAVIRTUALIZED` - Paravirtualized disk. This is the default for boot volumes and remote block
        /// storage volumes on Oracle-provided images.
        /// 
        /// </value>
        ///
        public enum RemoteDataVolumeTypeEnum {
            [EnumMember(Value = "ISCSI")]
            Iscsi,
            [EnumMember(Value = "SCSI")]
            Scsi,
            [EnumMember(Value = "IDE")]
            Ide,
            [EnumMember(Value = "VFIO")]
            Vfio,
            [EnumMember(Value = "PARAVIRTUALIZED")]
            Paravirtualized
        };

        /// <value>
        /// Emulation type for volume.
        /// * `ISCSI` - ISCSI attached block storage device.
        /// * `SCSI` - Emulated SCSI disk.
        /// * `IDE` - Emulated IDE disk.
        /// * `VFIO` - Direct attached Virtual Function storage.  This is the default option for local data
        /// volumes on Oracle-provided images.
        /// * `PARAVIRTUALIZED` - Paravirtualized disk. This is the default for boot volumes and remote block
        /// storage volumes on Oracle-provided images.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "remoteDataVolumeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RemoteDataVolumeTypeEnum> RemoteDataVolumeType { get; set; }

        /// <value>
        /// Deprecated. Instead use `isPvEncryptionInTransitEnabled` in
        /// {@link #launchInstanceDetails(LaunchInstanceDetailsRequest) launchInstanceDetails}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPvEncryptionInTransitEnabled")]
        public System.Nullable<bool> IsPvEncryptionInTransitEnabled { get; set; }

        /// <value>
        /// Whether to enable consistent volume naming feature. Defaults to false.
        /// </value>
        [JsonProperty(PropertyName = "isConsistentVolumeNamingEnabled")]
        public System.Nullable<bool> IsConsistentVolumeNamingEnabled { get; set; }
    }
}
