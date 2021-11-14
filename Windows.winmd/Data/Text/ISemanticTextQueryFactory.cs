// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.ISemanticTextQueryFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  [ExclusiveTo(typeof (SemanticTextQuery))]
  [Guid(596378883, 63893, 17799, 135, 119, 162, 183, 216, 10, 207, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISemanticTextQueryFactory
  {
    SemanticTextQuery Create(string aqsFilter);

    SemanticTextQuery CreateWithLanguage(string aqsFilter, string filterLanguage);
  }
}
