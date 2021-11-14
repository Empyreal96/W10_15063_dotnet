// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColumnDefinitionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ColumnDefinition))]
  [WebHostHidden]
  [Guid(112252712, 53316, 16582, 148, 46, 174, 96, 234, 199, 72, 81)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IColumnDefinitionStatics
  {
    DependencyProperty WidthProperty { get; }

    DependencyProperty MaxWidthProperty { get; }

    DependencyProperty MinWidthProperty { get; }
  }
}
