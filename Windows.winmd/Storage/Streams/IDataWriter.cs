// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataWriter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1689817701, 54081, 18722, 179, 138, 221, 74, 248, 128, 140, 78)]
  public interface IDataWriter
  {
    uint UnstoredBufferLength { get; }

    UnicodeEncoding UnicodeEncoding { get; set; }

    ByteOrder ByteOrder { get; set; }

    void WriteByte(byte value);

    void WriteBytes(byte[] value);

    [Overload("WriteBuffer")]
    void WriteBuffer(IBuffer buffer);

    [Overload("WriteBufferRange")]
    void WriteBuffer(IBuffer buffer, uint start, uint count);

    void WriteBoolean(bool value);

    void WriteGuid(Guid value);

    void WriteInt16(short value);

    void WriteInt32(int value);

    void WriteInt64(long value);

    void WriteUInt16(ushort value);

    void WriteUInt32(uint value);

    void WriteUInt64(ulong value);

    void WriteSingle(float value);

    void WriteDouble(double value);

    void WriteDateTime(global::Windows.Foundation.DateTime value);

    void WriteTimeSpan(global::Windows.Foundation.TimeSpan value);

    uint WriteString(string value);

    uint MeasureString(string value);

    [RemoteAsync]
    DataWriterStoreOperation StoreAsync();

    [RemoteAsync]
    IAsyncOperation<bool> FlushAsync();

    IBuffer DetachBuffer();

    IOutputStream DetachStream();
  }
}
