/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{
  public static class extensionExtensions
  {
    public static bool Equals(this Dictionary<int, string> instance, object that)
    {
      if (!(that is Dictionary<int, string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<int, string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<int, string> DeepCopy(this Dictionary<int, string> source)
    {
      if (source == null)
        return null;

      var tmp3704 = new Dictionary<int, string>(source.Count);
      foreach (var pair in source)
        tmp3704.Add(pair.Key, (pair.Value != null) ? pair.Value : null);
      return tmp3704;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Any> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp3705 = new Dictionary<string, global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var pair in source)
        tmp3705.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp3705;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Data> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Data> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Data> source)
    {
      if (source == null)
        return null;

      var tmp3706 = new Dictionary<string, global::Yaskawa.Ext.API.Data>(source.Count);
      foreach (var pair in source)
        tmp3706.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp3706;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.ControllerEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.ControllerEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> source)
    {
      if (source == null)
        return null;

      var tmp3707 = new HashSet<global::Yaskawa.Ext.API.ControllerEventType>(source.Count);
      foreach (var elem in source)
        tmp3707.Add(elem);
      return tmp3707;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.PendantEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.PendantEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.PendantEventType> source)
    {
      if (source == null)
        return null;

      var tmp3708 = new HashSet<global::Yaskawa.Ext.API.PendantEventType>(source.Count);
      foreach (var elem in source)
        tmp3708.Add(elem);
      return tmp3708;
    }


    public static bool Equals(this HashSet<string> instance, object that)
    {
      if (!(that is HashSet<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<string> DeepCopy(this HashSet<string> source)
    {
      if (source == null)
        return null;

      var tmp3709 = new HashSet<string>(source.Count);
      foreach (var elem in source)
        tmp3709.Add((elem != null) ? elem : null);
      return tmp3709;
    }


    public static bool Equals(this List<List<double>> instance, object that)
    {
      if (!(that is List<List<double>> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<List<double>> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<List<double>> DeepCopy(this List<List<double>> source)
    {
      if (source == null)
        return null;

      var tmp3710 = new List<List<double>>(source.Count);
      foreach (var elem in source)
        tmp3710.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3710;
    }


    public static bool Equals(this List<double> instance, object that)
    {
      if (!(that is List<double> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<double> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<double> DeepCopy(this List<double> source)
    {
      if (source == null)
        return null;

      var tmp3711 = new List<double>(source.Count);
      foreach (var elem in source)
        tmp3711.Add(elem);
      return tmp3711;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.Any> DeepCopy(this List<global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp3712 = new List<global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var elem in source)
        tmp3712.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3712;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.ControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp3713 = new List<global::Yaskawa.Ext.API.ControlGroup>(source.Count);
      foreach (var elem in source)
        tmp3713.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3713;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControllerEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControllerEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControllerEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControllerEvent> DeepCopy(this List<global::Yaskawa.Ext.API.ControllerEvent> source)
    {
      if (source == null)
        return null;

      var tmp3714 = new List<global::Yaskawa.Ext.API.ControllerEvent>(source.Count);
      foreach (var elem in source)
        tmp3714.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3714;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.DataPoint> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.DataPoint> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.DataPoint> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.DataPoint> DeepCopy(this List<global::Yaskawa.Ext.API.DataPoint> source)
    {
      if (source == null)
        return null;

      var tmp3715 = new List<global::Yaskawa.Ext.API.DataPoint>(source.Count);
      foreach (var elem in source)
        tmp3715.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3715;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.LoggingEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.LoggingEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.LoggingEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.LoggingEvent> DeepCopy(this List<global::Yaskawa.Ext.API.LoggingEvent> source)
    {
      if (source == null)
        return null;

      var tmp3716 = new List<global::Yaskawa.Ext.API.LoggingEvent>(source.Count);
      foreach (var elem in source)
        tmp3716.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3716;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PendantEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PendantEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PendantEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PendantEvent> DeepCopy(this List<global::Yaskawa.Ext.API.PendantEvent> source)
    {
      if (source == null)
        return null;

      var tmp3717 = new List<global::Yaskawa.Ext.API.PendantEvent>(source.Count);
      foreach (var elem in source)
        tmp3717.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3717;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PropValues> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PropValues> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PropValues> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PropValues> DeepCopy(this List<global::Yaskawa.Ext.API.PropValues> source)
    {
      if (source == null)
        return null;

      var tmp3718 = new List<global::Yaskawa.Ext.API.PropValues>(source.Count);
      foreach (var elem in source)
        tmp3718.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3718;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.SimpleControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.SimpleControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.SimpleControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp3719 = new List<global::Yaskawa.Ext.API.SimpleControlGroup>(source.Count);
      foreach (var elem in source)
        tmp3719.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3719;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.storageInfo> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.storageInfo> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.storageInfo> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.storageInfo> DeepCopy(this List<global::Yaskawa.Ext.API.storageInfo> source)
    {
      if (source == null)
        return null;

      var tmp3720 = new List<global::Yaskawa.Ext.API.storageInfo>(source.Count);
      foreach (var elem in source)
        tmp3720.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp3720;
    }


    public static bool Equals(this List<long> instance, object that)
    {
      if (!(that is List<long> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<long> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<long> DeepCopy(this List<long> source)
    {
      if (source == null)
        return null;

      var tmp3721 = new List<long>(source.Count);
      foreach (var elem in source)
        tmp3721.Add(elem);
      return tmp3721;
    }


    public static bool Equals(this List<string> instance, object that)
    {
      if (!(that is List<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<string> DeepCopy(this List<string> source)
    {
      if (source == null)
        return null;

      var tmp3722 = new List<string>(source.Count);
      foreach (var elem in source)
        tmp3722.Add((elem != null) ? elem : null);
      return tmp3722;
    }


  }
}
