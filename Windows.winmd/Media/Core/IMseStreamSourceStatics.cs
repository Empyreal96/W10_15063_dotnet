// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseStreamSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MseStreamSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1180460957, 54640, 17358, 186, 33, 11, 255, 95, 63, 189, 10)]
  internal interface IMseStreamSourceStatics
  {
    bool IsContentTypeSupported(string contentType);
  }
}
