// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IItemsChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3904132456, 32016, 16926, 190, 41, 129, 131, 154, 145, 222, 32)]
  [ExclusiveTo(typeof (ItemsChangedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsChangedEventArgs
  {
    int Action { get; }

    GeneratorPosition Position { get; }

    GeneratorPosition OldPosition { get; }

    int ItemCount { get; }

    int ItemUICount { get; }
  }
}
