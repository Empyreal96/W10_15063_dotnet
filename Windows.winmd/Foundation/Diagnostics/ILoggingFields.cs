// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ILoggingFields
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LoggingFields))]
  [Guid(3623270319, 30253, 17785, 131, 189, 82, 194, 59, 195, 51, 188)]
  internal interface ILoggingFields
  {
    void Clear();

    [Overload("BeginStruct")]
    void BeginStruct(string name);

    [Overload("BeginStructWithTags")]
    void BeginStruct(string name, int tags);

    void EndStruct();

    [Overload("AddEmpty")]
    void AddEmpty(string name);

    [Overload("AddEmptyWithFormat")]
    void AddEmpty(string name, LoggingFieldFormat format);

    [Overload("AddEmptyWithFormatAndTags")]
    void AddEmpty(string name, LoggingFieldFormat format, int tags);

    [Overload("AddUInt8")]
    void AddUInt8(string name, byte value);

    [Overload("AddUInt8WithFormat")]
    void AddUInt8(string name, byte value, LoggingFieldFormat format);

    [Overload("AddUInt8WithFormatAndTags")]
    void AddUInt8(string name, byte value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt8Array")]
    void AddUInt8Array(string name, byte[] value);

    [Overload("AddUInt8ArrayWithFormat")]
    void AddUInt8Array(string name, byte[] value, LoggingFieldFormat format);

    [Overload("AddUInt8ArrayWithFormatAndTags")]
    void AddUInt8Array(string name, byte[] value, LoggingFieldFormat format, int tags);

    [Overload("AddInt16")]
    void AddInt16(string name, short value);

    [Overload("AddInt16WithFormat")]
    void AddInt16(string name, short value, LoggingFieldFormat format);

    [Overload("AddInt16WithFormatAndTags")]
    void AddInt16(string name, short value, LoggingFieldFormat format, int tags);

    [Overload("AddInt16Array")]
    void AddInt16Array(string name, short[] value);

    [Overload("AddInt16ArrayWithFormat")]
    void AddInt16Array(string name, short[] value, LoggingFieldFormat format);

    [Overload("AddInt16ArrayWithFormatAndTags")]
    void AddInt16Array(string name, short[] value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt16")]
    void AddUInt16(string name, ushort value);

    [Overload("AddUInt16WithFormat")]
    void AddUInt16(string name, ushort value, LoggingFieldFormat format);

    [Overload("AddUInt16WithFormatAndTags")]
    void AddUInt16(string name, ushort value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt16Array")]
    void AddUInt16Array(string name, ushort[] value);

    [Overload("AddUInt16ArrayWithFormat")]
    void AddUInt16Array(string name, ushort[] value, LoggingFieldFormat format);

    [Overload("AddUInt16ArrayWithFormatAndTags")]
    void AddUInt16Array(string name, ushort[] value, LoggingFieldFormat format, int tags);

    [Overload("AddInt32")]
    void AddInt32(string name, int value);

    [Overload("AddInt32WithFormat")]
    void AddInt32(string name, int value, LoggingFieldFormat format);

    [Overload("AddInt32WithFormatAndTags")]
    void AddInt32(string name, int value, LoggingFieldFormat format, int tags);

    [Overload("AddInt32Array")]
    void AddInt32Array(string name, int[] value);

    [Overload("AddInt32ArrayWithFormat")]
    void AddInt32Array(string name, int[] value, LoggingFieldFormat format);

    [Overload("AddInt32ArrayWithFormatAndTags")]
    void AddInt32Array(string name, int[] value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt32")]
    void AddUInt32(string name, uint value);

    [Overload("AddUInt32WithFormat")]
    void AddUInt32(string name, uint value, LoggingFieldFormat format);

    [Overload("AddUInt32WithFormatAndTags")]
    void AddUInt32(string name, uint value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt32Array")]
    void AddUInt32Array(string name, uint[] value);

    [Overload("AddUInt32ArrayWithFormat")]
    void AddUInt32Array(string name, uint[] value, LoggingFieldFormat format);

    [Overload("AddUInt32ArrayWithFormatAndTags")]
    void AddUInt32Array(string name, uint[] value, LoggingFieldFormat format, int tags);

    [Overload("AddInt64")]
    void AddInt64(string name, long value);

    [Overload("AddInt64WithFormat")]
    void AddInt64(string name, long value, LoggingFieldFormat format);

    [Overload("AddInt64WithFormatAndTags")]
    void AddInt64(string name, long value, LoggingFieldFormat format, int tags);

    [Overload("AddInt64Array")]
    void AddInt64Array(string name, long[] value);

    [Overload("AddInt64ArrayWithFormat")]
    void AddInt64Array(string name, long[] value, LoggingFieldFormat format);

    [Overload("AddInt64ArrayWithFormatAndTags")]
    void AddInt64Array(string name, long[] value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt64")]
    void AddUInt64(string name, ulong value);

    [Overload("AddUInt64WithFormat")]
    void AddUInt64(string name, ulong value, LoggingFieldFormat format);

    [Overload("AddUInt64WithFormatAndTags")]
    void AddUInt64(string name, ulong value, LoggingFieldFormat format, int tags);

    [Overload("AddUInt64Array")]
    void AddUInt64Array(string name, ulong[] value);

    [Overload("AddUInt64ArrayWithFormat")]
    void AddUInt64Array(string name, ulong[] value, LoggingFieldFormat format);

    [Overload("AddUInt64ArrayWithFormatAndTags")]
    void AddUInt64Array(string name, ulong[] value, LoggingFieldFormat format, int tags);

    [Overload("AddSingle")]
    void AddSingle(string name, float value);

    [Overload("AddSingleWithFormat")]
    void AddSingle(string name, float value, LoggingFieldFormat format);

    [Overload("AddSingleWithFormatAndTags")]
    void AddSingle(string name, float value, LoggingFieldFormat format, int tags);

    [Overload("AddSingleArray")]
    void AddSingleArray(string name, float[] value);

    [Overload("AddSingleArrayWithFormat")]
    void AddSingleArray(string name, float[] value, LoggingFieldFormat format);

    [Overload("AddSingleArrayWithFormatAndTags")]
    void AddSingleArray(string name, float[] value, LoggingFieldFormat format, int tags);

    [Overload("AddDouble")]
    void AddDouble(string name, double value);

    [Overload("AddDoubleWithFormat")]
    void AddDouble(string name, double value, LoggingFieldFormat format);

    [Overload("AddDoubleWithFormatAndTags")]
    void AddDouble(string name, double value, LoggingFieldFormat format, int tags);

    [Overload("AddDoubleArray")]
    void AddDoubleArray(string name, double[] value);

    [Overload("AddDoubleArrayWithFormat")]
    void AddDoubleArray(string name, double[] value, LoggingFieldFormat format);

    [Overload("AddDoubleArrayWithFormatAndTags")]
    void AddDoubleArray(string name, double[] value, LoggingFieldFormat format, int tags);

    [Overload("AddChar16")]
    void AddChar16(string name, char value);

    [Overload("AddChar16WithFormat")]
    void AddChar16(string name, char value, LoggingFieldFormat format);

    [Overload("AddChar16WithFormatAndTags")]
    void AddChar16(string name, char value, LoggingFieldFormat format, int tags);

    [Overload("AddChar16Array")]
    void AddChar16Array(string name, char[] value);

    [Overload("AddChar16ArrayWithFormat")]
    void AddChar16Array(string name, char[] value, LoggingFieldFormat format);

    [Overload("AddChar16ArrayWithFormatAndTags")]
    void AddChar16Array(string name, char[] value, LoggingFieldFormat format, int tags);

    [Overload("AddBoolean")]
    void AddBoolean(string name, bool value);

    [Overload("AddBooleanWithFormat")]
    void AddBoolean(string name, bool value, LoggingFieldFormat format);

    [Overload("AddBooleanWithFormatAndTags")]
    void AddBoolean(string name, bool value, LoggingFieldFormat format, int tags);

    [Overload("AddBooleanArray")]
    void AddBooleanArray(string name, bool[] value);

    [Overload("AddBooleanArrayWithFormat")]
    void AddBooleanArray(string name, bool[] value, LoggingFieldFormat format);

    [Overload("AddBooleanArrayWithFormatAndTags")]
    void AddBooleanArray(string name, bool[] value, LoggingFieldFormat format, int tags);

    [Overload("AddString")]
    void AddString(string name, string value);

    [Overload("AddStringWithFormat")]
    void AddString(string name, string value, LoggingFieldFormat format);

    [Overload("AddStringWithFormatAndTags")]
    void AddString(string name, string value, LoggingFieldFormat format, int tags);

    [Overload("AddStringArray")]
    void AddStringArray(string name, string[] value);

    [Overload("AddStringArrayWithFormat")]
    void AddStringArray(string name, string[] value, LoggingFieldFormat format);

    [Overload("AddStringArrayWithFormatAndTags")]
    void AddStringArray(string name, string[] value, LoggingFieldFormat format, int tags);

    [Overload("AddGuid")]
    void AddGuid(string name, Guid value);

    [Overload("AddGuidWithFormat")]
    void AddGuid(string name, Guid value, LoggingFieldFormat format);

    [Overload("AddGuidWithFormatAndTags")]
    void AddGuid(string name, Guid value, LoggingFieldFormat format, int tags);

    [Overload("AddGuidArray")]
    void AddGuidArray(string name, Guid[] value);

    [Overload("AddGuidArrayWithFormat")]
    void AddGuidArray(string name, Guid[] value, LoggingFieldFormat format);

    [Overload("AddGuidArrayWithFormatAndTags")]
    void AddGuidArray(string name, Guid[] value, LoggingFieldFormat format, int tags);

    [Overload("AddDateTime")]
    void AddDateTime(string name, global::Windows.Foundation.DateTime value);

    [Overload("AddDateTimeWithFormat")]
    void AddDateTime(string name, global::Windows.Foundation.DateTime value, LoggingFieldFormat format);

    [Overload("AddDateTimeWithFormatAndTags")]
    void AddDateTime(string name, global::Windows.Foundation.DateTime value, LoggingFieldFormat format, int tags);

    [Overload("AddDateTimeArray")]
    void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value);

    [Overload("AddDateTimeArrayWithFormat")]
    void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value, LoggingFieldFormat format);

    [Overload("AddDateTimeArrayWithFormatAndTags")]
    void AddDateTimeArray(string name, global::Windows.Foundation.DateTime[] value, LoggingFieldFormat format, int tags);

    [Overload("AddTimeSpan")]
    void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value);

    [Overload("AddTimeSpanWithFormat")]
    void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value, LoggingFieldFormat format);

    [Overload("AddTimeSpanWithFormatAndTags")]
    void AddTimeSpan(string name, global::Windows.Foundation.TimeSpan value, LoggingFieldFormat format, int tags);

    [Overload("AddTimeSpanArray")]
    void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value);

    [Overload("AddTimeSpanArrayWithFormat")]
    void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value, LoggingFieldFormat format);

    [Overload("AddTimeSpanArrayWithFormatAndTags")]
    void AddTimeSpanArray(string name, global::Windows.Foundation.TimeSpan[] value, LoggingFieldFormat format, int tags);

    [Overload("AddPoint")]
    void AddPoint(string name, Point value);

    [Overload("AddPointWithFormat")]
    void AddPoint(string name, Point value, LoggingFieldFormat format);

    [Overload("AddPointWithFormatAndTags")]
    void AddPoint(string name, Point value, LoggingFieldFormat format, int tags);

    [Overload("AddPointArray")]
    void AddPointArray(string name, Point[] value);

    [Overload("AddPointArrayWithFormat")]
    void AddPointArray(string name, Point[] value, LoggingFieldFormat format);

    [Overload("AddPointArrayWithFormatAndTags")]
    void AddPointArray(string name, Point[] value, LoggingFieldFormat format, int tags);

    [Overload("AddSize")]
    void AddSize(string name, Size value);

    [Overload("AddSizeWithFormat")]
    void AddSize(string name, Size value, LoggingFieldFormat format);

    [Overload("AddSizeWithFormatAndTags")]
    void AddSize(string name, Size value, LoggingFieldFormat format, int tags);

    [Overload("AddSizeArray")]
    void AddSizeArray(string name, Size[] value);

    [Overload("AddSizeArrayWithFormat")]
    void AddSizeArray(string name, Size[] value, LoggingFieldFormat format);

    [Overload("AddSizeArrayWithFormatAndTags")]
    void AddSizeArray(string name, Size[] value, LoggingFieldFormat format, int tags);

    [Overload("AddRect")]
    void AddRect(string name, Rect value);

    [Overload("AddRectWithFormat")]
    void AddRect(string name, Rect value, LoggingFieldFormat format);

    [Overload("AddRectWithFormatAndTags")]
    void AddRect(string name, Rect value, LoggingFieldFormat format, int tags);

    [Overload("AddRectArray")]
    void AddRectArray(string name, Rect[] value);

    [Overload("AddRectArrayWithFormat")]
    void AddRectArray(string name, Rect[] value, LoggingFieldFormat format);

    [Overload("AddRectArrayWithFormatAndTags")]
    void AddRectArray(string name, Rect[] value, LoggingFieldFormat format, int tags);
  }
}
