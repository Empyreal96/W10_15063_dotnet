// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [Guid(69040489, 8722, 17105, 157, 250, 136, 168, 227, 3, 58, 163)]
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [ExclusiveTo(typeof (TargetedContentObject))]
  internal interface ITargetedContentObject
  {
    TargetedContentObjectKind ObjectKind { get; }

    TargetedContentCollection Collection { get; }

    TargetedContentItem Item { get; }

    TargetedContentValue Value { get; }
  }
}
