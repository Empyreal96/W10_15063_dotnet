// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastActivatedEventArgs))]
  [Guid(3820983027, 49559, 17263, 130, 101, 6, 37, 130, 79, 141, 172)]
  internal interface IToastActivatedEventArgs
  {
    string Arguments { get; }
  }
}
