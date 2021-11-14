// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.JournalEntry
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;

namespace System.Windows.Navigation
{
  public sealed class JournalEntry : DependencyObject, IJournalEntry
  {
    internal static readonly DependencyProperty NameProperty = DependencyProperty.RegisterAttached(nameof (Name), typeof (string), typeof (JournalEntry), new PropertyMetadata(new PropertyChangedCallback(JournalEntry.NamePropertyChanged)));
    internal static readonly DependencyProperty NavigationContextProperty = DependencyProperty.RegisterAttached(nameof (NavigationContext), typeof (NavigationContext), typeof (JournalEntry), (PropertyMetadata) null);
    internal JournalEntryData _journalEntryData;

    internal JournalEntry(string name, Uri uri)
    {
      Guard.ArgumentNotNull((object) uri, nameof (uri));
      this.Name = name;
      this.PageInstance = (IPhoneApplicationPage) null;
      this._journalEntryData = new JournalEntryData();
      this._journalEntryData.Source = uri;
    }

    internal JournalEntry(JournalEntryData journalEntryData)
    {
      Guard.ArgumentNotNull((object) journalEntryData, nameof (journalEntryData));
      this.Name = journalEntryData.Source.ToString();
      this.PageInstance = (IPhoneApplicationPage) null;
      this._journalEntryData = journalEntryData;
    }

    internal string Name
    {
      get => (string) this.GetValue(JournalEntry.NameProperty);
      set => this.SetValue(JournalEntry.NameProperty, (object) value);
    }

    internal static string GetName(DependencyObject obj)
    {
      Guard.ArgumentNotNull((object) obj, nameof (obj));
      return (string) obj.GetValue(JournalEntry.NameProperty);
    }

    internal static void SetName(DependencyObject obj, string name)
    {
      Guard.ArgumentNotNull((object) obj, nameof (obj));
      obj.SetValue(JournalEntry.NameProperty, (object) name);
    }

    private static void NamePropertyChanged(
      DependencyObject depObj,
      DependencyPropertyChangedEventArgs e)
    {
    }

    internal NavigationContext NavigationContext
    {
      get => (NavigationContext) this.GetValue(JournalEntry.NavigationContextProperty);
      set => this.SetValue(JournalEntry.NavigationContextProperty, (object) value);
    }

    internal static NavigationContext GetNavigationContext(DependencyObject obj)
    {
      Guard.ArgumentNotNull((object) obj, nameof (obj));
      return (NavigationContext) obj.GetValue(JournalEntry.NavigationContextProperty);
    }

    internal static void SetNavigationContext(
      DependencyObject obj,
      NavigationContext navigationContext)
    {
      Guard.ArgumentNotNull((object) obj, nameof (obj));
      obj.SetValue(JournalEntry.NavigationContextProperty, (object) navigationContext);
    }

    public Uri Source
    {
      get => this._journalEntryData.Source;
      set
      {
        Guard.ArgumentNotNull((object) value, nameof (value));
        this._journalEntryData.Source = value;
      }
    }

    internal IPhoneApplicationPage PageInstance { get; set; }

    JournalEntryData IJournalEntry.JournalEntryData => this._journalEntryData;
  }
}
