using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace EmailSender;
public class ExampleEmailService: BackgroundService
{
    private readonly ISender _email;

    public ExampleEmailService(ISender sender)
    {
        _email = sender;
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
            using var timer = new PeriodicTimer(TimeSpan.FromHours(1));
            var sw = Stopwatch.StartNew();
            while (await timer.WaitForNextTickAsync(stoppingToken))
            {
                _email.SendLetter();
            }
    }
}