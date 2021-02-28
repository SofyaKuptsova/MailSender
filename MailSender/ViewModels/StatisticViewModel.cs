using MailSender.lib.Interfaces;
using MailSender.lib.ViewModels.Base;
using System;
using System.Timers;

namespace MailSender.ViewModels
{
    class StatisticViewModel : ViewModel
    {
        private readonly IStatistic _Statistic;

        public int MailSenderCount => _Statistic.SenderMailCount;
        public int SendersCount => _Statistic.SendersCount;
        public int RecipientsCount => _Statistic.RecipientsCount;
        public TimeSpan UpTime => _Statistic.UpTime;

        public StatisticViewModel(IStatistic Statistic)
        {
            _Statistic = Statistic;

            var timer = new Timer(100);
            timer.Elapsed += (_, _) => OnPropertyChanged(nameof(UpTime));
            timer.Start();
        }
    }
}
