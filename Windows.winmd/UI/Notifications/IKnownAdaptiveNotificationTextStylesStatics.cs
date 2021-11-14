// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IKnownAdaptiveNotificationTextStylesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(539071191, 35222, 17834, 139, 161, 212, 97, 215, 44, 42, 27)]
  [ExclusiveTo(typeof (KnownAdaptiveNotificationTextStyles))]
  internal interface IKnownAdaptiveNotificationTextStylesStatics
  {
    string Caption { get; }

    string Body { get; }

    string Base { get; }

    string Subtitle { get; }

    string Title { get; }

    string Subheader { get; }

    string Header { get; }

    string TitleNumeral { get; }

    string SubheaderNumeral { get; }

    string HeaderNumeral { get; }

    string CaptionSubtle { get; }

    string BodySubtle { get; }

    string BaseSubtle { get; }

    string SubtitleSubtle { get; }

    string TitleSubtle { get; }

    string SubheaderSubtle { get; }

    string SubheaderNumeralSubtle { get; }

    string HeaderSubtle { get; }

    string HeaderNumeralSubtle { get; }
  }
}
