// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IDataReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(3803512873, 46273, 17172, 164, 184, 251, 129, 58, 47, 39, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDataReader
  {
    uint UnconsumedBufferLength { get; }

    UnicodeEncoding UnicodeEncoding { get; set; }

    ByteOrder ByteOrder { get; set; }

    InputStreamOptions InputStreamOptions { get; set; }

    byte ReadByte();

    void ReadBytes([Out] byte[] value);

    IBuffer ReadBuffer(uint length);

    bool ReadBoolean();

    Guid ReadGuid();

    short ReadInt16();

    int ReadInt32();

    long ReadInt64();

    ushort ReadUInt16();

    uint ReadUInt32();

    ulong ReadUInt64();

    float ReadSingle();

    double ReadDouble();

    string ReadString(uint codeUnitCount);

    global::Windows.Foundation.DateTime ReadDateTime();

    global::Windows.Foundation.TimeSpan ReadTimeSpan();

    [RemoteAsync]
    DataReaderLoadOperation LoadAsync(uint count);

    IBuffer DetachBuffer();

    IInputStream DetachStream();
  }
}
