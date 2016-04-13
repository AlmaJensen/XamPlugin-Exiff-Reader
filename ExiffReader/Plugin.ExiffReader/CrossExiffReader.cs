using Plugin.ExiffReader.Abstractions;
using System;

namespace Plugin.ExiffReader
{
  /// <summary>
  /// Cross platform ExiffReader implemenations
  /// </summary>
  public class CrossExiffReader
  {
    static Lazy<IExiffReader> Implementation = new Lazy<IExiffReader>(() => CreateExiffReader(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static IExiffReader Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static IExiffReader CreateExiffReader()
    {
#if PORTABLE
        return null;
#else
        return new ExiffReaderImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
