// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.DataReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDataReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IDataReaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DataReader : IDataReader, IClosable
  {
    [MethodImpl]
    public extern DataReader(IInputStream inputStream);

    public extern uint UnconsumedBufferLength { [MethodImpl] get; }

    public extern UnicodeEncoding UnicodeEncoding { [MethodImpl] get; [MethodImpl] set; }

    public extern ByteOrder ByteOrder { [MethodImpl] get; [MethodImpl] set; }

    public extern InputStreamOptions InputStreamOptions { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern byte ReadByte();

    [MethodImpl]
    public extern void ReadBytes([Out] byte[] value);

    [MethodImpl]
    public extern IBuffer ReadBuffer(uint length);

    [MethodImpl]
    public extern bool ReadBoolean();

    [MethodImpl]
    public extern Guid ReadGuid();

    [MethodImpl]
    public extern short ReadInt16();

    [MethodImpl]
    public extern int ReadInt32();

    [MethodImpl]
    public extern long ReadInt64();

    [MethodImpl]
    public extern ushort ReadUInt16();

    [MethodImpl]
    public extern uint ReadUInt32();

    [MethodImpl]
    public extern ulong ReadUInt64();

    [MethodImpl]
    public extern float ReadSingle();

    [MethodImpl]
    public extern double ReadDouble();

    [MethodImpl]
    public extern string ReadString(uint codeUnitCount);

    [MethodImpl]
    public extern global::Windows.Foundation.DateTime ReadDateTime();

    [MethodImpl]
    public extern global::Windows.Foundation.TimeSpan ReadTimeSpan();

    [RemoteAsync]
    [MethodImpl]
    public extern DataReaderLoadOperation LoadAsync(uint count);

    [MethodImpl]
    public extern IBuffer DetachBuffer();

    [MethodImpl]
    public extern IInputStream DetachStream();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public static extern DataReader FromBuffer(IBuffer buffer);
  }
}
