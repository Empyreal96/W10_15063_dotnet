// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataContextChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DataContextChangedEventArgs))]
  [Guid(2108067361, 2959, 20383, 161, 67, 248, 231, 120, 1, 54, 162)]
  internal interface IDataContextChangedEventArgs
  {
    object NewValue { get; }

    bool Handled { get; set; }
  }
}
