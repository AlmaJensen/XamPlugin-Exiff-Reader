using System;

namespace Plugin.ExiffReader.Abstractions
{
  /// <summary>
  /// Interface for ExiffReader
  /// </summary>
  public interface IExiffReader
  {
		ExiffData GetExifData(string FilePathWithImageName);
  }
}
