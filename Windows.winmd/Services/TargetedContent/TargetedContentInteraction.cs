// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.TargetedContentInteraction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  public enum TargetedContentInteraction
  {
    Impression,
    ClickThrough,
    Hover,
    Like,
    Dislike,
    Dismiss,
    Ineligible,
    Accept,
    Decline,
    Defer,
    Canceled,
    Conversion,
    Opportunity,
  }
}
