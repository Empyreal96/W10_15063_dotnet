// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.ResponseInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResponseInformation : IResponseInformation
  {
    public extern bool IsResumable { [MethodImpl] get; }

    public extern Uri ActualUri { [MethodImpl] get; }

    public extern uint StatusCode { [MethodImpl] get; }

    public extern IMapView<string, string> Headers { [MethodImpl] get; }
  }
}
