// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IMediaProtectionServiceCompletion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2338114072, 53205, 17646, 162, 237, 223, 118, 1, 12, 20, 181)]
  [ExclusiveTo(typeof (MediaProtectionServiceCompletion))]
  internal interface IMediaProtectionServiceCompletion
  {
    void Complete(bool success);
  }
}
