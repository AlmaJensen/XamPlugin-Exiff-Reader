using Plugin.ExiffReader.Abstractions;
using System;


namespace Plugin.ExiffReader
{
	/// <summary>
	/// Implementation for ExiffReader
	/// </summary>
	public class ExiffReaderImplementation : IExiffReader
	{
		public ExiffData GetExifData(string FilePathWithImageName)
		{
			var exifData = new ExiffData();
			var info = ExifLib.ExifReader
			throw new NotImplementedException();
		}
	}
}