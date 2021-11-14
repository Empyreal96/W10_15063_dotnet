// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.Preview.ISystemNavigationCloseRequestedPreviewEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core.Preview
{
  [Guid(2211450337, 52197, 20273, 132, 20, 54, 29, 160, 70, 81, 143)]
  [ExclusiveTo(typeof (SystemNavigationCloseRequestedPreviewEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISystemNavigationCloseRequestedPreviewEventArgs
  {
    bool Handled { get; set; }

    Deferral GetDeferral();
  }
}
