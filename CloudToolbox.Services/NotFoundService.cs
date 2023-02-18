namespace CloudToolbox.Services
{
	public class NotFoundService
	{
		public Action OnNotFound { get; set; }

		public void NotifyNotFound()
		{
			if (NotifyNotFound != null)
			{
				OnNotFound.Invoke();
			}
		}

	}
}
