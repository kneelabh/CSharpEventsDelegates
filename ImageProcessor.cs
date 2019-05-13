namespace Events_Delegates
{
	public delegate void ApplyImageFilters(object sender, MessageArgs args);
	internal class ImageProcessor
	{
		public int Counter { get; internal set; }

		public event ApplyImageFilters OnFilter;

		internal void Process()
		{
			OnFilter(this, new MessageArgs() { source = "Filter Applied: " });
		}
	}
}