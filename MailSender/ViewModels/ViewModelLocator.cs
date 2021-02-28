using Microsoft.Extensions.DependencyInjection;


namespace MailSender.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainVindowModel => App.Services.GetRequiredService<MainWindowViewModel>();

        public StatisticViewModel Statistic => App.Services.GetRequiredService<StatisticViewModel>();
    }
}
