// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IBindingExpression
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ExclusiveTo(typeof (BindingExpression))]
  [WebHostHidden]
  [Guid(1365907877, 49917, 19102, 159, 211, 154, 164, 47, 153, 90, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBindingExpression
  {
    object DataItem { get; }

    Binding ParentBinding { get; }

    void UpdateSource();
  }
}
