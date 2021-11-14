// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(3156513993, 34871, 18370, 133, 15, 215, 157, 100, 89, 89, 38)]
  [ExclusiveTo(typeof (TargetedContentContainer))]
  internal interface ITargetedContentContainer
  {
    string Id { get; }

    DateTime Timestamp { get; }

    TargetedContentAvailability Availability { get; }

    TargetedContentCollection Content { get; }

    TargetedContentObject SelectSingleObject(string path);
  }
}
