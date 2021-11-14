// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Globalization.SortedLocaleGrouping
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Interop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Globalization
{
  public sealed class SortedLocaleGrouping
  {
    [SecurityCritical]
    private IntPtr _slhHandle = IntPtr.Zero;
    private ReadOnlyCollection<string> _groupDisplayNames;
    private int _groupCount = -1;
    private CultureInfo _actualCulture;
    private bool? _supportsPhonetics;

    public SortedLocaleGrouping()
      : this(CultureInfo.CurrentCulture)
    {
    }

    [SecuritySafeCritical]
    public SortedLocaleGrouping(CultureInfo culture) => this.VerifyHR(LocaleGroupSessionNativeMethods.Create(culture.Name, out this._groupCount, out this._slhHandle));

    public ReadOnlyCollection<string> GroupDisplayNames
    {
      get
      {
        this.EnsureGroupDisplayNames();
        return this._groupDisplayNames;
      }
    }

    public CultureInfo CultureInfo
    {
      [SecuritySafeCritical] get
      {
        if (this._actualCulture == null)
        {
          string culture = (string) null;
          this.VerifyHR(LocaleGroupSessionNativeMethods.GetActualCulture(this._slhHandle, out culture));
          this._actualCulture = new CultureInfo(culture);
        }
        return this._actualCulture;
      }
    }

    [SecuritySafeCritical]
    public int GetGroupIndex(string itemName)
    {
      int groupIndex = -1;
      int groupIndexForString = LocaleGroupSessionNativeMethods.GetGroupIndexForString(this._slhHandle, itemName, out groupIndex);
      if (groupIndexForString == -2147024809)
        groupIndex = -1;
      else
        this.VerifyHR(groupIndexForString);
      return groupIndex;
    }

    [SecuritySafeCritical]
    private void EnsureGroupDisplayNames()
    {
      if (this._groupDisplayNames != null)
        return;
      List<string> stringList = new List<string>(this._groupCount);
      for (int groupIndex = 0; groupIndex < this._groupCount; ++groupIndex)
      {
        string groupName;
        this.VerifyHR(LocaleGroupSessionNativeMethods.GetGroupDisplayString(this._slhHandle, groupIndex, out groupName));
        stringList.Add(groupName);
      }
      this._groupDisplayNames = new ReadOnlyCollection<string>((IList<string>) stringList);
    }

    public bool SupportsPhonetics
    {
      [SecuritySafeCritical] get
      {
        if (!this._supportsPhonetics.HasValue)
          this._supportsPhonetics = new bool?(LocaleGroupSessionNativeMethods.IsPhoneticsSupported(this._slhHandle));
        return this._supportsPhonetics.Value;
      }
    }

    [SecuritySafeCritical]
    private void VerifyHR(int hresult)
    {
      if (hresult >= 0)
        return;
      Marshal.ThrowExceptionForHR(hresult);
    }

    ~SortedLocaleGrouping() => this.DestroySession();

    [SecuritySafeCritical]
    private void DestroySession()
    {
      if (!(IntPtr.Zero != this._slhHandle))
        return;
      LocaleGroupSessionNativeMethods.Destroy(this._slhHandle);
      this._slhHandle = IntPtr.Zero;
    }
  }
}
