// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IActivatedOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ActivatedOperation))]
  [Guid(3063985340, 50890, 17149, 152, 24, 113, 144, 78, 69, 254, 215)]
  internal interface IActivatedOperation
  {
    ActivatedDeferral GetDeferral();
  }
}
