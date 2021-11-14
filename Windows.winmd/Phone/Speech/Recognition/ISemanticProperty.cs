// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Recognition.ISemanticProperty
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Recognition
{
  [ExclusiveTo(typeof (SemanticProperty))]
  [Guid(145849457, 47094, 19601, 136, 14, 38, 132, 103, 210, 69, 158)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  internal interface ISemanticProperty
  {
    string Name { get; }

    object Value { [return: Variant] get; }

    [return: HasVariant]
    IVectorView<object> GetAllValues();
  }
}
