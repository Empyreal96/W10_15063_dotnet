// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentAvailabilityChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ExclusiveTo(typeof (TargetedContentAvailabilityChangedEventArgs))]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(3774192934, 22823, 17488, 150, 92, 28, 235, 123, 236, 222, 101)]
  internal interface ITargetedContentAvailabilityChangedEventArgs
  {
    Deferral GetDeferral();
  }
}
