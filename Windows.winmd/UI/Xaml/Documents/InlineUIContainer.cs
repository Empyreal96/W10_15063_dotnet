﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.InlineUIContainer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Documents
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Child")]
  public sealed class InlineUIContainer : Inline, IInlineUIContainer
  {
    [MethodImpl]
    public extern InlineUIContainer();

    public extern UIElement Child { [MethodImpl] get; [MethodImpl] set; }
  }
}
