// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/zodiac.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ZodiacServer {

  /// <summary>Holder for reflection information generated from Protos/zodiac.proto</summary>
  public static partial class ZodiacReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/zodiac.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZodiacReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90b3Mvem9kaWFjLnByb3RvEgZ6b2RpYWMaHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90byImCglJbnB1dERhdGUSGQoRaW5wdXRDYWxlbmRh",
            "ckRhdGUYASABKAkiNgoQU3RhclNpZ25SZXNwb25zZRIiCghzdGFyU2lnbhgB",
            "IAEoDjIQLnpvZGlhYy5TdGFyU2lnbiqtAQoIU3RhclNpZ24SDQoJVU5ERUZJ",
            "TkVEEAASDAoIVkFSU0FUT1IQARIJCgVQRVNUSRACEgoKBkJFUkJFQxADEggK",
            "BFRBVVIQBBIKCgZHRU1FTkkQBRIHCgNSQUMQBhIHCgNMRVUQBxIMCghGRUNJ",
            "T0FSQRAIEgsKB0JBTEFOVEEQCRIMCghTQ09SUElPThAKEg0KCVNBR0VUQVRP",
            "UhALEg0KCUNBUFJJQ09SThAMMlQKD1N0YXJTaWduU2VydmljZRJBChJHZXRT",
            "dGFyU2lnblJlcXVlc3QSES56b2RpYWMuSW5wdXREYXRlGhguem9kaWFjLlN0",
            "YXJTaWduUmVzcG9uc2VCD6oCDFpvZGlhY1NlcnZlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ZodiacServer.StarSign), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacServer.InputDate), global::ZodiacServer.InputDate.Parser, new[]{ "InputCalendarDate" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacServer.StarSignResponse), global::ZodiacServer.StarSignResponse.Parser, new[]{ "StarSign" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum StarSign {
    [pbr::OriginalName("UNDEFINED")] Undefined = 0,
    [pbr::OriginalName("VARSATOR")] Varsator = 1,
    [pbr::OriginalName("PESTI")] Pesti = 2,
    [pbr::OriginalName("BERBEC")] Berbec = 3,
    [pbr::OriginalName("TAUR")] Taur = 4,
    [pbr::OriginalName("GEMENI")] Gemeni = 5,
    [pbr::OriginalName("RAC")] Rac = 6,
    [pbr::OriginalName("LEU")] Leu = 7,
    [pbr::OriginalName("FECIOARA")] Fecioara = 8,
    [pbr::OriginalName("BALANTA")] Balanta = 9,
    [pbr::OriginalName("SCORPION")] Scorpion = 10,
    [pbr::OriginalName("SAGETATOR")] Sagetator = 11,
    [pbr::OriginalName("CAPRICORN")] Capricorn = 12,
  }

  #endregion

  #region Messages
  public sealed partial class InputDate : pb::IMessage<InputDate> {
    private static readonly pb::MessageParser<InputDate> _parser = new pb::MessageParser<InputDate>(() => new InputDate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InputDate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacServer.ZodiacReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InputDate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InputDate(InputDate other) : this() {
      inputCalendarDate_ = other.inputCalendarDate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InputDate Clone() {
      return new InputDate(this);
    }

    /// <summary>Field number for the "inputCalendarDate" field.</summary>
    public const int InputCalendarDateFieldNumber = 1;
    private string inputCalendarDate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InputCalendarDate {
      get { return inputCalendarDate_; }
      set {
        inputCalendarDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InputDate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InputDate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InputCalendarDate != other.InputCalendarDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (InputCalendarDate.Length != 0) hash ^= InputCalendarDate.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (InputCalendarDate.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InputCalendarDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (InputCalendarDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InputCalendarDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InputDate other) {
      if (other == null) {
        return;
      }
      if (other.InputCalendarDate.Length != 0) {
        InputCalendarDate = other.InputCalendarDate;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            InputCalendarDate = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StarSignResponse : pb::IMessage<StarSignResponse> {
    private static readonly pb::MessageParser<StarSignResponse> _parser = new pb::MessageParser<StarSignResponse>(() => new StarSignResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StarSignResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacServer.ZodiacReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StarSignResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StarSignResponse(StarSignResponse other) : this() {
      starSign_ = other.starSign_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StarSignResponse Clone() {
      return new StarSignResponse(this);
    }

    /// <summary>Field number for the "starSign" field.</summary>
    public const int StarSignFieldNumber = 1;
    private global::ZodiacServer.StarSign starSign_ = global::ZodiacServer.StarSign.Undefined;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ZodiacServer.StarSign StarSign {
      get { return starSign_; }
      set {
        starSign_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StarSignResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StarSignResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StarSign != other.StarSign) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (StarSign != global::ZodiacServer.StarSign.Undefined) hash ^= StarSign.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (StarSign != global::ZodiacServer.StarSign.Undefined) {
        output.WriteRawTag(8);
        output.WriteEnum((int) StarSign);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (StarSign != global::ZodiacServer.StarSign.Undefined) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StarSign);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StarSignResponse other) {
      if (other == null) {
        return;
      }
      if (other.StarSign != global::ZodiacServer.StarSign.Undefined) {
        StarSign = other.StarSign;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StarSign = (global::ZodiacServer.StarSign) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
