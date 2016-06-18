using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yusuke
{
    public class YusukeBot
    {
        private DiscordClient bot;

        public YusukeBot()
        {
            bot = new DiscordClient();

            bot.MessageReceived += Bot_MessageReceived;

            bot.Connect("MTkzNTIzNjI2NDkyODIxNTA0.CkYobA.NDpPcYN9tEVZ7NNOQX1q2cHtU8s");

            bot.Wait();


        }

        private void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;

            if (e.Message.Text == "!yusuke")
            { e.Channel.SendMessage(e.User.Mention + ": da fuck u want"); }

            if (e.Message.Text.ToLower().Contains("how are you yusuke"))
            { e.Channel.SendMessage(e.User.Mention + ": What the fuck did you just fucking say about me, you little bitch? I’ll have you know I graduated top of my class in the Navy Seals, and I’ve been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills."); }

            if (e.Message.Text.ToLower().Contains("yusuke show us your tree"))
            { e.Channel.SendFile("images/bonsai.jpg"); }
        }
    }
}
