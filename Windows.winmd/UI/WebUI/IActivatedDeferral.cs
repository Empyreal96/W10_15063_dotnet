// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IActivatedDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  [ExclusiveTo(typeof (ActivatedDeferral))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3283949944, 42033, 18904, 167, 106, 57, 90, 78, 3, 220, 243)]
  internal interface IActivatedDeferral
  {
    void Complete();
  }
}
