// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (AccessKeyManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Guid(1285615590, 55752, 20156, 180, 199, 48, 209, 131, 138, 129, 241)]
  internal interface IAccessKeyManagerStatics
  {
    bool IsDisplayModeEnabled { get; }

    event TypedEventHandler<object, object> IsDisplayModeEnabledChanged;

    void ExitDisplayMode();
  }
}
