// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IKnownAdaptiveNotificationHintsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(102786456, 54422, 18813, 134, 146, 79, 125, 124, 39, 112, 223)]
  [ExclusiveTo(typeof (KnownAdaptiveNotificationHints))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IKnownAdaptiveNotificationHintsStatics
  {
    string Style { get; }

    string Wrap { get; }

    string MaxLines { get; }

    string MinLines { get; }

    string TextStacking { get; }

    string Align { get; }
  }
}
