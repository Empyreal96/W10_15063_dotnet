﻿// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.TransferProgress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TransferProgress
  {
    public uint BytesSent;
    public uint TotalBytesToSend;
    public uint BytesRetrieved;
    public uint TotalBytesToRetrieve;
  }
}
