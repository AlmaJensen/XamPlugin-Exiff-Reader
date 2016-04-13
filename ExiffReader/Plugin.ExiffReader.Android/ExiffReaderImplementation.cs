using Android.Media;
using Plugin.ExiffReader.Abstractions;
using System;


namespace Plugin.ExiffReader
{
	/// <summary>
	/// Implementation for Feature
	/// </summary>
	public class ExiffReaderImplementation : IExiffReader
	{
		public ExiffData GetExifData(string filepath)
		{
			var exif = new ExifInterface(filepath);
			var exiffdata = new ExiffData
			{
				Altitude = exif.GetAttribute(ExifInterface.TagGpsAltitude),
				Aperature = exif.GetAttribute(ExifInterface.TagAperture),
				DateTime = exif.GetAttribute(ExifInterface.TagDatetime),
				ExposureTime = exif.GetAttribute(ExifInterface.TagExposureTime),
				Flash = exif.GetAttribute(ExifInterface.TagFlash),
				FocalLength = exif.GetAttribute(ExifInterface.TagFocalLength),
				Height = Convert.ToInt32(exif.GetAttribute(ExifInterface.TagImageLength)),
				ISO = exif.GetAttribute(ExifInterface.TagIso),
				Make = exif.GetAttribute(ExifInterface.TagMake),
				Model = exif.GetAttribute(ExifInterface.TagModel),
				Orientation = exif.GetAttribute(ExifInterface.TagOrientation),
				Width = Convert.ToInt32(exif.GetAttribute(ExifInterface.TagImageWidth)),
			};
			string exiffValue = exif.GetAttribute(ExifInterface.TagGpsLatitude);
			exiffdata.Latitude = FormatAsDouble(exiffValue);
			exiffValue = exif.GetAttribute(ExifInterface.TagGpsLongitude);
			exiffdata.Latitude = FormatAsDouble(exiffValue);

			return exiffdata;
		}

		private double FormatAsDouble(string unformattedCoordinate)
		{
			if (string.IsNullOrEmpty(unformattedCoordinate))
				return 0;
			else
			{
				char divider = '/';
				char divider2 = ',';
				var strings = unformattedCoordinate.Split(divider);
				var strings1 = strings[1].Split(divider2);
				var strings2 = strings[2].Split(divider2);
				var numSeconds = (Convert.ToDouble(strings1[1]) * 60 + Convert.ToDouble(strings2[1]));
				double seconds = 0;
				try
				{
					seconds = numSeconds / 3600;
					seconds = Math.Round(seconds, 6, MidpointRounding.AwayFromZero);
				}
				catch
				{
					seconds = 0;
				}
				var coordinate = (Convert.ToDouble(strings[0])) + seconds;
				return (coordinate - 1);
			}

		}
	}
}