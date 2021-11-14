// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IRawNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(438465153, 15225, 17068, 153, 99, 34, 171, 0, 212, 240, 183)]
  [ExclusiveTo(typeof (RawNotification))]
  internal interface IRawNotification
  {
    string Content { get; }
  }
}
