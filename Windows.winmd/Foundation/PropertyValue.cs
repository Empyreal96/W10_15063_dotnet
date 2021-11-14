// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.PropertyValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Static(typeof (IPropertyValueStatics), 65536, "Windows.Foundation.FoundationContract")]
  public static class PropertyValue
  {
    [MethodImpl]
    public static extern object CreateEmpty();

    [MethodImpl]
    public static extern object CreateUInt8(byte value);

    [MethodImpl]
    public static extern object CreateInt16(short value);

    [MethodImpl]
    public static extern object CreateUInt16(ushort value);

    [MethodImpl]
    public static extern object CreateInt32(int value);

    [MethodImpl]
    public static extern object CreateUInt32(uint value);

    [MethodImpl]
    public static extern object CreateInt64(long value);

    [MethodImpl]
    public static extern object CreateUInt64(ulong value);

    [MethodImpl]
    public static extern object CreateSingle(float value);

    [MethodImpl]
    public static extern object CreateDouble(double value);

    [MethodImpl]
    public static extern object CreateChar16(char value);

    [MethodImpl]
    public static extern object CreateBoolean(bool value);

    [MethodImpl]
    public static extern object CreateString(string value);

    [MethodImpl]
    public static extern object CreateInspectable(object value);

    [MethodImpl]
    public static extern object CreateGuid(Guid value);

    [MethodImpl]
    public static extern object CreateDateTime(DateTime value);

    [MethodImpl]
    public static extern object CreateTimeSpan(TimeSpan value);

    [MethodImpl]
    public static extern object CreatePoint(Point value);

    [MethodImpl]
    public static extern object CreateSize(Size value);

    [MethodImpl]
    public static extern object CreateRect(Rect value);

    [MethodImpl]
    public static extern object CreateUInt8Array(byte[] value);

    [MethodImpl]
    public static extern object CreateInt16Array(short[] value);

    [MethodImpl]
    public static extern object CreateUInt16Array(ushort[] value);

    [MethodImpl]
    public static extern object CreateInt32Array(int[] value);

    [MethodImpl]
    public static extern object CreateUInt32Array(uint[] value);

    [MethodImpl]
    public static extern object CreateInt64Array(long[] value);

    [MethodImpl]
    public static extern object CreateUInt64Array(ulong[] value);

    [MethodImpl]
    public static extern object CreateSingleArray(float[] value);

    [MethodImpl]
    public static extern object CreateDoubleArray(double[] value);

    [MethodImpl]
    public static extern object CreateChar16Array(char[] value);

    [MethodImpl]
    public static extern object CreateBooleanArray(bool[] value);

    [MethodImpl]
    public static extern object CreateStringArray(string[] value);

    [MethodImpl]
    public static extern object CreateInspectableArray(object[] value);

    [MethodImpl]
    public static extern object CreateGuidArray(Guid[] value);

    [MethodImpl]
    public static extern object CreateDateTimeArray(DateTime[] value);

    [MethodImpl]
    public static extern object CreateTimeSpanArray(TimeSpan[] value);

    [MethodImpl]
    public static extern object CreatePointArray(Point[] value);

    [MethodImpl]
    public static extern object CreateSizeArray(Size[] value);

    [MethodImpl]
    public static extern object CreateRectArray(Rect[] value);
  }
}
