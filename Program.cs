namespace Events_Delegates
{
	class Program
	{
		static void Main(string[] args)
		{
			var y = new ImageProcessor();
			var s = new PictureFilters();
			ApplyFilters(y, s);
			y.Process();
		}

		private static void ApplyFilters(ImageProcessor y, PictureFilters s)
		{
			y.OnFilter += s.Filter1;
			y.Counter += 1;
			y.OnFilter += s.Filter2;
			y.Counter += 1;
			y.OnFilter += s.Filter3;
			y.Counter += 1;
			y.OnFilter += s.Filter4;
			y.Counter += 1;
		}

	}
}
