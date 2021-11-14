// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICurrentChangingEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CurrentChangingEventArgs))]
  [Guid(356237038, 25331, 18639, 129, 131, 139, 226, 109, 227, 166, 110)]
  [WebHostHidden]
  internal interface ICurrentChangingEventArgsFactory
  {
    CurrentChangingEventArgs CreateInstance(object outer, out object inner);

    CurrentChangingEventArgs CreateWithCancelableParameter(
      bool isCancelable,
      object outer,
      out object inner);
  }
}
