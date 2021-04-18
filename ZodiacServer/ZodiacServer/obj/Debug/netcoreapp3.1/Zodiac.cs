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
            "ChNQcm90b3Mvem9kaWFjLnByb3RvEgZ6b2RpYWMiOAoMQ2FsZW5kYXJEYXRl",
            "EgsKA2RheRgBIAEoCRINCgVtb250aBgCIAEoCRIMCgR5ZWFyGAMgASgJIjYK",
            "EFN0YXJTaWduUmVzcG9uc2USIgoIc3RhclNpZ24YASABKA4yEC56b2RpYWMu",
            "U3RhclNpZ24qrQEKCFN0YXJTaWduEg0KCVVOREVGSU5FRBAAEgwKCFZBUlNB",
            "VE9SEAESCQoFUEVTVEkQAhIKCgZCRVJCRUMQAxIICgRUQVVSEAQSCgoGR0VN",
            "RU5JEAUSBwoDUkFDEAYSBwoDTEVVEAcSDAoIRkVDSU9BUkEQCBILCgdCQUxB",
            "TlRBEAkSDAoIU0NPUlBJT04QChINCglTQUdFVEFUT1IQCxINCglDQVBSSUNP",
            "Uk4QDDJXCg9TdGFyU2lnblNlcnZpY2USRAoSR2V0U3RhclNpZ25SZXF1ZXN0",
            "EhQuem9kaWFjLkNhbGVuZGFyRGF0ZRoYLnpvZGlhYy5TdGFyU2lnblJlc3Bv",
            "bnNlQg+qAgxab2RpYWNTZXJ2ZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ZodiacServer.StarSign), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ZodiacServer.CalendarDate), global::ZodiacServer.CalendarDate.Parser, new[]{ "Day", "Month", "Year" }, null, null, null, null),
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
  public sealed partial class CalendarDate : pb::IMessage<CalendarDate> {
    private static readonly pb::MessageParser<CalendarDate> _parser = new pb::MessageParser<CalendarDate>(() => new CalendarDate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CalendarDate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ZodiacServer.ZodiacReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalendarDate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalendarDate(CalendarDate other) : this() {
      day_ = other.day_;
      month_ = other.month_;
      year_ = other.year_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CalendarDate Clone() {
      return new CalendarDate(this);
    }

    /// <summary>Field number for the "day" field.</summary>
    public const int DayFieldNumber = 1;
    private string day_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Day {
      get { return day_; }
      set {
        day_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 2;
    private string month_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Month {
      get { return month_; }
      set {
        month_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 3;
    private string year_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Year {
      get { return year_; }
      set {
        year_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CalendarDate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CalendarDate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Day != other.Day) return false;
      if (Month != other.Month) return false;
      if (Year != other.Year) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Day.Length != 0) hash ^= Day.GetHashCode();
      if (Month.Length != 0) hash ^= Month.GetHashCode();
      if (Year.Length != 0) hash ^= Year.GetHashCode();
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
      if (Day.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Day);
      }
      if (Month.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Month);
      }
      if (Year.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Year);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Day.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Day);
      }
      if (Month.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Month);
      }
      if (Year.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Year);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CalendarDate other) {
      if (other == null) {
        return;
      }
      if (other.Day.Length != 0) {
        Day = other.Day;
      }
      if (other.Month.Length != 0) {
        Month = other.Month;
      }
      if (other.Year.Length != 0) {
        Year = other.Year;
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
            Day = input.ReadString();
            break;
          }
          case 18: {
            Month = input.ReadString();
            break;
          }
          case 26: {
            Year = input.ReadString();
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
