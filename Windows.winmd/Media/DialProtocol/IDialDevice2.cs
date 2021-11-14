// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevice2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.DialProtocol
{
  [ExclusiveTo(typeof (DialDevice))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3132617685, 23547, 20154, 139, 50, 181, 124, 92, 94, 229, 201)]
  internal interface IDialDevice2
  {
    string FriendlyName { get; }

    IRandomAccessStreamReference Thumbnail { get; }
  }
}
