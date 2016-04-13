using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.ExiffReader.Abstractions
{
	public class ExiffData
	{
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }
		public string Aperature { get; set; }
		public string DateTime { get; set; }
		public string ExposureTime { get; set; }
		public string Flash { get; set; }
		public string FocalLength { get; set; }
		public string Altitude { get; set; }
		public string ISO { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string Orientation { get; set; }
		public string WhiteBalance { get; set; }
	}
}
