// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Failed to delete all files from an unlinked device.</para>
    /// </summary>
    public class DeviceDeleteOnUnlinkFailDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceDeleteOnUnlinkFailDetails> Encoder = new DeviceDeleteOnUnlinkFailDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceDeleteOnUnlinkFailDetails> Decoder = new DeviceDeleteOnUnlinkFailDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceDeleteOnUnlinkFailDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="deviceInfo">Device information.</param>
        /// <param name="numFailures">The number of times that remote file deletion
        /// failed.</param>
        public DeviceDeleteOnUnlinkFailDetails(DeviceLogInfo deviceInfo,
                                               long numFailures)
        {
            if (deviceInfo == null)
            {
                throw new sys.ArgumentNullException("deviceInfo");
            }

            this.DeviceInfo = deviceInfo;
            this.NumFailures = numFailures;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceDeleteOnUnlinkFailDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceDeleteOnUnlinkFailDetails()
        {
        }

        /// <summary>
        /// <para>Device information.</para>
        /// </summary>
        public DeviceLogInfo DeviceInfo { get; protected set; }

        /// <summary>
        /// <para>The number of times that remote file deletion failed.</para>
        /// </summary>
        public long NumFailures { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceDeleteOnUnlinkFailDetails" />.</para>
        /// </summary>
        private class DeviceDeleteOnUnlinkFailDetailsEncoder : enc.StructEncoder<DeviceDeleteOnUnlinkFailDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceDeleteOnUnlinkFailDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("device_info", value.DeviceInfo, writer, global::Dropbox.Api.TeamLog.DeviceLogInfo.Encoder);
                WriteProperty("num_failures", value.NumFailures, writer, enc.Int64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceDeleteOnUnlinkFailDetails" />.</para>
        /// </summary>
        private class DeviceDeleteOnUnlinkFailDetailsDecoder : enc.StructDecoder<DeviceDeleteOnUnlinkFailDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceDeleteOnUnlinkFailDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceDeleteOnUnlinkFailDetails Create()
            {
                return new DeviceDeleteOnUnlinkFailDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceDeleteOnUnlinkFailDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "device_info":
                        value.DeviceInfo = global::Dropbox.Api.TeamLog.DeviceLogInfo.Decoder.Decode(reader);
                        break;
                    case "num_failures":
                        value.NumFailures = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
