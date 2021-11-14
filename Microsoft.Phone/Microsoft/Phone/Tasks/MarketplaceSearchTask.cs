// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.MarketplaceSearchTask
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;

namespace Microsoft.Phone.Tasks
{
  public sealed class MarketplaceSearchTask
  {
    private MarketplaceContentType _marketPlaceContentType;
    private string _searchTerms;

    public MarketplaceSearchTask()
    {
      this._marketPlaceContentType = MarketplaceContentType.Applications;
      this._searchTerms = (string) null;
    }

    public MarketplaceContentType ContentType
    {
      get => this._marketPlaceContentType;
      set => this._marketPlaceContentType = value;
    }

    public string SearchTerms
    {
      get => this._searchTerms;
      set => this._searchTerms = value;
    }

    public void Show()
    {
      if (!ChooserHelper.NavigationInProgressGuard((Action) (() => this.Show())))
        return;
      MarketplaceLauncher.Show((MarketplaceContent) this._marketPlaceContentType, MarketplaceOperation.Search, this._searchTerms);
    }
  }
}
