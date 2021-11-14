// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ChooserBase`1
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Navigation;

namespace Microsoft.Phone.Tasks
{
  public abstract class ChooserBase<TTaskEventArgs> where TTaskEventArgs : Microsoft.Phone.Tasks.TaskEventArgs
  {
    protected const string KeyValueDelimiter = "=";
    protected const string PeopleAppPackageFamilyName = "Microsoft.People_8wekyb3d8bbwe";
    protected const string PeoplePickerUri = "ms-people:picker?";
    protected const string SaveToContactUri = "ms-people:savetocontact?";
    protected const string SaveNewContactUri = "ms-people:savecontacttask?";
    protected const string ParameterContactPhoneNumber = "PhoneNumber";
    protected const string ParameterContactEmail = "Email";
    protected const string ParameterContactAddress = "Address";
    protected const string ParameterReturnRawValue = "ReturnRawValue";
    protected const string ParameterDesiredFields = "DesiredFields";
    protected const string ParameterContactName = "ContactName";
    internal GenericChooser _genericChooser;
    private EventHandler<TTaskEventArgs> _completed;

    public ChooserBase() => this.InitializeGenericChooser();

    private void InitializeGenericChooser()
    {
      this._genericChooser = new GenericChooser();
      this._genericChooser.OnInvokeReturnedHandler = new GenericChooser.GenericOnInvokeReturned(this.OnInvokeReturned);
      this._genericChooser.SerializeHandler = new GenericChooser.GenericSerialize(this.Serialize);
      this._genericChooser.DeserializeHandler = new GenericChooser.GenericDeserialize(this.Deserialize);
      this._genericChooser.GetCorrelationBlobHandler = new GenericChooser.GenericGetCorrelationBlob(this.GetCorrelationBlob);
      this._genericChooser.GetTypeStringHandler = new GenericChooser.GenericGetTypeString(this.GetTypeString);
    }

    private byte[] CorrelationBlob
    {
      get
      {
        ChooserInfo chooserInfo = new ChooserInfo();
        chooserInfo.ChooserType = ChooserInfo.ChooserTypeFromChooser((IChooser) this._genericChooser);
        if (this._completed != null)
        {
          Delegate[] invocationList = this._completed.GetInvocationList();
          chooserInfo.Observers = new Dictionary<string, bool>(invocationList.Length);
          for (int index = 0; index < invocationList.Length; ++index)
            chooserInfo.Observers[ChooserInfo.ObserverFromDelegate(invocationList[index])] = true;
        }
        MemoryStream memoryStream = new MemoryStream();
        new DataContractSerializer(typeof (ChooserInfo)).WriteObject((Stream) memoryStream, (object) chooserInfo);
        return memoryStream.ToArray();
      }
    }

    public TTaskEventArgs TaskEventArgs { get; set; }

    protected void FireCompleted(object sender, TTaskEventArgs e, Delegate fireThisHandlerOnly)
    {
      if ((object) fireThisHandlerOnly == null)
      {
        ChooserListener.DeregisterChooser();
        EventHandler<TTaskEventArgs> completed = this._completed;
        if (completed != null)
          completed(sender, e);
        PerfUtil.InfoLogMarker(MarkerEvents.TH_CHOOSER_BASE_FIRE_COMPLETED, "Completed from FAS");
      }
      else
      {
        PerfUtil.InfoLogMarker(MarkerEvents.TH_CHOOSER_BASE_FIRE_COMPLETED, "Completed from dehydration");
        ((EventHandler<TTaskEventArgs>) fireThisHandlerOnly)(sender, e);
      }
    }

    internal string GetDisplayName(ParameterPropertyBag ppb)
    {
      ParameterProperty property = ppb.GetProperty("ContactName");
      return property.ValueType == ParameterPropertyValueType.ValueType_String ? property.StringValue : string.Empty;
    }

    public event EventHandler<TTaskEventArgs> Completed
    {
      add
      {
        if (this._completed != null && Array.IndexOf<Delegate>(this._completed.GetInvocationList(), (Delegate) value) != -1)
          return;
        this._completed += value;
        ChildTaskReturnedEventArgs args = (ChildTaskReturnedEventArgs) null;
        if (!ChooserListener.IsChooserCompletePending((IChooser) this._genericChooser, (Delegate) value, out args))
          return;
        this.OnInvokeReturned(args.returnBuffer, (Delegate) value);
      }
      remove => this._completed -= value;
    }

    public virtual void Show()
    {
      PerfUtil.InfoLogMarker(MarkerEvents.TH_CHOOSER_BASE_SHOW, "ChooserBase.Show()");
      ChooserListener.RegisterChooser((IChooser) this._genericChooser);
      ChooserListener.PersistLaunchingChooserInfo((IChooser) this._genericChooser);
    }

    internal void Show(Uri appUri, ParameterPropertyBag ppb)
    {
      PerfUtil.InfoLogMarker(MarkerEvents.TH_CHOOSER_BASE_SHOW, "ChooserBase.Show()");
      ChooserListener.RegisterChooser((IChooser) this._genericChooser);
      ChooserListener.PersistLaunchingChooserInfo((IChooser) this._genericChooser);
      try
      {
        switch (this.LaunchType)
        {
          case ChooserLaunchType.ChildTask:
            ChooserHelper.LaunchChildTask(appUri, ppb);
            break;
          case ChooserLaunchType.ModernChooser:
            ChooserHelper.LaunchModernChooser(appUri, this.ChooserTargetPackageFamilyName, ppb);
            break;
        }
      }
      catch (Exception ex)
      {
        ChooserListener.DeregisterChooser();
        throw;
      }
    }

    internal void ShowUri(string uri, string parameterData)
    {
      PerfUtil.InfoLogMarker(MarkerEvents.TH_CHOOSER_BASE_SHOW, "ChooserBase.Show()");
      ChooserListener.RegisterChooser((IChooser) this._genericChooser);
      ChooserListener.PersistLaunchingChooserInfo((IChooser) this._genericChooser);
      try
      {
        ChooserHelper.LaunchUriChildTask(uri, parameterData);
      }
      catch (Exception ex)
      {
        ChooserListener.DeregisterChooser();
        throw;
      }
    }

    internal void FireOnInvokeReturned(byte[] returnBuffer) => this.OnInvokeReturned(returnBuffer, (Delegate) this._completed);

    internal byte[] GetCorrelationBlob() => this.CorrelationBlob;

    internal string GetTypeString()
    {
      Type type = this.GetType();
      return type.Assembly.FullName + type.FullName;
    }

    internal virtual void OnInvokeReturned(byte[] outputBuffer, Delegate handler)
    {
    }

    internal virtual void Serialize(Stream s)
    {
    }

    internal virtual void Deserialize(Stream s)
    {
    }

    internal virtual Uri BuildUri() => (Uri) null;

    internal virtual ParameterPropertyBag BuildParameterPropertyBag() => (ParameterPropertyBag) null;

    internal virtual ChooserLaunchType LaunchType => ChooserLaunchType.ChildTask;

    internal virtual string ChooserTargetPackageFamilyName => string.Empty;
  }
}
