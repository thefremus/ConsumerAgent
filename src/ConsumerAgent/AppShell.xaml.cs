using ConsumerAgent.Pages;

namespace ConsumerAgent;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("addtransactions", typeof(AddReceipt));
    }
}
