﻿using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace pmcenter.Commands
{
    internal class PingCommand : ICommand
    {
        public bool OwnerOnly => true;

        public string Prefix => "ping";

        public async Task<bool> ExecuteAsync(TelegramBotClient botClient, Update update)
        {
            await botClient.SendTextMessageAsync(update.Message.From.Id,
                Vars.CurrentLang.Message_PingReply,
                ParseMode.Markdown,
                false,
                Vars.CurrentConf.DisableNotifications,
                update.Message.MessageId);
            return true;
        }
    }
}
