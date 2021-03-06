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
    /// <para>The device approvals policy object</para>
    /// </summary>
    public class DeviceApprovalsPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceApprovalsPolicy> Encoder = new DeviceApprovalsPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceApprovalsPolicy> Decoder = new DeviceApprovalsPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceApprovalsPolicy" />
        /// class.</para>
        /// </summary>
        public DeviceApprovalsPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unlimited</para>
        /// </summary>
        public bool IsUnlimited
        {
            get
            {
                return this is Unlimited;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unlimited, or <c>null</c>.</para>
        /// </summary>
        public Unlimited AsUnlimited
        {
            get
            {
                return this as Unlimited;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Zero</para>
        /// </summary>
        public bool IsZero
        {
            get
            {
                return this is Zero;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Zero, or <c>null</c>.</para>
        /// </summary>
        public Zero AsZero
        {
            get
            {
                return this as Zero;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is One</para>
        /// </summary>
        public bool IsOne
        {
            get
            {
                return this is One;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a One, or <c>null</c>.</para>
        /// </summary>
        public One AsOne
        {
            get
            {
                return this as One;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Two</para>
        /// </summary>
        public bool IsTwo
        {
            get
            {
                return this is Two;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Two, or <c>null</c>.</para>
        /// </summary>
        public Two AsTwo
        {
            get
            {
                return this as Two;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Three</para>
        /// </summary>
        public bool IsThree
        {
            get
            {
                return this is Three;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Three, or <c>null</c>.</para>
        /// </summary>
        public Three AsThree
        {
            get
            {
                return this as Three;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Four</para>
        /// </summary>
        public bool IsFour
        {
            get
            {
                return this is Four;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Four, or <c>null</c>.</para>
        /// </summary>
        public Four AsFour
        {
            get
            {
                return this as Four;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Five</para>
        /// </summary>
        public bool IsFive
        {
            get
            {
                return this is Five;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Five, or <c>null</c>.</para>
        /// </summary>
        public Five AsFive
        {
            get
            {
                return this as Five;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceApprovalsPolicy" />.</para>
        /// </summary>
        private class DeviceApprovalsPolicyEncoder : enc.StructEncoder<DeviceApprovalsPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceApprovalsPolicy value, enc.IJsonWriter writer)
            {
                if (value is Unlimited)
                {
                    WriteProperty(".tag", "unlimited", writer, enc.StringEncoder.Instance);
                    Unlimited.Encoder.EncodeFields((Unlimited)value, writer);
                    return;
                }
                if (value is Zero)
                {
                    WriteProperty(".tag", "zero", writer, enc.StringEncoder.Instance);
                    Zero.Encoder.EncodeFields((Zero)value, writer);
                    return;
                }
                if (value is One)
                {
                    WriteProperty(".tag", "one", writer, enc.StringEncoder.Instance);
                    One.Encoder.EncodeFields((One)value, writer);
                    return;
                }
                if (value is Two)
                {
                    WriteProperty(".tag", "two", writer, enc.StringEncoder.Instance);
                    Two.Encoder.EncodeFields((Two)value, writer);
                    return;
                }
                if (value is Three)
                {
                    WriteProperty(".tag", "three", writer, enc.StringEncoder.Instance);
                    Three.Encoder.EncodeFields((Three)value, writer);
                    return;
                }
                if (value is Four)
                {
                    WriteProperty(".tag", "four", writer, enc.StringEncoder.Instance);
                    Four.Encoder.EncodeFields((Four)value, writer);
                    return;
                }
                if (value is Five)
                {
                    WriteProperty(".tag", "five", writer, enc.StringEncoder.Instance);
                    Five.Encoder.EncodeFields((Five)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceApprovalsPolicy" />.</para>
        /// </summary>
        private class DeviceApprovalsPolicyDecoder : enc.UnionDecoder<DeviceApprovalsPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceApprovalsPolicy"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceApprovalsPolicy Create()
            {
                return new DeviceApprovalsPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override DeviceApprovalsPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "unlimited":
                        return Unlimited.Decoder.DecodeFields(reader);
                    case "zero":
                        return Zero.Decoder.DecodeFields(reader);
                    case "one":
                        return One.Decoder.DecodeFields(reader);
                    case "two":
                        return Two.Decoder.DecodeFields(reader);
                    case "three":
                        return Three.Decoder.DecodeFields(reader);
                    case "four":
                        return Four.Decoder.DecodeFields(reader);
                    case "five":
                        return Five.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The unlimited object</para>
        /// </summary>
        public sealed class Unlimited : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unlimited> Encoder = new UnlimitedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unlimited> Decoder = new UnlimitedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unlimited" /> class.</para>
            /// </summary>
            private Unlimited()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unlimited</para>
            /// </summary>
            public static readonly Unlimited Instance = new Unlimited();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unlimited" />.</para>
            /// </summary>
            private class UnlimitedEncoder : enc.StructEncoder<Unlimited>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unlimited value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unlimited" />.</para>
            /// </summary>
            private class UnlimitedDecoder : enc.StructDecoder<Unlimited>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unlimited" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unlimited Create()
                {
                    return Unlimited.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The zero object</para>
        /// </summary>
        public sealed class Zero : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Zero> Encoder = new ZeroEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Zero> Decoder = new ZeroDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Zero" /> class.</para>
            /// </summary>
            private Zero()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Zero</para>
            /// </summary>
            public static readonly Zero Instance = new Zero();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Zero" />.</para>
            /// </summary>
            private class ZeroEncoder : enc.StructEncoder<Zero>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Zero value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Zero" />.</para>
            /// </summary>
            private class ZeroDecoder : enc.StructDecoder<Zero>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Zero" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Zero Create()
                {
                    return Zero.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The one object</para>
        /// </summary>
        public sealed class One : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<One> Encoder = new OneEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<One> Decoder = new OneDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="One" /> class.</para>
            /// </summary>
            private One()
            {
            }

            /// <summary>
            /// <para>A singleton instance of One</para>
            /// </summary>
            public static readonly One Instance = new One();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="One" />.</para>
            /// </summary>
            private class OneEncoder : enc.StructEncoder<One>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(One value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="One" />.</para>
            /// </summary>
            private class OneDecoder : enc.StructDecoder<One>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="One" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override One Create()
                {
                    return One.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The two object</para>
        /// </summary>
        public sealed class Two : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Two> Encoder = new TwoEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Two> Decoder = new TwoDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Two" /> class.</para>
            /// </summary>
            private Two()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Two</para>
            /// </summary>
            public static readonly Two Instance = new Two();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Two" />.</para>
            /// </summary>
            private class TwoEncoder : enc.StructEncoder<Two>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Two value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Two" />.</para>
            /// </summary>
            private class TwoDecoder : enc.StructDecoder<Two>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Two" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Two Create()
                {
                    return Two.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The three object</para>
        /// </summary>
        public sealed class Three : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Three> Encoder = new ThreeEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Three> Decoder = new ThreeDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Three" /> class.</para>
            /// </summary>
            private Three()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Three</para>
            /// </summary>
            public static readonly Three Instance = new Three();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Three" />.</para>
            /// </summary>
            private class ThreeEncoder : enc.StructEncoder<Three>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Three value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Three" />.</para>
            /// </summary>
            private class ThreeDecoder : enc.StructDecoder<Three>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Three" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Three Create()
                {
                    return Three.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The four object</para>
        /// </summary>
        public sealed class Four : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Four> Encoder = new FourEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Four> Decoder = new FourDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Four" /> class.</para>
            /// </summary>
            private Four()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Four</para>
            /// </summary>
            public static readonly Four Instance = new Four();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Four" />.</para>
            /// </summary>
            private class FourEncoder : enc.StructEncoder<Four>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Four value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Four" />.</para>
            /// </summary>
            private class FourDecoder : enc.StructDecoder<Four>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Four" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Four Create()
                {
                    return Four.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The five object</para>
        /// </summary>
        public sealed class Five : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Five> Encoder = new FiveEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Five> Decoder = new FiveDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Five" /> class.</para>
            /// </summary>
            private Five()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Five</para>
            /// </summary>
            public static readonly Five Instance = new Five();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Five" />.</para>
            /// </summary>
            private class FiveEncoder : enc.StructEncoder<Five>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Five value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Five" />.</para>
            /// </summary>
            private class FiveDecoder : enc.StructDecoder<Five>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Five" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Five Create()
                {
                    return Five.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : DeviceApprovalsPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
