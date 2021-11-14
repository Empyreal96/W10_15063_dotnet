// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IDynamicOverflowItemsChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (DynamicOverflowItemsChangingEventArgs))]
  [Guid(3376182127, 28526, 20035, 144, 217, 155, 70, 160, 216, 139, 159)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IDynamicOverflowItemsChangingEventArgs
  {
    CommandBarDynamicOverflowAction Action { get; }
  }
}
