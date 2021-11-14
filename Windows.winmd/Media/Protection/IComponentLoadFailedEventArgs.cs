// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.IComponentLoadFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2509713043, 30534, 16766, 132, 149, 240, 49, 187, 197, 134, 44)]
  [ExclusiveTo(typeof (ComponentLoadFailedEventArgs))]
  internal interface IComponentLoadFailedEventArgs
  {
    RevocationAndRenewalInformation Information { get; }

    MediaProtectionServiceCompletion Completion { get; }
  }
}
