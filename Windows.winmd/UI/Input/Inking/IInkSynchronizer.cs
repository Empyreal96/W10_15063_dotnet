// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkSynchronizer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(2610864480, 44699, 17913, 132, 7, 75, 73, 59, 22, 54, 97)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InkSynchronizer))]
  internal interface IInkSynchronizer
  {
    IVectorView<InkStroke> BeginDry();

    void EndDry();
  }
}
