using Microsoft.AspNetCore.SignalR;

public class ClockHub : Hub<IClock>
{
    public async Task SendTimeToClients(DateTime dateTime)
    {
        await Clients.All.ShowTime(dateTime);
    }
}
public interface IClock
{
    Task ShowTime(DateTime currentTime);
}