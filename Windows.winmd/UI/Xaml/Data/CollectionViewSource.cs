// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.CollectionViewSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICollectionViewSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CollectionViewSource : DependencyObject, ICollectionViewSource
  {
    [MethodImpl]
    public extern CollectionViewSource();

    public extern object Source { [MethodImpl] get; [MethodImpl] set; }

    public extern ICollectionView View { [MethodImpl] get; }

    public extern bool IsSourceGrouped { [MethodImpl] get; [MethodImpl] set; }

    public extern PropertyPath ItemsPath { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty ViewProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsSourceGroupedProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemsPathProperty { [MethodImpl] get; }
  }
}
