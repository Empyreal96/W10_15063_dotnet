// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ISetterBaseCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(63179944, 37022, 16663, 129, 28, 164, 82, 148, 150, 189, 241)]
  [ExclusiveTo(typeof (SetterBaseCollection))]
  [WebHostHidden]
  internal interface ISetterBaseCollection : IVector<SetterBase>, IIterable<SetterBase>
  {
    bool IsSealed { get; }
  }
}
