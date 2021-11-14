// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.LocalSearch.LocalCategories
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.LocalSearch
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (LocalSearchContract), 65536)]
  [Static(typeof (ILocalCategoriesStatics), 65536, "Windows.Services.Maps.LocalSearchContract")]
  [WebHostHidden]
  public static class LocalCategories
  {
    public static extern string BankAndCreditUnions { [MethodImpl] get; }

    public static extern string EatDrink { [MethodImpl] get; }

    public static extern string Hospitals { [MethodImpl] get; }

    public static extern string HotelsAndMotels { [MethodImpl] get; }

    public static extern string All { [MethodImpl] get; }

    public static extern string Parking { [MethodImpl] get; }

    public static extern string SeeDo { [MethodImpl] get; }

    public static extern string Shop { [MethodImpl] get; }
  }
}
