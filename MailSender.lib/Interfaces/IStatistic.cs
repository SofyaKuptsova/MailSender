using System;

namespace MailSender.lib.Interfaces
{
    public interface IStatistic
    {
        int SenderMailCount { get; }

        void MailSender();

        int SendersCount { get; }

        int RecipientsCount { get; }

        TimeSpan UpTime { get; }
    }
}
