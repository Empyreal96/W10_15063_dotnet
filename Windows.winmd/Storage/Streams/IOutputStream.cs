﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IOutputStream
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(2421821414, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IOutputStream : IClosable
  {
    IAsyncOperationWithProgress<uint, uint> WriteAsync(IBuffer buffer);

    IAsyncOperation<bool> FlushAsync();
  }
}
