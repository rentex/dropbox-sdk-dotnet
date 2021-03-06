// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The relinquish file membership arg object</para>
    /// </summary>
    public class RelinquishFileMembershipArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RelinquishFileMembershipArg> Encoder = new RelinquishFileMembershipArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RelinquishFileMembershipArg> Decoder = new RelinquishFileMembershipArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelinquishFileMembershipArg" />
        /// class.</para>
        /// </summary>
        /// <param name="file">The path or id for the file.</param>
        public RelinquishFileMembershipArg(string file)
        {
            if (file == null)
            {
                throw new sys.ArgumentNullException("file");
            }
            if (file.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("file", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(file, @"\A(?:((/|id:).*|nspath:[^:]*:[^:]*))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("file", @"Value should match pattern '\A(?:((/|id:).*|nspath:[^:]*:[^:]*))\z'");
            }

            this.File = file;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RelinquishFileMembershipArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public RelinquishFileMembershipArg()
        {
        }

        /// <summary>
        /// <para>The path or id for the file.</para>
        /// </summary>
        public string File { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RelinquishFileMembershipArg" />.</para>
        /// </summary>
        private class RelinquishFileMembershipArgEncoder : enc.StructEncoder<RelinquishFileMembershipArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RelinquishFileMembershipArg value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RelinquishFileMembershipArg" />.</para>
        /// </summary>
        private class RelinquishFileMembershipArgDecoder : enc.StructDecoder<RelinquishFileMembershipArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RelinquishFileMembershipArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RelinquishFileMembershipArg Create()
            {
                return new RelinquishFileMembershipArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RelinquishFileMembershipArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
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
