using ConsumerAgent.ViewModels;

namespace ConsumerAgent;

public partial class RetailerTrips : ContentPage
{
	public RetailerTrips()
	{
		InitializeComponent();
		BindingContext = new RetailerTripsViewModel();
	}
}