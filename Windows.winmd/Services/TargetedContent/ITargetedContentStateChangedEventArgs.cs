// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentStateChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [Guid(2585587517, 32883, 17430, 141, 242, 84, 104, 53, 166, 65, 79)]
  [ExclusiveTo(typeof (TargetedContentStateChangedEventArgs))]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  internal interface ITargetedContentStateChangedEventArgs
  {
    Deferral GetDeferral();
  }
}
