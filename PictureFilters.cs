using System;
using System.Threading;

namespace Events_Delegates
{
	class PictureFilters
	{
		public void Filter1(object sender, MessageArgs args) { Console.WriteLine(args.source + "1 Out of Total " + ((ImageProcessor)sender).Counter); Thread.Sleep(1000); }
		public void Filter2(object sender, MessageArgs args) {Console.WriteLine(args.source + "2 Out of Total " + ((ImageProcessor)sender).Counter); Thread.Sleep(1000); }
		public void Filter3(object sender, MessageArgs args) { Console.WriteLine(args.source + "3 Out of Total " + ((ImageProcessor)sender).Counter); Thread.Sleep(1000);}
		public void Filter4(object sender, MessageArgs args) { Console.WriteLine(args.source + "4 Out of Total " + ((ImageProcessor)sender).Counter); Thread.Sleep(1000);}
	}
}
