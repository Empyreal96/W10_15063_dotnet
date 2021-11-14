// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.ISearchActivatedEventArgsWithLinguisticDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3231658970, 2219, 18737, 155, 124, 69, 16, 37, 242, 31, 129)]
  public interface ISearchActivatedEventArgsWithLinguisticDetails
  {
    SearchPaneQueryLinguisticDetails LinguisticDetails { get; }
  }
}
