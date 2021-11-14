// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceStartingRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1058231973, 25408, 19908, 153, 16, 6, 142, 217, 245, 152, 248)]
  [ExclusiveTo(typeof (MediaStreamSourceStartingRequestDeferral))]
  internal interface IMediaStreamSourceStartingRequestDeferral
  {
    void Complete();
  }
}
