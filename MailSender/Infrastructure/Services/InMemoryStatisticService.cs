using MailSender.Data;
using MailSender.lib.Interfaces;
using System;
using System.Diagnostics;

namespace MailSender.Infrastructure.Services
{
    internal class InMemoryStatisticService : IStatistic
    {
        private int _SenderMailCount;
        public int SenderMailCount => _SenderMailCount;

        public void MailSender() => _SenderMailCount++;

        public int SendersCount => TestData.Senders.Count;

        public int RecipientsCount => TestData.Recipients.Count;

        private readonly Stopwatch _StopwatchTimer = Stopwatch.StartNew();
        public TimeSpan UpTime => _StopwatchTimer.Elapsed;
    }
}
