// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LoggingFields
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LoggingFields : ILoggingFields
  {
    [MethodImpl]
    public extern LoggingFields();

    [MethodImpl]
    public extern void Clear();

    [Overload("BeginStruct")]
    [MethodImpl]
    public extern void BeginStruct(string name);

    [Overload("BeginStructWithTags")]
    [MethodImpl]
    public extern void BeginStruct(string name, int tags);

    [MethodImpl]
    public extern void EndStruct();

    [Overload("AddEmpty")]
    [MethodImpl]
    public extern void AddEmpty(string name);

    [Overload("AddEmptyWithFormat")]
    [MethodImpl]
    public extern void AddEmpty(string name, LoggingFieldFormat format);

    [Overload("AddEmptyWithFormatAndTags")]
    [MethodImpl]
    public extern void AddEmpty(string name, LoggingFieldFormat format, int tags);

    [Overload("AddUInt8")]
    [MethodImpl]
    public extern void AddUInt8(string name, byte value);

    [Overload("AddUInt8WithFormat")]
    [MethodImpl]
    public extern void AddUInt8(string name, byte value, LoggingFieldFormat format);

    [Overload("AddUInt8WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt8(string name, byte value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt8Array")]
    [MethodImpl]
    public extern void AddUInt8Array(string name, byte[] value);

    [Overload("AddUInt8ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt8Array(string name, byte[] value, LoggingFieldFormat format);

    [Overload("AddUInt8ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt8Array(
      string name,
      byte[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddInt16")]
    [MethodImpl]
    public extern void AddInt16(string name, short value);

    [Overload("AddInt16WithFormat")]
    [MethodImpl]
    public extern void AddInt16(string name, short value, LoggingFieldFormat format);

    [Overload("AddInt16WithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt16(string name, short value, LoggingFieldFormat format, int tags);

    [Overload("AddInt16Array")]
    [MethodImpl]
    public extern void AddInt16Array(string name, short[] value);

    [Overload("AddInt16ArrayWithFormat")]
    [MethodImpl]
    public extern void AddInt16Array(string name, short[] value, LoggingFieldFormat format);

    [Overload("AddInt16ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt16Array(
      string name,
      short[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddUInt16")]
    [MethodImpl]
    public extern void AddUInt16(string name, ushort value);

    [Overload("AddUInt16WithFormat")]
    [MethodImpl]
    public extern void AddUInt16(string name, ushort value, LoggingFieldFormat format);

    [Overload("AddUInt16WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt16(string name, ushort value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt16Array")]
    [MethodImpl]
    public extern void AddUInt16Array(string name, ushort[] value);

    [Overload("AddUInt16ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt16Array(string name, ushort[] value, LoggingFieldFormat format);

    [Overload("AddUInt16ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt16Array(
      string name,
      ushort[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddInt32")]
    [MethodImpl]
    public extern void AddInt32(string name, int value);

    [Overload("AddInt32WithFormat")]
    [MethodImpl]
    public extern void AddInt32(string name, int value, LoggingFieldFormat format);

    [Overload("AddInt32WithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt32(string name, int value, LoggingFieldFormat format, int tags);

    [Overload("AddInt32Array")]
    [MethodImpl]
    public extern void AddInt32Array(string name, int[] value);

    [Overload("AddInt32ArrayWithFormat")]
    [MethodImpl]
    public extern void AddInt32Array(string name, int[] value, LoggingFieldFormat format);

    [Overload("AddInt32ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt32Array(
      string name,
      int[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddUInt32")]
    [MethodImpl]
    public extern void AddUInt32(string name, uint value);

    [Overload("AddUInt32WithFormat")]
    [MethodImpl]
    public extern void AddUInt32(string name, uint value, LoggingFieldFormat format);

    [Overload("AddUInt32WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt32(string name, uint value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt32Array")]
    [MethodImpl]
    public extern void AddUInt32Array(string name, uint[] value);

    [Overload("AddUInt32ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt32Array(string name, uint[] value, LoggingFieldFormat format);

    [Overload("AddUInt32ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt32Array(
      string name,
      uint[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddInt64")]
    [MethodImpl]
    public extern void AddInt64(string name, long value);

    [Overload("AddInt64WithFormat")]
    [MethodImpl]
    public extern void AddInt64(string name, long value, LoggingFieldFormat format);

    [Overload("AddInt64WithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt64(string name, long value, LoggingFieldFormat format, int tags);

    [Overload("AddInt64Array")]
    [MethodImpl]
    public extern void AddInt64Array(string name, long[] value);

    [Overload("AddInt64ArrayWithFormat")]
    [MethodImpl]
    public extern void AddInt64Array(string name, long[] value, LoggingFieldFormat format);

    [Overload("AddInt64ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddInt64Array(
      string name,
      long[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddUInt64")]
    [MethodImpl]
    public extern void AddUInt64(string name, ulong value);

    [Overload("AddUInt64WithFormat")]
    [MethodImpl]
    public extern void AddUInt64(string name, ulong value, LoggingFieldFormat format);

    [Overload("AddUInt64WithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt64(string name, ulong value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt64Array")]
    [MethodImpl]
    public extern void AddUInt64Array(string name, ulong[] value);

    [Overload("AddUInt64ArrayWithFormat")]
    [MethodImpl]
    public extern void AddUInt64Array(string name, ulong[] value, LoggingFieldFormat format);

    [Overload("AddUInt64ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddUInt64Array(
      string name,
      ulong[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddSingle")]
    [MethodImpl]
    public extern void AddSingle(string name, float value);

    [Overload("AddSingleWithFormat")]
    [MethodImpl]
    public extern void AddSingle(string name, float value, LoggingFieldFormat format);

    [Overload("AddSingleWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSingle(string name, float value, LoggingFieldFormat format, int tags);

    [Overload("AddSingleArray")]
    [MethodImpl]
    public extern void AddSingleArray(string name, float[] value);

    [Overload("AddSingleArrayWithFormat")]
    [MethodImpl]
    public extern void AddSingleArray(string name, float[] value, LoggingFieldFormat format);

    [Overload("AddSingleArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSingleArray(
      string name,
      float[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddDouble")]
    [MethodImpl]
    public extern void AddDouble(string name, double value);

    [Overload("AddDoubleWithFormat")]
    [MethodImpl]
    public extern void AddDouble(string name, double value, LoggingFieldFormat format);

    [Overload("AddDoubleWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDouble(string name, double value, LoggingFieldFormat format, int tags);

    [Overload("AddDoubleArray")]
    [MethodImpl]
    public extern void AddDoubleArray(string name, double[] value);

    [Overload("AddDoubleArrayWithFormat")]
    [MethodImpl]
    public extern void AddDoubleArray(string name, double[] value, LoggingFieldFormat format);

    [Overload("AddDoubleArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDoubleArray(
      string name,
      double[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddChar16")]
    [MethodImpl]
    public extern void AddChar16(string name, char value);

    [Overload("AddChar16WithFormat")]
    [MethodImpl]
    public extern void AddChar16(string name, char value, LoggingFieldFormat format);

    [Overload("AddChar16WithFormatAndTags")]
    [MethodImpl]
    public extern void AddChar16(string name, char value, LoggingFieldFormat format, int tags);

    [Overload("AddChar16Array")]
    [MethodImpl]
    public extern void AddChar16Array(string name, char[] value);

    [Overload("AddChar16ArrayWithFormat")]
    [MethodImpl]
    public extern void AddChar16Array(string name, char[] value, LoggingFieldFormat format);

    [Overload("AddChar16ArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddChar16Array(
      string name,
      char[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddBoolean")]
    [MethodImpl]
    public extern void AddBoolean(string name, bool value);

    [Overload("AddBooleanWithFormat")]
    [MethodImpl]
    public extern void AddBoolean(string name, bool value, LoggingFieldFormat format);

    [Overload("AddBooleanWithFormatAndTags")]
    [MethodImpl]
    public extern void AddBoolean(string name, bool value, LoggingFieldFormat format, int tags);

    [Overload("AddBooleanArray")]
    [MethodImpl]
    public extern void AddBooleanArray(string name, bool[] value);

    [Overload("AddBooleanArrayWithFormat")]
    [MethodImpl]
    public extern void AddBooleanArray(string name, bool[] value, LoggingFieldFormat format);

    [Overload("AddBooleanArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddBooleanArray(
      string name,
      bool[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddString")]
    [MethodImpl]
    public extern void AddString(string name, string value);

    [Overload("AddStringWithFormat")]
    [MethodImpl]
    public extern void AddString(string name, string value, LoggingFieldFormat format);

    [Overload("AddStringWithFormatAndTags")]
    [MethodImpl]
    public extern void AddString(string name, string value, LoggingFieldFormat format, int tags);

    [Overload("AddStringArray")]
    [MethodImpl]
    public extern void AddStringArray(string name, string[] value);

    [Overload("AddStringArrayWithFormat")]
    [MethodImpl]
    public extern void AddStringArray(string name, string[] value, LoggingFieldFormat format);

    [Overload("AddStringArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddStringArray(
      string name,
      string[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddGuid")]
    [MethodImpl]
    public extern void AddGuid(string name, Guid value);

    [Overload("AddGuidWithFormat")]
    [MethodImpl]
    public extern void AddGuid(string name, Guid value, LoggingFieldFormat format);

    [Overload("AddGuidWithFormatAndTags")]
    [MethodImpl]
    public extern void AddGuid(string name, Guid value, LoggingFieldFormat format, int tags);

    [Overload("AddGuidArray")]
    [MethodImpl]
    public extern void AddGuidArray(string name, Guid[] value);

    [Overload("AddGuidArrayWithFormat")]
    [MethodImpl]
    public extern void AddGuidArray(string name, Guid[] value, LoggingFieldFormat format);

    [Overload("AddGuidArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddGuidArray(
      string name,
      Guid[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddDateTime")]
    [MethodImpl]
    public extern void AddDateTime(string name, global::Windows.Foundation.DateTime value);

    [Overload("AddDateTimeWithFormat")]
    [MethodImpl]
    public extern void AddDateTime(string name, global::Windows.Foundation.DateTime value, LoggingFieldFormat format);

    [Overload("AddDateTimeWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDateTime(
      string name,
      global::Windows.Foundation.DateTime value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddDateTimeArray")]
    [MethodImpl]
    public extern void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value);

    [Overload("AddDateTimeArrayWithFormat")]
    [MethodImpl]
    public extern void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value, LoggingFieldFormat format);

    [Overload("AddDateTimeArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddDateTimeArray(
      string name,
      global::Windows.Foundation.DateTime[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddTimeSpan")]
    [MethodImpl]
    public extern void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value);

    [Overload("AddTimeSpanWithFormat")]
    [MethodImpl]
    public extern void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value, LoggingFieldFormat format);

    [Overload("AddTimeSpanWithFormatAndTags")]
    [MethodImpl]
    public extern void AddTimeSpan(
      string name,
      global::Windows.Foundation.TimeSpan value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddTimeSpanArray")]
    [MethodImpl]
    public extern void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value);

    [Overload("AddTimeSpanArrayWithFormat")]
    [MethodImpl]
    public extern void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value, LoggingFieldFormat format);

    [Overload("AddTimeSpanArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddTimeSpanArray(
      string name,
      global::Windows.Foundation.TimeSpan[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddPoint")]
    [MethodImpl]
    public extern void AddPoint(string name, Point value);

    [Overload("AddPointWithFormat")]
    [MethodImpl]
    public extern void AddPoint(string name, Point value, LoggingFieldFormat format);

    [Overload("AddPointWithFormatAndTags")]
    [MethodImpl]
    public extern void AddPoint(string name, Point value, LoggingFieldFormat format, int tags);

    [Overload("AddPointArray")]
    [MethodImpl]
    public extern void AddPointArray(string name, Point[] value);

    [Overload("AddPointArrayWithFormat")]
    [MethodImpl]
    public extern void AddPointArray(string name, Point[] value, LoggingFieldFormat format);

    [Overload("AddPointArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddPointArray(
      string name,
      Point[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddSize")]
    [MethodImpl]
    public extern void AddSize(string name, Size value);

    [Overload("AddSizeWithFormat")]
    [MethodImpl]
    public extern void AddSize(string name, Size value, LoggingFieldFormat format);

    [Overload("AddSizeWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSize(string name, Size value, LoggingFieldFormat format, int tags);

    [Overload("AddSizeArray")]
    [MethodImpl]
    public extern void AddSizeArray(string name, Size[] value);

    [Overload("AddSizeArrayWithFormat")]
    [MethodImpl]
    public extern void AddSizeArray(string name, Size[] value, LoggingFieldFormat format);

    [Overload("AddSizeArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddSizeArray(
      string name,
      Size[] value,
      LoggingFieldFormat format,
      int tags);

    [Overload("AddRect")]
    [MethodImpl]
    public extern void AddRect(string name, Rect value);

    [Overload("AddRectWithFormat")]
    [MethodImpl]
    public extern void AddRect(string name, Rect value, LoggingFieldFormat format);

    [Overload("AddRectWithFormatAndTags")]
    [MethodImpl]
    public extern void AddRect(string name, Rect value, LoggingFieldFormat format, int tags);

    [Overload("AddRectArray")]
    [MethodImpl]
    public extern void AddRectArray(string name, Rect[] value);

    [Overload("AddRectArrayWithFormat")]
    [MethodImpl]
    public extern void AddRectArray(string name, Rect[] value, LoggingFieldFormat format);

    [Overload("AddRectArrayWithFormatAndTags")]
    [MethodImpl]
    public extern void AddRectArray(
      string name,
      Rect[] value,
      LoggingFieldFormat format,
      int tags);
  }
}
