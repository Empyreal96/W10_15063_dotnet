﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1540981226, 57976, 16540, 181, 34, 249, 70, 202, 37, 59, 68)]
  [ExclusiveTo(typeof (CommandBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICommandBarStatics
  {
    DependencyProperty PrimaryCommandsProperty { get; }

    DependencyProperty SecondaryCommandsProperty { get; }
  }
}
