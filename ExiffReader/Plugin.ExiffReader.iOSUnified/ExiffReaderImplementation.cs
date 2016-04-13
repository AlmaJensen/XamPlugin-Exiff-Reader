using Foundation;
using Photos;
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
			var fetchResult = PHAsset.FetchAssets(new[] { NSUrl.FromString(FilePathWithImageName) }, null);
			if (fetchResult.Count == 1) 
			{
				var result = (PHAsset)fetchResult[0];
				if (result.Location != null)
				{
					exifData.Latitude = result.Location.Coordinate.Latitude;
					exifData.Longitude = result.Location.Coordinate.Longitude;

				}
				exifData.Height = (int)result.PixelHeight;
				exifData.Width = (int)result.PixelWidth;

			}
			return exifData;
		}
	}
}