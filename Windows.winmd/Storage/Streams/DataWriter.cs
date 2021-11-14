// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.DataWriter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IDataWriterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DataWriter : IDataWriter, IClosable
  {
    [MethodImpl]
    public extern DataWriter(IOutputStream outputStream);

    [MethodImpl]
    public extern DataWriter();

    public extern uint UnstoredBufferLength { [MethodImpl] get; }

    public extern UnicodeEncoding UnicodeEncoding { [MethodImpl] get; [MethodImpl] set; }

    public extern ByteOrder ByteOrder { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void WriteByte(byte value);

    [MethodImpl]
    public extern void WriteBytes(byte[] value);

    [Overload("WriteBuffer")]
    [MethodImpl]
    public extern void WriteBuffer(IBuffer buffer);

    [Overload("WriteBufferRange")]
    [MethodImpl]
    public extern void WriteBuffer(IBuffer buffer, uint start, uint count);

    [MethodImpl]
    public extern void WriteBoolean(bool value);

    [MethodImpl]
    public extern void WriteGuid(Guid value);

    [MethodImpl]
    public extern void WriteInt16(short value);

    [MethodImpl]
    public extern void WriteInt32(int value);

    [MethodImpl]
    public extern void WriteInt64(long value);

    [MethodImpl]
    public extern void WriteUInt16(ushort value);

    [MethodImpl]
    public extern void WriteUInt32(uint value);

    [MethodImpl]
    public extern void WriteUInt64(ulong value);

    [MethodImpl]
    public extern void WriteSingle(float value);

    [MethodImpl]
    public extern void WriteDouble(double value);

    [MethodImpl]
    public extern void WriteDateTime(global::Windows.Foundation.DateTime value);

    [MethodImpl]
    public extern void WriteTimeSpan(global::Windows.Foundation.TimeSpan value);

    [MethodImpl]
    public extern uint WriteString(string value);

    [MethodImpl]
    public extern uint MeasureString(string value);

    [RemoteAsync]
    [MethodImpl]
    public extern DataWriterStoreOperation StoreAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> FlushAsync();

    [MethodImpl]
    public extern IBuffer DetachBuffer();

    [MethodImpl]
    public extern IOutputStream DetachStream();

    [MethodImpl]
    public extern void Close();
  }
}
