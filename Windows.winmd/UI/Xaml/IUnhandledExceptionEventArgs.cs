// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUnhandledExceptionEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [Guid(1915758236, 1358, 19699, 134, 197, 190, 144, 235, 104, 99, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UnhandledExceptionEventArgs))]
  internal interface IUnhandledExceptionEventArgs
  {
    HResult Exception { get; }

    string Message { get; }

    bool Handled { get; set; }
  }
}
