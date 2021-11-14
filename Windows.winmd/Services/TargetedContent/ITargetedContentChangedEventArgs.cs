// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ExclusiveTo(typeof (TargetedContentChangedEventArgs))]
  [Guid(2580842697, 22654, 17798, 142, 247, 181, 76, 169, 69, 58, 22)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  internal interface ITargetedContentChangedEventArgs
  {
    Deferral GetDeferral();

    bool HasPreviousContentExpired { get; }
  }
}
