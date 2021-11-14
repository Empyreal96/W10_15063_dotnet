// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragOperationDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DragOperationDeferral))]
  [Guid(3128159418, 7027, 16518, 179, 211, 194, 35, 190, 234, 22, 51)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragOperationDeferral
  {
    void Complete();
  }
}
