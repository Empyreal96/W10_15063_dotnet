// Decompiled with JetBrains decompiler
// Type: System.Windows.Navigation.PageResourceContentLoader
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone;
using MS.Internal;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Markup;
using System.Windows.Resources;

namespace System.Windows.Navigation
{
  internal sealed class PageResourceContentLoader : ContentLoaderBase
  {
    private static readonly Regex XClassRegex = new Regex(".*x:Class=\"(.*?)\"", RegexOptions.CultureInvariant);

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "It is being called by BeginLoad_OnUIThread().")]
    private static string GetLocalXaml(string pagePathAndName)
    {
      string stringToEscape1;
      string stringToEscape2;
      if (!pagePathAndName.Contains(";component/"))
      {
        stringToEscape1 = PageResourceContentLoader.GetEntryPointAssemblyPartSource();
        stringToEscape2 = pagePathAndName;
      }
      else
      {
        string[] strArray = pagePathAndName.Split(new string[1]
        {
          ";component"
        }, StringSplitOptions.RemoveEmptyEntries);
        stringToEscape1 = strArray.Length == 2 ? strArray[0] : throw new InvalidOperationException(Resource.PageResourceContentLoader_InvalidComponentSyntax);
        stringToEscape2 = strArray[1];
      }
      if (string.IsNullOrEmpty(stringToEscape1))
        return (string) null;
      string str = Uri.EscapeUriString(stringToEscape2);
      StreamResourceInfo resourceStream = Application.GetResourceStream(new Uri(Uri.EscapeUriString(stringToEscape1) + ";component" + str, UriKind.Relative));
      if (resourceStream == null)
        return (string) null;
      using (StreamReader streamReader = new StreamReader(resourceStream.Stream))
        return streamReader.ReadToEnd();
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "It is being called by GetLocalXaml().")]
    private static string GetEntryPointAssemblyPartSource()
    {
      string str = (string) null;
      foreach (AssemblyPart part in (PresentationFrameworkCollection<AssemblyPart>) Deployment.Current.Parts)
      {
        if (part.Source.Substring(0, part.Source.Length - 4) == Deployment.Current.EntryPointAssembly)
        {
          str = part.Source;
          break;
        }
      }
      return str.Substring(0, str.Length - 4);
    }

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "It is being called by BeginLoad_OnUIThread().")]
    private static string GetXClass(string xaml)
    {
      Match match = PageResourceContentLoader.XClassRegex.Match(xaml);
      return match == Match.Empty ? (string) null : match.Groups[1].Value;
    }

    [SecuritySafeCritical]
    [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "The parameter is being used in conditional compile.")]
    private static Type GetTypeFromAnyLoadedAssembly(string typeName)
    {
      Type type = (Type) null;
      foreach (AssemblyPart part in (PresentationFrameworkCollection<AssemblyPart>) Deployment.Current.Parts)
      {
        string assemblyShortName = Path.ChangeExtension(part.Source, (string) null);
        if (!assemblyShortName.Contains("/"))
        {
          Assembly loadedAssemblyByName = JoltHelper.GetLoadedAssemblyByName(assemblyShortName);
          if (loadedAssemblyByName != null)
            type = Type.GetType(typeName + "," + (object) loadedAssemblyByName, false);
        }
        if (type != null)
          break;
      }
      return type;
    }

    public override IAsyncResult BeginLoad(
      Uri uri,
      AsyncCallback userCallback,
      object asyncState)
    {
      PageResourceContentLoader.PageResourceContentLoaderAsyncResult result = new PageResourceContentLoader.PageResourceContentLoaderAsyncResult(uri, asyncState);
      if (uri == (Uri) null)
        result.Exception = (Exception) new ArgumentNullException(nameof (uri));
      if (SynchronizationContext.Current != null)
        SynchronizationContext.Current.Post((SendOrPostCallback) (args => PageResourceContentLoader.BeginLoad_OnUIThread(userCallback, result)), (object) null);
      else
        Deployment.Current.Dispatcher.BeginInvoke((Action) (() => PageResourceContentLoader.BeginLoad_OnUIThread(userCallback, result)));
      return (IAsyncResult) result;
    }

    public override void CancelLoad(IAsyncResult asyncResult)
    {
    }

    public override object EndLoad(IAsyncResult asyncResult)
    {
      Guard.ArgumentNotNull((object) asyncResult, nameof (asyncResult));
      if (!(asyncResult is PageResourceContentLoader.PageResourceContentLoaderAsyncResult loaderAsyncResult))
        throw new InvalidOperationException("Wrong kind of IAsyncResult passed in.  The IAsyncResult passed in should only come from PageResourceContentLoader.BeginLoad.");
      return loaderAsyncResult.Exception == null ? loaderAsyncResult.Content : throw loaderAsyncResult.Exception;
    }

    [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "We need to catch all exceptions to ensure we raise events in error cases instead, per design.")]
    private static void BeginLoad_OnUIThread(
      AsyncCallback userCallback,
      PageResourceContentLoader.PageResourceContentLoaderAsyncResult result)
    {
      if (result.Exception != null)
      {
        result.IsCompleted = true;
        userCallback((IAsyncResult) result);
      }
      else
      {
        try
        {
          string baseValue = UriParsingHelper.InternalUriGetBaseValue(result.Uri);
          string localXaml = PageResourceContentLoader.GetLocalXaml(baseValue);
          if (string.IsNullOrEmpty(localXaml))
          {
            result.Exception = (Exception) new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resource.PageResourceContentLoader_NoXAMLWasFound, (object) baseValue));
          }
          else
          {
            string xclass = PageResourceContentLoader.GetXClass(localXaml);
            if (string.IsNullOrEmpty(xclass))
            {
              try
              {
                result.Content = XamlReader.Load(localXaml);
              }
              catch (Exception ex)
              {
                result.Exception = (Exception) new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resource.PageResourceContentLoader_XAMLWasUnloadable, (object) baseValue), ex);
              }
            }
            else
            {
              Type anyLoadedAssembly = PageResourceContentLoader.GetTypeFromAnyLoadedAssembly(xclass);
              if (anyLoadedAssembly == null)
                result.Exception = (Exception) new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resource.PageResourceContentLoader_TheTypeSpecifiedInTheXClassCouldNotBeFound, (object) xclass, (object) baseValue));
              else
                result.Content = Activator.CreateInstance(anyLoadedAssembly);
            }
          }
        }
        catch (Exception ex)
        {
          result.Exception = ex;
        }
        finally
        {
          result.IsCompleted = true;
          if (userCallback != null)
            userCallback((IAsyncResult) result);
        }
      }
    }

    private class PageResourceContentLoaderAsyncResult : IAsyncResult
    {
      private object _asyncState;
      private bool _isCompleted;

      internal PageResourceContentLoaderAsyncResult(Uri uri, object asyncState)
      {
        this._asyncState = asyncState;
        this.Uri = uri;
      }

      public object AsyncState => this._asyncState;

      public WaitHandle AsyncWaitHandle => (WaitHandle) null;

      public bool CompletedSynchronously => false;

      public bool IsCompleted
      {
        get => this._isCompleted;
        internal set => this._isCompleted = value;
      }

      internal Uri Uri { get; set; }

      internal Exception Exception { get; set; }

      internal object Content { get; set; }
    }
  }
}
